using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELOS502;
using ModelSoft502;
using System.Data;

namespace ControllerSoft502
{
    public class ControllerVentas
    {

        public static DataTable MostrarClientes(string dpi,string nombres, string apellidos, int opcion)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_BuscarClienteParaVentas";
            objProc.Parametros.Add(new MParametro { Nombre = "@dpi", Valor = dpi, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@nombres", Valor = nombres, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@apellidos", Valor = apellidos, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = opcion, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static DataTable ValidarBloqueoCliente(int id_cliente)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "ValidarBloqueoCliente";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = id_cliente, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

        public static DataTable MostrarProductosEnbodega(int idtienda, int idbodega, string texto)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ProductosEnBodegaParaVentas";
            objProc.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = idtienda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@pidbodega", Valor = idbodega, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@texto", Valor = texto, Tipo = DbType.String, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static string AgregarTelefonoCliente(int id_cliente, string descripcion, string telefono)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_AgregarTelefonoCliente";

            objProc.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = id_cliente, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@telefono", Valor = telefono, Tipo = DbType.String, Out = false });
            return objExcute.Upsert(objProc);

        }

        public static string ActualizarTelefonoCliente(int id_cliente, int id_telefono,string descripcion, string telefono)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUpdate_TelefonosClietne";

            objProc.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = id_cliente, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_telefono", Valor = id_cliente, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@telefono", Valor = telefono, Tipo = DbType.String, Out = false });
            return objExcute.Upsert(objProc);

        }

        public static DataTable MostrarTelefonoDeCliente(int id_cliente)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_TelefonosClietne";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = id_cliente, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static string EliminarTelefonoCliente(int id_cliente, int id_telefono)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPDelete_TelefonosClietne";

            objProc.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = id_cliente, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_telefono", Valor = id_telefono, Tipo = DbType.Int32, Out = false });
            return objExcute.Upsert(objProc);

        }


        public static string ObtenerIdVentaEnc(int id_cliente, string descripcion, string telefono)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_AgregarTelefonoCliente";

            objProc.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = id_cliente, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = descripcion, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@telefono", Valor = telefono, Tipo = DbType.String, Out = false });
            return objExcute.Upsert(objProc);

        }
    }
}
