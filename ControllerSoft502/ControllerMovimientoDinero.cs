using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelSoft502;

namespace ControllerSoft502
{
    public class ControllerMovimientoDinero
    {



        public static string GrabarSalida(int id_salida_dinero,int id_tienda, int id_tipo_pago, int id_tipo_salida_dinero,int id_tipo_documento,int id_sereie, int id_usuario,string descripcion, string destino,string observaciones, decimal monto, string serie,int correlativo,string serie_factura,int correlativo_factura, int opcion)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_RealizarMovimientoDinero";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_salida_dinero", Valor = id_salida_dinero, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_pago", Valor = id_tipo_pago, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_salida_dinero", Valor = id_tipo_salida_dinero, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_documento", Valor = id_tipo_documento, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_serie", Valor = id_sereie, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario", Valor = id_usuario, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@destino", Valor = destino, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@observaciones", Valor = observaciones, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@monto", Valor = monto, Tipo = DbType.Decimal, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@serie", Valor = serie, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@correlativo", Valor = correlativo, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@serie_factura", Valor = serie_factura, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@correlativo_factura", Valor = correlativo_factura, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);

        }

        public static string GrabarEntrada(int id,int id_tienda,int id_usuario,int id_serie,decimal monto,string serie,int correlativo)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_EntradaDinero";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_recibo_anticipo", Valor = id, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario", Valor = id_usuario, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_serie", Valor = id_serie, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@monto", Valor = monto, Tipo = DbType.Decimal, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@serie", Valor = serie, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@correlativo", Valor = correlativo, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);

        }


        public static DataTable ObtenerTotalesEntradasSalidas(int idtienda,DateTime fecha)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ObtenerIngresoSalidasDinero";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@fecha", Valor = fecha, Tipo = DbType.Date, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static DataTable MostrarSalidasGastos(int idtienda, DateTime fecha_inicial, DateTime fecha_final,int id_tipo_salida_dinero,int id_usuario, int opcion)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ReporteDeSalidasDinero";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@fecha_inicial", Valor = fecha_inicial, Tipo = DbType.Date, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@fecha_final", Valor = fecha_final, Tipo = DbType.Date, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_salida_dinero", Valor = id_tipo_salida_dinero, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario", Valor = id_usuario, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

    }
}
