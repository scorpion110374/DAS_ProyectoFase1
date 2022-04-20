using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectoAvance1.Models
{
    public class Producto
    {
        [Column, Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(15)"), MaxLength(15), Required]
        [DisplayName("Código de Producto")]
        public string Codigo { get; set; }
        [Column(TypeName = "varchar(100)"), MaxLength(100), Required]
        [DisplayName("Descripción de Producto")]
        public string Descripcion { get; set; }
        [Column(TypeName = "varchar(100)"), MaxLength(100)]
        [DisplayName("Foto")]
        public string Foto { get; set; }
        [Required]
        [DisplayName("Categoría de Producto")]
        public int IdCategoria { get; set; }
        [Column(TypeName = "decimal(10,2)"), Required, DefaultValue(0)]
        [DisplayName("Precio")]
        public decimal Precio { get; set; }
        [Column(TypeName = "decimal(10,2)"), Required, DefaultValue(0)]
        [DisplayName("Precio Oferta")]
        public decimal PrecioOferta { get; set; }
        [Required, DefaultValue(true)]
        [DisplayName("Disponible")]
        public bool Disponible { get; set; }
        [Required, DefaultValue(1)]
        [DisplayName("Nuevo Producto")]
        public int Nuevo { get; set; }
        [Required, DefaultValue(0)]
        [DisplayName("Oferta")]
        public int Oferta { get; set; }
        [Required, DefaultValue(0)]
        [DisplayName("Descuento")]
        public int Descuento { get; set; }
        [Column(TypeName = "decimal(4,2)"), Required, DefaultValue(0)]
        [DisplayName("Peso")]
        public decimal Peso { get; set; }
    }
}
