using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELOS502;
using System.Data;
using ModelSoft502;

namespace ControllerSoft502
{
    public class ControllerAnulaciones
    {
        public static string AnularOperacion(MAnularOperacion encabezado, List<MAnularOperacionDetalle> detalle)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPUpdate_AnularDocumentos";
                objProc.Parametros.Add(new MParametro { Nombre = "@codigo", Valor = encabezado.Codito, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_encabezado", Valor = encabezado.IdEncabezado, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = encabezado.IdTienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_documento", Valor = encabezado.IdTipoDeDocumento, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = encabezado.Opcion, Tipo = DbType.Int64, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalle != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        foreach (MAnularOperacionDetalle item in detalle)
                        {
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPUpdate_AnularDocumentosDetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_encabezado", Valor = item.IdEncabezado, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_detalle", Valor = item.IdDetalle, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_producto", Valor = item.IdProducto, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_bodega", Valor = item.IdBodega, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidad, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_documento", Valor = item.IdDocumento, Tipo = DbType.Int32, Out = false });
                            rpta = objExcute.UpsertTransaction(objProc1);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }
                }

                if (rpta.Equals("OK"))
                {
                    objExcute.TranasctionCommit();

                }
                else
                {
                    objExcute.TranasctionRollback();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                objExcute.cerrarConexionTransaccion();
            }
            return rpta;
        }

        public static DataTable MostrarDocumentoOperado(int codigo, int id_tienda,int id_tienda_destino,int id_documento,int opcion)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_DocumetnosOperados";
            objProc.Parametros.Add(new MParametro { Nombre = "@codigo", Valor = codigo, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda_destino", Valor = id_tienda_destino, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_documento", Valor = id_documento, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

    }
}
