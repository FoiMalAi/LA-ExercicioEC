namespace ExercicioEC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, nfinal;

            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            nfinal = n1 + n2;

            Console.WriteLine("NOTA FINAL = " + nfinal.ToString("F1"));

            if (nfinal < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }
           
        }
    }
}
 