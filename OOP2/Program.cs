using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Esma Nur";
            musteri1.Soyadi = "KILIÇ";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri sırf bunlar birbirine benziyor bunlar birbirlerinin yerine kullanılamazlar.
            //SOLID'den L harfi bunu açıklar.

            Musteri musteri3 = new GercekMusteri(); // new gördüğünde bellekteki referans numarası diye oku.
            Musteri musteri4 = new TuzelMusteri(); // yani müşteri hem gerçek hem de tüzelin referans numarasını tutar.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
