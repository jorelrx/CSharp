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
    }

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
        public int Count()
        {
            return valores.Count;
        }
        public V this[K c]
        {
            get
            {
                if (chaves.IndexOf(c) == -1) throw new InvalidOperationException();
                else return valores[chaves.IndexOf(c)];
            }
            set
            {
                if (chaves.IndexOf(c) == -1)
                {
                    chaves.Add(c);
                    valores.Add(null as List<V>);
                }
                else valores[chaves.IndexOf(c)] = value;
            }
        }
        public void Add(K chave, V valor)
        {
            if (chave == null) throw new ArgumentNullException();
            else if (chaves.IndexOf(chave) != -1) throw new InvalidOperationException();
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
        public bool Contains(K chave)
        {
            return chaves.Contains(chave);
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
    }
}
