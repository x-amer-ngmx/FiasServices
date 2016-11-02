using System.ServiceProcess;
namespace FiasService
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        private static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new RunAcrualis()
            };
            ServiceBase.Run(ServicesToRun);
            
        }
    }
}