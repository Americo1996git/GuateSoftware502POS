using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MCierreDetalle
    {
        private int idtienda;
        private int idcierre;

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
    }
}
