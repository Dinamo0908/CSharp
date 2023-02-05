using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sueldos
{
    class Dinero
    {//Se declaran las variables
        private int[] sueldos;
        
        //Método para pedir datos de cada sueldo
        public Dinero() {
            sueldos = new int[5];
            for (int i = 0; i < sueldos.Length; i++) {
                Console.Write("Ingrese el sueldo de la persona número {0}:", i+1);
                string datos = Console.ReadLine();
                sueldos[i] = int.Parse(datos);
            }
        }
        //Método para imprimir los datos de cada sueldo
        public void Imprimir() {
            for (int j = 0; j < sueldos.Length; j++) {
                Console.WriteLine("El sueldo número {0} es de {1} $.", j+1, sueldos[j]);
                Thread.Sleep(2000);
            }
        }
        
        static void Main(string[] args)
        {//Inicia el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al creador de sueldos, donde podés ser impresionantemente humilde o ser una rata graciosiña con tus trabajadores.");
            Thread.Sleep(1000);
            Console.WriteLine("Acá podés ingresar 5 sueldos distintos, los cuales se imprimirán para que no los olvides.");
            Thread.Sleep(1000);
            Console.WriteLine("¿Preparado?");
            Thread.Sleep(1000);

        //Se inician los métodos para ingresar datos y luego imprimirlos
            Dinero salarios = new Dinero();
            salarios.Imprimir();

        //Finaliza el programa
            Thread.Sleep(1000);
            Console.WriteLine("Eso es todo. ¡Adiós!");
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
