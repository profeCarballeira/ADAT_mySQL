using System;
using System.Collections.Generic;
using System.Text;
using _05_CRUD_MVC_base.Models;
using MySql.Data.MySqlClient;

namespace _05_CRUD_MVC_base.Controllers
{
    internal class EmployeeController
    {
        private readonly string cadConexion = "server=localhost; port=3307; user=profe;password=abc123.;database=w3schools;";

        public List<Employee> GetAll() { 
            var empleados = new List<Employee>();

            using (MySqlConnection conn = new MySqlConnection(cadConexion)) { 
                conn.Open();
                string query = "SELECT EmployeeID, FirstName, LastName, BirthDate FROM employees";
                using (MySqlCommand cmd = new MySqlCommand(query,conn)){
                    using (MySqlDataReader dr = cmd.ExecuteReader()) { 
                        while (dr.Read()){
                            empleados.Add(new Employee {
                                EmployeeID = Convert.ToInt32(dr["EmployeeID"]),
                                FirstName = dr["FirstName"].ToString(),
                                LastName = dr["LastName"].ToString(),
                                BirthDate = Convert.ToDateTime(dr["BirthDate"])
                            });                            
                        }
                    }
                }             
             }
            return empleados;
        }
    }
}
