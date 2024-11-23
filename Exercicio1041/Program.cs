namespace Exercicio1041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            String[] vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0]);
            y = double.Parse(vet[1]);

            if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else 
            {
                Console.WriteLine("Eixo X");
            }
        }    
    }
}
