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
using ViewGuate502.dbSoftwareGTDataSetTableAdapters;
using DevExpress.XtraEditors.Controls;
using CrystalDecisions.CrystalReports.Engine;

namespace ViewGuate502.Ventas
{
    public partial class VentaForm : DevExpress.XtraEditors.XtraForm
    {

        int id_tipo_venta = 0;
        public VentaForm(int id)
        {
            InitializeComponent();
            id_tipo_venta = id;
        }

        tbl_vendedoresTableAdapter tbl_vendedores = new tbl_vendedoresTableAdapter();
        tbl_vendedores_tiendaTableAdapter tbl_vendedores_tienda = new tbl_vendedores_tiendaTableAdapter();
        tbl_usuariosTableAdapter tbl_usuarios = new tbl_usuariosTableAdapter();
        tbl_autorizadores_creditoTableAdapter tbl_autorizadores = new tbl_autorizadores_creditoTableAdapter();
        tbl_autorizadores_tiendaTableAdapter tbl_autorizadores_tienda = new tbl_autorizadores_tiendaTableAdapter();
        tbl_seriesTableAdapter tbl_series = new tbl_seriesTableAdapter();
        tbl_tipo_serieTableAdapter tbl_tipo_serie = new tbl_tipo_serieTableAdapter();
        tbl_ventas_encTableAdapter tbl_venta_enc = new tbl_ventas_encTableAdapter();
        tbl_ventas_detTableAdapter tbl_venta_det = new tbl_ventas_detTableAdapter();
        tbl_recibos_anticiposTableAdapter tbl_recibos_anticipos = new tbl_recibos_anticiposTableAdapter();
        tbl_venta_fiadoresTableAdapter tbl_fiadores = new tbl_venta_fiadoresTableAdapter();
        tbl_ventas_aprobacion_creditoTableAdapter tbl_ventas_aprobacion_credito = new tbl_ventas_aprobacion_creditoTableAdapter();
        tbl_ventas_promesas_pago_encTableAdapter tbl_promesas_pago_enc = new tbl_ventas_promesas_pago_encTableAdapter();
        tbl_ventas_promesas_pago_detTableAdapter tbl_promesas_pago_det = new tbl_ventas_promesas_pago_detTableAdapter();
        tbl_venta_abonosTableAdapter tbl_venta_abonos = new tbl_venta_abonosTableAdapter();
        tbl_facturacion_encTableAdapter tbl_facturacion_enc = new tbl_facturacion_encTableAdapter();
        tbl_facturacion_detTableAdapter tbl_facturacion_det = new tbl_facturacion_detTableAdapter();
        tbl_auditoria_ventasTableAdapter tbl_auditoria_ventas = new tbl_auditoria_ventasTableAdapter();

        object senderForm = new object();
        EventArgs eForm = new EventArgs();
        public DataTable dt;
        public bool validar_autorizacion = false;
        int id_serie = 0;
        decimal monto_total_factura = 0;
        decimal abonos_aplicados = 0;
        int id_venta_enc = 0;

        public List<Tuple<int, string, string, string>> fiadores;
        public List<Tuple<int, decimal, DateTime>> cuotas;
        public List<Tuple<int, string>> autorizaciones;
        public List<Tuple<int, decimal, int, string>> anticipos;
        public string comentarios_autorizaciones = "";

        private void VentaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.tbl_tipos_pago' Puede moverla o quitarla según sea necesario.
            this.tbl_tipos_pagoTableAdapter.Fill(this.dbSoftwareGTDataSet.tbl_tipos_pago);
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.tbl_vendedores_tienda' Puede moverla o quitarla según sea necesario.
            this.tbl_vendedores_tiendaTableAdapter.Fill(this.dbSoftwareGTDataSet.tbl_vendedores_tienda);
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet1.ListadoProductosVenta' Puede moverla o quitarla según sea necesario.
            this.listadoProductosVentaTableAdapter.Fill(this.dbSoftwareGTDataSet1.ListadoProductosVenta);
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.tbl_tipos_venta' Puede moverla o quitarla según sea necesario.
            senderForm = sender;
            eForm = e;
            this.tbl_tipos_ventaTableAdapter.Fill(this.dbSoftwareGTDataSet.tbl_tipos_venta);
            OnLoadFormControls();
        }

