using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");           
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        //public int Topla(int sayi1, int sayi2)    => çıkan sonucu eğer program için başka noktalarda kullanac isek
        //{                                            return kullanmalıyız                   
        //    return sayi1 + sayi2;
        //}
        //                                      
        //public void Topla2(int sayi1, int sayi2)   =>   void emir  kipi
        //{
        //    Console.WriteLine(sayi1+);
        //}
    }
}
