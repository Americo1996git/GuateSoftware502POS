using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MRequisicionDetalle
    {
        private int idcapturapedidodetalle;
        private int idtienda;
        private int idcapturapedido;
        private int idproducto;
        private int cantidadRequerida;
        private bool eliminado;
        private int opcion;
        private string origen;

        public int Idcapturapedidodetalle
        {
            get
            {
                return idcapturapedidodetalle;
            }

            set
            {
                idcapturapedidodetalle = value;
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

        public int Idcapturapedido
        {
            get
            {
                return idcapturapedido;
            }

            set
            {
                idcapturapedido = value;
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

        public int CantidadRequerida
        {
            get
            {
                return cantidadRequerida;
            }

            set
            {
                cantidadRequerida = value;
            }
        }

        public bool Eliminado
        {
            get
            {
                return eliminado;
            }

            set
            {
                eliminado = value;
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

        public string Origen
        {
            get
            {
                return origen;
            }

            set
            {
                origen = value;
            }
        }
    }
}
