using System;
using System.Collections.Generic;

namespace Desayuno
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings que serviran como inputs
            string input1;
            string input2;

            //diccionarios con las listas de comidas y bebidas
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Tostadas");
            dict.Add(2, "Sandwich");
            dict.Add(3, "Cereales");

            Dictionary<int, string> dict2 = new Dictionary<int, string>();
            dict2.Add(4, "Jugo de Naranja");
            dict2.Add(5, "Leche");
            dict2.Add(6, "Agua");

            //programa en accion
            Console.WriteLine("BEEP - BOOP");
            Console.WriteLine("Bienvenido a Dinamo's Fast Break Service, donde o comes en 5 minutos o te hacemos tostada pa los clientes");
            Console.WriteLine("Yo soy Alicia, te pateo el culo con caricia, y hoy voy a ser su mesera");
            Console.WriteLine("Tenemos una variedad de opciones para elegir. Que desea comer hoy? 1/2/3/A vos bb");
            
            //primera decision
            input1 = Console.ReadLine();
            switch (input1)
            {
                
                default: 
                Console.WriteLine("Si no desea comer nada, se puede ir amablemente y con toda la cordialidad del mundo al aparato reproductor de su querida y santa madre. Muchas gracias.");
                break;

                case "1":
                Console.WriteLine(dict[1]);
                break;
                
                case "2":
                Console.WriteLine(dict[2]);
                break;

                case "3":
                Console.WriteLine(dict[3]);
                break;

                case "A vos bb":
                Console.WriteLine("USTED SE TIENE QUE ARREPENTIR DE LO QUE DIJO!... a menos que tengas un millon de dolares y otro millon en la bolsa de Tiktok. En ese caso, nos vemos hoy a las 8 en mi casa UwU");
                break;

            }

            Console.WriteLine("Y que desea beber? 1/2/3/bebida ");

            //segunda decision
            input2 = Console.ReadLine();
            switch (input2)
            {
                
                default:
                Console.WriteLine("Si no desea beber nada, puede retirarse tranquilamente por la puerta a menos que desee beber del líquido extraño que sale del baño desde que Johnny, nuestro cliente con gastroentiritis y otros problemas del recto, fue a hacer sus necesidades hace un mes. Gracias");
                break;

                case "1":
                Console.WriteLine(dict2[4]);
                break;
                
                case "2":
                Console.WriteLine(dict2[5]);
                break;

                case "3":
                Console.WriteLine(dict2[6]);
                break;

                case "bebida":
                Console.WriteLine("... oc.");
                break;
            }
            //ultima seccion, se juntan los inputs en un texto y se cierra el programa
            Console.WriteLine("Entonces, usted va a comer un/a/as " + input1 + " con un/ " + input2);
            Console.WriteLine("Aquí tiene! Que lo disfrute! :D ");
            Console.WriteLine("Adios!");
        }
    }
}
