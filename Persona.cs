using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogramacion2
{
    internal class Persona
    {
        private int CI { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private int Telefono { get; set; }
        private string Email { get; set; }
        private string Direccion { get; set; }

        public Persona()
        {
            CI = 12345678;
            Nombre = "Zoyla";
            Apellido = "Vaca";
            Telefono = 76543210;
            Email = "zoylavaca@gmail.com";
            Direccion = "Avenida Argentina";
        }
        public Persona(int ci, string nombre, string apellido, int telefono, string email, string direccion)
        {
            CI = ci;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
        }








    }
}
