using System;
using System.Threading;

namespace Dinero_a_Dólares
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
            double monedaOriginal, uniCambio, enDolares;

        //Empieza el progama
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido a la calculadora de unidad cambiaria, donde el cliente puede tener dos respuestas: o le da un infarto, o le da un infarto pero de alegría.");
            Thread.Sleep(1000);
            Console.WriteLine("Sólo voy a requerir que me digas 2 cosas, cual es el monto de que quieres pasar a dólares y cual es la unidad de cambio, así que, si no la sabes, por favor ve a investigarla y vuelve.");
            Thread.Sleep(1000);
            Console.WriteLine("¿Ya estás? Entonces vamos a empezar.");
            Thread.Sleep(1000);

        //Se pide la cantidad de dinero y la unidad de cambio, para luego pasar a dólares
            Console.Write("Por favor, digame cual es la cantidad que quiere pasar a dólares:");
            monedaOriginal = Double.Parse(Console.ReadLine());
            Console.Write("Bien, ahora, digame cual es la unidad de cambio:");
            uniCambio = Double.Parse(Console.ReadLine());
            Console.WriteLine("Bien, dejame que haga un par de cálculos...");
            enDolares = monedaOriginal / uniCambio;

        //Se dan los resultados y finaliza el programa
            Console.WriteLine("Bien, la cantidad de dinero que quiere pasar a dólares es {0} $", monedaOriginal);
            Thread.Sleep(2000);
            Console.WriteLine("La unidad de cambio es {0} $", uniCambio);
            Thread.Sleep(2000);
            Console.WriteLine("Por tanto, esa cantidad a dólares es de {0} $.", enDolares);
            Thread.Sleep(2000);
            Console.WriteLine("Eso es todo. ¡Adiós!");
            Thread.Sleep(2000);
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
