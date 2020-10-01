using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MTrasladoBodega
    {
        private int idTrasladoBodega;
        private int idTienda;
        private int idDocumento;
        private int idUsuario;
        private string observaciones;

        private int idSubTrasladoBodega;
        private int id_operacion_inventario;
        private int id_serie;
        private string serie;
        private string descripcion_documento;

        public int IdTrasladoBodega
        {
            get
            {
                return idTrasladoBodega;
            }

            set
            {
                idTrasladoBodega = value;
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

        public int IdSubTrasladoBodega
        {
            get
            {
                return idSubTrasladoBodega;
            }

            set
            {
                idSubTrasladoBodega = value;
            }
        }

        public int Id_operacion_inventario
        {
            get
            {
                return id_operacion_inventario;
            }

            set
            {
                id_operacion_inventario = value;
            }
        }

        public int Id_serie
        {
            get
            {
                return id_serie;
            }

            set
            {
                id_serie = value;
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

        public string Descripcion_documento
        {
            get
            {
                return descripcion_documento;
            }

            set
            {
                descripcion_documento = value;
            }
        }
    }
}
