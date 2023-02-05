using System;
using System.Collections.Generic;
using System.Text;

public class Reversa{
    public static void Main(){
        //Se declaran las variables
        int numero, division, resto, numeroFinal;
        
        //Empieza el programa 
        Console.WriteLine("Por favor, ingrese un numero de dos digitos: ");
        
        //Se lee el número y se crean fórmulas para devolverlo en reversa
        numero = int.Parse(Console.ReadLine());
        division = numero / 10;
        resto = numero / 10;
        numeroFinal = resto * 10 + division;
        
        //Finaliza el programa
        Console.WriteLine("El numero " + numero + " ingresado al reves es ", numeroFinal);

    }
}