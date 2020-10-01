using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSoft502
{
    public class MProcedimiento
    {
        public string NombreProcedimiento;
        public string NombreTabla;
        public List<MParametro> Parametros = new List<MParametro>();
        public List<MParametro> ParametrosConsulta = new List<MParametro>();
    }
}
