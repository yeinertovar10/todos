using System;

class Program
{
    static void Main(string[] args)
    {
        string nombreusuario = "";

        Console.WriteLine("por favor ingrese su nombre de usuario: ");
        nombreusuario = Console.ReadLine();


        Console.WriteLine("Bienvenido(a) " + nombreusuario + ".");
        Console.ReadLine();

    }
}

