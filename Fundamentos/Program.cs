using EditorHtml;
using System;
using System.ComponentModel.Design;
using TratamentoString;

namespace Fundamentos
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("-----------=== MENU PRINCIPAL ===-------------");
            Console.WriteLine("");
            Console.WriteLine("   1 - Calculadora");
            Console.WriteLine("   2 - Cronometro");
            Console.WriteLine("   3 - Editor de Texto");
            Console.WriteLine("   4 - Métodos tratamento de Strings");
            Console.WriteLine("   5 - Editor HTML");
            Console.WriteLine("   0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Digite sua Opção");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Calculadora.Calculadora.Menu(); break;
                case 2: Stopwatch.StopWatch.Menu(); break;
                case 3: TextEditor.TextEditor.Menu(); break;
                case 4: TratamentoString.TratamentoString.Menu();break;
                case 5: EditorHtml.Menu.Show(); break;
            }

            Menu();
        }
    }
}
