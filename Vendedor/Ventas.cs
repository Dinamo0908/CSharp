using System;
using System.Threading;

namespace Vendedor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declaran las variables
            double venta1, venta2, venta3, comision1, comision2, comision3, sueldoBase, comisionTotal, sueldoTotal;

            //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al sistema de ingeniería matemática de última generación KALK 2.0. (No prometemos que puedas dividir por 0, capa 8).");
            Thread.Sleep(1000);
            Console.WriteLine("KALK 2.0 No es solamente una calculadora cualquiera, sino que también es una inteligencia artificial consciente que puede dar servicios para negocios, economía, análisis de datos, y mucho más.");
            Thread.Sleep(1000);
            Console.WriteLine("Por su cara de preocupación, KALK 2.0 puede deducir que quiere hablar sobre ventas y comisiones, ¿No es así?");
            Thread.Sleep(1000);
            Console.WriteLine("Muy bien, entonces dile todas las ventas que hiciste y él te dirá cual es tu sueldo base y tu total. (KALK 2.0 supone que tu comisión es del 10%, ¿Verdad?)");
            Console.WriteLine("BOOP");

            //Se pide ingresar el valor del sueldo base
            Console.Write("Por favor, ingresa el valor del sueldo base:");
            sueldoBase = Double.Parse(Console.ReadLine());

            Console.Write("Por favor, ingrese el valor de la venta:");
            venta1 = Double.Parse(Console.ReadLine());
            comision1 = venta1 * 0.10;

            Console.Write("Por favor, ingrese el valor de la segunda venta:");
            venta2 = Double.Parse(Console.ReadLine());
            comision2 = venta2 * 0.10;

            Console.Write("Ingrese el valor de la última venta, muchas gracias:");
            venta3 = Double.Parse(Console.ReadLine());
            comision3 = venta3 * 0.10;

            //Se juntan todas las comisiones y se da el sueldo total
            comisionTotal = comision1 + comision2 + comision3;
            sueldoTotal = sueldoBase + comisionTotal;

            //Se dan los resultados y se termina el programa
            Console.WriteLine("KALK 2.0 te dará los resultados finales.");
            Console.WriteLine("Tu sueldo base es de {0} $.", sueldoBase);
            Console.WriteLine("El resultado de todas tus comisiones es de {0} $.", comisionTotal);
            Console.WriteLine("Por ende, tu sueldo total es de {0} $.", sueldoTotal);
            Thread.Sleep(1000);
            Console.WriteLine("Eso es todo entonces. ¡Adiós!");
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
