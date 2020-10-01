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
    public class ControllerIngresoTrasladoBodega
    {
        public static int Id_ingreso_enc;
        public static string IngresarProductos(MIngresoTrasladoBodega ingreso, List<MIngresoTrasladoBodegaDetalle> detalleInsercion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPSave_IngresoTrasladoBodegaEncabezado";
                objProc.Parametros.Add(new MParametro { Nombre = "@id_ingreso_traslado_bodega", Valor = ingreso.IdIngresoTrasladoBodega, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_operacion_inventario", Valor = ingreso.IdOperacionInventarioEnc, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = ingreso.IdTienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_bodega_destino", Valor = ingreso.IdBodegaDestino, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_documento", Valor = ingreso.IdDocumento, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario_creacion", Valor = ingreso.IdUsuarioCreacion, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@observaciones", Valor = ingreso.Observaciones, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@serie", Valor = ingreso.Serie, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_serie", Valor = ingreso.IdSerie, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@descripcion_de_documento", Valor = ingreso.DescripcionDeDocumento, Tipo = DbType.String, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion.Count > 0)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idingreso = Convert.ToInt32(objExcute.ParametroDeSalida("@id_ingreso_traslado_bodega"));
                        int id_operacion_inventario = Convert.ToInt32(objExcute.ParametroDeSalida("@id_operacion_inventario"));
                        Id_ingreso_enc = idingreso;

                        foreach (MIngresoTrasladoBodegaDetalle item in detalleInsercion)
                        {

                            item.IdIngresoTrasladoBodega = idingreso;
                            item.IdOperacionInventarioEnc = id_operacion_inventario;                                           
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_IngresoTrasladoBodegaDetalle";       
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_ingreso_traslado_bodega", Valor = item.IdIngresoTrasladoBodega, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_traslado_bodega_detalle", Valor = item.IdTrasladoBodegaDetalle, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidad, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idbodega", Valor = item.IdBodega, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.IdProducto, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idingreso", Valor = item.IdIngreso, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_traslado", Valor = item.IdTraslado, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_operacion_inventario", Valor = item.IdOperacionInventarioEnc, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detalle", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
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


        public static DataTable MostrarBodegaCarga(int idtienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_Bodegas";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }
     
        public static DataTable mostrarDetalle(int idtienda, int idtraslado)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_DetalleTrasldoBodega";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_traslado", Valor = idtraslado, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }



    }
}
