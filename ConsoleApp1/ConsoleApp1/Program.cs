using ConsoleApp1.Factories;
using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SettingFactory factory = new SettingNotebookFactory();
            IWriter writer = factory.CreateWriter();
            IReader reader = factory.CreateReader();

            // Чтение настроек
            UserSettings settings = await reader.Read();

            // Запись настроек
            SomeSetting setting = new SomeSetting { Name = "Example", Value = "Value" };
            SettingState state = writer.Write(setting, 1);
            Console.WriteLine($"Статус записи: {state}");

            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
