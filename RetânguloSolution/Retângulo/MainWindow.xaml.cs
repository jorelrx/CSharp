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

namespace Retângulo
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
            Retangulo retan = new Retangulo();
            retan.SetBase(double.Parse(bas.Text));
            retan.SetAltura(double.Parse(altura.Text));
            area.Text = retan.CalcArea().ToString();
            diag.Text = retan.CalcDiag().ToString();
        }
    }

    class Retangulo
    {
        private double b, h;
        public void SetBase(double b)
        {
            this.b = b;
        }
        public void SetAltura(double h)
        {
            this.h = h;
        }
        public double GetBase()
        {
            return b;
        }
        public double GetAltura()
        {
            return h;
        }
        public double CalcArea()
        {
            return b * h;
        }
        public double CalcDiag()
        {
            return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
        }
    }
}
