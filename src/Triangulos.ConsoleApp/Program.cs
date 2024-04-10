namespace Triangulos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo(2, 2, 3);

            // Verificando se o triângulo é válido
            if (t.TrianguloValido())
            {
                Console.WriteLine("O triângulo é válido");
                Console.WriteLine("O triângulo é " + t.ObterTipo());
            }
            else
            {
                Console.WriteLine("O triângulo não é válido");
            }
        }
    }
}
