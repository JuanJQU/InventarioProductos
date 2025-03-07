using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioProductos
{
    public class Inventario
    {
        public List<ProductoElectronico> Productos { get; private set; }

        public Inventario()
        {
            Productos = new List<ProductoElectronico>();
        }

        public void AgregarProducto(ProductoElectronico producto)
        {
            Productos.Add(producto);
        }

        public ProductoElectronico BuscarProducto(string nombre)
        {
            return Productos.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
    }
}
