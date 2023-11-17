using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kornyakovpr8
{
    public class Pramaygolnik : Interface1
    {
        double _sideA;
        double _sideB;
        int _square;

        public Pramaygolnik(double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }

        public double Perimetr()
        {
            return (_sideA + _sideB) * 2;

        }

        public double Square()
        {
            return _sideA * _sideB;
        }

        public int Sravnenie(object obj)
        {
            Pramaygolnik str = (Pramaygolnik)obj;
            if (this._square > str._square) return 1;
            if (this._square < str._square) return -1;
            return 0;
        }
    }
}
