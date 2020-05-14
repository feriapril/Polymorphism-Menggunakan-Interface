using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace Tugas6
{
    public interface IPrinterWindows
    {
        void Convert(Show sho);
        void Convert(Print pri);
    }
    public class Show 
    {

    }
    public class Print
    {
        
    }
    public class ConvertToJson : IPrinterWindows
    {
        public void Convert(Show sho)
        {
            Console.WriteLine("Epsone Display Dimension : 10*11");
        }

        public void Convert(Print pri)
        {
            Console.WriteLine("Epsone Printer Printing....\n");
        }
    }
}
