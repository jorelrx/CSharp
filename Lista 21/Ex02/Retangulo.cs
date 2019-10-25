using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Retangulo
    {
        private double b, h;
        public Retangulo(double b, double h)
        {
            if (b > 0 && h > 0)
            {
                this.b = b;
                this.h = h;
            }
            else throw new ArgumentOutOfRangeException();
        }
        public double CalcArea()
        {
            double area;
            area = b * h;
            return area;
        }
    }
}
