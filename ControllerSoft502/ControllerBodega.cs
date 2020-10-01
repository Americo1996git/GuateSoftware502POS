using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelSoft502;

namespace ControllerSoft502
{
    public class ControllerBodega
    {


        public static DataTable MostrarBodega(int idtienda)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_Bodegas";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }


        public static string ActualizarBodega(int idtienda, int idbodega, string nombre, string direccion)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_Bodegas";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idbodega", Valor = idbodega, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@direccion", Valor = direccion, Tipo = DbType.String, Out = false });

            return objExcute.Upsert(objProc);

        }

        public static string GuardarBodega(int idtienda,string nombre, string direccion)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_Bodega";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@direccion", Valor = direccion, Tipo = DbType.String, Out = false });
            return objExcute.Upsert(objProc);

        }

    }
}
