using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado_A, lado_B;
            Console.WriteLine("Digite o valor para o lado A:");
            double.TryParse(Console.ReadLine(), out lado_A);

            Console.WriteLine("Digite o valor para o lado B:");
            double.TryParse(Console.ReadLine(), out lado_B);

            bool isQuadrado = lado_A.Equals(lado_B);
            string msg = string.Concat("A figura informada ", (isQuadrado ? "é " : "não é "), "um quadrado!");
            Console.WriteLine(msg);

            Console.WriteLine($"O perímetro é {2 * (lado_A + lado_B)}");
            Console.WriteLine($"A área é {lado_A * lado_B }");
            Console.ReadKey();
        }
    }
}
