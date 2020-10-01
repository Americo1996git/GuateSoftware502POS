using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MTrasladoTiendaDetalle
    {
        private int idtienda;
        private int idtraslado;
        private int idproducto;
        private int cantidadtrasladar;
        private int idbodega;
        private DateTime fechaIngreso;
        private int idtiendadestino;
        private int iddocumento;
        private DateTime fechaCreacion;

        private int idTrasladoDetalle;
        private int idSubTrasladoDetalle;
        private int idExistenciaDetalle;
        private int id_operacion_inventario;

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

        public int Idtraslado
        {
            get
            {
                return idtraslado;
            }

            set
            {
                idtraslado = value;
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

        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }

            set
            {
                fechaIngreso = value;
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

        public int Iddocumento
        {
            get
            {
                return iddocumento;
            }

            set
            {
                iddocumento = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }

            set
            {
                fechaCreacion = value;
            }
        }

        public int IdTrasladoDetalle
        {
            get
            {
                return idTrasladoDetalle;
            }

            set
            {
                idTrasladoDetalle = value;
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

        public int IdSubTrasladoDetalle
        {
            get
            {
                return idSubTrasladoDetalle;
            }

            set
            {
                idSubTrasladoDetalle = value;
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
