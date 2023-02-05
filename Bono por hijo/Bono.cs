using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bono_por_hijo
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
            double sueldo, nuevoSueldo;
            int numeroHijos, bono;

        //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al bonificador 3000, donde podras bendecir a tus hijos por haber nacido luego de que termine el programa.");
            Thread.Sleep(1000);
            Console.WriteLine("El programa es simple: ingresas tu sueldo, y el numero de hijos que tengas. Calculo el bono y te devuelvo tu nuevo sueldo.");
            Thread.Sleep(1000);
            Console.WriteLine("Empezando...");
            Thread.Sleep(1000);

        //Se pregunta el sueldo y el número de hijos. Si es mayor de tres, el bono será mayor, sino, menor. Finalmente, se calcula el bono y el nuevo sueldo
            Console.Write("Por favor, ingresa tu sueldo:");
            sueldo = Double.Parse(Console.ReadLine());
            Console.Write("Ahora, ingresa el numero de hijos que tengas (Si no tienes ninguno, ingresa 0):");
            numeroHijos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            if (numeroHijos >=3) {
                bono = numeroHijos * 10;
            } else {
                bono = numeroHijos * 20;
            }
            nuevoSueldo = sueldo + bono;
            Thread.Sleep(2000);

        //Se dan los resultados y finaliza el programa
            Console.WriteLine("El sueldo es de {0}$, y el numero de hijos es {1}.", sueldo, numeroHijos);
            Thread.Sleep(2000);
            Console.WriteLine("Por tanto, el sueldo con la bonificacion por hijo es de {0}$.", nuevoSueldo);
            Thread.Sleep(2000);
            Console.WriteLine("Eso es todo. Hasta luego...");
            Thread.Sleep(1000);
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
