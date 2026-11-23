using MySql.Data.MySqlClient;

namespace _04_5Oper_Foms_Parametros
{
    public partial class Form1 : Form
    {
        string cadConexion = "server=localhost; port=3307; user=profe;password=abc123.;database=w3schools;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //limpiamos el listbox de resultados
            lstResultados.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                try
                {
                    conn.Open();
                    string selectQuery = "SELECT * FROM employees";
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string resultado = $"ID: {dr["EmployeeID"]}, Nombre: {dr["FirstName"]} {dr["LastName"]}, Fecha: {dr["BirthDate"]}";
                                lstResultados.Items.Add(resultado);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Consulta erronea: {ex.Message}");
                }
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string firstName = txtName.Text;
            string lastName = txtLastName.Text;
            string birthDate = txtBirthDate.Text;

            DateTime fecha_yyyy_mm_dd;
            if (!DateTime.TryParseExact(txtBirthDate.Text, "d/M/yy", null, System.Globalization.DateTimeStyles.None, out fecha_yyyy_mm_dd))
            {
                MessageBox.Show("Formato de fecha incorrecto. Usar dd/mm/yy por ejemplo 24/07/83");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                try
                {
                    conn.Open();
                    //dos formas de hacerlo
                    //1. con formulación de cadenas
                    //string insertQuery = $@"INSERT INTO employees (FirstName, LastName, BirthDate) 
                    //                        VALUES ('{firstName}', '{lastName}', '{birthDate}')";
                    //2. con parámetros cualificados a posteriory
                    string insertQuery = $@"INSERT INTO employees (FirstName, LastName, BirthDate) 
                                            VALUES (@FirstName, @LastName, @BirthDate)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@BirthDate", fecha_yyyy_mm_dd);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        MessageBox.Show(filasAfectadas > 0 ? "Inserción correcta" : "No se ha podido insertar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Inserción con errores: {ex.Message}");
                }

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDEmployee.Text))
            {
                MessageBox.Show("Por favor, introduce un ID del empleado");
                return;
            }
            string firstName = txtName.Text;
            string lastName = txtLastName.Text;
            //string birthDate = txtBirthDate.Text;
            int id = int.Parse(txtIDEmployee.Text);

            DateTime fecha_yyyy_mm_dd;
            if (!DateTime.TryParseExact(txtBirthDate.Text, "d/M/yy", null, System.Globalization.DateTimeStyles.None, out fecha_yyyy_mm_dd))
            {
                MessageBox.Show("Formato de fecha incorrecto. Usar dd/mm/yy por ejemplo 24/07/83");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                try
                {
                    conn.Open();
                    string updateQuery = $@"UPDATE employees
                                          SET FirstName = @FirstName, LastName = @LastName, BirthDate = @BirthDate
                                          WHERE EmployeeID = @EmployeeID";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@BirthDate", fecha_yyyy_mm_dd);
                        cmd.Parameters.AddWithValue("@EmployeeID", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        MessageBox.Show(filasAfectadas > 0 ? "Modificación correcta" : "No se ha podido modifica");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Modificación erronea: {ex.Message}");
                }

            }



        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDEmployee.Text))
            {
                MessageBox.Show("Por favor, introduce un ID del empleado");
                return;
            }
            int id = int.Parse(txtIDEmployee.Text);

            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM employees WHERE EmployeeID = @EmployeeID";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        MessageBox.Show(filasAfectadas > 0 ? "Borrado efectuado" : "No se ha podido borrar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Borrado erroneo: {ex.Message}");
                }

            }

        }
    }
}
