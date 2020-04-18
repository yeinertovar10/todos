using System;

class Program
{
    static void Main(string[] args)
    {
        calculadora();
    }
    public static void calculadora()
    {
        int operacion = 0;
        Console.WriteLine("ingrese la operacion: ");
        Int32.TryParse(Console.ReadLine(), out operacion);
        switch (operacion)
        {
            case 1:
                suma();
                break;

            case 2:
                resta();
                break;
            case 3:
                multiplicacion();
                break;
            case 4:
                division();
                break;
        }

    }
    public static void suma()
    {
        int Resultado = 0;
        int num1 = 0;
        int num2 = 0;
        Console.WriteLine("ingrese el numero 1: ");
        Int32.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("ingrese el numero 2: ");
        Int32.TryParse(Console.ReadLine(), out num2);
        Resultado = num1 + num2;
        Console.WriteLine("el resultado es: " + Resultado);
        Console.ReadLine();
    }

    public static void resta()
    {
        int Resultado = 0;
        int num1 = 0;
        int num2 = 0;
        Console.WriteLine("ingrese el numero 1: ");
        Int32.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("ingrese el numero 2: ");
        Int32.TryParse(Console.ReadLine(), out num2);
        Resultado = num1 - num2;
        Console.WriteLine("el resultado es: " + Resultado);
        Console.ReadLine();

    }

    public static void multiplicacion()
    {
        int Resultado = 0;
        int num1 = 0;
        int num2 = 0;
        Console.WriteLine("ingrese el numero 1: ");
        Int32.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("ingrese el numero 2: ");
        Int32.TryParse(Console.ReadLine(), out num2);
        Resultado = num1 * num2;
        Console.WriteLine("el resultado es: " + Resultado);
        Console.ReadLine();


    }

    public static void division()
    {
        int Resultado = 0;
        int num1 = 0;
        int num2 = 0;
        Console.WriteLine("ingrese el numero 1: ");
        Int32.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("ingrese el numero 2: ");
        Int32.TryParse(Console.ReadLine(), out num2);
        Resultado = num1 / num2;
        Console.WriteLine("el resultado es: " + Resultado);
        Console.ReadLine();
    }


        
  }

 

