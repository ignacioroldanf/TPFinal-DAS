using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{

    public class DetalleFacturaControlador
    {
        private readonly TiendaContext _context;

        public DetalleFacturaControlador(TiendaContext context)
        {
            _context = context;
        }

        public void Agregar(DetalleFactura nuevoDetalle)
        {
            _context.DetallesFacturas.Add(nuevoDetalle);
            _context.SaveChanges();
        }

        public List<Modelo.DetalleFactura> Listar()
        {
            return _context.DetallesFacturas.ToList();
        }
        public List<DetalleFactura> ListarPorFactura(int facturaId)
        {
            return _context.DetallesFacturas
                .Where(d => d.FacturaId == facturaId)
                .Include(d => d.Producto)
                .ToList();
        }



    }
}
