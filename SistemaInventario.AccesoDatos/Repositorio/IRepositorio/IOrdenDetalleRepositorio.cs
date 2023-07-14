using SistemaInventario.Modelos.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IOrdenDetalleRepositorio : IRepositorio<OrdenDetalle>
    {
        void Actualizar(OrdenDetalle OrdenDetalle);
    }
}
