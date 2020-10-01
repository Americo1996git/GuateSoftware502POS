using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MSalidaEnc
    {
        public int IdSalidaEnc { get; set; }
        public int IdMovimientoEnc { get; set; }
        public int IdTienda { get; set; }
        public int IdUsuario { get; set; }
        public int IdDocumentoDeInventrio { get; set; }
        public int IdSerie { get; set; }
        public int IdDestino { get; set; }
        public int IdBodegaDestino { get; set; }
        public string Observaciones { get; set; }
        public string Descripcion { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public string Serie { get; set; }
        public bool SeraIngresado { get; set; }
        public int CorrelativoOut { get; set; }
        public int TipoSalida { get; set; }
        public int IdBodeg { get; set; }
        public int IdSubTraslado { get; set; }
        public int NumeroEnvio { get; set; }
        public bool Ingresado { get; set; }
    }
}
