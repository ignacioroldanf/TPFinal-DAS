using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetalleFactura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }

        [ForeignKey("FacturaId")]
        public virtual Factura Factura { get; set; }
        [ForeignKey("ProductoId")]
        public virtual Producto Producto { get; set; }

    }
}
