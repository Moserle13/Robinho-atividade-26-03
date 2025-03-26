using System;

class Aluno
{
    public string RA { get; set; }
    public string Nome { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public double NotaFinal { get; private set; }

    public void ReceberDados()
    {
        Console.Write("Digite o RA do aluno: ");
        RA = Console.ReadLine();

        Console.Write("Digite o Nome do aluno: ");
        Nome = Console.ReadLine();

        Console.Write("Digite a Nota da Prova: ");
        NotaProva = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a Nota do Trabalho: ");
        NotaTrabalho = Convert.ToDouble(Console.ReadLine());
    }

    public void CalcularMedia()
    {
        NotaFinal = (NotaProva + NotaTrabalho) / 2;
    }

    public bool CalcularNotaFinal()
    {
        double notaNecessaria = 6.0 - NotaFinal;
        if (NotaFinal >= 6.0)
        {
            Console.WriteLine("Aluno aprovado!");
            return true;
        }
        else
        {
            Console.WriteLine($"Aluno em prova final. Precisa de {notaNecessaria:F2} pontos para ser aprovado.");
            return false;
        }
    }

    public void ImprimirNotaFinal()
    {
        Console.WriteLine($"Nota Final do aluno {Nome} ({RA}): {NotaFinal:F2}");
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();
        aluno.ReceberDados();
        aluno.CalcularMedia();
        aluno.ImprimirNotaFinal();
        aluno.CalcularNotaFinal();
    }
}
