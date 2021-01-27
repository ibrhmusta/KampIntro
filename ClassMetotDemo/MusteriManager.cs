using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("musteri basariyla eklendi: " + musteri.Ad + " " + musteri.Soyad);
            Console.WriteLine("*************************");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Musteri Ad Soyad: " + musteri.Ad + " " + musteri.Soyad);
                Console.WriteLine("Musteri Id:" + musteri.Id);
                Console.WriteLine("Musteri Yas: " + musteri.Yas);
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Musteri basariyla silindi: " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
