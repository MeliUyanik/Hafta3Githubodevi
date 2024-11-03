using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arraylistilealfabetiksiralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList isimler = new ArrayList();
            
            Console.WriteLine("Birinci ismi giriniz: ");
            String isim1 = Console.ReadLine();
            isimler.Add(isim1);
            Console.WriteLine("İkinci ismi giriniz: ");
            String isim2 = Console.ReadLine();
            isimler.Add(isim2);
            Console.WriteLine("Üçüncü ismi giriniz: ");
            String isim3 = Console.ReadLine();
            isimler.Add(isim3);
            Console.WriteLine("Dördüncü ismi giriniz: ");
            String isim4 = Console.ReadLine();
            isimler.Add(isim4);
            Console.WriteLine("Beşinci ismi giriniz: ");
            String isim5 = Console.ReadLine();
            isimler.Add(isim5);
            
            isimler.Sort();
            Console.WriteLine("Girilen isimlerin alfabetik sayıya göre sıralanmış hali: ");
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.ReadKey();
        }
    }
}
