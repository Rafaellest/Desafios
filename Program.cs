using System;   

namespace AnalizadorDeTexto
{


    

   
        class Program
        {
            public static void LimitadorCaracter(ref string text, int size = 1000)
            {
                if (text.Length < size) return;

                text = text.Substring(0, size);

                var qtdcaracter = text.Length;
            }

            public static bool Vogal(char v)
            {
                v = char.ToUpper(v);
                return (v == 'A' || v == 'E' || v == 'I' || v == 'O' || v == 'U');
            }

            public static bool Consoantes(char c)
            {
                c = char.ToUpper(c);
                return (c == 'B' || c == 'C' || c == 'D' || c == 'F' || c == 'G' ||
                        c == 'H' || c == 'J' || c == 'K' || c == 'L' || c == 'M' ||
                        c == 'N' || c == 'O' || c == 'P' || c == 'Q' || c == 'R' ||
                        c == 'S' || c == 'T' || c == 'U' || c == 'V' || c == 'W' ||
                        c == 'X' || c == 'Y' || c == 'Z');
            }
            public static bool Espaco(char e)
            {
                e = char.ToUpper(e);
                return (e == ' ');
            }
            public static bool Numero(char n)
            {
                n = char.ToUpper(n);
                return (n == '0' || n == '1' || n == '2' || n == '3' || n == '4' || n == '5' || n == '6' || n == '7' || n == '8' || n == '9');
            }
            public static bool Pontuacao(char p)
            {
                p = char.ToUpper(p);
                return (p == '.' || p == ',' || p == ';' || p == ':' || p == '!' || p == '?' || p == '/' || p == '#' || p == '$' || p == ')' || p == '(' || p == '-');
            }

            public static int countvogais(string frase)
            {
                int quantidade = 0;
                for (int i = 0; i < frase.Length; i++)
                {
                    if (Vogal(frase[i]))
                    {
                        ++quantidade;
                    }
                }
                return quantidade;
            }
            public static int countconsoantes(string frase)
            {
                int quantidade = 0;
                for (int i = 0; i < frase.Length; i++)
                {
                    if (Consoantes(frase[i]))
                    {
                        ++quantidade;
                    }
                }
                return quantidade;
            }
            public static int countespaco(string frase)
            {
                int quantidade = 0;
                for (int i = 0; i < frase.Length; i++)
                {
                    if (Espaco(frase[i]))
                    {
                        ++quantidade;
                    }
                }
                return quantidade;
            }
            public static int countnumero(string frase)
            {
                int quantidade = 0;
                for (int i = 0; i < frase.Length; i++)
                {
                    if (Numero(frase[i]))
                    {
                        ++quantidade;
                    }
                }
                return quantidade;
            }

            public static int countpontuacao(string frase)
            {
                int quantidade = 0;
                for (int i = 0; i < frase.Length; i++)
                {
                    if (Pontuacao(frase[i]))
                    {
                        ++quantidade;
                    }
                }
                return quantidade;
            }
            public static void Main(string[] args)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Digite seu texto: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                var frase = Console.ReadLine();

                Console.WriteLine("\n");

                if (frase == null || frase.Length == 0) throw new Exception("Frase não informada");

                LimitadorCaracter(ref frase);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Qtd de Vogais:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(countvogais(frase));

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Qtd de Consoantes:");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(countconsoantes(frase));

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Qtd de espaços:");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(countespaco(frase));

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Qtd de numeros:");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(countnumero(frase));

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Qtd de caracteres de pontuação:");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(countpontuacao(frase));

                Console.WriteLine("\n\n");

                Console.ReadLine();
            }
        }
    }




}


