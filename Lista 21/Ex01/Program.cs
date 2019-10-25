using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            try
            {
                t.Metodo1(int.Parse(Console.ReadLine()));
                Console.WriteLine(t.GetNumero());
            }
            catch (Erro)
            {
                Console.WriteLine("Valor incorreto");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
