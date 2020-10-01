using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelSoft502;

namespace ControllerSoft502
{
    public class ControllerMarca
    {
        public static string ActualizarMarca(int idmarca, string nombre, bool estado)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_Marca";

            objProc.Parametros.Add(new MParametro { Nombre = "@idmarca", Valor = idmarca, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@estado", Valor = estado, Tipo = DbType.Boolean, Out = false });        
            return objExcute.Upsert(objProc);

        }


        public static DataTable MostrarMarcas()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_MarcasActivas";
            return objExcute.Consultar(objProc);

        }


        public static string GuardarMarca(int idtienda,string nombre,bool estado)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_Marca";

            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@estado", Valor = estado, Tipo = DbType.Boolean, Out = false });
            return objExcute.Upsert(objProc);

        }
    }
}
