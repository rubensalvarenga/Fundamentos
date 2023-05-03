using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EditorHtml
{
 public static class Editor
    {
        public static void Show() {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("------------");
            Start();


        }

        public static void Start() {
             var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------------");
            Console.WriteLine("Deseja salvar o arquivo (S)im ou (N)ão ?");
            var escolha = Console.ReadLine();
            if (escolha == "S" || escolha == "s") {
                string arquivo = file.ToString();
                Salvar(arquivo);
            }else if (escolha =="N" || escolha == "n") {
                Console.WriteLine("Arquivo descartado, pressione qq tecla para continuar ...");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Arquivo descartado, digitou qq tecla ...");
                Console.ReadLine();
            }

        }

        public static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para Salvar ?");
            var path = Console.ReadLine();


            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo !");
            Console.ReadLine();
            Show();
        }
    }
}
