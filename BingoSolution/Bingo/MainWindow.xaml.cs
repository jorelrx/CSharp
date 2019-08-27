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

namespace Bingo
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
        Bingos b;
        private void Button_Click(object sender, RoutedEventArgs e) //iniciar
        {
            b = new Bingos();
            b.Iniciar(int.Parse(txt.Text));
            txtNum.Text = "";
            txtNums.Text = "";
            btnSortear.IsEnabled = true;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (txt != null) txt.Text = slider.Value.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //"sortear"
        {
            int n = b.Proximo();
            txtNum.Text = n.ToString();
            txtNums.Text += n.ToString() + " - ";
        }
    }
    class Bingos
    {
        private int numBolas, cont;
        private int[] vet;
        public void Iniciar(int numBolas)
        {
            this.numBolas = numBolas;
            vet = new int[numBolas];
            int k = 0;
            Random r = new Random();
            while (k < numBolas)
            {
                int n = r.Next(1, numBolas + 1);
                if (Array.IndexOf(vet, n) == -1)
                {
                    vet[k] = n; k++;
                }
            }
        }
        public int Proximo()
        {
            if (cont < numBolas)
            {
                int x = vet[cont];
                cont++;
                return x;
            }
            return -1;
        }
    }
}
