using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace ModelSoft502
{
    public class CadenaConexionSqlServer
    {
        public SqlConnection oCnx;
        public SqlTransaction SqlTran;

        public static SqlConnection oCnx1 = new SqlConnection(Properties.Settings.Default.conexion);

        public static string Cadena = Properties.Settings.Default.conexion;
        
        //ConfigurationManager.ConnectionStrings["conexion"].ToString()
        public CadenaConexionSqlServer()
        {
            oCnx = new SqlConnection(Cadena);
        }
        public void abrirConexion()
        {
            try
            {


                if (oCnx.State == ConnectionState.Broken || oCnx.State == ConnectionState.Closed)
                    oCnx.Open();
            }
            catch (Exception e)
            {

                throw new Exception("Error con la conexión a la base de datos ", e);
            }
        }


        public SqlConnection IniciarTransaction()
        {
            try
            {
                abrirConexion();
                SqlTran = oCnx.BeginTransaction();
            }
            catch (Exception e)
            {

                throw new Exception("Error con la conexión a la base de datos ", e);
            }
            return oCnx;
        }

        public void TranasctionCommit()
        {
            SqlTran.Commit();
        }

        public void TranasctionRollback()
        {
            SqlTran.Rollback();
        }


        public void cerrarConexion()
        {
            try
            {
                if (oCnx.State == ConnectionState.Open)
                    oCnx.Close();
            }
            catch (Exception e)
            {

                throw new Exception("Error al intentar cerrar la conexión con la base de datos ", e);
            }
        }

    }
}