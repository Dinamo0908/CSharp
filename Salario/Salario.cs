using System;
using System.Threading;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
            double salario, porcentaje, salarioFinal;
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al incrementador de salarios, donde puedes sumarte un 150% de tu salario para hacerte millonario y mandar a su casa a tu jefe.");
            Thread.Sleep(1000);
            Console.WriteLine("Es simple; ingresa tu salario antiguo, el porcentaje de incremento, y así te devolvemos el salario final");
            Thread.Sleep(1000);
            Console.WriteLine("¿Preparado?");

        //Se pide el salario antiguo y el incremento, dando el salario final
            Console.Write("Por favor, ingresa el valor de tu salario antiguo:");
            salario = Double.Parse(Console.ReadLine());
            Console.Write("Ahora, ingrese el porcentaje de incremento por favor:");
            porcentaje = Double.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            salarioFinal = salario + salario * (porcentaje / 100);
            Thread.Sleep(2000);

        //Se da el resultado y finaliza el programa
            Console.WriteLine("El salario antiguo es de {0} $, y el incremento es de un {1} %.", salario, porcentaje);
            Thread.Sleep(2000);
            Console.WriteLine("Por tanto, el nuevo salario es de {0} $.", salarioFinal);
            Thread.Sleep(2000);
            Console.WriteLine("Eso es todo, nos vemos luego...");
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
