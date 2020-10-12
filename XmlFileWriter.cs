using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling
{
    class XmlFileWriter : IFileWriter
    {
        public string Extension { get { return ".xml"; } }

        public string WriteToFile(string fileName)
        {
            return $"Har skrivit {fileName + Extension}-fil till disk!";
        }
    }
}
