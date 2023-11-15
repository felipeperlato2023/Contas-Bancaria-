using Herança;
using System.Runtime.CompilerServices;

public  class Program
{
    private static void Main(string[] args)
    {

        Console.Write("informe o numero da conta:");
        int num = int.Parse(Console.ReadLine());

        Console.Write("informe o nome titular da conta:");
        string nometitular = Console.ReadLine();

        Console.Write("informe o saldo:");
        double saldo = double.Parse(Console.ReadLine());

        Conta c1 = new Conta(num,nometitular,saldo);

        Console.WriteLine(" numero:" + c1.Numero + " nome:" + c1.Nome + " saldo:" + c1.Saldo);

        Console.Write("valor a sacar: ");
        double saque = double.Parse(Console.ReadLine());

        c1.Saque(saque);

        Console.WriteLine(" numero:" + c1.Numero + " nome:" + c1.Nome + " saldo:" + c1.Saldo);


        Console.Write("valor a depositar: ");
        double dep = double.Parse(Console.ReadLine());

        c1.Deposito(dep);

        Console.WriteLine(" numero:" + c1.Numero + " nome:" + c1.Nome + " saldo:" + c1.Saldo);



        Console.WriteLine(" criando conta comercial ");

        ContaComercial cc = new ContaComercial(num,nometitular, saldo);

        Console.WriteLine(" numero:" + cc.Numero + " nome:" + cc.Nome + " saldo:" + cc.Saldo);
        Console.WriteLine("valor do emprestimo");
        double valoremprestimo = double.Parse(Console.ReadLine());  

        cc.Opemprestimo(valoremprestimo);

        Console.WriteLine(" numero:" + cc.Numero + " nome:" + cc.Nome + " saldo:" + cc.Saldo);
    }
}