using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class ProductoControlador
    {
        private readonly TiendaContext _context;

        public ProductoControlador(TiendaContext context)
        {
            _context = context;
        }

        public List<Modelo.Producto> Listar()
        {
            return _context.Productos
                .Include(p => p.Categoria) 
                .Include(p => p.Proveedor)
                .ToList();
        }

        public void Agregar(Producto nuevoProducto)
        {
            _context.Productos.Add(nuevoProducto);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            Producto ProductoSeleccionado = _context.Productos.Find(id);

            if (ProductoSeleccionado != null)
            {
                _context.Productos.Remove(ProductoSeleccionado);
                _context.SaveChanges();
            }
        }

        public void Modificar(Producto ProductoSeleccionado)
        {
            if (ProductoSeleccionado != null)
            {
                var ProductoExistente = _context.Productos.FirstOrDefault(c => c.Id == ProductoSeleccionado.Id);

                if (ProductoExistente != null)
                {
                    ProductoExistente.Nombre = ProductoSeleccionado.Nombre;
                    ProductoExistente.Descripcion = ProductoSeleccionado.Descripcion;
                    ProductoExistente.Precio = ProductoSeleccionado.Precio;
                    ProductoExistente.Stock = ProductoSeleccionado.Stock;
                    ProductoExistente.Categoria = ProductoSeleccionado.Categoria;
                    ProductoExistente.Proveedor = ProductoSeleccionado.Proveedor;

                    _context.SaveChanges();
                }
            }
        }

        public Producto BuscarPorID(int productoID)
        {
            return _context.Productos.FirstOrDefault(c => c.Id == productoID);
        }

        public void Actualizar(Producto producto)
        {
            var productoExistente = _context.Productos.FirstOrDefault(p => p.Id == producto.Id);
            if (productoExistente != null)
            {
                productoExistente.Nombre = producto.Nombre;
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.Precio = producto.Precio;
                productoExistente.Stock = producto.Stock;
                productoExistente.CategoriaId = producto.CategoriaId;
                productoExistente.ProveedorId = producto.ProveedorId;

                _context.SaveChanges();
            }
        }


        void AplicarDescuento(Producto producto, float porcentaje)
        {
            producto.Precio -= producto.Precio * porcentaje / 100;
        }
    }
}
