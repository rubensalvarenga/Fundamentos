using System;
using System.IO;

namespace TextEditor
{
    public static class TextEditor
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("**** Editor de Texto ****");
            Console.WriteLine("");
            Console.WriteLine("O que você deseja fazer ?");
            Console.WriteLine("1 - Abrir arquivo texto ");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir();break; 
                case 2: Editar();break;
            }
        }
       
        static void Editar() 
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo");
            Console.WriteLine("-------------------------");

            string text = "";
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine; //quebra de linha
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
           
                
            
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho ?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void Salvar(string text)
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
            Menu();
        }
    }
}
