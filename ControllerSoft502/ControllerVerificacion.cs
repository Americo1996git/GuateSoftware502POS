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
    public class ControllerVerificacion
    {


        public static DataTable MostrarDetalleOrdenCompra(int idorden, int idtienda)
        {

            try
            {

                MExecute objExcute = new MExecute();
                MProcedimiento objProc = new MProcedimiento();
                objProc.NombreProcedimiento = "SPMostrar_DetalleOrdenDeCompraParaVerificacionDePrecios";
                objProc.Parametros.Add(new MParametro { Nombre = "@idgenordencompraencabezado", Valor = idorden, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
                return objExcute.Consultar(objProc);
            }
            catch (Exception)
            {

                throw;  
            }
        }

        //int idtienda,int idorden, int idetalle, decimal nuevocosto, decimal nuevoprecio, int idproducto
        public static string ActulizarDetalleOCPreciosCostos(MOrdenCompra orden, List<MOrdenCompraDetalle> detalleInsercion, List<MHistorialPreciosCostos> HistorialDetalleInsert)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPUpdate_OrdenDeCompraEstadoRecibido";
                objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = orden.IdTienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_orden_compra_encabezado", Valor = orden.IdGenorDenCompraEncabezado, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_estado_orden_de_compra", Valor = orden.Id_estado_orden_de_compra, Tipo = DbType.Int64, Out = false });

                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {

                        foreach (MOrdenCompraDetalle item in detalleInsercion)
                        {
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPUpdate_DetalleOrdenCompraCostos";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_producto", Valor = item.Idproducto, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@costo", Valor = item.NuevoCosto, Tipo = DbType.Decimal, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@precioa", Valor = item.NuevoPrecio, Tipo = DbType.Decimal, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@recibido", Valor = item.Recibidos, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_orden", Valor = orden.IdGenorDenCompraEncabezado, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_orden_compra_detalle", Valor = item.IdGenorDenCompraDetalle, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                            rpta = objExcute.UpsertTransaction(objProc1);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }

                        foreach (MHistorialPreciosCostos item in HistorialDetalleInsert)
                        {

                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_HistorialPreciosCostos";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_usuario_creacion", Valor = item.IdUsuarioCreacion, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_origen_monto_precios", Valor = item.IdOrigenMontoPrecios, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_sub_orden", Valor = item.IdSubOrden, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_producto", Valor = item.IdProducto, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@costo", Valor = item.Costo, Tipo = DbType.Decimal, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@precio_venta", Valor = item.PrecioVenta, Tipo = DbType.Decimal, Out = false });
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
    }

}
