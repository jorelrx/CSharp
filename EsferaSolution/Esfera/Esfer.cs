using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfera
{
    class Esfer
    {
        private double raio;
        public void SetRaio(double raio)
        {
            this.raio = raio;
        }
        public double GetRaio()
        {
            return raio;
        }
        public double CalcArea()
        {
            return 4 * Math.PI * Math.Pow(raio,2);
        }
        public double CalcVolume()
        {
            return 4 / 3 * Math.PI * Math.Pow(raio, 3);
        }
    }
}
