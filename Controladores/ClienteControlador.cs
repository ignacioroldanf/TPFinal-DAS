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

        public List<Cliente> Listar()
        {
            return _context.Clientes.ToList();
        }
        public List<ClienteIndividual> ListarClientesIndividuales()
        {
            return _context.Clientes.OfType<ClienteIndividual>().ToList();
        }
        public List<ClienteEmpresarial> ListarClientesEmpresariales()
        {
            return _context.Clientes.OfType<ClienteEmpresarial>().ToList();
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

        public void Modificar(Cliente clienteModificado)
        {
            if (clienteModificado != null)
            {
                var clienteExistente = _context.Clientes.FirstOrDefault(c => c.Id == clienteModificado.Id);

                if (clienteExistente != null)
                {
                    clienteExistente.Nombre = clienteModificado.Nombre;
                    clienteExistente.Direccion = clienteModificado.Direccion;
                    clienteExistente.Telefono = clienteModificado.Telefono;

                    if (clienteExistente is ClienteIndividual && clienteModificado is ClienteIndividual clienteInd)
                    {
                        ((ClienteIndividual)clienteExistente).DNI = clienteInd.DNI;
                    }

                    if (clienteExistente is ClienteEmpresarial && clienteModificado is ClienteEmpresarial clienteEmp)
                    {
                        ((ClienteEmpresarial)clienteExistente).CUIT = clienteEmp.CUIT;
                    }

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
