using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Quadrado : Retangulo
    {
        public Quadrado(double l) : base(l, l) { }
        public override string ToString()
        {
            return $"Quadrado: \nLado = {base.GetBase()} \nÁrea = {base.CalcArea()} \nDiagonal = {base.CalcDiag():00.00}";
        }
    }
}
