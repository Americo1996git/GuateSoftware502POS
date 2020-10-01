using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MOrdenCompraDetalle
    {
        private int idTienda;
        private int idGenorDenCompraEncabezado;
        private int idSubOrdenDetalle;

        //estas variables es para el transito local, si exsite el transito o no
        private int idproducto;
        private int cantidad;


        //estas varialbes es para actulaizar los proecios y costos al momento de verificar la orden de compra

        private decimal nuevoCosto;
        private decimal nuevoPrecio;
        private int recibidos;

        private int idGenorDenCompraDetalle;
        private bool verificado;


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

        public decimal NuevoCosto
        {
            get
            {
                return nuevoCosto;
            }

            set
            {
                nuevoCosto = value;
            }
        }

        public decimal NuevoPrecio
        {
            get
            {
                return nuevoPrecio;
            }

            set
            {
                nuevoPrecio = value;
            }
        }

        public int Recibidos
        {
            get
            {
                return recibidos;
            }

            set
            {
                recibidos = value;
            }
        }

        public int IdGenorDenCompraDetalle
        {
            get
            {
                return idGenorDenCompraDetalle;
            }

            set
            {
                idGenorDenCompraDetalle = value;
            }
        }

        public bool Verificado
        {
            get
            {
                return verificado;
            }
            set
            {
                verificado = value;
            }
        }
    }
}
