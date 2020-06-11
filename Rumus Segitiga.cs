using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Segitiga : BangunDatar
    {
        public int a = 0;
        public float p,l;

        public override void Luas()
        {
            Console.Write("Masukkan nilai alas       = ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai tinggi     = ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai sisi       = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luas Segitiga             = " + ((p * l) / 2));
        }

        public override void Keliling()
        {
            Console.WriteLine("Keliling Segitiga         = " + (a + a + a));
        }
    }
}
