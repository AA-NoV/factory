using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Implementations
{
    public class SettingReader : IReader
    {
        public async Task<UserSettings> Read()
        {
            Console.WriteLine("Чтение настроек...");
            await Task.Delay(1000);
            return new UserSettings();
        }
    }
}
