using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MSalidaDetalle
    {
        public int IdTienda { get; set; }
        public int IdSalidaEnc { get; set; }
        public int IdMovimientoEnc { get; set; }
        public int IdSubTrasladoDetalle { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int IdBodega { get; set; }
        public int IdExistenciaDetalle { get; set; }
        public int EsVenta { get; set; }
        public int IdMoviminetoDet { get; set; }
    }
}
