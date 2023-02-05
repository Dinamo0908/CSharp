using System;
using System.Threading;

namespace Emprendimiento
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
        double cant1, cant2, cant3, cantTotal, porcent;

        //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al Emprendedor 3.8, donde averiguamos quién es el más rati de todos los inversores.");
            Thread.Sleep(1000);
            Console.WriteLine("El programa es simple: usted ingresa la cantidad dada por 3 inversores, hacemos un pequeño cálculo de la cantidad total y tenemos un porcentaje de los tres.");
            Thread.Sleep(1000);
            Console.WriteLine("¡Empecemos!");
            Thread.Sleep(1000);
        
        //Se piden las cantidades de cada persona, y se suman todos estos números dados
            Console.Write("Por favor, ingresa la cantidad de la primera persona:");
            cant1 = Double.Parse(Console.ReadLine());
            Console.Write("Ahora, ingresa la cantidad de la segunda persona:");
            cant2 = Double.Parse(Console.ReadLine());
            Console.Write("Finalmente, ingresa el monto de la tercera persona:");
            cant3 = Double.Parse(Console.ReadLine());
            cantTotal = cant1 + cant2 + cant3;
        
        //Se dan los porcentajes de cada persona con una sola variable (porcentaje), y finaliza el programa 
            porcent = cant1 * 100 / cantTotal;
            Console.WriteLine("La cantidad dada por la primera persona es de {0} $. Entonces, su porcentaje de inversión es de {1} %.", cant1, Math.Round(porcent, 2));
            Thread.Sleep(2000);
            porcent = cant2 * 100 / cantTotal;
            Console.WriteLine("La cantidad dada por la segunda persona es de {0} $. Por ende, el porcentaje de su inversión es de {1} %.", cant2, Math.Round(porcent, 2));
            Thread.Sleep(2000);
            porcent = cant3 * 100 / cantTotal;
            Console.WriteLine("Por último, el monto de la tercera persona es de {0} $, es por eso que su porcentaje es de {1} %.", cant3, Math.Round(porcent,2));
            Thread.Sleep(2000);
            Console.WriteLine("Eso es todo. ¡Adiós!");
            Thread.Sleep(1000);
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
