using System;
using System.Collections.Generic;

namespace HPPParcial2.Models
{
    public partial class Orden
    {
        public int Id { get; set; }
        public int? ProduId { get; set; }
        public int? Cantidad { get; set; }
        public int? UsuarioId { get; set; }
        public int? EstadoId { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Productos Produ { get; set; }
        public virtual Usuarios Usuario { get; set; }
    }
}
