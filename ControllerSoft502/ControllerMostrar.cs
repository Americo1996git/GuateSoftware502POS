using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelSoft502;
using System.Data;

namespace ControllerSoft502
{
    public class ControllerMostrar
    {
       public static DataTable TiposDePagos()
       {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreTabla = "tbl_tipos_pago";
            return objExcute.Mostrar(objProc);

       }
        public static DataTable Usuarios()
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreTabla = "tbl_usuarios";
            return objExcute.Mostrar(objProc);
        }


        public static DataTable CuentasBancarias()
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreTabla = "CuentaBanco";
            return objExcute.Mostrar(objProc);
        }
        public static DataTable TiposDeGastos()
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreTabla = "tbl_tipo_salida_dinero";
            return objExcute.Mostrar(objProc);
        }

        public static DataTable HistorialCuadreDia(int id_tienda)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_HistorialVitacoraCuadreDia";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        //public static string AgregarCuenta(string codigo, string nombre, string descripcion, string numero_ceunta, DateTime fecha)
        //{
        //    MExecute objExcute = new MExecute();
        //    return objExcute.Insert("CuentaBanco", codigo, nombre, descripcion, numero_ceunta, DateTime.Now.ToString(""));
        //}


    }
}
