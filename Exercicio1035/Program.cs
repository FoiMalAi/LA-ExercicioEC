namespace Exercicio1035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, SOMAAB, SOMACD;

            string[] v = Console.ReadLine().Split(' ');
            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            c = int.Parse(v[2]);
            d = int.Parse(v[3]);
            SOMAAB = a + b;
            SOMACD = c + d;

            if (b > c && d > a && SOMACD > SOMAAB && c >= 0 && d >= 0 && (a % 2) == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
