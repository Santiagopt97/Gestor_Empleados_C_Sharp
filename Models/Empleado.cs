using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Empleados.Models
{
    public class Empleado : Persona
    {        
        public string Posicion { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, string apellido, string numeroDeIdentificacion, byte edad, string posicion, decimal salario)
        {
            Id = Guid.NewGuid();
            Nombre = nombre.ToLower();
            Apellido = apellido.ToLower();
            NumeroDeIdentificacion = numeroDeIdentificacion;
            Edad = edad;
            Posicion = posicion.ToLower();
            Salario = salario;
        }

        private decimal CalcularBonificacion(){
            var bonificacion = Salario * Convert.ToDecimal(0.10);
            var salarioConBonificacion = Salario + bonificacion;
            return salarioConBonificacion;
        }

        public override void MostrarInformacion(){
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("--------Informacion del empleado--------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($@"
            Nombre: {Nombre} {Apellido}
            Numero de Identificacion: {NumeroDeIdentificacion}
            Edad: {Edad} años
            Posicion: {Posicion}
            Salario con bonificacion: {CalcularBonificacion():c}");
            Console.WriteLine("----------------------------------------");
        }
    }
}   