using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelSoft502;
using System.Data;

namespace ControllerSoft502
{
    public class ControllerSubLinea
    {
        public static string ActualizarSubLinea(int idsublinea,int idlinea,string descripcion, string abreviatura, decimal descuento)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_SubLinea";


            objProc.Parametros.Add(new MParametro { Nombre = "@idsublinea", Valor = idsublinea, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idlinea", Valor = idlinea, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@abreviatura", Valor = abreviatura, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descuento", Valor = descuento, Tipo = DbType.Decimal, Out = false });
            return objExcute.Upsert(objProc);

        }

        public static DataTable MostrarSubLienas(int idlinea)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_SublineaParaCrearProductos";
            objProc.Parametros.Add(new MParametro { Nombre = "@idlinea", Valor = idlinea, Tipo = DbType.Int64, Out = false });

            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarSubLienasParaElModulo()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_SublineasModuloSublineas";

            return objExcute.Consultar(objProc);

        }

        public static string GuardarSubLinea(int idtienda,int idlinea, string descripcion,string abreviatura, decimal descuento)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_Sublinea";

            objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@idlinea", Valor = idlinea, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@abreviatura", Valor = abreviatura, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descuento", Valor = descuento, Tipo = DbType.Decimal, Out = false });
            return objExcute.Upsert(objProc);

        }

    }
}
