using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;


namespace Exercicio.Encapsulamento._1
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.Write("Entre o numero da conta: ");
            int Contaa = int.Parse(Console.ReadLine());


            Console.Write("Entre o titular da conta: ");

            string Nomee = Console.ReadLine();

            ContaBancaria CF = new ContaBancaria(Contaa, Nomee) ;

            Console.Write("Haverá depósito inicial (s/n)? ");

             CF.Inicial = char.Parse(Console.ReadLine());

            if (CF.Inicial == 's' || CF.Inicial == 'S')
            {
                Console.Write("\nEntre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                CF.Deposito(deposito);
            }


            Console.WriteLine("\nDados da conta: \n" + CF.ToString());

            Console.Write("\nEntre um valor para deposito: ");
            double depositar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            CF.Depositar(depositar);

            Console.WriteLine("\nDados da conta atualizados: \n" + CF.ToString());

            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            CF.Saque(saque);

            Console.WriteLine("\nDados da conta atualizados: \n" + CF.ToString());

        }
    }
}
