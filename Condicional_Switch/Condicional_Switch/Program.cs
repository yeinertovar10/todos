using System;
class Program
{
    static void Main(string[] args)
    {
        int dia = 0;
        int mes = 0;
        int anyo = 0;
        string mesletras = "";
        Console.WriteLine("ingrese su dia de nacimiento: ");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese mes de nacimiento: ");
        mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese el año de nacimiento: ");
        anyo = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        {
            case 1:
                mesletras = "enero";
                break;
            case 2:
                mesletras = "febrero";
                break;
            case 3:
                mesletras = "marzo";
            case 4:
                mesletras = "abril";
                break;
            case 5:
                mesletras = "mayo";
                break;
            case 6:
                mesletras = "junio";
            case 7:
                mesletras = "julio";
                break;
            case 8:
                mesletras = "agosto";
                break;
            case 9:
                mesletras = "septiembre";
            case 10:
                mesletras = "octubre";
                break;
            case 11:
                mesletras = "noviembre";
                break;
            case 12:
                mesletras = "diciembre";
                break;
            default:
                mesletras = "error";
                break;

        }
        if (mesletras == "error")
        {
            Console.WriteLine("la fecha ingresada es incorrecta: ");

            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("usted nacio el " + dia + " de " + mesletras + " del año " + "anyo");

            Console.ReadLine();




        }


    }
}

