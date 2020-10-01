using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MSubTrasladoBodegaDetalle
    {
        private int idSubtrasladoBodegaDetalle;
        private int idTienda;
        private int idSubTrasladoBodega;
        private int idExistenciaDetalle;
        private int cantidadTrasladar;
        private int opcion;

        public int IdSubtrasladoBodegaDetalle
        {
            get
            {
                return idSubtrasladoBodegaDetalle;
            }

            set
            {
                idSubtrasladoBodegaDetalle = value;
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

        public int CantidadTrasladar
        {
            get
            {
                return cantidadTrasladar;
            }

            set
            {
                cantidadTrasladar = value;
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
