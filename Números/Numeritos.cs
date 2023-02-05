using System;
using System.Threading;

namespace Números
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declaran las variables
            int i, par = 0 , impar = 0;

            //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(2000);
            Console.WriteLine("Bienvenido al programa de numeritos, donde para nada abusamos y explotamos de nuestros empleados para que puedan repetir el show las veces que sea necesario.");
            Thread.Sleep(2000);
            Console.WriteLine("Bien, tenemos 6 shows, en uno, verás números pares del 1 al 100, en el siguiente, números impares, en el tercero, todos los números del 0 al 100, en el cuarto, números del 100 al 0, en el penúltimo, múltiplos del 3 entre el 0 y 100, y, para finalizar, mútliplos de 3 y 2 entre el 0 y el 100. ¡Que lo disfrutes!");
            Console.WriteLine("BEEP... Iniciando programa... BOOP");
            Thread.Sleep(2000);


            //Primer bucle, en la consola se escriben sólo números pares del 0 al 100
            for (i = 0; i < 101; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine("Número par: {0} ", i);
                    impar++;
                    Thread.Sleep(1000);
                }
            }
            //Segundo bucle, en la consola se escriben sólo números impares del 0 al 100
            for (i =  0; i < 100; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine("Número impar: {0} ", i);
                    par++;
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("Entre el 0 y el 100 hay {0} números pares, y {1} impares. ¡Siguientes shows!", par, impar);
            Thread.Sleep(2000);

            //Tercer bucle, en la consola se escriben todos los números de 0 al 100
            for (i = 0; i < 101; i++) {
                Console.WriteLine("Contador: {0} ", i);
                Thread.Sleep(1000);
            }

            //Cuarto bucle, se escriben todos los números del 100 al 0
            for (i = 100; i > -1; i--) {
                Console.WriteLine("Contador en reversa: {0} ", i);
                Thread.Sleep(1000);
            }

            //Quinto bucle, se escriben múltiplos de 3 entre el 0 y el 100

            for (i = 0; i < 100; i++) {
                if (i % 3 == 0) {
                    Console.WriteLine("Múltiplo de tres: {0} ", i);
                    Thread.Sleep(1000);
                }
            }
            
            //Último bucle, se escriben múltiplos de 2 y 3 entre el 0 y el 100
            for (i = 0; i < 101; i++) {
                if (i % 3 == 0) {
                    Console.WriteLine("Múltiplo de 3: {0} ", i);
                    Thread.Sleep(1000);
                } else if (i % 2 == 0) {
                    Console.WriteLine("Múltiplo de 2: {0} ", i);
                    Thread.Sleep(1000);
                }
            }

            //Finaliza el programa
            Console.WriteLine("Eso es todo. ¡Adiós!");
            Console.WriteLine("BOOP - BEEP");
        }
    }
}
