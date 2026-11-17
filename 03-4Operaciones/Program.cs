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

                //inserción
                //INSERT INTO `employees` (`EmployeeID`, `LastName`, `FirstName`, `BirthDate`, `Photo`, `Notes`) VALUES (NULL, 'González', 'Antón', '2026-11-03', NULL, NULL);
                String insertQuery = @"INSERT INTO employees  (FirstName, LastName, BirthDate)
                                      VALUES ('Juan','Rolán','2007-06-20');";
                using (MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn))
                { 
                        int filasAfectadas = cmdInsert.ExecuteNonQuery();
                    Console.Write($"Filas/tuplas/registros insertados: {filasAfectadas} \n");
                }

                //modificación
                //UPDATE `employees` SET `FirstName` = 'Juan Manuel' WHERE `employees`.`EmployeeID` = 53;
                string updateQuery = @"UPDATE employees SET FirstName = 'Juan a secas' 
                                       WHERE EmployeeID = 53";
                using (MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, conn))
                {
                    int filasAfectadas = cmdUpdate.ExecuteNonQuery();
                    Console.Write($"Filas/tuplas/registros modificados: {filasAfectadas}\n");
                }

                //borrado
                //"DELETE FROM employees WHERE `employees`.`EmployeeID` = 57"
                string deleteQuery = @"DELETE FROM employees  
                                       WHERE EmployeeID = 56";
                using (MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, conn))
                {
                    int filasAfectadas = cmdDelete.ExecuteNonQuery();
                    Console.Write($"Filas/tuplas/registros borrados: {filasAfectadas}\n");
                }

                //consulta
                string selectQuery = "SELECT * FROM employees";
                using (MySqlCommand cmdSelect = new MySqlCommand(selectQuery, conn))
                {
                    using (MySqlDataReader dr = cmdSelect.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine($"ID: {dr["EmployeeID"]}, Nombre: {dr["FirstName"]}");
                        }
                    }
                }

            } //al hacer using ==> cieere automático



        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

}
