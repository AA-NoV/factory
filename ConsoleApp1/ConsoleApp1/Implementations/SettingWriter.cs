using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Implementations
{
    public class SettingWriter : IWriter
    {
        public SettingState Write(ISetting setting, long id)
        {
            // Реализация записи настроек
            Console.WriteLine($"Запись настроек для ID: {id}");
            return SettingState.Success; // Предположим, что запись успешна
        }
    }
}
