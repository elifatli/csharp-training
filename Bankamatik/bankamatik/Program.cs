using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankamatik
{
    class Program
    {
        public static double bakiye { get; set; }

        static void BakiyeGoster()
        {
            Console.WriteLine($"bakiyeniz: {bakiye}");

        }
        static void ParaCek()
        {
            Console.Write("çekilen miktar");
            double cekilen = double.Parse(Console.ReadLine());
            if (cekilen <= bakiye)
            {
                bakiye = bakiye - cekilen;
                Console.WriteLine($"{cekilen} lira çektiniz. kalan bakiye {bakiye}");
            }
            else
            {
                Console.WriteLine("yetersiz bakiye");
            }
        }
        static void ParaYatir()
        {
            Console.Write("yatırılan miktar");
            double yatirilan = double.Parse(Console.ReadLine());
            bakiye = bakiye + yatirilan;
            Console.WriteLine($"{yatirilan} lira yatırdınız. yeni bakiye {bakiye}");
        }
        static void Main(string[] args)
        {
            Console.Write("bakiye girin");
            bakiye = double.Parse(Console.ReadLine());

            char islem;

            do
            {
                Console.Write("yapmak istediğiniz işlemi seçiniz\n1.bakiye sorgulama\n" +
                    "2.para çekme\n3.para yatırma\n4.çıkış");
                islem = char.Parse(Console.ReadLine());

                switch (islem)
                {
                    case '1':
                        BakiyeGoster();
                        break;

                    case '2':
                        ParaCek();
                        break;
                    case '3':
                        ParaYatir();
                        break;

                    case '4':
                        Console.WriteLine("çıkış");
                        break;
                    default:
                        Console.WriteLine("yanlış işlem");
                        break;
                }

            } while (islem != '4');

            Console.ReadLine();

        }
    }
}
