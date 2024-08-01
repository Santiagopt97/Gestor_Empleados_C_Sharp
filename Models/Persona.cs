using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Empleados.Models
{
    public class Persona
    {
        public  Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroDeIdentificacion { get; set; }
        public int Edad { get; set; }

        public virtual void MostrarInformacion(){
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("--------Informacion del empleado--------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($@"
            Nombre: {Nombre} {Apellido}
            Numero de Identificacion: {NumeroDeIdentificacion}
            Edad: {Edad} años");
            Console.WriteLine("----------------------------------------");
        }
    }
}