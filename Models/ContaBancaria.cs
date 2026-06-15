using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_API_3.Models
{
    public class ContaBancaria
    {
        private string numeroConta;
        private double saldo;

        public string NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }

        public double Saldo
        {
            get { return saldo; }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                return true;
            }

            return false;
        }
    }
}