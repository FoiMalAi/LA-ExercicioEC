namespace Exercicio1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Salario, SalarioNovo, reajuste;
            double porcentagem;

            Salario = double.Parse(Console.ReadLine());

            if (Salario <= 400.00)
            {
                porcentagem = 15.0;
            }
            else if (Salario <= 800.00)
            {
                porcentagem = 12.0;
            }
            else if (Salario <= 1200.00)
            {
                porcentagem = 10.0;
            }
            else if (Salario <= 2000.00)
            {
                porcentagem = 7.0;
            }
            else
            {
                porcentagem = 4.0;
            }

            reajuste = Salario * porcentagem / 100;
            SalarioNovo = reajuste + Salario;

            Console.WriteLine("Novo salario: " + SalarioNovo.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"));
            Console.WriteLine("Em percentual: " + porcentagem + " %");
                       
        }
    }
}
