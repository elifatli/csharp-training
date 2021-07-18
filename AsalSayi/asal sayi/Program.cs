using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal_sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.Write("sayı: ");
                int sayi = int.Parse(Console.ReadLine());

                bool sayiasalmi = true;

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        Console.WriteLine("asal sayı değil");
                        sayiasalmi = false;
                        break;
                    }
                }

                if (sayiasalmi)
                {
                    Console.WriteLine("sayı asal");
                }

                Console.ReadLine();
            } while (true);

        }
    }
}
