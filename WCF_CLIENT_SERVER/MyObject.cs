﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_INTERFACE_TEST;

namespace WCF_SERVER
{
    class MyObject : IMyObject
    {
        public string GetCommandString(int i)
        {
            switch (i)
            {
                case 1:// TODO: Реализация старта выполнения ваших команд
                    return "Начало обработки";

                case 0:// TODO: Реализация остановки выполнения ваших команд
                    return "Конец обработки";

                default:// TODO: Выполнение какой-либо вашей команды
                    return "Получил " + i.ToString();
            }
        }

        public string GetConsoleKey(ConsoleKeyInfo keyInfo)
        {
            return keyInfo.KeyChar.ToString();
        }
    }
}