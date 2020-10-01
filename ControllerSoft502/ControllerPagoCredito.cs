using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODELOS502;
using ModelSoft502;

namespace ControllerSoft502
{
    public class ControllerPagoCredito
    {
        public static int IdPagoEnc;
        public static string RealizarPago(MPagoCreditoEncabezado pago, List<MPagoCreditoDetalle> detalleInsercion/*, List<MSubOrdenDetalle> detalleEliminacion*/)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "SPSave_PagoCreditoEncabezado";
                objProc.Parametros.Add(new MParametro { Nombre = "@id_pago_credito_enc", Valor = pago.IdPagoCreditoEnc, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@monto_recibo", Valor = pago.MontoRecibido, Tipo = DbType.Decimal, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_pago", Valor = pago.IdTipoPagoCredito, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = pago.IdCliente, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@nombre_cliente", Valor = pago.NombreCliente, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@detalle_recibo", Valor = pago.DetalleRecibo, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@codigo_pago_lugar", Valor = pago.NumeroDeposito, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@lugar_de_pago", Valor = pago.Banco, Tipo = DbType.String, Out = false });
                if (pago.IdTipoPagoCredito == 4)
                {
                    objProc.Parametros.Add(new MParametro { Nombre = "@fecha_de_pago", Valor = pago.FechaDepositoBanco, Tipo = DbType.Date, Out = false });
                }
                else
                {
                    objProc.Parametros.Add(new MParametro { Nombre = "@fecha_de_pago", Valor = DBNull.Value, Tipo = DbType.Date, Out = false });
                }

                objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario_creacion", Valor = pago.IdUsuario, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = pago.IdTienda, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_serie", Valor = pago.IdSerie, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@serie", Valor = pago.Serie, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_origen_anticipo", Valor = pago.IdOrigenAnticipo, Tipo = DbType.Int32, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idencabezadoTabla = Convert.ToInt32(objExcute.ParametroDeSalida("@id_pago_credito_enc"));
                        IdPagoEnc = Convert.ToInt32(objExcute.ParametroDeSalida("@id_pago_credito_enc"));

                        foreach (MPagoCreditoDetalle item in detalleInsercion)
                        {

                            item.IdPagoCreditoEnc = idencabezadoTabla;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSavePagoCreditoDetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.IdTienda, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_pago_credito_enc", Valor = item.IdPagoCreditoEnc, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_promesa_pago_det", Valor = item.IdPromesaPagoDet, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_usuario", Valor = item.IdUsuario, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@monto_pagar", Valor = item.MontoPagar, Tipo = DbType.Decimal, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@monto_interes", Valor = item.MontoInteres, Tipo = DbType.Decimal, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@monto_cuota", Valor = item.MontoCuota, Tipo = DbType.Decimal, Out = false });
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


