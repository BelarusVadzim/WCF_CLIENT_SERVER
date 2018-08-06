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
            Proxy.SendNotification("Are you ready?");
            Console.ReadLine();
        }
        public static INotificationServices Proxy
        {
            get
            {
                var ctx = new InstanceContext(new NotificationServiceCallBack());
                return new DuplexChannelFactory<INotificationServices>(ctx, "WSDualHttpBinding_INotificationServices").CreateChannel();
            }
        }
    }

    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class NotificationServiceCallBack : INotificationServiceCallBack
    {
        public void OnNotificationSend(string message)
        {
            Console.WriteLine("NotificationServiceCallBack" + message);
        }

        public void SendCallBack(string Message)
        {
            Console.WriteLine("Сработал тестовый метод: " + Message);
        }
    }
}
