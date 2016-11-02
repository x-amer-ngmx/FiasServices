using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestNalogWebService.nalog;

namespace TestNalogWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запуск службы");

            nalog.DownloadServiceSoapClient client = new DownloadServiceSoapClient();
            var res = client.GetLastDownloadFileInfo();

            var f = res.FiasCompleteXmlUrl;
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
