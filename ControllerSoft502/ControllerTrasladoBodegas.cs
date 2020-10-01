using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelSoft502;
using System.Data;
using MODELOS502;

namespace ControllerSoft502
{
    public class ControllerTrasladoBodegas
    {
        public static int IdSubtraslado;
        public static int IdTraslado;
        public static string GuardarSubTraslado(MSubtrasladoBodega subtraslado, List<MSubTrasladoBodegaDetalle> detalleInsercion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "spsave_subtrasladobodega";
                objProc.Parametros.Add(new MParametro { Nombre = "@id_subtraslado_bodega", Valor = subtraslado.IdSubtrasladoBodega, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = subtraslado.IdTienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idbodegadestino", Valor = subtraslado.IdBodegaDestino, Tipo = DbType.Int64, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idecabezado = Convert.ToInt32(objExcute.ParametroDeSalida("@id_subtraslado_bodega"));
                        IdSubtraslado = Convert.ToInt32(objExcute.ParametroDeSalida("@id_subtraslado_bodega"));

                        foreach (MSubTrasladoBodegaDetalle item in detalleInsercion)
                        {

                            item.IdSubTrasladoBodega = idecabezado;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "spsave_subtrasladobodegadetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idsubtrasladobodega", Valor = item.IdSubTrasladoBodega, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detalle", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad_trasladar", Valor = item.CantidadTrasladar, Tipo = DbType.Int32, Out = false });
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



        public static string AgregarProductosEnStandBy(List<MSubTrasladoBodegaDetalle> DetalleInsercion, List<MSubTrasladoBodegaDetalle> detalleActualizacion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {


                objExcute.IniciarTran();


                if (DetalleInsercion.Count > 0)
                {


                    foreach (MSubTrasladoBodegaDetalle item in DetalleInsercion)
                    {

                        MProcedimiento objProc1 = new MProcedimiento();
                        objProc1.NombreProcedimiento = "spsave_subtrasladobodegadetalle";
                        objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@idsubtrasladobodega", Valor = item.IdSubTrasladoBodega, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detalle", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad_trasladar", Valor = item.CantidadTrasladar, Tipo = DbType.Int32, Out = false });
                        rpta = objExcute.UpsertTransaction(objProc1);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                    }
                }

                if (detalleActualizacion.Count > 0)
                {
                    foreach (MSubTrasladoBodegaDetalle item in detalleActualizacion)
                    {

                        MProcedimiento objProc1 = new MProcedimiento();
                        objProc1.NombreProcedimiento = "SPUpdate_CantidadTrasladarDetalleSubtrasladoBodega";
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_subtraslado", Valor = item.IdSubTrasladoBodega, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detalle", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.CantidadTrasladar, Tipo = DbType.Int32, Out = false });
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



        public static string GuardarTrasladoBodega(MTrasladoBodega traslado, List<MTrasladoBodegaDetalle> detalleInsercion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPSave_TrasladoBodega";
                objProc.Parametros.Add(new MParametro { Nombre = "@id_traslado_bodega", Valor = traslado.IdTrasladoBodega, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_operacion_enc", Valor = traslado.Id_operacion_inventario, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = traslado.IdTienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@iddocumento", Valor = traslado.IdDocumento, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario", Valor = traslado.IdUsuario, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@observaciones", Valor = traslado.Observaciones, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_subraslado_bodega", Valor = traslado.IdSubTrasladoBodega, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_serie", Valor = traslado.Id_serie, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@descripcion_de_documento", Valor = traslado.Descripcion_documento, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@serie", Valor = traslado.Serie, Tipo = DbType.String, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idecabezado = Convert.ToInt32(objExcute.ParametroDeSalida("@id_traslado_bodega"));
                        int id_operancion = Convert.ToInt32(objExcute.ParametroDeSalida("@id_operacion_enc"));
                        IdTraslado = Convert.ToInt32(objExcute.ParametroDeSalida("@id_traslado_bodega"));

                        foreach (MTrasladoBodegaDetalle item in detalleInsercion)
                        {

                            item.IdTrasladoBodega = idecabezado;
                            item.Id_operacion_inventario = id_operancion;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_TrasladoBodegaDetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idtrasladobodega", Valor = item.IdTrasladoBodega, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_subtraslado_bodega_detalle", Valor = item.IdSubTrasladoBodegaDetalle, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidad, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detalle", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.IdProducto, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_operacion_enc", Valor = item.Id_operacion_inventario, Tipo = DbType.Int32, Out = false });
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

        public static string QuitarProductosDeBodegaEnStandBy(List<MSubTrasladoBodegaDetalle> detalleEliminacion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {


                objExcute.IniciarTran();


                if (detalleEliminacion.Count > 0)
                {


                    foreach (MSubTrasladoBodegaDetalle item in detalleEliminacion)
                    {
                        MProcedimiento objProc1 = new MProcedimiento();
                        objProc1.NombreProcedimiento = "SPUpdate_RegresarProductosBodega";
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_subtraslado", Valor = item.IdSubTrasladoBodega, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_subtraslado_detalle", Valor = item.IdSubtrasladoBodegaDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detall1", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.CantidadTrasladar, Tipo = DbType.Int32, Out = false });
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

        public static string EliminarProductosDeBodegaEnStandBy(List<MSubTrasladoBodegaDetalle> detalleEliminacion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {


                objExcute.IniciarTran();


                if (detalleEliminacion.Count > 0)
                {


                    foreach (MSubTrasladoBodegaDetalle item in detalleEliminacion)
                    {
                        MProcedimiento objProc1 = new MProcedimiento();
                        objProc1.NombreProcedimiento = "SPDelete_EliminarProductosDeSubTraslados";
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_subtraslado", Valor = item.IdSubTrasladoBodega, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_subtraslado_detalle", Valor = item.IdSubtrasladoBodegaDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detall1", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Opcion, Tipo = DbType.Int32, Out = false });
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





        public static DataTable MostrarBodegaOrigen(int idtiendaa)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_BodegasParaTrasladoTiendasa";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtiendaa, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }


        public static DataTable MostrarSubTrasladoDetalleBodega(int idtienda, int id_bodega_destino)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_DetalleSubtrasaldoBodega";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_bodega_destino", Valor = id_bodega_destino, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarSubtrasladosNoGeneradosBodegas(int idtienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_SubTrasladoBodegas";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarSubtrasladosPorBodega(int idtienda,int id_bodega_destino)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_SubtrasladoPorBodega";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_bodega_destino", Valor = id_bodega_destino, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }


        public static DataTable MostrarBodegaDestino(int idtiendaa, int idbodegaOrigen)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "spmostrar_bodegaDestino";
            objProc.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = idtiendaa, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@pidbodega", Valor = idbodegaOrigen, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }
 

    }
}
