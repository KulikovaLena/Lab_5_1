using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            float S = 0;
            Console.WriteLine("Vvedite 7 celochislennih znacheniy");
            for (int i = 0; i < 7; i++)
            {
                int n;
                n = Convert.ToInt32(Console.ReadLine());
                array[i] = n;
                S += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("{0:f2} - srednee arifmeticheskoe", S/7);
            Console.ReadKey();
        }
    }
}
