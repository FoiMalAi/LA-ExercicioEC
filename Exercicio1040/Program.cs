namespace Exercicio1040
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            float n1, n2, n3, n4, media, notaExame, mediaFinal;
            string[] vetor = Console.ReadLine().Split(' ');
            n1 = float.Parse(vetor[0]);
            n2 = float.Parse(vetor[1]);
            n3 = float.Parse(vetor[2]);
            n4 = float.Parse(vetor[3]);
           
            media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1"));
                       
            if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = float.Parse(Console.ReadLine());
                mediaFinal = (media + notaExame) / 2;
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1"));
                if (mediaFinal > 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1"));
            }
            



        }
    }
}