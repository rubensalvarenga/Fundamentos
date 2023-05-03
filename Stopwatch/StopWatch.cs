using System;
using System.Threading;

namespace Stopwatch
{
    public static class StopWatch
    {
        static void Main(string[] args)
        {
            Menu();  
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("**** StopWatch - Contador de tempo ****");
            Console.WriteLine("");
            Console.WriteLine("S = Segundos");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("R = Regressiva");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar ?");
            string op = Console.ReadLine();
            if (op == "S" || op == "s")
            {
                Console.WriteLine("Quantos segundos ?");
                int segundos = int.Parse(Console.ReadLine());
                Start(segundos);
            }
            else
            
            if (op == "M" || op == "m")
             {
                 Console.WriteLine("Quantos minutos ?");
                 int segundos = int.Parse(Console.ReadLine());
                 Start(segundos*60);
             }

            if (op == "R" || op == "r")
            {
                Console.WriteLine("Quantos segundos ?");
                int segundos = int.Parse(Console.ReadLine());
                StartRegressiva(segundos);
            }



        }
        static void Start(int time)
        {
            
            int currentTime = 0;
            while ( currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

        }

        static void StartRegressiva(int time)
        {

            int currentTime = time;

            while (currentTime != 0)
            {
                Console.Clear();
                currentTime--;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

        }
    }
}
