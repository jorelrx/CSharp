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

        private void Proximo(object sender, RoutedEventArgs e)
        {

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
        public void Iniciar()
        {
            primeiroElemento = 0;
        }
        public int Proximo()
        {
            primeiroElemento += razao;
            return primeiroElemento;
        }
    }
}
