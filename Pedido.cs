using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogramacion2
{
    internal class Pedido
    {
        private int NumeroPedido { get; set; }
        private Cliente Cliente { get; set; }
        private string Fecha { get; set; }
        private PedidoItem [] Item { get; set; }
        private int cantidadPedidoItem { get; set; }
        private AbsPromocion PromocionAplicada { get; set; }
        private string Estado { get; set; }
        private double TotalBruto { get; set; }
        private double TotalNeto { get; set; }
        public Pedido()
        {
            NumeroPedido = 1;

            Cliente = new Cliente();
            Fecha = "2-02-25";
            Item = new PedidoItem[1];
            cantidadPedidoItem = 1;
            PromocionAplicada = null;
            Estado = "Pendiente";
            TotalBruto = 0;
            TotalNeto = 0;
        }
        public Pedido(int numero, int puntos, string categoria, double limite, string fecha, int cantPedidoItem, AbsPromocion promocion, string estado, double totalBruto, double totalNeto)
        {
            NumeroPedido = numero;
            Cliente = new Cliente(puntos, categoria, limite);
            Fecha = fecha;
            Item = new PedidoItem[cantPedidoItem];
            cantidadPedidoItem = cantPedidoItem;
            PromocionAplicada = promocion;
            Estado = estado;
            TotalBruto = totalBruto;
            TotalNeto = totalNeto;
        }
    }
}
