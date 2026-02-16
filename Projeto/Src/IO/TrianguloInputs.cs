using System.Globalization;

namespace Projeto.Src.IO;

static class TrianguloInputs
{
    public static Triangulo CriarTriangulo()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Lado A: ");
        double a = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado B: ");
        double b = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Lado C: ");
        double c = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Triangulo t = new Triangulo(nome, a, b, c);

        return t;
    }
}