using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.Admin
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} del producto es requerido.")]
        [MaxLength(60)]
        public string NumeroSerie { get; set; }
        
        [Required(ErrorMessage = "{0} del producto es requerido.")]
        [MaxLength(100)]
        public string Descripcion { get; set; }
        
        [Required(ErrorMessage = "{0} del producto es requerido.")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "{0} del producto es requerido.")]
        public double Costo { get; set; }

        public string ImagenURL { get; set; }


        [Required(ErrorMessage = "{0} del producto es requerido.")]
        public bool Estado { get; set; }

        // Relaciones a otras entidades
        [Required(ErrorMessage = "{0} del producto es requerido.")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }


        [Required(ErrorMessage = "{0} del producto es requerido.")]
        public int MarcaId { get; set; }

        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }

        public int? PadreId { get; set; }
        public virtual Producto Padre { get; set; }
    }
}
