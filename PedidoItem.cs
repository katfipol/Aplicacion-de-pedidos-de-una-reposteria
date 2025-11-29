using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogramacion2
{
    internal class PedidoItem
    {
        private Producto[] Producto { get; set; }
        private int CantidadPro { get; set; }
        private int SubTotal { get; set; }

        public PedidoItem()
        {
            Producto = new Producto[1];
            CantidadPro = 1;
            SubTotal = 2;
        }
        public PedidoItem(int cantidad, int subtotal)
        {
            Producto = new Producto[CantidadPro];
            CantidadPro = cantidad;
            SubTotal = subtotal;
        }
    }
}
