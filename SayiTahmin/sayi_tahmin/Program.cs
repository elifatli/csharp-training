using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_tahmin
{
    class Program
    {
        static void Main(string[] args)
        {

            string devammi = "";

            do
            {

                Console.WriteLine("hadi bakalım oyununa hoş geldiniz");

                int rastsalsayi = new Random().Next(1, 100);
                int hak = 5;
                int puan = 100;

                do
                {
                    Console.Write("sayı girin: ");
                    int sayi = int.Parse(Console.ReadLine());


                    if (rastsalsayi == sayi)
                    {
                        Console.WriteLine($"bildiniz: {puan} aldınız: {6 - hak} kez sayı girdiniz. ");
                        break;

                    }

                    else
                    {
                        hak--;
                        puan -= 20;

                        if (hak == 0)
                        {
                            break;
                        }

                        if (sayi < rastsalsayi)
                        {
                            Console.WriteLine("yukarı");
                        }

                        else
                        {
                            Console.WriteLine("aşağı");
                        }

                       
                    }

                } while (hak > 0);

                if (hak == 0)
                {
                    Console.WriteLine($"kaybettiniz {rastsalsayi} sayı buydu.");
                }

                Console.WriteLine("Tekrar oynamak ister misiniz? E/H");
                devammi = Console.ReadLine();

            } while (devammi.Equals("E",StringComparison.OrdinalIgnoreCase)); 
            // davammi == "e" || devammi == "E";
            //("E").ToLower() == devammi.ToLower();


            Console.WriteLine("oynadığınız için teşekkürler.");
            Console.ReadLine();


        }
    }
}
