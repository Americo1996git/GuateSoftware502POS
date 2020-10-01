using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelSoft502;

namespace ControllerSoft502
{
    public class ControllerGastos
    {
        public static string ActualizarMarca(int id, string nombre, string codigo, bool activo, int opcion)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPCrud_Gastos";
            objProc.Parametros.Add(new MParametro { Nombre = "@id", Valor = id, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@codigo", Valor = codigo, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@activo", Valor = activo, Tipo = DbType.Boolean, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);

        }


        public static DataTable MostrarGastos()
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreTabla = "Gasto";
            return objExcute.Mostrar(objProc);
        }

    }
}
