using System;

class Lampada
{
    private bool Ligada;

    public void Ligar()
    {
        Ligada = true;
        Console.WriteLine("A lâmpada está ligada.");
    }

    public void Desligar()
    {
        Ligada = false;
        Console.WriteLine("A lâmpada está desligada.");
    }

    public void MostrarEstado()
    {
        Console.WriteLine(Ligada ? "A lâmpada está ligada." : "A lâmpada está desligada.");
    }
}

class Program
{
    static void Main()
    {
        Lampada lampada = new Lampada();

        int opcao;
        do
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Ligar a lâmpada");
            Console.WriteLine("2 - Desligar a lâmpada");
            Console.WriteLine("3 - Mostrar estado da lâmpada");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    lampada.Ligar();
                    break;
                case 2:
                    lampada.Desligar();
                    break;
                case 3:
                    lampada.MostrarEstado();
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
