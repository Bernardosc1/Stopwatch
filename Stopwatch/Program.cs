using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static short res;

        static void Main(string[] args)
        {
            // invocando o menu
            Menu();
        }

        static void Menu()
        {
            // Mensagem de apresentação
            Console.WriteLine("Ola, eu sou o Stopwatch!");

            // Menu de escolha da unidade de tempo
            Console.WriteLine("Qual a unidade de tempo que voce deseja utilizar?");
            Console.WriteLine("1 - Segundos");
            Console.WriteLine("2 - Minutos");
            Console.WriteLine("3 - Horas");
            Console.WriteLine("4 - Sair");
            res = short.Parse(Console.ReadLine());

            if (res == 1)
            {
                Console.WriteLine("Quantos segundos voce deseja contar?");
            }
            else if (res == 2)
            {
                Console.WriteLine("Quantos minutos voce deseja contar?");
            }
            else if (res == 3)
            {
                Console.WriteLine("Quantas horas voce deseja contar?");
            }
            else if (res == 4)
            {
                Console.WriteLine("Finalizando o programa...");
                Environment.Exit(0);
            }

            int time = Convert.ToInt32(Console.ReadLine());
            // Processo de contagem de tempo com base em cada caso

            // Invocacao metodo de contagem
            PreStart(time);
        }


        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready....");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set....");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go....");
            Thread.Sleep(2500);
            Console.Clear();

            Start(time);
        }


        // Metodo de contagem
        static void Start(int time)
        {
            int Hours = 0;
            int seconds = 0;
            int minutes = 0;

            while (true)
            {
                seconds++;
                if (seconds >= 60)
                {
                    minutes++;
                    seconds = 0;
                }
                if (minutes >= 60)
                {
                    Hours++;
                    minutes = 0;
                }

                // Exibe a contagem atual
                if (Hours > 0)
                {
                    Console.WriteLine(Hours + " horas, " + minutes + " minutos e " + seconds + " segundos");
                }
                else if (minutes > 0)
                {
                    Console.WriteLine(minutes + " minutos e " + seconds + " segundos");
                }
                else
                {
                    Console.WriteLine(seconds + " segundos");
                }

                Thread.Sleep(1000); // Atraso de 1 segundo

                // Verifica se a contagem atingiu o tempo desejado
                if ((res == 1 && seconds == time) || (res == 2 && minutes == time) || (res == 3 && Hours == time))
                {
                    Console.WriteLine("Contagem finalizada!");
                    break;
                }
            }

            Menu(); // Retorna ao menu após a contagem terminar
        }
    }
}