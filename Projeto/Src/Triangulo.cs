using System.Globalization;

namespace Projeto.Src;

class Triangulo
{
    private string _nome;
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set;}

    public Triangulo(string nome, double a, double b, double c)
    {
        _nome = ValidarNome(nome);
        A = a;
        B = b;
        C = c;
    }

    public Triangulo(string nome) : this(nome, 3.0, 4.0, 5.0) {}

    public string Nome
    {
        get
        {
            return _nome;
        }

        set
        {
            _nome = ValidarNome(value);
        }
    }

    private static string ValidarNome(string nome)
    {
        if (nome != null && nome.Length >= 3)
        {
            return nome;
        }
        else
        {
            return "ABC";
        }
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