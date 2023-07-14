using SistemaInventario.AccesoDatos.Data;
using SistemaInventario.AccesoDatos.Repositorio.IRepositorio;
using SistemaInventario.Modelos.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio
{
    public class OrdenDetalleRepositorio : Repositorio<OrdenDetalle>, IOrdenDetalleRepositorio
    {
        private readonly ApplicationDbContext _db;
        public OrdenDetalleRepositorio(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Actualizar(OrdenDetalle orden)
        {
            _db.Update(orden);
        }
    }
}
