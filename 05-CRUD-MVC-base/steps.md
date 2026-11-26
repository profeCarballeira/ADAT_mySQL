# CRUD BASE EN UN DataGridView con modelo MVC
1. Interfaz: insertar controles y poner nombre y text
1. Crear carpetas Models, Views y Controllers
1. Arrastrar el formulario (Form1.cs) a la carpeta Views
1. Crear una clase que mapee la tabla Employees (get, set) en Models
1. En el controller (crear EmployeeController.cs) incluir el model (using)
1. Instalar (NuGet+using) MySql.Data.MySqlClient
1. Crear la cadena de conexión
1. Crear el método GetAll que devuelve una lista con todos los empleados
1. Incluir en el form los using (Modelo y controlador)
1. En el view (form) insertar como propiedad una instancia del EmployeeController
1. En el view (form) crear el método CargarDatos y asociar el handler del click de Cargar con ese método