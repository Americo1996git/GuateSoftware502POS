using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MIngresoTrasladoBodegaDetalle
    {
        public int IdTienda { get; set; }
        public int IdIngresoTrasladoBodega { get; set; }
        public int IdTrasladoBodegaDetalle { get; set; }
        public int Cantidad { get; set; }
        public bool Activo { get; set; }
        public int IdBodega { get; set; }
        public int IdProducto { get; set; }
        public int IdIngreso { get; set; }
        public int IdTraslado { get; set; }
        private int IdTiendaOrigen { get; set; }
        public int IdOperacionInventarioEnc { get; set; }
        public int IdExistenciaDetalle { get; set; }

    }
}
