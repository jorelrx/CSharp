using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagem
{
    class Via
    {
        private double d, t;
        public void SetDistancia(double d)
        {
            this.d = d;
        }
        public void SetTempo(double t)
        {
            this.t = t;
        }
        public double GetDistancia()
        {
            return d;
        }
        public double GetTempo()
        {
            return t;
        }
        public double CalcVelocidad()
        {
            return d / t;
        }
    }
}
