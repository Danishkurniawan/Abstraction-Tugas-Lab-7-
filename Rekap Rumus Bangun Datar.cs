using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace BangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            Persegi p = new Persegi();
            p.Sisi = 9;
 
            System.Console.WriteLine("Persegi");
            System.Console.WriteLine("Nilai Sisi : " + p.Sisi);
            System.Console.WriteLine("Luas : " + p.hitungLuas());
            System.Console.WriteLine("Keliling : "+ p.hitungKeliling()+ "\n");
 
            PersegiPanjang pp = new PersegiPanjang();
            pp.Panjang = 9;
            pp.Lebar = 5;
 
            System.Console.WriteLine("Persegi Panjang");
            System.Console.WriteLine("Nilai Panjang : " + pp.Panjang);
            System.Console.WriteLine("Nilai Lebar : " + pp.Lebar);
            System.Console.WriteLine("Luas : " + pp.hitungLuas());
            System.Console.WriteLine("Keliling : " + pp.hitungKeliling()+ "\n");
 
            Segitiga s = new Segitiga();
            s.Alas = 5.5;
            s.Tinggi = 10;
            s.Sisi = 7;
 
            System.Console.WriteLine("Segitiga");
            System.Console.WriteLine("Nilai Alas : " + s.Alas);
            System.Console.WriteLine("Nilai Tinggi : " + s.Tinggi);
            System.Console.WriteLine("Nilai Sisi : " + s.Sisi);
            System.Console.WriteLine("Luas : " + s.hitungLuas());
            System.Console.WriteLine("Keliling : " + s.hitungKeliling());
 
            System.Console.ReadKey();
        }
    }
}
