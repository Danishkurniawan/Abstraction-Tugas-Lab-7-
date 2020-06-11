using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace BangunDatar
{
    class Persegi : BangunDatar
    {
 
        private double _sisi;
 
        public double Sisi
        {
            get { return _sisi; }
            set { _sisi = value; }
        }
 
        public override double hitungLuas()
        {
            _hitung = _sisi * _sisi;
            return _hitung;
        }
 
        public override double hitungKeliling()
        {
            _hitung = _sisi * 4;
            return _hitung;
        }
    }
}
