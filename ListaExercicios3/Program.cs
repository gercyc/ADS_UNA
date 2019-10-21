using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ListaExercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio_10();
        }

        private static void Exercicio_10()
        {
            //Faça um programa que receba o número, calcule e mostre a tabuada desse número
            int num;
            Write("Digita um numero: ");
            int.TryParse(ReadLine(), out num);
            for (int i = 0; i < 11; i++)
            {
                WriteLine($"{num} X {i} = {num*i}");
            }
            ReadKey();
        }

        private static void Exercicio_9()
        {
            /*
             Faça um programa que receba um número inteiro maior que 1, verifique se o
            número fornecido é primo ou não e mostre uma mensagem de número primo ou de
            número não primo. Um número é primo quando é divisível apenas por 1 e por ele
            mesmo.
             */
            double num;
            string option = "S";
            do
            {
                WriteLine("Digite um numero maior que 1");
                double.TryParse(ReadLine(), out num);
                if (num % 2 == 0)
                    WriteLine($"O numero {num} não é primo");
                else
                    WriteLine($"O numero {num} é primo");

                WriteLine("Executar novamente? (S/N)");
                option = ReadLine().ToUpper();

            }
            while (num < 0 || option != "N");

        }

        private static void Exercicio_8()
        {
            /*
            Em um campeonato de futebol existem cinco times e cada um e cada um possui
            onze jogadores. Faça um programa que receba a idade, o peso e a altura de cada
            jogador, calcule e mostre:
            1) a quantidade de jogadores com idade inferior a 18 anos;
            2) a média das idades dos jogadores de cada time;
            3) a média das alturas de todos os jogadores do campeonato; e
            4) a porcentagem de jogadores com mais de 80 kg entre todos os jogadores do campeonato
             */

            int[] idades = new int[11];
            double[] pesos = new double[11];
            double[] alturas = new double[11];
            string[] mediaIdadeTimes = new string[5];
            int jogadorMenor18Anos = 0, jogadorMais80kg = 0;
            double alturaTotal = 0;
            Random rnd = new Random(1);

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 11; j++)
                {
                    idades[j] = rnd.Next(15, 30);
                    pesos[j] = rnd.Next(69, 95);
                    alturas[j] = rnd.Next(1, 3);
                }

                alturaTotal += alturas.Sum();
                jogadorMenor18Anos += idades.Count(id => id < 18);
                jogadorMais80kg += pesos.Count(p => p > 80);

                mediaIdadeTimes[i] = $"Media de idade dos jogadores do time {i}: {idades.Sum() / idades.Length}";

            }

            WriteLine($"Jogadores menores de 18 anos: {jogadorMenor18Anos}");

            foreach (var msg in mediaIdadeTimes)
            {
                WriteLine(msg);
            }
            WriteLine($"Altura media dos jogadores: {alturaTotal / 55}");
            WriteLine($"Porcentagem de jogadores com mais de 80KG: {(((double)jogadorMais80kg / 55) * 100):F2} %");


            ReadKey();

        }

        private static void Exercicio_7()
        {
            /*
             Faça um programa que leia cinco grupos de quatro valores (A, B, C, D) e
            mostre-os na ordem lida. Em seguida organize-os em ordem crescente e decrescente.
             */
            var rnd = new Random(1);
            const int MAX = 100;
            int vlr = 0;
            for (int i = 0; i < 5; i++)
            {
                int[] arr = new int[4] { rnd.Next(MAX), rnd.Next(MAX), rnd.Next(MAX), rnd.Next(MAX) };
                vlr = 0;
                WriteLine($"Valores Grupo {i}");
                foreach (var valor in arr)
                {
                    WriteLine($"Valor {GetLetterValue(vlr)}: {valor}");
                    vlr++;
                }

                vlr = 0;
                WriteLine("\nOrdem Crescente");
                foreach (var valor in arr.OrderBy(n => n))
                {
                    WriteLine($"Valor {GetLetterValue(vlr)}: {valor}");
                    vlr++;
                }

                vlr = 0;
                WriteLine("\nOrdem Decrescente");
                foreach (var valor in arr.OrderByDescending(n => n))
                {
                    WriteLine($"Valor {GetLetterValue(vlr)}: {valor}");
                    vlr++;
                }

                WriteLine("------- \n");

            }
            ReadKey();

        }
        private static string GetLetterValue(int number)
        {
            string letter = string.Empty;

            switch (number)
            {
                case 0:
                    letter = "A";
                    break;
                case 1:
                    letter = "B";
                    break;
                case 2:
                    letter = "C";
                    break;
                case 3:
                    letter = "D";
                    break;
                default:
                    letter = "A";
                    break;
            }

            return letter;
        }

        private static void Exercicio_6()
        {

            /*
             Faça um programa que receba duas notas de seis alunos. Calcule e mostre:
            • a média aritmética das duas notas de cada aluno; e
            • a mensagem que está na tabela a seguir:

            |Media           | Mensagem      |
            |--------------------------------|
            |Ate 3           | Reprovado     |
            |Entre 3 e 7     | Exame         |
            |De 7 pra cima   | Aprovado      |

             */
            var rnd = new Random(new Random().Next(5));

            for (int i = 0; i < 6; i++)
            {
                var aluno = new Aluno(rnd.Next(1, 10), rnd.Next(1, 10));

                WriteLine($"Aluno {aluno.Nome} | Nota A: {aluno.Nota_A} | Nota B: {aluno.Nota_B} | Media: {aluno.MediaNotas}");

                if (aluno.MediaNotas < 3)
                    WriteLine($"Aluno {aluno.Nome} reprovado!");
                else if (aluno.MediaNotas >= 3 && aluno.MediaNotas <= 7)
                    WriteLine($"Aluno {aluno.Nome} em exame!");
                else
                    WriteLine($"Aluno {aluno.Nome} aprovado!");

                WriteLine("");
            }
            ReadKey();

        }
        internal class Aluno
        {
            public string Nome { get; set; }
            public double Nota_A { get; set; }
            public double Nota_B { get; set; }
            public double MediaNotas { get; set; }
            public Aluno(double nota_a, double nota_b)
            {
                Nome = Guid.NewGuid().ToString();
                Nota_A = nota_a;
                Nota_B = nota_b;
                MediaNotas = (Nota_A + Nota_B) / 2;
            }
        }

        private static void Exercicio_5()
        {
            /*
                Faça um programa que receba o salário de um funcionário chamado Carlos.
                Sabe-se que outro funcionário, João, tem salário equivalente a um terço do salário de
                Carlos. Carlos aplicará seu salário integralmente na caderneta de poupança, que rende
                2% ao mês, João aplicará seu salário integralmente no fundo de renda fixa, que rende
                5% ao mês. O programa deverá calcular a mostrar a quantidade de meses necessários
                para que o valor pertencente a João iguale ou ultrapasse o valor pertencente a Carlos.
             */

            double salCarlos, salJoao, meses = 0;

            WriteLine("Digite o salario de Carlos:");
            double.TryParse(ReadLine(), out salCarlos);
            salJoao = salCarlos / 3;
            while (salJoao < salCarlos)
            {
                salCarlos = salCarlos + (salCarlos * 2 / 100);
                salJoao = salJoao + (salJoao * 5 / 100);

                meses++;
            }
            WriteLine($"Joao devera manter seu $$ por {meses} meses na aplicação para alcançar o salario de Carlos!");
            WriteLine($"Carlos tera {salCarlos} no final do periodo aplicado");
            WriteLine($"Joao tera {salJoao} no final do periodo aplicado");
            ReadKey();

        }

        private static void Exercicio_4()
        {
            /*
             Faça um programa para calcular a área de um triângulo e que não permita a
 entrada de dados inválidos, ou seja, medidas menores ou iguais a zero.
              */
            double baseTriangulo, altura;
            string option = "S";

            while (option == "S")
            {
                WriteLine("Digita o valor da base do triangulo");
                double.TryParse(ReadLine(), out baseTriangulo);
                if (baseTriangulo <= 0)
                {
                    WriteLine("Valor invalido para base, digita novamente!!");
                    double.TryParse(ReadLine(), out baseTriangulo);
                }

                WriteLine("Digita o valor da altura do triangulo");
                double.TryParse(ReadLine(), out altura);
                if (altura <= 0)
                {
                    WriteLine("Valor invalido para altura, digita novamente!!");
                    double.TryParse(ReadLine(), out altura);
                }

                WriteLine($"A area do triangulo informado é {baseTriangulo * altura / 2}");

                WriteLine("Novo calculo? (S/N)");
                option = ReadLine().ToUpper();

            }
            ReadKey();

        }

        private static void Exercicio_3()
        {
            /*
                Faça um programa que mostre os N primeiros termo da sequência de Fibonacci.
                A sequência de Fibonacci é uma sequência de números inteiros, começando por 0 e 1,
                na qual, cada termo subsequente (numero de Fibonacci) corresponde a soma dos dois
                anteriores. Exemplo: 0 – 1 – 1 – 2 – 3 – 5 – 8 – 13 – 21 –34 – 55 ...
             */

            int numero = 10;
            //WriteLine("Digite um numero inteiro maior que 0");
            //double.TryParse(ReadLine(), out numero);

            WriteLine(0);
            WriteLine(1);

            for (int i = 1; i < numero; i++)
            {
                WriteLine(fib(i));
            }
            ReadKey();

        }

        static int fib(int seq)
        {
            int firstSeq = 0,
                secondSeq = 1,
                nextSeq;

            for (int i = 0; i < seq; i++)
            {
                nextSeq = firstSeq + secondSeq;
                firstSeq = secondSeq;
                secondSeq = nextSeq;
            }

            return secondSeq;
        }

        private static void Exercicio_2()
        {
            /*
             Faça um programa leia um valor N inteiro e positivo. Calcule e mostre o fatorial de N.
             */
            double numero = 0;
            double fatorial = 0;
            bool first = false, again = true;

            while (again)
            {
                WriteLine("Digite um numero inteiro maior que 0");
                double.TryParse(ReadLine(), out numero);

                for (double i = numero - 1; i >= 1; i--)
                {
                    if (!first)
                    {
                        fatorial = numero * i;
                        first = true;

                    }
                    else
                        fatorial *= i;
                }

                WriteLine($"Fatorial é {fatorial}");
                WriteLine("Executar novamente?! (S/N)");
                fatorial = 0;
                first = false;

                switch (ReadLine().ToUpper())
                {
                    case "S":
                        again = true;
                        break;
                    case "N":
                        again = false;
                        break;
                    default:
                        WriteLine("Opção invalida!! Digite S ou N");
                        again = true;
                        break;
                }

            }


            ReadKey();
        }

        private static void Exercicio_1()
        {
            /*
             * Um funcionário  de  uma  empresa  recebe,  anualmente,  aumento  salarial.  
             * Sabe-se que: 
             * Esse funcionário foi contratado em 2005, com salário inicial de R$ 1.000,00.
             * Em 2006, ele recebeu aumento de 1,5% sobre seu salário inicial.
             * A  partir  de  2007 (inclusive),  os  aumentos  salariais  sempre  corresponderam  ao dobro do percentual do ano anterior.
             * Faça um programa que determine o salário atual desse funcionário.
             */

            var salInicial = 1000m;
            var salFinal = 0m;
            var percAumento = (decimal)(1.5 / 100);
            DateTime dtContratacao = new DateTime(2005, 1, 1);
            DateTime dtAux = dtContratacao;

            while (dtAux.Year <= DateTime.Now.Year)
            {
                if (dtAux.Year == 2006)
                {
                    salFinal = salInicial + (salInicial * percAumento);
                }
                else if (dtAux.Year <= 2005)
                {

                }
                else
                {
                    percAumento = percAumento * 2;
                    salFinal = salFinal + (salFinal * percAumento);
                }

                dtAux = dtAux.AddYears(1);
            }

            Console.WriteLine($"Salario final é {salFinal.ToString("N2")}");
            Console.ReadKey();

        }
    }
}
