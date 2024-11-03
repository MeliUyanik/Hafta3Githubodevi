using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace foreachdongusuilelisteelemanlariniyazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList() { 4, 12, 15, 23 };
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                Console.WriteLine("Sayı: " + sayi);
                toplam += sayi;
            }
            Console.WriteLine("Toplam: " + toplam);
            Console.ReadKey();
        }
    }
}
