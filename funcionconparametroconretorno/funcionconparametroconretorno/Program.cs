using System;

class Program
{
    static void Main(string[] args)
    {
        int numeronotas = 0;
       

        Console.WriteLine("===NOTAS===");
        Console.WriteLine("ingrese el numero de notas: ");
        Int32.TryParse(Console.ReadLine(), out numeronotas);
        string resultado = calcularnotas(numeronotas);
    }
    public static string calcularnotas(int numeronotas)
    {
        decimal nota = 0;
        decimal sumanotas = 0;
        decimal promedio = 0;
        for (int i = 1; i <= numeronotas; i++)
        {
            Console.Write("ingrese la nota N:" + "");
            decimal.TryParse(Console.ReadLine(), out nota);
            sumanotas += nota;
            promedio = sumanotas / i;
            

        }

        if (promedio >= 6)
        {

            Console.WriteLine("usted ha pasado");
        }
        else
        {
            Console.WriteLine("usted ha perdido");
        }
        Console.ReadLine();
        return "";
        {

        }
    }
}      

