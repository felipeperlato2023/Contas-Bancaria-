using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
  public class ContaComercial:Conta
    {
        public double Limiteemprestimo { get; set; }

        public ContaComercial()
        {
            Limiteemprestimo = 100;
        }

        public ContaComercial (int numero, string nome, double saldo) : this()
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
       
        }


        public void Opemprestimo (double valoremprestimo)
        {
            if (Limiteemprestimo >= valoremprestimo)
            {
                Saldo += valoremprestimo - 10;

            }
            else
            {
                Console.WriteLine("valor maior que o limite");
            }
        }

    }
}
