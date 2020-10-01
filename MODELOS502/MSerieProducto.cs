using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MODELOS502
{
    public class MSerieProducto
    {
        private int idtienda;
        private int idordenDeCompraDetalle;
        private int numero;
        private string serie;
        public int IdMovimientoDet { get; set; }


        public int IdordenDeCompraDetalle
        {
            get
            {
                return idordenDeCompraDetalle;
            }

            set
            {
                idordenDeCompraDetalle = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
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

        public int Idtienda
        {
            get
            {
                return idtienda;
            }

            set
            {
                idtienda = value;
            }
        }
    }
}
