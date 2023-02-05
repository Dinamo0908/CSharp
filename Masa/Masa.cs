using System;
using System.Threading;

namespace Masa
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
            double presion, volumen, temperatura, masa;

        //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al cálculo de masa de un objeto, donde no nos hacemos cargo si nos confundimos por más del 99,9% + 1%.");
            Thread.Sleep(1000);
            Console.WriteLine("El programa es simple, me pasás la presión, el volumen y temperatura de un objeto, hago un pequeño cálculo y te devuelvo la masa.");
            Thread.Sleep(1000);
            Console.WriteLine("¿Estás preparado?");
            Thread.Sleep(1000);

        //Se pide la presión, el volumen y temperatura de un objeto para luego calcular la masa
            Console.Write("Por favor, ingresa la presión del objeto:");
            presion = Double.Parse(Console.ReadLine());
            Console.Write("Por favor, ingresa el volumen del objeto:");
            volumen = Double.Parse(Console.ReadLine());
            Console.Write("Por último, ingresa la temperatura del objeto:");
            temperatura = Double.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            masa = Math.Round((presion * volumen)/(0.37 * (temperatura + 460)));

        //Se dan los resultados y finaliza el programa
            Console.WriteLine("La presión ingresada es {0}.", presion);
            Thread.Sleep(2000);
            Console.WriteLine("El volumen ingresado es {0}.", volumen);
            Thread.Sleep(2000);
            Console.WriteLine("La temperatura ingresada es de {0} grados.", temperatura);
            Thread.Sleep(2000);
            Console.WriteLine("Por ende, la masa es {0}, redondeado.", masa);
            Thread.Sleep(2000);
            Console.WriteLine("Eso es todo. ¡Adiós!");
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
