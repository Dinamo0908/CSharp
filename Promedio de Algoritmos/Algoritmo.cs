using System;
using System.Threading;

namespace Promedio_de_Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
        double notaPar1, notaPar2, notaPar3, notaTrabajo, notaExamen, porcenParcial, porcenTrabajo, porcenExamen, notaFinal;

        //Inicia el programa
        Console.WriteLine("BEEP - BOOP");
        Thread.Sleep(2000);
        Console.WriteLine("Bienvenido al cálculo de materias, donde no prometemos que usted apruebe luego de hacer este test, por tanto, por favor no sea idiota y no revolee el dispositivo que está utilizando una vez que se den los resultados, gracias.");
        Thread.Sleep(1000);
        Console.WriteLine("Bien, dados los datos que ingresaste previamente, necesitas saber cual es tu calificación final de Algoritmos teniendo en cuenta tres trabajos parciales(55%), un trabajo final (15%) y un examen final (30%)");
        Thread.Sleep(1000);
        Console.WriteLine("Bien, entonces, empecemos a calcular. ¡Buena suerte! (lo necesitarás |:D)");
        Thread.Sleep(2000);

        //Se piden los valores de cada prueba, y se asignan a las variables con el prefijo "nota" (excepto notaFinal)
        Console.Write("Por favor, ingresa la nota del primer parcial:");
        notaPar1 = Double.Parse(Console.ReadLine());
        Console.Write("Segunda nota:");
        notaPar2 = Double.Parse(Console.ReadLine());
        Console.Write("Tercera nota:");
        notaPar3 = Double.Parse(Console.ReadLine());

        Console.Write("Por favor, ingrese la calificación del trabajo final:");
        notaTrabajo = Double.Parse(Console.ReadLine());

        Console.Write("Finalmente, ingrese la nota del examen final, por favor:");
        notaExamen = Double.Parse(Console.ReadLine());

        //Se calculan los porcentajes
        Console.Write("Deme un par de segundos, estoy haciendo los cálculos finales...");
        porcenParcial = ((notaPar1 + notaPar2 + notaPar3)/3)* 0.55;
        porcenTrabajo = notaTrabajo * 0.15;
        porcenExamen = notaExamen * 0.30;
        notaFinal = porcenParcial + porcenTrabajo + porcenExamen;

        //Se dan los resultados finales y finaliza el programa
        Thread.Sleep(2000);
        Console.WriteLine("Bien, el porcentaje de tus parciales es de 55%, que en números es un {0}.", porcenParcial);
        Thread.Sleep(1000);
        Console.WriteLine("El porcentaje de tu trabajo final es de 15%, lo que significa que es un {0}.", porcenTrabajo);
        Thread.Sleep(1000);
        Console.WriteLine("El porcentaje de tu examen final es de 30%, por lo tanto, es un {0}.", porcenExamen);
        Thread.Sleep(1000);
        Console.WriteLine("Entonces, tu nota final es un {0}.", notaFinal);
        Thread.Sleep(1000);
        Console.WriteLine("Eso es todo. ¡Adiós!");
        Console.WriteLine("BOOP - BEEP");
        Thread.Sleep(2000);
        }
    }
}
