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

namespace EquacaoIIgrau
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
            Eq2g eq = new Eq2g();
            eq.SetABC(double.Parse(A.Text), double.Parse(B.Text), double.Parse(C.Text));
            if (eq.Delta() >= 0)
            {
                delt.Text = eq.Delta().ToString();
                xizum.Text = eq.X1().ToString();
                xidos.Text = eq.X2().ToString();
            }
            else
            {
                delt.Text = eq.Delta().ToString();
                xizum.Text = "Raiz Indefinida";
                xidos.Text = "Raiz Indefinida";
            }
        }
    }
    class Eq2g
    {
        private double a, b, c;
        public void SetABC(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void GetABC(out double a, out double b, out double c)
        {
            a = this.a;
            b = this.b;
            c = this.c;
        }
        public double Delta()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
        public double X1()
        {
            return -b + Math.Sqrt(Delta()) / 2 * a;
        }
        public double X2()
        {
            return -b - Math.Sqrt(Delta()) / 2 * a;
        }
    }
}
