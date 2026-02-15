namespace Projeto.Src;

static class TrianguloHelpers
{
    public static Triangulo CompararAreas(Triangulo t1, Triangulo t2)
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
}