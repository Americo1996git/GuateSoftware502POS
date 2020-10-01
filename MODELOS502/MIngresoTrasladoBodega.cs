using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MIngresoTrasladoBodega
    {
        public int IdIngresoTrasladoBodega { get; set; }
        public int IdTienda { get; set; }
        public int IdBodegaDestino { get; set; }
        public int IdDocumento { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public string Observaciones { get; set; }
        public string Serie { get; set; }
        public int Correltivo { get; set; }
        public int IdTraslado { get; set; }
        public int IdSerie { get; set; }
        public int IdOperacionInventarioEnc { get; set; }
        public string DescripcionDeDocumento { get; set; }

    }
}
