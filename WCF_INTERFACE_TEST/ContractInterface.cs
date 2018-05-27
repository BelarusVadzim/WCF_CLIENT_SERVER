using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace WCF_INTERFACE_TEST
{
    [ServiceContract] // Говорим WCF что это интерфейс для запросов сервису
    public interface IMyObject
    {
        [OperationContract] // Делегируемый метод.
        string GetCommandString(int i);

        [OperationContract] // Делегируемый метод.
        string GetConsoleKey(ConsoleKeyInfo key);
    }
}
