using System;
using System.Threading;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
            int varones, mujeres, total, porcentajeVarones, porcentajeMujeres;

        //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al contador de personas, donde podras saber si hay mas machos pechos peludos o mujeres con ovarios de acero.");
            Thread.Sleep(1000);
            Console.WriteLine("El programa es simple, ingresas el total de personas en un lugar, luego los hombres y las mujeres, y te devuelvo el porcentaje de cada uno.");
            Thread.Sleep(1000);
            Console.WriteLine("¿Empezamos?");
            Thread.Sleep(1000);

        //Se pide el total de personas, la cantidad de varones y de mujeres y se da el porcentaje
            Console.Write("Por favor, ingresa la cantidad de personas en total:");
            total = Int32.Parse(Console.ReadLine());
            Console.Write("Ahora, ingresa la cantidad de mujeres en total:");
            mujeres = Int32.Parse(Console.ReadLine());
            Console.Write("Finalmente, ingresa la cantidad de hombres en total:");
            varones = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            porcentajeVarones = varones * 100 / total;
            porcentajeMujeres = mujeres * 100 / total;

        //Se dan los resultados y finaliza el programa
            Console.WriteLine("En total son {0} personas, {1} son mujeres y {2} son hombres.", total, varones, mujeres);
            Thread.Sleep(1000);
            Console.WriteLine("Por tanto, un {0} % son mujeres, mientras que un {1} % son hombres.", porcentajeMujeres, porcentajeVarones);
            Thread.Sleep(2000);
            Console.WriteLine("Eso es todo, hasta luego...");
            Thread.Sleep(1000);
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
