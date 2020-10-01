using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MCierre
    {
        private int idcierre;
        private int idtienda;
        private DateTime fecha;
        private string anio_cierre;
        private string mes_cierre;
        private string abierto;
        private int mes;
    

        public int Idcierre
        {
            get
            {
                return idcierre;
            }

            set
            {
                idcierre = value;
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

        public string Anio_cierre
        {
            get
            {
                return anio_cierre;
            }

            set
            {
                anio_cierre = value;
            }
        }

        public string Mes_cierre
        {
            get
            {
                return mes_cierre;
            }

            set
            {
                mes_cierre = value;
            }
        }

        public string Abierto
        {
            get
            {
                return abierto;
            }

            set
            {
                abierto = value;
            }
        }

        public int Mes
        {
            get
            {
                return mes;
            }

            set
            {
                mes = value;
            }
        }

    }
}
