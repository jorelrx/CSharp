using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite base e altura do triângulo.");
                Retangulo r = new Retangulo(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine(r.CalcArea());
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Valor incorreto!");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
