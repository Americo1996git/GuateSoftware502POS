using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSoft502
{
    public class MParametro
    {
        /// <summary>
        /// Nombre del parametro.
        /// </summary>
        public string Nombre;

        /// <summary>
        /// Valor del parametro.
        /// </summary>
        public Object Valor;

        /// <summary>
        /// Tipo de dato del parametro.
        /// </summary>
        public System.Data.DbType Tipo;

        /// <summary>
        /// True si es un parametro de salida del procedimiento almacenado.
        /// </summary>
        public bool Out;
    }
}
