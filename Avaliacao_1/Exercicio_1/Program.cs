using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora, minuto;
            Console.WriteLine("Digite a hora:");
            int.TryParse(Console.ReadLine(), out hora);
            Console.WriteLine("Digite os minutos:");
            int.TryParse(Console.ReadLine(), out minuto);
            double amountMinutes = TimeSpan.FromHours(hora).TotalMinutes;
            Console.WriteLine($"Hora convertida em minutos {amountMinutes}");
            Console.WriteLine($"Total dos minutos {amountMinutes + minuto}");
            Console.WriteLine($"Total dos minutos convertidos em segundos {TimeSpan.FromMinutes(amountMinutes + minuto).TotalSeconds}");
            Console.ReadKey();
        }
    }
}
