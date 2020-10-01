using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ModelSoft502
{
    public class MExecute : CadenaConexionSqlServer
    {
        SqlCommand cmd;
        public string Upsert(MProcedimiento procedimiento)
        {
            string rpta = "";
            try
            {
                abrirConexion();
                SqlCommand cmd = oCnx.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento.NombreProcedimiento;

                foreach (var item in procedimiento.Parametros)
                {
                    SqlParameter parametro = new SqlParameter();
                    parametro.ParameterName = item.Nombre;
                    parametro.DbType = item.Tipo;
                    if (item.Out)
                    {
                        parametro.Direction = ParameterDirection.Output;
                    }
                    else
                    {
                        parametro.Direction = ParameterDirection.Input;
                        parametro.Value = item.Valor;
                    }
                    cmd.Parameters.Add(parametro);
                    //cmd.Parameters.AddWithValue(item.Nombre, item.Valor).DbType = item.Tipo;
                }
                rpta = cmd.ExecuteNonQuery() > 0 ? "OK" : "No ejecutado";
                cerrarConexion();
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }


        //____________________________________________________________________________________________________
        //____________________________________________________________________________________________________
        //____________________________________________________________________________________________________

        public void IniciarTran()
        {
            IniciarTransaction();
        }

        public string UpsertTransaction(MProcedimiento procedimiento)
        {
            string rpta = "";
            try
            {
                //abrir conexion a la DB
                cmd = oCnx.CreateCommand();
                cmd.Transaction = SqlTran;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento.NombreProcedimiento;

                foreach (var item in procedimiento.Parametros)
                {
                    SqlParameter parametro = new SqlParameter();
                    parametro.ParameterName = item.Nombre;
                    parametro.DbType = item.Tipo;
                    if (item.Out)
                    {
                        parametro.Direction = ParameterDirection.Output;
                    }
                    else
                    {
                        parametro.Direction = ParameterDirection.Input;
                        parametro.Value = item.Valor;
                    }
                    cmd.Parameters.Add(parametro);

                    //cmd.Parameters.AddWithValue(item.Nombre, item.Valor).DbType = item.Tipo;
                }

                rpta = cmd.ExecuteNonQuery() > 0 ? "OK" : "No ejecutado";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }

        public string UpsertTransaction()
        {
            string rpta = "";
            try
            {
                //abrir conexion a la DB
                cmd = oCnx.CreateCommand();
                cmd.Transaction = SqlTran;
                rpta = "OK";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }

        public object ParametroDeSalida(string nombreParametro)
        {
            return (cmd.Parameters[nombreParametro].Value);
        }

        //____________________________________________________________________________________________________
        //____________________________________________________________________________________________________
        //____________________________________________________________________________________________________

        public string UpsertTran(MProcedimiento procedimiento)
        {
            string rpta = "";
            try
            {
                //abrirConexion();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = oCnx;
                cmd.Transaction = SqlTran;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento.NombreProcedimiento;

                foreach (var item in procedimiento.Parametros)
                {
                    cmd.Parameters.AddWithValue(item.Nombre, item.Valor).DbType = item.Tipo;
                }

                rpta = cmd.ExecuteNonQuery() > 0 ? "OK" : "No ejecutado";
                //cerrarConexion();
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        //____________________________________________________________________________________________________
        //____________________________________________________________________________________________________
        //____________________________________________________________________________________________________



        public void cerrarConexionTransaccion()
        {

            cerrarConexion();

        }

        public DataTable Consultar(MProcedimiento procedimiento)
        {
            DataTable dtlDatos = new DataTable("datos");
            try
            {

                abrirConexion();
                SqlCommand cmd = oCnx.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento.NombreProcedimiento;

                if (procedimiento.Parametros != null)
                {
                    foreach (var item in procedimiento.Parametros)
                    {
                        cmd.Parameters.AddWithValue(item.Nombre, item.Valor).DbType = item.Tipo;
                    }
                }

                SqlDataAdapter msqDta = new SqlDataAdapter(cmd);
                msqDta.Fill(dtlDatos);

                cerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtlDatos;
        }

        public DataTable Mostrar(MProcedimiento procedimiento)
        {
            DataTable dtlDatos = new DataTable("datos");
            try
            {

                abrirConexion();
                SqlCommand cmd = oCnx.CreateCommand();
                cmd.CommandText = "select *from " + procedimiento.NombreTabla + " ";

                if (procedimiento.ParametrosConsulta != null)
                {
                    foreach (var item in procedimiento.ParametrosConsulta)
                    {
                        cmd.Parameters.AddWithValue(item.Nombre, item.Valor).DbType = item.Tipo;
                    }
                }

                SqlDataAdapter msqDta = new SqlDataAdapter(cmd);
                msqDta.Fill(dtlDatos);

                cerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtlDatos;
        }


        //______Funcion para insertar en la base de datos SqlServer
        //_________________________________________________________________________________



        //_________________________________________________________________________________
        //______Funcion para recibiri parametros y envialros a la base de datos
        //_________________________________________________________________________________
        public  string SqlValues(params object[] variables)
        {
            string elementos = "";
            int el = (variables.Length) - 1;
            for (int i = 0; i < (el); i++)
            {
                elementos += "'{" + i + "}',";
                if (i == (el - 1))
                {
                    int ultimo = i + 1;
                    elementos += "'{" + ultimo + "}'";

                }


            }

            return elementos;
        }
        //_________________________________________________________________________________
        //_________________________________________________________________________________


        public  string Insert(string NombreTabla, params object[] variables)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                string query = "Insert Into " + NombreTabla + " values(" + SqlValues(variables) + ")";
                query = string.Format(query, variables);
                SqlCon.ConnectionString = CadenaConexionSqlServer.Cadena;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand(query, SqlCon);



                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ejecto el comando";


            }
            catch (Exception ex)
            {

                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return respuesta;
        }

        //_________________________________________________________________________________
        //_________________________________________________________________________________
    }
}

