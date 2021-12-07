using System;
using System.Collections.Generic;

namespace HPPParcial2.Models
{
    public partial class OrdenDto
    {
        public int Id { get; set; }
        public int? ProduId { get; set; }
        public int? Cantidad { get; set; }
        public int? UsuarioId { get; set; }
        public int? EstadoId { get; set; }

        public int ZonaCosto {get;set;}

        public string Marca{get;set;}

        public string ZonaNombre {get;set;}

        public int ProduCosto {get;set;}

        public string ProduNombre {get;set;}

        public string EstadoNombre {get;set;}



        //public virtual Estado Estado { get; set; }
        //public virtual Productos Produ { get; set; }
        //public virtual Usuarios Usuario { get; set; }
    }
}
