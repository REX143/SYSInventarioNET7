using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.Admin
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} es un campo obligatorio.")]
        [MaxLength(60, ErrorMessage ="{0} debe contener un máximos de {1} caracteres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "{0} es un campo obligatorio.")]
        [MaxLength(100, ErrorMessage = "{0} debe contener un máximos de {1} caracteres.")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "{0} es un campo obligatorio.")]
        public bool Estado { get; set; }
    }
}
