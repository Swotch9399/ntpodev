using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntpodevMetodlar
{
    class Class
    {
        public int sayi1, sayi2;
        public int Toplama()
        {
            return sayi1 + sayi2;
        }
        public int KaresiniAlma()
        {
            return sayi1 * sayi1;
        }
        public void Yazdir()
        {
            Console.WriteLine("Yazdırıldı.");
        }
        public void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
