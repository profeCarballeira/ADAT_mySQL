using MySql.Data.MySqlClient;

class Program {
    static void Main()
    {
        //revisar el usuario y los permisos sobre la BBDD (%/localhost/IP...)
        //string cadConexion = "server=localhost; port=3307; user=root;password=abc123.;database=w3schools;";
        string cadConexion = "server=localhost; port=3307; user=profe;password=abc123.;database=w3schools;";

        try
        {
            //conectar
            using (MySqlConnection conn = new MySqlConnection(cadConexion)) { 
                conn.Open();
                Console.WriteLine("Conexión con éxito");

            } //al hacer using ==> cieere automático
            //procesar

            //cerrar
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

}
