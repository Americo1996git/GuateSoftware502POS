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
    public class ControllerCliente
    {
        public static int IdCliente = 0;
        public static string Nombres = "";
        public static string Apellidos = "";
        public static string Nit = "_";
        public static string Telefono = "_";
        public static string Direccion = "_";

        public static string GuardarCliente(MCliente objMCliente,List<MTelefonoCliente> detalleInsercion)
        {


            string rpta = "";
            MExecute objExcute = new MExecute();
            MProcedimiento objProc = new MProcedimiento();
            try
            {
                objProc.NombreProcedimiento = "SPSave_Cliente";
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@id_cliente",
                    Valor = objMCliente.idCliente,
                    Tipo = DbType.Int32,
                    Out = true
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "id_estado_civil",
                    Valor = objMCliente.idEstadoCivil,
                    Tipo = DbType.Int32,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@id_cliente_subgrupo",
                    Valor = objMCliente.IdSubGrupo,
                    Tipo = DbType.Int32,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@id_usuario_creacion",
                    Valor = objMCliente.IdUsuario,
                    Tipo = DbType.Int32,
                    Out = false
                });


                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "dpi",
                    Valor = objMCliente.identificacion,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@nombres",
                    Valor = objMCliente.Nombres,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@apellidos",
                    Valor = objMCliente.Apellidos,
                    Tipo = DbType.String,
                    Out = false
                });
              
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "fecha_nacimiento",
                    Valor = objMCliente.fechaNacimiento,
                    Tipo = DbType.Date,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "direccion",
                    Valor = objMCliente.direccion,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "email",
                    Valor = objMCliente.email,
                    Tipo = DbType.String,
                    Out = false
                });
          
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "empresa_labora",
                    Valor = objMCliente.empresaLabora,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "cargo",
                    Valor = objMCliente.cargo,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "nit",
                    Valor = objMCliente.nit,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "maneja_cuenta_banco",
                    Valor = objMCliente.manejaCuentaBanco,
                    Tipo = DbType.Boolean,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "negocio_propio",
                    Valor = objMCliente.negocioPropio,
                    Tipo = DbType.Boolean,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "tipo_negocio",
                    Valor = objMCliente.tipoNegocio,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "tiempo_negocio",
                    Valor = objMCliente.tiempoNegocio,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "cantidad_hijos",
                    Valor = objMCliente.cantidadHijos,
                    Tipo = DbType.Int32,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "cantidad_aportes_familia",
                    Valor = objMCliente.cantidadAportesFamilia,
                    Tipo = DbType.Double,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "casa_propia",
                    Valor = objMCliente.casaPropia,
                    Tipo = DbType.Boolean,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "tiempo_de_residir",
                    Valor = objMCliente.tiempoResidir,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "trabaja_pareja",
                    Valor = objMCliente.trabajaPareja,
                    Tipo = DbType.Boolean,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "trabajo_pareja",
                    Valor = objMCliente.trabajoPareja,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "descripcion",
                    Valor = objMCliente.descripcion,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@esFiador",
                    Valor = objMCliente.EsFiador,
                    Tipo = DbType.Boolean,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@direccion_fiscal",
                    Valor = objMCliente.DireccionFiscal,
                    Tipo = DbType.String,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@razon_social",
                    Valor = objMCliente.RazonSocial,
                    Tipo = DbType.String,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@con_telefonos",
                    Valor = objMCliente.ConTelefonos,
                    Tipo = DbType.Boolean,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@limite_credito",
                    Valor = objMCliente.LimiteDeCredito,
                    Tipo = DbType.Decimal,
                    Out = false
                });



                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@con_observaciones",
                    Valor = objMCliente.ConObservaciones,
                    Tipo = DbType.Boolean,
                    Out = false
                });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        int idcliente = Convert.ToInt32(objExcute.ParametroDeSalida("@id_cliente"));
                        IdCliente = idcliente;
                        foreach (MTelefonoCliente item in detalleInsercion)
                        {

                            item.IdCliente = idcliente;
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_TelefonoClientes";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = item.IdCliente, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = item.Descripcion, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@telefono", Valor = item.Telefono, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_telefono", Valor = item.IdTelefon, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int32, Out = false });
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

                    Nombres = objMCliente.Nombres;
                    Apellidos = objMCliente.Apellidos;
                    Nit = objMCliente.nit;
                    Telefono = objMCliente.Telefono;
                    Direccion = objMCliente.direccion;
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

        public static string ActualizarCliente(MCliente objMCliente, List<MTelefonoCliente> detalleInsercion, List<MTelefonoCliente> detalleEliminacion)
        {
            string rpta = "";
            MExecute objExcute = new MExecute();
            MProcedimiento objProc = new MProcedimiento();
            try
            {
                objProc.NombreProcedimiento = "SPUpdate_Cliente";
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@id_cliente",
                    Valor = objMCliente.idCliente,
                    Tipo = DbType.Int32,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "id_estado_civil",
                    Valor = objMCliente.idEstadoCivil,
                    Tipo = DbType.Int32,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@id_cliente_subgrupo",
                    Valor = objMCliente.IdSubGrupo,
                    Tipo = DbType.Int32,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@id_usuario_creacion",
                    Valor = objMCliente.IdUsuario,
                    Tipo = DbType.Int32,
                    Out = false
                });


                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "dpi",
                    Valor = objMCliente.identificacion,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@nombres",
                    Valor = objMCliente.Nombres,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@apellidos",
                    Valor = objMCliente.Apellidos,
                    Tipo = DbType.String,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "fecha_nacimiento",
                    Valor = objMCliente.fechaNacimiento,
                    Tipo = DbType.Date,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "direccion",
                    Valor = objMCliente.direccion,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "email",
                    Valor = objMCliente.email,
                    Tipo = DbType.String,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "empresa_labora",
                    Valor = objMCliente.empresaLabora,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "cargo",
                    Valor = objMCliente.cargo,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "nit",
                    Valor = objMCliente.nit,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "maneja_cuenta_banco",
                    Valor = objMCliente.manejaCuentaBanco,
                    Tipo = DbType.Boolean,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "negocio_propio",
                    Valor = objMCliente.negocioPropio,
                    Tipo = DbType.Boolean,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "tipo_negocio",
                    Valor = objMCliente.tipoNegocio,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "tiempo_negocio",
                    Valor = objMCliente.tiempoNegocio,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "cantidad_hijos",
                    Valor = objMCliente.cantidadHijos,
                    Tipo = DbType.Int32,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "cantidad_aportes_familia",
                    Valor = objMCliente.cantidadAportesFamilia,
                    Tipo = DbType.Double,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "casa_propia",
                    Valor = objMCliente.casaPropia,
                    Tipo = DbType.Boolean,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "tiempo_de_residir",
                    Valor = objMCliente.tiempoResidir,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "trabaja_pareja",
                    Valor = objMCliente.trabajaPareja,
                    Tipo = DbType.Boolean,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "trabajo_pareja",
                    Valor = objMCliente.trabajoPareja,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "descripcion",
                    Valor = objMCliente.descripcion,
                    Tipo = DbType.String,
                    Out = false
                });
                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@esFiador",
                    Valor = objMCliente.EsFiador,
                    Tipo = DbType.Boolean,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@direccion_fiscal",
                    Valor = objMCliente.DireccionFiscal,
                    Tipo = DbType.String,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@razon_social",
                    Valor = objMCliente.RazonSocial,
                    Tipo = DbType.String,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@con_telefonos",
                    Valor = objMCliente.ConTelefonos,
                    Tipo = DbType.Boolean,
                    Out = false
                });

                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@limite_credito",
                    Valor = objMCliente.LimiteDeCredito,
                    Tipo = DbType.Decimal,
                    Out = false
                });



                objProc.Parametros.Add(new MParametro
                {
                    Nombre = "@con_observaciones",
                    Valor = objMCliente.ConObservaciones,
                    Tipo = DbType.Boolean,
                    Out = false
                });
                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);

                if (detalleInsercion != null)
                {
                    if (rpta.Equals("OK"))
                    {
                        foreach (MTelefonoCliente item in detalleEliminacion)
                        {


                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_TelefonoClientes";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = item.IdCliente, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = item.Descripcion, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@telefono", Valor = item.Telefono, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_telefono", Valor = item.IdTelefon, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int32, Out = false });
                            rpta = objExcute.UpsertTransaction(objProc1);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }

                        foreach (MTelefonoCliente item in detalleInsercion)
                        {

     
                            MProcedimiento objProc1 = new MProcedimiento();
                            objProc1.NombreProcedimiento = "SPSave_TelefonoClientes";
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = item.IdCliente, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@descripcion", Valor = item.Descripcion, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@telefono", Valor = item.Telefono, Tipo = DbType.String, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@id_telefono", Valor = item.IdTelefon, Tipo = DbType.Int32, Out = false });
                            objProc1.Parametros.Add(new MParametro { Nombre = "@opcion", Valor = item.Opcion, Tipo = DbType.Int32, Out = false });
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


        public static DataTable MostrarEstadoCivil()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_EstadoCivil";
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarGrupo()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_Grupo";
            return objExcute.Consultar(objProc);

        }

        public static DataTable MostrarClientes()
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_ListaDeTodosLosClientes";
            return objExcute.Consultar(objProc);

        }


        public static DataTable MostrarSubGrupo(int idgrupo)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPMostrar_SubGrupo";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_grupo", Valor = idgrupo, Tipo = DbType.Int32, Out = false });
            return objExcute.Consultar(objProc);

        }

        public static string CrearRapido(int id_tienda, string nombres, string apellidos,string nit,string telefono,string direccion,int id_cliente)
        {

            string rpta = "";
            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            try
            {
                Nombres = nombres;
                Apellidos = apellidos;
                Nit = nit;
                Telefono = telefono;
                Direccion = direccion;
                objProc.NombreProcedimiento = "SPSave_CrearClienteRapido";
                objProc.Parametros.Add(new MParametro { Nombre = "@id_tienda", Valor = id_tienda, Tipo = DbType.Int32, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@nombres", Valor = nombres, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@apellidos", Valor = apellidos, Tipo = DbType.String, Out = false });
                objProc.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = id_cliente, Tipo = DbType.Int32, Out = true });

                objExcute.IniciarTran();
                rpta = objExcute.UpsertTransaction(objProc);
                if (rpta.Equals("OK"))
                {
                    IdCliente = Convert.ToInt32(objExcute.ParametroDeSalida("@id_cliente"));
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


        public static string BloquerCliente(int id_cliente, int id_estado_cliente,string estado_bloqueo,string codigo_empresa)
        {

            MProcedimiento objProc = new MProcedimiento();
            MExecute objExcute = new MExecute();
            objProc.NombreProcedimiento = "SPSave_BloquearCliente";
            objProc.Parametros.Add(new MParametro { Nombre = "@id_cliente", Valor = id_cliente, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@id_estado_cliente", Valor = id_estado_cliente, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@estado_bloqueo", Valor = estado_bloqueo, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new MParametro { Nombre = "@codigo_empresa", Valor = codigo_empresa, Tipo = DbType.String, Out = false });
            return objExcute.Upsert(objProc);

        }
    }
}
