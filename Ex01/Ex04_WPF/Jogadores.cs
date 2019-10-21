using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_WPF
{
    class Jogador : IComparable
    {
        private string nome, email;
        private int PontosMax;
        private DateTime data;
        public Jogador(string n, string e)
        {
            nome = n;
            email = e;
        }
        public void SetPontos(int pontos, DateTime data)
        {
            DateTime d = DateTime.Today;
            if (pontos < 0) throw new ArgumentOutOfRangeException();
            else if (data > d) throw new ArgumentOutOfRangeException();
            else
            {
                PontosMax = pontos;
                this.data = data;
            }
        }
        public string GetEmail() { return email; }
        public int CompareTo(object obj)
        {
            Jogador j = obj as Jogador;
            if (this.PontosMax.CompareTo(j.PontosMax) != 0) return this.PontosMax.CompareTo(j.PontosMax);
            else return this.data.CompareTo(j.data);
        }
        public override string ToString()
        {
            return $"Nome do jogador: {nome}\nEmail: {email}\nPontuação maxima: {PontosMax}\nData do recorde: {data}";
        }
    }
}
