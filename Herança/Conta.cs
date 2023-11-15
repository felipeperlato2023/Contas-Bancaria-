using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
        }

        public Conta(int num, string nometitular, double saldo)
        {
            Numero = num;
            Nome = nometitular;
           Saldo = saldo;
        }

        public void  Saque (double saque)
        {
            Saldo -= saque;

        }

        public void Deposito (double dep)
        {
            Saldo += dep;
        }


    }
}
