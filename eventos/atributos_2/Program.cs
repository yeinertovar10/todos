using System;

class Program
{
    static void Main(string[] args)
    {
        aprendiz_2 apsena = new aprendiz_2();
        saludo(apsena);
        guardarEnBD(apsena);


    }
    private static void saludo(aprendiz_2 apsena)
    {
        Console.WriteLine("por favor escriba su nombre");
        apsena.nombres = Console.ReadLine();
        Console.WriteLine("por favor ingrese su apellido");
        apsena.apellidos = Console.ReadLine();
        Console.WriteLine("por favor su tipo de documento");
        apsena.TipoIdentificacion = Console.ReadLine();
        Console.WriteLine("por favor su numero de identificacion");
        apsena.NumeroIdentificacion = Console.ReadLine();
        Console.Write("ingrese la fecha nacimiento:(DD/MM/AAAA)");
        apsena.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("por ingrese su genero");
        apsena.Genero = Console.ReadLine();
        Console.WriteLine("por favor ingrese su id ficha");
        apsena.IdFicha = Console.ReadLine();
        Console.WriteLine("por favor ingrese su estado");
        apsena.Estado = Console.ReadLine();
        Console.WriteLine("por favor ingrese su direccion");
        apsena.Direccion = Console.ReadLine();
        Console.WriteLine("por favor su RH");
        apsena.RH = Console.ReadLine();
        Console.WriteLine("por favor igrese su email ");
        apsena.Email = Console.ReadLine();
        Console.WriteLine("por favor ingrese su telefono");
        apsena.Telefono = Console.ReadLine();
        Console.WriteLine("por favor su tipo de poblacion");
        apsena.TipodePoblacion = Console.ReadLine();
        Console.WriteLine("por favor escriba su departamento de residencia");
        apsena.DepartamentodeResidencia = Console.ReadLine();
        Console.WriteLine("por favor ingrese su municipio de residencia");
        apsena.MunicipiodeResidencia = Console.ReadLine();
        Console.WriteLine("por favor su ingrese su municipio de nacimeineto");
        apsena.MunicipiodeNacimiento = Console.ReadLine();
        Console.WriteLine("por favor su ingrese su estrato");
        apsena.Estrato = Console.ReadLine();
        Console.WriteLine("por favor su ingrese su EPS");
        apsena.EPS = Console.ReadLine();
        Console.WriteLine("por favor su ingrese su tipo de regimen");
        apsena.TipodeRegimen = Console.ReadLine();
        Console.WriteLine("por favor su ingrese su fecha de ingreso");
        apsena.FechadeIngreso = Console.ReadLine();
        Console.WriteLine("por favor su ingrese su discapacidad");
        apsena.Discapacidad = Console.ReadLine();
        Console.WriteLine("por favor su ingrese su libreta militar");
        apsena.LibretaMilitar = Console.ReadLine();
        Console.ReadLine();

    }
    private static void guardarEnBD(aprendiz_2 apsena)
    {
        Console.WriteLine("sr.(a) " + apsena.nombres + " " + apsena.apellidos + ". su usuario ha sido registrado con exito en la base de datos.");
        Console.ReadLine();
    }
}
