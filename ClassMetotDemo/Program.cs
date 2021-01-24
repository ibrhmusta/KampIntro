using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();

            musteri1.Ad = "Ferdi";
            musteri1.Soyad = "Tayfur";

            musteri2.Ad = "İbrahim";
            musteri2.Soyad = "Usta";

            MusteriManager musterimanager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] {musteri1,musteri2};
            musterimanager.Add(musteriler);
        }
    }
}
