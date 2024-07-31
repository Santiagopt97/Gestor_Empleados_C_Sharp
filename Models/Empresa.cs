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

        public void AgregarEmpleado(Empleado empleado, List<Empleado> listaEmpleados){
            listaEmpleados.Add(empleado);
        }
    }
}