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
    public class ControllerProducto
    {




       

        public static DataTable MostrarCaracteristicas(int idproducto)
        {
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_CaracteristicasDetalle";
            objProc.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = idproducto, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);
        }

   
     


        
    
    
       

        public static DataTable MostrarProductos()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "spmostrar_TodosLosProductos";



            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarProductosInactivos()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_TodosLosProductosInactivos";



            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarMarcasActivas()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_MarcasActivas";



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

        public static string DesactivarProducto(int idproducto)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUdate_DesactivarProducto";
            objProc.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = idproducto, Tipo = DbType.Int64, Out = false });
            return objExcute.Upsert(objProc);

        }

        public static string ActivarProducto(int idproducto)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPUdate_ActivarProducto";
            objProc.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = idproducto, Tipo = DbType.Int64, Out = false });
            return objExcute.Upsert(objProc);

        }



        

       

        public static string GuardarProducto(MProducto producto, List<MCaracteristicasProducto> caracteristicasDetalle)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {
       
                objProc.NombreProcedimiento = "spsave_producto";
                objProc.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = producto.Idproducto, Tipo = DbType.Int64, Out = true });
                objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = producto.Idtienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idsublinea", Valor = producto.Idsublinea, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idmarca", Valor = producto.Idmarca, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = producto.Nombre, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@modelo", Valor = producto.Modelo, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@precioa", Valor = producto.Precioa, Tipo = DbType.Decimal, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@preciob", Valor = producto.Preciob, Tipo = DbType.Decimal, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@precioc", Valor = producto.Precioc, Tipo = DbType.Decimal, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@imagen", Valor = producto.RutaImagen, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@meses", Valor = producto.MesesGarantia, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@utilizaImagen", Valor = producto.UtilizaImagen, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@concaracteristica", Valor = producto.ConCaracteristica, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@presentacion", Valor = producto.Presentacion, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@esreciente", Valor = producto.EsReciente, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@descuento", Valor = producto.Descuento, Tipo = DbType.Decimal, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@utilizamarca", Valor = producto.UtilizaMarca, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@ultimocosto", Valor = producto.Ultimocosto, Tipo = DbType.Decimal, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@nombrelinea", Valor = producto.NombreLinea, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@aplicaserie", Valor = producto.AplicaSerie, Tipo = DbType.String, Out = false });
                objExcute.IniciarTran();
                rpta =  objExcute.UpsertTransaction(objProc);

                if (caracteristicasDetalle !=null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idproducto = Convert.ToInt32(objExcute.ParametroDeSalida("@idproducto"));

                        foreach (MCaracteristicasProducto item in caracteristicasDetalle)
                        {
   
                            item.Idproducto = idproducto;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "spsave_caracteristicaproducto";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = item.Idtienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pidproducto", Valor = item.Idproducto, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@ptitulo", Valor = item.Titulo, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pdescripcion", Valor = item.Descripcion, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idcaracteristica", Valor = item.Idcaracteristica, Tipo = DbType.Int64, Out = false });
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

                    if (producto.ActivarImagen.Equals("activar"))
                    {

                        if (producto.RutaImagen != "ninguno")
                        {
                            System.IO.File.Copy(producto.RutaImagenInsercion, "./assets/ImagenesProductos/" + producto.RutaImagen);
                        }
                    }


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



        public static string ActualizarProducto(MProducto producto, List<MCaracteristicasProducto> caracteristicasDetalleEliminacion, List<MCaracteristicasProducto> caracteristicasDetalleInsercion)
        {
            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {

                objProc.NombreProcedimiento = "spedit_producto";
                objProc.Parametros.Add(new MParametro { Nombre = "@idproducto", Valor = producto.Idproducto, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idtienda", Valor = producto.Idtienda, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idsublinea", Valor = producto.Idsublinea, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@idmarca", Valor = producto.Idmarca, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@nombre", Valor = producto.Nombre, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@modelo", Valor = producto.Modelo, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@precioa", Valor = producto.Precioa, Tipo = DbType.Decimal, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@preciob", Valor = producto.Preciob, Tipo = DbType.Decimal, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@precioc", Valor = producto.Precioc, Tipo = DbType.Decimal, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@imagen", Valor = producto.RutaImagen, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@meses", Valor = producto.MesesGarantia, Tipo = DbType.Int64, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@utilizaImagen", Valor = producto.UtilizaImagen, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@concaracteristica", Valor = producto.ConCaracteristica, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@presentacion", Valor = producto.Presentacion, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@esreciente", Valor = producto.EsReciente, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@descuento", Valor = producto.Descuento, Tipo = DbType.Decimal, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@utilizamarca", Valor = producto.UtilizaMarca, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@ultimocosto", Valor = producto.Ultimocosto, Tipo = DbType.Decimal, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@aplicaserie", Valor = producto.AplicaSerie, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@codigo", Valor = producto.Codigo, Tipo = DbType.String, Out = false });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (caracteristicasDetalleEliminacion != null && caracteristicasDetalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idproducto = producto.Idproducto;

                        foreach (MCaracteristicasProducto item in caracteristicasDetalleEliminacion)
                        {

                            item.Idproducto = idproducto;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "spsave_caracteristicaproducto";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = item.Idtienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pidproducto", Valor = item.Idproducto, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@ptitulo", Valor = item.Titulo, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pdescripcion", Valor = item.Descripcion, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idcaracteristica", Valor = item.Idcaracteristica, Tipo = DbType.Int64, Out = false });
                            rpta = objExcute.UpsertTransaction(objProc1);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }

                        foreach (MCaracteristicasProducto item in caracteristicasDetalleInsercion)
                        {

                            item.Idproducto = idproducto;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "spsave_caracteristicaproducto";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = item.Idtienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pidproducto", Valor = item.Idproducto, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@ptitulo", Valor = item.Titulo, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pdescripcion", Valor = item.Descripcion, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idcaracteristica", Valor = item.Idcaracteristica, Tipo = DbType.Int64, Out = false });
                            rpta = objExcute.UpsertTransaction(objProc1);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }
                }

                if (caracteristicasDetalleEliminacion == null && caracteristicasDetalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idproducto = producto.Idproducto;

                       

                        foreach (MCaracteristicasProducto item in caracteristicasDetalleInsercion)
                        {

                            item.Idproducto = idproducto;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "spsave_caracteristicaproducto";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = item.Idtienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pidproducto", Valor = item.Idproducto, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@ptitulo", Valor = item.Titulo, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pdescripcion", Valor = item.Descripcion, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idcaracteristica", Valor = item.Idcaracteristica, Tipo = DbType.Int64, Out = false });
                            rpta = objExcute.UpsertTransaction(objProc1);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }
                }

                if (caracteristicasDetalleEliminacion != null && caracteristicasDetalleInsercion == null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idproducto = producto.Idproducto;

                        foreach (MCaracteristicasProducto item in caracteristicasDetalleEliminacion)
                        {

                            item.Idproducto = idproducto;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "spsave_caracteristicaproducto";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pidtienda", Valor = item.Idtienda, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pidproducto", Valor = item.Idproducto, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@ptitulo", Valor = item.Titulo, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@pdescripcion", Valor = item.Descripcion, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int64, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@idcaracteristica", Valor = item.Idcaracteristica, Tipo = DbType.Int64, Out = false });
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

                    if (producto.ActivarImagen.Equals("activar"))
                    {
                        if (producto.RutaImagenEliminacion != "") //significa que si tiene imagen el producto
                        {
                            //entonces eleimina la imagen anterioro e inserta la imagen nueva
                            System.IO.File.Delete("./assets/ImagenesProductos/" + producto.RutaImagenEliminacion); 
                            System.IO.File.Copy(producto.RutaImagenInsercion, "./assets/ImagenesProductos/" + producto.RutaImagen);
                            System.IO.File.Delete("./assets/ImagenesTemporal/" + producto.RutaImagenEliminacion);
                        }
                        else//de lo contario significa que no tiene imagen
                        {
                            //entonces guarda la nueva imagen
                            System.IO.File.Copy(producto.RutaImagenInsercion, "./assets/ImagenesProductos/" + producto.RutaImagen);
                        }
                    }
                    if (producto.ActivarImagen.Equals("desactivar"))
                    {
                        if (producto.RutaImagenEliminacion != "") //significa que si tiene imagen el producto
                        {
                            //entonces eleimina la imagen anterioro e inserta la imagen nueva
                            System.IO.File.Delete("./assets/ImagenesProductos/" + producto.RutaImagenEliminacion);
                            System.IO.File.Delete("./assets/ImagenesTemporal/" + producto.RutaImagenEliminacion);
                        }
                     
                    }

                    if (producto.ActivarImagen.Equals("neutro"))
                    {
                        if (producto.RutaImagenEliminacion != "") //significa que si tiene imagen el producto
                        {
                            //entonces eleimina la imagen anterioro e inserta la imagen nueva
                            //System.IO.File.Delete("./assets/ImagenesProductos/" + producto.RutaImagenEliminacion);
                            //System.IO.File.Copy(producto.RutaImagenInsercion, "./assets/ImagenesProductos/" + producto.RutaImagen);
                            System.IO.File.Delete("./assets/ImagenesTemporal/" + producto.RutaImagenEliminacion);
                        }
                    }        

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
    }
}
