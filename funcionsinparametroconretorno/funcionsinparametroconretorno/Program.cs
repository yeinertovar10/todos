using System;

class Program
{
   static decimal precioproducto = 0;
    static decimal precioproductoconIva = 0;
    static int categoriaproducto = 0;
    
    static void Main(string[] args)

    {
      

        Console.WriteLine("por favor, ingrese el costo del producto");
        decimal.TryParse(Console.ReadLine(), out precioproducto);
        Console.WriteLine("por favor ingrese la categoria del producto");
        Int32.TryParse(Console.ReadLine(), out categoriaproducto);

        if (categoriaproducto == 1)
        {

            precioproductoconIva = porcentaje5();
            Console.WriteLine("el precio del producto con Iva es: {0:c}", precioproductoconIva);
        }
        if (categoriaproducto == 2)
        {
            precioproductoconIva = porcentaje10();
            Console.WriteLine("el precio del producto con Iva es: {0:c}", precioproductoconIva);

        }
        if (categoriaproducto == 3)
        {
            precioproductoconIva = porcentaje19();
            Console.WriteLine("el precio del producto con Iva es: {0:c}", precioproductoconIva);

        }

        Console.ReadLine();
        }
        
    public static decimal porcentaje5()
    {

         decimal aux = 0.05M;
        precioproducto += precioproducto * aux;
        return precioproducto;
    }
    public static decimal porcentaje10()
    {

        decimal aux = 0.10M;
        precioproducto += precioproducto * aux;
        return precioproducto;
    }
          public static decimal porcentaje19()
    {

         decimal aux = 0.19M;
        precioproducto += precioproducto * aux;
        return precioproducto;
    }

}


     
