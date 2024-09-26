using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
            // Soma();
            // Subtracao();
            // Divisao();
            // Multiplicacao();
        }

        static void Menu()
        {
            /*
            Console.Clear();

             Comando para verificar se o console está disponível antes de tentar limpar a tela, evitando assim a exceção.


            if (Console.IsOutputRedirected == false)
            {
              Console.Clear();
            }
            else
            {
              Console.WriteLine("Não é possível limpar o console.");
            }
            */

            Console.WriteLine("O que deseja Fazer?");
            Console.WriteLine(" 1 - Soma");
            Console.WriteLine(" 2 - Subtração");
            Console.WriteLine(" 3 - Divisão");
            Console.WriteLine(" 4 - Multiplicação");
            Console.WriteLine(" 5 - Porcentagem");
            Console.WriteLine(" 6 - Raiz");
            Console.WriteLine(" 7 - Idade");
            Console.WriteLine(" 0 - Sair");
            

            Console.WriteLine("-------------");
            Console.WriteLine("Seleciona uma opção: ");
            
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Porcentagem(); break;
                case 6: Raiz();break;
                case 7: Idade(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;

            }

        }




        static void Soma()
        {
            Console.WriteLine("Operação de soma");
            Console.WriteLine("Primeiro valor: ");
            float Pv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float Pv2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = Pv1 + Pv2;
            // Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado} ");
            // Console.WriteLine($"O resultado da soma é: {Pv1 + Pv2} ");
            // Console.WriteLine("O resultado da soma é: " + (Pv1 + Pv2));
            // Console.ReadKey();





            Console.WriteLine("");

            Menu();



        }


        static void Subtracao()
        {
            Console.WriteLine("Operação de subtração");
            Console.WriteLine("Primeiro Valor");
            float Pv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float Pv2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = Pv1 - Pv2;
            Console.WriteLine($"O resultado da soma é: {resultado} ");
            // Console.ReadKey();



            Menu();
            Console.WriteLine("");


        }

        static void Divisao()
        {
            Console.WriteLine("Operação de divisão");
            Console.WriteLine("Primeiro valor: ");
            float Pv1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo Valor: ");
            float Pv2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = Pv1 / Pv2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            //  Console.ReadKey();



            Menu();
            Console.WriteLine("");
        }


        static void Multiplicacao()
        {
            Console.WriteLine("Operação de multiplicação");
            Console.WriteLine("Primeiro valor:");
            float Pv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float Pv2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = Pv1 * Pv2;
            Console.WriteLine($"O resultado da Multiplicação é {resultado}");
            //  Console.ReadKey


            Menu();
            Console.WriteLine("");



        }

        static void Porcentagem()
        {

        // Entrada do valor total
        Console.Write("Digite o valor total: ");
        float Pv1 = float.Parse(Console.ReadLine());

        // Entrada da porcentagem
        Console.Write("Digite a porcentagem: ");
        float Pv2 = float.Parse(Console.ReadLine());

        // Cálculo da porcentagem
        float resultado = (Pv2 / 100) * Pv1;

        // Cálculo do valor restante
        // float valorRestante = total - valorPorcentagem;

        // Exibindo o resultado
        Console.WriteLine($"Valor correspondente a {Pv2}% de {Pv1} é {resultado}");
        // Console.WriteLine($"Valor restante após subtrair {porcentagem}% de {total} é {valorRestante}");

        Menu();
        Console.WriteLine("");
        }

        static void Raiz()
        {

         // Solicitar ao usuário para inserir um número
        Console.WriteLine("Digite um número para calcular a raiz quadrada: ");
        double Pv1 = double.Parse(Console.ReadLine());
        // Calcular a raiz quadrada usando Math.Sqrt()
        double Pv2 = Math.Sqrt(Pv1);

        // Exibir o resultado
        Console.WriteLine($"A raiz quadrada de {Pv1} é {Pv2}");

        Menu();
        Console.WriteLine("");

        }

        static void Idade()

        {

        Console.WriteLine("Sua idade");
        Console.WriteLine("Informe o ano de nascimento:");
        float Pv1 = float.Parse(Console.ReadLine());

        

        Console.WriteLine("Digita o ano atual:");
        float Pv2 = float.Parse(Console.ReadLine());

        float resultado = Pv2 - Pv1;

        Console.WriteLine($"Sua idade é: {resultado} ");
           

        Menu();
        Console.WriteLine("");

        // Console.WriteLine("Operação de subtração");
        //     Console.WriteLine("Primeiro Valor");
        //     float Pv1 = float.Parse(Console.ReadLine());

        //     Console.WriteLine("Segundo valor: ");
        //     float Pv2 = float.Parse(Console.ReadLine());
        //     Console.WriteLine("");

        //     float resultado = Pv1 - Pv2;
        //     Console.WriteLine($"O resultado da soma é: {resultado} ");
        //     // Console.ReadKey();



        //     Menu();
        //     Console.WriteLine("");



        }

         

    }
}