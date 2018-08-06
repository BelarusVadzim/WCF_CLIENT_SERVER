using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace WCF_INTERFACE_TEST
{
    [ServiceContract(CallbackContract = typeof(INotificationServiceCallBack))]
    public interface INotificationServices
    {
        [OperationContract]
        void SendNotification(string message);
    }

    public interface INotificationServiceCallBack
    {
        [OperationContract(IsOneWay = true)]
        void OnNotificationSend(string message);

        [OperationContract(IsOneWay = true)]
        void SendCallBack(string Message);
    }
}
