using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling
{
    class TextFileWriter : IFileWriter
    {
        public string Extension { get { return ".txt"; } }

        public string WriteToFile(string fileName)
        {
            //Vi fejkar att vi skriver ned till en textfil här
            //och returnerar "sökvägen" till filen.
            return $"Har skrivit {fileName + Extension}-fil till disk!";
        }
    }
}