        public static string ActualizarEstadoDelPago(MPagoCreditoEncabezado pago, List<MPagoCreditoDetalle> detalleInsercion/*, List<MSubOrdenDetalle> detalleEliminacion*/)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {
                if (pago != null)
                {
                    objProc.NombreProcedimiento = "SPUpdate_ActualizarPago";
                    objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = pago.IdTienda, Tipo = DbType.Int64, Out = false });
                    objProc.Parametros.Add(new MParametro { Nombre = "@id_pago_credito_recibo_enc", Valor = pago.IdPagoCreditoEnc, Tipo = DbType.Int32, Out = false });
                    objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_pago", Valor = pago.IdTipoPagoCredito, Tipo = DbType.Int32, Out = false });
                    objProc.Parametros.Add(new MParametro { Nombre = "@id_estado_recibo", Valor = pago.IdEstadoRecibo, Tipo = DbType.Int32, Out = false });
                    objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = pago.Opcion, Tipo = DbType.Int32, Out = false });
                    objExcute.IniciarTran();
                    rpta = objExcute.UpsertTransaction(objProc);
                }


                if (detalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        foreach (MPagoCreditoDetalle item in detalleInsercion)
                        {
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPUpdate_ActualizarPagoDetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.IdTienda, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_promesa_pago_det", Valor = item.IdPromesaPagoDet, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@monto", Valor = item.MontoCuota, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Decimal, Out = false });
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

        public static string ActualizarEstadoDelPago(List<MPagoCreditoDetalle> detalleInsercion/*, List<MSubOrdenDetalle> detalleEliminacion*/)
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
                    if (rpta.Equals("OK"))
                    {
                        foreach (MPagoCreditoDetalle item in detalleInsercion)
                        {
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPUpdate_ActualizarPagoDetalle";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = item.IdTienda, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_promesa_pago_det", Valor = item.IdPromesaPagoDet, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@monto", Valor = item.MontoCuota, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Decimal, Out = false });
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


        public static DataTable MostrarClienteConCredito(string texto, int opcion)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ListadoClientesConCredito";
            objProc.Parametros.Add(new MParametro { Nombre = "@texto_buscar", Valor = texto, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarCreditoPorCliente(int id_cliente, int opcion)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_CreditosPorCliente";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = id_cliente, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarCuantosMesesReporteMorosos()
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_CuantosMesesMorosos";
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarDetallePromesasDePagoParaCobros(int id_proesa_pago_enc)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ProesasPagoParaCobros";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_promesa_pago_enc", Valor = id_proesa_pago_enc, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }


        //_____________________________ESTA FUNCIONA MUESTRA PAGOS EN TRANSITO__________________________________________________________
        public static DataTable MostrarPagosEnTransito(int id_tienda)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_PagosEnTransito";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        //_____________________________ESTA FUNCIONA MUESTRA EL DETALLE DE PAGO ES DECIR EL DETALLE DE CADA RECIBO__________________________________________________________
        public static DataTable MostrarDetalleDePago(int id_tienda, int id_pago_o_recibo_enc)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_DetalleDePagoCredito";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_pago_credito_enc", Valor = id_pago_o_recibo_enc, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }


        // ESTA FUNCION HAY QUE REVISAR SI SE ELIMINA O SE UTILIZA
        //public static DataTable ObtenerElTotalDeCuotas(int id_promesa_pago_enc)
        //{
        //    MProcedimiento objProc = new MProcedimiento();
        //    MExecute objExcute = new MExecute();
        //    objProc.NombreProcedimiento = "SPMostrar_RecargosContarTotalDeCuotas";
        //    objProc.Parametros.Add(new MParametro { Nombre = "@id_promesa_pago", Valor = id_promesa_pago_enc, Tipo = DbType.Int32, Out = false });
        //    return objExcute.Consultar(objProc);

        //}

        //_____________________________ESTA FUNCION ES PARA AGREGAR LAS OBSERVACIONES POR CADA CUOTA ___________________
        public static string AgregarObservaciones(int id_promesas_pago_det, int idtienda, string descripcion, int id_usuario)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_AgregarObservacionesParaCuotaPromesasDePago";

            objProc.Parametros.Add(new MParametro { Nombre = "@id_ventas_promesas_pago_det", Valor = id_promesas_pago_det, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario_creacion", Valor = id_usuario, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);

        }

        public static string CalcularMoras(int id_tienda, int id_usuario,int dias)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SP_CACULO_DE_MORAS_AUTOMATICO";

            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario", Valor = id_usuario, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@dias_tolerar", Valor = dias, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);

        }

        //___________________________________________________________________________________________________________
        //_____________________________________________________________________________________________________________
        //_________________________________ESTA FUNCION MUESTRA LAS CUOTAS DE UN CREDITO
        //NOTA: POR EL MOMENTO NO SE ESTA USUANDO
        //public static DataTable MostrarDetallePromesasDePagoParaObservaciones(int id_proesa_pago_enc)
        //{
        //    MProcedimiento objProc = new MProcedimiento();
        //    MExecute objExcute = new MExecute();
        //    objProc.NombreProcedimiento = "SPMostrar_PromesasDePagoParaAgregarObservaciones";
        //    objProc.Parametros.Add(new MParametro { Nombre = "@id_promesa_pago_enc", Valor = id_proesa_pago_enc, Tipo = DbType.Int32, Out = false });
        //    return objExcute.Consultar(objProc);

        //}
        //____________________________________________________________________________________________________________________

        //___ESTA FUNCION ES PARA AGREGAR LOS RECRGOS 
        public static string AgregarRecargos(int idtienda, int id_promesa_pago, int id_usuario, int correlativo, decimal monto, string descripcion, DateTime fecha_de_pago,int id_tipo_de_promesa)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_AgregarRecargos";

            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_promesa_pago", Valor = id_promesa_pago, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario_creacion", Valor = id_usuario, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@numero_cuota", Valor = correlativo, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@monto", Valor = monto, Tipo = DbType.Decimal, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@fecha_de_pago", Valor = fecha_de_pago, Tipo = DbType.Date, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_de_promesa", Valor = id_tipo_de_promesa, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);

        }
        public static DataTable MostrarDetalleDeRecargos(int id_promesa_pago_enc)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_Recargos";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_promesa_pago", Valor = id_promesa_pago_enc, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        //__________________

        public static DataTable MostrarDetalleObservacionesPorCuota(int id_promesas_pago_det)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ObservacionesPorCuotas";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_promesa_pago_det", Valor = id_promesas_pago_det, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }



        public static string CancelarCreditoVenta(int id_promesas_pago_enc)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_CancelarCreditoVenta";

            objProc.Parametros.Add(new MParametro { Nombre = "@id_promesa_pago", Valor = id_promesas_pago_enc, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);


        }


        //___ESTA FUNCION ES PARA mostra los DEOUDRES O CUANTAS VECES A SIDO FIADOR UAN PERSONA

        public static DataTable MostrarDeudores(int id_tienda, string persona)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_BusquedaDeCodeudores";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@deudor", Valor = persona, Tipo = DbType.String, Out = false });
            return objExcute.Consultar(objProc);

        }


        //___ESTA FUNCION ES PARA MOSTRAR LA REVISON DE PAGOS Y NOTAS

        public static DataTable MostrarPagosNotas(int id_tienda, DateTime fecha_inicial, DateTime fecha_final, int id_tipo_pago, int opcion)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_RevisionDepositosNotas";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@fecha_incial", Valor = fecha_inicial, Tipo = DbType.Date, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@fecha_final", Valor = fecha_final, Tipo = DbType.Date, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tipo_pago_doc", Valor = id_tipo_pago, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }




        //_____________________________ESTA FUNCION ES PARA GARBAR EN EL HISTORIA CUADRE DE DINERO O DIA ___________________
        public static string GrabarEnHistorialDeCuadreDinero(int id_tienda,int id_usuario, decimal total_entradas, decimal total_salidas,decimal monto_ingresado)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_Mod_Cobros_HistorialCuadreDinero";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_usuario", Valor = id_usuario, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@total_entradas", Valor = total_entradas, Tipo = DbType.Decimal, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@total_salidas", Valor = total_salidas, Tipo = DbType.Decimal, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@monto_ingresado", Valor = monto_ingresado, Tipo = DbType.Decimal, Out = false });
            return objExcute.Upsert(objProc);

        }
    }
}