using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class FacturaControlador
    {
        private readonly TiendaContext _context;

        public FacturaControlador (TiendaContext context)
        {
            _context = context;
        }


        public void Agregar(Factura nuevaFactura)
        {
            _context.Facturas.Add(nuevaFactura);
            _context.SaveChanges();
        }

        public List<Modelo.Factura> Listar()
        {
            return _context.Facturas
                .Include(p => p.Cliente)
                .Include(p => p.Detalles)
                .ThenInclude(d => d.Producto)

                .ToList();
        }
        public List<DetalleFactura> ObtenerDetalles()
        {
            return _context.DetallesFacturas
                .Include(d => d.Producto) 
                .ToList();
        }
        public Factura BuscarPorID(int FacturaID)
        {
            return _context.Facturas.FirstOrDefault(f => f.Id == FacturaID);
        }

    }
}
