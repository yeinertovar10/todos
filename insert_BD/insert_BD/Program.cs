using System;

using MySql.Data.MySqlClient;


class Program
{
    static void Main(string[] args)
    {
        Usuario usuario new Usuario();
        Pregunta(usuario);
        GuardarenBD();
    }
    private static void Pregunta(Usuario usuario)
    {
        Console.WriteLine("TipoDocumento");
        usuario.TipoDocumento = Console.ReadLine();
        Console.WriteLine("NumeroDocumento");
        usuario.NumeroDocumento = Console.ReadLine();
        Console.WriteLine("PrimerNombre")
        usuario.PrimerNombre = Console.ReadLine();
        Console.WriteLine("SegundoNombre");
        usuario.SegundoNombre = Console.ReadLine();
        Console.WriteLine("PrimerApellido");
        usuario.PrimerApellido = Console.ReadLine();
        Console.WriteLine("SegundoApellido");
        usuario.SegundoApellido = Console.ReadLine();
        Console.WriteLine("Telefono");
        usuario.Telefono = Console.ReadLine();
        Console.WriteLine("CorreoElectronico");
        usuario.CorreoElectronico = Console.ReadLine();
        Console.WriteLine("Password");
        usuario.Password = Console.ReadLine();
       
        {

    private static void GuardarenBD()
        {
            MySqlConnection conex = new MySqlConnection(
                "Server=127.0.0.1;" +
                "Database=bdagroindustria;" +
                "Uid=root;" +
                "Pwd=;" +
                "SslMode=None"

                );
            conex.Open();

            string sql = "INSERT INTO tbusuario " +
                         "(TipoDocumento, NumeroDocumento, " +
                         "PrimerNombre, SegundoNombre, " +
                         "PrimerApellido, SegundoApellido, " +
                         "Telefono, CorreoElectronico, " +
                         "Password) " +
                         "VALUES " +
                         "(@TipoDocumento, @NumeroDocumento, " +
                         "@PrimerNombre, @SegundoNombre, " +
                         "@PrimerApellido, @SegundoApellido, " +
                         "@Telefono, @CorreoElectronico, " +
                         "@Password)";
                         

            MySqlCommand cmd = new MySqlCommand(sql, conex);

            cmd.Parameters.AddWithValue("@TipoDocumento", usuario.TipoDocumento);
            cmd.Parameters.AddWithValue("@NumeroDocumento", usuario.NumeroDocumento);
            cmd.Parameters.AddWithValue("@PrimerNombre", usuario.PrimerNombre);
            cmd.Parameters.AddWithValue("@SegundoNombre",  usuario.SegundoNombre);
            cmd.Parameters.AddWithValue("@PrimerApellido", usuario.PrimerApellido);
            cmd.Parameters.AddWithValue("@SegundoApellido", usuario.SegundoApellido);
            cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            cmd.Parameters.AddWithValue("@CorreoElectronico", usuario.CorreoElectronico);
            cmd.Parameters.AddWithValue("@Password", usuario.Password);
            int NumeroFilas=cmd.ExecuteNonQuery();
            if(NumeroFilas>0)
                Console.WriteLine("usuario agregado con exito");
                Console.ReadLine();

        

        cmd.ExecuteNonQuery();

        }
}




