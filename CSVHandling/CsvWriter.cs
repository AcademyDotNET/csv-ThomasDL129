using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSVHandling
{
    class CsvWriter
    {
        public static void writeCsvNoStreamWriter()
        {
            string filepath = @"C:\Users\Jesse Viskens\Desktop\DemoData.csv";
            StringBuilder output = new StringBuilder();
            output.AppendLine("1,2,3");
            output.AppendLine("4,5,6");

            File.WriteAllText(filepath, output.ToString());
            File.AppendAllText(filepath, output.ToString());
        }
        public static void writeCsvStreamWriter()
        {
            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\Jesse Viskens\Desktop\DemoData.csv"))
            {
                streamWriter.WriteLine("1,2,3");
                streamWriter.WriteLine("4,5,6");
            }
        }
    }
}
