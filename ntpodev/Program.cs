using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ntpodevMetodlar;

namespace ntpodev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class metodlar = new Class();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("1 - TOPLAMA");
            Console.WriteLine("2 - SAYININ KARESİNİ ALMA");
            Console.WriteLine("3 - YAZDIR");
            Console.WriteLine("4 - HELLOWORLD");
            Console.WriteLine("Yukardan işlem seçiniz ve tuşlayınız.");
            int hangisi = Convert.ToInt32(Console.ReadLine());
            if (hangisi == 1)
            {
                Console.WriteLine("1. Sayı değerini giriniz:");
                metodlar.sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Sayı değerini giriniz:");
                metodlar.sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayıların Toplamı = " + metodlar.Toplama());
            }
            if (hangisi == 2)
            {
                Console.WriteLine("Sayı değerini giriniz:");
                metodlar.sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayının Karesi = " + metodlar.KaresiniAlma());
            }
            if (hangisi == 3)
            {
                metodlar.Yazdir();
            }
            if (hangisi == 4)
            {
                metodlar.HelloWorld();
            }
            Console.ReadLine();
        }
    }
}
