using System.Globalization;
using Projeto.Src;

namespace Projeto;

class Program
{
    static void Main(string[] args)
    {
        SolucaoProblema();
    }

    static void SolucaoProblema()
    {
        Console.WriteLine("Entre com os dados do primeiro triângulo:");
        Triangulo x = CriarTriangulo();

        Console.WriteLine();
        Console.WriteLine("Entre com os dados do segundo triângulo:");
        Triangulo y = CriarTriangulo();

        Triangulo maiorArea = CompararAreas(x, y);

        Console.WriteLine();
        ExibirArea(x);
        ExibirArea(y);
        Console.WriteLine($"Maior área: {maiorArea.Nome}");
    }

    static Triangulo CriarTriangulo()
    {
        Triangulo t = new Triangulo();

        Console.Write("Nome: ");
        t.Nome = Console.ReadLine()!;
        Console.Write("Lado A: ");
        t.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado B: ");
        t.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado C: ");
        t.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        return t;
    }

    static Triangulo CompararAreas(Triangulo t1, Triangulo t2)
    {
        if (t1.Area() >= t2.Area())
        {
            return t1;
        }
        else
        {
            return t2;
        }
    }

    static void ExibirArea(Triangulo t)
    {
        double area = t.Area();
        Console.WriteLine($"Área de {t.Nome}: {area.ToString("F4", CultureInfo.InvariantCulture)}");
    }
}