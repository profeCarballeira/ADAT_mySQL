using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        //revisar el usuario y los permisos sobre la BBDD (%/localhost/IP...)
        //string cadConexion = "server=localhost; port=3307; user=root;password=abc123.;database=w3schools;";
        string cadConexion = "server=localhost; port=3307; user=profe;password=abc123.;database=w3schools;";

        try
        {
            //conectar
            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                conn.Open();
                Console.WriteLine("Conexión con éxito");

                //procesar
                //nombre y precio de todos los productos
                string query = @"SELECT ProductName, Price 
                            FROM products;";

                //lanzamos la consulta
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                    using (MySqlDataReader dr = cmd.ExecuteReader()) {
                        while (dr.Read())
                            Console.WriteLine($"Producto: {dr["ProductName"]}, Precio: {dr["Price"]}");
                    }
                }

                //consulta con todos los productos de "Condiments"


            } //al hacer using ==> cieere automático
            

          
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

}
