using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Загрузки/текстуры";
            string[] path1 = Directory.GetDirectories(path);
            string[] path2 = Directory.GetFiles(path);
            Console.WriteLine("Подкаталоги: ");
            for (int i = 0; i < path1.Length; i++)
            {
                Console.WriteLine(path1[i]);
            }
            Console.WriteLine("Содержимое: ");
            for (int i = 0; i < path2.Length; i++)
            {
                Console.WriteLine(path2[i]);
            }
            Console.WriteLine("Содержимое всех подкаталогов: ");
            for (int i = 0; i < path1.Length; i++)
            {
                string[] n = Directory.GetFiles(path1[i]);
                for (int j = 0; j < n.Length; j++)
                {
                    Console.WriteLine(n[j]);
                }
            }
            Console.ReadKey();
        }
    }
}
