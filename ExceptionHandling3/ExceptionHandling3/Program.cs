using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen parola içerisinde Türkçe karakter araması yapınız.

            Console.Write("parola: ");
            string parola = Console.ReadLine();

            try
            {
                CheckPassword(parola);

            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }
            Console.ReadLine();
        }

        static void CheckPassword(string parola)
        {
            string turkce_karakterler = "ç,Ç,ğ,Ğ,ö,Ö,ş,Ş,ü,Ü,ı,İ";
            foreach (var karakter in parola)
            {
                if (turkce_karakterler.IndexOf(karakter)>-1) //!=-1 de olabilir
                {
                    throw new Exception(ErrorMessage.TurkishCharacterError);
                    
                }
            }

            Console.WriteLine("geçerli parola");
            
           
        }

        
    }
}
