using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı 'q' değerini girmedikçe aldığınız her değerin sayısal
            //olup olmadığını kontrol edin aksi halde hata mesajı veriniz.

            while (true)
            {
                Console.Write("sayı: ");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    int sayi = int.Parse(input);
                    Console.WriteLine("girdiğiniz sayı: {0}", sayi);
                }
                catch (Exception)
                {

                    Console.WriteLine("geçersiz sayı");
                    continue;
                }
            }
        }
    }
}
