using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio_5();
        }
        /// <summary>
        /// 1)Faça um programa que receba quatro números inteiros, calcule e mostre a soma desses números.
        /// </summary>
        static void Exercicio_1()
        {
            int sum = 0;
            string[] inputLine = new string[4];
            Console.WriteLine("Digite 4 numeros, separe por ponto e virgula. Ex: 3;4;5");
            inputLine = Console.ReadLine().Split(';');
            foreach (var n in inputLine)
            {
                sum += Convert.ToInt32(n);
            }
            Console.WriteLine($"A soma dos numeros digitados é {sum}");
            Console.ReadLine();
        }

        /// <summary>
        /// 2)Faça um programa que receba três notas, calcule e mostre a média aritmética.
        /// </summary>
        static void Exercicio_2()
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
        /// 3)Faça um programa que receba três notas e seus respectivos pesos, calcule e mostre amédia ponderada.
        /// A média aritmética ponderada é calculada multiplicando cada valor do conjunto de dados pelo seu peso.
        ///Depois, encontra-se a soma desses valores que será dividida pela soma dos pesos.
        /// Mp = p1*x1 + p2*x2 / p1 + p2
        /// <seealso cref="https://www.todamateria.com.br/media/"/>
        /// </summary>
        static void Exercicio_3()
        {
            double nota1, nota2, nota3, pesoNota1, pesoNota2, pesoNota3, mediaPonderada = 0;
            Console.WriteLine("Digite 3 notas e seus respectivos pesos. \nUma nota de cada vez, ex: Nota 1 = 3, Peso = 2");

            Console.WriteLine("Digite o valor para a nota 1");
            double.TryParse(Console.ReadLine(), out nota1);
            Console.WriteLine("Digite o peso para a nota 1");
            double.TryParse(Console.ReadLine(), out pesoNota1);

            Console.WriteLine("Digite o valor para a nota 2");
            double.TryParse(Console.ReadLine(), out nota2);
            Console.WriteLine("Digite o peso para a nota 2");
            double.TryParse(Console.ReadLine(), out pesoNota2);

            Console.WriteLine("Digite o valor para a nota 3");
            double.TryParse(Console.ReadLine(), out nota3);
            Console.WriteLine("Digite o peso para a nota 3");
            double.TryParse(Console.ReadLine(), out pesoNota3);

            mediaPonderada = ((nota1 * pesoNota1) + (nota2 * pesoNota2) + (nota3 * pesoNota3)) / (pesoNota1 + pesoNota2 + pesoNota3);

            Console.WriteLine($"A media ponderada das notas é {mediaPonderada}");

            Console.ReadLine();
        }

        /// <summary>
        /// 4)Faça um programa que receba o salário de um funcionário e o percentual de aumento, 
        /// calcule e mostre o valor do aumento e o novo salário.
        /// </summary>
        static void Exercicio_4()
        {
            double salario = 0, percentual = 0;
            Console.WriteLine("Digite o salario:");
            double.TryParse(Console.ReadLine(), out salario);

            Console.WriteLine("Digite o percentual de aumento:");
            double.TryParse(Console.ReadLine(), out percentual);

            Console.WriteLine($"O valor do aumento será de {salario * (percentual / 100)}");

            Console.WriteLine($"O valor do novo salário será de {salario + (salario * (percentual / 100))}");
            Console.ReadLine();

        }

        /// <summary>
        /// 5)Faça um programa que receba o salário base de um funcionário, calcule e mostre o salário a receber,
        /// sabendo-se que o funcionário tem gratificação de 5% sobre o salário base e paga imposto de 7% também sobre o salário base.
        /// </summary>
        static void Exercicio_5()
        {
            double salario = 0;
            Console.WriteLine("Digite o salario:");
            double.TryParse(Console.ReadLine(), out salario);

            Console.WriteLine($"O valor líquido do salário será é {salario - (salario * 7 / 100) + (salario * 5 / 100)}");
            Console.ReadLine();
        }
    }
}
