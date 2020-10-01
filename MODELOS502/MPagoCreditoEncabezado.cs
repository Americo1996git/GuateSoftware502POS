using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MPagoCreditoEncabezado
    {
        public int IdPagoCreditoEnc { get; set; }
        public int IdTienda { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoPagoCredito { get; set; }
        public int IdSerie { get; set; }
        public string Serie { get; set; }
        public int Correlativo { get; set; }
        public string Banco { get; set; }
        public string NumeroDeposito { get; set; }
        public DateTime FechaDepositoBanco { get; set; }
        public int IdOrigenAnticipo { get; set; }
        public string DetalleRecibo { get; set; }
        public decimal MontoRecibido { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public int Opcion { get; set; }
        public int IdEstadoRecibo { get; set; }
    }
}
