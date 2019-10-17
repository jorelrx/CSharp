using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class ContaBancaria
    {
        private string numeroDaConta;
        private double saldo;
        public ContaBancaria(string n, double s)
        {
            numeroDaConta = n;
            if (s >= 0) saldo = s;
            else throw new ArgumentOutOfRangeException();
        }
        public void Despositar(double valor)
        {
            if (valor > 0) saldo += valor;
            else throw new ArgumentOutOfRangeException();
        }
        public void Sacar(double valor)
        {
            if (valor < 0) throw new ArgumentOutOfRangeException();
            if (valor > saldo) throw new InversaoSaldoException();
            else saldo -= valor;
        }
        public double GetSaldo()
        {
            return saldo;
        }
        public override string ToString()
        {
            return $"Numero da conta: {numeroDaConta}\nSaldo: {saldo} R$";
        }
    }
}
