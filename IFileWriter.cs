using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling
{
    interface IFileWriter
    {
        string Extension { get; }

        string WriteToFile(string fileName);

    }
}
