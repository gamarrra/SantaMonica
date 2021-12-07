using System;
using System.Collections.Generic;

namespace HPPParcial2.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Orden = new HashSet<Orden>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public int ZonaId { get; set; }

        public virtual Zonas Zona { get; set; }
        public virtual ICollection<Orden> Orden { get; set; }
    }
}
