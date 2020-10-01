using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ViewGuate502
{
    public partial class DashBoard : DevExpress.XtraEditors.XtraForm
    {
        public string tienda;
        public string usuario;

        Productos.FormProductos productos;
        Ventas.VentaForm ventas;
        Ventas.Complementos.AgregarRecibo agregarRecibo;
        Ventas.Reimpresion.ReimpresionFacturas reimpresionFacturas;
        Ventas.Reimpresion.ReimpresionEnvios reimpresionEnvios;
        Ventas.Reimpresion.ReimpresionRecibos reimpresionRecibos;
        Ventas.Anulacion.AnulacionFacturas anulacionFacturas;
        Ventas.Anulacion.AnulacionEnvios anulacionEnvios;
        Ventas.Anulacion.AnulacionRecibos anulacionRecibos;
        Ventas.Reportes.Reportes reportes;
        Ventas.Consultas.Series series = new Ventas.Consultas.Series();
        Ventas.Consultas.Proformas Proformas = new Ventas.Consultas.Proformas();
        Ventas.Consultas.HistoricoSeries historicoSeries = new Ventas.Consultas.HistoricoSeries();
        Auditoria.Pendientes pendientes = new Auditoria.Pendientes();
        Auditoria.Escalados escalados = new Auditoria.Escalados();
        Auditoria.Finalizados finalizados = new Auditoria.Finalizados();
        Auditoria.Documentacion.Pendientes_doc pendientes_doc = new Auditoria.Documentacion.Pendientes_doc();
        Auditoria.Documentacion.EnRevision_doc enRevision = new Auditoria.Documentacion.EnRevision_doc();
        Auditoria.Documentacion.Finalizados_doc finalizados_doc = new Auditoria.Documentacion.Finalizados_doc();
        CuentasxCobrar.Formularios.BuscarCreditoCliente buscarCreditoCliente = new CuentasxCobrar.Formularios.BuscarCreditoCliente();
        Ventas.RealizarVenta VentaContado = new Ventas.RealizarVenta(1);
        Ventas.RealizarVenta VentaCredito = new Ventas.RealizarVenta(2);

        //_______________________AUTOR DEL CODIGO: DANEIL TZUNUN______________________________________
        private static DashBoard _Instancia;
        //____________________________________________________________________________________________

        public DashBoard()
        {
            InitializeComponent();
        }

        public static DashBoard GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new DashBoard();
            }
            return _Instancia;
        }
        void UsarMenusConTeclas(string menu)
        {
            if (menu.Equals("EXISTENCIAS"))
            {
                ProductosEnBodega.FormProductosEnBodega productos = new ProductosEnBodega.FormProductosEnBodega();
                productos.MdiParent = this;
                productos.Show();
            }
            if (menu.Equals("MAESTRO DE PRODUCTOS"))
            {
                MaestroProductos.FormMaestro maestro = new MaestroProductos.FormMaestro();
                maestro.ShowDialog();
            }
            if (menu.Equals("DOCUMENTOS OPERADOS"))
            {
                Ingresos.FormImprimirDocumento modal = new Ingresos.FormImprimirDocumento();
                modal.ShowDialog();

            }
            if (menu.Equals("CONTADO"))
            {
                if (Application.OpenForms["Contado"] != null)
                {
                    VentaContado.BringToFront();
                }
                else
                {
                    VentaContado = new Ventas.RealizarVenta(1);
                    VentaContado.MdiParent = this;
                    VentaContado.Show();
                }

            }
            if (menu.Equals("CREDITO"))
            {
                if (Application.OpenForms["Credito"] != null)
                {
                    VentaCredito.BringToFront();
                }
                else
                {
                    VentaCredito = new Ventas.RealizarVenta(2);
                    VentaCredito.MdiParent = this;
                    VentaCredito.Show();
                }

            }

            if (menu.Equals("CONSULTAR CREDITOS"))
            {
                bool abrir = true;
                Cobros.FormBuscarCreditoPorCliente modal = new Cobros.FormBuscarCreditoPorCliente(1,this);
                modal.ShowDialog();
                if (!modal.pagar)
                {
                    abrir = false;
                }

                if (abrir)
                {
                    Cobros.FormCobros cobros = Cobros.FormCobros.GetInstancia(this);
                    cobros.MdiParent = this;
                    cobros.Show();
                }
            }
            if (menu.Equals("CONSULTAR OTROS MOVIMIENTOS"))
            {
                bool abrir = true;
                Cobros.FormBuscarCreditoPorCliente modal = new Cobros.FormBuscarCreditoPorCliente(2,this);
                modal.ShowDialog();
                if (!modal.pagar)
                {
                    abrir = false;
                }

                if (abrir)
                {
                    Cobros.FormCobros cobros = Cobros.FormCobros.GetInstancia(this);
                    cobros.MdiParent = this;
                    cobros.Show();
                }
            }


            //____________________________________________________________________________
            //____________________________________________________________________________
            //____________________________________________________________________________
            //if (menu.Equals("INGRESAR PRODUCTOS POR ORDEN DE COMPRA"))
            //{
            //    Ingresos.FormIngresosMercaderia ingreso = Ingresos.FormIngresosMercaderia.GetInstancia();
            //    ingreso.MdiParent = this;
            //    ingreso.Show();
            //}
            //if (menu.Equals("INGRESAR PRODUCTOS POR TRASLADO ENTRE TIENDAS"))
            //{
            //    Ingresos.FormIngresoPorTraslado traslados = Ingresos.FormIngresoPorTraslado.GetInstancia(1);
            //    traslados.id_tipo_de_documento = 2; // ingreso por traslado entre tiendas
            //    traslados.id_tipo_de_Salida = 4;
            //    traslados.titulo_de_formulario = "INGRESAR PRODUCTOS POR TRASLADO ENTRE TIENDAS";
            //    traslados.MdiParent = this;
            //    traslados.Show();
            //}
            //if (menu.Equals("INGRESAR PRODUCTOS POR TRASLADO ENTRE BODEGAS"))
            //{
            //    Ingresos.FormIngresoPorTraslado traslados = new Ingresos.FormIngresoPorTraslado(2);
            //    traslados.id_tipo_de_documento = 3; // ingreso por trslado entre bodega
            //    traslados.id_tipo_de_Salida = 5;
            //    traslados.titulo_de_formulario = "INGRESAR PRODUCTOS POR TRASLADO ENTRE BODEGAS";
            //    traslados.MdiParent = this;
            //    traslados.Show();
            //}
            //if (menu.Equals("TRASLADAR PRODUCTOS A OTRAS TIENDAS"))
            //{
            //    Movimientos.FormMovimientos movimientos = Movimientos.FormMovimientos.GetInstancia();
            //    movimientos.id_tipo_de_sub_traslado = 1;
            //    movimientos.id_tipo_de_documento = 4;
            //    movimientos.MdiParent = this;
            //    movimientos.Show();
            //}
            //if (menu.Equals("TRASLADAR PRODUCTOS A OTRAS BODEGAS"))
            //{
            //    Movimientos.FormMovimientos movimientos = Movimientos.FormMovimientos.GetInstancia();
            //    movimientos.id_tipo_de_sub_traslado = 2;
            //    movimientos.id_tipo_de_documento = 5;
            //    movimientos.MdiParent = this;
            //    movimientos.Show();

            //}
        }

        private void barButtonItemLinea_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ConfigGenerales.FormAgregar agregar = new ConfigGenerales.FormAgregar("Linea", "Agregar");
            agregar.ShowDialog();
            //Linea.FormNuevaLinea form = new Linea.FormNuevaLinea();
            //form.ShowDialog();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            this.barSubItemTienda.Caption = "TIENDA: "+tienda;
            //this.barStaticItemUser.Caption = "USUARIO: "+usuario;
    
        }

        private void barButtonItemSubLinea_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ConfigGenerales.FormAgregar agregar = new ConfigGenerales.FormAgregar("Sub linea", "Agregar");
            agregar.ShowDialog();
            //Sublinea.FormSublinea form = new Sublinea.FormSublinea();
            //form.ShowDialog();
        }

        private void barButtonItemMarca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ConfigGenerales.FormAgregar agregar = new ConfigGenerales.FormAgregar("Marca", "Agregar");
            agregar.ShowDialog();
            //Marca.FormNuevaMarca form = new Marca.FormNuevaMarca();
            //form.ShowDialog();
        }

        private void barButtonItemProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Productos.FormProductos agregar = new Productos.FormProductos("Agregar");
            agregar.MdiParent = this;
            agregar.Show();
        }

        private void barButtonItemBodega_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ConfigGenerales.FormAgregar agregar = new ConfigGenerales.FormAgregar("Bodega", "Agregar");
            agregar.ShowDialog();
            //Bodegas.FormBodegas form = new Bodegas.FormBodegas();
            //form.ShowDialog();
        }

        private void barButtonItemLineas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ConfigGenerales.FormVerListas lista = new ConfigGenerales.FormVerListas("Lineas");
            lista.ShowDialog();
        }

        private void barButtonItemSubLineas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ConfigGenerales.FormVerListas lista = new ConfigGenerales.FormVerListas("Sub lineas");
            lista.ShowDialog();
        }

        private void barButtonItemMarcas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ConfigGenerales.FormVerListas lista = new ConfigGenerales.FormVerListas("Marcas");
            lista.ShowDialog();
        }

        private void barButtonItemBodegas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ConfigGenerales.FormVerListas lista = new ConfigGenerales.FormVerListas("Bodegas");
            lista.ShowDialog();
        }

        private void barButtonItemProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Productos.FormProductos agregar = new Productos.FormProductos("Lista");
            agregar.MdiParent = this;
            agregar.Show();
        }

        private void barButtonItemAgregarProductosOC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ingresos.FormIngresosMercaderia ingreso = Ingresos.FormIngresosMercaderia.GetInstancia();
            ingreso.MdiParent = this;
            ingreso.Show();
        }

        private void barButtonItemAgregarProductosTraladosTiendas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ingresos.FormIngresoPorTraslado traslados = Ingresos.FormIngresoPorTraslado.GetInstancia(1);
            traslados.id_tipo_de_documento = 2; // ingreso por traslado entre tiendas
            traslados.id_tipo_de_Salida = 4;
            traslados.titulo_de_formulario = "INGRESAR PRODUCTOS POR TRASLADO ENTRE TIENDAS";
            traslados.MdiParent = this;
            traslados.Show();
        }

        private void barButtonItemAgregarProductosTrasladosBodegas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ingresos.FormIngresoPorTraslado traslados = new Ingresos.FormIngresoPorTraslado(2);
            traslados.id_tipo_de_documento = 3; // ingreso por trslado entre bodega
            traslados.id_tipo_de_Salida = 5;
            traslados.titulo_de_formulario = "INGRESAR PRODUCTOS POR TRASLADO ENTRE BODEGAS";
            traslados.MdiParent = this;
            traslados.Show();
        }

        private void barButtonItemTrasladarProductosTiendas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Movimientos.FormMovimientos movimientos = Movimientos.FormMovimientos.GetInstancia();
            movimientos.id_tipo_de_sub_traslado = 1;
            movimientos.id_tipo_de_documento = 4;
            movimientos.MdiParent = this;
            movimientos.Show();
        }

        private void barButtonItemTrasladarProductosBodegas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Movimientos.FormMovimientos movimientos = Movimientos.FormMovimientos.GetInstancia();
            movimientos.id_tipo_de_sub_traslado = 2;
            movimientos.id_tipo_de_documento = 5;
            movimientos.MdiParent = this;
            movimientos.Show();
        }

        private void barButtonItemRepCatalogoProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Productos.FormProductos form = new Productos.FormProductos("Catalogo");
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItemVerExistencias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductosEnBodega.FormProductosEnBodega productos = new ProductosEnBodega.FormProductosEnBodega();
            productos.MdiParent = this;
            productos.Show();
        }

        private void barButtonItemRepMestroProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MaestroProductos.FormMaestro maestro = new MaestroProductos.FormMaestro();
            maestro.ShowDialog();
        }

        private void barButtonItemRequisicion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Requisicioes.FormRequisicion requisiciones = Requisicioes.FormRequisicion.GetInstancia();
            requisiciones.MdiParent = this;
            requisiciones.Show();
        }

        private void barButtonItemAddOc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GenerarOrdenCompra.FormGenerarOrdenCompra orden = GenerarOrdenCompra.FormGenerarOrdenCompra.GetInstacnia();
            orden.MdiParent = this;
            orden.Show();
        }

        private void barButtonItemRepProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Productos.FormModalReporteProductos imprimir = new Productos.FormModalReporteProductos();
            imprimir.ShowDialog();
        }

        private void barButtonItemRepPreciosCostos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HistorialDePrecios.FormHistorialPrecios modal = new HistorialDePrecios.FormHistorialPrecios();
            modal.ShowDialog();
        }

        private void barButtonItemRepRequisiciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Requisicioes.FormModalRangoDeFechas modal = new Requisicioes.FormModalRangoDeFechas();
            modal.ShowDialog();
        }

        private void barButtonItemDocumentosInventario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ingresos.FormImprimirDocumento modal = new Ingresos.FormImprimirDocumento();
            modal.ShowDialog();
        }

        private void barButtonItemVerificarOC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Verificaciones.FormVerifiacioesOC form = new Verificaciones.FormVerifiacioesOC();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItemReimprimirDocumento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Movimientos.FormReimprimirTraslado modal = new Movimientos.FormReimprimirTraslado("IMPRIMIR");
            modal.ShowDialog();
        }

        private void barButtonItemrReimprimirRequisicion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Requisicioes.FormModalRangoDeFechas modal = new Requisicioes.FormModalRangoDeFechas();
            modal.tipo_impresion = 1;
            modal.ShowDialog();
        }

        private void barButtonItemReimprimirOC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reimpresiones.FormOrdenesCompra modal = new Reimpresiones.FormOrdenesCompra();
            modal.ShowDialog();
        }

        private void barButtonItemEditarRequisicion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Requisicioes.FormEditarRequisicion form = Requisicioes.FormEditarRequisicion.GetInstancia();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItemBuscarSeriesProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Buscadores.FormSeriesPorDocumento form = new Buscadores.FormSeriesPorDocumento();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItemCorregirSereisProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Movimientos.FormReimprimirTraslado modal = new Movimientos.FormReimprimirTraslado("EDITAR");
            modal.ShowDialog();
        }

        private void barButtonItemCierreMensual_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cierre.FormCierre modal = new Cierre.FormCierre(this);
            modal.ShowDialog();
        }

        private void barButtonItemVentaContado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Contado"] != null)
            {
                VentaContado.BringToFront();
            }
            else
            {
                VentaContado = new Ventas.RealizarVenta(1);
                VentaContado.MdiParent = this;
                VentaContado.Show();
            }

            //Ventas.RealizarVenta VentaContado = Ventas.RealizarVenta.GetInstancia(1);
            //VentaContado.MdiParent = this;
            //VentaContado.Show();
        }

        private void barButtonItemVentaCredito_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Credito"] != null)
            {
                VentaCredito.BringToFront();
            }
            else
            {
                VentaCredito = new Ventas.RealizarVenta(2);
                VentaCredito.MdiParent = this;
                VentaCredito.Show();
            }
            //Ventas.RealizarVenta  VentaCredito = Ventas.RealizarVenta.GetInstancia(2);
            //VentaCredito.MdiParent = this;
            //VentaCredito.Show();
        }

        private void barButtonItemNuevoRecibo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (Application.OpenForms["AgregarRecibo"] != null)
            {

                agregarRecibo.BringToFront();
            }
            else
            {
                agregarRecibo = new Ventas.Complementos.AgregarRecibo();
                agregarRecibo.MdiParent = this;
                agregarRecibo.Show();

            }
        }

        private void barButtonItemReimprimirFactura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["ReimpresionFacturas"] != null)
            {

                reimpresionFacturas.BringToFront();

            }
            else
            {

                reimpresionFacturas = new Ventas.Reimpresion.ReimpresionFacturas();
                reimpresionFacturas.MdiParent = this;
                reimpresionFacturas.Show();
            }
        }

        private void barButtonItemReimprimirEnvio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["ReimpresionEnvios"] != null)
            {

                reimpresionEnvios.BringToFront();

            }
            else
            {

                reimpresionEnvios = new Ventas.Reimpresion.ReimpresionEnvios();
                reimpresionEnvios.MdiParent = this;
                reimpresionEnvios.Show();
            }
        }

        private void barButtonItemReimprimirRecibo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["ReimpresionRecibos"] != null)
            {

                reimpresionRecibos.BringToFront();

            }
            else
            {

                reimpresionRecibos = new Ventas.Reimpresion.ReimpresionRecibos();
                reimpresionRecibos.MdiParent = this;
                reimpresionRecibos.Show();
            }
        }

        private void barButtonItemReportes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Reportes"] != null)
            {
                reportes.BringToFront();
            }
            else
            {

                reportes = new Ventas.Reportes.Reportes();
                reportes.MdiParent = this;
                reportes.Show();
            }
        }

        private void barButtonItemConsultarSeries_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Series"] != null)
            {
                series.BringToFront();
            }
            else
            {
                series = new Ventas.Consultas.Series();
                series.MdiParent = this;
                series.Show();
            }
        }

        private void barButtonItemConsultarProformas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Proformas"] != null)
            {
                series.BringToFront();
            }
            else
            {
                Proformas = new Ventas.Consultas.Proformas();
                Proformas.MdiParent = this;
                Proformas.Show();
            }
        }

        private void barButtonItemConsultarHistorialSeries_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["HistoricoSeries"] != null)
            {
                historicoSeries.BringToFront();
            }
            else
            {
                historicoSeries = new Ventas.Consultas.HistoricoSeries();
                historicoSeries.MdiParent = this;
                historicoSeries.Show();
            }
        }

        private void barButtonItemProcesosCredito_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cobros.FormBuscarCreditoPorCliente modal = new Cobros.FormBuscarCreditoPorCliente(1,this);
            modal.ShowDialog();
        }

        private void barButtonItemProcesosOtrosMoviminetos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cobros.FormBuscarCreditoPorCliente modal = new Cobros.FormBuscarCreditoPorCliente(2,this);
            modal.ShowDialog();
        }

        private void barButtonItemConsultarBloquear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clientes.FormBloquerClientes modal = new Clientes.FormBloquerClientes();
            modal.ShowDialog();
        }

        private void barButtonItemConsultarClientesMorosos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportesIn.ClientesMorosos.FormModalMorosos modal = new ReportesIn.ClientesMorosos.FormModalMorosos();
            modal.ShowDialog();
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("DESEA SALIR DEL SISTEMA", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.No)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clientes.FormClientes cliente = Clientes.FormClientes.GetInstacnia();
            cliente.tipo_crecion = 0;
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void barBtnListaClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clientes.FormListaDeClientes clientes = new Clientes.FormListaDeClientes(this);
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void barButtonItemVerProveedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Proveedor.FormProveedor proveedor = new Proveedor.FormProveedor();
            proveedor.MdiParent = this;
            proveedor.Show();
        }

        private void barButtonItemCerrarSesion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormPantallaInicio login = new FormPantallaInicio();
            login.Show();
            this.Hide();
        }

        private void DashBoard_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.N))
            {
                Productos.FormProductos agregar = new Productos.FormProductos("Agregar");
                agregar.MdiParent = this;
                agregar.Show();
            }

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Shift) + Convert.ToInt32(Keys.L))
            {
                ConfigGenerales.FormAgregar agregar = new ConfigGenerales.FormAgregar("Linea", "Agregar");
                agregar.ShowDialog();
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Shift) + Convert.ToInt32(Keys.S))
            {
                ConfigGenerales.FormAgregar agregar = new ConfigGenerales.FormAgregar("Sub linea", "Agregar");
                agregar.ShowDialog();
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Shift) + Convert.ToInt32(Keys.M))
            {
                ConfigGenerales.FormAgregar agregar = new ConfigGenerales.FormAgregar("Marca", "Agregar");
                agregar.ShowDialog();
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Shift) + Convert.ToInt32(Keys.B))
            {
                ConfigGenerales.FormAgregar agregar = new ConfigGenerales.FormAgregar("Bodega", "Agregar");
                agregar.ShowDialog();
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Shift) + Convert.ToInt32(Keys.R))
            {
                Requisicioes.FormRequisicion requisiciones = Requisicioes.FormRequisicion.GetInstancia();
                requisiciones.MdiParent = this;
                requisiciones.Show();
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Shift) + Convert.ToInt32(Keys.O))
            {
                GenerarOrdenCompra.FormGenerarOrdenCompra orden = GenerarOrdenCompra.FormGenerarOrdenCompra.GetInstacnia();
                orden.MdiParent = this;
                orden.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnPagosPendientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cobros.PagosEnTransito.FormPagosTransito modal = Cobros.PagosEnTransito.FormPagosTransito.GetInstancia();
            modal.ShowDialog();
        }

        private void barBtnAnularRecibos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ventas.Anulacion.AnulacionRecibos modal = new Ventas.Anulacion.AnulacionRecibos();
            modal.ShowDialog();
        }

        private void barButtonItemAnularDocumentoOperado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Movimientos.FormReimprimirTraslado modal = new Movimientos.FormReimprimirTraslado("ANULAR");
            modal.ShowDialog();
        }

        private void DashBoard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                UsarMenusConTeclas("EXISTENCIAS");
            }
            if (e.KeyCode == Keys.F2)
            {
                UsarMenusConTeclas("MAESTRO DE PRODUCTOS");
            }
            if (e.KeyCode == Keys.F3)
            {
                UsarMenusConTeclas("DOCUMENTOS OPERADOS");
            }
            if (e.KeyCode == Keys.F4)
            {
                UsarMenusConTeclas("CONTADO");
            }
            if (e.KeyCode == Keys.F5)
            {
                UsarMenusConTeclas("CREDITO");
            }
        }

        private void barBtnNotificaciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Notificaciones.FormNotificaciones modal = new Notificaciones.FormNotificaciones();
            modal.ShowDialog();
        }

        private void btnBuscarPersonFiador_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cobros.Busquedas.FormCuatasVecesEsFiador modal = new Cobros.Busquedas.FormCuatasVecesEsFiador();
            modal.ShowDialog();
        }

        private void btnRevisionDeNotasDepositos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reportes.RevisionDepostiosNotas.FormRevisionDepositosNotas modal = new Reportes.RevisionDepostiosNotas.FormRevisionDepositosNotas();
            modal.ShowDialog();
        }

        private void btnRepCombranzasPagosEfectuados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportesIn.CobrosPagos.IngresosDiarios.FormModalAbrirReporte modal = new ReportesIn.CobrosPagos.IngresosDiarios.FormModalAbrirReporte("INGRESOS");
            modal.ShowDialog();
        }

        private void btnBancosAgregarCuentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Bancos.FormAgregarCuenta formAgregar = new Bancos.FormAgregarCuenta("AGREGAR");
            formAgregar.ShowDialog();
        }

        private void btnBancosVerCuentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Bancos.FormListaCuentas formLista = new Bancos.FormListaCuentas();
            formLista.ShowDialog();
        }

        private void btnBancosConfigurarPagos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Bancos.FormConfigurarPagos formConfig = new Bancos.FormConfigurarPagos();
            formConfig.ShowDialog();
        }

        private void btnAnalisisCredito_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRepCombranzasNotasCredito_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportesIn.CobrosPagos.IngresosDiarios.FormModalAbrirReporte modal = new ReportesIn.CobrosPagos.IngresosDiarios.FormModalAbrirReporte("NOTAS_CREDITO");
            modal.ShowDialog();
        }

        private void btnGastosAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SalidasDinero.Gastos.FormNuevoGasto modal = new SalidasDinero.Gastos.FormNuevoGasto("AGREGAR");
            modal.ShowDialog();
        }

        private void btnBancosCuadreDelDia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cuadres.FormCuadreDia modal = new Cuadres.FormCuadreDia();
            modal.ShowDialog();
        }

        private void btnGastosActualizacionDeGastos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SalidasDinero.Gastos.FormLista modal = new SalidasDinero.Gastos.FormLista("EDICION");
            modal.ShowDialog();
        }

        private void btnGastosReportes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SalidasDinero.Gastos.FormLista modal = new SalidasDinero.Gastos.FormLista("REPORTE");
            modal.ShowDialog();
        }

        private void btnCobranzasCuadreDiaHistorialCuadre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cuadres.FormVitacoraHistorial modal = new Cuadres.FormVitacoraHistorial();
            modal.ShowDialog();
        }

        private void btnCobranzasCalcularMoras_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cobros.FormCalcularMoras MODAL = new Cobros.FormCalcularMoras();
            MODAL.ShowDialog();
        }
    }
}