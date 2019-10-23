using System;
using System.Collections.Generic;
using System.Text;

namespace Conta_Bancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria()
        {

        }
        public ContaBancaria(int numero, string titular,double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia - 5;
        }

    }
}
