using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_WPF
{

    class Jogo
    {
        private string nome;
        private List<Jogador> jogadores = new List<Jogador>();
        public Jogo(string nome)
        {
            this.nome = nome;
        }
        public void Inserir(Jogador j)
        {
            foreach (Jogador x in jogadores)
            {
                if (x.GetEmail() == j.GetEmail()) throw new EmailExistenteException();
            }
            jogadores.Add(j);
        }
        public List<Jogador> Listar()
        {
            return jogadores;
        }
        public Jogador Top1()
        {
            jogadores.Sort();
            return jogadores[0];
        }
        public List<Jogador> Top10()
        {
            int k = 0;
            jogadores.Sort();
            List<Jogador> j = new List<Jogador>();
            do
            {
                j.Add(jogadores[k++]);
            } while (k < 10);
            return j;
        }
        public override string ToString()
        {
            return $"Nome do jogo: {nome}\nJogadores total: {jogadores.Count}";
        }
    }
}
