using System;
using System.Threading;

namespace Números_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declaran las variables
            float num1, num2, link, num3;

            //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(2000);
            Console.WriteLine("¡Bienvenido al segundo show de números! Hoy tenemos dos shows; uno de intercambio de números, y otro de mostrar su cuadrado y su cubo.");
            Console.WriteLine("¡Empecemos!");
            Thread.Sleep(2000);

            //Primer evento, se intercambian números
            Console.WriteLine("Por favor, ingrese su primer número.");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, ingrese un número más.");
            num2 = float.Parse(Console.ReadLine());
            link = num1;
            num1 = num2;
            num2 = link;
            Console.WriteLine("El primer número ahora es {0} , y el segundo es {1} .",num1, num2);
            Thread.Sleep(2000);
            Console.WriteLine("¡Siguiente Show!");

            //Segundo evento, se da el cubo y cuadrado de un número
            Console.WriteLine("Por favor, ingrese un número.");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("El cubo de este número es {0} , mientras que el cuadrado es {1} .", Math.Pow(num3, 3.00), Math.Pow(num3, 2.00));

            //Termina el Programa
            Console.WriteLine("Eso es todo. ¡Adiós!");
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);

        }
    }
}
