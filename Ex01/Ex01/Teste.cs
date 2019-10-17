using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Teste : ITeste
    {
        private int num;
        public int GetNumero()
        {
            return num;
        }

        public void SetNumero(int valor)
        {
            if (valor < 0) throw new Erro();
            else num = valor;
        }
    }
}
