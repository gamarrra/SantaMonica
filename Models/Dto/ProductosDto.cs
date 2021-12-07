using System;
using System.Collections.Generic;

namespace HPPParcial2.Models
{
    public partial class ProductosDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Stock { get; set; }
        public int TipoProductoId { get; set; }
        public DateTime Ingreso { get; set; }
        public int Costo { get; set; }
        public string Detalle { get; set; }
        public string FotoRuta {get;set;}
        public string TipoProductoNombre {get;set;}

        //public virtual TipoProducto TipoProducto { get; set; }
        //public virtual ICollection<Orden> Orden { get; set; }
    }
}
