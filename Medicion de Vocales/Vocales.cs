using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Medicion
{
    class Program {
        //Se crea una función para la medición de vocales
        public static string Mid(string param, int Index, int longitud)
        {
            string resultado = param.Substring(Index, longitud);
            return resultado;
        }
        static void Main(string[] args)
        {
        //Se declaran las variables
        string frase;
        int K = 0;
        int A = 0;
        int E = 0;
        int I = 0;
        int O = 0;
        int U = 0;
        string LON;

        //Inicia el programa 
        Console.Write("Por favor, escriba una frase: ");
        frase = Console.ReadLine();
        A = 0;
        E = 0;
        I = 0;
        O = 0;
        U = 0;

        //Se crea un bucle for para saber cuántas vocales hay en la frase ingresada
        for (K = 1; K < frase.Length; K++)
        {
            frase = frase.ToUpper();
            LON = Mid(frase, K, 1);
            switch (LON)
            {
                case "A":
                A = A + 1;
                break;
                case "E":
                E = E + 1;
                break;
                case "I":
                I = I + 1;
                break;
                case "O":
                O = O + 1;
                break;
                case "U":
                U = U + 1;
                break;
            }
        }

        //Se  devuelve el resultado y finaliza el programa
        Console.WriteLine("Hay {0} vocales a", A);
        Console.WriteLine("Hay {0} vocales e", E);
        Console.WriteLine("Hay {0} vocales i", I);
        Console.WriteLine("Hay {0} vocales o", O);
        Console.WriteLine("Hay {0} vocales u", U);
        }
    }
}

