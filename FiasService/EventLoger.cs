using System.Diagnostics;

namespace FiasService
{
    class EventLoger
    {
        private static EventLog log = new EventLog();

        public static void configEventlog(string nameLog, string serviceName)
        {
            log = new EventLog()
            {
                Source = serviceName,
                Log = nameLog,

            };
            ((System.ComponentModel.ISupportInitialize)(log)).BeginInit();
            if (!EventLog.SourceExists(serviceName))
            {
                EventLog.CreateEventSource(serviceName, nameLog);
            }
            ((System.ComponentModel.ISupportInitialize)(log)).EndInit();
        }

        public static void setEvent(string message, EventLogEntryType type)
        {
            log.WriteEntry(message, type);
        }

    }
}
