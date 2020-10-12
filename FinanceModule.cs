using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling
{
    class FinanceModule
    {
        public IFileWriter FileWriter { get; set; }

        public FinanceModule()
        {
            FileWriter = FileWriterFactory.GetFileWriterInstance();
        }
    }
}
