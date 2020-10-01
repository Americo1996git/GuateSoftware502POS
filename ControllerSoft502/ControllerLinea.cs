using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelSoft502;
using System.Data;

namespace ControllerSoft502
{
    public class ControllerLinea
    {
        public static string ActualizarLinea(int idlinea,string nombre, string descripcion, decimal descuento)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_Linea";

            objProc.Parametros.Add(new MParametro { Nombre = "@idlinea", Valor = idlinea, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descuento", Valor = descuento, Tipo = DbType.Decimal, Out = false });
            return objExcute.Upsert(objProc);

        }

        public static string GuardarLinea(int idtienda, string nombre, string descripcion, decimal descuento)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_Linea";

            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descuento", Valor = descuento, Tipo = DbType.Decimal, Out = false });
            return objExcute.Upsert(objProc);

        }


        public static DataTable MostrarLineas()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_linea";
            return objExcute.Consultar(objProc);

        }
    }
}
