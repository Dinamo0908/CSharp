using System;
using System.Linq;

namespace ATM_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            int cash = 10000;
            string ver;
            Console.WriteLine("BEEP - BOOP bienvenido a la caja registradora automatica, donde puedes retirar hasta un millon de dolares, pero no los veras en tu vida.");
            Console.WriteLine("Por favor, ingresa tu pin, que debe contener solamente 6 numeros");
            ver = Console.ReadLine();
            int verL = ver.Length;
            if  ((verL == 6) && (ver.All(char.IsDigit))) {
                Console.WriteLine("Perfecto, el pin que ingresaste es {0}", ver);
                Console.WriteLine("Tienes un total de " + cash + " dolares, cuanto quieres retirar? 10/20/100/10000");
                x = Console.ReadLine();
                switch (x)
                {
                    case "10":
                        int res = cash - 10;
                        Console.WriteLine("Retiraste 10 dolares, te quedan " + res + " dolares");
                        break;

                    case "20":
                        int res1 = cash - 20;
                        Console.WriteLine("Retiraste 20 dolares, te quedan " + res1 + " dolares");
                        break;

                    case "100":
                        int res2 = cash - 100;
                        Console.WriteLine("Retiraste 20 dolares, te quedan " + res2 + " dolares");
                        break;

                    case "10000":
                        int res3 = cash - 10000;
                        Console.WriteLine("Retiraste todo tu dinero! No te queda ni un solo dolar XD");
                        Console.WriteLine("Adios!");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Incorrecto, el pin que ingresaste, " + ver + " ,no esta bien implementado. Por favor, intentelo nuevamente");
                Console.WriteLine("Inserte cualquier tecla para cerrar el programa e intentarlo nuevamente");
                Console.ReadKey();
            }
        }
    }
}
