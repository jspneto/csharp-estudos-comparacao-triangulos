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
        Triangulo x = new Triangulo();
        Triangulo y = new Triangulo();
        
        Console.WriteLine("Entre com os dados do primeiro triângulo:");
        x.Nome = Console.ReadLine()!;
        x.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine("Entre com as medidas do segundo triângulo:");
        y.Nome = Console.ReadLine()!;
        y.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double xArea = x.Area();
        double yArea = y.Area();

        Console.WriteLine();
        Console.WriteLine($"Área de {x.Nome}: {xArea.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Área de {y.Nome}: {yArea.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.Write("Maior área: ");

        if (xArea >= yArea)
        {
            Console.WriteLine(x.Nome);
        }
        else
        {
            Console.WriteLine(y.Nome);
        }
    }
}