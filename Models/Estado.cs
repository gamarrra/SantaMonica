using System;
using System.Collections.Generic;

namespace HPPParcial2.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Orden = new HashSet<Orden>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Orden> Orden { get; set; }
    }
}
