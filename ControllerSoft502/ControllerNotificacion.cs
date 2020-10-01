using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelSoft502;

namespace ControllerSoft502
{
    public class ControllerNotificacion
    {
        public static string Agregar(int id_tienda, int id_documento, string descripcion, string serie, int correlativo, bool operado)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_Notificacion";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_documento", Valor = id_documento, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@serie", Valor = serie, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@correlativo", Valor = correlativo, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@operado", Valor = operado, Tipo = DbType.Boolean, Out = false });
            return objExcute.Upsert(objProc);

        }

        public static DataTable Mostrar(int id_tienda, int opcion)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_Notificaciones";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static string Actualizar(int id_tienda,int correlativo)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_ActualizarNotificaciones";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@correlativo", Valor = correlativo, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);

        }
    }
}
