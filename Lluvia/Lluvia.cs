using System;
using System.Threading;

namespace Lluvia
{
    class Program
    {
        static void Main(string[] args)
        {
        //Se declaran todas las variables
        int flag = 0, i = 0, maydia = 0, mendia = 0, x = 30;
        int[] dia = new int[31];
        float menor = 0, mayor = 0, promedio = 0, contagua = 0;
        float[] agua = new float[x + 1];
        
        //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Console.WriteLine("Bienvenido al sistema de detector de lluvia, donde no prometemos saber si estás a punto de ser la próxima  Tailandia o no.");
            Console.WriteLine("Por el módico precio de 20000000000 australes, te ofrecemos decirte el promedio de agua caída por lluvia en un mes, incluyendo el mayor día en el que cayó como el menor día.");
            Console.WriteLine("Por favor, ingrese cualquier tecla para empezar.");
            Console.ReadKey();
            Console.WriteLine("Empezando programa...");
            Thread.Sleep(2000);
            Console.WriteLine("BEEP");
            
        //Empieza el bucle
        do
        {
            Console.Write("Ingrese día: ");
            dia[i] = int.Parse(Console.ReadLine());

            Console.Write("Ingrese agua caída: ");
            agua[i] = float.Parse(Console.ReadLine());
            
            //Se asignan las variables
            if (flag == 0) {
            maydia = dia[i];
            mendia = dia[i];
            menor = agua[i];
            mayor = agua[i];
            flag = 1;

            //Se calculan los días con mayor agua caída y con menor agua caída, y se suman los números para luego ser promediados
            } else {
                if (agua[i] > mayor) {
                    maydia = dia[i];
                    mayor = agua[i];
                } else if (agua[i] < menor) {
                    mendia = dia[i];
                    menor = agua[i];
                }
            }
            contagua+= agua[i];

            //Si el array de días llega a 29 días, le pregunta si tiene 31 días el mes para seguir promediando.
            if (i == 28) {
                Console.Write("¿Este mes tiene 31 días? si/no/tiene 29:");
                if (Console.ReadLine() == "si") {
                    x = x + 1;
                } else if (Console.ReadLine() == "tiene 29") {
                    x = x - 1;
                }
            }
            i++;
        
        //Último bucle, se calcula el promedio del agua caída y se detiene cuando el iterador es mayor que el número 29/30/31
        } while (i < x);
        promedio = contagua / 1;

        //Se dan los resultados del día con mayor agua, con menor agua y el promedio
        if (menor == mayor) {
            Console.WriteLine("El agua caída fue el mismo para todos los días, por tanto, no hubo día con mayor agua o menor agua. El número y el promedio fue {0} .", menor);
        } else {
            Console.WriteLine("La mayor cantidad de agua caída fue de {0} en el/los día/s: ", mayor);
            for (i = 0; i < x; i++) {
                if (agua[i] == mayor) {
                    Console.WriteLine("Día {0}", dia[i]);
                }
            }
            Console.WriteLine("La menor cantidad de agua caída fue de {0} en el/los día/s: ", menor);
            for (i = 0; i < x; i++) {
                if (agua[i] == menor) {
                    Console.WriteLine("Día {0}", dia[i]);
                }
            }
            Console.WriteLine("El promedio de agua caída en {0} días es de {1} milímetros.", x, promedio);
            Console.WriteLine("Eso es todo. ¡Adiós!");
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
            } 
        }
    }
}
