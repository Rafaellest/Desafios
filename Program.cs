
using System;
class Program
{
    public static void LimitadorCaracter(ref string str, int size = 200)
    {
        if (str.Length < size) return;

        str = str.Substring(0, size);

        var qtdcaracter = str.Length;
    }
    static void Upper(char[] str)
    {
        int N = str.Length;

        for (int i = 0; i < N; i++)
        {
            if (str[i] == 'a' || str[i] == 'e' ||
                str[i] == 'i' || str[i] == 'o' ||
                str[i] == 'u')
            {
                char c = char.ToUpperInvariant(str[i]);
                str[i] = c;
            }

        }
        foreach (char c in str)
            Console.Write(c);
    }
    static void Lower(char[] str)
    {
        int N = str.Length;

        for (int i = 0; i < N; i++)
        {
            if (str[i] == 'B' || str[i] == 'C' || str[i] == 'D' || str[i] == 'F' || str[i] == 'G' ||
                        str[i] == 'H' || str[i] == 'J' || str[i] == 'K' || str[i] == 'L' || str[i] == 'M' ||
                        str[i] == 'N' || str[i] == 'O' || str[i] == 'P' || str[i] == 'Q' || str[i] == 'R' ||
                        str[i] == 'S' || str[i] == 'T' || str[i] == 'U' || str[i] == 'V' || str[i] == 'W' ||
                        str[i] == 'X' || str[i] == 'Y' || str[i] == 'Z') ;
            {
                char c = char.ToLowerInvariant(str[i]);
                str[i] = c;
            }

        }
        foreach (char c in str)
            Console.Write(c);
    }



    public static void Main(String[] args)
    {
        String str = "Eutopia";
        Upper(str.ToCharArray());
        Lower(str.ToCharArray());

    }
}





