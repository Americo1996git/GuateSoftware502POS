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
    public class ControllerCapturaPedido
    {
        public static int idcapturapedido;
        public static string GuardarCapturaPedidoRequisicion(MRequisicion requisicion, List<MRequisicionDetalle> detalle)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPSave_CapturaPedido";
                objProc.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = requisicion.Idcapturapedido, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = requisicion.Idtienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idusuario", Valor = requisicion.Idusuario, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@Observaciones", Valor = requisicion.Observacion, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_estado_requisicion", Valor = requisicion.IdEstadoRequisicion, Tipo = DbType.Int32, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalle != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idencabezadoTabla = Convert.ToInt32(objExcute.ParametroDeSalida("@idcapturapedido"));
                        idcapturapedido = idencabezadoTabla;

                        foreach (MRequisicionDetalle item in detalle)
                        {

                            item.Idcapturapedido = idencabezadoTabla;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_CapturaPedidoDetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_captura_pedido_detalle", Valor = item.Idcapturapedidodetalle, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.Idtienda, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = item.Idcapturapedido, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.Idproducto, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad_requerida", Valor = item.CantidadRequerida, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int32, Out = false });
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

        //___________________________SE PUEDE ACTUALIZAR LA REQUISION SI ESTA PENDITNE DE LO CONTRARIO NO SE PODRA EDITAR
        public static string ActualizarCapturaPedidoRequisicion(MRequisicion requisicion, List<MRequisicionDetalle> detalleEliminacion, List<MRequisicionDetalle> detalleInsercion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPUpdate_CapturaPedido";
                objProc.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = requisicion.Idcapturapedido, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = requisicion.Idtienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@Observaciones", Valor = requisicion.Observacion, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_estado_requisicion", Valor = requisicion.IdEstadoRequisicion, Tipo = DbType.Int32, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleEliminacion != null && detalleInsercion !=null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idencabezadoTabla = requisicion.Idcapturapedido;

                        foreach (MRequisicionDetalle item in detalleEliminacion)
                        {

                            item.Idcapturapedido = idencabezadoTabla;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_CapturaPedidoDetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_captura_pedido_detalle", Valor = item.Idcapturapedidodetalle, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.Idtienda, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = item.Idcapturapedido, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.Idproducto, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad_requerida", Valor = item.CantidadRequerida, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int32, Out = false });
                            rpta = objExcute.UpsertTransaction(objProc1);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }

                        foreach (MRequisicionDetalle item in detalleInsercion)
                        {

                            item.Idcapturapedido = idencabezadoTabla;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_CapturaPedidoDetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_captura_pedido_detalle", Valor = item.Idcapturapedidodetalle, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.Idtienda, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = item.Idcapturapedido, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.Idproducto, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad_requerida", Valor = item.CantidadRequerida, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int32, Out = false });
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


        //__________________________ESTA FUNCION ES PARA MOSTRAR PRODUCTOS SOLO PARA CREAR REQUEISICION
        public static DataTable MostrarProductos(string texto)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ProductosParaRequisicion";
            objProc.Parametros.Add(new MParametro { Nombre = "@texto", Valor = texto, Tipo = DbType.String, Out = false });
            return objExcute.Consultar(objProc);

        }

        //__________________________ESTA FUNCION ES PARA MOSTRAR LA REQUISICION Y SU DETALLE PARA PODER EDITARLO
        public static DataTable MostrarRequisicionDetalle(int idtienda, int idcapturapedido)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_CapturaPedidoDetalleParaEditar";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = idcapturapedido, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        //__________________________ESTA FUNCION ES PARA MOSTRAR LOS PRODUCTOS PERO PRO FILTRO
        public static DataTable MostrarProductosPorFiltro(string texto)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ProductosParaRequisicionPorFiltro";
            objProc.Parametros.Add(new MParametro { Nombre = "@texto", Valor = texto, Tipo = DbType.String, Out = false });
            return objExcute.Consultar(objProc);

        }


        //__________________________ESTA FUNCION ES PARA MOSTRAR PRODUCTOS SOLO PARA CREAR REQUEISICION
        public static string AnularRequsicion(int idtienda, int idrequisicion)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPAnular_CapturaPedido";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = idrequisicion, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);

        }




    }
}
