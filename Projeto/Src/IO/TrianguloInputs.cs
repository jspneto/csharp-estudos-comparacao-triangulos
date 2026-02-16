using System.Globalization;

namespace Projeto.Src.IO;

static class TrianguloInputs
{
    public static Triangulo CriarTriangulo()
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
}