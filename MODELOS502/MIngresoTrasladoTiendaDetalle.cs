using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MIngresoTrasladoTiendaDetalle
    {
        private int inIngresoTrasladoTiendaDetalle;
        private int idTienda;
        private int idIngresoTrasladoTienda;
        private int idTrasladoDetalle;
        private int cantidadRecibida;

        private int idBodega;
        private int idProducto;
        private int idIngreso;
        private int idTraslado;
        private int idTiendaOrigen;
        private int idOperacionInventarioEnc;
        private int idBodegaOringe;
        public int IdExistenciaDetalle;
        public int InIngresoTrasladoTiendaDetalle
        {
            get
            {
                return inIngresoTrasladoTiendaDetalle;
            }

            set
            {
                inIngresoTrasladoTiendaDetalle = value;
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

        public int IdTrasladoDetalle
        {
            get
            {
                return idTrasladoDetalle;
            }

            set
            {
                idTrasladoDetalle = value;
            }
        }

        public int CantidadRecibida
        {
            get
            {
                return cantidadRecibida;
            }

            set
            {
                cantidadRecibida = value;
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

        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

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

        public int IdTraslado
        {
            get
            {
                return idTraslado;
            }

            set
            {
                idTraslado = value;
            }
        }

        public int IdTiendaOrigen
        {
            get
            {
                return idTiendaOrigen;
            }

            set
            {
                idTiendaOrigen = value;
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

        public int IdBodegaOringe
        {
            get
            {
                return idBodegaOringe;
            }

            set
            {
                idBodegaOringe = value;
            }
        }
    }
}
