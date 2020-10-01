using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelSoft502;
using MODELOS502;

namespace ControllerSoft502
{

    public class ControllerIngreso
    {
        public static string RespuestaExiste = "";


        public static int IdIngreso; 

     
      
        public static DataTable MostrarDetalleProductosParaIngresar(int numero, int idtienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "spmostrar_detalleOrdenCompraEI";
            objProc.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@codigo", Valor = numero, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static DataTable MostrarBodegaCarga(int idtienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_Bodegas";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static DataTable ObtenerCorrelativoDeDocumento(int id_documento)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ObtenerCorrelativoDocumento";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_documento", Valor = id_documento, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }


        //________________Esta funcion es para ingresar los productos al invetnario_______________-
        public static string IngresarProductos(MIngreso ingreso, List<MIngresoDetalle> detalleInsercion,List<MSerieProducto> detalleInsercionSeries)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPSave_IngresoEncabezado";
                objProc.Parametros.Add(new MParametro { Nombre = "@id_ingreso_enc", Valor = ingreso.IdIngreso, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_movimiento_enc", Valor = ingreso.IdMovimientoEnc, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = ingreso.IdTienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario", Valor = ingreso.IdUsuario, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_documento", Valor = ingreso.IdDocumento, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_serie", Valor = ingreso.IdSerie, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_bodega", Valor = ingreso.IdBodega, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@observaciones", Valor = ingreso.Observaciones, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = ingreso.DescripcionDeDocumento, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@origen_documento", Valor = ingreso.Origen, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@destino_documento", Valor = ingreso.Destino, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@factura_proveedor", Valor = ingreso.FacturaProveedor, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@serie_factura_proveedor", Valor = ingreso.SerieFactura, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@serie", Valor = ingreso.Serie, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@correlativo", Valor = ingreso.Correlativo, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_salida_enc", Valor = ingreso.IdSalidaEnc, Tipo = DbType.Int32, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idingreso = Convert.ToInt32(objExcute.ParametroDeSalida("@id_ingreso_enc"));
                        int id_movimiento_enc = Convert.ToInt32(objExcute.ParametroDeSalida("@id_movimiento_enc"));
                        IdIngreso = idingreso;
                        foreach (MIngresoDetalle item in detalleInsercion)
                        {

                            item.IdIngreso = idingreso;
                            item.IdMovimientoEnc = id_movimiento_enc;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_IngresoDetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda_origen", Valor = item.IdTiendaOrigen, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_bodega_origen", Valor = item.IdBodegaOrigen, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_ingreso_enc", Valor = item.IdIngreso, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_movimiento_enc", Valor = item.IdMovimientoEnc, Tipo = DbType.Int32, Out = false });
                            if (item.EsOrden)
                            {
                                objProc1.Parametros.Add(new MParametro { Nombre = "@id_gen_orden_compra_detalle", Valor = item.IdGenOrdenCompraDetalle, Tipo = DbType.Int32, Out = false });
                                objProc1.Parametros.Add(new MParametro { Nombre = "@id_salida_det", Valor = DBNull.Value, Tipo = DbType.Int32, Out = false });
                            }
                            if (!item.EsOrden)
                            {
                                objProc1.Parametros.Add(new MParametro { Nombre = "@id_gen_orden_compra_detalle", Valor = DBNull.Value, Tipo = DbType.Int32, Out = false });
                                objProc1.Parametros.Add(new MParametro { Nombre = "@id_salida_det", Valor = item.IdSalidaDet, Tipo = DbType.Int32, Out = false });
                            }
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_producto", Valor = item.IdProducto, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_documento_inventario", Valor = ingreso.IdDocumento, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidad, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@con_series", Valor = item.ConSeries, Tipo = DbType.Boolean, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_bodega", Valor = item.IdBodega, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@restante", Valor = item.Restante, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_ingreso_detalle", Valor = item.IdIngresoDetalle, Tipo = DbType.Int64, Out = true });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_movimiento_det", Valor = item.IdMoviminetoDet, Tipo = DbType.Int64, Out = true });


                            rpta = objExcute.UpsertTransaction(objProc1);

                            if (rpta.Equals("OK"))
                            {
                                int id_ingreso_detalle = Convert.ToInt32(objExcute.ParametroDeSalida("@id_ingreso_detalle"));
                                int id_movimiento_det = Convert.ToInt32(objExcute.ParametroDeSalida("@id_movimiento_det"));

                                foreach (MSerieProducto itemSeries in detalleInsercionSeries)
                                {
                                    if (item.IdProducto == itemSeries.IdordenDeCompraDetalle)
                                    {
                                        itemSeries.IdMovimientoDet = id_movimiento_det;
                                        MProcedimiento objProc2 = new MProcedimiento();
                                        objProc2.NombreProcedimiento = "SPSave_SerieProducto";
                                        objProc2.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = itemSeries.Idtienda, Tipo = DbType.Int32, Out = false });
                                        objProc2.Parametros.Add(new MParametro { Nombre = "@id_movimiento_det", Valor = itemSeries.IdMovimientoDet, Tipo = DbType.Int32, Out = false });
                                        objProc2.Parametros.Add(new MParametro { Nombre = "@numero", Valor = itemSeries.Numero, Tipo = DbType.Int32, Out = false });
                                        objProc2.Parametros.Add(new MParametro { Nombre = "@serie", Valor = itemSeries.Serie, Tipo = DbType.String, Out = false });
                                        rpta = objExcute.UpsertTransaction(objProc2);
                                        if (!rpta.Equals("OK"))
                                        {
                                            break;
                                        }
                                    }

                                }

                            }

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


        public static string TerminarProducto(List<MIngresoDetalle> detalleInsercion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction();

                if (detalleInsercion != null)
                {
                    if (rpta == "OK")
                    {


                        foreach (MIngresoDetalle item in detalleInsercion)
                        {

                            item.IdIngreso = 0;
                            item.IdOperacionInventarioEnc = 0;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPUpdate_FinalizarProductosDeOrdenCompra";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idingreso", Valor = item.IdIngreso, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idgenordencompradetalle", Valor = item.IdGenOrdenCompraDetalle, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidad, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idbodega", Valor = 0, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.IdProducto, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@restante", Valor = item.Restante, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_operacion_inventario", Valor = item.IdOperacionInventarioEnc, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_orden", Valor = item.IdOrden, Tipo = DbType.Int64, Out = false });
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


        //______________esta funcion solo para actualizar el transito local
        public static string AcutalizarTransitoLocalOC(List<MIngresoDetalle> detalleInsercion)
        {
            string rpta = "";
            MExecute objExcute = new MExecute();
            try
            {



                if (detalleInsercion != null)
                {


                    objExcute.IniciarTran();
                    foreach (MIngresoDetalle item in detalleInsercion)
                    {
                        MProcedimiento objProc1 = new MProcedimiento();
                        objProc1.NombreProcedimiento = "SPSave_ActualizarProductosEnTransitoOC";
                        objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidad, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@idbodega", Valor = item.IdBodega, Tipo = DbType.Int64, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.IdProducto, Tipo = DbType.Int64, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int64, Out = false });
                        rpta = objExcute.UpsertTransaction(objProc1);
                        if (!rpta.Equals("OK"))
                        {
                            break;
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



        public static string CambiarEstadoOrdenAParcial(int id_encabezado,int id_estado_orden_de_compra)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_CambirEstadoDeOrdenCompraParcial";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_encabezado", Valor = id_encabezado, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_estado_orden_de_compra", Valor = id_estado_orden_de_compra, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);

        }

    }
}
