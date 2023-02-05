using System;
using System.Collections.Generic;

namespace Detector_de_Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch1;


            Dictionary<string, string> Caninos = new Dictionary<string, string>();

            Caninos.Add("Perro", "Canino");
            Caninos.Add("Lobo", "Canino");
            Caninos.Add("Coyote", "Canino");
 
            Dictionary<string, string> Felinos = new Dictionary<string, string>();

            Felinos.Add("Gato", "Felino");
            Felinos.Add("Leon", "Felino");
            Felinos.Add("Pantera", "Felino");
            

            Console.WriteLine("BEEP - BOOP ...");
            Console.WriteLine("Bienvenido al detector de animales, el unico detector innecesario para gente innecesaria.");
            Console.WriteLine("Tenemos dos clases: Caninos y felinos. Cada una de ellas cuenta con tres animales distintos. Empezamos?");
            Console.WriteLine("Por favor, elige un animal primero: ");

            ch1 = Console.ReadLine();

            switch (ch1)
            {
                case "Perro":
                    Console.WriteLine(Caninos["Perro"]);
                    break;
                case "Lobo":
                    Console.WriteLine(Caninos["Lobo"]);
                    break;
                case "Coyote":
                    Console.WriteLine(Caninos["Coyote"]);
                    break;
                case "Gato":
                    Console.WriteLine(Felinos["Gato"]);
                    break;
                case "Leon":
                    Console.WriteLine(Felinos["Leon"]);
                    break;
                case "Pantera":
                    Console.WriteLine(Felinos["Pantera"]);
                    break;
            }

        }
    }
}
