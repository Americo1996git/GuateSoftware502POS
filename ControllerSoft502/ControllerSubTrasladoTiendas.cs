using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ModelSoft502;
using MODELOS502;

namespace ControllerSoft502
{
    public class ControllerSubTrasladoTiendas
    {
        public static int IdSubtraslado;
        public static string GuardarSubTraslado(MSubTrasladoTienda subtraslado, List<MSubTrasladoTiendaDetalle> detalleInsercion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPSave_subtraslado";
                objProc.Parametros.Add(new MParametro { Nombre = "@id_subt_raslado_enc", Valor = subtraslado.Idsubtraslado, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = subtraslado.Idtienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda_destino", Valor = subtraslado.Idtiendadestino, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_bodega_destino", Valor = subtraslado.IdBodegaDestino, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario", Valor = subtraslado.IdUsuario, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_sub_traslado", Valor = subtraslado.IdTipoSubTraslado, Tipo = DbType.Int32, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idecabezado = Convert.ToInt32(objExcute.ParametroDeSalida("@id_subt_raslado_enc"));
                        IdSubtraslado = Convert.ToInt32(objExcute.ParametroDeSalida("@id_subt_raslado_enc"));

                        foreach (MSubTrasladoTiendaDetalle item in detalleInsercion)
                        {

                            item.Idsubtraslado = idecabezado;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_subtrasladodetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.Idtienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_sub_traslado", Valor = item.Idsubtraslado, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_bodega", Valor = item.Idbodega, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detalle", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidadtrasladar, Tipo = DbType.Int32, Out = false });
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


        public static string AgregarTiendaEnStandBy(int idsubtraslado,List<MSubTrasladoTiendaDetalle> DetalleInsercion,List<MSubTrasladoTiendaDetalle> detalleActualizacion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

            
                objExcute.IniciarTran();


                if (DetalleInsercion.Count > 0)
                {
                  

                    foreach (MSubTrasladoTiendaDetalle item in DetalleInsercion)
                    {

                        item.Idsubtraslado = idsubtraslado;
                        MProcedimiento objProc1 = new MProcedimiento();
                        objProc1.NombreProcedimiento = "SPSave_subtrasladodetalle";
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.Idtienda, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_sub_traslado", Valor = item.Idsubtraslado, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_bodega", Valor = item.Idbodega, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detalle", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidadtrasladar, Tipo = DbType.Int32, Out = false });
                        rpta = objExcute.UpsertTransaction(objProc1);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                    }
                }

                if (detalleActualizacion.Count > 0)
                {
                    foreach (MSubTrasladoTiendaDetalle item in detalleActualizacion)
                    {

                        MProcedimiento objProc1 = new MProcedimiento();
                        objProc1.NombreProcedimiento = "SPUpdate_CantidadTrasladarDetalleSubtraslado";
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.Idtienda, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_subtraslado", Valor = item.Idsubtraslado, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_subtraslado_detalle", Valor = item.IdSubtrasladoDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detalle", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidadtrasladar, Tipo = DbType.Int32, Out = false });
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



        public static string QuitarProductosDeTiendaEnStandBy(List<MSubTrasladoTiendaDetalle> detalleEliminacion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {


                objExcute.IniciarTran();


                if (detalleEliminacion.Count > 0)
                {


                    foreach (MSubTrasladoTiendaDetalle item in detalleEliminacion)
                    {
                        MProcedimiento objProc1 = new MProcedimiento();
                        objProc1.NombreProcedimiento = "SPUpdate_RegresarProductosAtienda";
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.Idtienda, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_subtraslado", Valor = item.Idsubtraslado, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_subtraslado_detalle", Valor = item.IdSubtrasladoDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detall1", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidadtrasladar, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@stock", Valor = item.Stock, Tipo = DbType.Int32, Out = false });
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


        public static string EliminarProductosDeTiendaEnStandBy(List<MSubTrasladoTiendaDetalle> detalleEliminacion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {


                objExcute.IniciarTran();


                if (detalleEliminacion.Count > 0)
                {


                    foreach (MSubTrasladoTiendaDetalle item in detalleEliminacion)
                    {
                        MProcedimiento objProc1 = new MProcedimiento();
                        objProc1.NombreProcedimiento = "SPDelete_EliminarProductosDeSubTraslados";
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.Idtienda, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_subtraslado", Valor = item.Idsubtraslado, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_subtraslado_detalle", Valor = item.IdSubtrasladoDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_existencia_detall1", Valor = item.IdExistenciaDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int32, Out = false });
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



        public static DataTable MostrarSubtrasladosNoGenerados(int idtienda)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_SubTraslados";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static DataTable MostrarSubtrasladoPorTiendaDestino(int idtienda,int idtienda_destino, int id_tipo_sub_traslado)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "spmostrar_subtrasladonoconfirmado";
            objProc.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda_destino", Valor = idtienda_destino, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_sub_traslado", Valor = id_tipo_sub_traslado, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarSubTrasladoDetalle(int idtienda, int id_tienda_destino,int tipo_de_destino)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_DetalleSubtrasaldo";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_destino", Valor = id_tienda_destino, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_sub_traslado", Valor = tipo_de_destino, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

      
      

    }
}
