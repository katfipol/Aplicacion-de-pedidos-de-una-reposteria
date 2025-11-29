using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyectoprogramacion2
{
    internal class Empleado : Persona
    {
        private string Usuario { get; set; }
        private string Cargo { get; set; }
        private double SalarioBase { get; set; }
        private string Turno { get; set; }
        private double Bonificacion { get; set; }
        public Empleado() : base()
        {
            Usuario= "admin";
            Cargo = "Cajero";
            SalarioBase = 2500;
            Turno = "Mañana";
            Bonificacion = 0;
        }
        public Empleado(int ci, string nombre, string apellido, int telefono, string email, string direccion, string usuario, string cargo, double salarioBase, string turno, double bonificacion) : base(ci, nombre, apellido, telefono, email, direccion)
        {
            Usuario = usuario;
            Cargo = cargo;
            SalarioBase = salarioBase;
            Turno = turno;
            Bonificacion = bonificacion;
        }
    }
}
