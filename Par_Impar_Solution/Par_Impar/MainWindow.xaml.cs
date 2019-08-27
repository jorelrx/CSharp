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

namespace Par_Impar
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Numeros num = new Numeros(int.Parse(inicio.Text), int.Parse(fim.Text));
            listbox.ItemsSource = num.Calcular(cbP.IsChecked.Value, cbI.IsChecked.Value);
        }
    }
    class Numeros
    {
        private int inicio, fim;
        public Numeros(int inicio, int fim)
        {
            this.inicio = inicio;
            this.fim = fim;
        }
        public int[] Calcular(bool p, bool i)
        {
            int[] vet = new int[fim];
            int cont = 0;
            for (int k = inicio; k <= fim; k++)
            {
                if (p == true && i == false && k % 2 == 0) vet[cont++] = k;
                if (p == false && i == true && k % 2 != 0) vet[cont++] = k;
                if (p == true && i == true) vet[cont++] = k;
            }
            int[] retornar = new int[cont];
            Array.Copy(vet, retornar, cont);
            return retornar;
        }
    }
}
