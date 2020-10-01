using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ViewGuate502.dbSoftwareGTDataSetTableAdapters;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using ControllerSoft502;
using MODELOS502;

namespace ViewGuate502.Ventas
{
    public partial class RealizarVenta : DevExpress.XtraEditors.XtraForm
    {
        int id_tipo_venta;
        dbSoftwareGTDataSet db = new dbSoftwareGTDataSet();
        tbl_vendedores_tiendaTableAdapter tbl_vendedores_tienda = new tbl_vendedores_tiendaTableAdapter();
        tbl_ventas_encTableAdapter tbl_ventas_enc = new tbl_ventas_encTableAdapter();
        tbl_ventas_detTableAdapter tbl_ventas_det = new tbl_ventas_detTableAdapter();
        tbl_vendedoresTableAdapter tbl_vendedores = new tbl_vendedoresTableAdapter();
        tbl_usuariosTableAdapter tbl_usuarios = new tbl_usuariosTableAdapter();
        tbl_autorizadores_tiendaTableAdapter tbl_autorizadores_tienda = new tbl_autorizadores_tiendaTableAdapter();
        tbl_autorizadores_creditoTableAdapter tbl_autorizadores_credito = new tbl_autorizadores_creditoTableAdapter();
        tbl_seriesTableAdapter tbl_series = new tbl_seriesTableAdapter();
        tbl_auditoria_ventasTableAdapter tbl_auditoria_ventas = new tbl_auditoria_ventasTableAdapter();
        tbl_auditoria_revision_doctosTableAdapter tbl_auditoria_revision_doctos = new tbl_auditoria_revision_doctosTableAdapter();
        tbl_recibos_anticiposTableAdapter tbl_recibos_anticipos = new tbl_recibos_anticiposTableAdapter();
        tbl_venta_fiadoresTableAdapter tbl_venta_fiadores = new tbl_venta_fiadoresTableAdapter();
        tbl_venta_abonosTableAdapter tbl_venta_abonos = new tbl_venta_abonosTableAdapter();
        //PagoCreditoDetalleTableAdapter pago_credito_detalle = new PagoCreditoDetalleTableAdapter();
        tbl_ventas_aprobacion_creditoTableAdapter tbl_ventas_aprobacion_credito = new tbl_ventas_aprobacion_creditoTableAdapter();
        tbl_ventas_promesas_pago_encTableAdapter tbl_ventas_promesas_pago_enc = new tbl_ventas_promesas_pago_encTableAdapter();
        tbl_ventas_promesas_pago_detTableAdapter tbl_ventas_promesas_pago_det = new tbl_ventas_promesas_pago_detTableAdapter();
        tbl_facturacion_encTableAdapter tbl_facturacion_enc = new tbl_facturacion_encTableAdapter();
        tbl_facturacion_detTableAdapter tbl_facturacion_det = new tbl_facturacion_detTableAdapter();
        Listado_clientesTableAdapter listado_clientes = new Listado_clientesTableAdapter();
        ExistenciaDetalleTableAdapter tbl_existencias = new ExistenciaDetalleTableAdapter();

        public List<Anticipo> anticipos = new List<Anticipo>();
        public List<Fiadores> fiadores = new List<Fiadores>();
        public List<Autorizaciones> autorizaciones = new List<Autorizaciones>();
        public List<Cuotas> cuotas = new List<Cuotas>();
        public string comentarios_aut = "";
        decimal total_venta = 0;
        public int cant_meses = 0;
        public decimal monto_financiar = 0;
        public DateTime a_partir_de = new DateTime();
        int id_venta_enc;

        int id_cliente = 0;

        //ErrorProvider errorProvider;
        object sndr = null;
        EventArgs evnt = null;
        public DataTable dt;

        //AUTOR DEL CODIGO: DANIEL AMERICO TZUNUN ACABAL
        public DataTable dtDetalleInsercion;
        public DataTable dtSeries;
        public DataTable dtSeriesCopia;
        DataTable dtValidarBloqueoCliente;

        private static RealizarVenta _Instancia;
        public DataTable dtProductos;
        int idbodega = 0;

        bool mostrar = true;
        bool validar_cliente = false;

        decimal total = 0; // esta variable es para sumar el total a pagar del detalle de productos o el total de la venta
        //__________________________________________________



        public RealizarVenta(int id_tv)
        {
            InitializeComponent();
            id_tipo_venta = id_tv;
        }


        //AUTOR DEL CODIGO: DANIEL AMERICO TZUNUN ACABAL
        public static RealizarVenta GetInstancia(int id_tv)
        {
            if (_Instancia == null)
            {
                _Instancia = new RealizarVenta(id_tv);
            }
            return _Instancia;
        }

        public void CrearTablaSeriesProductos()
        {

            dtSeries = new DataTable();
            dtSeries.Columns.Add("idproducto", typeof(int));
            dtSeries.Columns.Add("numero", typeof(int));
            dtSeries.Columns.Add("serie", typeof(string));
        }

        public void CrearTablaSeriesProductosCopia()
        {

            dtSeriesCopia = new DataTable();
            dtSeriesCopia.Columns.Add("idproducto", typeof(int));
            dtSeriesCopia.Columns.Add("numero", typeof(int));
            dtSeriesCopia.Columns.Add("serie", typeof(string));
        }



        void CrearTablaProductos()
        {
            dtProductos = new DataTable();
            dtProductos.Columns.Add("IdProducto", typeof(int));
            dtProductos.Columns.Add("Cantidad", typeof(int));
            dtProductos.Columns.Add("IdBodega", typeof(int));
        }
        //______________________________________________________
        //______________________________________________________
        //______________________________________________________

