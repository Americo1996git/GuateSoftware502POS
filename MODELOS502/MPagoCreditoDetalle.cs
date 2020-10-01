using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MPagoCreditoDetalle
    {
        public int IdTienda { get; set; }
        public int IdPagoCreditoEnc { get; set; }
        public int IdPromesaPagoDet { get; set; }
        public int IdUsuario { get; set; }
        public decimal MontoPagar { get; set; }
        public decimal MontoInteres { get; set; }
        public decimal MontoCuota { get; set; }
        public int Opcion { get; set; }
    }
}
