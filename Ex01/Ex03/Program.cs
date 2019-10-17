using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe nome, email e fone.");
                Cliente c = new Cliente(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                int op = 0;
                do
                {
                    Console.WriteLine($"1: Criar conta bancaria.\n2: Listar contas bancarias de {c.GetNome()}\n3: Deposito.\n4: Saque.");
                    op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.WriteLine("Informe numero da conta e saldo incial.");
                        ContaBancaria b = new ContaBancaria(Console.ReadLine(), double.Parse(Console.ReadLine()));
                        c.Inserir(b);
                    }
                    if (op == 2)
                    {
                        foreach (ContaBancaria a in c.Listar())
                            Console.WriteLine(a);
                    }
                    if (op == 3)
                    {
                        int k = 0;
                        foreach (ContaBancaria a in c.Listar())
                        {
                            Console.WriteLine("Conta: " + k++);
                            Console.WriteLine(a);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Em qual conta deseja fazer deposito?");
                        ContaBancaria cliente = c.Listar()[int.Parse(Console.ReadLine())];
                        Console.WriteLine(cliente);
                    }
                } while (op != 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Valor invalido");
            }
            catch (InversaoSaldoException)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
