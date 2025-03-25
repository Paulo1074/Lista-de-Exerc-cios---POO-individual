using System;

class ContaBancaria
{
    public string NumeroConta { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria(string numeroConta, string titular, double saldoInicial)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor de depósito inválido!");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor inválido!");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: R${Saldo:F2}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o número da conta: ");
        string numeroConta = Console.ReadLine();

        Console.Write("Digite o nome do titular: ");
        string titular = Console.ReadLine();

        Console.Write("Digite o saldo inicial: ");
        double saldoInicial = Convert.ToDouble(Console.ReadLine());

        ContaBancaria conta = new ContaBancaria(numeroConta, titular, saldoInicial);

        int opcao;
        do
        {
            Console.WriteLine("\n1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Exibir Saldo");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o valor para depósito: ");
                    double deposito = Convert.ToDouble(Console.ReadLine());
                    conta.Depositar(deposito);
                    break;
                case 2:
                    Console.Write("Digite o valor para saque: ");
                    double saque = Convert.ToDouble(Console.ReadLine());
                    conta.Sacar(saque);
                    break;
                case 3:
                    conta.ExibirSaldo();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 0);
    }
}