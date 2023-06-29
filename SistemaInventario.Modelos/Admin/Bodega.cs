using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.Admin
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} es obligatorio.")]
        [MaxLength(60, ErrorMessage ="{0} no debe contener más de {1} carácteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "{0} no debe contener más de {1} carácteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage ="{0} es obligatorio.")]
        public bool Estado { get; set; }
    }
}
