using System;
using System.Threading;

namespace Edad
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
        int fechaNacimiento, fechaActual, edad;

        //Inicia el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al detector de edades, donde existe una pequeña probabilidad de errar por un año pero no nos hacemos responsables de que el sujeto haya nacido después de la mitad del año.");
            Thread.Sleep(1000);
            Console.WriteLine("Lo único que necesitamos saber es el año de nacimiento del sujeto y el año actual, para poder saber cuánto tiempo pasó y así deducir su edad.");
            Thread.Sleep(1000);
            Console.WriteLine("¿Estás listo?");
            Thread.Sleep(1000);
        
        //Se pide el año de nacimiento de la persona y el año actual, haciendo un cálculo para saber la edad del sujeto
            Console.Write("¿En qué año nació esta persona?:");
            fechaNacimiento = Int32.Parse(Console.ReadLine());
            Console.Write("¿Cuál es el año actual?:");
            fechaActual = Int32.Parse(Console.ReadLine());
            edad = fechaActual - fechaNacimiento;

        //Se da el resultado y finaliza el programa
            Console.WriteLine("La fecha de nacimiento dada es en el año {0}.", fechaNacimiento);
            Thread.Sleep(2000);
            Console.WriteLine("La fecha actual dada es en el año {0}.", fechaActual);
            Thread.Sleep(2000);
            Console.WriteLine("Por tanto, la probable edad del sujeto es de {0} o {1} año/s.", edad, edad - 1);
            Thread.Sleep(1000);
            Console.WriteLine("Eso es todo. ¡Adiós!");
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
