using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product) //(int x) gibi düşün, product türü ver.
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        /*public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        } */
        //VOID, TOPLA2 İŞLEMİNİ YAPIP YAZDIRIYOR, EMİR KİPİ GİT YAP BİTİR. INT İSE BAŞKA ŞEYLER ÜZERİNDE ÇALIŞACAKSAN DA KULLANILIR MİSAL TOPLAMA DIŞINDA ÇARPMA GİBİ. (?)
        


    }
}
