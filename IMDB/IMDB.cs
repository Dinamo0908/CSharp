//Biblioteca de peliculas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace IMDB
{
        //Metodo para agregar una pelicula
        class Insert {
            public string movieLink;
            public string movieName;
            public Insert(string nm, string ml) {
                movieName = nm;
                movieLink = ml;
            }
            public string getName() {
                return movieName;
            }
            public string getAndOpenLink(string movieLink) {
                return movieLink;
                var prs = new ProcessStartInfo("chrome.exe");
                prs.Arguments = movieLink;
                Process.Start(prs);
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            string input2;
            string input3;
            string input4;
            //inicia el programa
            Console.WriteLine("BEEP BOOP");
            Console.WriteLine("Buenos dias, tardes y noches en dondequiera que estes, bienvenido a Dinamo's IMDB Studio, un cine para nada robado de otros sitios web.");
            Console.WriteLine("Tenemos una seleccion de 5 peliculas, todas ampliamente recomendadas y a un modico precio de -1 + 1 dolar.");
            
            //primera decision, si dice "no" lo echan, caso contrario sigue corriendo
            Console.WriteLine("Deseas agregar un combo a tu pedido?");
            input1 = Console.ReadLine();
            if (input1 == "no") {
                Console.WriteLine("No hay combo, no hay pelicula. Vete!");
            }
            else if (input1 == "si") {
                Console.WriteLine("Muy bien, entonces aqui tienes tu mcCombo doble googolplex multiplicada por la raiz cuadrada de 23 - 456, a un total de 700 australes. Hecho esto, sigamos!");
                Console.WriteLine("Que pelicula deseas ver? Personalizada/Saw/Godzilla/Batman/Scarface/Mid-Sommar");

                //decision 2, elegir una pelicula o agregar una categoria personal.
                input2 = Console.ReadLine();
                switch (input2) {
                    case "Personalizada":
                    Console.WriteLine("Entonces, quieres una personalizada, mmm.");
                    Console.WriteLine("En otra ocasion, te hubieramos hecho pochoclo pa los compas, pero como nos caes bien, vamos a hacerlo.");
                    Console.WriteLine("Por favor, dinos el nombre de la pelicula que quieres ver");
                    //ultima decision, elegir que pelicula ver.
                    input3 = Console.ReadLine();
                    Console.WriteLine("Muy bien, es una pelicula muy interesante " + input3 + " . Por favor, podrias proporcionarnos un link para verla?");
                    input4 = Console.ReadLine();
                    Insert link = new Insert(input3, input4);
                    link.getAndOpenLink(input4);
                    break;

                    case "Saw":
                    Console.WriteLine("Entonces, Saw sera. Es una saga muy interesante, sobre todo la primera entrega. El resto son un poco mas tirando a lo slasher que otra cosa");
                    Console.WriteLine("Aqui tienes tu ticket, seras redireecionado a una pagina en la que podras ver Saw ahora. Que lo disfrutes!");
                    var prs1 = new ProcessStartInfo("chrome.exe");
                    prs1.Arguments = "https://pelis28.top/pelicula/saw-el-juego-del-miedo/";
                    Process.Start(prs1);
                    break;

                    case "Godzilla":
                    Console.WriteLine("Una saga de Serie B sobre Kaijus en Japon muy interesante, sobre todo en su era Heisei. Te daremos un ticket para que veas la ultima pelicula que salio, Godzilla 2.");
                    Console.WriteLine("Aqui tienes tu ticket, seras redireecionado a una pagina en la que podras ver Godzilla ahora. Que lo disfrutes!");
                    var prs2 = new ProcessStartInfo("chrome.exe");
                    prs2.Arguments = "https://cinemitas.tv/peliculas/godzilla-rey-de-los-monstruos-altsv/";
                    Process.Start(prs2);
                    break;

                    case "Batman":
                    Console.WriteLine("Una de las mejores trilogias de heroes que pueden haber, en especial en su segunda entrega, la cual es precisamente la que tenemos disponible ahora mismo.");
                    Console.WriteLine("Aqui tienes tu ticket, seras redireecionado a una pagina en la que podras ver Batman ahora. Que lo disfrutes!");
                    var prs3 = new ProcessStartInfo("chrome.exe");
                    prs3.Arguments = "https://cinemitas.tv/peliculas/el-caballero-oscuro-usqu7/";
                    Process.Start(prs3);
                    break;

                    case "Scarface":
                    Console.WriteLine("Una joya del cine, producida en 1983 por Brian De Palma y protagonizada por el reconocido y gran actor Al Pacino. Una muy buena eleccion.");
                    Console.WriteLine("Aqui tienes tu ticket, seras redireecionado a una pagina en la que podras ver Scarface ahora. Que lo disfrutes!");
                    var prs4 = new ProcessStartInfo("chrome.exe");
                    prs4.Arguments = "https://cuevana3.video/115/el-precio-del-poder-scarface";
                    Process.Start(prs4);
                    break;

                    case "Mid - Sommar":
                    Console.WriteLine("La verdad es que no he visto la pelicula todavia, pero dicen que es muy interesante y original. Te invito a que la veas y me cuentes tu experencia luego");
                    Console.WriteLine("Aqui tienes tu ticket, seras redireecionado a una pagina en la que podras ver Mid - Sommar ahora. Que lo disfrutes!");
                    var prs5 = new ProcessStartInfo("chrome.exe");
                    prs5.Arguments = "https://pelisplushd.net/pelicula/midsommar";
                    Process.Start(prs5);
                    break;
                }
            }
        }
    }
}
//fin del programa
