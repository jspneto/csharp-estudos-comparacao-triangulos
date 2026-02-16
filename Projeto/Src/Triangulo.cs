using System.Globalization;

namespace Projeto.Src;

class Triangulo
{
    private string _nome;
    private double _a;
    private double _b;
    private double _c;

    public Triangulo(string nome, double a, double b, double c)
    {
        if (nome != null && nome.Length >= 3)
        {
            _nome = nome;
        }
        else
        {
            _nome = "ABC";
        }

        _a = a;
        _b = b;
        _c = c;
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
            if (value != null && value.Length >= 3)
            {
                _nome = value;
            }
            else
            {
                _nome = "ABC";
            }
        }
    }

    public double A
    {
        get
        {
            return _a;
        }
    }

    public double B
    {
        get
        {
            return _b;
        }
    }

    public double C
    {
        get
        {
            return _c;
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