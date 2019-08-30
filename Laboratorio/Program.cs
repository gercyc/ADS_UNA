using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamada do exercicio1
            //Exercicio1();

            //Chamada do exercicio2
            Exercicio2_novo();

        }

        /// <summary>
        /// Faz a soma de 2 numeros. 30/08/2019
        /// </summary>
        private static void Exercicio1()
        {
            int num1, num2;
            Console.WriteLine("Digite o valor do numero 1");
            int.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Digite o valor do numero 2");
            int.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("A soma de '{0}' + '{1}' é '{2}'", num1, num2, (num1 + num2));
            Console.ReadKey();
        }

        /// <summary>
        /// Recebe 3 notas e calcula a media. 30/08/2019
        /// </summary>
        private static void Exercicio2()
        {
            float nota1, nota2, nota3, media;
            Console.WriteLine("Digite o valor da 1ª nota");
            float.TryParse(Console.ReadLine(), out nota1);
            Console.WriteLine("Digite o valor da 2ª nota");
            float.TryParse(Console.ReadLine(), out nota2);
            Console.WriteLine("Digite o valor da 3ª nota");
            float.TryParse(Console.ReadLine(), out nota3);

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"A média das notas '{nota1}', '{nota2}', '{nota3}' é '{media}'");
            Console.ReadKey();
        }

        /// <summary>
        /// Outra forma de fazer o exercicio 2 com a chamada do método Avg(params float[] args)
        /// </summary>
        private static void Exercicio2_novo()
        {
            float nota1, nota2, nota3, media;
            Console.WriteLine("Digite o valor da 1ª nota");
            float.TryParse(Console.ReadLine(), out nota1);
            Console.WriteLine("Digite o valor da 2ª nota");
            float.TryParse(Console.ReadLine(), out nota2);
            Console.WriteLine("Digite o valor da 3ª nota");
            float.TryParse(Console.ReadLine(), out nota3);

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"A média das notas '{nota1}', '{nota2}', '{nota3}' é '{Avg(nota1, nota2, nota3)}'");
            Console.ReadKey();
        }

        /// <summary>
        /// Calcula a média entre números.
        /// </summary>
        /// <param name="args">10.4, 10.8, 4.5</param>
        /// <example>Avg(8.9, 4.8, 8.9)</example>
        /// <returns>Float</returns>
        private static float Avg(params float[] args)
        {
            float avg = 0;
            for (int i = 0; i < args.Length; i++)
            {
                avg += args[i];
            }
            avg = avg / args.Length;
            return avg;
        }

    }
}
