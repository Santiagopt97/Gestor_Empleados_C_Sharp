using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Empleados.Models
{
    public class Cliente : Persona
    {
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombre, string apellido, string numeroDeIdentificacion, byte edad, string email, string telefono)
        {
            Id = Guid.NewGuid();
            Nombre = nombre.ToLower();
            Apellido = apellido.ToLower();
            NumeroDeIdentificacion = numeroDeIdentificacion;
            Edad = edad;
            Email = email;
            Telefono = telefono;            
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefono: {Telefono}");
            Console.WriteLine("--------------------------------------------");
        }
    }
}