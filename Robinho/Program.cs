using System;

class ContaBancaria
{
    public string NumeroConta { get; set; }
    public string Titular { get; set; }
    private double Saldo;

    public ContaBancaria(string numeroConta, string titular)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = 0.0;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Valor de depósito inválido.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor inválido para saque.");
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

        ContaBancaria conta = new ContaBancaria(numeroConta, titular);

        int opcao;
        do
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Exibir Saldo");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o valor do depósito: ");
                    double deposito = Convert.ToDouble(Console.ReadLine());
                    conta.Depositar(deposito);
                    break;
                case 2:
                    Console.Write("Digite o valor do saque: ");
                    double saque = Convert.ToDouble(Console.ReadLine());
                    conta.Sacar(saque);
                    break;
                case 3:
                    conta.ExibirSaldo();
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao != 0);
    }
}