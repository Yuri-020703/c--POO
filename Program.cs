using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alugar_Quartos_Para_Estudantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] vect = new Estudantes[10];

            Console.Write("Quantos quartos você deseja alugar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nome do Aluno: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Número do quarto (1-10): ");
                int quarto = int.Parse(Console.ReadLine());
                if (quarto < 1 || quarto > 10)
                {
                    Console.Write("Você deve escolher número o do quarto de 1 a 10 !");
                }
                vect[quarto] = new Estudantes(nome, email);
            }

            Console.Write("Quartos ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + "- " + vect[i]);
                }
            }
        }
    }
}
