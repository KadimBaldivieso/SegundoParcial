using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcial.Models
{
    public class Naipe
    {
        [Key]
        public string NaipeId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]

        [Url]
        public string Imagen { get; set; }
        

    }
}
