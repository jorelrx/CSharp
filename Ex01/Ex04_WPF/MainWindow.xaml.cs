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

namespace Ex04_WPF
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
        Jogo j;
        private void ButtonNewGame_Click(object sender, RoutedEventArgs e)
        {
            j = new Jogo(nomeJogo.Text);
        }

        private void ButtonInserir_Click(object sender, RoutedEventArgs e)
        {
            Jogador jog = new Jogador(nomeJogador.Text, emailJogador.Text);
            jog.SetPontos(int.Parse(pontuacaoJogador.Text), DateTime.Parse(data_Jogador.Text));
            j.Inserir(jog);
        }

        private void ButtonListar_Click(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = j.Listar();
        }

        private void ButtonTop1_Click(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = j.Top1().ToString();
        }

        private void ButtonTop10_Click(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = j.Top10().ToString();
        }
    }
}
