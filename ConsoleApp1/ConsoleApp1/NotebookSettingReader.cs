using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NotebookSettingReader : IReader
    {
        public async Task<UserSettings> Read()
        {
            // Реализация чтения настроек
            Console.WriteLine("Чтение настроек для Notebook...");
            await Task.Delay(1000); // Симуляция задержки
            return new UserSettings(); // Возвращаем новые настройки пользователя
        }
    }
}
