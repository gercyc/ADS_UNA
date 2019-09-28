using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros");
            double num_A = 0, num_B = 0, num_C = 0;
            
            Console.WriteLine("Digite o valor para o número A:");
            double.TryParse(Console.ReadLine(), out num_A);

            Console.WriteLine("Digite o valor para o número B:");
            double.TryParse(Console.ReadLine(), out num_B);

            Console.WriteLine("Digite o valor para o número C:");
            double.TryParse(Console.ReadLine(), out num_C);

            Console.WriteLine("Impressão em ordem crescente...");
            double[] myNumbers = new double[] { num_A, num_B, num_C }.OrderBy(a => a).ToArray();
            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
            Console.ReadLine();
        }
    }
}
