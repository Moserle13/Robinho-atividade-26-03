using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; private set; }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            Quantidade += quantidade;
            Console.WriteLine($"{quantidade} unidades adicionadas ao estoque.");
        }
        else
        {
            Console.WriteLine("Quantidade inválida para adicionar ao estoque.");
        }
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= Quantidade)
        {
            Quantidade -= quantidade;
            Console.WriteLine($"{quantidade} unidades removidas do estoque.");
        }
        else
        {
            Console.WriteLine("Quantidade insuficiente em estoque ou valor inválido.");
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}\nPreço: R${Preco:F2}\nQuantidade em estoque: {Quantidade}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o preço do produto: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade inicial em estoque: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        Produto produto = new Produto(nome, preco, quantidade);

        int opcao;
        do
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar ao estoque");
            Console.WriteLine("2 - Remover do estoque");
            Console.WriteLine("3 - Exibir detalhes do produto");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a quantidade a adicionar: ");
                    int adicionar = Convert.ToInt32(Console.ReadLine());
                    produto.AdicionarEstoque(adicionar);
                    break;
                case 2:
                    Console.Write("Digite a quantidade a remover: ");
                    int remover = Convert.ToInt32(Console.ReadLine());
                    produto.RemoverEstoque(remover);
                    break;
                case 3:
                    produto.ExibirDetalhes();
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