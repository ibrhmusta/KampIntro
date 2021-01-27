using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "İbrahim";
            musteri1.Soyad = "Usta";
            musteri1.Id = 405594;
            musteri1.Yas = 20;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Salih";
            musteri2.Soyad = "Malkoç";
            musteri2.Id = 405792;
            musteri2.Yas = 25;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Hasan";
            musteri3.Soyad = "Develi";
            musteri3.Id = 405122;
            musteri3.Yas = 27;

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Bilal Şahin";
            musteri4.Soyad = "Usta";
            musteri4.Id = 405146;
            musteri4.Yas = 23;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Yas);
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
        } 
    }
}
