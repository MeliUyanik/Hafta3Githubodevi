using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhiledongusuilebasithesapmakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string islem;
            do
            {
                Console.WriteLine("Yapmak istediğiniz işlem türünü seçiniz (+, -, *, /), çıkış yapmak için çıkış yazınız");
                islem = Console.ReadLine();
                if (islem != "çıkış")
                {
                    Console.Write("Birinci sayıyı giriniz: ");
                    int sayi1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("İkinici sayıyı giriniz: ");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());
                    int sonuc = 0;

                    if (islem == "+")
                    {
                        sonuc = sayi1 + sayi2;
                    }
                    else if (islem == "-")
                    {
                        sonuc = sayi1 - sayi2;
                    }
                    else if (islem == "*")
                    {
                        sonuc = sayi1 * sayi2;
                    }
                    else if (islem == "/")
                    {
                        if (sayi2 == 0)
                        {
                            Console.WriteLine("Hata! Bir sayı sıfıra bölünemez.");
                        }
                        else
                        {
                            sonuc = sayi1 / sayi2;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz işlme türü");
                    }
                    if (islem == "+" || islem == "-" || islem == "*" || islem == "/" && sayi2 != 0)
                    {
                        Console.WriteLine("Sonuç" + sonuc);
                    }
                    Console.ReadKey();
                }
            } while (islem != "çıkış");
            Console.WriteLine("Çıkış yapıldı.");
        }
    }
}
