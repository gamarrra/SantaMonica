using System;
using System.Collections.Generic;

namespace HPPParcial2.Models
{
    public partial class TipoProducto
    {
        public TipoProducto()
        {
            Productos = new HashSet<Productos>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
