using System;

namespace Tugas6
{
    class Program
    {
        static void Main(string[] args)
        {
            Show sho = new Show();
            Print pri = new Print();
            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Cannon");
            Console.WriteLine("3. LaserJet\n");
            Console.WriteLine("Nomor Format Data [1..3]: ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            IPrinterWindows convert;

            if (nomorFormatData == 1)
                convert = new ConvertToJson();
            else if (nomorFormatData == 2)
                convert = new ConvertToXml();
            else
                convert = new ConverToCsv();

            convert.Convert(sho);
            convert.Convert(pri);
            Console.ReadKey();
        }
    }
}
