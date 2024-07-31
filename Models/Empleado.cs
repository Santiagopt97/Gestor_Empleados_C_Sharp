using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Empleados.Models
{
    public class Empleado
    {
        public  Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroDeIdentificacion { get; set; }
        public byte Edad { get; set; }
        public string Posicion { get; set; }
        public double Salario { get; set; }

        private void CalcularBonificacion(){
            var bonificacion = Salario * 0.10;
            var salarioConBonificacion = Salario + bonificacion;
            Console.WriteLine($"El salario con bonificacion del empleado {Nombre} {Apellido} es de: {salarioConBonificacion:c}");
        }

        public void MostrarInformacion(){
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("--------Informacion del empleado--------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($@"
            Nombre: {Nombre} {Apellido}
            Numero de Identificacion: {NumeroDeIdentificacion}
            Edad: {Edad} años
            Posicion: {Posicion}
            ");
            CalcularBonificacion();
            Console.WriteLine("----------------------------------------");
        }

    }
}