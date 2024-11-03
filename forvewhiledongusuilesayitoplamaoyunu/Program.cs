using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forvewhiledongusuilesayitoplamaoyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            int toplam = 0;
            Console.WriteLine("Toplamlarını bulmak istediğinzi pozitif tam sayılar girin(çıkmak için 0'a basın): ");
            while (true)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 0)
                {
                    break;
                }
                else if (sayi > 0)
                {
                    sayilar.Add(sayi);
                    toplam += sayi;
                }
            }
            Console.WriteLine("Girdiğiniz sayıların toplamı: " + toplam);
            Console.WriteLine("Girdiğiniz sayılar: ");
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadKey();
        }
    }
}
