using System;
using System.Security.Cryptography.X509Certificates;

namespace AnalizadorDeTexto
{

    class Program
    {
        static int consulta(string frase, char caracter)
        {
            int contador = 0;
            for (int i = 0; frase.Length < 1000; i++)
                if (frase[i] == caracter)
                    contador++;
            return contador;
        }
        static void Main(string[] args)
        {
            string frase;
            char caracter;
            Console.Write("Introduza uma frase: ");
            frase = Console.ReadLine();
            Console.Write("Introduza o caracter a pesquisar: ");
            caracter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("O carácter '{0}' aparece {1} vez(es)", caracter, consulta(frase, caracter));
        }
    }







}


