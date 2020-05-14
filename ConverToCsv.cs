using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Tugas6
{
    public class ConverToCsv : IPrinterWindows
    {
        public void Convert(Show sho)
        {
            Console.WriteLine("LaserJe Display Dimension : 12*12");
        }

        public void Convert(Print pri)
        {
            Console.WriteLine("LaserJe Display Dimension : 12*12");
        }
}
}
