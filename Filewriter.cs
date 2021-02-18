using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public partial class Program
    {
        static void statsTxt()
        {
            string dosyaYolu = @"C:\stats.txt";

            FileStream fs = new FileStream(dosyaYolu, FileMode.OpenOrCreate, FileAccess.Write);
           
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("stats");
            sw.Flush();
            sw.Close();
            fs.Close();

        }
    }
}