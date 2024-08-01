using Gestor_Empleados.Models;



void Menu()
{
    var empresa = new Empresa("Riwi", "calle riwi");
    var nuevoEmpleado = new Empleado("santiago", "pineda", "12145475", 26, "desarrollador", 2500000);
    var nuevoEmpleado2 = new Empleado("vale", "piedrahita", "12302569", 22, "scrum master", 3500000);
    var nuevoCliente = new Cliente("juan", "perez", "12345678", 25,"calle@correo.com", "3026654785");
    var nuevoCliente2 = new Cliente("pedro", "gomez", "98765432", 38,"pedro@correo.com", "302645458");

    empresa.AgregarEmpleado(nuevoEmpleado);//quemados
    empresa.AgregarEmpleado(nuevoEmpleado2);
    empresa.AgregarCliente(nuevoCliente);
    empresa.AgregarCliente(nuevoCliente2);
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
        Console.WriteLine("7. Agregar Cliente");
        Console.WriteLine("8. Eliminar Cliente");
        Console.WriteLine("9. Mostrar Clientes");
        Console.WriteLine("0. Salir");
        Console.Write("Escoja una opcion: ");
        int opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                empresa.AgregarEmpleado(empresa.PedirDatosEmpleado());
                Pausarmenu();
                break;
            case 2:
                empresa.MostrarEmpleados(empresa.ListaEmpleados);
                Pausarmenu();
                break;
            case 3:
                Console.Write("Ingrese el nombre del empleado a eliminar: ");
                string nombre = Console.ReadLine().ToLower();
                Console.Write("Ingrese el apellido del empleado a eliminar: ");
                string apellido = Console.ReadLine().ToLower();
                empresa.EliminarEmpleado(nombre, apellido);
                Pausarmenu();
                break;
            case 4:
                Console.WriteLine("Actualización de Empleado");
                Console.Write("Ingrese el numero de documento del empleado a actualizar: ");
                string documento = Console.ReadLine();
                empresa.ActualizarEmpleado(documento);
                Pausarmenu();
                break;
            case 5:
                Console.Write("Ingrese el numero de documento del empleado a buscar: ");
                string documentoBuscar = Console.ReadLine();
                empresa.BuscarEmpleado(documentoBuscar);
                Pausarmenu();
                break;

            case 6:
                Console.Write("Ingrese el cargo del empleado a buscar: ");
                string cargoBuscar = Console.ReadLine().ToLower();
                empresa.BuscarEmpleadosPorCargo(cargoBuscar);
                Pausarmenu();
                break;

            case 7:
                empresa.AgregarCliente(empresa.PedirDatosCliente());
                Pausarmenu();
                break;

            case 8:
                Console.Write("Ingrese el nombre del cliente a eliminar: ");
                string nombreCliente = Console.ReadLine().ToLower();
                Console.Write("Ingrese el apellido del cliente a eliminar: ");
                string apellidoCliente = Console.ReadLine().ToLower();
                empresa.EliminarCliente(nombreCliente, apellidoCliente);
                Pausarmenu();
                break;

            case 9:
                empresa.MostrarClientes(empresa.ListaClientes);
                Pausarmenu();
                break;


            case 0:
                flag = true;
                break;


        }
    }
}

void Pausarmenu()
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
}

Menu();