        private void RealizarVenta_Load(object sender, EventArgs e)
        {
            if (!Configuraciones.Configuraciones.InventarioCerrado())
            {
                tbidcliente.Text = "0";
                lcginfocliente.Enabled = false;
                lciinfocredito.Enabled = false;
                lciinfodeposito.Enabled = false;
                lcilistaproductos.Enabled = false;
                lcinuevaventa.Enabled = false;
            }
            else
            {
                tbidcliente.Text = "0";
                DataTable dtBodegas;
                dtBodegas = ControllerTrasladoTiedas.MostrarBodegaOrigen(Configuraciones.Configuraciones.idtienda);

                if (dtBodegas.Rows.Count > 0)
                {
                    lookUpEditBodegas.Properties.DataSource = dtBodegas;
                    lookUpEditBodegas.Properties.ValueMember = "idbodega";
                    lookUpEditBodegas.Properties.DisplayMember = "nombre";

                    lookUpEditBodegas.ItemIndex = 0;
                }

                //AUTOR DEL CODIGO: DANIEL AMERICO TZUNUN ACABAL
                CrearTablaSeriesProductos();
                CrearTablaSeriesProductosCopia();
                CrearTablaProductos();
                //_______________________________________________
                //_______________________________________________
                //_______________________________________________


                // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.tbl_tipos_pago' Puede moverla o quitarla según sea necesario.
                this.tbl_tipos_pagoTableAdapter.Fill(this.dbSoftwareGTDataSet.tbl_tipos_pago);
                sndr = sender;
                evnt = e;

                CargarTablas();
                if (id_tipo_venta == 1)
                {
                    this.Name = "Contado";
                    this.Text = "NUEVA VENTA DE CONTADO";
                    lyBuscarCliente.Text = "BUSCAR DPI/NOMBRES";
                    lcicrearanticipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciagregaranticipo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
                else
                {
                    this.Name = "Credito";
                    this.Text = "NUEVA VENTA AL CREDITO";
                    lyBuscarCliente.Text = "DPI";
                }

                tbfecha.Text = DateTime.Now.ToLongDateString();

                if (id_tipo_venta == 1)
                {
                    lciautorizador.Dispose();
                    lueautorizador.Dispose();
                    btnfiadores.Dispose();
                    btnautorizaciones.Dispose();
                    btncuotas.Dispose();
                    lciinfocredito.TextVisible = false;
                    lciinfocredito.GroupBordersVisible = false;
                    lciinfocredito.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }

                lciinfodeposito.TextVisible = false;
                lciinfodeposito.GroupBordersVisible = false;

                if (id_tipo_venta == 1)
                {
                    lciimpcontrato.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciimpcuotas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lyBuscarCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                }

                if (id_tipo_venta == 2)
                {
                    btnimpcontrato.Enabled = false;
                    btnimpcuotas.Enabled = false;
                    lyNuevoCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                }

                var vendedores = (from a in db.tbl_vendedores_tienda
                                  join b in db.tbl_vendedores on a.id_vendedor equals b.id_vendedor
                                  join c in db.tbl_usuarios on b.id_usuario equals c.id_usuario
                                  where a.id_tienda == Configuraciones.Configuraciones.idtienda &&
                                  a.activo == true
                                  select new
                                  {
                                      a.id_vendedor,
                                      c.nombre_usuario
                                  }).ToList();

                if (vendedores.Count > 0)
                {
                    luevendedor.Properties.DataSource = vendedores;
                    luevendedor.Properties.DisplayMember = "nombre_usuario";
                    luevendedor.Properties.ValueMember = "id_vendedor";

                    if (luevendedor.Properties.Columns.Count == 0)
                    {
                        luevendedor.Properties.Columns.Add(new LookUpColumnInfo("id_vendedor", "Id"));
                        luevendedor.Properties.Columns.Add(new LookUpColumnInfo("nombre_usuario", "Nombre"));
                    }

                    luevendedor.Properties.Columns[0].Visible = false;
                    //enable text editing 
                    luevendedor.Properties.TextEditStyle = TextEditStyles.Standard;
                }

                var autorizadores_tienda = (from a in db.tbl_autorizadores_tienda
                                            join b in db.tbl_autorizadores_credito on a.id_autorizador equals b.id_autorizador
                                            join c in db.tbl_usuarios on b.id_usuario equals c.id_usuario
                                            where a.id_tienda == Configuraciones.Configuraciones.idtienda
                                            select new
                                            {
                                                b.id_autorizador,
                                                c.nombre_usuario
                                            }).ToList();

                if (autorizadores_tienda.Count > 0)
                {
                    lueautorizador.Properties.DataSource = autorizadores_tienda;
                    lueautorizador.Properties.DisplayMember = "nombre_usuario";
                    lueautorizador.Properties.ValueMember = "id_autorizador";

                    if (lueautorizador.Properties.Columns.Count == 0)
                    {
                        lueautorizador.Properties.Columns.Add(new LookUpColumnInfo("id_autorizador", "Id"));
                        lueautorizador.Properties.Columns.Add(new LookUpColumnInfo("nombre_usuario", "Nombre"));
                    }

                    lueautorizador.Properties.Columns[0].Visible = false;
                    //enable text editing 
                    lueautorizador.Properties.TextEditStyle = TextEditStyles.Standard;
                }

                dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("IdBodega", typeof(int));
                dt.Columns.Add("IdProducto", typeof(int));
                dt.Columns.Add("Stock", typeof(int));
                dt.Columns.Add("sub_stock", typeof(int)); //<---- creado por el programador daniel
                dt.Columns.Add("Tienda", typeof(string));
                dt.Columns.Add("Bodega", typeof(string));
                dt.Columns.Add("Producto", typeof(string));
                dt.Columns.Add("Cod. Producto", typeof(string));
                dt.Columns.Add("Precio A", typeof(decimal));
                dt.Columns.Add("Precio B", typeof(decimal));
                dt.Columns.Add("Precio C", typeof(decimal));
                dt.Columns.Add("Descuento", typeof(decimal));
                dt.Columns.Add("PrecioUnitario", typeof(decimal));
                dt.Columns.Add("Cantidad", typeof(int));
                dt.Columns.Add("Sub-Total", typeof(decimal));
                dt.Columns.Add("NoSerie", typeof(string));

                gclistaproductos.DataSource = dt;

                for (int i = 0; i < 5; i++)
                {
                    gvlistadoproductos.Columns[i].Visible = false;
                }

                for (int i = 0; i < 12; i++)
                {
                    gvlistadoproductos.Columns[i].OptionsColumn.ReadOnly = true;
                    gvlistadoproductos.Columns[i].OptionsColumn.AllowEdit = false;
                }

                gvlistadoproductos.Columns[8].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvlistadoproductos.Columns[9].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvlistadoproductos.Columns[10].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvlistadoproductos.Columns[11].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvlistadoproductos.Columns[12].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvlistadoproductos.Columns[13].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvlistadoproductos.Columns[14].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvlistadoproductos.Columns[15].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;

                gvlistadoproductos.Columns[8].DisplayFormat.FormatString = "c2";
                gvlistadoproductos.Columns[9].DisplayFormat.FormatString = "c2";
                gvlistadoproductos.Columns[10].DisplayFormat.FormatString = "c2";
                gvlistadoproductos.Columns[11].DisplayFormat.FormatString = "c2";
                gvlistadoproductos.Columns[12].DisplayFormat.FormatString = "{0:n0} %";
                gvlistadoproductos.Columns[13].DisplayFormat.FormatString = "c2";
                gvlistadoproductos.Columns[14].DisplayFormat.FormatString = "{0:n0}";
                gvlistadoproductos.Columns[15].DisplayFormat.FormatString = "c2";
                gvlistadoproductos.Columns[15].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;

                gvlistadoproductos.Columns[14].OptionsColumn.ReadOnly = true;
                gvlistadoproductos.Columns[14].OptionsColumn.AllowEdit = false;
                gvlistadoproductos.BestFitColumns();
            }

            if (id_tipo_venta == 1)
            {
                Clientes.FormListaDeClientes modal = new Clientes.FormListaDeClientes(this);
                modal.btnEditar.Text = "AGREGAR";
                modal.ShowDialog();
                if (Convert.ToInt32(tbidcliente.Text) > 0)
                {
                    mostrar = true;
                    validar_cliente = true;
                }
                if (validar_cliente)
                {
                    ValidarCliente();
                }
            }

        }

        public void CargarTablas()
        {
            tbl_vendedores_tienda.Fill(db.tbl_vendedores_tienda);
            tbl_vendedores.Fill(db.tbl_vendedores);
            tbl_usuarios.Fill(db.tbl_usuarios);
            tbl_ventas_enc.Fill(db.tbl_ventas_enc);
            tbl_ventas_det.Fill(db.tbl_ventas_det);
            tbl_autorizadores_tienda.Fill(db.tbl_autorizadores_tienda);
            tbl_autorizadores_credito.Fill(db.tbl_autorizadores_credito);
            tbl_series.Fill(db.tbl_series);
            tbl_auditoria_ventas.Fill(db.tbl_auditoria_ventas);
            tbl_auditoria_revision_doctos.Fill(db.tbl_auditoria_revision_doctos);
            tbl_venta_fiadores.Fill(db.tbl_venta_fiadores);
            tbl_venta_abonos.Fill(db.tbl_venta_abonos);
            tbl_recibos_anticipos.Fill(db.tbl_recibos_anticipos);
            tbl_ventas_aprobacion_credito.Fill(db.tbl_ventas_aprobacion_credito);
            tbl_ventas_promesas_pago_enc.Fill(db.tbl_ventas_promesas_pago_enc);
            tbl_ventas_promesas_pago_det.Fill(db.tbl_ventas_promesas_pago_det);
            tbl_facturacion_enc.Fill(db.tbl_facturacion_enc);
            tbl_facturacion_det.Fill(db.tbl_facturacion_det);
            listado_clientes.Fill(db.Listado_clientes);
            tbl_existencias.Fill(db.ExistenciaDetalle);
        }

        void ValidarCliente()
        {
            string respuesta_bloqueo_empresa;
            dtValidarBloqueoCliente = ControllerVentas.ValidarBloqueoCliente(Convert.ToInt32(tbidcliente.Text));
            if (dtValidarBloqueoCliente.Rows.Count > 0)
            {
                respuesta_bloqueo_empresa = Convert.ToString(dtValidarBloqueoCliente.Rows[0]["codigo_empresa"]);

                if (respuesta_bloqueo_empresa == "F1")
                {
                    XtraMessageBox.Show("El cliente seleccionado se encuentra bloqueado en la empresa Pecul, se sugiere pueda contactar con dicha empresa para obtener más información.", "Realizando ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (respuesta_bloqueo_empresa == "A1")
                {
                    XtraMessageBox.Show("El cliente seleccionado se encuentra bloqueado en esta empresa. No es posible ligarlo a una venta.", "Realizando ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tbidcliente.Text = "0";
                tbcliente.Text = string.Empty;
                tbdireccion.Text = string.Empty;
                tbnit.Text = string.Empty;
                tbtelefono.Text = string.Empty;
            }
        }
        private void btncliente_Click(object sender, EventArgs e)
        {

            DataTable dtCliente = new DataTable();



            if (id_tipo_venta == 1)
            {
                Clientes.FormListaDeClientes modal = new Clientes.FormListaDeClientes(this);
                //modal.lyBtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                modal.btnEditar.Text = "AGREGAR";
                modal.ShowDialog();
                if (Convert.ToInt32(tbidcliente.Text) > 0)
                {
                    mostrar = true;
                    validar_cliente = true;
                }

            }
            if (id_tipo_venta == 2)
            {
                if (string.IsNullOrWhiteSpace(txtDpi.Text))
                {
                    mostrar = true;
                }
            }

            if (mostrar)
            {

                //if (id_tipo_venta == 1)
                //{
                //    validar_cliente = true;
                //}
                if (id_tipo_venta == 2)
                {
                    dtCliente = ControllerVentas.MostrarClientes(txtDpi.Text, "", "", 0);
                }

                if (dtCliente.Rows.Count > 0)
                {
                    tbidcliente.Text = Convert.ToString(dtCliente.Rows[0]["id_cliente"]);
                    id_cliente = Convert.ToInt32(dtCliente.Rows[0]["id_cliente"]);
                    tbcliente.Text = Convert.ToString(dtCliente.Rows[0]["nombre_cliente"]);
                    tbdireccion.Text = Convert.ToString(dtCliente.Rows[0]["direccion"]);
                    tbnit.Text = Convert.ToString(dtCliente.Rows[0]["nit"]);
                    tbtelefono.Text = Convert.ToString(dtCliente.Rows[0]["telefono"]);
                    validar_cliente = true;
                    //tbtelefono.Properties.DataSource = ControllerVentas.MostrarTelefonoDeCliente(Convert.ToInt32(tbidcliente.Text));
                    //tbtelefono.Properties.DisplayMember = "telefono";
                    //tbtelefono.Properties.ValueMember = "id_telefono";
                }
                if (validar_cliente)
                {
                    ValidarCliente();
                }

            }
        }

        private void btnlimpiarcliente_Click(object sender, EventArgs e)
        {
            //tbcliente.EditValue = null;
            tbidcliente.Text = "0";
            tbnit.EditValue = null;
            tbdireccion.EditValue = null;
            tbtelefono.EditValue = null;
            tbidcliente.EditValue = null;

            tbcliente.Enabled = true;
            tbnit.Enabled = true;
            tbdireccion.Enabled = true;
            tbtelefono.Enabled = true;
            tbidcliente.Enabled = true;
        }

        private void btnnuevaventa_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                LimpiarFormulario(control);
            }
            anticipos = new List<Anticipo>();
            fiadores = new List<Fiadores>();
            autorizaciones = new List<Autorizaciones>();
            dtProductos.Clear();

            cuotas = new List<Cuotas>();
            RealizarVenta_Load(sndr, evnt);

            btnimpcuotas.Enabled = false;
            btnimpcontrato.Enabled = false;
            tbcontrolventa.Enabled = true;
            btnfiadores.Enabled = true;
            btnautorizaciones.Enabled = true;
            luevendedor.Enabled = true;
            luetipopago.Enabled = true;
            btncliente.Enabled = true;
            btnlimpiarcliente.Enabled = true;
            btnguardar.Enabled = true;
            btnagregaranticipo.Enabled = true;
            btncrearanticipo.Enabled = true;
            btneliminarlinea.Enabled = true;
            gclistaproductos.Enabled = true;
            tbcliente.Enabled = true;
            tbnit.Enabled = true;
            tbdireccion.Enabled = true;
            tbtelefono.Enabled = true;
            btncuotas.Enabled = true;
        }

        public static void LimpiarFormulario(Control Ctrl)
        {
            foreach (Control ctrl in Ctrl.Controls)
            {
                BaseEdit edior = ctrl as BaseEdit;
                if (edior != null)
                    edior.EditValue = null;

                LimpiarFormulario(ctrl);//Recursive
            }

        }
        private void btnagregaranticipo_Click(object sender, EventArgs e)
        {
            Buscadores.BuscadorAnticipos buscadorAnticipos = new Buscadores.BuscadorAnticipos(1, null, this);
            buscadorAnticipos.ShowDialog();
        }

        private void btncrearanticipo_Click(object sender, EventArgs e)
        {
            Complementos.CrearAnticipo crearAnticipo = new Complementos.CrearAnticipo(id_tipo_venta, null, this);
            crearAnticipo.ShowDialog();
        }

        private void luetipopago_EditValueChanged(object sender, EventArgs e)
        {
            if (luetipopago.EditValue != null)
            {
                if (int.Parse(luetipopago.EditValue.ToString()) == 4)
                {
                    lciinfodeposito.TextVisible = true;
                    lciinfodeposito.GroupBordersVisible = true;
                    lciinfodeposito.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lcibancodep.ContentVisible = true;
                    lcinoboletadep.ContentVisible = true;
                    lcifechadep.ContentVisible = true;
                }
                else
                {
                    lciinfodeposito.TextVisible = false;
                    lciinfodeposito.GroupBordersVisible = false;
                    lciinfodeposito.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lcibancodep.ContentVisible = false;
                    lcinoboletadep.ContentVisible = false;
                    lcifechadep.ContentVisible = false;
                    tbbancodep.EditValue = null;
                    defechadep.EditValue = null;
                    tbnoboletadep.EditValue = null;
                }
            }
            else
            {
                lciinfodeposito.TextVisible = false;
                lciinfodeposito.GroupBordersVisible = false;
                lcibancodep.ContentVisible = false;
                lcinoboletadep.ContentVisible = false;
                lcifechadep.ContentVisible = false;
                tbbancodep.EditValue = null;
                defechadep.EditValue = null;
                tbnoboletadep.EditValue = null;
            }
        }

        private void tbcontrolventa_Leave(object sender, EventArgs e)
        {
            if (tbcontrolventa.EditValue != null)
            {
                int cv = int.Parse(tbcontrolventa.Text.Replace(",", ""));
                var cv_data = (from a in db.tbl_ventas_enc
                               where a.control_venta == cv &&
                               a.activo == true
                               select a).SingleOrDefault();

                if (cv_data != null)
                {
                    MessageBox.Show("El control de venta ingresado ya existe en la base de datos. Por favor, inténtalo nuevamente.", "¡Control de venta ya existente!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tbcontrolventa.EditValue = null;
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            ControlesARevisar();
        }

        private void ControlesARevisar()
        {
            int cant_errores = 0;
            int correlativo = 0;
            string serie_salida = "";
            List<Control> controles = new List<Control>();
            controles.Add(tbcliente);
            controles.Add(tbnit);
            controles.Add(tbdireccion);
            controles.Add(tbtelefono);
            controles.Add(tbcontrolventa);

            if (luetipopago.EditValue != null)
            {
                if (luetipopago.EditValue.ToString() == "4")
                {
                    controles.Add(tbbancodep);
                    controles.Add(defechadep);
                    controles.Add(tbnoboletadep);
                }
            }

            foreach (Control control in controles)
            {
                dxErrorProvider1.SetError(control, "");

                if (control.Text == null)
                {
                    dxErrorProvider1.SetError(control, "Este campo no puede ser vacío");
                    cant_errores++;
                }
                else
                {
                    if (control.Text == "")
                    {
                        dxErrorProvider1.SetError(control, "Este campo no puede ser vacío");
                        cant_errores++;
                    }
                }
            }

            dxErrorProvider1.SetError(luevendedor, "");
            if (luevendedor.EditValue == null)
            {
                dxErrorProvider1.SetError(luevendedor, "Seleccione un vendedor");
                cant_errores++;
            }

            dxErrorProvider1.SetError(luetipopago, "");
            if (luetipopago.EditValue == null)
            {
                dxErrorProvider1.SetError(luetipopago, "Seleccione un tipo de pago");
                cant_errores++;
            }

            if (id_tipo_venta > 1)
            {
                if (lueautorizador.EditValue == null)
                {
                    dxErrorProvider1.SetError(lueautorizador, "Seleccione un vendedor");
                    cant_errores++;
                }
            }

            if (id_tipo_venta == 2)
            {
                if (fiadores.Count == 0)
                {
                    dxErrorProvider1.SetError(btnfiadores, "Selecciona los fiadores correspondientes a esta venta.");
                    cant_errores++;
                    btnfiadores.Focus();
                }
                else if (autorizaciones.Count == 0)
                {
                    dxErrorProvider1.SetError(btnfiadores, "Selecciona las autorizaciones correspondientes a esta venta.");
                    cant_errores++;
                    btnautorizaciones.Focus();
                }
                else if (cuotas.Count == 0)
                {
                    dxErrorProvider1.SetError(btnfiadores, "Genera la distribución de cuotas correspondientes a esta venta.");
                    cant_errores++;
                    btncuotas.Focus();
                }
            }

            if (gvlistadoproductos.RowCount == 0 && cant_errores == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto");
                cant_errores++;
            }
            else
            {
                total_venta = 0;
                for (int i = 0; i < gvlistadoproductos.RowCount; i++)
                {
                    string precio_unitario = gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString();
                    string cantidad = gvlistadoproductos.GetRowCellValue(i, "Cantidad").ToString();
                    string no_serie = gvlistadoproductos.GetRowCellValue(i, "NoSerie").ToString();
                    decimal precio_c = decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "Precio C").ToString());
                    decimal descuento = decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "Descuento").ToString());
                    if (precio_unitario == "" || decimal.Parse(precio_unitario) == 0 || no_serie == "" || cantidad == "" || int.Parse(cantidad) == 0)
                    {
                        MessageBox.Show("Debe ingresar el Precio Unitario, Cantidad y/o Número de serie del producto en la línea " + (i + 1));
                        cant_errores++;
                        break;
                    }
                    else
                    {
                        decimal precio_menor = precio_c;
                        if (id_tipo_venta == 1)
                        {
                            if (descuento > 0)
                            {
                                precio_menor = (precio_c - (precio_c * (descuento / 100)));
                            }
                        }

                        if (decimal.Parse(precio_unitario) < precio_menor)
                        {
                            MessageBox.Show("El Precio Unitario no puede ser menor al Precio C con descuento en la línea " + (i + 1));
                            cant_errores++;
                            break;
                        }

                        total_venta = total_venta + decimal.Parse(precio_unitario) * int.Parse(cantidad);
                    }
                }

                if (cant_errores == 0 && id_tipo_venta == 2 && total_venta != (cuotas.Sum(a => a.monto_cuota) + anticipos.Sum(a => a.monto_anticipo)))
                {
                    MessageBox.Show("Debe crear las cuotas nuevamente ya que el valor de la venta no coincide con las cuotas registradas.");
                    btncuotas.Focus();
                }
            }

            if (cant_errores == 0)
            {
                //id_cliente = 0;
                if (tbidcliente.EditValue != null)
                {
                    id_cliente = int.Parse(tbidcliente.EditValue.ToString());
                }
                string nombre_cliente = tbcliente.Text;
                string razon_social = tbcliente.Text;
                string nit = tbnit.Text;
                int id_tienda = Configuraciones.Configuraciones.idtienda;
                int id_vendedor = int.Parse(luevendedor.EditValue.ToString());
                int control_venta = Convert.ToInt32(tbcontrolventa.Value);
                decimal subtotal = (total_venta - (total_venta * 0.12m));
                decimal iva = total_venta - subtotal;

                if (lueautorizador.EditValue != null)
                {
                    if (lueautorizador.EditValue.ToString() == "3")
                    {
                        comentarios_aut = comentarios_aut + " Información del depósito: banco " + tbbancodep.Text + ", fecha depósito " + defechadep.Text + ", número de boleta " + tbnoboletadep.Text;
                    }
                }

                var data_serie = (from a in db.tbl_series
                                  where a.id_tienda == id_tienda
                                  && a.id_tipo_serie == id_tipo_venta
                                  && a.id_tipo_documento == 4
                                  && a.activo == true
                                  select a).FirstOrDefault();
                correlativo = data_serie.correlativo + 1;
                serie_salida = data_serie.serie;
                tbl_ventas_enc.Insert(id_cliente, nombre_cliente, razon_social, nit, data_serie.id_serie, data_serie.serie, data_serie.correlativo + 1, id_tienda, id_vendedor, 1, control_venta, subtotal, iva, total_venta, id_tipo_venta, true, DateTime.Now, 1, comentarios_aut, 4,id_tipo_venta == 1 ? 1:2);
                tbl_ventas_enc.Update(db);

                (from a in db.tbl_series
                 where a.id_serie == data_serie.id_serie
                 select a).ToList().ForEach(a => { a.correlativo = (a.correlativo + 1); });
                tbl_series.Update(db);
                CargarTablas();

                var countOfRows = db.tbl_ventas_enc.Count();
                var datos_registro = db.tbl_ventas_enc.OrderBy(c => 1 == 1).Skip(countOfRows - 1).FirstOrDefault();

                id_venta_enc = datos_registro.id_venta_enc;

                tbserie.Text = datos_registro.serie;
                tbcorrelativo.Text = datos_registro.correlativo.ToString();

                for (int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                {
                    CargarTablas();
                    int id_existencia = int.Parse(gvlistadoproductos.GetRowCellValue(i, "Id").ToString());
                    decimal precio_unitario = decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString());
                    int cantidad = int.Parse(gvlistadoproductos.GetRowCellValue(i, "Cantidad").ToString());
                    int sub_stock = int.Parse(gvlistadoproductos.GetRowCellValue(i, "sub_stock").ToString());
                    int sub_stock_final = 0;
                    decimal iva_unidad = precio_unitario * 0.12m;
                    decimal subtotal_unidad = precio_unitario - iva_unidad;
                    string no_serie = gvlistadoproductos.GetRowCellValue(i, "NoSerie").ToString();
                    if (cantidad > sub_stock)
                    {
                        sub_stock_final = cantidad - sub_stock;
                    }
                    if (cantidad < sub_stock)
                    {
                        sub_stock_final = sub_stock - cantidad;
                    }
                    if (cantidad == sub_stock)
                    {
                        sub_stock_final = cantidad - sub_stock;
                    }

                    tbl_ventas_det.Insert(id_existencia, cantidad, precio_unitario, subtotal_unidad, iva_unidad, (precio_unitario * cantidad), id_venta_enc, true, DateTime.Now, 1, no_serie);

                    (from a in db.ExistenciaDetalle
                     where a.idexistenciadetalle == id_existencia
                     select a).ToList().ForEach(a => { a.stock = a.stock - cantidad; a.sub_stock = sub_stock_final; });
                    tbl_ventas_det.Update(db);
                    tbl_existencias.Update(db);
                }

                btnimpcuotas.Enabled = true;
                btnimpcontrato.Enabled = true;
                tbcontrolventa.Enabled = false;
                btnfiadores.Enabled = false;
                btnautorizaciones.Enabled = false;
                luevendedor.Enabled = false;
                luetipopago.Enabled = false;
                btncliente.Enabled = false;
                btnlimpiarcliente.Enabled = false;
                btnguardar.Enabled = false;
                btnagregaranticipo.Enabled = false;
                btncrearanticipo.Enabled = false;
                btneliminarlinea.Enabled = false;
                gclistaproductos.Enabled = false;

                if (id_tipo_venta == 1)
                {
                    tbl_ventas_promesas_pago_enc.Insert(id_venta_enc, 1, DateTime.Now, DateTime.Now, false, DateTime.Now, 1, total_venta, total_venta);
                    tbl_ventas_promesas_pago_enc.Update(db);
                    CargarTablas();

                    var promesa_pago_enc = (from a in db.tbl_ventas_promesas_pago_enc
                                            select a).LastOrDefault();

                    tbl_ventas_promesas_pago_det.Insert(promesa_pago_enc.id_promesa_pago, total_venta, DateTime.Now, false, DateTime.Now, 1, 0,true,"CUOTA DE VENTA AL CONTADO",1);
                    tbl_ventas_promesas_pago_det.Update(db);
                    CargarTablas();

                    var promesa_pago_det = (from a in db.tbl_ventas_promesas_pago_det
                                            select a).LastOrDefault();
                    int id_anticipo = 0;
                    if (anticipos.Count > 0)
                    {
                        var datos_serie = (from a in db.tbl_series
                                           where a.id_tienda == Configuraciones.Configuraciones.idtienda &&
                                           a.id_tipo_serie == 3 &&
                                           a.activo == true
                                           select new
                                           {
                                               a.id_serie,
                                               a.serie,
                                               a.correlativo
                                           }).SingleOrDefault();

                        for (int i = 0; i < anticipos.Count; i++)
                        {
                            id_anticipo = anticipos[i].id_anticipo;
                            if (id_anticipo == 0)
                            {
                                tbl_recibos_anticipos.Insert(anticipos[i].monto_anticipo, anticipos[i].id_tipo_pago, id_cliente, nombre_cliente, anticipos[i].descripcion, DateTime.Now, true, 1, (datos_serie.correlativo + 1), Configuraciones.Configuraciones.idtienda, datos_serie.serie, datos_serie.id_serie, 2);
                                tbl_recibos_anticipos.Update(db);
                                (from a in db.tbl_series
                                 where a.id_serie == datos_serie.id_serie
                                 select a).ToList().ForEach(a => { a.correlativo = (a.correlativo + 1); });
                                tbl_series.Update(db);
                                CargarTablas();

                                id_anticipo = (from a in db.tbl_recibos_anticipos
                                               select a.id_recibos_anticipo).LastOrDefault();
                            }

                            promesa_pago_det = (from a in db.tbl_ventas_promesas_pago_det
                                                select a).LastOrDefault();

                            tbl_venta_abonos.Insert(promesa_pago_det.id_promesa_pago_det, id_anticipo, true, DateTime.Now, 1,1,0,0);
                            tbl_venta_abonos.Update(db);
                            CargarTablas();
                        }
                    }
                }



                if (id_tipo_venta == 2)
                {
                    int id_autorizador = int.Parse(lueautorizador.EditValue.ToString());
                    tbl_auditoria_ventas.Insert(id_venta_enc, 1, 0, "", "", DateTime.Now, null, null, true, 1, false);
                    tbl_auditoria_ventas.Update(db);
                    CargarTablas();

                    tbl_auditoria_revision_doctos.Insert(id_venta_enc, 1, 0, "", DateTime.Now, null, null, true, 1, false);
                    tbl_auditoria_revision_doctos.Update(db);
                    CargarTablas();

                    if (cuotas.Count > 0)
                    {
                        tbl_ventas_promesas_pago_enc.Insert(id_venta_enc, cuotas.Count, cuotas[0].fecha_pago_cuota, cuotas[cuotas.Count - 1].fecha_pago_cuota, true, DateTime.Now, 1, (total_venta - anticipos.Sum(a => a.monto_anticipo)), anticipos.Sum(a => a.monto_anticipo));
                        tbl_ventas_promesas_pago_enc.Update(db);
                        CargarTablas();
                        int id_promesa_pago = (from a in db.tbl_ventas_promesas_pago_enc
                                               where a.activo == true
                                               select a.id_promesa_pago).Max();
                        for (int i = 0; i < cuotas.Count; i++)
                        {

                            tbl_ventas_promesas_pago_det.Insert(id_promesa_pago, cuotas[i].monto_cuota, cuotas[i].fecha_pago_cuota, true, DateTime.Now, 1, i + 1,false," ",1);
                            tbl_ventas_promesas_pago_det.Update(db);
                            CargarTablas();
                        }
                    }

                    if (anticipos.Count > 0)
                    {
                        var serie = (from a in db.tbl_series
                                     where a.id_tienda == Configuraciones.Configuraciones.idtienda
                                     && a.activo == true
                                     && a.id_tipo_serie == 3
                                     select a).FirstOrDefault();



                        int id_promesa_pago_enc = db.tbl_ventas_promesas_pago_enc.OrderByDescending(a => a.id_promesa_pago).Take(1).Select(a => a.id_promesa_pago).FirstOrDefault();


                        for (int i = 0; i < anticipos.Count; i++)
                        {
                            if (anticipos[i].id_anticipo == 0)
                            {
                                tbl_recibos_anticipos.Insert(anticipos[i].monto_anticipo, anticipos[i].id_tipo_pago, id_cliente, tbcliente.Text, anticipos[i].descripcion, DateTime.Now, true, 1, (serie.correlativo + 1), Configuraciones.Configuraciones.idtienda, serie.serie, serie.id_serie, 2);
                                tbl_recibos_anticipos.Update(db);
                             
                                (from a in db.tbl_series
                                 where a.id_serie == serie.id_serie
                                 select a).ToList().ForEach(a => { a.correlativo = (a.correlativo + 1); });
                                tbl_series.Update(db);
                            }

                            tbl_ventas_promesas_pago_det.Insert(id_promesa_pago_enc, anticipos[i].monto_anticipo, DateTime.Now, false, DateTime.Now, 1, 0,true,"CUOTA DE ANTICIPO",1);
                            tbl_ventas_promesas_pago_det.Update(db);
                            CargarTablas();

                            int id_promesa_pago_det = db.tbl_ventas_promesas_pago_det.OrderByDescending(a => a.id_promesa_pago_det).Take(1).Select(a => a.id_promesa_pago_det).FirstOrDefault();

                            int id_anticipo = 0;
                            if (anticipos[i].id_anticipo == 0)
                            {
                                id_anticipo = db.tbl_recibos_anticipos.OrderByDescending(a => a.id_recibos_anticipo).Take(1).Select(a => a.id_recibos_anticipo).FirstOrDefault();
                            }
                            else
                            {
                                id_anticipo = anticipos[i].id_anticipo;
                            }

                            tbl_venta_abonos.Insert(id_promesa_pago_det, id_anticipo, true, DateTime.Now, 1,1,0,0);
                            tbl_venta_abonos.Update(db);
                            //=============================================================================
                            //============================SE REGISTRA UNA ENTRADA DE DINERO=================================================
                            ControllerMovimientoDinero.GrabarEntrada(id_anticipo
                            , Configuraciones.Configuraciones.idtienda
                            , Configuraciones.Configuraciones.idusuario
                            , 7
                            , anticipos[i].monto_anticipo
                            , "A"
                            , (serie.correlativo + 1));
                            //=============================================================================

                 

                            db.tbl_recibos_anticipos.Where(a => a.id_recibos_anticipo == id_anticipo).Select(a => a).ToList().ForEach(a => { a.activo = false; });
                            tbl_recibos_anticipos.Update(db);
                            CargarTablas();
                        }
                    }

                    if (fiadores.Count > 0)
                    {
                        for (int i = 0; i < fiadores.Count; i++)
                        {
                            tbl_venta_fiadores.Insert(fiadores[i].id_fiador, fiadores[i].nombre_fiador, fiadores[i].cui, id_venta_enc, true, DateTime.Now, 1);
                            tbl_venta_fiadores.Update(db);
                            CargarTablas();
                        }
                    }

                    if (autorizaciones.Count > 0)
                    {
                        for (int i = 0; i < autorizaciones.Count; i++)
                        {
                            tbl_ventas_aprobacion_credito.Insert(autorizaciones[i].id_autorizacion, id_venta_enc, true, DateTime.Now, 1);
                            tbl_ventas_aprobacion_credito.Update(db);
                            CargarTablas();
                        }
                    }


                }

                if (anticipos.Count > 0 && anticipos.Select(a => a.id_anticipo == 0).FirstOrDefault())
                {
                    DialogResult imprecibo = MessageBox.Show("Impresión de recibo", "¿Desea imprimir el recibo de anticipo?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (imprecibo == DialogResult.Yes)
                    {
                        int id_recibo = (from a in db.tbl_venta_abonos
                                         join b in db.tbl_ventas_promesas_pago_det on a.id_promesa_pago_det equals b.id_promesa_pago_det
                                         join c in db.tbl_ventas_promesas_pago_enc on b.id_promesa_pago equals c.id_promesa_pago
                                         where c.id_venta_enc == id_venta_enc
                                         select a.id_recibo_anticipo).SingleOrDefault();
                        Complementos.ImprimirRecibo imprimirRecibo = new Complementos.ImprimirRecibo(id_recibo);
                        imprimirRecibo.ShowDialog();
                    }
                }

                DialogResult impenvio = MessageBox.Show("¿Desea imprimir el recibo de venta?", "Impresión de envío", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (impenvio == DialogResult.Yes)
                {
                    if (id_tipo_venta == 1)
                    {
                        Complementos.ImprimirEnvio imprimirEnvio = new Complementos.ImprimirEnvio(id_venta_enc);
                        imprimirEnvio.ShowDialog();
                    }
                    else if (id_tipo_venta == 2)
                    {
                        Complementos.ImprimirPromesasPago imprimirPromesasPago = new Complementos.ImprimirPromesasPago(id_venta_enc);
                        imprimirPromesasPago.ShowDialog();
                    }
                }

                DialogResult impfactura = MessageBox.Show("¿Desea imprimir la factura?", "Impresión de factura", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (impfactura == DialogResult.Yes)
                {
                    var data_serie_fact = (from a in db.tbl_series
                                           where a.id_tienda == id_tienda
                                           && a.id_tipo_documento == 1
                                           && a.activo == true
                                           select a).FirstOrDefault();

                    string direccion_cliente = (from a in db.Listado_clientes
                                                where a.id_cliente == id_cliente
                                                select a.direccion).SingleOrDefault();

                    tbl_facturacion_enc.Insert(data_serie_fact.id_serie, data_serie_fact.serie, data_serie_fact.correlativo + 1, id_venta_enc, subtotal, total_venta, iva, id_cliente, nombre_cliente, nit, direccion_cliente, DateTime.Now, true, 1);
                    tbl_facturacion_enc.Update(db);
                    (from a in db.tbl_series
                     where a.id_serie == data_serie_fact.id_serie
                     select a).ToList().ForEach(a => { a.correlativo = (a.correlativo + 1); });
                    tbl_series.Update(db);
                    CargarTablas();

                    int id_factura = (from a in db.tbl_facturacion_enc
                                      select a.id_factura).Max();

                    for (int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                    {
                        int id_existencia = int.Parse(gvlistadoproductos.GetRowCellValue(i, "Id").ToString());
                        decimal precio_unitario = decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString());
                        int cantidad = int.Parse(gvlistadoproductos.GetRowCellValue(i, "Cantidad").ToString());
                        decimal iva_unidad = precio_unitario * 0.12m;
                        decimal subtotal_unidad = precio_unitario - iva_unidad;
                        string no_serie = gvlistadoproductos.GetRowCellValue(i, "NoSerie").ToString();

                        tbl_facturacion_det.Insert(id_existencia, cantidad, precio_unitario, subtotal_unidad, iva_unidad, (precio_unitario * cantidad), true, id_factura, DateTime.Now, no_serie);
                        tbl_facturacion_det.Update(db);
                        CargarTablas();
                    }

                    var info_factura = db.tbl_facturacion_enc.Where(a => a.id_factura == id_factura).FirstOrDefault();

                    Complementos.ImprimirFactura imprimirEnvio = new Complementos.ImprimirFactura(info_factura.serie, info_factura.correlativo, int.Parse(Configuraciones.Configuraciones.idtienda.ToString()));
                    imprimirEnvio.ShowDialog();


                }

                //AUTOR EL CODIGO: BOBI1996
                //ABAJO DE ESTE COMENTARIO VA EL CODIGO PARA INSERTAR EN LA TABLA 
                string rpta = "";
                int CantidadRecibidos = 0;
                string producto = "";
                int idgenordencompradetalle = 0;
                int contFilas = 0;
                int cantidadAgregar = 0;
                DataTable dtSeriesDatos;
                bool add_only = false;


                MSalidaEnc salida = new MSalidaEnc();
                salida.IdTienda = Configuraciones.Configuraciones.idtienda;
                salida.IdUsuario = Configuraciones.Configuraciones.idusuario;
                salida.IdDocumentoDeInventrio = 7;
                salida.IdSerie = 1;
                salida.IdDestino = 0;
                salida.IdBodegaDestino = 0;
                salida.Observaciones = "";
                salida.Descripcion = "VENDIDO AL CLIENTE: " + tbcliente.Text;
                salida.Origen = "TIENDA ORIGEN: " + Configuraciones.Configuraciones.tienda;
                salida.Destino = "DESTINO: " + tbcliente.Text;
                salida.FechaDeIngreso = DateTime.Now;
                salida.Serie = serie_salida;
                salida.SeraIngresado = false;
                salida.TipoSalida = 3;
                salida.IdSubTraslado = 0;
                salida.NumeroEnvio = correlativo;

                List<MSalidaDetalle> DetalleInserccion = new List<MSalidaDetalle>();

                for (int i = 0; i < gvlistadoproductos.RowCount; i++)
                {
                    int count = 0;
                    bool add = false;
                    for (int j = 0; j < gvlistadoproductos.RowCount; j++)
                    {
                        if (Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "IdProducto")) == Convert.ToInt32(gvlistadoproductos.GetRowCellValue(j, "IdProducto")))
                        {
                            count++;
                            if (ExisteProducto(Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "IdProducto"))))
                            {
                                add = true;
                            }

                        }
                    }
                    if (add)
                    {
                        if (count > 1)
                        {
                            DataRow dtRow = dtProductos.NewRow();
                            dtRow["IdProducto"] = Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "IdProducto"));
                            dtRow["Cantidad"] = count;
                            dtRow["IdBodega"] = Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "IdBodega"));
                            dtProductos.Rows.Add(dtRow);
                        }
                        else
                        {
                            DataRow dtRow = dtProductos.NewRow();
                            dtRow["IdProducto"] = Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "IdProducto"));
                            dtRow["Cantidad"] = Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "Cantidad"));
                            dtRow["IdBodega"] = Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "IdBodega"));
                            dtProductos.Rows.Add(dtRow);
                        }

                    }

                }
                bool ExisteProducto(int id_producto)
                {
                    for (int i = 0; i < dtProductos.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dtProductos.Rows[i]["IdProducto"]) == id_producto)
                        {

                            return false;
                        }
                    }
                    return true;
                }

                for (int i = 0; i < dtProductos.Rows.Count; i++)
                {

                    MSalidaDetalle SalidaDetalle = new MSalidaDetalle();
                    SalidaDetalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                    SalidaDetalle.IdSubTrasladoDetalle = 0;
                    SalidaDetalle.IdProducto = Convert.ToInt32(dtProductos.Rows[i]["IdProducto"]);
                    SalidaDetalle.Cantidad = Convert.ToInt32(dtProductos.Rows[i]["Cantidad"]);
                    SalidaDetalle.IdExistenciaDetalle = 0;
                    SalidaDetalle.IdBodega = Convert.ToInt32(dtProductos.Rows[i]["IdBodega"]);
                    SalidaDetalle.EsVenta = 1;
                    DetalleInserccion.Add(SalidaDetalle);
                }



                List<MSerieProducto> IngresoDetalleInsercionSeriesProducto = new List<MSerieProducto>();


                foreach (DataRow item in dtProductos.Rows)
                {
                    int correlativo_serie = 0;
                    for (int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                    {

                        if (Convert.ToInt32(item["idproducto"]) == Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "IdProducto")))
                        {
                            //NoSerie
                            correlativo_serie++;
                            MSerieProducto serie = new MSerieProducto();
                            serie.Idtienda = Configuraciones.Configuraciones.idtienda;
                            serie.IdordenDeCompraDetalle = Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "IdProducto"));
                            serie.Numero = correlativo_serie;
                            serie.Serie = Convert.ToString(gvlistadoproductos.GetRowCellValue(i, "NoSerie"));
                            IngresoDetalleInsercionSeriesProducto.Add(serie);
                        }
                    }
                }

                //for (int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                //{

                //    MSerieProducto serie = new MSerieProducto();
                //    serie.Idtienda = Configuraciones.Configuraciones.idtienda;
                //    serie.IdordenDeCompraDetalle = Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "IdProducto"));
                //    serie.Numero = 1;
                //    serie.Serie = Convert.ToString(gvlistadoproductos.GetRowCellValue(i, "IdProducto"));
                //    IngresoDetalleInsercionSeriesProducto.Add(serie);
                //}

                rpta = ControllerSalidas.Salidas(salida, DetalleInserccion, IngresoDetalleInsercionSeriesProducto);
                if (rpta == "OK")
                {
                    XtraMessageBox.Show("la salida se reailo nitido");
                    total = 0;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un error al crear el traslado, profavor consulte a su administrador de datos " + rpta, "Error al crear traslado");
                }


                btnimpcontrato.Visible = true;
                btnimprimircuotas.Visible = true;
                total = 0;
                SpinEditTotal.Value = 0;
            }
        }

        private void lueautorizador_EditValueChanged(object sender, EventArgs e)
        {
            int cant_errores = 0;
            if (lueautorizador.EditValue != null)
            {
                if (gvlistadoproductos.RowCount == 0)
                {
                    MessageBox.Show("Seleccione primero los artículos a vender e ingrese los precios unitarios de cada uno.");
                    lueautorizador.EditValue = null;
                    gclistaproductos.Focus();
                }
                else
                {
                    decimal total_venta = 0;
                    for (int i = 0; i < gvlistadoproductos.RowCount; i++)
                    {
                        string precio_unitario = gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString();
                        string cantidad = gvlistadoproductos.GetRowCellValue(i, "Cantidad").ToString();
                        string no_serie = gvlistadoproductos.GetRowCellValue(i, "NoSerie").ToString();
                        decimal precio_c = decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "Precio C").ToString());
                        decimal descuento = decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "Descuento").ToString());

                        if (Convert.ToDecimal(precio_unitario) == 0 || Convert.ToDecimal(precio_unitario) == 0 || Convert.ToDecimal(cantidad) == 0 || Convert.ToDecimal(cantidad) == 0)
                        {
                            MessageBox.Show("Ingrese el precio unitario/cantidad del producto en la línea " + (i + 1));
                            lueautorizador.EditValue = null;
                            cant_errores++;
                            break;
                        }
                        else
                        {
                            decimal precio_menor = precio_c;
                            if (id_tipo_venta == 1)
                            {
                                if (descuento > 0)
                                {
                                    precio_menor = (precio_c - (precio_c * (descuento / 100)));
                                }
                            }
                            if (decimal.Parse(precio_unitario) < precio_menor)
                            {
                                MessageBox.Show("El Precio Unitario no puede ser menor al Precio C con descuento en la línea " + (i + 1));
                                lueautorizador.EditValue = null;
                                cant_errores++;
                                break;
                            }
                            else
                            {
                                total_venta = total_venta + (decimal.Parse(precio_unitario) * int.Parse(cantidad));
                            }
                        }
                    }

                    if (cant_errores == 0)
                    {
                        if (cuotas.Count == 0)
                        {
                            MessageBox.Show("Ingrese la distribución de cuotas para esta venta antes de seleccionar al autorizador.");
                            lueautorizador.EditValue = null;
                        }
                        else
                        {
                            decimal monto_comp = (cuotas.Sum(a => a.monto_cuota) + anticipos.Sum(a => a.monto_anticipo));
                            if (cant_errores == 0 && total_venta != (cuotas.Sum(a => a.monto_cuota) + anticipos.Sum(a => a.monto_anticipo)))
                            {
                                MessageBox.Show("Debe crear las cuotas nuevamente ya que el valor de la venta no coincide con las cuotas registradas.");
                                btncuotas.Focus();
                                lueautorizador.EditValue = null;
                                btncuotas.Focus();
                            }
                            else
                            {
                                int id_autorizador = int.Parse(lueautorizador.EditValue.ToString());
                                decimal monto_maximo_autorizar = (from a in db.tbl_autorizadores_tienda
                                                                  where a.id_autorizador == id_autorizador &&
                                                                  a.id_tienda == Configuraciones.Configuraciones.idtienda
                                                                  select a.monto_maximo_autorizar).SingleOrDefault();

                                if (total_venta > monto_maximo_autorizar)
                                {
                                    MessageBox.Show("El total de la venta es de Q." + total_venta + " y monto máximo de crédito para el autorizador seleccionado es de: Q." + monto_maximo_autorizar);
                                    lueautorizador.EditValue = null;
                                    gclistaproductos.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("Al validar el autorizador se desactivarán las opciones para agregar productos.");
                                    Complementos.SolicitarAutorizacion autorizacion = new Complementos.SolicitarAutorizacion(null, int.Parse(lueautorizador.EditValue.ToString()), this);
                                    autorizacion.ShowDialog();
                                }
                            }
                        }
                    }
                    else
                    {
                        lueautorizador.EditValue = null;
                        gclistaproductos.Focus();
                    }
                }
            }
        }

        private void btnfiadores_Click(object sender, EventArgs e)
        {
            Buscadores.BuscadorFiadores buscadorFiadores = new Buscadores.BuscadorFiadores(1, null, this);
            buscadorFiadores.ShowDialog();
        }

        private void btnautorizaciones_Click(object sender, EventArgs e)
        {
            Buscadores.BuscardorAutorizaciones buscardorAutorizaciones = new Buscadores.BuscardorAutorizaciones(1, null, this);
            buscardorAutorizaciones.ShowDialog();
        }

        private void btncuotas_Click(object sender, EventArgs e)
        {
            if (gvlistadoproductos.DataRowCount > 0)
            {
                decimal total_venta = 0;
                int errores = 0;
                for (int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                {
                    if (decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) > 0)
                    {
                        total_venta = total_venta + (decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) * decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "Cantidad").ToString()));
                    }
                    else
                    {
                        MessageBox.Show("No se ha ingresado el valor unitario para todos los productos. Revise e intente nuevamente.");
                        errores = errores + 1;
                        i = gvlistadoproductos.DataRowCount;
                    }

                    if (decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "Cantidad").ToString()) > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se ha ingresado la cantidad para todos los productos. Revise e intente nuevamente.");
                        errores = errores + 1;
                        i = gvlistadoproductos.DataRowCount;
                    }

                    if (gvlistadoproductos.GetRowCellValue(i, "NoSerie") != null)
                    {
                        if (gvlistadoproductos.GetRowCellValue(i, "NoSerie").ToString() != "")
                        {

                        }
                        else
                        {
                            if (errores == 0)
                            {
                                MessageBox.Show("No se ha ingresado el número de serie para todos los productos. Revise e intente nuevamente.");
                                errores = errores + 1;
                                i = gvlistadoproductos.DataRowCount;
                            }
                        }
                    }
                    else
                    {
                        if (errores == 0)
                        {
                            MessageBox.Show("No se ha ingresado el número de serie para todos los productos. Revise e intente nuevamente.");
                            errores = errores + 1;
                            i = gvlistadoproductos.DataRowCount;
                        }
                    }
                }

                if (errores == 0)
                {
                    Complementos.CalcularCuotas calcularCuotas = new Complementos.CalcularCuotas(2, null, total_venta, anticipos.Sum(a => a.monto_anticipo), this);
                    calcularCuotas.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No ha ingresado ningún producto.");
            }
        }

        void QuitarProducto()
        {
            if (gvlistadoproductos.RowCount > 0)
            {
                gvlistadoproductos.DeleteRow(gvlistadoproductos.FocusedRowHandle);


                for (int i = 0; i < gvlistadoproductos.RowCount; i++)
                {
                    total += Convert.ToDecimal(gvlistadoproductos.GetRowCellValue(i, "Sub-Total"));
                }

                SpinEditTotal.Value = total;
                total = 0;
            }
            else
            {
                SpinEditTotal.Value = 0;
                total = 0;
            }
        }

        private void btneliminarlinea_Click(object sender, EventArgs e)
        {
            QuitarProducto();
        }

        private void btnimpcontrato_Click(object sender, EventArgs e)
        {
            Complementos.ImprimirContrato imprimirContrato = new Complementos.ImprimirContrato(id_venta_enc);
            imprimirContrato.ShowDialog();
        }

        private void btnimpcuotas_Click(object sender, EventArgs e)
        {
            Complementos.ImprimirPromesasPago imprimirPromesasPago = new Complementos.ImprimirPromesasPago(id_venta_enc);
            imprimirPromesasPago.ShowDialog();
        }

        private void tbcontrolventa_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gvlistadoproductos_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            for (int i = 0; i < gvlistadoproductos.RowCount; i++)
            {
                if (gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario") != null && gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString() != "" && gvlistadoproductos.GetRowCellValue(i, "Cantidad") != null && gvlistadoproductos.GetRowCellValue(i, "Cantidad").ToString() != "")
                {
                    gvlistadoproductos.SetRowCellValue(i, "Sub-Total", (decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) * int.Parse(gvlistadoproductos.GetRowCellValue(i, "Cantidad").ToString())));
                }
                else
                {
                    gvlistadoproductos.SetRowCellValue(i, "Sub-Total", 0);
                }
            }
        }

        private void gvlistadoproductos_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            for (int i = 0; i < gvlistadoproductos.RowCount; i++)
            {
                if (gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario") != null && gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString() != "" && gvlistadoproductos.GetRowCellValue(i, "Cantidad") != null && gvlistadoproductos.GetRowCellValue(i, "Cantidad").ToString() != "")
                {
                    gvlistadoproductos.SetRowCellValue(i, "Sub-Total", (decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) * int.Parse(gvlistadoproductos.GetRowCellValue(i, "Cantidad").ToString())));
                }
                else
                {
                    gvlistadoproductos.SetRowCellValue(i, "Sub-Total", 0);
                }
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Clientes.FormCrearClienteRapido nuevoCliente = new Clientes.FormCrearClienteRapido();
            nuevoCliente.ShowDialog();
            id_cliente = ControllerCliente.IdCliente;
            tbidcliente.Text = id_cliente.ToString();

            tbcliente.Text = ControllerCliente.Nombres + " " + ControllerCliente.Apellidos;
            tbtelefono.Text = ControllerCliente.Telefono;
            tbnit.Text = string.IsNullOrWhiteSpace(ControllerCliente.Nit) == true ? "CF" : ControllerCliente.Nit;
            tbdireccion.Text = ControllerCliente.Direccion;
        }

        private void gvlistadoproductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                QuitarProducto();
            }
        }

        private void RealizarVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void lookUpEditProductos_Properties_PopupFilter(object sender, PopupFilterEventArgs e)
        {

        }

        //____________________________________________________

        //_____________________________________________________AUTOR: PROGRAMADOR DANIEL AMERICO_________________________________________________________________
        //________________________________________________funcion para mostrar los productos en el lookpuedit______________________________________________________________________

        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {
            lookupeditnombre.Properties.DataSource = datos;
            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
        }
        //______________________________________________________________________________________________________________________
        //______________________________________________________________________________________________________________________

        private void lookUpEditBodegas_EditValueChanged(object sender, EventArgs e)
        {


            if (lookUpEditBodegas.ItemIndex > -1)
            {
                idbodega = Convert.ToInt32(lookUpEditBodegas.EditValue);
                mostrarEnComboboxLookUp(lookUpEditProductos, "producto", "idexistenciadetalle", ControllerVentas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, "00-developer-..."));
            }
        }

        private void txtBuscarProducto_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            mostrarEnComboboxLookUp(lookUpEditProductos, "producto", "idexistenciadetalle", dt = ControllerVentas.MostrarProductosEnbodega(Configuraciones.Configuraciones.idtienda, idbodega, txtBuscarProducto.Text));
            if (dt.Rows.Count > 0)
            {
                lookUpEditProductos.ItemIndex = 0;
            }
        }

        void AgregarProducto(bool aplica_serie)
        {

            if (aplica_serie)
            {
                int cantidad = 1;
                for (int i = 0; i < gvlistadoproductos.RowCount; i++)
                {
                    if (Convert.ToInt32(lookUpEditProductos.GetColumnValue("idproducto")) == Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "IdProducto")))
                    {
                        cantidad++;
                    }
                }
                if (cantidad <= spinEditDisponible.Value)
                {
                    gvlistadoproductos.AddNewRow();
                    int rowHandle = gvlistadoproductos.GetRowHandle(gvlistadoproductos.DataRowCount);

                    if (gvlistadoproductos.IsNewItemRow(rowHandle))
                    {
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[0], lookUpEditProductos.GetColumnValue("idexistenciadetalle").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[1], lookUpEditProductos.GetColumnValue("idbodega").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[2], lookUpEditProductos.GetColumnValue("idproducto").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[3], lookUpEditProductos.GetColumnValue("stock").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[4], lookUpEditProductos.GetColumnValue("sub_stock").ToString()); //creado por daniel
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[5], lookUpEditProductos.GetColumnValue("nombre").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[6], lookUpEditProductos.GetColumnValue("bodega").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[7], lookUpEditProductos.GetColumnValue("producto").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[8], lookUpEditProductos.GetColumnValue("codigo_producto").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[9], lookUpEditProductos.GetColumnValue("precioa").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[10], lookUpEditProductos.GetColumnValue("preciob").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[11], lookUpEditProductos.GetColumnValue("precioc").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[12], lookUpEditProductos.GetColumnValue("descuento_producto").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[13], spinEditPrecio.Value);
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[14], spinEditCantidad.Value);
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[15], 0);
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[16], txtSerie.Text);
                        gvlistadoproductos.UpdateCurrentRow();
                        gvlistadoproductos.BestFitColumns();
                    }
                }
            }
            if (!aplica_serie)
            {
                bool agregar_producto = true;
                for (int i = 0; i < gvlistadoproductos.RowCount; i++)
                {
                    if (Convert.ToInt32(lookUpEditProductos.GetColumnValue("idproducto")) == Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "IdProducto")))
                    {
                        int cantidad_actual = 0, cantidad_final = 0;
                        cantidad_actual = Convert.ToInt32(gvlistadoproductos.GetRowCellValue(i, "Cantidad"));
                        cantidad_final = cantidad_actual + Convert.ToInt32(spinEditCantidad.Value);
                        if (cantidad_final <= spinEditDisponible.Value)
                        {
                            gvlistadoproductos.SetRowCellValue(i, "Cantidad", cantidad_final);
                            gvlistadoproductos.SetRowCellValue(i, "Sub-Total", cantidad_final * (spinEditPrecio.Value));
                        }
                        agregar_producto = false;
                    }
                }
                if (agregar_producto)
                {
                    gvlistadoproductos.AddNewRow();
                    int rowHandle = gvlistadoproductos.GetRowHandle(gvlistadoproductos.DataRowCount);

                    if (gvlistadoproductos.IsNewItemRow(rowHandle))
                    {
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[0], lookUpEditProductos.GetColumnValue("idexistenciadetalle").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[1], lookUpEditProductos.GetColumnValue("idbodega").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[2], lookUpEditProductos.GetColumnValue("idproducto").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[3], lookUpEditProductos.GetColumnValue("stock").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[4], lookUpEditProductos.GetColumnValue("sub_stock").ToString()); //creado por daniel
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[5], lookUpEditProductos.GetColumnValue("nombre").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[6], lookUpEditProductos.GetColumnValue("bodega").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[7], lookUpEditProductos.GetColumnValue("producto").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[8], lookUpEditProductos.GetColumnValue("codigo_producto").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[9], lookUpEditProductos.GetColumnValue("precioa").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[10], lookUpEditProductos.GetColumnValue("preciob").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[11], lookUpEditProductos.GetColumnValue("precioc").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[12], lookUpEditProductos.GetColumnValue("descuento_producto").ToString());
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[13], spinEditPrecio.Value);
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[14], spinEditCantidad.Value);
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[15], 0);
                        gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[16], txtSerie.Text);
                        gvlistadoproductos.UpdateCurrentRow();
                        gvlistadoproductos.BestFitColumns();
                    }
                }
            }

            //_______________________________________ESTE CODIGO ES PARA INSRTAR EN LA TABLA DE DOCUMENTOS OPERADOS______________________________________________________________
            //AUTOR DEL CODIGO BOBY1996
            //bool agregar = true;

            //foreach (DataRow item in dtProductos.Rows)
            //{

            //    if (Convert.ToInt32(item["IdProducto"]) == Convert.ToInt32(lookUpEditProductos.GetColumnValue("idproducto")))
            //    {
            //        agregar = false;
            //        item["Cantidad"] = Convert.ToInt32(item["Cantidad"]) + spinEditCantidad.Value;
            //    }
            //}
            //if (agregar)
            //{
            //    DataRow dtRow = dtProductos.NewRow();
            //    dtRow["IdProducto"] = Convert.ToInt32(lookUpEditProductos.GetColumnValue("idproducto"));
            //    dtRow["Cantidad"] = spinEditCantidad.Value;
            //    dtRow["IdBodega"] = Convert.ToInt32(lookUpEditProductos.GetColumnValue("idbodega"));
            //    dtProductos.Rows.Add(dtRow);
            //}

            txtBuscarProducto.Focus();
            txtSerie.Text = "";

            for (int i = 0; i < gvlistadoproductos.RowCount; i++)
            {
                total += Convert.ToDecimal(gvlistadoproductos.GetRowCellValue(i, "Sub-Total"));
            }

            SpinEditTotal.Value = total;
            total = 0;

            //_____________________________________________________________________________________________________
        }

        private void spinEditCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool AgrearProducto = true;
                bool aplica_serie = false;

                if (Convert.ToBoolean(lookUpEditProductos.GetColumnValue("aplica_serie")))
                {
                    lySerie.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    if (string.IsNullOrWhiteSpace(txtSerie.Text))
                    {
                        AgrearProducto = false;
                    }
                    else
                    {
                        aplica_serie = true;
                        spinEditCantidad.Value = 1;
                    }
                }
                if (!Convert.ToBoolean(lookUpEditProductos.GetColumnValue("aplica_serie")))
                {
                    txtSerie.Text = "N0-APLICA-S";
                    aplica_serie = false;

                    if (spinEditCantidad.Value > spinEditDisponible.Value)
                    {
                        AgrearProducto = false;
                    }
                    if (spinEditCantidad.Value < 0)
                    {
                        AgrearProducto = false;
                    }
                }




                if (AgrearProducto)
                {
                    AgregarProducto(aplica_serie);
                }


            }
        }

        private void lookUpEditProductos_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditProductos.ItemIndex > -1)
            {
                spinEditDisponible.Value = Convert.ToInt32(lookUpEditProductos.GetColumnValue("stock"));
                spinEditPrecio.Value = Convert.ToInt32(lookUpEditProductos.GetColumnValue("precioa"));
                if (Convert.ToBoolean(lookUpEditProductos.GetColumnValue("aplica_serie")))
                {
                    lySerie.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    lyCanitdad.Text = "CANTIDAD";
                    spinEditCantidad.Properties.MinValue = 1;
                    spinEditCantidad.Properties.MaxValue = 1;
                }
                else
                {
                    lySerie.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lyCanitdad.Text = "[E]CANTIDAD";
                    spinEditCantidad.Properties.MinValue = 1;
                    spinEditCantidad.Properties.MaxValue = 4294967295;
                }


            }
        }

        private void txtSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool AgrearProducto = true;
                bool aplica_serie = false;
                if (spinEditCantidad.Value > spinEditDisponible.Value)
                {
                    spinEditCantidad.Value = 1;
                    AgrearProducto = false;
                }
                if (Convert.ToBoolean(lookUpEditProductos.GetColumnValue("aplica_serie")))
                {
                    lySerie.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    if (string.IsNullOrWhiteSpace(txtSerie.Text))
                    {
                        AgrearProducto = false;
                    }
                    else
                    {
                        aplica_serie = true;
                    }
                }

                if (spinEditCantidad.Value < 0)
                {
                    AgrearProducto = false;
                }

                if (AgrearProducto)
                {
                    AgregarProducto(aplica_serie);
                }


            }
        }

        private void RealizarVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.G))
            {
                ControlesARevisar();
            }
        }


    }

    public class Anticipo
    {
        public int id_anticipo { get; set; }
        public decimal monto_anticipo { get; set; }

        public int id_tipo_pago { get; set; }

        public string descripcion { get; set; }
    }

    public class Fiadores
    {
        public int id_fiador { get; set; }
        public string nombre_fiador { get; set; }
        public string cui { get; set; }
        public string nit { get; set; }
    }

    public class Autorizaciones
    {
        public int id_autorizacion { get; set; }
        public string nombre_autorizacion { get; set; }
    }

    public class Cuotas
    {
        public int no_cuota { get; set; }
        public decimal monto_cuota { get; set; }
        public DateTime fecha_pago_cuota { get; set; }
    }
}