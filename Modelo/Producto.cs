using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        //Atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }

        public int CategoriaId {  get; set; }

        public int ProveedorId { get; set; }



        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        [ForeignKey("ProveedorId")]
        public Categoria Proveedor { get; set; }



    }
}
