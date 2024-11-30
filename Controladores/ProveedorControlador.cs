using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controladores
{
    public class ProveedorControlador
    {
        private readonly TiendaContext _context;
        public ProveedorControlador(TiendaContext context)
        {
            _context = context;
        }

        public List<Modelo.Proveedor> Listar()
        {
            return _context.Proveedores.ToList();
        }

        public void Agregar(Proveedor nuevoProveedor)
        {
            _context.Proveedores.Add(nuevoProveedor);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            Proveedor ProveedorSeleccionado = _context.Proveedores.Find(id);

            if (ProveedorSeleccionado != null)
            {
                _context.Proveedores.Remove(ProveedorSeleccionado);
                _context.SaveChanges();
            }
        }

        public void Modificar(Proveedor ProveedorSeleccionado)
        {
            if (ProveedorSeleccionado != null)
            {
                var ProveedorExistente = _context.Proveedores.FirstOrDefault(c => c.Id == ProveedorSeleccionado.Id);

                if (ProveedorExistente != null)
                {
                    ProveedorExistente.Nombre = ProveedorSeleccionado.Nombre;
                    ProveedorExistente.Direccion = ProveedorSeleccionado.Direccion;
                    ProveedorExistente.Telefono = ProveedorSeleccionado.Telefono;

                    _context.SaveChanges();
                }
            }
        }

        public Proveedor BuscarPorID(int proveedorID)
        {
            return _context.Proveedores.FirstOrDefault(c => c.Id == proveedorID);
        }



    }
}
