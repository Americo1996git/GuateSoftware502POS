using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MIngresoTrasladoTienda
    {
        private int idIngresoTrasladoTienda;
        private int idTienda;
        private int idBodega;
        private int idDocumento;
        private int idUsuario;
        private string observaciones;
        private string serie;
        private int idSerie;
        private int idOperacionInventarioEnc;
        private string descripcionDeDocumento;
        public int IdTiendaOrigen { get; set; }
        public int Correlativo { get; set; }

        public int IdIngresoTrasladoTienda
        {
            get
            {
                return idIngresoTrasladoTienda;
            }

            set
            {
                idIngresoTrasladoTienda = value;
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

        public int IdOperacionInventarioEnc
        {
            get
            {
                return idOperacionInventarioEnc;
            }

            set
            {
                idOperacionInventarioEnc = value;
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
    }
}
