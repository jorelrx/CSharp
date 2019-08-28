using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Historico
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Historic h;
        private void Button_Aluno(object sender, RoutedEventArgs e)
        {
            h = new Historic(aluno.Text);
        }

        private void Button_Inserir(object sender, RoutedEventArgs e)
        {
            Disciplina d = new Disciplina(nome.Text, semestre.Text, int.Parse(media.Text), cbA.IsChecked.Value);
            h.Inserir(d);
            materias.ItemsSource = h.Listar();
        }
    }
    class Historic
    {
        string aluno;
        Disciplina[] disc = new Disciplina[10];
        int cont = 0;
        public Historic()
        {

        }
        public Historic(string aluno)
        {
            this.aluno = aluno;
        }
        public void Inserir(Disciplina d)
        {
            disc[cont++] = d;
        }
        public Disciplina[] Listar()
        {
            Disciplina[] d = new Disciplina[cont];
            Array.Copy(disc, d, cont);
            return d;
        }
        public double CalcIra()
        {
            double ira = 0;
            Disciplina[] d = Listar();
            foreach(Disciplina di in d)
            {
                ira += di.GetMedia();
            }
            return ira;
        }
    }

    class Disciplina
    {
        private string nome, semestre;
        private int media;
        private string situacao;
        public Disciplina(string nome, string semestre, int media, bool situacao)
        {
            this.nome = nome;
            this.semestre = semestre;
            this.media = media;
            if (situacao == true) this.situacao = "Aprovado";
            else this.situacao = "Reprovado";
        }
        public double GetMedia() { return media; }
        public override string ToString()
        {
            return nome + " - " + semestre + " - " + media + " - " + situacao;
        }
    }
}
