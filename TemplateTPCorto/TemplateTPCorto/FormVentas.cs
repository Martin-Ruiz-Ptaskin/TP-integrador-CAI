using Datos;
using Datos.Ventas;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPCorto
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

            CargarClientes();
            CargarCategoriasProductos();

            IniciarTotales();
        }

        private void IniciarTotales()
        {
            lablSubTotal.Text = "0.00";
            lblTotal.Text = "0.00";
        }

        private void CargarCategoriasProductos()
        {

            VentasNegocio ventasNegocio = new VentasNegocio();

            List<CategoriaProductos> categoriaProductos = ventasNegocio.obtenerCategoriaProductos();

            foreach (CategoriaProductos categoriaProducto in categoriaProductos)
            {
                cboCategoriaProductos.Items.Add(categoriaProducto);
            }
        }

        private void CargarClientes()
        {
            VentasNegocio ventasNegocio = new VentasNegocio();

            List<Cliente> listadoClientes = ventasNegocio.obtenerClientes();

            foreach (Cliente cliente in listadoClientes)
            {
                cmbClientes.Items.Add(cliente);
            }
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            VentasNegocio ventasNegocio = new VentasNegocio();
            CategoriaProductos categoriaSeleccionada = cboCategoriaProductos.SelectedItem as CategoriaProductos;
            if (categoriaSeleccionada != null) {
                List<Producto> productosCategoriaSeleccionada = new List<Producto>();
                productosCategoriaSeleccionada = ventasNegocio.obtenerProductosPorCategoria(categoriaSeleccionada.Id);
                lstProducto.SelectedIndexChanged -= lstProducto_SelectedIndexChanged;
                lstProducto.DisplayMember = "DisplayInfo";
                lstProducto.DataSource = productosCategoriaSeleccionada;
                lstProducto.SelectedIndexChanged += lstProducto_SelectedIndexChanged;

            }
        }

        private void cboCategoriaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoriaProductos categoriaSeleccionada = cboCategoriaProductos.SelectedItem as CategoriaProductos;
            if(categoriaSeleccionada!=null)
            {
                btnListarProductos.Enabled = true;
            }
        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto productoSeleccionado = lstProducto.SelectedItem as Producto;
            if (productoSeleccionado != null)
            {
                Console.WriteLine(productoSeleccionado);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CarritoNegocio carritoNegocio = new CarritoNegocio();
            Producto productoSeleccionado = lstProducto.SelectedItem as Producto;
            int cantidad;
            if (int.TryParse(txtCantidad.Text, out cantidad))
            {
                bool seAgregoExitoso = carritoNegocio.AgregarProductoCarrito(productoSeleccionado, cantidad);
                if (!seAgregoExitoso)
                {
                    MessageBox.Show("Error al agregar el producto al carrito");
                }
                else
                {
                    List<ProductoEnCarrito> productosDelCarrito = new List<ProductoEnCarrito>();
                    productosDelCarrito = carritoNegocio.obtenerProductosDelCarrito();

                    Carrito.SelectedIndexChanged -= Carrito_SelectedIndexChanged;
                    Carrito.DisplayMember = "DisplayInfo";
                    Carrito.DataSource = productosDelCarrito;
                    Carrito.SelectedIndexChanged += Carrito_SelectedIndexChanged;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }

        private void Carrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
