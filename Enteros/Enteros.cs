using System;
using System.Threading;

namespace Enteros
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
            double num;

        //Inicia el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al redondeador 3000, donde podes redondear los numeros que desees.");
            Thread.Sleep(1000);
            Console.WriteLine("El programa es simple, ingresas un numero cualquiera en decimal y automaticamente se redondeara.");
            Thread.Sleep(1000);
            Console.WriteLine("¿Preparado?");

        //Se pide el número decimal
            Console.Write("Por favor, ingresa el numero que desees redondear:");
            num = Double.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            Thread.Sleep(1000);
        
        //Se dan los resultados y finaliza el programa
            Console.WriteLine("El numero ingresado es {0}.", num);
            Thread.Sleep(2000);
            Console.WriteLine("Por tanto, el numero redondeado es {0}.", Math.Round(num));
            Thread.Sleep(2000);
            Console.WriteLine("Eso es todo. Hasta luego...");
            Thread.Sleep(1000);
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
