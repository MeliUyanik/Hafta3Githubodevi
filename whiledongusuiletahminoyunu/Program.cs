using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiledongusuiletahminoyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sayi = random.Next(1, 11);
            int tahmin = 0;
            Console.WriteLine("1 ile 10 arasında bir sayı seçtim tahmin edin.");
            while (true)
            {
                Console.WriteLine("Tahmininiz: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin == sayi)
                {
                    Console.WriteLine("Doğru tamin tebrikler!");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış tahmin tekrar deneyin.");
                }
            }
            Console.ReadKey();
        }
    }
}
