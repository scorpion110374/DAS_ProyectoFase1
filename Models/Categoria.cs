using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectoAvance1.Models
{
    public class Categoria
    {
        [Column,Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)"), MaxLength(50), Required, DisplayName("Categoría")]
        public string NombreCategoria { get; set; }
    }
}
