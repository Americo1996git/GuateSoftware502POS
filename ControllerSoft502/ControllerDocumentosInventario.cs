using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelSoft502;
namespace ControllerSoft502
{
    public class ControllerDocumentosInventario
    {
        public static DataTable MostrarDocumentos()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_DocumentosDeInventario";
            return objExcute.Consultar(objProc);
        }
        public static DataTable MostrarDocumentosParaReportes()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_DocumentosDeInventarioParaReportes";
            return objExcute.Consultar(objProc);
        }

        public static DataTable MostrarTipoDeDocumentosParaReimprimrTraslados()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_DocumentosTipoDeDocumentoParaReimprimirTraslados";
            return objExcute.Consultar(objProc);
        }
        public static string GuardarDocumento(int idtienda, string nombre, string operacion, string descripcion)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_DocumentosDeInventario";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@operacion", Valor = operacion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            return objExcute.Upsert(objProc);
        }

        public static string ActualizarDocumento(int iddocumento, string nombre, string operacion, string descripcion)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_DocumentosDeInventario";

            objProc.Parametros.Add(new MParametro { Nombre = "@iddocumento", Valor = iddocumento, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@operacion", Valor = operacion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            return objExcute.Upsert(objProc);

        }


        public static DataTable MostrarDocumentoOperado(int codigo, int id_tienda, int id_tipo_documento, int id_origen, int id_destino,bool ingresado, int opcion)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ReporteDeDocumentoGenerado";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_movimiento_enc", Valor = codigo, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_documento", Valor = id_tipo_documento, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_origine", Valor = id_origen, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_destino", Valor = id_destino, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@ingresado", Valor = ingresado, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

    }
}
