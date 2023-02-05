using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
            double lunes, martes, miercoles, total, promedio;

        //Inicia el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al prome-inador 3000, en el cual puedes hacer promedios de tus ejercicios para ver que tan vago sos.");
            Thread.Sleep(1000);
            Console.WriteLine("Es simple, suponiendo que entrenas 3 dias ingresas cuanto tiempo duro cada sesion, luego lo sumamos y te damos el total y el promedio.");
            Thread.Sleep(1000);
            Console.WriteLine("¿Preparado?");
            Thread.Sleep(1000);

        //Se pregunta cuanto tiempo entrenó el lunes, el martes y el miércoles, se hace el promedio y el total
            Console.Write("Por favor, ingresa cuanto tiempo entrenaste el primer dia:");
            lunes = Double.Parse(Console.ReadLine());
            Console.Write("Por favor, ingresa cuanto tiempo entrenaste el segundo dia:");
            martes = Double.Parse(Console.ReadLine());
            Console.Write("Finalmente, ingresa cuanto tiempo entrenaste el tercer dia:");
            miercoles = Double.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            total = lunes + martes + miercoles;
            promedio = total / 3;
            Thread.Sleep(2000);
            
        //Se dan los resultados y finaliza el programa
            Console.WriteLine("El total de minutos trabajados es de {0} minutos.", total);
            Thread.Sleep(2000);
            Console.WriteLine("Entonces, el promedio de cada sesion es de {0} minutos.", Math.Round(promedio));
            Thread.Sleep(2000);
            Console.WriteLine("Eso es todo, hasta luego...");
            Thread.Sleep(1000);
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
