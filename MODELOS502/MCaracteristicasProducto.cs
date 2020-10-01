using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS502
{
    public class MCaracteristicasProducto
    {
        private int idcaracteristica;
        private int idtienda;
        private int idproducto;
        private string titulo;
        private string descripcion;
        private int opcion;

        public int Idcaracteristica
        {
            get
            {
                return idcaracteristica;
            }

            set
            {
                idcaracteristica = value;
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

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
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
