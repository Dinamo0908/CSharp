using System;
using System.Collections.Generic;

namespace Detector_de_Semanas
{
    class Program
    {
        static void Main(string[] args)
        {
        //Se declara la única variable del código
        string input;

        //Diccionario con todos los días de la semana
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add("Domingo", "fin de semana");
        dict.Add("Lunes", "día de semana");
        dict.Add("Martes", "día de semana");
        dict.Add("Miércoles", "día de semana");
        dict.Add("Jueves", "día de semana");
        dict.Add("Viernes", "día de semana");
        dict.Add("Sábado", "fin de semana");

        //Inicia el programa
        Console.WriteLine("BEEP - BOOP");
        Console.WriteLine("Bienvenido al calendario Agustiniano, donde para nada te vamos a tratar como un ignorante si te olvidás de una tilde en alguna palabra.");
        Console.WriteLine("Esto es simple, decime el día en el que estamos y yo te voy a decir si es fin de semana o no. Caso contrario, te voy a decir que te vayas bien a freír churros a Mar Del Plata.");
        Console.WriteLine("Entonces dime, ¿Qué día es hoy?");
        
        //La variable input1 pasa a un switch case
        input = Console.ReadLine();
        switch (input)
        {
            
            default:
            Console.WriteLine("Lo siento compa, pero no te entendí ni mu. Andá a leerte un calendario y después volvés cuando sepas cómo se escriben los días de la semana, chau.");
            break;

            case "Domingo":
            Console.WriteLine("Hoy es " + dict["Domingo"]);
            break;

            case "Lunes":
            Console.WriteLine("Hoy es " + dict["Lunes"]);
            break;

            case "Martes":
            Console.WriteLine("Hoy es " + dict["Martes"]);
            break;

            case "Miércoles":
            Console.WriteLine("Hoy es " + dict["Miércoles"]);
            break;

            case "Jueves":
            Console.WriteLine("Hoy es " + dict["Jueves"]);
            break;

            case "Viernes":
            Console.WriteLine("Hoy es " + dict["Viernes"]);
            break;

            case "Sábado":
            Console.WriteLine("Hoy es " + dict["Sábado"]);
            break;
        }
        }
    }
}
