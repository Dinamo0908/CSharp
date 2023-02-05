using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarifa_Telefonica
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
            double cantidadKilovaltios, costoKilovaltios, total;
            costoKilovaltios = 0;

        //Inicia el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al tafinador 8000 4.0, donde podras saber cuanto tienes que pagar luego de una llamada de 16 horas con tus compas.");
            Thread.Sleep(1000);
            Console.WriteLine("El programa es simple: dices cuanta cantidad de kilovaltios gastaste, y en base a eso, el precio aumentara o se reducira. Luego, se multiplican y te devuelvo el resultado.");
            Thread.Sleep(1000);
            Console.WriteLine("Iniciando...");
            Thread.Sleep(1000);

        //Se pide saber la cantidad de kilovaltios. En base a eso, el costo sube o baja, luego se multiplican los dos números y se obtiene el total del coste
            Console.Write("Por favor, ingresa la cantidad de kilovaltios usados:");
            cantidadKilovaltios = Double.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            if (cantidadKilovaltios <= 1000) {
                costoKilovaltios = 0.14;
            }
            if ((cantidadKilovaltios > 1000) & (cantidadKilovaltios <= 1800)) {
                costoKilovaltios = 0.12;
            }
            if  (cantidadKilovaltios > 1800) {
                costoKilovaltios = 0.8;
            }
            total = cantidadKilovaltios * costoKilovaltios;
            Thread.Sleep(2000);

        //Se dan los resultados y finaliza el programa
            Console.WriteLine("La cantidad de kilovaltios usados es de {0} kv.", cantidadKilovaltios);
            Thread.Sleep(2000);
            Console.WriteLine("Por tanto, la tarifa es de {0}$.", Math.Round(total));
            Thread.Sleep(2000);
            Console.WriteLine("Eso es todo. Hasta luego...");
            Thread.Sleep(1000);
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
