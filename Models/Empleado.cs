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

        public Empleado(string nombre, string apellido, string numeroDeIdentificacion, byte edad, string posicion, double salario)
        {
            Id = Guid.NewGuid();
            Nombre = nombre.ToLower();
            Apellido = apellido.ToLower();
            NumeroDeIdentificacion = numeroDeIdentificacion;
            Edad = edad;
            Posicion = posicion.ToLower();
            Salario = salario;
        }

        private double CalcularBonificacion(){
            var bonificacion = Salario * 0.10;
            var salarioConBonificacion = Salario + bonificacion;
            return salarioConBonificacion;
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
            Salario con bonificacion: {CalcularBonificacion():c}");
            Console.WriteLine("----------------------------------------");
        }
    }
}