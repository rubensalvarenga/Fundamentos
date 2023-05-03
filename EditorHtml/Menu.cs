using System;
using System.Collections.Generic;
using System.Text;

namespace EditorHtml
{
    public static class Menu
    {



        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen(80, 20);
            WriteOptions();
            Console.SetCursorPosition(45 , 12);
            var options = short.Parse(Console.ReadLine());  
            HandleMenuOptions(options);

        }

        public static void DrawScreen(int horizontal, int vertical)
        {

            LinhaTopBottom(horizontal);
            LinhaVertical(vertical, horizontal);
            LinhaTopBottom(horizontal);

             static void LinhaVertical(int vertical, int horizontal)
            {
                for (int i = 0; i < vertical; i++)
                {
                    Console.Write("|");
                    for (int line = 0; line < horizontal; line++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("|");
                }
            }

             static void LinhaTopBottom(int horizontal)
            {
                Console.Write("+");
                for (int i = 0; i < horizontal; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("+");
            }


        }

        public static void WriteOptions()
        {
            var titulo = "Editor HTML";
            var linha = 2;
            Central(titulo, linha);

            linha = 3;
            titulo = "================";
            Central(titulo, linha);

            linha= 4;
            titulo = "Selecione uma das Opções";
            Central (titulo, linha);

            linha = 6;
            titulo = "1 - Novo Arquivo";
            Central(titulo, linha);

            linha = 8;
            titulo = "2 - Abrir";
            Central(titulo, linha);

            linha = 10;
            titulo = "0 - Sair";
            Central(titulo, linha);

            linha = 12;
            titulo = "OPÇÃO  :";
            Central(titulo, linha);





            static void Central(string titulo, int linha)
            {
                    Console.SetCursorPosition((80 - titulo.Length) / 2, linha);
                    Console.WriteLine(titulo);
                 
            }



        }

        public static void HandleMenuOptions(short option)
        {
            switch (option)
            {
                
                case 1: Editor.Show(); break; 
                case 2: Console.WriteLine(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                     }
                  
                default: Show();break;
                    


            }
        }


    }
}

