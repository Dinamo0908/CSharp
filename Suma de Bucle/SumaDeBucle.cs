using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
	public static void Main()
	{
		//Se declaran las variables
		int i, limite, suma, sumaFinal;
		sumaFinal = 0;
		//Empieza el programa
		Console.WriteLine("Por favor, ingrese un numero:");
		limite = int.Parse(Console.ReadLine());
		//Se crea unn bucle for para sumar valores ingresados por el usuario hasta que llegue al limite establecido
		for (i = 0; i < limite; i++)
		{
			Console.WriteLine("Numero {0} :", i + 1);
			suma = int.Parse(Console.ReadLine());
			sumaFinal = suma + sumaFinal;
		}

		//Se devuelve el resultado y finaliza el programa
		Console.WriteLine("El resultado final es {0} .", sumaFinal);
	}
}