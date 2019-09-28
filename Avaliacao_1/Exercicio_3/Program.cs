using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string resultado = string.Empty;
            Console.WriteLine("Digite um número inteiro:");
            int.TryParse(Console.ReadLine(), out numero);

            if (numero == 0)
                resultado = "nulo/zero";
            else if (numero > 0)
                resultado = "positivo";
            else
                resultado = "negativo";

            Console.WriteLine($"O número digitado é {resultado}");
            Console.ReadLine();
        }
    }
}
