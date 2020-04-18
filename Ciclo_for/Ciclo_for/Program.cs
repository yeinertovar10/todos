using System;

class Program
{
    static void Main(string[] args)
    {
        int cantidad = 0;
        int n = 0;
        double sumatoria = 0.0;
        double valor = 0.0;
        double promedio = 0.0;
        string dato = "";

        Console.WriteLine("cuantos numeros son");
        dato = Console.ReadLine();
        cantidad = Convert.ToInt32(dato);

        for (n = 0; n < cantidad; n++)
        {
            Console.WriteLine("dame el numero ");
            dato = Console.ReadLine();
            valor = Convert.ToInt32(dato);

            sumatoria += valor;

        }

        promedio = sumatoria / cantidad;

        Console.WriteLine("el promedio es {0}", promedio);
        Console.WriteLine("presione una tecla para continuar.....!!!");
        Console.ReadLine();


    }
}

