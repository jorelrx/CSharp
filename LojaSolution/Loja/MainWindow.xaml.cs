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

namespace Loja
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
        Lojaa loja;
        private void Button_Loja(object sender, RoutedEventArgs e)
        {
            loja = new Lojaa(nome.Text);
        }

        private void Button_Inserir(object sender, RoutedEventArgs e)
        {
            Veiculo v = new Veiculo(placa.Text, fabricante.Text, modelo.Text, int.Parse(ano.Text), decimal.Parse(preco.Text), vendido.IsChecked.Value);
            loja.Inserir(v);
        }

        private void Button_Listar(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = loja.Listar();
        }

        private void Button_Vender(object sender, RoutedEventArgs e)
        {

        }

    }
    class Lojaa
    {
        private string nome;
        private int cont = 0;
        Veiculo[] v = new Veiculo[10];
        public Lojaa(string nome) { this.nome = nome; }
        public void Inserir(Veiculo v)
        {
            this.v[cont++] = v;
        }
        public Veiculo[] Listar()
        {
            Veiculo[] veic = new Veiculo[cont];
            Array.Copy(v, veic, cont);
            return veic;
        }
        public Veiculo[] ListarValor(decimal limite)
        {
            int x = 0;
            Veiculo[] veic = new Veiculo[cont];
            foreach (Veiculo a in Listar()) if (a.GetPreco() <= limite) veic[x++] = a;
            Veiculo[] retorno = new Veiculo[x];
            Array.Copy(veic, retorno, x);
            return retorno;
        }
    }
    class Veiculo
    {
        private string placa, fabricante, modelo;
        private int ano;
        private decimal preco;
        private bool vendido;
        public Veiculo(string placa, string fabricante, string modelo, int ano, decimal preco, bool vendido)
        {
            this.placa = placa;
            this.fabricante = fabricante;
            this.modelo = modelo;
            this.ano = ano;
            this.preco = preco;
            this.vendido = vendido;
        }
        public void Vender()
        {
            if (vendido != true) vendido = true;
        }
        public decimal GetPreco()
        {
            return preco;
        }
        public override string ToString()
        {
            string vendeu;
            if (vendido == true) vendeu = "Vendido";
            else vendeu = "Não vendido";
            return $"{placa} {fabricante} {modelo} - {ano} - {preco} - {vendeu}";
        }
    }
}
