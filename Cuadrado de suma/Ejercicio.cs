using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cuadrado_de_suma
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
            double numero1, numero2, resultado;

        //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al potenciador 3000, donde puedes finalmente saber cuanto es 1+1 sobre 2.");
            Thread.Sleep(1000);
            Console.WriteLine("El programa es simple: ingresas dos numeros los cuales se sumaran y luego se pasara su resultado al cuadrado.");
            Thread.Sleep(1000);
            Console.WriteLine("Finalmente, te damos el resultado y finalizamos el programa.");
            Thread.Sleep(1000);
            Console.WriteLine("Iniciando...");
            Thread.Sleep(1000);
        
        //Se piden dos números, se suman y luego se multiplica la misma suma
            Console.Write("Por favor, ingresa el primer numero:");
            numero1 = Double.Parse(Console.ReadLine());
            Console.Write("Ahora, ingresa el segundo numero:");
            numero2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            resultado = (numero1 + numero2) * (numero1 + numero2);
            Thread.Sleep(2000);

        //Se da el resultado y finaliza el programa
            Console.WriteLine("El primer numero ingresado es {0}, y el segundo {1}.", numero1, numero2);
            Thread.Sleep(2000);
            Console.WriteLine("Por tanto, el cuadrado de su suma es {0}.", resultado);
            Thread.Sleep(2000);
            Console.WriteLine("Eso es todo, hasta luego...");
            Thread.Sleep(1000);
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
