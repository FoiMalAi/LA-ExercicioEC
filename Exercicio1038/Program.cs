using System.Numerics;

namespace Exercicio1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int cod = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);

            double total;

            if (cod == 1)
            {
                total = qtd * 4.0;
            }
            else if (cod == 2)
            {
                total = qtd * 4.50;
            }
            else if (cod == 3)
            {
                total = qtd * 5.0;
            }
            else if (cod == 4)
            {
                total = qtd * 2.0;
            }
            else 
            {
                total = qtd * 1.50;
            }
            
            Console.WriteLine("Total: R$ " + total.ToString("F2"));
            
        }
    }
}
