using System;

class Program
{
    static void Main(string[] args)
    {

        string Nombre = "";
        string Apellido = "";
        Console.WriteLine("por favor ingrese su nombre: ");
        Nombre = Console.ReadLine();
        Console.Write("por favor ingrese su apellido: ");
        Apellido = Console.ReadLine();
        Mostrarmensaje(Nombre, Apellido);
    }

    public static void Mostrarmensaje(string Nombreusuario, string Apellidousuario)
    {
        Console.WriteLine("bienvenido, sr(a)." + Nombreusuario + " " + Apellidousuario);
        Console.ReadLine();

    }
}