using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProductos
{
   public class ProductoElectronico
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int CantidadStock { get; set; }

        public ProductoElectronico(string nombre, decimal precio, int cantidadStock)
        {
            Nombre = nombre;
            Precio = precio;
            CantidadStock = cantidadStock;
        }

        public bool Vender(int cantidad)
        {
            if(CantidadStock>= cantidad)
            {
                CantidadStock -= cantidad;
                return true;
            }
            return false;
        }
    }
}
