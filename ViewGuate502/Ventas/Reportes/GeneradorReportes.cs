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

namespace ViewGuate502.Ventas.Reportes
{
    public partial class GeneradorReportes : DevExpress.XtraEditors.XtraForm
    {
        int id_reporte = 0;
        string nombre_reporte = "";
        Reportes reportes = new Reportes();
        dbSoftwareGTDataSet dbSoftwareGTDataSet = new dbSoftwareGTDataSet();
        Reporte_ventas_CCRTableAdapter reporte_Ventas_CCRTableAdapter = new Reporte_ventas_CCRTableAdapter();
        public GeneradorReportes(int ir, string nr, Reportes rpt)
        {
            InitializeComponent();
            id_reporte = ir;
            nombre_reporte = nr;
            reportes = rpt;
        }

        private void GeneradorReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet1.Tienda' Puede moverla o quitarla según sea necesario.
            this.tiendaTableAdapter.Fill(this.dbSoftwareGTDataSet1.Tienda);
            DataSet dataSet = new DataSet();
            IDictionary<string, int> dictionary = new Dictionary<string, int>();
            lbltitulo.Text = nombre_reporte;
            luetiporeporte.Properties.Columns[1].Visible = false;
            luetienda.EditValue = 1;
            luetienda.Enabled = true;
            if (id_reporte == 1 || id_reporte == 2)
            {
                luetiporeporte.Enabled = true;
            }
            else
            {
                luetiporeporte.Enabled = false;
            }

            switch(id_reporte)
            {
                case 1:
                    dictionary.Add("Por rango de fechas", 1);
                    dictionary.Add("Pendientes de facturar", 2);
                    break;
                case 2:
                    dictionary.Add("Reporte de ventas por producto (detallado)", 1);
                    dictionary.Add("Reporte de ventas por producto (resumido)", 2);
                    break;
            }

            luetiporeporte.Properties.DataSource = dictionary;
            luetiporeporte.Properties.ValueMember = "Value";
            luetiporeporte.Properties.DisplayMember = "Key";

            if(Configuraciones.Configuraciones.usuario.ToLower() != "admin")
            {
                lblidtienda.Visible = false;
                luetienda.Visible = false;
                chktodastiendas.Visible = false;
            }
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            int id_tienda;
            if(id_reporte == 1 || id_reporte == 2)
            {
                if (luetiporeporte.EditValue != null && defechainicio.EditValue != null && defechafin.EditValue != null)
                {
                    int tipo_reporte = int.Parse(luetiporeporte.EditValue.ToString());
                    if (luetienda.EditValue == null)
                    {
                        id_tienda = 0;
                    }
                    else
                    {
                        id_tienda = int.Parse(luetienda.EditValue.ToString());
                    }
                    switch (id_reporte)
                    {
                        case 1:
                            VistaEnvios vistaEnvios = new VistaEnvios(tipo_reporte, id_tienda, DateTime.Parse(defechainicio.Text), DateTime.Parse(defechafin.Text));
                            vistaEnvios.ShowDialog();
                            break;
                        case 2:
                            VistaVentasProducto vistaVentasProducto = new VistaVentasProducto(tipo_reporte, id_tienda, DateTime.Parse(defechainicio.Text), DateTime.Parse(defechafin.Text));
                            vistaVentasProducto.ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Completa todos los campos del formulario para continuar.");
                }
            }
            else
            {
                if (defechainicio.EditValue != null && defechafin.EditValue != null)
                {
                    if (luetienda.EditValue == null)
                    {
                        id_tienda = 0;
                    }
                    else
                    {
                        id_tienda = int.Parse(luetienda.EditValue.ToString());
                    }
                    switch (id_reporte)
                    {
                        case 3:
                            VistaFacturacion vistaFacturacion = new VistaFacturacion(1, id_tienda, DateTime.Parse(defechainicio.Text), DateTime.Parse(defechafin.Text));
                            vistaFacturacion.ShowDialog();
                            break;
                        case 4:
                            VistaVentasCliente vistaVentasCliente = new VistaVentasCliente(1, id_tienda, DateTime.Parse(defechainicio.Text), DateTime.Parse(defechafin.Text));
                            vistaVentasCliente.ShowDialog();
                            break;
                        case 5:
                            VistaLibroVentasEspecial vistaLibroVentasEspecial = new VistaLibroVentasEspecial(id_tienda, DateTime.Parse(defechainicio.Text), DateTime.Parse(defechafin.Text), 0);
                            vistaLibroVentasEspecial.ShowDialog();
                            break;
                        case 6:
                            gcresultados.Visible = true;
                            reporte_Ventas_CCRTableAdapter.Fill(dbSoftwareGTDataSet.Reporte_ventas_CCR, id_tienda, DateTime.Parse(defechainicio.Text), DateTime.Parse(defechafin.Text));
                            var results = reporte_Ventas_CCRTableAdapter.GetData(1, DateTime.Parse(defechainicio.Text), DateTime.Parse(defechafin.Text)).FirstOrDefault();
                            tbcontado.Text = results.contado.ToString();
                            tbcredito.Text = results.credito.ToString();
                            tbsubtotal.Text = results.subtotal.ToString();
                            tbrenegociadas.Text = results.renegociadas.ToString();
                            tbservicios.Text = results.servicios.ToString();
                            break;
                        case 7:
                            VistaVentasClienteTienda vistaVentasClienteTienda = new VistaVentasClienteTienda(1, id_tienda, DateTime.Parse(defechainicio.Text), DateTime.Parse(defechafin.Text));
                            vistaVentasClienteTienda.ShowDialog();
                            break;
                        case 8:
                            VistaFrecuenciaClientes vistaFrecuenciaClientes = new VistaFrecuenciaClientes(1, id_tienda, DateTime.Parse(defechainicio.Text), DateTime.Parse(defechafin.Text));
                            vistaFrecuenciaClientes.ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fecha de inicio y final para generar el reporte.");
                }
            }
        }

        private void GeneradorReportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportes.luereporte.EditValue = null;
        }

        private void chktodastiendas_CheckedChanged(object sender, EventArgs e)
        {
            if(chktodastiendas.Checked)
            {
                luetienda.EditValue = null;
                luetienda.Enabled = false;
            }
            else
            {
                luetienda.EditValue = 1;
                luetienda.Enabled = true;
            }
            
        }
    }
}