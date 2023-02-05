using System;
using System.Threading;

namespace Pulsaciones
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
            int edad;
            double nPulsaciones;
        
        //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al detector de pulsaciones cada 10 segundos de ejercicio, donde podés saber cuándo te va a dar un infarto haciendo 3 flexiones de brazo, vago.");
            Thread.Sleep(1000);
            Console.WriteLine("El cálculo lo hago yo, lo único que necesito es saber cuál es tu edad o la edad de la persona a calcular.");
            Thread.Sleep(1000);
            Console.WriteLine("¿Empezamos?");
            Thread.Sleep(1000);
        
        //Se pide la edad y se hacen los cálculos de sus pulsaciones
            Console.Write("Por favor, ingrese la edad de la persona a calcular sus pulsaciones:");
            edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            nPulsaciones = (220 - edad) / 10;
            Thread.Sleep(2000);

        //Se dan los resultados y finaliza el programa
            Console.WriteLine("Bien, la edad ingresada es de {0} año/s.", edad);
            Thread.Sleep(1000);
            Console.WriteLine("Por tanto, el número de pulsaciones cada diez segundos es de {0} pulsación/es apróximadamente.", nPulsaciones);
            Thread.Sleep(1000);
            Console.WriteLine("Eso es todo. ¡Adiós!");
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
