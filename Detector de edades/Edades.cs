using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Detector_de_edades
{
    class Edad
    {//Se declaran las variables
        private string nombre;
        private int edad;
    
    //Se crea el constructor de la clase con las variables de arriba
        public Edad()
        {
            Console.Write("Ingrese el nombre de la persona, por favor:");
            nombre = Console.ReadLine();
            Console.Write("Ahora ingrese la edad del mismo:");
            edad = Int32.Parse(Console.ReadLine());
        }

    //Metodo para devolver el resultado
        public void Resultado()
        {
            Console.WriteLine("La persona ingresada se llama {0}.", nombre);
            Thread.Sleep(2000);
            Console.Write("{0} tiene {1} de edad, por tanto, es ", nombre, edad);
        }

    //Metodo para verificar si es mayor o menor de edad
        public void Comparar()
        {
            if (edad >= 18)
            {
                Console.Write("mayor de edad.");
            } else
            {
                Console.Write("es menor.");
            }
        }
        static void Main(string[] args)
        {//Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al detector de edades, donde podemos descubrir si la persona indicada es 100% legal o si no se puede tocar ni con un palo porque sino pal lobby bro.");
            Thread.Sleep(1000);
            Console.WriteLine("El programa es simple, ingresas el nombre y edad de la persona y verificamos si es mayor de 18 o no.");
            Thread.Sleep(1000);
            Console.WriteLine("¿Preparado?");

        //Se crea una instancia y se ejecutan los metodos
            Edad persona = new Edad();
            persona.Resultado();
            persona.Comparar();

        //Finaliza el progama
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("Eso es todo. ¡Adios!");
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
