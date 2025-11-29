using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoprogramacion2
{
    internal class Menu
    {
        private string Titulo { get; set; }
        private Producto Producto { get; set; }
        public Menu()
        {
            Titulo = "Menú Principal";
            Producto = new Producto();
        }
        public Menu(string titulo, int codigo, string nombre, double precio, int stock, string descripcion, string proveedor)
        {
            Titulo = titulo;
            Producto = new Producto(codigo, nombre, precio, stock, descripcion, proveedor);
        }
    }
}
