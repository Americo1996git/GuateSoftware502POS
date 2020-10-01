using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelSoft502;

namespace ControllerSoft502
{
    public class ControllerTrasladoTiedas
    {
        public static DataTable MostrarProductosEnbodega(int idtienda, int idbodega,string texto)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_productosenbodegaParaSubTraslado";
            objProc.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@pidbodega", Valor = idbodega, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@texto", Valor = texto, Tipo = DbType.String, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarBodegaOrigen(int idtiendaa)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_BodegasParaTrasladoTiendasa";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtiendaa, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarTiendasDeDestino(int idtiend)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_TiendasDeDestionoParaTrasladoTiendas";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtiend, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }


    }
}