        public void OnLoadFormControls()
        {
            CargarTablas();
            fiadores = new List<Tuple<int, string, string, string>>();
            cuotas = new List<Tuple<int, decimal, DateTime>>();
            autorizaciones = new List<Tuple<int, string>>();
            anticipos = new List<Tuple<int, decimal, int, string>>(); // id_recibo, monto, tipo_pago, descripción
            //visible

            this.btnnuevaventa.Visible = true;
            tbfecha.Visible = true;
            btnbuscarcliente.Visible = true;
            tbnombrecliente.Visible = true;
            lblnombrecliente.Visible = true;
            lblnit.Visible = true;
            tbnit.Visible = true;
            lbldireccion.Visible = true;
            tbdireccion.Visible = true;
            tbidcliente.Visible = false;
            btnagregarproductos.Visible = true;
            gclistadoproductos.Visible = true;
            lblventacontado.Visible = true;
            lblcontrolventa.Visible = true;
            tbcontrolventa.Visible = true;
            lblserie.Visible = true;
            lblcorrelativo.Visible = true;
            tbserie.Visible = true;
            tbcorrelativo.Visible = true;
            lblvendedor.Visible = true;
            
            luevendedor.Visible = true;
            
            lbltipopago.Visible = true;
            cmbtipopago.Visible = true;
            btnguardar.Visible = true;
            btnligaranticipo.Visible = false;
            //gcanticipos.Visible = true;
            
            btnimprimircontrato.Visible = false;
            btnimprimirpromesas.Visible = false;

            //Enabled

            btnagregarproductos.Enabled = true;
            btnligaranticipo.Enabled = true;
            btnbuscarcliente.Enabled = true;
            cmbtipopago.Enabled = true;
            luevendedor.Enabled = true; 
            tbcontrolventa.Enabled = true;
            
            tbfecha.Enabled = false;
            

            if (id_tipo_venta == 1)
            {
                gcventas.Text = "Venta de contado";
                lblventacontado.Text = "Venta de contado";
                lblautorizador.Visible = false;
                lueautorizador.Visible = false;
                btnagregarfiadores.Visible = false;
                btnagregarautorizaciones.Visible = false;
                lueautorizador.Enabled = false;
                tbnombrecliente.Enabled = true;
                tbnit.Enabled = true;
                tbdireccion.Enabled = true;
                btncalcularcuotas.Visible = false;

                var datos_serie = (from a in dbSoftwareGTDataSet.tbl_series
                                   where a.id_tienda == 1 &&
                                   a.id_tipo_serie == 1
                                   select new
                                   {
                                       a.id_serie,
                                       a.serie
                                   }).SingleOrDefault();

                tbserie.Text = datos_serie.serie;
                id_serie = datos_serie.id_serie;
            }
            else
            {
                gcventas.Text = "Venta al crédito";
                lblventacontado.Text = "Venta al crédito";
                lblautorizador.Visible = true;
                lueautorizador.Visible = true;
                btnagregarfiadores.Visible = true;
                btnagregarautorizaciones.Visible = true;
                lueautorizador.Enabled = true;
                tbnombrecliente.Enabled = false;
                tbnit.Enabled = false;
                tbdireccion.Enabled = false;
                btncalcularcuotas.Visible = true;

                var datos_serie = (from a in dbSoftwareGTDataSet.tbl_series
                                   where a.id_tienda == 1 &&
                                   a.id_tipo_serie == 2
                                   select new
                                   {
                                       a.id_serie,
                                       a.serie
                                   }).SingleOrDefault();

                tbserie.Text = datos_serie.serie;
                id_serie = datos_serie.id_serie;
            }
            
            
            this.gcventas.Text = "";
            tbfecha.Text = DateTime.Now.ToShortDateString();
            
            

            tbnombrecliente.Text = "";
            tbdireccion.Text = "";
            tbnit.Text = "";
            tbidcliente.Text = "";

            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("IdBodega", typeof(int));
            dt.Columns.Add("IdProducto", typeof(int));
            dt.Columns.Add("Stock", typeof(int));
            dt.Columns.Add("Tienda", typeof(string));
            dt.Columns.Add("Bodega", typeof(string));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Cod. Producto", typeof(string));
            dt.Columns.Add("Precio A", typeof(decimal));
            dt.Columns.Add("Precio B", typeof(decimal));
            dt.Columns.Add("Precio C", typeof(decimal));
            dt.Columns.Add("Descuento", typeof(int));
            dt.Columns.Add("PrecioUnitario", typeof(decimal));
            dt.Columns.Add("NoSerie", typeof(string));

            gclistadoproductos.DataSource = dt;

            for(int i = 0; i < 4; i++)
            {
                gvlistadoproductos.Columns[i].Visible = false;
            }

            for(int i = 0; i < 12; i++)
            {
                gvlistadoproductos.Columns[i].OptionsColumn.ReadOnly = true;
                gvlistadoproductos.Columns[i].OptionsColumn.AllowEdit = false;
            }

            gvlistadoproductos.Columns[8].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvlistadoproductos.Columns[9].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvlistadoproductos.Columns[10].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvlistadoproductos.Columns[11].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvlistadoproductos.Columns[12].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvlistadoproductos.Columns[13].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;

            gvlistadoproductos.Columns[8].DisplayFormat.FormatString = "c2";
            gvlistadoproductos.Columns[9].DisplayFormat.FormatString = "c2";
            gvlistadoproductos.Columns[10].DisplayFormat.FormatString = "c2";
            gvlistadoproductos.Columns[11].DisplayFormat.FormatString = "{0:n0} %";
            gvlistadoproductos.Columns[12].DisplayFormat.FormatString = "c2";

            gvlistadoproductos.Columns[12].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;

            var vendedores_tienda = (from a in dbSoftwareGTDataSet.tbl_vendedores_tienda
                                     join b in dbSoftwareGTDataSet.tbl_vendedores on a.id_vendedor equals b.id_vendedor
                                     join c in dbSoftwareGTDataSet.tbl_usuarios on b.id_usuario equals c.id_usuario
                                     where a.id_tienda == 1
                                     select new
                                     {
                                         b.id_vendedor,
                                         c.nombre_usuario
                                     }).ToList();

            if (vendedores_tienda.Count > 0)
            {
                luevendedor.Properties.DataSource = vendedores_tienda;
                luevendedor.Properties.DisplayMember = "nombre_usuario";
                luevendedor.Properties.ValueMember = "id_vendedor";

                if(luevendedor.Properties.Columns.Count == 0)
                {
                    luevendedor.Properties.Columns.Add(new LookUpColumnInfo("id_vendedor", "Id"));
                    luevendedor.Properties.Columns.Add(new LookUpColumnInfo("nombre_usuario", "Nombre"));
                }

                luevendedor.Properties.Columns[0].Visible = false;
                //enable text editing 
                luevendedor.Properties.TextEditStyle = TextEditStyles.Standard;
            }

            var autorizadores_tienda = (from a in dbSoftwareGTDataSet.tbl_autorizadores_tienda
                                        join b in dbSoftwareGTDataSet.tbl_autorizadores_credito on a.id_autorizador equals b.id_autorizador
                                        join c in dbSoftwareGTDataSet.tbl_usuarios on b.id_usuario equals c.id_usuario
                                        where a.id_tienda == 1
                                        select new
                                        {
                                            b.id_autorizador,
                                            c.nombre_usuario
                                        }).ToList();

            
            luevendedor.EditValue = null;

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

            
            lueautorizador.EditValue = null;
            validar_autorizacion = false;

            
            cmbtipopago.EditValue = null;

            luetipomoneda.Visible = false;
            luetipomoneda.Properties.Columns[0].Visible = false;
            luetipomoneda.Properties.Columns[2].Visible = false;
            luetipomoneda.Properties.Columns[3].Visible = false;
            luetipomoneda.Properties.Columns[4].Visible = false;
            btncrearanticipo.Visible = false;
        }

