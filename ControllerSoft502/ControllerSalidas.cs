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
    public class ControllerSalidas
    {
        public static int IdSalida = 0;
        public static int IdMovimientoEnc = 0;
        public static int Correlativo = 0;

        public static string Salidas(MSalidaEnc salida, List<MSalidaDetalle> detalleInsercion, List<MSerieProducto> detalleInsercionSeries)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "spsave_traslado";
                objProc.Parametros.Add(new MParametro { Nombre = "@id_salida_enc", Valor = salida.IdSalidaEnc, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_movimiento_enc", Valor = salida.IdMovimientoEnc, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = salida.IdTienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario", Valor = salida.IdUsuario, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_documento_inventario", Valor = salida.IdDocumentoDeInventrio, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_serie", Valor = salida.IdSerie, Tipo = DbType.Int32, Out = false });
                if (salida.TipoSalida == 1)
                {
                    objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda_destino", Valor = salida.IdDestino, Tipo = DbType.Int32, Out = false });
                    objProc.Parametros.Add(new MParametro { Nombre = "@id_bodega_destino", Valor = DBNull.Value, Tipo = DbType.Int32, Out = false });
                }
                if (salida.TipoSalida == 2)
                {
                    objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda_destino", Valor = DBNull.Value, Tipo = DbType.Int32, Out = false });
                    objProc.Parametros.Add(new MParametro { Nombre = "@id_bodega_destino", Valor = salida.IdBodegaDestino, Tipo = DbType.Int32, Out = false });
                }
                if (salida.TipoSalida == 3)//3 es una venta o una orden de compra
                {
                    objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda_destino", Valor = DBNull.Value, Tipo = DbType.Int32, Out = false });
                    objProc.Parametros.Add(new MParametro { Nombre = "@id_bodega_destino", Valor = DBNull.Value, Tipo = DbType.Int32, Out = false });
                }
                objProc.Parametros.Add(new MParametro { Nombre = "@observaciones", Valor = salida.Observaciones, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = salida.Descripcion, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@origen_documento", Valor = salida.Origen, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@destino_documento", Valor = salida.Destino, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@destino", Valor = salida.Destino, Tipo = DbType.String, Out = false });
                if (salida.SeraIngresado)
                {
                    objProc.Parametros.Add(new MParametro { Nombre = "@fecha_de_ingreso", Valor = salida.FechaDeIngreso, Tipo = DbType.DateTime, Out = false });
                }
                if (!salida.SeraIngresado)
                {
                    objProc.Parametros.Add(new MParametro { Nombre = "@fecha_de_ingreso", Valor = DBNull.Value, Tipo = DbType.DateTime, Out = false });
                }

                objProc.Parametros.Add(new MParametro { Nombre = "@serie", Valor = salida.Serie, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@sera_ingresado", Valor = salida.SeraIngresado, Tipo = DbType.Boolean, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@correlativo_out", Valor = salida.CorrelativoOut, Tipo = DbType.Int32, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_sub_traslado", Valor = salida.IdSubTraslado, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@numero_envio", Valor = salida.NumeroEnvio, Tipo = DbType.Int32, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idecabezado = Convert.ToInt32(objExcute.ParametroDeSalida("@id_salida_enc"));
                        Correlativo = Convert.ToInt32(objExcute.ParametroDeSalida("@correlativo_out"));
                        int id_operacion = Convert.ToInt32(objExcute.ParametroDeSalida("@id_movimiento_enc"));

                        IdSalida = idecabezado;
                        IdMovimientoEnc = id_operacion;
                       
                        foreach (MSalidaDetalle item in detalleInsercion)
                        {

                            item.IdSalidaEnc = idecabezado;
                            item.IdMovimientoEnc = id_operacion;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "spsave_trasladodetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_salida_enc", Valor = item.IdSalidaEnc, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_movimiento_enc", Valor = item.IdMovimientoEnc, Tipo = DbType.Int32, Out = false });
                            if (item.IdSubTrasladoDetalle == 0)
                            {
                                objProc1.Parametros.Add(new MParametro { Nombre = "@id_sub_traslado_detalle", Valor = DBNull.Value, Tipo = DbType.Int32, Out = false });
                            }
                            else
                            {
                                objProc1.Parametros.Add(new MParametro { Nombre = "@id_sub_traslado_detalle", Valor = item.IdSubTrasladoDetalle, Tipo = DbType.Int32, Out = false });
                            }
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_producto", Valor = item.IdProducto, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidad, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detalle", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_bodega", Valor = item.IdBodega, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@es_venta", Valor = item.EsVenta, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_movimiento_det", Valor = item.IdMoviminetoDet, Tipo = DbType.Int64, Out = true });
                            rpta = objExcute.UpsertTransaction(objProc1);

                            if (rpta.Equals("OK"))
                            {

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


        public static string DescontarStock(List<MDescontarStock> stockDetalle)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {


                objExcute.IniciarTran();


                if (stockDetalle != null)
                {


                    foreach (MDescontarStock item in stockDetalle)
                    {

                        MProcedimiento objProc1 = new MProcedimiento();
                        objProc1.NombreProcedimiento = "SPUpdate_DescontarStock";
                        objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.Idtienda, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.Idproducto, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@idbodega", Valor = item.Idbodega, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidad, Tipo = DbType.Int32, Out = false });

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

    }
}
