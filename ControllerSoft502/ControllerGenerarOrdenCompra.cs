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
    public class ControllerGenerarOrdenCompra
    {
        public static int IdOrdenDeCompra;

        public static int IdSubOrden;

        //__________________________ESTA FUNCION ES PARA MOSTRAR LA REQUISICION Y SU DETALLE PARA PODER EDITARLO
        public static DataTable MostrarRequisicionesPendietnes(int idtienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_RequisicionesPendientesParaGenerarOrdenDeCompra";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }
        

        public static DataTable MostrarProveedores()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ProveedoresParaGenerarSubOrdenDeCompra";
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarDetalleDeRequisicion(int idtienda, int idcapturapedido)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_DetalleDeRequisicionParaGenerarSubOrdenDeCompra";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = idcapturapedido, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarProductos()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPmostrar_TodosoLosProductosParaAgregarAsubOrden";
            return objExcute.Consultar(objProc);
        }

        //_______________________-ESTA FUNCION ES PARA MOSTRAR LAS LINEAS_______________________________
        public static DataTable MostrarLineas()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_linea";
            return objExcute.Consultar(objProc);
        }

        //______________________Esta funcion es para mostrar sublineas que pertenecen a una linea
        public static DataTable MostrarSubLineas(int idlinea)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_SublienasParaCrearProducto";
            objProc.Parametros.Add(new MParametro { Nombre = "@idlinea", Valor = idlinea, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        //__________ESTA FUNCION ES PARA MOSTRAR LAS MARCAS QUE TIENE UNA LINEA________
        public static DataTable MostrarMarcas()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_marca";
            return objExcute.Consultar(objProc);
        }




        //________________________________ESTA FUNCONA ES PARA AGREGAR NUEVAMENTE LOS PRODUCTOS A LA REQUISICION
        //CON LA DIFERTENCIA DEQUE INSERTA PRODUCTOS TANTO DE SUBORDEN COMO REQUISICION________________________________________________________________
        public static string ActualizarCapturaPedidoRequisicion(MRequisicion requisicion, List<MRequisicionDetalle> detalleInsercion)
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

                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idencabezadoTabla = requisicion.Idcapturapedido;

                        //foreach (MRequisicionDetalle item in detalleEliminacion)
                        //{

                        //    item.Idcapturapedido = idencabezadoTabla;
                        //    MProcedimiento objProc1 = new MProcedimiento();
                        //    objProc1.NombreProcedimiento = "SPSave_CapturaPedidoDetalleEnELmoduloSubOrdenDeCOmpra";
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@id_captura_pedido_detalle", Valor = item.Idcapturapedidodetalle, Tipo = DbType.Int64, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.Idtienda, Tipo = DbType.Int64, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = item.Idcapturapedido, Tipo = DbType.Int64, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.Idproducto, Tipo = DbType.Int64, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad_requerida", Valor = item.CantidadRequerida, Tipo = DbType.Int32, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@origen", Valor = item.Origen, Tipo = DbType.String, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int32, Out = false });
                        //    rpta = objExcute.UpsertTransaction(objProc1);
                        //    if (!rpta.Equals("OK"))
                        //    {
                        //        break;
                        //    }
                        //}

                        //foreach (MRequisicionDetalle item in detalleInsercion)
                        //{

                        //    item.Idcapturapedido = idencabezadoTabla;                   
                        //    MProcedimiento objProc1 = new MProcedimiento();
                        //    objProc1.NombreProcedimiento = "SPSave_SubOrdenDetalle";
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.IdTienda, Tipo = DbType.Int64, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@idsuborden", Valor = item.IdSuborden, Tipo = DbType.Int64, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@id_captura_pedido_detalle", Valor = item.IdCapturaPedidoDetalle, Tipo = DbType.Int64, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad_autorizada", Valor = item.CantidadAutorizada, Tipo = DbType.Int32, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@precio_compra", Valor = item.PrecioCompra, Tipo = DbType.Decimal, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@precioa_producto", Valor = item.Precioa, Tipo = DbType.Decimal, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.Idproducto, Tipo = DbType.Int64, Out = false });

                        //    rpta = objExcute.UpsertTransaction(objProc1);
                        //    if (!rpta.Equals("OK"))
                        //    {
                        //        break;
                        //    }
                        //}
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


        //_________________________________ESTA FUNCION ES PARA GUARDAR O CREAR PRODUCTOS EN LA SUBRODEN DE COMPRA___
        public static string GuardarProducto(MProducto producto)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPSave_ProductosIncompletosSubOrden";
                objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = producto.Idtienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idsublinea", Valor = producto.Idsublinea, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idmarca", Valor = producto.Idmarca, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = producto.Nombre, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@presentacion", Valor = producto.Presentacion, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@utilizamarca", Valor = producto.UtilizaMarca, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@nombrelinea", Valor = producto.NombreLinea, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@aplicaserie", Valor = producto.AplicaSerie, Tipo = DbType.String, Out = false });
                rpta = objExcute.Upsert(objProc);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                objExcute.cerrarConexion();
            }
            return rpta;
        }



        //__________ESTA FUNCION ES PARA MOSTRAR LOS PRODCTOS RECIENAGREGADOS CON ESTATUS RECIETNE = SI________
        public static DataTable MostrarProdcutosRecienCreados()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ProductosRecientesSubOrdenDeCompra";
            return objExcute.Consultar(objProc);
        }

        //____ESTA FUNCION ES PARA ACTULAIZAR EL ESTDO RECIENTE DEL PRODCUTO, RECIENTE = NO
        public static string ProductosDejanDeSerRecientes(int idproducto)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_DejanDeSerProductosRecientes";
            objProc.Parametros.Add(new MParametro { Nombre = "@idprocuto", Valor = idproducto, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);
        }

        //_____________________Esta funcion es para crear la subroden a proveedor_________
        //En este caso si el proveedor ya existe entonces los productos de la requsicion eleginda se asiganan a ese proveedro
        //en caso contrario si el proveedor no existe se crea la orden de compra
        public static string CrearSubOrden(MSubOrden suborden, List<MSubOrdenDetalle> detalleInsercion/*, List<MSubOrdenDetalle> detalleEliminacion*/)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPSave_SubOrden";
                objProc.Parametros.Add(new MParametro { Nombre = "@idsuborden", Valor = suborden.IdSuborden, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = suborden.IdTienda, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idproveedor", Valor = suborden.IdProveedor, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idusuario", Valor = suborden.IdUsuariio, Tipo = DbType.Int32, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null )
                {
                    if (rpta.Equals("OK"))
                    {
                        int idencabezadoTabla = Convert.ToInt32(objExcute.ParametroDeSalida("@idsuborden"));
                        IdSubOrden = Convert.ToInt32(objExcute.ParametroDeSalida("@idsuborden"));
                        //foreach (MSubOrdenDetalle item in detalleEliminacion)
                        //{

                        //    item.IdSuborden = idencabezadoTabla;
                        //    MProcedimiento objProc1 = new MProcedimiento();
                        //    objProc1.NombreProcedimiento = "SPSave_SubOrdenDetalle";
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.IdTienda, Tipo = DbType.Int64, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@idsuborden", Valor = item.IdSuborden, Tipo = DbType.Int64, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@id_captura_pedido_detalle", Valor = item.IdCapturaPedidoDetalle, Tipo = DbType.Int64, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad_autorizada", Valor = item.CantidadAutorizada, Tipo = DbType.Int32, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@idsubordendetalle", Valor = item.IdSubOrdenDetalle, Tipo = DbType.Int32, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@precio_compra", Valor = item.PrecioCompra, Tipo = DbType.Decimal, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@precioa_producto", Valor = item.Precioa, Tipo = DbType.Decimal, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.Idproducto, Tipo = DbType.Int64, Out = false });
                        //    objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int64, Out = false });
                        //    rpta = objExcute.UpsertTransaction(objProc1);
                        //    if (!rpta.Equals("OK"))
                        //    {
                        //        break;
                        //    }
                        //}
                        foreach (MSubOrdenDetalle item in detalleInsercion)
                        {

                            item.IdSuborden = idencabezadoTabla;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_SubOrdenDetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.IdTienda, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idsuborden", Valor = item.IdSuborden, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_captura_pedido_detalle", Valor = item.IdCapturaPedidoDetalle, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad_autorizada", Valor = item.CantidadAutorizada, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idsubordendetalle", Valor = item.IdSubOrdenDetalle, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@precio_compra", Valor = item.PrecioCompra, Tipo = DbType.Decimal, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@precioa_producto", Valor = item.Precioa, Tipo = DbType.Decimal, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.Idproducto, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_captura_pedido", Valor = item.IdCapturaPedido, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int64, Out = false });
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


        //______________esta funcion solo agrega los prodcuso a la suborden con el proveedor seleccionado o solicitado
        public static string AgregarProductosSubOrdenExistente(int idcaptruapedido,int idtienda, List<MSubOrdenDetalle> detalleInsercion)
        {
            string rpta = "";
            MExecute objExcute = new MExecute();
            MProcedimiento objProc = new MProcedimiento();
            try
            {

                objProc.NombreProcedimiento = "SPUpdate_CambiarEstadoRequisicionEnProceso";
                objProc.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = idcaptruapedido, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null)
                {



                    foreach (MSubOrdenDetalle item in detalleInsercion)
                    {

                        MProcedimiento objProc1 = new MProcedimiento();
                        objProc1.NombreProcedimiento = "SPSave_SubOrdenDetalle";
                        objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.IdTienda, Tipo = DbType.Int64, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@idsuborden", Valor = item.IdSuborden, Tipo = DbType.Int64, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_captura_pedido_detalle", Valor = item.IdCapturaPedidoDetalle, Tipo = DbType.Int64, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad_autorizada", Valor = item.CantidadAutorizada, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@idsubordendetalle", Valor = item.IdSubOrdenDetalle, Tipo = DbType.Int32, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@precio_compra", Valor = item.PrecioCompra, Tipo = DbType.Decimal, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@precioa_producto", Valor = item.Precioa, Tipo = DbType.Decimal, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.Idproducto, Tipo = DbType.Int64, Out = false });
                        objProc1.Parametros.Add(new MParametro { Nombre = "@id_captura_pedido", Valor = item.IdCapturaPedido, Tipo = DbType.Int64, Out = false });
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

        //_____________ESTA FUNCION ES PARA MOSTRAR LAS SUBORDENS CREASAS 
        public static DataTable MostrarSubOrdenesConSuProveedor(int idtienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_SubOrdenParaGenerarOC";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        //_____________ESTA FUNCION ES PARA MOSTRAR LAS SUBORDENS CREASAS POR PROVEEDOR 
        public static DataTable MostrarSubOrdenesPorProveedor(int idtienda,int idproveedor)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_SubOrdenParaGenerarOCPorProveedor";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_priveedor", Valor = idproveedor, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        //________ESTA FINCION ES PARA MOSTRAR EL DETALLE DE UAN SUBORDEN
        public static DataTable SPMostrar_SubOrdenDetalle(int idtienda,int idproveedor)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_SubOrdenDetalle";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idproveedor", Valor = idproveedor, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }
        public static DataTable MostrarLineasActivas()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_LineasActivas";



            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarSubLineasActivas(int idlinea)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_SublineasActivas";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_linea", Valor = idlinea, Tipo = DbType.Int64, Out = false });
            return objExcute.Consultar(objProc);

        }

        //___________________________________________________________________________
        public static string ActualizarPreciosYCostos(int idtienda, int idproducto, decimal precioa,decimal precioCosto,int opcion,bool verificado, int id_sub_orden_detlle)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_PrecioAyUltimoCostoproductoSubordenCompra";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = idproducto, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@precioa_producto", Valor = precioa, Tipo = DbType.Decimal, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@precio_compra", Valor = precioCosto, Tipo = DbType.Decimal, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@verificado", Valor = verificado, Tipo = DbType.Boolean, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_sub_orden_detalle", Valor = id_sub_orden_detlle, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);
        }

        //___________________________________________________________________________
        public static string ActualizarCantidadSubOrdenDetalle(int idsubordendetalle, int idproducto, int idtienda, int cantidad)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_CantidadAutorizarSuobrdenDetalle";
            objProc.Parametros.Add(new MParametro { Nombre = "@idsubordendetalle", Valor = idsubordendetalle, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = idproducto, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = cantidad, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);
        }

        //___________________________________________________________________________
        public static string EliminarProductoDeSubOrdenDetalle(int idtienda, int idproducto, int idsubordendetalle,int id_captura_pedido)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPDelete_ProductoDeSubOrdenDeCompra";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = idproducto, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idsubordendetalle", Valor = idsubordendetalle, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_captura_pedido", Valor = id_captura_pedido, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);
        }


        //____________________ESTA FUNCION ES PARA RECHAR LA REQUISICION _________________________________________
        public static string TerminiarRequisicion(int idtienda, int idcaptruapedido)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_CompletarCapturaPedidoRequisicion";
            objProc.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = idcaptruapedido, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);
        }

        public static string CompletarRequisicion(int idtienda, int idcaptruapedido)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_CambiarEstadoRequisicionEnTerminado";
            objProc.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = idcaptruapedido, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);
        }


        //____________________ESTA FUNCION ES PARA  ANULAR UNA SUBORDEN_______________________________________
        public static string AnularSuborden(int idsuborden, int idtienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_AnularSubOrden";
            objProc.Parametros.Add(new MParametro { Nombre = "@idsuborden", Valor = idsuborden, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);
        }

        //____________________ESTA FUNCION ES PARA  CAMBIAR EL ESTADO DE UNA REQUSISICON A EN PROCESO, SU ESTADO PASA A SER , pro = en proceso_____________________________________
        public static string RequisicionEnProceso(int idcapturapedido, int idtienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_CmbiarCapturaPedidoAestadoEnProceso";
            objProc.Parametros.Add(new MParametro { Nombre = "@idcapturapedido", Valor = idcapturapedido, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);
        }

        //__________ESTA FUNCON ES PARA GENERAR LA ORDEN DE COMPRA COMO TAL_____
        public static string GenerarOrdenDeCompra(MOrdenCompra ordenCompra, List<MOrdenCompraDetalle> detalleInsercion, List<MHistorialPreciosCostos> HistorialDetalleInsert)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPSave_GenerarOrdenDeCompra";
                objProc.Parametros.Add(new MParametro { Nombre = "@idgenordencompraencabezado", Valor = ordenCompra.IdGenorDenCompraEncabezado, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = ordenCompra.IdTienda, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idusuario", Valor = ordenCompra.IdUsuario, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@serie", Valor = ordenCompra.Serie, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@destino", Valor = ordenCompra.Destino, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@observaciones", Valor = ordenCompra.Observaciones, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@quien_recibe_orden", Valor = ordenCompra.QuienRecibe, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@fecha_ingreso_bodega", Valor = ordenCompra.FechaIngresoBodega, Tipo = DbType.Date, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idsuborden", Valor = ordenCompra.Idsuborden, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_estado_orden_de_compr", Valor = ordenCompra.Id_estado_orden_de_compra, Tipo = DbType.Int32, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idencabezadoTabla = Convert.ToInt32(objExcute.ParametroDeSalida("@idgenordencompraencabezado"));
                        IdOrdenDeCompra = idencabezadoTabla;
                        foreach (MOrdenCompraDetalle item in detalleInsercion)
                        {

                            item.IdGenorDenCompraEncabezado = idencabezadoTabla;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_GenerarOrdenDeCompraDetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = item.IdTienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idgenordencompraencabezado", Valor = item.IdGenorDenCompraEncabezado, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idsubordendetalle", Valor = item.IdSubOrdenDetalle, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = item.Idproducto, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@cantidad", Valor = item.Cantidad, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@verificado", Valor = item.Verificado, Tipo = DbType.Boolean, Out = false });
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

        //____________________esta funcion es para reimprimr una orden de compra________________________________________________________
        public static DataTable ReimprimrOrdenDeCompra(int idtienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_OrdenesDeCompraParaReimprimir";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static DataTable VerificacionesOrdenDeCompra(int idtienda)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_OrdenesDeCompraParaVerificacionesPrecios";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static DataTable MostrarHistorialDePrecios(int id_producto,int id_proveedor)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_HistorialPreciosCostos";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_producto", Valor = id_producto, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_proveedor", Valor = id_proveedor, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }
    }
}
