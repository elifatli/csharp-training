using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UygulamaClass;

namespace UygulamaClass
{

    //product class: name, price, description
    //sınırsız sayısa ürün bilgisini alıp bir dizi içinde saklayınız.
    //ürün adetini kullanıcı belirlesin.
    //eklenen ürünler listelensin.

    class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("adet: ");
                int adet;
                if (!int.TryParse(Console.ReadLine(),out adet))
                    throw new Exception("geçersiz adet");


            Product[] products = new Product[adet];
            

            int i = 0;
            Product prd;
            
                do
                {
                    prd = new Product();

                    Console.Write("ürün adı: ");
                    prd.name = Console.ReadLine();

                    Console.Write("ürün fiyatı: ");
                    prd.price = double.Parse(Console.ReadLine());

                    Console.Write("açıklama: ");
                    prd.description = Console.ReadLine();

                    products[i] = prd;
                    i++;


                } while (adet > i);

                //for (int a = 0; a <products.Length; a++)
                //{
                //   Console.WriteLine($"ürün adı: {products[a].name} ürün fiyat: {products[a].price} açıklama: {products[a].description}");
                //}

                foreach (var urun in products)
                {
                    Console.WriteLine($"ürün adı: {urun.name} ürün fiyat: {urun.price} açıklama: {urun.description}");
                }

            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
