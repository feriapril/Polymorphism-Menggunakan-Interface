using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Tugas6
{
    public class ConvertToXml : IPrinterWindows
    {
        public void Convert(Show sho)
        {
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Show));
                serializer.Serialize(writer, sho);

                string xml = writer.ToString();

                Console.WriteLine("Cannon Display Dimension : 9.5*12");
                Console.WriteLine(xml);
            };
        }

        public void Convert(Print pri)
        {
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Show));
                serializer.Serialize(writer, pri);

                string xml = writer.ToString();

                Console.WriteLine("Cannon Printer Printing....\n");
                Console.WriteLine(xml);
            };
        }
    }
}
