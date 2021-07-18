using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Başlagıç değeri");
            int baslangic = int.Parse(Console.ReadLine());

            Console.Write("Bitiş değeri");
            int bitis = int.Parse(Console.ReadLine());

            Console.Write("Artış Miktarı");
            int artis = int.Parse(Console.ReadLine());

           
            int sayac = 0;
            int toplam = 0;
            int carpma = 1;
            int karesi = 1;
            


            for (int i = baslangic; i <= bitis; i = i + artis)
            {
                sayac++;
                toplam += i;


                if (i%2==0)
                {
                    Console.WriteLine("sayı çifttir.");

                }
                else
                {
                    Console.WriteLine("sayı tektir.");
                }

                Console.WriteLine("{1}.sayı : {0}",i, sayac);
            }

            Console.WriteLine("Toplam değer:{0}", toplam);
            Console.ReadLine();

            for (int i = baslangic; i <= bitis; i= i+artis)
            {
                sayac++;
                carpma *= i;
                 

                Console.WriteLine("{1}.sayı: {0}", i, sayac);

            }
            Console.WriteLine("Çarpım değer: {0}", carpma);
            Console.ReadLine();

            for (int i = baslangic; i <= bitis; i= i+artis)
            {
                sayac++;
                karesi = i * i;

                Console.WriteLine("{1}. sayı: {0}", i * i, sayac);
            }

            Console.ReadLine();


          

        }
    }
}
