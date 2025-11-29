using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyectoprogramacion2
{
    internal class Cliente:Persona

    {
        private int PuntosAcumulados { get; set; }
        private string CategoriaCliente { get; set; }
        private double LimiteCredito { get; set; }

        public Cliente():base()
        {
            PuntosAcumulados = 0;
            CategoriaCliente = "Normal";
            LimiteCredito = 1000;
        }
        public Cliente(int ci, string nombre, string apellido, int telefono, string email, string direccion, int puntos, string categoria, double limite) : base(ci, nombre, apellido, telefono, email, direccion)
        {
            PuntosAcumulados = puntos;

            CategoriaCliente = categoria;

            LimiteCredito = limite;
        }
    }
}
