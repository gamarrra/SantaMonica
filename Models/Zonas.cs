using System;
using System.Collections.Generic;

namespace HPPParcial2.Models
{
    public partial class Zonas
    {
        public Zonas()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Costo { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
