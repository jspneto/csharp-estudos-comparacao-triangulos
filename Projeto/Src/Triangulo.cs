using System.Globalization;

namespace Projeto.Src;

class Triangulo
{
    public string Nome;
    public double A;
    public double B;
    public double C;

    public Triangulo(string nome, double a, double b, double c)
    {
        if (nome != null && nome.Length >= 3)
        {
            Nome = nome;
        }
        else
        {
            Nome = "ABC";
        }

        A = a;
        B = b;
        C = c;
    }

    public double Area()
    {
        double p = (A + B + C) / 2.0;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\n"
            + $"Lado A = {A.ToString("F4", CultureInfo.InvariantCulture)}\n"
            + $"Lado B = {B.ToString("F4", CultureInfo.InvariantCulture)}\n"
            + $"Lado C = {C.ToString("F4", CultureInfo.InvariantCulture)}\n"
            + $"Área = {Area().ToString("F4", CultureInfo.InvariantCulture)}";
    }
}