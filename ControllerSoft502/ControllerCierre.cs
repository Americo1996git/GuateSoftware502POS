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
    public class ControllerCierre
    {
        public static string CerrarInventario(MCierre cierre,MCierreDetalle cirreDetalle)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {
                objProc.NombreProcedimiento = "spsave_cierre";
                objProc.Parametros.Add(new MParametro { Nombre = "@pidcierre", Valor = cierre.Idcierre, Tipo = DbType.Int32, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = cierre.Idtienda, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@pfecha", Valor = cierre.Fecha, Tipo = DbType.DateTime, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@anio_cierre", Valor = cierre.Anio_cierre, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@mes_cierre", Valor = cierre.Mes_cierre, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@abierto", Valor = cierre.Abierto, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@mes", Valor = cierre.Mes, Tipo = DbType.Int32, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (rpta.Equals("OK"))
                {
                    int idingreso = Convert.ToInt32(objExcute.ParametroDeSalida("@pidcierre"));


                    MProcedimiento objProc1 = new MProcedimiento();
                    cirreDetalle.Idcierre = idingreso;
                    objProc1.NombreProcedimiento = "spsave_cierreDetalle";
                    objProc1.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = cirreDetalle.Idtienda, Tipo = DbType.Int32, Out = false });
                    objProc1.Parametros.Add(new MParametro { Nombre = "@pidcierre", Valor = cirreDetalle.Idcierre, Tipo = DbType.Int32, Out = false });
                    rpta = objExcute.UpsertTransaction(objProc1);

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

        public static DataTable ValidarMes(int mes)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ValidarCierreMes";
            objProc.Parametros.Add(new MParametro { Nombre = "@mes", Valor = mes, Tipo = DbType.String, Out = false });
            return objExcute.Consultar(objProc);

        }
    }
}
