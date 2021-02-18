using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public partial class Program
    {
        static void stats(string playerw)
        {
            StreamWriter ekle = File.AppendText("C:\\stats.txt");

            ekle.WriteLine(playerw);

            ekle.Close();

        }
    }
}