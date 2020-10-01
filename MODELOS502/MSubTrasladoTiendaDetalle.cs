using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MSubTrasladoTiendaDetalle
    {
        private int idtienda;
        private int idsubtraslado;
        private int idbodega;
        private int idproducto;
        private int cantidadtrasladar;
        private int idtiendaDestino;

        private int idExistenciaDetalle;
        private int idSubtrasladoDetalle;
        private int opcion;
        public int Stock { get; set; }
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

        public int Idsubtraslado
        {
            get
            {
                return idsubtraslado;
            }

            set
            {
                idsubtraslado = value;
            }
        }

        public int Idbodega
        {
            get
            {
                return idbodega;
            }

            set
            {
                idbodega = value;
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

        public int Cantidadtrasladar
        {
            get
            {
                return cantidadtrasladar;
            }

            set
            {
                cantidadtrasladar = value;
            }
        }

        public int IdtiendaDestino
        {
            get
            {
                return idtiendaDestino;
            }

            set
            {
                idtiendaDestino = value;
            }
        }

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

        public int IdSubtrasladoDetalle
        {
            get
            {
                return idSubtrasladoDetalle;
            }

            set
            {
                idSubtrasladoDetalle = value;
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
