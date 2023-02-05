using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numeros_Invertidos
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
        int numero, auxiliar, dec, unidad;

        //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al show del mago-inador, donde podras ver una magia increiblemente estupenda.");
            Thread.Sleep(1000);
            Console.WriteLine("Es simple, ingresas un numero (entero) y te devuelvo ese numero en reversa.");
            Thread.Sleep(1000);
            Console.WriteLine("Estas preparado?");
            Thread.Sleep(1000);


        //Se pide un número entero y se pasa en reversa
            Console.Write("Por favor, ingresa un numero entero:");
            numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            dec = numero / 10;
            unidad = numero % 10;
            auxiliar = (unidad * 10) + dec;
            Thread.Sleep(2000);

        //Se da el resultado y finaliza el programa;
            Console.WriteLine("El numero ingresado es {0}", numero);
            Thread.Sleep(2000);
            Console.WriteLine("Por tanto, el numero en reversa es {0}.", auxiliar);
            Thread.Sleep(2000);
            Console.WriteLine("Eso es todo. Hasta luego...");
            Thread.Sleep(1000);
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
