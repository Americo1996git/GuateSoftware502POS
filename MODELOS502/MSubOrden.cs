using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MSubOrden
    {
        private int idSuborden;
        private int idTienda;
        private int idProveedor;
        private int idUsuariio;
        private int idCapturaPedido;

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

        public int IdProveedor
        {
            get
            {
                return idProveedor;
            }

            set
            {
                idProveedor = value;
            }
        }

        public int IdUsuariio
        {
            get
            {
                return idUsuariio;
            }

            set
            {
                idUsuariio = value;
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
    }
}
