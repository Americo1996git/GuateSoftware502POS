using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MVentaDetalle
    {
        private int idExistenciaDetalle;
        private int cantidad;
        private decimal precioUnitario;
        private decimal subTotal;
        private decimal iva;
        private decimal total;
        private int idVentaEncabezado;
        private int idUsuario;
        private string noSerieArticulos;
        private int idTienda;

        public int IdExistenciaDetalle
        {
            get
            {
                return idExistenciaDetalle;
            }

            set
            {
                idExistenciaDetalle = value;
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

        public decimal PrecioUnitario
        {
            get
            {
                return precioUnitario;
            }

            set
            {
                precioUnitario = value;
            }
        }

        public decimal SubTotal
        {
            get
            {
                return subTotal;
            }

            set
            {
                subTotal = value;
            }
        }

        public decimal Iva
        {
            get
            {
                return iva;
            }

            set
            {
                iva = value;
            }
        }

        public decimal Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public int IdVentaEncabezado
        {
            get
            {
                return idVentaEncabezado;
            }

            set
            {
                idVentaEncabezado = value;
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

        public string NoSerieArticulos
        {
            get
            {
                return noSerieArticulos;
            }

            set
            {
                noSerieArticulos = value;
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
    }
}
