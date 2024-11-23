namespace ExercicioEc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, menor;

            string[] v = Console.ReadLine().Split(' ');
            n1 = int.Parse(v[0]);   
            n2 = int.Parse(v[1]);
            n3 = int.Parse(v[2]);

            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine("MENOR = " + n1);
            }
            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine("MENOR = " + n2);
            }
            else
            {
                Console.WriteLine("MENOR = " + n3);
            }    

        }
    }
}
 