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
    public class ControllerIngresoTrasladoTienda
    {

        public static int Id_ingreso_enc;
        public static DataTable MostrarBodegaCarga(int idtienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_Bodegas";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static DataTable MostrarDocumento(int codigo,int id_tienda, int id_tipo_documento, int id_origen, int id_destino)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ReporteDeDocumentoGenerado";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_movimiento_enc", Valor = codigo, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_documento", Valor = id_tipo_documento, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_origine", Valor = id_origen, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_destino", Valor = id_destino, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static DataTable mostrarIngresoPorTraslado(int codigo, int idtienda)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_IngresoPorTraslado";
            objProc.Parametros.Add(new MParametro { Nombre = "@codigo", Valor = codigo, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda_origen", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }


        public static DataTable MostrarSereisDeProductosPorIngresos(int id_detalle_tabla, int opcion)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_SeriesPorProductoIngresado";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_detalle_tabla", Valor = id_detalle_tabla, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static string AcutuallizarSeries(int id_detalle_tabla, int opcion, string serie, int id_serie)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_ActualizarSeriesProductosPorIngresos";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_detalle_tabla", Valor = id_detalle_tabla, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@serie", Valor = serie, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_serie", Valor = id_serie, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);
        }




        public static string IngresarProductos(MIngresoTrasladoTienda ingreso, List<MIngresoTrasladoTiendaDetalle> detalleInsercion, List<MSerieProducto> detalleInsercionSeries)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPSave_IngresoTrasladoTienda";
                objProc.Parametros.Add(new MParametro { Nombre = "@id_ingreso_traslado_tienda", Valor = ingreso.IdIngresoTrasladoTienda, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_operacion_inventario", Valor = ingreso.IdOperacionInventarioEnc, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = ingreso.IdTienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idbodega", Valor = ingreso.IdBodega, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@iddocumento", Valor = ingreso.IdDocumento, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario", Valor = ingreso.IdUsuario, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@observaciones", Valor = ingreso.Observaciones, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@serie", Valor = ingreso.Serie, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_serie", Valor = ingreso.IdSerie, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@descripcion_de_documento", Valor = ingreso.DescripcionDeDocumento, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda_origen", Valor = ingreso.IdTiendaOrigen, Tipo = DbType.Int32, Out = false});
                objProc.Parametros.Add(new MParametro { Nombre = "@correlativo", Valor = ingreso.Correlativo, Tipo = DbType.Int32, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion.Count > 0)
                {
                    if (rpta.Equals("OK"))
                    {   
                        int idingreso = Convert.ToInt32(objExcute.ParametroDeSalida("@id_ingreso_traslado_tienda"));
                        int id_operacion_inventario = Convert.ToInt32(objExcute.ParametroDeSalida("@id_operacion_inventario"));
                        Id_ingreso_enc = idingreso;

                        foreach (MIngresoTrasladoTiendaDetalle item in detalleInsercion)
                        {

                            item.IdIngresoTrasladoTienda = idingreso;
                            item.IdOperacionInventarioEnc = id_operacion_inventario;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_IngresoTrasladoDetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_ingreso_traslado_tienda", Valor = item.IdIngresoTrasladoTienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_traslado_detalle", Valor = item.IdTrasladoDetalle, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad_recibida", Valor = item.CantidadRecibida, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idbodega", Valor = item.IdBodega, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.IdProducto, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idingreso", Valor = item.IdIngreso, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_traslado", Valor = item.IdTraslado, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda_origen", Valor = item.IdTiendaOrigen, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_operacion_inventario", Valor = item.IdOperacionInventarioEnc, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_bodega_origen", Valor = item.IdBodegaOringe, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_ingreso_detalle_traslado", Valor = item.InIngresoTrasladoTiendaDetalle, Tipo = DbType.Int32, Out = true });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detalle", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                            rpta = objExcute.UpsertTransaction(objProc1);


                            if (rpta.Equals("OK"))
                            {
                                int id_ingreso_detalle = Convert.ToInt32(objExcute.ParametroDeSalida("@id_ingreso_detalle_traslado"));

                                foreach (MSerieProducto itemSeries in detalleInsercionSeries)
                                {
                                    if (item.IdProducto == itemSeries.IdordenDeCompraDetalle)
                                    {
                                        itemSeries.IdMovimientoDet = id_ingreso_detalle;
                                        MProcedimiento objProc2 = new MProcedimiento();
                                        objProc2.NombreProcedimiento = "SPSave_AgregarSeriesPorTrasladosTiendas";
                                        objProc2.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = itemSeries.Idtienda, Tipo = DbType.Int32, Out = false });
                                        objProc2.Parametros.Add(new MParametro { Nombre = "@id_ingreso_traslado_detalle", Valor = itemSeries.IdMovimientoDet, Tipo = DbType.Int32, Out = false });
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

  
    }
}
