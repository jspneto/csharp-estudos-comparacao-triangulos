using System.Globalization;

namespace Projeto.Src.IO;

static class TrianguloOutputs
{
    public static void ExibirArea(Triangulo t)
    {
        double area = t.Area();
        Console.WriteLine($"Área de {t.Nome}: {area.ToString("F4", CultureInfo.InvariantCulture)}");
    }
}