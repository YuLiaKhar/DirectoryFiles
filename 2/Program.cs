using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string file = "Logs/Log.txt";
            if (!File.Exists(file))
            {
                File.Create(file);
            }
            Random r = new Random();
            int sum = 0;
            StreamWriter sw = new StreamWriter(file);
            for (int i = 0; i < 10; i++)
            {
                int a = r.Next(0, 100);
                sw.WriteLine(a);
            }
            sw.Close();
            using (StreamReader sr = new StreamReader(file))
            {
                for (int i = 0; i < 10; i++)
                {
                    int n = Convert.ToInt32(sr.ReadLine());
                    sum += n;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
