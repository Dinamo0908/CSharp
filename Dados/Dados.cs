using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dados
{//Se declara la clase en la que se crea la lógica de los dados
    class Dados 
    {
    //Se declaran las variables
        private int valor;
        private static Random aleatorio;

    //Se crea un método para establecer la variable aleatorio como Random
        public Dados() {
            aleatorio = new Random();
        }

    //Se crea un método para tirar los dados
        public void Tirar() 
        {
            valor = aleatorio.Next(1,6);
        }

    //Se crea un método para decir cuál es el valor del dado
        public void Valor() 
        {
            Console.WriteLine("El valor del dado es " + valor);
        }

    //Se crea un método para devolver el valor
        public int Devolver() 
        {
            return valor;
        }
    }
    //Clase en la que se instancian los dados y se generan los métodos del juego
    class JuegoDeDados
    {//Se instancian los dados
        private Dados dado1, dado2, dado3;

    //Constructor de la clase
        public JuegoDeDados() {
            dado1 = new Dados();
            dado2 = new Dados();
            dado3 = new Dados();
        }

    //Método para empezar el juego
        public void Jugar() 
        {
            dado1.Tirar();
            dado1.Valor();
            dado2.Tirar();
            dado2.Valor();
            dado3.Tirar();
            dado3.Valor();
            if (dado1.Devolver() == dado2.Devolver() && dado1.Devolver() == dado3.Devolver()) 
            {
                Console.WriteLine("Felicidades, ganaste!");
            } else 
            {
                Console.WriteLine("Lo lamento, pero perdiste ;(");
            }
        }

        static void Main(string[] args)
        {//Se instancia la clase 
            string decision;
            JuegoDeDados juego = new JuegoDeDados();

        //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Thread.Sleep(1000);
            Console.WriteLine("Bienvenido al Dado-Inador 450210, donde nunca dejaras de divertirte jugando :)");
            Thread.Sleep(1000);
            Console.WriteLine("El programa es simple, apenas te diga tocas cualquier tecla y automaticamente empieza el juego. Si los tres dados tienen el mismo valor, ganas, sino, pierdes");
            Thread.Sleep(1000);
            Console.WriteLine("Preparado?");
            Thread.Sleep(1000);

        //Se espera a que se ingrese cualquier tecla para que inicie el juego. Una vez terminado, se pasa a preguntar si jugar de vuelta o no
            Console.WriteLine("Presiona cualquier tecla para empezar:");
            Console.ReadKey();
            juego.Jugar();
            Console.Write("Quieres jugar una vez mas? S/N:");
            decision = Console.ReadLine();
            if (decision == "S") 
            {
                juego.Jugar();
            } else if (decision == "N")
            {//Finaliza el programa
            Console.WriteLine("Espero que te haya gustado, nos vemos luego!");
            Thread.Sleep(1000);
            Console.WriteLine("BOOP - BEEP");
            Thread.Sleep(2000);
            }
        }
    }
}
