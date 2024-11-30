using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class CategoriaControlador
    {
        private readonly TiendaContext _context;

        public CategoriaControlador(TiendaContext context)
        {
            _context = context;
        }

        public List<Modelo.Categoria> Listar()
        {
            return _context.Categorias.ToList();
        }

    }
}
