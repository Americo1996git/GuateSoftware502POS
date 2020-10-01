using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelSoft502;

namespace ControllerSoft502
{
    public class ControllerBancos
    {
        public static string AgregarCuentaBancaria(int id_tabla,string codigo, string nombre, string descripcion, string numero_ceunta, int opcion)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_AgregarCuentaBancaria";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tabla", Valor = id_tabla, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@codigo", Valor = codigo, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@numero_cuenta", Valor = numero_ceunta, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);

        }

        public static string ActualizarCuentaBancaria(int idtienda, string nombre, string direccion)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_Bodega";
            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = nombre, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@direccion", Valor = direccion, Tipo = DbType.String, Out = false });
            return objExcute.Upsert(objProc);

        }
    }
}
