using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SomeSetting : ISetting
    {
        // Определите необходимые свойства и методы для настроек
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
