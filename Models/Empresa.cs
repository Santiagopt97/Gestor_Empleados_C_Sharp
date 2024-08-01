using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Empleados.Models
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Empleado> ListaEmpleados = new List<Empleado>();
        public List<Cliente> ListaClientes = new List<Cliente>();

        public Empresa(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public Empleado PedirDatosEmpleado()
        {
            Console.WriteLine("Ingrese los datos del empleado:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Numero de documento: ");
            string documento = Console.ReadLine();
            Console.Write("Edad: ");
            byte edad = Convert.ToByte(Console.ReadLine());
            Console.Write("Posicion: ");
            string posicion = Console.ReadLine();
            Console.Write("Salario: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            return new Empleado(nombre, apellido, documento, edad, posicion, salario);
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
            Console.WriteLine($"El empleado {empleado.Nombre} {empleado.Apellido} ha sido agregado.");
        }

        public void EliminarEmpleado(string nombre, string apellido)
        {
            Console.WriteLine($"Estas seguro que deseas eliminar al empleado: {nombre} {apellido} (si o no)");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "si")
            {
                Empleado empleadoAEliminar = ListaEmpleados.Find(e => e.Nombre == nombre && e.Apellido == apellido);
                if (empleadoAEliminar != null)
                {
                    ListaEmpleados.Remove(empleadoAEliminar);
                    Console.WriteLine($"El empleado {nombre} {apellido} ha sido eliminado.");
                }
                else
                {
                    Console.WriteLine($"El empleado {nombre} {apellido} no se encuentra en la lista.");
                }
            }
        }

        public void MostrarEmpleados(List<Empleado> listaEmpleados)
        {
            Console.WriteLine("Empleados de la empresa: ");
            foreach (var empleado in listaEmpleados)
            {
                empleado.MostrarInformacion();
            }
        }

        public void ActualizarEmpleado(string numeroDeIdentificacion)
        {
            var empleadoAModificar = ListaEmpleados.Find(empleado => empleado.NumeroDeIdentificacion == numeroDeIdentificacion);
            if (empleadoAModificar != null)
            {
                Console.WriteLine(@"
                Que deseas modificar: 
                1. Nombre
                2. Apellido
                3. Documento
                4. Edad
                5. Posicion
                6. Salario
                ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Nuevo nombre: ");
                        empleadoAModificar.Nombre = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Nuevo apellido: ");
                        empleadoAModificar.Apellido = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Nuevo documento: ");
                        empleadoAModificar.NumeroDeIdentificacion = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Nueva edad: ");
                        empleadoAModificar.Edad = Convert.ToByte(Console.ReadLine());
                        break;
                    case 5:
                        Console.Write("Nueva posicion: ");
                        empleadoAModificar.Posicion = Console.ReadLine();
                        break;
                    case 6:
                        Console.Write("Nuevo salario: ");
                        empleadoAModificar.Salario = Convert.ToDecimal(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }

            }
        }

        public void BuscarEmpleado(string numeroDeIdentificacion)
        {
            var empleadoEncontrado = ListaEmpleados.Find(empleado => empleado.NumeroDeIdentificacion == numeroDeIdentificacion);
            if (empleadoEncontrado != null)
            {
                empleadoEncontrado.MostrarInformacion();
            }
            else
            {
                Console.WriteLine($"El empleado con el numero de identificacion {numeroDeIdentificacion} no se encuentra en la lista.");
            }
        }

        public void BuscarEmpleadosPorCargo(string posicion)
        {
            Console.WriteLine($"Empleados con la posicion {posicion}:");
            var empleadosPorCargo = ListaEmpleados.FindAll(empleado => empleado.Posicion == posicion);
            foreach (var empleado in empleadosPorCargo)
            {
                empleado.MostrarInformacion();
            }

        }

        public void AgregarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
            Console.WriteLine($"El cliente {cliente.Nombre} {cliente.Apellido} ha sido agregado.");
        }
        public Cliente PedirDatosCliente()
        {
            Console.WriteLine("Ingrese los datos del cliente:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Numero de documento: ");
            string documento = Console.ReadLine();
            Console.Write("Edad: ");
            byte edad = Convert.ToByte(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Telefono: ");
            string telefono = Console.ReadLine();

            return new Cliente(nombre, apellido, documento, edad, email, telefono);
        }

        public void EliminarCliente(string nombre, string apellido){
            Console.WriteLine($"Estas seguro que deseas eliminar al Cliente: {nombre} {apellido} (si o no)");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "si")
            {
                Cliente clienteAEliminar = ListaClientes.Find(e => e.Nombre == nombre && e.Apellido == apellido);
                if (clienteAEliminar != null)
                {
                    ListaClientes.Remove(clienteAEliminar);
                    Console.WriteLine($"El ciente {nombre} {apellido} ha sido eliminado.");
                }
                else
                {
                    Console.WriteLine($"El ciente {nombre} {apellido} no se encuentra en la lista.");
                }
            }
        }

        public void MostrarClientes(List<Cliente> listaClientes)
        {
            Console.WriteLine("Clientes de la empresa: ");
            foreach (var cliente in listaClientes)
            {
                cliente.MostrarInformacion();
            }
        }
    }
}