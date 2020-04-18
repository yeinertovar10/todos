using System;

class Program
{
    static void Main(string[] args)
    {
        aprendiz apsena = new aprendiz();
        apsena.nombre = " yeiner antonio";
        apsena.apellidos = "tovar samboni";
        apsena.Direccion = "san agustin";
        saludo(apsena);
    }
    private static void saludo(aprendiz apsena)
    {
        Console.WriteLine("bienevenido, sr(a)" + apsena.nombre);
        Console.WriteLine(apsena.apellidos);
        Console.WriteLine(apsena.Direccion);
        Console.ReadLine();

    }
}