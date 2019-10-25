using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Cliente
    {
        private string nome, email, fone;
        private ContaBancaria[] contas = new ContaBancaria[10];
        private int k = 0;
        public Cliente(string n, string e, string f)
        {
            nome = n;
            email = e;
            fone = f;
        }
        public string GetNome() { return nome; }
        public void Inserir(ContaBancaria c)
        {
            contas[k++] = c;
        }
        public ContaBancaria[] Listar()
        {
            ContaBancaria[] c = new ContaBancaria[k];
            Array.Copy(contas, c, k);
            return c;
        }
    }
}
