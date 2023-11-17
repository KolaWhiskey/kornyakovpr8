using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kornyakovpr8
{
    public class Circl : Interface1
    {
        double _radius;
        int _square;

        public Circl(double radius)
        {
            _radius = radius;
        }

        public double Perimetr()
        {
            return 2 * Math.PI * _radius;
        }

        public double Square()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public int Sravnenie(object obj)
        {
            Circl c = obj as Circl;
            if (this._square > c._square) return 1;
            if (this._square < c._square) return -1;
            return 0;

        }
    }
}
