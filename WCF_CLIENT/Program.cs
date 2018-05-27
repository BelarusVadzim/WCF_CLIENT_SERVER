using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF_INTERFACE_TEST;

namespace WCF_CLIENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri tcpUri = new Uri("http://localhost:1050/TestService");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<IMyObject> factory = new ChannelFactory<IMyObject>(binding, address);
            IMyObject service = factory.CreateChannel();

            String pressedKey = string.Empty;

            while(pressedKey != "x")
            {
                var key = Console.ReadKey();
                try
                {
                    pressedKey = service.GetConsoleKey(key);
                }
                catch(Exception ex) { Console.WriteLine(ex.Message); continue; }
                Console.WriteLine(pressedKey);
            }
        }
    }
}
