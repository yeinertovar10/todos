using System;

class program
{
    static void Main(string[] args)
    {

        string NombreUsuario = "";
        Console.Write("por favor, ingresa tu nombre: ");
        NombreUsuario = Console.ReadLine();


        //Estructura repetitiva para preguntar por el nombre
        while (NombreUsuario != "FIN")
        {


            Console.WriteLine("Bienvenido, sr(a) " + NombreUsuario + ".");
            Console.WriteLine("");
            Console.WriteLine("por favor ingresa tu nombre: ");
            NombreUsuario = Console.ReadLine();
            Console.ReadLine();


        }
        Console.WriteLine("fin del programa");
        Console.ReadLine();
    }
}