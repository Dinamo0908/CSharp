using System;

namespace Trabajadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se ingresean las variables para el trabajo
            float hrstrab, vhrstrab, anstrab;
            string nombre;
            string inspector;

            //Empieza el programa
            Console.WriteLine("BEEP - BOOP");
            Console.WriteLine("Por favor, escriba su nombre en este panel para ingresar.");

            //Nombre del inspector se asigna acá
            inspector = Console.ReadLine();

            Console.WriteLine("Bienvenido a 'Dr. Loco's Inc.', donde no hacemos crunching ni nos peleamos con todo el mundo pero, para los compas, trabajamos 18 horas al día y nos peleamos con la competenia.");
            Console.WriteLine("Buen dia, inspector {0} , veo que está aquí para hacer la inspección mensual, ¿No es así?, entonces, acompañeme y digame cual es el empleado que elegirá esta vez.", inspector);
            Console.WriteLine("Bien, ya estamos aquí. Por favor, llame al empleado del que quiere saber (Que no diga Juan por favor).");

            //Nombre se asigna acá
            nombre = Console.ReadLine();

            //Si el nombre es igual a Juan, el programa procede a realizar esta funcion
            if (nombre == "Juan") {
                Console.WriteLine("LA PUTA MADRE JUAN NOOOOOOO");
                Console.WriteLine("El inspector muere porque no puede saber quién es Juan. Fin.");
            }

            Console.WriteLine("Bien, aqui está {0} . Preguntele lo que desee. (Estoy cagado hasta las patas)", nombre);
            Console.WriteLine("(Le preguntás) ¿Cuántas horas a trabajado aquí?");
            
            //El total de horas se asigna acá
            hrstrab = float.Parse(Console.ReadLine());
            Console.WriteLine("Bien. ¿Cuánto se gana por hora acá?");

            //El valor de la hora se asigna acá
            vhrstrab = float.Parse(Console.ReadLine());
            Console.WriteLine("Muy bien, eso es aceptable. ¿Cuántos años ha trabajado aquí?");

            //El total de años se asigna acá
            anstrab = float.Parse(Console.ReadLine());
            Console.WriteLine("Muy bien, gracias {0} , eso servirá para hacer mi veredicto final, ya puedes retirarte.", nombre);
            Console.WriteLine("(El jefe se acerca al oido de {0} ) Si el inspector no nos denuncia, subis de puesto, sino, te vas con Andrómeda al cuarto oscuro, ahora rajá de acá", nombre);
            Console.WriteLine("Y bien inspector, ¿Cual es su veredicto?");
            
            //En esta parte se suman y asignan todas las variables
            float total = vhrstrab * hrstrab;
            float totalans = anstrab * 30;
            Console.WriteLine("Bien. Teniendo en cuenta que {0} trabaja {1} horas y recibe {2} $ por cada hora, en total recibió {3} $.", nombre, hrstrab, vhrstrab, total);
            Console.WriteLine("Si le sumamos que por año recibe 30 $ más, entonces recibe {0} $ en bruto.", total + totalans); 
            Console.WriteLine("El descuento es del 13%, así que eso sería un total de {0} $ menos.", (total + totalans) * 0.13);
            Console.WriteLine("Por tanto, el saldo a cobrar con el descuento es de un total de {0} $.", ((total + totalans) - (total + totalans) * 0.13));
            
            //Finaliza el programa
            Console.WriteLine("¿Qué piensa, Jefe? ¿Es una buena cifra?");
            Console.WriteLine("Bueno, yo creo que sí, es una cifra justa y digna para un trabajador como {0} . ¿Está todo en orden, entonces?", nombre);
            Console.WriteLine("Sí, mi trabajo aquí termino. Nos vemos jefe, espero que la próxima vez encuentre a su compañía tan bien como ahora");
            Console.WriteLine("¡Adiós! {0} , estás ascendido.", nombre);
            Console.WriteLine("BOOP - BEEP");
            
        }
    }
}
