using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string op;
            int res;

            Console.WriteLine("BEEP - BOOP");
            Console.WriteLine("Bienvenido a la calculadora en C# (Algun dia le vamos a poner un nombre xd)");
            Console.WriteLine("RECUERDA: Solo numeros enteros, no numeros decimales y tampoco el 0 (F por el 0)");
            Console.WriteLine("Por favor, ingresa los numeros que desees utilizar: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El primer numero seleccionado es " + num1);
            Console.WriteLine("Por favor, selecciona el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El segundo numero seleccionado es " + num2);
            Console.WriteLine("Por ultimo, elige que operador vas a utilizar (+ , - , * o /): ");
            op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("El resultado es " + res);
                        break;

                case "-":
                    res = num1 - num2;
                    Console.WriteLine("El resultado es " + res);
                    break;

                case "*":
                    res = num1 * num2;
                    Console.WriteLine("El resultado es " + res);
                    break;

                case "/":
                    res = num1 / num2;
                    Console.WriteLine("El resultado es " + res);
                    break;
            }
        }
    }
}
