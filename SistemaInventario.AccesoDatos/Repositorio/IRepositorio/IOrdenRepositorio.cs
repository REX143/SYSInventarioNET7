using SistemaInventario.Modelos.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IOrdenRepositorio : IRepositorio<Orden>
    {
        void Actualizar(Orden Orden);
        void ActualizarEstado(int id, string ordenEstado, string pagoEstado);
        void ActualizarPagoStripeId(int id, string sessionId, string transaccionId);
    }
}
