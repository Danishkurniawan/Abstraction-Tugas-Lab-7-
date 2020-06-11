using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace BangunDatar
{
    abstract class BangunDatar
    {
        public double _hitung;
 
        public double Hitung
        {
            get { return _hitung; }
            set { _hitung = value; }
        }
 
        public abstract double hitungLuas();
 
        public abstract double hitungKeliling();
    }
}
