using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MHistorialPreciosCostos
    {
        public int IdTienda { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public int IdOrigenMontoPrecios { get; set; }
        public int IdGenOrdenCompraDetalle { get; set; }
        public int IdSubOrdenDetalle { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public int IdProducto { get; set; }
        public int IdSubOrden { get; set; }
    }
}
