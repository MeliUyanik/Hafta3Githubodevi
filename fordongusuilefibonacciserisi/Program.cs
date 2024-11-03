using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusuilefibonacciserisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç tane fibonacci sayısı görmek istediğinizi giriniz: ");
            int s = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            Console.WriteLine("Fibonacci Serisi: ");
            for (int i = 1; i <= s; i++)
            {
                Console.WriteLine(a + " ");
                int temp = a + b; a = b; b = temp;
            }
            Console.ReadKey();

        }
    }
}
