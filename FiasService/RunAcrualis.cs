using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;

namespace FiasService
{
    public partial class RunAcrualis : ServiceBase
    {
        private Timer time;
        private bool isrun = false;

        private BackgroundWorker work;

        public RunAcrualis()
        {
            
            InitializeComponent();

            EventLoger.configEventlog("Fias Data MS Log", "Fias Data MS");
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                EventLoger.setEvent("Служба успесно Запущена!", EventLogEntryType.SuccessAudit);
                time = new Timer()
                {
                    Interval = (double)(60 * 1000) * 10,
                    AutoReset = true,
                    Enabled = true
                };

                time.Elapsed += new ElapsedEventHandler(time_Elapsed);
                time.Start();
            }
            catch (Exception ex)
            {
                EventLoger.setEvent(ex.Message, EventLogEntryType.Error);
                OnStop();

            }
        }

        void time_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (DateTime.Now.Hour != global::FiasService.Properties.Settings.Default.Hour) isrun = false;

            if (DateTime.Now.Hour == global::FiasService.Properties.Settings.Default.Hour && !isrun)
            {
                EventLoger.setEvent(string.Format("Запуск задания на выполнение (статус запуска : {0})!", !isrun ? "не запускался" : "уже был запущен"), EventLogEntryType.SuccessAudit);
                isrun = true;

                try
                {
                    work = new BackgroundWorker() { WorkerSupportsCancellation = true };

                    work.DoWork += new DoWorkEventHandler(work_DoWork);
                    work.RunWorkerCompleted += delegate(object s1, RunWorkerCompletedEventArgs eArgs)
                    {
                        EventLoger.setEvent("Задача выполнена!", EventLogEntryType.Information);
                    };

                    work.RunWorkerAsync();

                }
                catch { }
                

            }
        }

        void work_DoWork(object sender, DoWorkEventArgs e)
        {
            EngineringProcess.DownloadFirs();
        }

        protected override void OnStop()
        {
            EventLoger.setEvent("Служба успесно Остановлена!", EventLogEntryType.SuccessAudit);
            time.Stop();
            time = null;
        }
    }
}