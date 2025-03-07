using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioProductos
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Inventario inventario = new Inventario();
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProducto.Text;
            decimal precio = Convert.ToDecimal(txtPrecioProducto.Text);
            int cantidad = Convert.ToInt32(txtCantidadStock.Text);

            inventario.AgregarProducto(new ProductoElectronico(nombre, precio, cantidad));
            ActualizarListaInventario();
        }

        private void ActualizarListaInventario()
        {
            listBoxInventario.Items.Clear();
            foreach (var producto in inventario.Productos)
            {
                listBoxInventario.Items.Add($"{producto.Nombre} - ${producto.Precio} - Stock: {producto.CantidadStock}");
            }
        }

        private void btnVenderProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarProducto.Text;
            int cantidad = Convert.ToInt32(txtCantidadVenta.Text);

            var producto = inventario.BuscarProducto(nombre);

            if (producto !=null && producto.Vender(cantidad))
            {
                MessageBox.Show("Venta realizada Exitosamente");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock o producto no valido");
            }

            ActualizarListaInventario();

        }
    }
}
