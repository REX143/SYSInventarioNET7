﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.Admin
{
    public class Compania
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} es requerido.")]
        [MaxLength(80)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "{0} es requerido.")]
        [MaxLength(200)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "{0} es requerido.")]
        [MaxLength(60)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "{0} es requerido.")]
        [MaxLength(80)]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "{0} es requerido.")]
        [MaxLength(100)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "{0} es requerido.")]
        [MaxLength(40)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La bodega de venta es requerida")]
        public int BodegaVentaId { get; set; }

        [ForeignKey("BodegaVentaId")]
        public Bodega Bodega { get; set; }

        public string CreadoPorId { get; set; }

        [ForeignKey("CreadoPorId")]
        public UsuarioAplicacion CreadoPor { get; set; }


        public string ActualizadoPorId { get; set; }

        [ForeignKey("ActualizadoPorId")]
        public UsuarioAplicacion ActualizadoPor { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
