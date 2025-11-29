using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogramacion2
{
    internal class Producto
    {
        private int Codigo { get; set; }
        private string NombreProducto { get; set; }
        private double PrecioUnitario { get; set; }
        private int Stock { get; set; }
        private string Descripcion { get; set; }
        private string Proveedor { get; set; }
        public Producto()
        {
            Codigo = 1;
            NombreProducto = "Sin nombre";
            PrecioUnitario = 0;
            Stock = 0;
            Descripcion = "Pastel";
            Proveedor = "Bimbo";
        }
        public Producto(int codigo, string nombre, double precio, int stock, string descripcion, string proveedor)
        {
            Codigo = codigo;
            NombreProducto = nombre;
            PrecioUnitario = precio;
            Stock = stock;
            Descripcion = descripcion;
            Proveedor = proveedor;
        }
    }
}
