using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restorante
{
    class Program
    {
        static void Main(string[] args)
        {//Se declaran las variables
            double hamburguesas, papas, bebidas, ticket;
            double precioHamb = 2;
            double precioPapas = 1.2;
            double precioBeb = 0.8;
            string tieneDinero;

        //Empieza el programa
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al generador de tickets, para que sepas cuanto vas a tener que secar de tu preciosa e inocente billetera.");
            Thread.Sleep(1000);
            Console.WriteLine("El programa es simple, ingresas cuantas hamburguesas, papas y bebidas quieres, y te devolvemos el precio total de todo.");
            Thread.Sleep(1000);
            Console.WriteLine("Ten en cuenta que las hamburguesas cuestan 2$, las papas 1,2$, y las bebidas 0,8$");
            Thread.Sleep(1000);
            Console.WriteLine("Empezamos?");
            Thread.Sleep(1000);
        
        //Se pide la cantidad de hamburguesas, papas y bebidas, y luego se hace la cuenta de todo
            Console.Write("Por favor, ingresa cuantas hamburguesas quieres:");
            hamburguesas = Double.Parse(Console.ReadLine());
            Console.Write("Ahora, ingresa cuantas papas fritas quieres:");
            papas = Double.Parse(Console.ReadLine());
            Console.Write("Por ultimo, ingresa cuantas bebidas quieres:");
            bebidas = Double.Parse(Console.ReadLine());
            Console.WriteLine("Calculando...");
            ticket = (hamburguesas * precioHamb) + (papas * precioPapas) + (bebidas * precioBeb);
            Thread.Sleep(2000);

        //Se da el resultado, se pregunta si tiene dinero para pagarlo y finaliza el programa
            Console.WriteLine("La cantidad de hamburguesas es/son {0} hamburguesa/s, {1} papa/s, y {2} bebida/s.", hamburguesas, papas, bebidas);
            Thread.Sleep(2000);
            Console.WriteLine("Por tanto, el precio a pagar es de {0}$.", Math.Round(ticket));
            Thread.Sleep(2000);
            Console.WriteLine("Tienes el dinero para pagarlo?: s/n");
            tieneDinero = Console.ReadLine();
            if (tieneDinero == "s") {
                Console.WriteLine("Bien, aqui tienes tu pedido.");
                Thread.Sleep(2000);
                Console.WriteLine("Eso es todo, hasta luego...");
                Thread.Sleep(1000);
                Console.WriteLine("BOOP - BEEP");
                Thread.Sleep(2000);
            } else if (tieneDinero == "n") {
                Console.WriteLine("Entonces vas a tener que trabajas en mi puesto a partir de ahora |:D .");
                Thread.Sleep(2000);
                Console.WriteLine("Eso es todo, hasta luego...");
                Thread.Sleep(1000);
                Console.WriteLine("BOOP - BEEP");
                Thread.Sleep(2000);
            }
        }
    }
}
