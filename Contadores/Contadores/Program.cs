using System;

class Program
{
    static void Main(string[] args)
    {
        string NombreCiudad = "";
        int ciudadn = 1;
        Console.Write("por favor, ingresa nombre ciudad: ");
        NombreCiudad = Console.ReadLine();

        while (NombreCiudad !="fin")
        {
            Console.WriteLine("bienvenido ciudad n° " + ciudadn);
            Console.WriteLine("");
            Console.Write("por favor ingresa el nombre ciudad: ");
            NombreCiudad = Console.ReadLine();
            ciudadn += 1;
        }
        Console.WriteLine("fin del programa");
        Console.ReadLine();
    }
}

