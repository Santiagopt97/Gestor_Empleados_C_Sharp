using Gestor_Empleados.Models;



void Menu()
{
    var empresa = new Empresa("Riwi", "calle riwi");
    var nuevoEmpleado = new Empleado("santiago", "pineda", "12145475", 26, "desarrollador", 2500000);
    var nuevoEmpleado2 = new Empleado("vale", "piedrahita", "12302569", 22, "scrum master", 3500000);

    empresa.AgregarEmpleado(nuevoEmpleado);//quemados
    empresa.AgregarEmpleado(nuevoEmpleado2);
    bool flag = false;
    while (!flag)
    {
        Console.WriteLine("Gestor de Empleados");
        Console.WriteLine("1. Agregar Empleado");
        Console.WriteLine("2. Mostrar Empleados");
        Console.WriteLine("3. Eliminar Empleado");
        Console.WriteLine("4. Actualizar Empleado");
        Console.WriteLine("5. Buscar Empleados");
        Console.WriteLine("6. Buscar Empleados Por Cargo");
        Console.WriteLine("0. Salir");
        Console.Write("Escoja una opcion: ");
        int opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                empresa.AgregarEmpleado(empresa.PedirDatosEmpleado());
                break;
            case 2:
                empresa.MostrarEmpleados(empresa.ListaEmpleados);
                break;
            case 3:
                Console.Write("Ingrese el nombre del empleado a eliminar: ");
                string nombre = Console.ReadLine().ToLower();
                Console.Write("Ingrese el apellido del empleado a eliminar: ");
                string apellido = Console.ReadLine().ToLower();
                empresa.EliminarEmpleado(nombre, apellido);
                break;
            case 4:
                Console.WriteLine("Actualización de Empleado");
                Console.Write("Ingrese el numero de documento del empleado a actualizar: ");
                string documento = Console.ReadLine();
                empresa.ActualizarEmpleado(documento);
                break;
            case 5:
                Console.Write("Ingrese el numero de documento del empleado a buscar: ");
                string documentoBuscar = Console.ReadLine();
                empresa.BuscarEmpleado(documentoBuscar);
                break;

            case 6:
                Console.Write("Ingrese el cargo del empleado a buscar: ");
                string cargoBuscar = Console.ReadLine().ToLower();
                empresa.BuscarEmpleadosPorCargo(cargoBuscar);
                break;

            case 0:
                flag = true;
                break;


        }
    }
}

Menu();

