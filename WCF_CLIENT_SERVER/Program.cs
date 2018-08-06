using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF_INTERFACE_TEST;

namespace WCF_SERVER
{
    class Program
    {
        static void Main(string[] args)
        {
            var svcHost = new ServiceHost(typeof(NotificationService));
            svcHost.Open();
            Console.WriteLine("Available Endpoints :\n");
            svcHost.Description.Endpoints.ToList().ForEach(endpoint => Console.WriteLine(endpoint.Address.ToString()));
            Console.ReadLine();
            svcHost.Close();
        }
    }
}
