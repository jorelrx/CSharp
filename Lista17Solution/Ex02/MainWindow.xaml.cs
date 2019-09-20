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

namespace Ex02
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

        PA peA;
        Fibonacci fibo;

        private void Iniciar(object sender, RoutedEventArgs e)
        {
            peA = new PA(int.Parse(txtPa.Text));
            ListPA.Items.Add(peA.Iniciar());
            ButtonIniciar.IsEnabled = false;
            fibo = new Fibonacci();
            ListFibo.Items.Add(fibo.Iniciar());
        }

        private void Button_Proximo(object sender, RoutedEventArgs e)
        {
            ListPA.Items.Add(peA.Proximo());
            ListFibo.Items.Add(fibo.Proximo());
        }
    }

    class PA
    {
        private int primeiroElemento;
        private int razao;
        public PA(int razao)
        {
            this.razao = razao;
        }
        public int Iniciar()
        {
            primeiroElemento = 0;
            return primeiroElemento;
        }
        public int Proximo()
        {
            primeiroElemento += razao;
            return primeiroElemento;
        }
    }

    class Fibonacci
    {
        private int primeiroElemento = 0;
        private int proximoElemento = 1, aux = 0;
        public int Iniciar()
        {
            return primeiroElemento;
        }
        public int Proximo()
        {
            aux = primeiroElemento;
            primeiroElemento = proximoElemento;
            proximoElemento += aux;
            return primeiroElemento;

        }
    }
}
