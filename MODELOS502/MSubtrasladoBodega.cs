using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MSubtrasladoBodega
    {
        private int idSubtrasladoBodega;
        private int idTienda;
        private int idBodegaDestino;

        public int IdSubtrasladoBodega
        {
            get
            {
                return idSubtrasladoBodega;
            }

            set
            {
                idSubtrasladoBodega = value;
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

        public int IdBodegaDestino
        {
            get
            {
                return idBodegaDestino;
            }

            set
            {
                idBodegaDestino = value;
            }
        }
    }
}
