using System; 

class Program
{
    static void Main(string[] args)
    {
        int valorProducto = 0;
        int cantidadProducto = 0;
        int totalProducto = 0;
        int numeroProducto = 0;
        int totalCompra = 0;
        string respuestaUsuario = "";

        Console.WriteLine("Desea agregar productos al carrito ( Y / N): ");
        respuestaUsuario = Console.ReadLine();

        while (respuestaUsuario == "Y")
        {
            valorProducto++;

            Console.WriteLine("ingrese el valor del producto n. " + numeroProducto + ": ");
            valorProducto =Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("ingrese cantidad:");
            cantidadProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Desea agregar mas productos al carrito ( Y / N): ");
            respuestaUsuario = (Console.ReadLine());
            totalProducto = valorProducto * cantidadProducto;
            totalCompra += totalProducto;
            }

        Console.WriteLine("valor total de la factura: " + totalCompra);
        Console.ReadLine();
    }
}
    
