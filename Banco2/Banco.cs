using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Banco2
{
    class Cliente
    {//Se declaran las variables
        private string nombre;
        private int monto;
    //Método para ingresar datos del cliente
        public Cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }

    //Método para depositar dinero
        public void Depositar(int d)
        {
            monto = monto + d;
        }

    //Método para extraer dinero
        public void Extraer(int e)
        {
            monto = monto - e;
        }

    //Método para devolver el monto
        public int DevolverMonto()
        {
            return monto;
        }

    //Método para informar el monto
        public void Informar()
        {
            Console.WriteLine("El cliente/a {0} tiene la suma de {1} $.", nombre, monto);
        }
    }
    class Banco {
    //Se declaran las variables
        private Cliente cliente1, cliente2, cliente3;
        public Banco()
        {
            Console.Write("Ingresa el nombre del primer cliente:");
            cliente1 = new Cliente(Console.ReadLine());
            Console.Write("Ingresa el nombre del segundo cliente:");
            cliente2 = new Cliente(Console.ReadLine());
            Console.Write("Ingresa el nombre del tercer cliente:");
            cliente3 = new Cliente(Console.ReadLine());
        }

    //Se hacen las operaciones
        public void Operar()
        {   
            Console.Write("Ingresa el valor del depósito del primer cliente:");
            cliente1.Depositar(Int32.Parse(Console.ReadLine()));
            Console.Write("Ingresa el valor del depósito del segundo cliente:");
            cliente2.Depositar(Int32.Parse(Console.ReadLine()));
            Console.Write("Ingresa el valor del depósito del tercer cliente:");
            cliente3.Depositar(Int32.Parse(Console.ReadLine()));
            Console.Write("Ingresa el valor de la extracción del primer cliente:");
            cliente1.Extraer(Int32.Parse(Console.ReadLine()));
            Console.Write("Ingresa el valor de la extracción del segundo cliente:");
            cliente2.Extraer(Int32.Parse(Console.ReadLine()));
            Console.Write("Ingresa el valor de la extracción del tercer cliente:");
            cliente3.Extraer(Int32.Parse(Console.ReadLine()));
        }

    //Se devuelven todos los montos
        public void Depositos()
        {
            int dt = cliente1.DevolverMonto() + cliente2.DevolverMonto() + cliente3.DevolverMonto();
            Console.WriteLine("El total de dinero es de {0} $.", dt);
            Thread.Sleep(2000);
            cliente1.Informar();
            Thread.Sleep(2000);
            cliente2.Informar();
            Thread.Sleep(2000);
            cliente3.Informar();
            Thread.Sleep(2000);
        }

        static void Main(string[] args)
        {//Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al banco Kantas, donde somos tan tristes que tenemos sólo tres clientes a cargo de tí.");
            Thread.Sleep(1000);
            Console.WriteLine("Tu trabajo es simple. Debes atender a nuestros únicos y especiales clientes, ingresando sus depósitos y extracciones.");
            Thread.Sleep(1000);
            Console.WriteLine("Luego, se dará el depósito total de todo, además de que se informará el monto de cada cliente.");
            Thread.Sleep(1000);
            Console.WriteLine("¿Preparado?");
        
        //Se ejecutan las clases
            Banco banco1 = new Banco();
            banco1.Operar();
            banco1.Depositos();
        
        //Finaliza el programa
            Thread.Sleep(2000);
            Console.WriteLine("Bien, eso es todo por hoy, ya puedes irte a casa. ¡Adiós!");
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
        }
    }
}