        private void btnnuevaventa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Desea iniciar una nueva venta?", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                VentaForm_Load(senderForm, eForm);
            }
            else
            {
                
            }
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            if(id_tipo_venta == 1)
            {
                Buscadores.BuscadorClientes buscarclientes = new Buscadores.BuscadorClientes(id_tipo_venta, this, null, null);
                buscarclientes.ShowDialog();
            }
            else if (id_tipo_venta == 2)
            {
                Buscadores.BuscadorClientesCUI buscadorClientesCUI = new Buscadores.BuscadorClientesCUI(id_tipo_venta, this);
                buscadorClientesCUI.ShowDialog();
            }
            
        }

        private void gcventa_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnagregarproductos_Click(object sender, EventArgs e)
        {
            Buscadores.BuscadorProductos buscadorProductos = new Buscadores.BuscadorProductos(id_tipo_venta, this, null, null, null);
            buscadorProductos.ShowDialog();
        }

        private void tbcontrolventa_Leave(object sender, EventArgs e)
        {
            if(tbcontrolventa.Text != "")
            {
                int x = 0;
                if(int.TryParse(tbcontrolventa.Text, out x))
                {
                    int cv = int.Parse(tbcontrolventa.Text);
                    var cv_data = (from a in dbSoftwareGTDataSet.tbl_ventas_enc
                                    where a.control_venta == cv &&
                                    a.activo == true
                                    select a).SingleOrDefault();

                    if(cv_data != null)
                    {
                        MessageBox.Show("El control de venta ingresado ya existe en la base de datos. Por favor, inténtalo nuevamente.");
                        tbcontrolventa.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("El valor ingresado no es correcto. Inténtelo de nuevo.");
                    tbcontrolventa.Text = "";
                }
            }
        }

        public void CargarTablas()
        {
            tbl_vendedores.Fill(dbSoftwareGTDataSet.tbl_vendedores);
            tbl_vendedores_tienda.Fill(dbSoftwareGTDataSet.tbl_vendedores_tienda);
            tbl_usuarios.Fill(dbSoftwareGTDataSet.tbl_usuarios);
            tbl_autorizadores.Fill(dbSoftwareGTDataSet.tbl_autorizadores_credito);
            tbl_autorizadores_tienda.Fill(dbSoftwareGTDataSet.tbl_autorizadores_tienda);
            tbl_series.Fill(dbSoftwareGTDataSet.tbl_series);
            tbl_tipo_serie.Fill(dbSoftwareGTDataSet.tbl_tipo_serie);
            tbl_venta_enc.Fill(dbSoftwareGTDataSet.tbl_ventas_enc);
            tbl_venta_det.Fill(dbSoftwareGTDataSet.tbl_ventas_det);
            tbl_recibos_anticipos.Fill(dbSoftwareGTDataSet.tbl_recibos_anticipos);
            tbl_fiadores.Fill(dbSoftwareGTDataSet.tbl_venta_fiadores);
            tbl_ventas_aprobacion_credito.Fill(dbSoftwareGTDataSet.tbl_ventas_aprobacion_credito);
            tbl_promesas_pago_enc.Fill(dbSoftwareGTDataSet.tbl_ventas_promesas_pago_enc);
            tbl_promesas_pago_det.Fill(dbSoftwareGTDataSet.tbl_ventas_promesas_pago_det);
            tbl_venta_abonos.Fill(dbSoftwareGTDataSet.tbl_venta_abonos);
            tbl_facturacion_enc.Fill(dbSoftwareGTDataSet.tbl_facturacion_enc);
            tbl_auditoria_ventas.Fill(dbSoftwareGTDataSet.tbl_auditoria_ventas);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int count_errores_precio = 0;
            int count_errores_serie = 0;
            if (id_tipo_venta == 1)
            {
                if (gvlistadoproductos.DataRowCount > 0)
                {
                    for(int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                    {
                        decimal monto_articulo = 0;
                        monto_articulo = decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString());
                        if (gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString() == "" || monto_articulo <= 0)
                        {
                            count_errores_precio = count_errores_precio + 1;
                        }

                        if (gvlistadoproductos.GetRowCellValue(i, "NoSerie").ToString() == "")
                        {
                            count_errores_serie = count_errores_serie + 1;
                        }
                    }
                }

                if (id_serie != 0 && tbidcliente.Text != "" && gvlistadoproductos.DataRowCount > 0 && tbcontrolventa.Text != "" && luevendedor.EditValue != null && cmbtipopago.EditValue != null)
                {
                    if((int.Parse(luetipomoneda.EditValue.ToString()) == 4) && (tbbancodeposito.Text == "" || tbfechadeposito.Text == "" || tbnumeroboleta.Text == "" ))
                    {
                        MessageBox.Show("Datos incompletos. Llene todos los campos para continuar.");
                    }
                    else
                    {
                        if (count_errores_precio > 0)
                        {
                            MessageBox.Show("No se han ingresado todos los precios unitarios. Favor de revisar.");
                        }
                        else
                        {
                            if (count_errores_serie > 0)
                            {
                                MessageBox.Show("No se han ingresado todos los numeros de serie de los productos. Favor de revisar.");
                            }
                            else
                            {
                                GuardarEnvio(id_tipo_venta);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Datos incompletos. Llene todos los campos para continuar.");
                }
            }
            else if(id_tipo_venta == 2)
            {
                if(id_serie != 0 && tbidcliente.Text != "" && gvlistadoproductos.DataRowCount > 0 && tbcontrolventa.Text != "" && luevendedor.EditValue != null && cmbtipopago.EditValue != null && fiadores.Count != 0 && autorizaciones.Count != 0 && cuotas.Count != 0 && lueautorizador.EditValue != null)
                {
                    if (count_errores_precio > 0)
                    {
                        MessageBox.Show("No se han ingresado todos los precios unitarios. Favor de revisar.");
                    }
                    else
                    {
                        if (count_errores_serie > 0)
                        {
                            MessageBox.Show("No se han ingresado todos los numeros de serie de los productos. Favor de revisar.");
                        }
                        else
                        {
                            GuardarEnvio(id_tipo_venta);
                        }
                    }
                }
            }
        }

        private void cmbtipopago_EditValueChanged(object sender, EventArgs e)
        {
            if(cmbtipopago.Text == "Parcial")
            {
                btnligaranticipo.Visible = true;
                luetipomoneda.Visible = false;
                btncrearanticipo.Visible = true;
            }
            else if (cmbtipopago.Text == "Total" || cmbtipopago.EditValue == null)
            {
                luetipomoneda.Visible = true;
                btnligaranticipo.Visible = false;
                btncrearanticipo.Visible = false;
            }
        }

        private void btnagregaranticipo_Click(object sender, EventArgs e)
        {
            Buscadores.BuscadorAnticipos buscadorAnticipos = new Buscadores.BuscadorAnticipos(1, this, null);
            buscadorAnticipos.ShowDialog();
        }

        private void lueautorizador_EditValueChanged(object sender, EventArgs e)
        {
            if(lueautorizador.EditValue != null)
            {
                int id_autorizador = int.Parse(lueautorizador.EditValue.ToString());
                decimal monto_maximo_autorizar = (from a in dbSoftwareGTDataSet.tbl_autorizadores_tienda
                                                  where a.id_autorizador == id_autorizador &&
                                                  a.id_tienda == 1
                                                  select a.monto_maximo_autorizar).SingleOrDefault();

                MessageBox.Show("El monto máximo de crédito para el autorizador seleccionado es de: Q." + monto_maximo_autorizar);

                Complementos.SolicitarAutorizacion autorizacion = new Complementos.SolicitarAutorizacion(this, int.Parse(lueautorizador.EditValue.ToString()), null);
                autorizacion.ShowDialog();
            }
        }

        private void btnagregarfiadores_Click(object sender, EventArgs e)
        {
            Buscadores.BuscadorFiadores buscadorFiadores = new Buscadores.BuscadorFiadores(1, this, null);
            buscadorFiadores.ShowDialog();
        }

        private void btnagregarautorizaciones_Click(object sender, EventArgs e)
        {
            Buscadores.BuscardorAutorizaciones buscardorAutorizaciones = new Buscadores.BuscardorAutorizaciones(1, this, null);
            buscardorAutorizaciones.ShowDialog();
        }

        private void btnimprimircontrato_Click(object sender, EventArgs e)
        {
            Complementos.ImprimirContrato imprimirContrato = new Complementos.ImprimirContrato(id_venta_enc);
            imprimirContrato.ShowDialog();
        }

        private void btnimprimirpromesas_Click(object sender, EventArgs e)
        {
            Complementos.ImprimirPromesasPago imprimirPromesasPago = new Complementos.ImprimirPromesasPago(id_venta_enc);
            imprimirPromesasPago.ShowDialog();
        }

        private void btncalcularcuotas_Click(object sender, EventArgs e)
        {
            if (gvlistadoproductos.DataRowCount > 0)
            {
                decimal total_venta = 0;
                int errores = 0;
                for (int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                {
                    if (decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) > 0)
                    {
                        total_venta = total_venta + decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString());
                    }
                    else
                    {
                        MessageBox.Show("No se ha ingresado el valor unitario para todos los productos. Revise e intente nuevamente.");
                        errores = errores + 1;
                        i = gvlistadoproductos.DataRowCount;
                    }
                }

                if (errores == 0)
                {
                    monto_total_factura = total_venta;
                    Complementos.CalcularCuotas calcularCuotas = new Complementos.CalcularCuotas(2, this, monto_total_factura, abonos_aplicados, null);
                    calcularCuotas.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No ha ingresado ningún producto.");
            }
        }

        private void cmbtipopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            gcinfodeposito.Visible = false;
            luetipomoneda.EditValue = 1;
            tbbancodeposito.Text = "";
            tbnumeroboleta.Text = "";
            tbfechadeposito.Text = "";
        }

        private void btncrearanticipo_Click(object sender, EventArgs e)
        {
            Complementos.CrearAnticipo crearAnticipo = new Complementos.CrearAnticipo(id_tipo_venta, this, null);
            crearAnticipo.ShowDialog();
        }

        public void GuardarEnvio(int id)
        {
            try
            {
                if (id == 1)
                {
                    CargarTablas();
                    int correlativo = (from a in dbSoftwareGTDataSet.tbl_series
                                       where a.id_serie == id_serie
                                       select a.correlativo).Max();

                    decimal subtotal = 0;
                    decimal iva = 0;
                    decimal total = 0;

                    for (int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                    {
                        total = total + decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString());
                    }

                    iva = total * 0.12m;
                    subtotal = total - iva;

                    string info_deposito = "";
                    if(luetipomoneda.EditValue.ToString() == "3")
                    {
                        info_deposito = " Información del depósito: banco " + tbbancodeposito.Text + ", fecha depósito " + tbfechadeposito.Text + ", número de boleta " + tbnumeroboleta.Text;
                    }
                    tbl_venta_enc.Insert(int.Parse(tbidcliente.Text), tbnombrecliente.Text, tbnombrecliente.Text, tbnit.Text, id_serie, tbserie.Text, (correlativo + 1), 1, int.Parse(luevendedor.EditValue.ToString()), 1, int.Parse(tbcontrolventa.Text.ToString()), subtotal, iva, total, 1, true, DateTime.Now, 1, (comentarios_autorizaciones + info_deposito), 1, id_tipo_venta == 1 ? 1 : 2);
                    tbl_venta_enc.Update(dbSoftwareGTDataSet);
                    CargarTablas();

                    (from a in this.dbSoftwareGTDataSet.tbl_series
                     where a.id_serie == id_serie
                     select a).ToList().ForEach(a => { a.correlativo = (a.correlativo + 1); });
                    tbl_series.Update(dbSoftwareGTDataSet);
                    CargarTablas();

                    id_venta_enc = (from a in dbSoftwareGTDataSet.tbl_ventas_enc
                                        select a.id_venta_enc).Max();

                    tbl_auditoria_ventas.Insert(id_venta_enc, 1, 0, "", "", DateTime.Now, null, null, true, 1, false);
                    tbl_auditoria_ventas.Update(dbSoftwareGTDataSet);

                    for (int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                    {
                        CargarTablas();
                        int id_existencia = int.Parse(gvlistadoproductos.GetRowCellValue(i, "Id").ToString());
                        decimal precio_unitario = decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString());
                        decimal iva_unidad = precio_unitario * 0.12m;
                        decimal subtotal_unidad = precio_unitario - iva_unidad;
                        string no_serie = gvlistadoproductos.GetRowCellValue(i, "NoSerie").ToString();

                        tbl_venta_det.Insert(id_existencia, 1, precio_unitario, subtotal_unidad, iva_unidad, precio_unitario, id_venta_enc, true, DateTime.Now, 1, no_serie);
                        tbl_venta_det.Update(dbSoftwareGTDataSet);
                    }

                    
                    tbl_promesas_pago_enc.Insert(id_venta_enc, 1, DateTime.Now, DateTime.Now, true, DateTime.Now, 1, total, total);
                    tbl_promesas_pago_enc.Update(dbSoftwareGTDataSet);
                    CargarTablas();

                    var promesa_pago_enc = (from a in dbSoftwareGTDataSet.tbl_ventas_promesas_pago_enc
                                            select a).LastOrDefault();

                    tbl_promesas_pago_det.Insert(promesa_pago_enc.id_promesa_pago, total, DateTime.Now, false, DateTime.Now, 1,0,false,"",1);
                    tbl_promesas_pago_det.Update(dbSoftwareGTDataSet);
                    CargarTablas();

                    var promesa_pago_det = (from a in dbSoftwareGTDataSet.tbl_ventas_promesas_pago_det
                                            select a).LastOrDefault();
                    int id_anticipo = 0;
                    if (anticipos.Count > 0)
                    {
                        var datos_serie = (from a in dbSoftwareGTDataSet.tbl_series
                                           where a.id_tienda == 1 &&
                                           a.id_tipo_serie == 3
                                           select new
                                           {
                                               a.id_serie,
                                               a.serie,
                                               a.correlativo
                                           }).SingleOrDefault();


                        decimal abonos_aplicados = 0;
                        for(int i = 0; i < anticipos.Count; i++)
                        {
                            id_anticipo = anticipos[i].Item1;
                            if (id_anticipo == 0)
                            {
                                tbl_recibos_anticipos.Insert(anticipos[i].Item2, anticipos[i].Item3, anticipos[i].Item1, tbnombrecliente.Text, anticipos[i].Item4, DateTime.Now, true, 1, (datos_serie.correlativo + 1), 1, datos_serie.serie, datos_serie.id_serie, 2);
                                tbl_recibos_anticipos.Update(dbSoftwareGTDataSet);
                                CargarTablas();

                                id_anticipo = (from a in dbSoftwareGTDataSet.tbl_recibos_anticipos
                                               select a.id_recibos_anticipo).LastOrDefault();
                            }
                            abonos_aplicados = abonos_aplicados + anticipos[i].Item2;

                            promesa_pago_det = (from a in dbSoftwareGTDataSet.tbl_ventas_promesas_pago_det
                                                select a).LastOrDefault();

                            tbl_venta_abonos.Insert(promesa_pago_det.id_promesa_pago_det, id_anticipo, true, DateTime.Now, Configuraciones.Configuraciones.idusuario, Configuraciones.Configuraciones.idtienda, anticipos[i].Item2, 0);
                            tbl_venta_abonos.Update(dbSoftwareGTDataSet);
                            CargarTablas();
                        }
                    }

                    BloquearControles();
                    MessageBox.Show("¡Envío guardado exitosamente!");

                    if(anticipos.Count > 0)
                    {
                        DialogResult imprecibo = MessageBox.Show("Impresión de recibo", "¿Desea imprimir el recibo?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (imprecibo == DialogResult.Yes)
                        {
                            int id_recibo = (from a in dbSoftwareGTDataSet.tbl_venta_abonos
                                             join b in dbSoftwareGTDataSet.tbl_ventas_promesas_pago_det on a.id_promesa_pago_det equals b.id_promesa_pago_det
                                             join c in dbSoftwareGTDataSet.tbl_ventas_promesas_pago_enc on b.id_promesa_pago equals c.id_promesa_pago
                                             where c.id_venta_enc == id_venta_enc
                                             select a.id_recibo_anticipo).SingleOrDefault();
                            Complementos.ImprimirRecibo imprimirRecibo = new Complementos.ImprimirRecibo(id_recibo);
                            imprimirRecibo.ShowDialog();
                        }
                        else if (imprecibo == DialogResult.No)
                        {

                        }
                    }

                    DialogResult impenvio = MessageBox.Show("Impresión de envío", "¿Desea imprimir el envío?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(impenvio == DialogResult.Yes)
                    {
                        Complementos.ImprimirEnvio imprimirEnvio = new Complementos.ImprimirEnvio(id_venta_enc);
                        imprimirEnvio.ShowDialog();
                    }
                    else if (impenvio == DialogResult.No)
                    {
                        
                    }

                    DialogResult impfactura = MessageBox.Show("Impresión de factura", "¿Desea imprimir la factura?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (impfactura == DialogResult.Yes)
                    {   
                        Complementos.ImprimirEnvio imprimirEnvio = new Complementos.ImprimirEnvio(id_venta_enc);
                        imprimirEnvio.ShowDialog();
                    }
                    else if (impfactura == DialogResult.No)
                    {

                    }
                }
                else if(id == 2)
                {
                    CargarTablas();
                    int correlativo = (from a in dbSoftwareGTDataSet.tbl_series
                                       where a.id_serie == id_serie
                                       select a.correlativo).SingleOrDefault();

                    decimal subtotal = 0;
                    decimal iva = 0;
                    decimal total = 0;

                    for (int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                    {
                        total = total + decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString());
                    }

                    iva = total * 0.12m;
                    subtotal = total - iva;
                    luetipomoneda.EditValue = 1;

                    tbl_venta_enc.Insert(int.Parse(tbidcliente.Text), tbnombrecliente.Text, tbnombrecliente.Text, tbnit.Text, id_serie, tbserie.Text, (correlativo + 1), 1, int.Parse(luevendedor.EditValue.ToString()), 1, int.Parse(tbcontrolventa.Text.ToString()), subtotal, iva, total, 2, true, DateTime.Now, 1, comentarios_autorizaciones, 1, id_tipo_venta == 1 ? 1 : 2);
                    tbl_venta_enc.Update(dbSoftwareGTDataSet);
                    CargarTablas();

                    (from a in this.dbSoftwareGTDataSet.tbl_series
                     where a.id_serie == id_serie
                     select a).ToList().ForEach(a => { a.correlativo = (a.correlativo + 1); });
                    tbl_series.Update(dbSoftwareGTDataSet);
                    CargarTablas();

                    id_venta_enc = (from a in dbSoftwareGTDataSet.tbl_ventas_enc
                                        select a.id_venta_enc).Max();

                    tbl_auditoria_ventas.Insert(id_venta_enc, 1, 0, "", "", DateTime.Now, null, null, true, 1, false);
                    tbl_auditoria_ventas.Update(dbSoftwareGTDataSet);

                    for (int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                    {
                        CargarTablas();
                        int id_existencia = int.Parse(gvlistadoproductos.GetRowCellValue(i, "Id").ToString());
                        decimal precio_unitario = decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString());
                        decimal iva_unidad = precio_unitario * 0.12m;
                        decimal subtotal_unidad = precio_unitario - iva_unidad;
                        string no_serie = gvlistadoproductos.GetRowCellValue(i, "NoSerie").ToString();

                        tbl_venta_det.Insert(id_existencia, 1, precio_unitario, subtotal_unidad, iva_unidad, precio_unitario, id_venta_enc, true, DateTime.Now, 1, no_serie);
                        tbl_venta_det.Update(dbSoftwareGTDataSet);
                    }

                    if (anticipos.Count > 0)
                    {
                        for (int i = 0; i < anticipos.Count; i++)
                        {
                            CargarTablas();
                            tbl_recibos_anticipos.Insert(anticipos[i].Item2, anticipos[i].Item3, anticipos[i].Item1, tbnombrecliente.Text, anticipos[i].Item4, DateTime.Now, true, 1, 0, 1, "A", 3, 2);
                            tbl_recibos_anticipos.Update(dbSoftwareGTDataSet);
                            abonos_aplicados = abonos_aplicados + anticipos[i].Item2;
                        }
                    }

                    if(fiadores.Count > 0)
                    {
                        for (int i = 0; i < fiadores.Count; i++)
                        {
                            CargarTablas();
                            tbl_fiadores.Insert(fiadores[i].Item1, fiadores[i].Item2, fiadores[i].Item3, id_venta_enc, true, DateTime.Now, 1);
                            tbl_fiadores.Update(dbSoftwareGTDataSet);
                        }
                    }

                    if(autorizaciones.Count > 0)
                    {
                        for(int i = 0; i < autorizaciones.Count; i++)
                        {
                            CargarTablas();
                            tbl_ventas_aprobacion_credito.Insert(autorizaciones[i].Item1, id_venta_enc, true, DateTime.Now, 1);
                            tbl_ventas_aprobacion_credito.Update(dbSoftwareGTDataSet);
                        }
                    }

                    if(cuotas.Count > 0)
                    {
                        CargarTablas();
                        tbl_promesas_pago_enc.Insert(id_venta_enc, cuotas.Count, cuotas[0].Item3, cuotas[cuotas.Count - 1].Item3, true, DateTime.Now, 1, (monto_total_factura - abonos_aplicados), abonos_aplicados);
                        tbl_promesas_pago_enc.Update(dbSoftwareGTDataSet);
                        CargarTablas();
                        int id_promesa_pago = (from a in dbSoftwareGTDataSet.tbl_ventas_promesas_pago_enc
                                               where a.activo == true
                                               select a.id_promesa_pago).Max();
                        for (int i = 0; i < cuotas.Count; i++)
                        {
                            CargarTablas();
                            //tbl_promesas_pago_det.Insert(id_promesa_pago, cuotas[i].Item2, cuotas[i].Item3, true, DateTime.Now, 1);
                            tbl_promesas_pago_det.Update(dbSoftwareGTDataSet);
                        }
                    }

                    BloquearControles();
                    MessageBox.Show("¡Envío guardado exitosamente!");
                    DialogResult impenvio = MessageBox.Show("Impresión de envío", "¿Desea imprimir el envío?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (impenvio == DialogResult.Yes)
                    {
                        Complementos.ImprimirPromesasPago imprimir = new Complementos.ImprimirPromesasPago(id_venta_enc);
                        imprimir.ShowDialog();
                    }
                    else if (impenvio == DialogResult.No)
                    {

                    }

                    DialogResult impcontrato = MessageBox.Show("Impresión de contrato", "¿Desea imprimir el contrato?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (impcontrato == DialogResult.Yes)
                    {
                        Complementos.ImprimirContrato imprimirContrato = new Complementos.ImprimirContrato(id_venta_enc);
                        imprimirContrato.ShowDialog();
                    }
                    else if (impcontrato == DialogResult.No)
                    {

                    }

                    DialogResult impfactura = MessageBox.Show("Impresión de factura", "¿Desea imprimir la factura?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (impfactura == DialogResult.Yes)
                    {
                        //tbl_venta_enc.Insert(int.Parse(tbidcliente.Text), tbnombrecliente.Text, tbnombrecliente.Text, tbnit.Text, id_serie, tbserie.Text, (correlativo + 1), 1, int.Parse(luevendedor.EditValue.ToString()), 1, int.Parse(tbcontrolventa.Text.ToString()), subtotal, iva, total, 1, true, DateTime.Now, 1, comentarios_autorizaciones, 1);
                        Complementos.ImprimirEnvio imprimirEnvio = new Complementos.ImprimirEnvio(id_venta_enc);
                        imprimirEnvio.ShowDialog();
                    }
                    else if (impfactura == DialogResult.No)
                    {

                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al guardar el envío: " + e.Message);
            }
        }

        public void BloquearControles()
        {
            btnguardar.Enabled = false;
            btnagregarproductos.Enabled = false;
            btnligaranticipo.Enabled = false;
            btnbuscarcliente.Enabled = false;
            cmbtipopago.Enabled = false;
            tbnombrecliente.Enabled = false;
            tbnit.Enabled = false;
            tbdireccion.Enabled = false;
            luevendedor.Enabled = false;
            tbcontrolventa.Enabled = false;
            lueautorizador.Enabled = false;
            gclistadoproductos.Enabled = false;
            luetipomoneda.Enabled = false;
            btncrearanticipo.Enabled = false;
            int nuevo_correlativo = (from a in dbSoftwareGTDataSet.tbl_series
                                     where a.id_serie == id_serie
                                     select a.correlativo).Max();
            tbcorrelativo.Text = nuevo_correlativo.ToString();
            if(id_tipo_venta == 2)
            {
                btnimprimircontrato.Visible = true;
                btnimprimirpromesas.Visible = true;
            }
            btnagregarfiadores.Enabled = false;
            btnagregarautorizaciones.Enabled = false;
            btncalcularcuotas.Enabled = false;
        }

        private void btnlimpiarcliente_Click(object sender, EventArgs e)
        {
            tbnombrecliente.Text = "";
            tbdireccion.Text = "";
            tbnit.Text = "";
            tbidcliente.Text = "";

            if(id_tipo_venta == 1)
            {
                tbnombrecliente.Enabled = true;
                tbdireccion.Enabled = true;
                tbnit.Enabled = true;
            }
        }

        private void luetipomoneda_EditValueChanged(object sender, EventArgs e)
        {
            if(int.Parse(luetipomoneda.EditValue.ToString()) == 4)
            {
                gcinfodeposito.Visible = true;
            }
            else
            {
                gcinfodeposito.Visible = false;
            }
        }
    }
}