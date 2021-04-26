using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--Análise de Crédito--\n");
            Console.ResetColor();

            double valorSolic;
            double quantParcelas;
            double renda; 

            double porcentagemUm;
            double porcentagemDois;
            double porcentagem;

            Console.WriteLine("\nPara iniciar a análise digite:\n");

            Console.Write("Valor solicitado.................: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            valorSolic = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Quantidade de parcelas desejada..:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            quantParcelas = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Renda mensal.....................: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            renda = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            porcentagemUm = 30/10;
            porcentagemDois = renda/10;
            porcentagem = porcentagemUm * porcentagemDois;

            if (valorSolic > porcentagem)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNão é possível realizar um empréstimo que ultrapasse 30% da renda.\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nÉ possível realizar um empréstimo de R${valorSolic} em {quantParcelas} parcelas.\n");
                Console.ResetColor();
            }
            
            

        }
    }
}
