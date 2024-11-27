using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class ClienteControlador
    {
        private readonly TiendaContext _context;

        public ClienteControlador(TiendaContext context)
        {
            _context = context;
        }

        public List<Modelo.Cliente> GetList()
        {
            return _context.Clientes.ToList();
        }

        public void Agregar(Cliente nuevoCliente)
        {
            _context.Clientes.Add(nuevoCliente);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            Cliente ClienteSeleccionado = _context.Clientes.Find(id);
            if (ClienteSeleccionado != null)
            {
                _context.Clientes.Remove(ClienteSeleccionado);
                _context.SaveChanges();
            }
        }

        public void Modificar(Cliente ClienteSeleccionado)
        {
            if (ClienteSeleccionado != null)
            {
                var clienteExistente = _context.Clientes.FirstOrDefault(c => c.Id == ClienteSeleccionado.Id);

                if (clienteExistente != null)
                {
                    clienteExistente.Nombre = ClienteSeleccionado.Nombre;
                    clienteExistente.Direccion = ClienteSeleccionado.Direccion;
                    clienteExistente.Telefono = ClienteSeleccionado.Telefono;

                    _context.SaveChanges();
                }
            }
        }

        public Cliente BuscarPorID(int clienteId)
        {
            return _context.Clientes.FirstOrDefault(c => c.Id == clienteId);
        }

    }
}
