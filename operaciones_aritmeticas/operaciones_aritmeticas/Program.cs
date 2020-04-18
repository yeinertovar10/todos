using System;

class Program
{
    static void Main(string[] args)
    {
        string[] operaciones = new string[5];
        operaciones[0] = "suma";
        operaciones[1] = "resta";
        operaciones[2] = "multiplicacion";
        operaciones[3] = "dividion";
        operaciones[4] = "error";
        
        int opusuario = 0;
        int resultado = 0;
        int num1 = 0;
        int num2 = 0;
        int operacion = 0;
        string respuestausuario = "";

        Console.WriteLine("desea realizar algun tipo de operaciones" + "Y/N");
        respuestausuario = Console.ReadLine();
        while (respuestausuario == "Y")
        {
            Console.WriteLine("ingrese el primer entero ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo entero:");
            num2 = Convert.ToInt32(Console.ReadLine());
            for (int op = 0; op <= 3; op++)
            {
                Console.WriteLine((op + 1) + " . " + operaciones[op]);

            }

            Console.WriteLine("seleccione una operacion: ");
            opusuario = Convert.ToInt32(Console.ReadLine());
            switch (opusuario)
            {

                case 1:
                    Console.WriteLine("usted a seleccionado una suma ");
                    resultado = num1 + num2;
                    Console.WriteLine(resultado);
                    break;
                case 2:
                    Console.WriteLine("usted a seleccionado una resta ");
                    resultado = num1 - num2;
                    Console.WriteLine(resultado);
                    break;
                case 3:
                    Console.WriteLine("usted a seleccionado una multiplicacion ");
                    resultado = num1 * num2;
                    Console.WriteLine(resultado);
                    break;
                case 4:
                    Console.WriteLine("usted a seleccionado una division ");
                    resultado = num1 / num2;
                    Console.WriteLine(resultado);
                    break;
            }

            Console.ReadLine();
        }
    }


}
    


