using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MSubTrasladoTienda
    {
        private int idsubtraslado;
        private int idtienda;
        private int idtiendadestino;
        private string confirmado;
        private int idUsuario;
        public int IdBodegaDestino { get; set; }
        public int IdTipoSubTraslado { get; set; }

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

        public int Idtiendadestino
        {
            get
            {
                return idtiendadestino;
            }

            set
            {
                idtiendadestino = value;
            }
        }



        public string Confirmado
        {
            get
            {
                return confirmado;
            }

            set
            {
                confirmado = value;
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
    }
}
