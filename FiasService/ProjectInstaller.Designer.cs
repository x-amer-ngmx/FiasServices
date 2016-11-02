namespace FiasService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstallerFias = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerFias = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallerFias
            // 
            this.serviceProcessInstallerFias.Account = System.ServiceProcess.ServiceAccount.NetworkService;
            this.serviceProcessInstallerFias.Password = null;
            this.serviceProcessInstallerFias.Username = null;
            // 
            // serviceInstallerFias
            // 
            this.serviceInstallerFias.Description = "Актуализатор базы адресов!";
            this.serviceInstallerFias.DisplayName = "Fias Data MS";
            this.serviceInstallerFias.ServiceName = "DataFiasMRG";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallerFias,
            this.serviceInstallerFias});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallerFias;
        private System.ServiceProcess.ServiceInstaller serviceInstallerFias;
    }
}