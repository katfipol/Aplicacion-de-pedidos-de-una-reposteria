using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogramacion2
{
    internal class Venta
    {
        private int IdVenta { get; set; }
        private string FechaVenta { get; set; }
        private double MontoVenta { get; set; }
        private string DescripcionVenta { get; set; }
        private Empleado Empleado { get; set; }
        public Venta()
        {
            IdVenta = 1;
            FechaVenta = "20-02-2025";
            MontoVenta = 0;
            DescripcionVenta = "Sin descripción";
            Empleado = new Empleado();
        }
        public Venta(int id, string fecha, double monto, string descripcion, string usuario, string cargo, double salarioBase, string turno, double bonificacion)
        {
            IdVenta = id;
            FechaVenta = fecha;
            MontoVenta = monto;
            DescripcionVenta = descripcion;
            Empleado = new Empleado(usuario, cargo, salarioBase, turno, bonificacion);
        }
    }
}
