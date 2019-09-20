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
            Exercicio_1();
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

        /// <summary>
        /// 6)Faça um programa que calcule e mostre a área de um triangulo.
        ///Sabe-se que: Área do triângulo = (base x altura) / 2.
        /// </summary>
        /// <returns></returns>
        static void Exercicio_6()
        {
            double medidaBase, altura;
            Console.WriteLine("Digite o a medida da base do triangulo:");
            double.TryParse(Console.ReadLine(), out medidaBase);

            Console.WriteLine("Digite o a medida da altura do triangulo:");
            double.TryParse(Console.ReadLine(), out altura);

            Console.WriteLine($"A área do triangulo é {(medidaBase * altura) / 2}");
            Console.ReadLine();
        }

        /// <summary>
        /// Faça um programa que receba um número positivo e maior que zero, calcule e mostre: o
        ///número digitado ao quadrado, ao cubo, sua raiz quadrada e sua raiz cúbica.
        /// </summary>
        static void Exercicio_7()
        {
            double numero;
            Console.WriteLine("Digite um numero:");
            double.TryParse(Console.ReadLine(), out numero);

            Console.WriteLine($"{numero} ao quadrado: {Math.Pow(numero, 2)}");
            Console.WriteLine($"{numero} ao cubo: {Math.Pow(numero, 3)}");
            Console.WriteLine($"Raiz quadrada: {Math.Sqrt(numero)}");
            Console.WriteLine($"Raiz cubica: {Math.Pow(numero, (1.0 / 3.0))}");

            Console.ReadLine();
        }

        /// <summary>
        /// Faça um programa que receba dois números maiores que zero, calcule e mostre um
        /// elevado ao outro.
        /// </summary>
        static void Exercicio_8()
        {
            double numero_1, numero_2;
            Console.WriteLine("Digite um numero maior que zero:");
            double.TryParse(Console.ReadLine(), out numero_1);

            Console.WriteLine("Digite outro numero maior que zero:");
            double.TryParse(Console.ReadLine(), out numero_2);

            if (numero_1 > 0 && numero_2 > 0)
                Console.WriteLine($"{numero_1} elevado a {numero_2}: {Math.Pow(numero_1, numero_2)}");
            else
                Console.WriteLine("Os dois numeros devem ser maior que zero!!!");

            Console.ReadLine();
        }

        /// <summary>
        /// Sabe-se que: 1 pé = 12 polegadas, 1 jarda = 3 pés, 1 milha = 1,760 jarda. Faça um
        /// programa que receba uma medida em pés, faça as conversões a seguir e mostre os
        /// resultados:
        /// a) polegadas, b) jardas, c) milhas.
        /// </summary>
        static void Exercicio_9()
        {
            double numero_1;
            Console.WriteLine("Digite uma medida em 'pés':");
            double.TryParse(Console.ReadLine(), out numero_1);

            Console.WriteLine($"A medida em polegada é:{numero_1 * 12}");
            Console.WriteLine($"A medida em jardas é:{numero_1 * 12 / 3}");
            Console.WriteLine($"A medida em milhas é:{ ((numero_1 / 3) * 3) * 1.76}");


            Console.ReadLine();
        }

        /// <summary>
        /// Faça um programa que receba o ano de nascimento de uma pessoa e o ano atual, calcule
        /// e mostre:
        /// a) a idade dessa pessoa, b) quantos anos ela terá em 2050.
        /// </summary>
        static void Exercicio_10()
        {
            int anoNascimento;
            Console.WriteLine("Digite seu ano de nascimento:");
            int.TryParse(Console.ReadLine(), out anoNascimento);

            Console.WriteLine($"A sua idade é:{anoNascimento - DateTime.Now.Year}");
            Console.WriteLine($"Você terá {2050 - anoNascimento} anos em 2050");


            Console.ReadLine();
        }

        /// <summary>
        /// O custo ao consumidor de um carro novo é a soma do preço de fábrica com o percentual
        /// de lucro do distribuidor e dos impostos aplicados ao preço de fábrica.Faça um programa
        /// que receba o preço de fábrica de um veículo, o percentual de lucro do distribuidor e o
        /// percentual de impostos, calcule e mostre:
        /// a) o valor correspondente ao lucro do distribuidor, b) o valor correspondente aos
        /// impostos, c) o preço final do veículo.
        /// </summary>
        static void Exercicio_11()
        {
            double precoFabrica, percentualLucro, percentualImpostos;
            Console.WriteLine("Digite o valor de fabrica:");
            double.TryParse(Console.ReadLine(), out precoFabrica);

            Console.WriteLine("Digite o percentual de lucro do distribuidor:");
            double.TryParse(Console.ReadLine(), out percentualLucro);


            Console.WriteLine("Digite o percentual de impostos:");
            double.TryParse(Console.ReadLine(), out percentualImpostos);


            Console.WriteLine($"O lucro será: {precoFabrica * (percentualLucro / 100)}");
            Console.WriteLine($"O valor dos impostos será: {precoFabrica * (percentualImpostos / 100)}");
            Console.WriteLine($"O valor final do veículo será: {precoFabrica + ((percentualImpostos / 100) + (percentualLucro / 100))}");

            Console.ReadLine();
        }

        /// <summary>
        /// Cada degrau de uma escada tem X de altura. Faça um programa que receba essa altura e
        /// a altura que o usuário deseja alcançar subindo a escada, calcule e mostre quantos
        /// degraus ele deverá subir para atingir seu objetivo, sem se preocupar com a altura do
        /// usuário.
        /// </summary>
        static void Exercicio_12()
        {
            double alturaDegrau, alturaDesejada;
            Console.WriteLine("Digite o valor da altura de cada degrau:");
            double.TryParse(Console.ReadLine(), out alturaDegrau);

            Console.WriteLine("Digite o valor da altura que deseja alcançar:");
            double.TryParse(Console.ReadLine(), out alturaDesejada);

            Console.WriteLine($"Você precisará subir {alturaDesejada / alturaDegrau} degraus para alcançar a altura {alturaDesejada}");

            Console.ReadLine();
        }

        /// <summary>
        /// Faça um programa que receba a medida do ângulo (em graus) formado por uma escada
        ///apoiada no chão e encostada na parede e a altura da parede onde está a ponta da escada.
        ///Calcule e mostre a medida dessa escada. Observação: as funções trigonométricas
        ///implementadas nas linguagens de programação trabalham com medidas de ângulos em
        ///radianos, 180º graus = pi rad.
        /// </summary>
        static void Exercicio_13()
        {
            double angulo = 0, altura = 0;
            Console.WriteLine("Digite a medida em angulo: ");
            double.TryParse(Console.ReadLine(), out angulo);

            Console.WriteLine("Digite a altura da parede:");
            double.TryParse(Console.ReadLine(), out altura);

            //ref: http://www.vcskicks.com/csharp_net_angles.php
            var cosAngulo = Math.Sin(Math.PI * angulo / 180);

            Console.WriteLine($"A altura da escada é: {cosAngulo * altura}");

            Console.ReadKey();

        }

        /// <summary>
        ///  Faça um programa que receba um número real, encontre e mostre:
        /// a) a parte inteira, b) a parte fracionária, c) o arredondamento.
        /// </summary>
        static void Exercicio_14()
        {
            Console.WriteLine("Informe um numero real:");
            double numero;
            double.TryParse(Console.ReadLine(), out numero);

            Console.WriteLine($"a) Parte inteira: {Math.Truncate(numero)}");
            //Console.WriteLine($"b) Parte fracionária: {Math.(numero)}");
            Console.WriteLine($"a) Parte inteira: {Math.Truncate(numero)}");


        }

        /// <summary>
        /// Faça um programa que receba a hora formada por hora e minuto. Calcule e mostre a
        ///hora digitada em minutos.
        /// </summary>
        static void Exercicio_15()
        {
            Console.WriteLine("Digite a hora (Formato HH:MM)");
            TimeSpan ts;
            TimeSpan.TryParse(Console.ReadLine(), out ts);
            Console.WriteLine($"Minutos: {ts.TotalMinutes}");
            Console.ReadLine();
        }

        /// <summary>
        /// Fala um programa que receba o custo de um espetáculo teatral e o preço do convite
        ///desse espetáculo.Esse programa deverá calcular e mostrar a quantidade de convites que
        ///devem ser vendidos para que, pelo menos, o custo do espetáculo seja alcançado.
        /// </summary>
        static void Exercicio_16()
        {
            decimal custo, precoConvite;
            Console.WriteLine("Digite o custo do espetaculo");
            decimal.TryParse(Console.ReadLine(), out custo);
            Console.WriteLine("Digite o preço do convite");
            decimal.TryParse(Console.ReadLine(), out precoConvite);

            Console.WriteLine($"Deverão ser vendidos ao menos {custo / precoConvite} convites para cobrir o custo!");

            Console.ReadLine();
        }

        /// <summary>
        ///Faça um programa que calcule e mostre a tabuada de um número digitado pelo usuário.
        ///Exemplo: Digite um número = 5 x 0 = 0, 5 x 1 = 5, 5 x 2 = 10, 5 x 3 = 15, 5 x 4 = 20, 5 x
        ///5 = 25, 5 x 6 = 30, 5 x 7 = 35, 5 x 8 = 40, 5 x 9 = 45, 5 x 10 = 50. 
        /// </summary>
        static void Exercicio_17()
        {
            Console.WriteLine("Digite um numero INTEIRO: ");
            int num;
            int.TryParse(Console.ReadLine(), out num);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Faça um programa que receba o ano de nascimento de uma pessoa e o ano atual, calcule
        /// e mostre a idade da pessoa em:
        /// a) anos, b) meses, c) dias, d) semanas.
        /// </summary>
        static void Exercicio_18()
        {
            int ano, currentYear;
            Console.WriteLine("Digite seu ano de nascimento");
            int.TryParse(Console.ReadLine(), out ano);

            Console.WriteLine("Digite o ano atual");
            int.TryParse(Console.ReadLine(), out currentYear);

            int idade = (currentYear - ano);
            int meses = idade * 12;
            int dias = 0, aux = 0;

            while (aux <= idade)
            {
                for (int i = 1; i <= 12; i++)
                {
                    dias = dias + DateTime.DaysInMonth(ano, i);
                }
                ano++;
                aux++;
            }

            Console.WriteLine($"Sua idade em anos é {idade}, em meses é {meses} em semanas é {dias / 7} e em dias é {dias}");
            Console.ReadLine();
        }

        /// <summary>
        /// Fala um programa que receba o valor dos catetos de um triângulo, calcule e mostre o valor da hipotenusa.
        /// soma dos quadrados dos catetos é igual ao quadrado da hipotenusa...
        /// </summary>
        static void Exercicio_19()
        {
            double cateto_1 = 0, cateto_2 = 0, hipotenusa = 0;
            Console.WriteLine("Digite o valor de um cateto: ");
            double.TryParse(Console.ReadLine(), out cateto_1);

            Console.WriteLine("Digite o valor de outro cateto: ");
            double.TryParse(Console.ReadLine(), out cateto_2);

            double somaQuadradosCatetos = (Math.Pow(cateto_1, 2)) + (Math.Pow(cateto_2, 2));
            hipotenusa = Math.Sqrt(somaQuadradosCatetos);

            Console.WriteLine($"O valor da hipotenusa é: {hipotenusa}");

            Console.ReadKey();
        }

        /// <summary>
        /// Faça um programa que receba o raio, calcule e mostre:
        /// a) o comprimento de um esfera, C = 2 * pi* R,
        /// b) a área da esfera, A = pi * R²,
        /// c) o volume da esfera, V = 1 / 4 * pi * R
        /// </summary>
        static void Exercicio_20()
        {
            Console.WriteLine("Digite o valor do raio: ");
            double raio;
            double.TryParse(Console.ReadLine(), out raio);

            Console.WriteLine($"O comprimento da esfera é: {2 * Math.PI * raio}");
            Console.WriteLine($"A área da esfera é: {Math.PI * Math.Pow(raio, 2)}");
            Console.WriteLine($"O volume da esfera é: {1 / 4 * Math.PI * raio}");
            Console.ReadKey();
        }

        /// <summary>
        /// Sabe-se que, para iluminar de maneira correta os cômodos de uma casa, para cada m²,
        ///deve-se usar 18 W de potência, Faça um programa que receba as duas dimensões de um
        ///cômodo(em metros), calcule e mostre a sua área(em m²) e a potência de iluminação que
        ///deverá ser utilizada
        /// </summary>
        static void Exercicio_21()
        {
            Console.WriteLine("Digite a largura: ");
            double largura, comprimento;
            double.TryParse(Console.ReadLine(), out largura);

            Console.WriteLine("Digite o comprimento: ");
            double.TryParse(Console.ReadLine(), out comprimento);

            Console.WriteLine($"A área do seu comodo é : {largura * comprimento}");
            Console.WriteLine($"Você vai precisar de {(largura * comprimento) * 18}W de potência");
            Console.ReadKey();
        }

        /// <summary>
        /// Faça um programa que receba o número de lados de um polígono convexo, calcule e
        ///mostre o número de diagonais desse polígono.Sabe-se que ND = N* (N-3)/2, em que N
        ///é o número de lados do polígono
        /// </summary>
        static void Exercicio_22()
        {
            Console.WriteLine("Digite O Nº de lados do poligono: ");
            double n_lados;
            double.TryParse(Console.ReadLine(), out n_lados);

            Console.WriteLine($"O poligono informado possui {n_lados * (n_lados - 3) / 2} diagonais");
            Console.ReadKey();
        }

        /// <summary>
        ///  Faça um programa que receba a medida de dois ângulos de um triângulo, calcule e
        ///mostre a medida do terceiro ângulo.Sabe-se que a soma dos ângulos de um triângulo é
        ///180 graus.
        /// </summary>
        static void Exercicio_23()
        {
            Console.WriteLine("Digite o valor do Angulo A: ");
            double angulo_a, angulo_b;
            double.TryParse(Console.ReadLine(), out angulo_a);

            Console.WriteLine("Digite o valor do Angulo B: ");
            double.TryParse(Console.ReadLine(), out angulo_b);

            Console.WriteLine($"O angulo C do triangulo informado é {180 - (angulo_a - angulo_b)}");
            Console.ReadKey();
        }

        /// <summary>
        /// Faça um programa que receba a quantidade de dinheiro em reais que um pessoa que vai
        ///viajar possui.Ela vai passar por vários países e precisa converter seu dinheiro em
        ///dólares, marco alemão e libra esterlina.Sabe-se que a cotação do dólar é de R$ 1,80; do
        /// marco alemão, de R$ 2,00; e da libra esterlina, de R$ 3,70. O programa deve fazer as
        ///conversões e mostrá-las.
        /// </summary>
        static void Exercicio_24()
        {
            Console.WriteLine("Digite o montante em R$");
            decimal montante;
            decimal.TryParse(Console.ReadLine(), out montante);

            Console.WriteLine($"Valor em DOLAR: {montante / 1.8m}");
            Console.WriteLine($"Valor em LIBRA: {montante / 3.7m}");
            Console.WriteLine($"Valor em MARCO ALEMÃO: {montante / 2m}");
            Console.ReadKey();
        }

        /// <summary>
        /// Faça um programa que receba uma hora (uma variável para hora e outra para minuto),
        ///calcule e mostre:
        ///a) a hora digitada convertida em minutos,
        ///b) o total dos minutos, ou seja, os minutos digitados mais a conversão anterior,
        ///c) o total dos minutos convertidos em segundos.
        /// </summary>
        static void Exercicio_25()
        {
            Console.WriteLine("Digite a hora");
            int hora, minutos;
            int.TryParse(Console.ReadLine(), out hora);
            Console.WriteLine("Digite os minutos");
            int.TryParse(Console.ReadLine(), out minutos);
            double totalMinutes = TimeSpan.FromHours(hora).TotalMinutes;

            Console.WriteLine($"Hora digitada em minutos: {totalMinutes}");
            Console.WriteLine($"Total dos minutos: {minutos + totalMinutes}");
            Console.WriteLine($"Total dos minutos em sec: {TimeSpan.FromMinutes(totalMinutes).TotalSeconds}");
            Console.ReadKey();
        }
    }
}
