using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Esma", "Nuri", "Songül", "Esra" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //new yeni referans adresi demek (yani isimlerin adresi = yeni bir adres) 15-18 satırları arraylerde yapamazsın. bu yüzden koleksiyonlar var.
            //isimler[4] = "Falanca"; //direk sona ekleniyor (esma , nuri , songül , esra iken bu şekilde yazarsan ..,..,.., falanca olur.
            //Console.WriteLine(isimler[4]); //bunu yazdırır ama
            //Console.WriteLine(isimler[0]); //bunu yazdırmaz boş döndürür, görünür.
                                                                                       //CTRL K + CTRL C SEÇTİĞİN SATIRLARA TEK TEK // KOYAR!

            List<string> isimler2 = new List<string> { "Esma", "Nuri", "Songül", "Esra" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Falanca");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            
        }
    }
}
