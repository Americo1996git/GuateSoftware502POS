using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelSoft502;

namespace ControllerSoft502
{
    public class ControllerProveedor
    {
      
        public static string guardarProveedor(int idtienda,string nombre, string nit, string direccion, string correo, string telefono,string vendedor,string telefono_vendedor)
        {
            MExecute objExcute = new MExecute();
            MProcedimiento objProc = new MProcedimiento();
            objProc.NombreProcedimiento = "SPSave_Proveedor";

            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nit", Valor = nit, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@direccion", Valor = direccion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@correo", Valor = correo, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@telefono", Valor = telefono, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@vendedor", Valor = vendedor, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@telefono_vendedor", Valor = telefono_vendedor, Tipo = DbType.String, Out = false });
            return objExcute.Upsert(objProc);
        }

        public static string ActualizarProveedor(int idproveedor, int idtienda, string nombre, string nit, string direccion, string correo, string telefono, string vendedor, string telefono_vendedor)
        {
            MExecute objExcute = new MExecute();
            MProcedimiento objProc = new MProcedimiento();
            objProc.NombreProcedimiento = "SPUpdate_Proveedor";

            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idproveedor", Valor = idproveedor, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nit", Valor = nit, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@direccion", Valor = direccion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@correo", Valor = correo, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@telefono", Valor = telefono, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@vendedor", Valor = vendedor, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@telefono_vendedor", Valor = telefono_vendedor, Tipo = DbType.String, Out = false });
            return objExcute.Upsert(objProc);
        }

        public static DataTable mostrarTodosProveedores()
        {

            try
            {

                MExecute objExcute = new MExecute();
                MProcedimiento objProc = new MProcedimiento();
                objProc.NombreProcedimiento = "SPMostrar_Proveedor";
                return objExcute.Consultar(objProc);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
