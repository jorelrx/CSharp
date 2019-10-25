using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Retangulo
    {
        private double b, h;
        public Retangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public double GetAltura() { return b; }
        public double GetBase() { return h; }
        public double CalcArea() { return b * h; }
        public double CalcDiag() { return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2)); }
        public override string ToString()
        {
            return $"Retângulo: \nBase = {b} \nAltura = {h} \nÁrea = {CalcArea()} \nDiagonal = {CalcDiag():00.00}";
        }
    }
}
