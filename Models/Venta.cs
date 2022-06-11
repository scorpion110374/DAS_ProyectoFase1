using ProjectoAvance1.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectoAvance1.Models
{
    public class Venta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]
        [DisplayName("Id Venta")]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        [DisplayName("N° Orden")]
        public string Norden { get; set; }
        [Required]
        [DisplayName("Fecha Venta")]
        public DateTime Fecha { get; set; }
        [Column(TypeName = "nvarchar(450)"), Required]
        [DisplayName("Id Usuario")]
        public string IdUsuario { get; set; }
        [Column(TypeName = "nvarchar(100)"),Required]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [Column(TypeName = "nvarchar(100)"), Required]
        [DisplayName("Apellido")]
        public string Apellido { get; set; }
        [Column(TypeName = "nvarchar(100)"), Required]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(100)"), Required]
        [DisplayName("Dirección")]
        public string Direccion { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Dirección 2")]
        public string Direccion2 { get; set; }
        [Column(TypeName = "nvarchar(15)"), Required]
        [DisplayName("Teléfono")]
        public string Telefono { get; set; }
        [Column(TypeName = "nvarchar(25)"), Required]
        [DisplayName("País")]
        public string Pais { get; set; }
        [Column(TypeName = "nvarchar(25)"), Required]
        [DisplayName("Departamento")]
        public string Departamento { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Código Postal")]
        public string CodigoPostal { get; set; }
        [Column(TypeName = "nvarchar(10)"), Required]
        [DisplayName("Tipo de Pago")]
        public string TipoPago { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Nombre en Tarjeta")]
        public string Cc_name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Número de Tarjeta")]
        public string Cc_number { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Fecha Expiración")]
        public string Cc_expiration { get; set; }
        [Column(TypeName = "nvarchar(5)")]
        [DisplayName("Código Seguridad")]
        public string Cc_cvv { get; set; }
        [Column(TypeName = "decimal(10,2)"), Required, DefaultValue(0)]
        [DisplayName("Valor")]
        public decimal Valor { get; set; }
        [ForeignKey("Key_IdUsuario")]
        public ApplicationUser ApplicationUser { get; set; }
    }


}
