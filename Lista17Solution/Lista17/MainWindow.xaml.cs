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

namespace Ex01
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
            DisciplinaSemestral s = new DisciplinaSemestral(snome.Text, int.Parse(s1bim.Text), int.Parse(s2bim.Text), int.Parse(sfinal.Text));
            list.Items.Add(s);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DisciplinaAnual s = new DisciplinaAnual(anome.Text, int.Parse(a1bim.Text), int.Parse(a2bim.Text), int.Parse(a3bim.Text), int.Parse(a4bim.Text), int.Parse(sfinal.Text));
            list.Items.Add(s);
        }

        private void Button_CalcularMedia(object sender, RoutedEventArgs e)
        {
            MessageBox.Show
            (
                (list.SelectedItem as IMedia).GetMedia().ToString()
            );
        }
    }
    interface IMedia
    {
        int GetMedia();
    }

    class DisciplinaAnual : IMedia
    {
        private string nome;
        private int nota1, nota2, nota3, nota4, notaf;
        public DisciplinaAnual(string nome, int n1, int n2, int n3, int n4, int nf)
        {
            this.nome = nome;
            nota1 = n1;
            nota2 = n2;
            nota3 = n3;
            nota4 = n4;
            notaf = nf;
        }

        public override string ToString()
        {
            return $"{nome} {nota1} {nota2} {nota3} {nota4} {notaf}";
        }
        public int GetMedia()
        {
            int m = (2 * nota1 + 2 * nota2 + 3 * nota3 + 3 * nota4) / 10;
            if (m < 60) m = (m + notaf) / 2;
            return m;
        }
    }
    class DisciplinaSemestral : IMedia
    {
        private string nome;
        private int nota1, nota2, nota3, nota4, notaf;
        public DisciplinaSemestral(string nome, int n1, int n2, int nf)
        {
            this.nome = nome;
            nota1 = n1;
            nota2 = n2;
            notaf = nf;
        }

        public override string ToString()
        {
            return $"{nome} {nota1} {nota2} {notaf}";
        }
        public int GetMedia()
        {
            int m = (2 * nota1 + 3 * nota2) / 5;
            if (m < 60) m = (m + notaf) / 2;
            return m;
        }
    }
}
