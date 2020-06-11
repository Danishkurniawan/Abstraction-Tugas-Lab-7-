using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace BangunDatar
{
    class PersegiPanjang : BangunDatar
    {
        private double _panjang;
        private double _lebar;
 
        public double Panjang
        {
            get { return _panjang; }
            set { _panjang = value; }
        }
 
        public double Lebar
        {
            get { return _lebar; }
            set { _lebar = value; }
        }
 
        public override double hitungLuas()
        {
            _hitung = _panjang * _lebar;
            return _hitung;
        }
 
        public override double hitungKeliling()
        {
            _hitung = (_panjang + _lebar) * 2;
            return _hitung;
        }
    }
}
