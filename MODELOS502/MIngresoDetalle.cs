using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MIngresoDetalle
    {
        private int idIngresoDetalle;
        private int idTienda;
        private int idIngreso;
        private int idGenOrdenCompraDetalle;
        private int cantidad;

        //esta variable es para insetar en la tabal existencias detlale, para consultar el stock
        private int idProducto;

        private int solicitado;
        private int restante;

        private int idBodega;
        private int opcion;
        private int idOperacionInventarioEnc;
        private int idOrden;
  
        public bool ConSeries { get; set; }
        public int IdMovimientoEnc { get; set; }
        public int IdSalidaDet { get; set; }
        public bool EsOrden { get; set; }
        public int IdMoviminetoDet { get; set; }
        public int IdTiendaOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }

        public int IdIngresoDetalle
        {
            get
            {
                return idIngresoDetalle;
            }

            set
            {
                idIngresoDetalle = value;
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

        public int IdGenOrdenCompraDetalle
        {
            get
            {
                return idGenOrdenCompraDetalle;
            }

            set
            {
                idGenOrdenCompraDetalle = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
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

        public int Solicitado
        {
            get
            {
                return solicitado;
            }

            set
            {
                solicitado = value;
            }
        }

        public int Restante
        {
            get
            {
                return restante;
            }

            set
            {
                restante = value;
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

        public int Opcion
        {
            get
            {
                return opcion;
            }

            set
            {
                opcion = value;
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

        public int IdOrden
        {
            get
            {
                return idOrden;
            }

            set
            {
                idOrden = value;
            }
        }
    }
}
