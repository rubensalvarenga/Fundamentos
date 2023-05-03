using System;
using System.Text;

namespace TratamentoString
{
    public static class TratamentoString
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("**** Tratamento de Strings ****");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Guids");
            Console.WriteLine("2 - Interpolação");
            Console.WriteLine("3 - Comparação de strings");
            Console.WriteLine("4 - Uso StarsWith/EndWith");
            Console.WriteLine("5 - Equals comparação");
            Console.WriteLine("6 - Índices");
            Console.WriteLine("7 - Métodos Adicionais");
            Console.WriteLine("8 - Manipulando Strings");
            Console.WriteLine("9 - StringBuilder");
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("Escolha sua Opção :");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: ; break;
                case 1: GuidId(); break;
                case 2: Inter(); break;
                case 3: Compara(); break;
                case 4: ComecoFim(); break;
                case 5: Igual(); break;
                case 6: Indice(); break;
                case 7: Adicionais() ; break;
                case 8: Manipulando(); break;
                case 9: CriandoSb();break;

                
            }
        }

        static void CriandoSb()
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Usando StringBuilder - quando manipulamos grandes string");
            Console.WriteLine();
            var texto = new StringBuilder();
            texto.Append("Esse é só começo ...");
            texto.Append("Muitos ainda viram ...");
            texto.Append("Vão procurar o que realmente importa ...");
            texto.Append("Nova era vai chegar !!!!");

            texto.ToString(); // Converter em String

            Console.WriteLine(texto);

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

        }
        static void Manipulando()
        {
            var texto = " Este texto é um teste ";
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Usando Replace - Split - Substring - Trim");
            Console.WriteLine();
            Console.WriteLine(texto.Replace("e", "Z")); //Substitui um por outro

            var divisao = texto.Split(" "); // divide a string em pedaços, usando " " para separar

            for(int i = 1; i < divisao.Length; i++)
            {
                Console.WriteLine(divisao[i]);
            }

            Console.WriteLine(texto.Substring(5,5)); // Pega um pedaço
            Console.WriteLine("Texto ANTES do Trim : "+texto);
            Console.WriteLine();
            Console.WriteLine("Texto DEPOIS Trim : "+texto.Trim());// Retira os espaços em branco no começo e fim da string
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
        static void Indice()
        {
            var texto = "Esse texto é um teste";
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Usando IndexOf");
            Console.WriteLine();
            Console.WriteLine("Pesquisa qual a posição na string");
            
            Console.WriteLine("Essa é a string a ser pesquisada " +texto);
            Console.WriteLine("Está na posição, o é >> " + texto.IndexOf("é"));
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

        }
        static void Igual()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Usando Equals");
            Console.WriteLine();
            Console.WriteLine("Exatamente Igual");

            var texto = "Esse texto é um teste";
            Console.WriteLine(texto);
            Console.WriteLine(texto.Equals("Esse texto é um teste")); // true ou false
            Console.WriteLine(texto.Equals("esse texto é um teste")); // true ou false
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();



        }
        static void ComecoFim()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Usando StarsWith e EndsWith");
            Console.WriteLine();
            Console.WriteLine("Começa com ... ou Termina com ...");

            var texto = "Esse texto é um teste";
            Console.WriteLine(texto); 
            Console.WriteLine(texto.StartsWith("Esse")); // true ou false
            Console.WriteLine(texto.StartsWith("esse")); // true ou false
            Console.WriteLine();
            Console.WriteLine(texto.EndsWith("teste")); // true ou false
            Console.WriteLine(texto.EndsWith("Teste")); // true ou false
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
        static void Compara()
        {
            var texto = "Testando";
            Console.WriteLine("Uso do CompareTo e Contains");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Usando CompareTo, obtemos 0 e 1");
            Console.WriteLine(texto.CompareTo("Testando")); //Retorna 0
            Console.WriteLine(texto.CompareTo("testando")); // Retorna 1
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Usando Contains, obtemos true ou false");
            Console.WriteLine(texto.Contains("teste")); // Retorna false
            Console.WriteLine(texto.Contains("Testando")); // Retorna true
            Console.WriteLine(texto.Contains("testando",
                StringComparison.OrdinalIgnoreCase)); // Ignora o quase sensitivo
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();



        }
        static void GuidId()
        {
            Console.WriteLine("Fornece identificador unico GUID");
            var id = Guid.NewGuid(); //Gera um identificador aleatório
            Console.WriteLine("");
            Console.WriteLine(id);
            Console.WriteLine("");
            Console.WriteLine("Exemplo : var id = Guid.NewGuid();");
            Console.WriteLine("");
            Console.ReadLine();
        }
        static void Inter()
        {
            //Interpolação 3 variações
            var texto1 = "O preço do produto ";
            var texto2 = "Apenas na promoção !!";
            var valor = 12.02;

            Console.WriteLine(texto1 + valor + texto2);
            Console.WriteLine();

            var junta = string.Format(texto1 + " acrescentando mais {0}, sem perder {1}", "dados", "foco");
            Console.WriteLine(junta);
            Console.WriteLine();
            Console.WriteLine($"Esse já usamos {valor} {texto1} {texto2}");
            Console.WriteLine();
            Console.WriteLine("Apresentamos 3 modelos de interpolação ");

            Console.WriteLine("");
            Console.WriteLine("var texto1 = O preço do produto ");
            Console.WriteLine("");
            Console.WriteLine("var texto2 = Ofertas da promoção !!");
            Console.WriteLine("valor = 10.3");
            Console.WriteLine("");
            Console.WriteLine("(texto1 + valor + texto2");
            Console.WriteLine("string.Format(texto1 + \" acrescentando mais {0}, sem perder {1}\", \"dados\", \"foco\")");
            Console.WriteLine("($\"Esse já usamos {valor} {texto1} {texto2}\")");
            Console.ReadLine() ;
            

        }
        static void Adicionais()
        {
            var texto = "Este texto é um teste para testar";
            Console.WriteLine($"Exemplo de texto : ");
            Console.WriteLine(texto);
            Console.WriteLine();
            Console.WriteLine($"Baseado no texto usamos \u001b[1m.ToLower()\u001b[0m para deixar minusculo ");
            Console.WriteLine($"\x1b[1m{texto.ToLower()}\x1b[0m ");
            Console.WriteLine();
            Console.WriteLine($"Para maísculo \u001b[1m.ToUpper()\u001b[0m para deixar maisculo ");
            Console.WriteLine($"\u001b[1m{texto.ToUpper()}");
            Console.WriteLine();
            Console.WriteLine($"Inserção de caracteres, usamos \u001b[1m.Insert\u001b[0m ");
            Console.WriteLine($"\u001b[1m{texto.Insert(5,"ADIÇÃO ")}");
            Console.WriteLine();
            Console.WriteLine($"Remover um determinado pedaço \u001b[1m.Remove\u001b[0m ");
            Console.WriteLine($"\u001b[1m{texto.Remove(5,7)}");
            Console.WriteLine();
            Console.WriteLine($"Muito usado que veremos é o \u001b[1m.Length\u001b[0m, conta os caracteres, nesse caso são \u001b[1m{texto.Length}\u001b[0m.");
            Console.WriteLine();
            Console.ReadLine();
            Menu();

        }
    }
}
