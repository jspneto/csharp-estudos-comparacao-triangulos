using Projeto.Src;
using Projeto.Src.IO;

namespace Projeto;

static class ProgramExamples
{
    public static void SolucaoProblema()
    {
        Console.WriteLine("Entre com os dados do primeiro triângulo:");
        Triangulo x = TrainguloInputs.CriarTriangulo();

        Console.WriteLine();
        Console.WriteLine("Entre com os dados do segundo triângulo:");
        Triangulo y = TrainguloInputs.CriarTriangulo();

        Triangulo maiorArea = TrianguloHelpers.CompararAreas(x, y);

        Console.WriteLine();
        TrianguloOutputs.ExibirArea(x);
        TrianguloOutputs.ExibirArea(y);
        Console.WriteLine($"Maior área: {maiorArea.Nome}");
    }
}