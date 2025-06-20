﻿using Datos;
using Datos.modelos;
using Datos.Ventas;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VentasNegocio
    {
        public List<Cliente> obtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            ClientePersistencia clientePersistencia = new ClientePersistencia();

            clientes = clientePersistencia.obtenerClientes();

            return clientes;
        }

        public List<CategoriaProductos> obtenerCategoriaProductos()
        {
            List<CategoriaProductos> categoriaProductos = new List<CategoriaProductos>();

            CategoriaProductos p1 = new CategoriaProductos("1", "Audio");
            categoriaProductos.Add(p1);

            CategoriaProductos p2 = new CategoriaProductos("2", "Celulares");
            categoriaProductos.Add(p2);

            CategoriaProductos p3 = new CategoriaProductos("3", "Electro Hogar");
            categoriaProductos.Add(p3);

            CategoriaProductos p4 = new CategoriaProductos("4", "Informática");
            categoriaProductos.Add(p4);

            CategoriaProductos p5 = new CategoriaProductos("5", "Smart TV");
            categoriaProductos.Add(p5);

            return categoriaProductos;
        }

        public List<Producto> obtenerProductosPorCategoria(string idCategoria)
        {
            List<Producto> productos = new List<Producto>();
            ProductoPersistencia productoPersistencia = new ProductoPersistencia();
            productos = productoPersistencia.obtenerProductosPorCategoria(idCategoria);
            List<Producto> productosConStock = new List<Producto>();
            foreach (Producto producto in productos)
            {
                if (producto.Stock > 0 && producto.FechaBaja == null)
                {
                    productosConStock.Add(producto);
                }
            }
            return productosConStock;
        }

        public void concluirVenta(String cliente)
        {
            List<ProductoEnCarrito> productosDelCarrito = new List<ProductoEnCarrito>();
            VentaPersistencia ventaPersistencia = new VentaPersistencia();

            CarritoNegocio carritoNegocio = new CarritoNegocio();

            Persona usuario = AppState.UsuarioActual;
            productosDelCarrito = carritoNegocio.obtenerProductosDelCarrito();
            foreach (ProductoEnCarrito producto in productosDelCarrito)
            {
                VentaItemRequest ventaItem = new VentaItemRequest(cliente, producto.Id, producto.Cantidad);
                try
                {
                    ventaPersistencia.agregarVenta(ventaItem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw new Exception($"Error al agregar la venta del producto {producto.Nombre}: {ex.Message}", ex);
                }
            }
        }
    }
}
