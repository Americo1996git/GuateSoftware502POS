using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelSoft502;

namespace ControllerSoft502
{
    public class ControllerProductosEnBodega
    {
        public static DataTable MostrarProductosExistencia(int opcion, int id, int idtienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SP_MOSTRAR_EXISTENCIAS";
            objProc.Parametros.Add(new MParametro { Nombre = "@popcion", Valor = opcion, Tipo = DbType.Int64, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@pid", Valor = id, Tipo = DbType.Int64, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = idtienda, Tipo = DbType.Int64, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarProductosEnTransito()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ProductosEnTransito";
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarBodega(int idtienda)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_Bodegas";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static DataTable MostrarTiendas()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_Tienda";
            return objExcute.Consultar(objProc);

        }

      



    }
}
