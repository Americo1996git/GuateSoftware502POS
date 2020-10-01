using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MTrasladoBodegaDetalle
    {
        private int idTrasladoBodegaDetalle;
        private int idTienda;
        private int idTrasladoBodega;
        private int idSubTrasladoBodegaDetalle;
        private int cantidad;
        private int idProducto;

        private int idExistenciaDetalle;
        private int id_operacion_inventario;

        public int IdTrasladoBodegaDetalle
        {
            get
            {
                return idTrasladoBodegaDetalle;
            }

            set
            {
                idTrasladoBodegaDetalle = value;
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

        public int IdSubTrasladoBodegaDetalle
        {
            get
            {
                return idSubTrasladoBodegaDetalle;
            }

            set
            {
                idSubTrasladoBodegaDetalle = value;
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

        public int IdTrasladoBodega
        {
            get
            {
                return idTrasladoBodega;
            }

            set
            {
                idTrasladoBodega = value;
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

        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        public int Id_operacion_inventario
        {
            get
            {
                return id_operacion_inventario;
            }

            set
            {
                id_operacion_inventario = value;
            }
        }
    }
}
