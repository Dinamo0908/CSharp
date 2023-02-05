using System;
using System.Threading;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
            double inversion, porcentaje, meses, ganancias;

        //Empieza el programa
            Thread.Sleep(1000);
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al detector de inversiones, donde puedes comprobar si vas a ser rico en un mes o si vas a estar patitas para la calle.");
            Thread.Sleep(1000);
            Console.WriteLine("Con mi ayuda, puedes saber cuánto dinero ganarás si inviertes en un banco en indeterminados meses. Sólo necesito saber tres cosas:");
            Thread.Sleep(1000);
            Console.WriteLine("El monto de la inversión, el porcentaje ganado por mes y la cantidad de meses que se desea evaluar.");
            Thread.Sleep(1000);
            Console.WriteLine("¿Empezamos?");
            Thread.Sleep(1000);
        
        //Se pide el monto de la inversión, el porcentaje conseguido por mes y la cantidad de meses a saber, para luego pasarlo a las ganancias
            Console.Write("Por favor, dígame cual es el monto de la inversión:");
            inversion = Double.Parse(Console.ReadLine());
            Console.Write("Ahora, dígame cual es el porcentaje en intereses por cada mes:");
            porcentaje = Double.Parse(Console.ReadLine());
            Console.Write("Finalmente, dígame cuántos meses en total quisiera saber:");
            meses = Double.Parse(Console.ReadLine());
            ganancias = ((inversion * porcentaje) / 100) * meses;

        //Se dan los resultados y finaliza el programa
            Console.WriteLine("Las ganancias conseguidas en todos {0} mes/es es de {1} $.", meses, ganancias);
            Thread.Sleep(2000);
            Console.WriteLine("Por tanto, teniendo en cuenta que la inversión es de {0} $, en total usted ganará {1} $.", inversion, inversion + ganancias);
            Thread.Sleep(2000);
            Console.WriteLine("Eso es todo. ¡Adiós!");
            Thread.Sleep(1000);
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);

        }
    }
}
