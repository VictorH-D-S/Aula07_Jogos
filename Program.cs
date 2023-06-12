using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Jogos
{
    class Program
    {
        static void Main(string[] args)
        {



        }

        void Atv_Jogos01()
        {
            // Programação orientada a objetes.
            
            Random sorteador = new Random();

            int sorteio = sorteador.Next(1, 11);
            int num;

            Console.WriteLine("Bem Vindo a Blaze");
            Console.WriteLine("ADVINHE O NÚMERO ENTRE 1 E 10!");
            Console.WriteLine("Digite o número: ");
            num = int.Parse(Console.ReadLine());

            if (num > 10 || num < 1)
            {
                Console.WriteLine("Hi, I'm Saul Goodman. Did you know that you have rights? The constitution says you do! And so do I.");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            if (num == sorteio)
            {
                Console.WriteLine("Tu ganhou piá");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            Console.WriteLine("Perdeste. Boa sorte em me achar em Curaçao.");

            Console.ReadKey();
        }
    }
}
