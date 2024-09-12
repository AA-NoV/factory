using ConsoleApp1.Implementations;
using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factories
{
    public abstract class SettingFactory
    {
        public IWriter CreateWriter()
        {
            return new SettingWriter();
        }

        public abstract IReader CreateReader();
    }
}
