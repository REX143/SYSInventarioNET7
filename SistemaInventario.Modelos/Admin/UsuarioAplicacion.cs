using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.Admin
{
    public class UsuarioAplicacion: IdentityUser
    {
        [Required(ErrorMessage ="{0} es obligatorio el registro.")]
        [MaxLength(90)]
        public string Nombres { get; set; }
        
        [Required(ErrorMessage ="{0} es obligatorio el registro.")]
        [MaxLength(90)]
        public string Apellidos { get; set; }
        
        [Required(ErrorMessage ="{0} es obligatorio el registro.")]
        [MaxLength(200)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio el registro.")]
        [MaxLength(60)]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio el registro.")]
        [MaxLength(60)]
        public string Pais { get; set; }

        [NotMapped] // No se genera en la BD
        public string Role { get; set; }
    }
}
