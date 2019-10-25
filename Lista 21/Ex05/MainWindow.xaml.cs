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
            private List<K> chaves = new List<K>();
            private List<V> valores = new List<V>();
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
                    if (chaves.IndexOf(chave) == -1)
                    {
                        chaves.Add(chave);
                    }
                    else valores[chaves.IndexOf(chave)] = value;
                }
                get
                {
                    int p = chaves.IndexOf(chave);
                    if (p == -1) throw new InvalidOperationException();
                    else return valores[p];
                }
            }
            public void Add(K chave, V valor)
            {
                if (chave == null) throw new InvalidOperationException();
                else
                {
                    chaves.Add(chave);
                    valores.Add(valor);
                }
            }
            public void Clear()
            {
                chaves.Clear();
                valores.Clear();
            }
            public bool Remove(K chave)
            {
                if (chaves.IndexOf(chave) == -1) return false;
                else
                {
                    chaves.RemoveAt(chaves.IndexOf(chave));
                    valores.RemoveAt(chaves.IndexOf(chave));
                    return true;
                }
            }
            public bool Contains(K chave) => chaves.Contains(chave);
        }
    }
}
