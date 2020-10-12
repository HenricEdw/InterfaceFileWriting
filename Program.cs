using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            FinanceModule finance = new FinanceModule();

            HRModule hr = new HRModule();

            Console.WriteLine($"This is our finance module writing files: {finance.FileWriter.WriteToFile("FinanceFile")}");

            Console.WriteLine($"This is our HR module writing files: {hr.FileWriter.WriteToFile("HRFile")}");

            Console.Read();
        }
    }
}
