using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MIngreso
    {
        private int idIngreso;
        private int idOperacionEnc;
        private int idTienda;
        private int idUsuario;
        private int idDocumento;
        private int idBodega;
        private string facturaProveedor;
        private string serieFactura;
        private string observaciones;
        private string serie;
        //esta variable es para actualizar el estado de la orden de compra a ingresdo
        private int idOrdenCompra;
        private int idSerie;
        private string descripcionDeDocumento;
        public int Correlativo { get; set; }
        public int IdMovimientoEnc { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int IdSalidaEnc { get; set; }

        public int IdIngreso
        {
            get
            {
                return idIngreso;
            }

            set
            {
                idIngreso = value;
            }
        }

        public int IdTienda
        {
            get
            {
                return idTienda;
            }

            set
            {
                idTienda = value;
            }
        }

        public int IdDocumento
        {
            get
            {
                return idDocumento;
            }

            set
            {
                idDocumento = value;
            }
        }

        public int IdBodega
        {
            get
            {
                return idBodega;
            }

            set
            {
                idBodega = value;
            }
        }

        public string FacturaProveedor
        {
            get
            {
                return facturaProveedor;
            }

            set
            {
                facturaProveedor = value;
            }
        }

        public string SerieFactura
        {
            get
            {
                return serieFactura;
            }

            set
            {
                serieFactura = value;
            }
        }

        public int IdOrdenCompra
        {
            get
            {
                return idOrdenCompra;
            }

            set
            {
                idOrdenCompra = value;
            }
        }

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return observaciones;
            }

            set
            {
                observaciones = value;
            }
        }

        public string Serie
        {
            get
            {
                return serie;
            }

            set
            {
                serie = value;
            }
        }

        public int IdSerie
        {
            get
            {
                return idSerie;
            }

            set
            {
                idSerie = value;
            }
        }

        public string DescripcionDeDocumento
        {
            get
            {
                return descripcionDeDocumento;
            }

            set
            {
                descripcionDeDocumento = value;
            }
        }

        public int IdOperacionEnc
        {
            get
            {
                return idOperacionEnc;
            }

            set
            {
                idOperacionEnc = value;
            }
        }
    }
}
