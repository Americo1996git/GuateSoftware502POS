using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MSubOrdenDetalle
    {
        private int idSubOrdenDetalle;
        private int idTienda;
        private int idSuborden;
        private int idCapturaPedidoDetalle;
        private int cantidadAutorizada;
        private decimal precioCompra;
        private int idCapturaPedido;
        private int opcion;

        //estas variables es para acutlaizar el prodcuto
        private decimal precioa;
        private int idproducto;

        public int IdSubOrdenDetalle
        {
            get
            {
                return idSubOrdenDetalle;
            }

            set
            {
                idSubOrdenDetalle = value;
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

        public int IdSuborden
        {
            get
            {
                return idSuborden;
            }

            set
            {
                idSuborden = value;
            }
        }

        public int IdCapturaPedidoDetalle
        {
            get
            {
                return idCapturaPedidoDetalle;
            }

            set
            {
                idCapturaPedidoDetalle = value;
            }
        }

        public int CantidadAutorizada
        {
            get
            {
                return cantidadAutorizada;
            }

            set
            {
                cantidadAutorizada = value;
            }
        }

        public decimal PrecioCompra
        {
            get
            {
                return precioCompra;
            }

            set
            {
                precioCompra = value;
            }
        }

        public decimal Precioa
        {
            get
            {
                return precioa;
            }

            set
            {
                precioa = value;
            }
        }

        public int Idproducto
        {
            get
            {
                return idproducto;
            }

            set
            {
                idproducto = value;
            }
        }

        public int IdCapturaPedido
        {
            get
            {
                return idCapturaPedido;
            }

            set
            {
                idCapturaPedido = value;
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
    }
}
