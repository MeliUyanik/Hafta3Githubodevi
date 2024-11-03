using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazirmetodkullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
            int kelimeSayisi = kelimeler.Length;
            Console.WriteLine("Kelime sayısı: " + kelimeSayisi);
            Console.ReadKey();
        }
    }
}
