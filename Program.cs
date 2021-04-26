using System;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
          string palabra, inverso, caracter;
          int i;
         Console.WriteLine("palabra que desea invertir");
         palabra = Console.ReadLine();
         i= palabra.Length;
         inverso = "";
         for (int x=i-1; x >= 0; x--)
         
            {caracter= palabra.Substring(x,1);
         inverso = inverso + caracter;
         }
         Console.WriteLine("inverso de la palabra");
         Console.WriteLine(inverso);
        if (palabra == inverso)
        { 
           Console.WriteLine("es palindromic", Console.ForegroundColor=ConsoleColor.Green);     
        }
        else{
            Console. WriteLine("no es palindromic",Console.ForegroundColor= ConsoleColor.Red);
        }
        }
    }    
}
