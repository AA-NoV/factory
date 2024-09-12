using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factories
{
    public class SettingNotebookFactory : SettingFactory
    {
        public override IReader CreateReader()
        {
            return new NotebookSettingReader();
        }
    }
}
