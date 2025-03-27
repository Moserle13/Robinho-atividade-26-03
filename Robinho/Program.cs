using System;

class Jogo
{
    static char[] tabuleiro = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static Random random = new Random();

    static void Main()
    {
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("Escolha um modo de jogo:");
            Console.WriteLine("1 - Jogar H x H");
            Console.WriteLine("2 - Jogar H x M (Fácil)");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    JogarContraHumano();
                    break;
                case 2:
                    JogarContraMaquina();
                    break;
                case 0:
                    Console.WriteLine("Saindo do jogo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        } while (opcao != 0);
    }

    static void JogarContraHumano()
    {
        Console.WriteLine("Modo H x H selecionado.");
        // Implementação do jogo entre dois humanos pode ser adicionada aqui
    }

    static void JogarContraMaquina()
    {
        Console.WriteLine("Modo H x M (Fácil) selecionado.");
        // Implementação do jogo contra a máquina com estratégia aleatória
    }
}
