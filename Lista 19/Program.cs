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
            int opcao = 0;
            do
            {
                Console.WriteLine("1: Quadrado.\n2: Retângulo.\n0: Sair.");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("Digite o valor equivalente aos lados do quadrado.");
                    Quadrado q = new Quadrado(double.Parse(Console.ReadLine()));
                    Console.WriteLine(q);
                    Console.ReadKey();
                    Console.Clear();
                }
                if (opcao == 2)
                {
                    Console.WriteLine("Base do retângulo.");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura do retângulo.");
                    double h = double.Parse(Console.ReadLine());
                    Retangulo r = new Retangulo(b, h);
                    Console.WriteLine(r);
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (opcao != 0);
        }
    }
}
