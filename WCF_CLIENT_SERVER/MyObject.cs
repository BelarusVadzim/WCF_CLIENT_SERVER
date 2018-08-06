using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF_INTERFACE_TEST;

namespace WCF_SERVER
{


    public class NotificationService : INotificationServices
    {
        public NotificationService()
        {
            Proxy.SendCallBack("Тестовый ответ от сервера");
        }

        public INotificationServiceCallBack Proxy
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<INotificationServiceCallBack>();
            }
        }

        public void SendNotification(string message)
        {
            Console.WriteLine("\nClient says :" + message);
            Proxy.OnNotificationSend("Yes");
        }
    }
}
