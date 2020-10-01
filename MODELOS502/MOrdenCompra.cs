using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MOrdenCompra
    {
        private int idGenorDenCompraEncabezado;
        private int idTienda;
        private int idUsuario;
        private string serie;
        private string destino;
        private string observaciones;
        private string quienRecibe;
        private DateTime fechaIngresoBodega;

        private int idsuborden;
        private int id_estado_orden_de_compra;

        public int IdGenorDenCompraEncabezado
        {
            get
            {
                return idGenorDenCompraEncabezado;
            }

            set
            {
                idGenorDenCompraEncabezado = value;
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

        public string Destino
        {
            get
            {
                return destino;
            }

            set
            {
                destino = value;
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

        public string QuienRecibe
        {
            get
            {
                return quienRecibe;
            }

            set
            {
                quienRecibe = value;
            }
        }

        public DateTime FechaIngresoBodega
        {
            get
            {
                return fechaIngresoBodega;
            }

            set
            {
                fechaIngresoBodega = value;
            }
        }

        public int Idsuborden
        {
            get
            {
                return idsuborden;
            }

            set
            {
                idsuborden = value;
            }
        }

        public int Id_estado_orden_de_compra
        {
            get
            {
                return id_estado_orden_de_compra;
            }

            set
            {
                id_estado_orden_de_compra = value;
            }
        }
    }
}
