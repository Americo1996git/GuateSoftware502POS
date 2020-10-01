using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELOS502;
using ModelSoft502;
using System.Data;

namespace ControllerSoft502
{
    public class ControllerBusquarSereis
    {
        public static DataTable Mostrar(string serie,int @id_tienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_BuscarSeries";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = @id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@serie", Valor = serie, Tipo = DbType.String, Out = false });
            return objExcute.Consultar(objProc);

        }
    }
}
