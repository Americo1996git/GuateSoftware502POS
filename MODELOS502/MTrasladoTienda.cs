using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MTrasladoTienda
    {
        private int idtraslado;
        private int idtienda;
        private int idsubtraslado;
        private int iddocumento;
        private int idtiendaDestino;
        private int idUsuario;

        private DateTime fecha;
        private string observciones;
        private string codigo;
        private DateTime fechaIngrso;
        private int id_operacion_inventario;
        private string descripcion_documento;
        private int id_serie;
        private string serie;
        public static int idtrasladoSalida;//esta variable siver para mostrar el documetn oque sera impres odonde especifiva el detalle de lso productos a trasladar

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

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Observciones
        {
            get
            {
                return observciones;
            }

            set
            {
                observciones = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
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

        public DateTime FechaIngrso
        {
            get
            {
                return fechaIngrso;
            }

            set
            {
                fechaIngrso = value;
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

        public string Descripcion_documento
        {
            get
            {
                return descripcion_documento;
            }

            set
            {
                descripcion_documento = value;
            }
        }

        public int Id_serie
        {
            get
            {
                return id_serie;
            }

            set
            {
                id_serie = value;
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
    }
}
