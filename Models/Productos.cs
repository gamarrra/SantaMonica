using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HPPParcial2.Models
{
    public partial class Productos
    {
        public Productos()
        {
            Orden = new HashSet<Orden>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre debe tener al menos 1 caracter")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Es obligatorio indicar la marca del producto")]
        public string Marca { get; set; }
        [Range(0, 100000, ErrorMessage = "Debe ingresar un stock valido")]
        public int Stock { get; set; }
        [Range(1, 6, ErrorMessage = "Debe elegir un tipo de producto")]
        public int TipoProductoId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:mm-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "1/1/2019", "12/31/2050",
        ErrorMessage = "La fecha {0} debe ser entre {1} y {2}")]
        [Display(Name = "Ingreso")]
        public DateTime Ingreso { get; set; }
        [Range(0, 100000, ErrorMessage = "Debe ingresar un costo valido")]
        public int Costo { get; set; }
        public string Detalle { get; set; }

        public virtual TipoProducto TipoProducto { get; set; }
        public virtual ICollection<Orden> Orden { get; set; }
        public string FotoRuta { get; set; }
        [NotMapped()]//esto para los campos que no quiero guardar en la base de datos, como un campo calculado
        public IFormFile Foto { get; set; }
    }
}
