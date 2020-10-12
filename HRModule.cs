using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling
{
    class HRModule 
    {
        public IFileWriter FileWriter { get; set; }

        public HRModule()
        {
            FileWriter = FileWriterFactory.GetFileWriterInstance();
        }
    }
}
