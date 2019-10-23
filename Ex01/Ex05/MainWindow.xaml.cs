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

namespace Ex05
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

        }
    }
    namespace Ex05
    {
        class Dicionario<K, V>
        {
            private List<K> chaves;
            private List<V> valores;
            public List<K> Chaves
            {
                get
                {
                    return chaves;
                }
            }
            public int Count
            {
                get
                {
                    return valores.Count;
                }
            }
            public V this[K chave]
            {
                set
                {

                }
                get
                {
                    int p = chaves.IndexOf(chave);
                    if (p == -1) throw new InvalidOperationException();
                    else return valores[p];
                }
            }
        }
    }
}
