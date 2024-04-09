namespace Triangulos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao = 'S';
            do
            {
                Console.WriteLine("Digite o primeiro segmento: ");
                Triangulos.x = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo segmento: ");
                Triangulos.y = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o terceiro segmento: ");
                Triangulos.z = double.Parse(Console.ReadLine());



                if (Triangulos.TrianguloPodeSerCriado(Triangulos.x, Triangulos.y, Triangulos.z) == false)
                {
                    Console.WriteLine("Por favor digite uma opção válida");
                } 
                else if ()

                Console.WriteLine("Deseja continuar (S/N)");
                opcao = char.Parse(Console.ReadLine());

            } while (opcao != 'N' || opcao != 'n');
        }
    }

    public static class Triangulos
    {
        public static double x;
        public static double y;
        public static double z;

        public static bool TrianguloPodeSerCriado(double x, double y, double z)
        {
            if (x < y + z && y < x + z && z < x + y)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public static string TrianguloEscaleno()
        {

        }

        public static string TrianguloIsosceles()
        {

        }

        public static string TrianguloEquilatero()
        {

        }
    }
}
