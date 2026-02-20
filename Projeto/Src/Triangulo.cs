using System.Globalization;

namespace Projeto.Src;

class Triangulo
{
    private string _nome;
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }

    public Triangulo(string nome, double a, double b, double c)
    {
        A = ValidarLado(a);
        B = ValidarLado(b);
        C = ValidarLado(c);

        if (!DesigualdadeTriangular(A, B, C))
        {
            A = 1.0;
            B = 1.0;
            C = 1.0;
        }

        if (NomeValido(nome))
        {
            _nome = nome;
        }
        else
        {
            _nome = "ABC";
        }
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
            if (NomeValido(value))
            {
                _nome = value;
            }
        }
    }

    private static bool NomeValido(string nome)
    {
        if (nome != null && nome.Length >= 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static double ValidarLado(double medida)
    {
        if (medida > 0.0)
        {
            return medida;
        }
        else
        {
            return 1.0;
        }
    }

    private static bool DesigualdadeTriangular(double a, double b, double c)
    {
        if (a + b > c && a + c > b && b + c > a)
        {
            return true;
        }
        else
        {
            return false;
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