using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio.Encapsulamento._1
{
    class ContaBancaria
    {
        public string NomeTitular { get; set; }
        public int Conta { get; private set; }
        public double DepositoInicial { get; private set; }
        public char Inicial { get; set; }

        public ContaBancaria (int _conta, string nome)
        {
            this.Conta = _conta;
            NomeTitular = nome;
            Depositar(DepositoInicial);
        }
        public string NomeTItular
        {
            get 
            {
                return NomeTitular;
            }
            set
            {
            }
        }

        public double Deposito (double dep) { 
                return DepositoInicial = dep;
        }

        public void Depositar (double posi)
        {
            DepositoInicial += posi;
        }
        public void Saque(double saca)
        {
            DepositoInicial -= saca + 5;;
        }


        public override string ToString()
        {
            return "Conta " 
                + Conta + ", Titular: " 
                + NomeTItular + ", Saldo: $ " 
                + DepositoInicial.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
