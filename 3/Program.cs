using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Logs/3 задача.txt";
            using (StreamReader sr = new StreamReader(file))
            {
                int n = sr.ReadToEnd().Length;
                Console.WriteLine("Количество символов: {0}", n);
            }
            using (StreamReader sr = new StreamReader(file))
            {
                string a = sr.ReadToEnd();
                int n = 1;
                foreach (char c in a)
                {
                    if (c == '\n')
                    {
                        n++;
                    }
                }
                Console.WriteLine("Количество строк: {0}", n);
            }
            using (StreamReader sr = new StreamReader(file))
            {
                string a = sr.ReadToEnd();
                string[] b = a.Split();
                int m = 1;
                foreach (char c in a)
                {
                    if (c == ' ' || c == '\n')
                    {
                        m++;
                    }
                }
                //int k = m
                Console.WriteLine("Количество слов: {0}", m);
            }
            Console.ReadKey();
        }
    }
}
