namespace Triangulos.ConsoleApp;
public class Triangulo
{
    public double LadoX;
    public double LadoY;
    public double LadoZ;

    public Triangulo(double ladoX, double ladoY, double ladoZ)
    {
        LadoX = ladoX;
        LadoY = ladoY;
        LadoZ = ladoZ;
    }

    public string ObterTipo()
    {
        string tipo = "";

        if (LadoX == LadoY && LadoX == LadoZ && LadoY == LadoZ)
        {
            tipo = "Equilátero";
            return tipo;
        }
        else if (LadoX != LadoY && LadoX != LadoZ && LadoY != LadoZ)
        {
            tipo = "Escaleno";
            return tipo;
        }
        else if (LadoX == LadoY || LadoX == LadoZ || LadoY == LadoZ)
        {
            tipo = "Isósceles";
            return tipo;
        }

        return tipo;
    }

    public bool TrianguloValido()
    {
        if (LadoX  > LadoY + LadoZ || LadoY > LadoX + LadoZ || LadoZ > LadoX + LadoY)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
