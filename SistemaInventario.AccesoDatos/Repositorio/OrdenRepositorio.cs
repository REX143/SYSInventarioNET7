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
    public class OrdenRepositorio : Repositorio<Orden>, IOrdenRepositorio
    {
        private readonly ApplicationDbContext _db;
        public OrdenRepositorio(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Actualizar(Orden orden)
        {
            _db.Update(orden);
        }

        public void ActualizarEstado(int id, string ordenEstado, string pagoEstado)
        {
            var ordenDB = _db.Ordenes.FirstOrDefault(o => o.Id == id);
            if (ordenDB != null)
            {
                ordenDB!.EstadoOrden = ordenEstado;
                ordenDB!.EstadoPago = pagoEstado;
                _db.Update(ordenDB);
            }
           
        }

        public void ActualizarPagoStripeId(int id, string sessionId, string transaccionId)
        {
            var ordenDB = _db.Ordenes.FirstOrDefault(o => o.Id == id);
            if (ordenDB != null)
            {
                if (!String.IsNullOrEmpty(sessionId))
                {
                    ordenDB!.SessionId = sessionId;

                }
                
                if (!String.IsNullOrEmpty(transaccionId))
                {
                    ordenDB!.TransaccionId = transaccionId;
                    ordenDB.FechaPago = DateTime.Now;

                }

                _db.Update(ordenDB);
            }
        }
    }
}
