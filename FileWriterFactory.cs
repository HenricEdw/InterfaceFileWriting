using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling
{
    static class FileWriterFactory
    {
        public static IFileWriter GetFileWriterInstance()
        {
            return new TextFileWriter();
        }
    }
}
