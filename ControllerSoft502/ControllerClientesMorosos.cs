using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelSoft502;
using System.Data;

namespace ControllerSoft502
{
    public class ControllerClientesMorosos
    {
        public static DataTable MostrarFiadores(int id_tienda, int id_venta_enc)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_FiadoresPorEnvio";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_venta_enc", Valor = id_venta_enc, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static DataTable ObtenerNumeroDeCuota(int id_tienda, int id_promesa_pago_det)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_NumeroDeCuotaClientesMorosos";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_promesa_pago_det", Valor = id_promesa_pago_det, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static DataTable EnviosAsociadosAlClienteFiador(int id_tienda, int id_cliente)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_EnviosAsocidosAunClienteFiador";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = id_cliente, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }
    }
}
