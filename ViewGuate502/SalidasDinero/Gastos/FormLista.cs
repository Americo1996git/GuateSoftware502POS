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
using ControllerSoft502;

namespace ViewGuate502.SalidasDinero.Gastos
{
    public partial class FormLista : DevExpress.XtraEditors.XtraForm
    {
        string tipo_de_lista;
        DataTable dt;
        public FormLista(string tipo_lista)
        {
            InitializeComponent();
            tipo_de_lista = tipo_lista;
        }

        private void FormLista_Load(object sender, EventArgs e)
        {
            if (tipo_de_lista.Equals("EDICION"))
            {
                emptySpaceItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                emptySpaceItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                emptySpaceItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyGastos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyOpciones.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyFechaInicial.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyFechaFinal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyBtnProcesar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyBtnVerReporte.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyCheck.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                dt = new DataTable();
                dt = ControllerMovimientoDinero.MostrarSalidasGastos(Configuraciones.Configuraciones.idtienda, DateTime.Now.Date, DateTime.Now.Date,0,Configuraciones.Configuraciones.idusuario,66);
                gridControl1.DataSource = dt;
                gridControl1.ForceInitialize();
                gridView1.BestFitColumns();
                this.Text = "SALIDAS POR GASTOS DEL DIA";
            }
            if (tipo_de_lista.Equals("REPORTE"))
            {
                this.Text = "VER REPORTE DE SALIDAS POR GASTOS";
                lyLista.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyBtnEditar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyBtnProcesar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                emptySpaceItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                emptySpaceItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                emptySpaceItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                lyOpciones.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                this.Width = 600;
                this.Height = 250;
                this.StartPosition = FormStartPosition.CenterScreen;


                lookUpEditGastos.Properties.DataSource = ControllerMostrar.TiposDeGastos();
                lookUpEditGastos.Properties.DisplayMember = "nombre";
                lookUpEditGastos.Properties.ValueMember = "id_tipo_salida_dinero";
            }

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //dt = new DataTable();
            //dt = ControllerMovimientoDinero.MostrarSalidasGastos(Configuraciones.Configuraciones.idtienda, DateTime.Now.Date, DateTime.Now.Date, 0, 0, 0);
            //gridControl1.DataSource = dt;
            //gridControl1.ForceInitialize();
            //gridView1.BestFitColumns();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                if (Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "fecha_creacion")) == DateTime.Now.Date)
                {
                    bool SeEdito = false;
                    FormNuevoGasto form = new FormNuevoGasto("EDITAR");
                    form.id_salida_dinero = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id_salida_dinero"));
                    form.txtSerieFactura.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "serie_factura"));
                    form.spinEditMonto.Value = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "monto"));
                    form.spinEditCorrelativo.Value = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "correlativo_factura"));
                    form.lookUpEditGastos.EditValue = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id_tipo_salida_dinero"));
                    form.txtDestino.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "destino"));
                    form.txtObservaciones.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "observaciones"));
                    form.ShowDialog();

                    dt = new DataTable();
                    dt = ControllerMovimientoDinero.MostrarSalidasGastos(Configuraciones.Configuraciones.idtienda, DateTime.Now.Date, DateTime.Now.Date, 0, Configuraciones.Configuraciones.idusuario, 66);
                    gridControl1.DataSource = dt;
                    gridControl1.ForceInitialize();
                    gridView1.BestFitColumns();

                }
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                lookUpEditGastos.Enabled = false;
            }
            if (!checkEdit1.Checked)
            {
                lookUpEditGastos.Enabled = true;
            }
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            FormImprimirReporte formReporte = new FormImprimirReporte();
            formReporte.id_tienda = Configuraciones.Configuraciones.idtienda;
            formReporte.fecha_inicial = dateEdit1.DateTime.Date;
            formReporte.fecha_final = dateEdit2.DateTime.Date;
            formReporte.id_usuario = Configuraciones.Configuraciones.idusuario;
            formReporte.id_tipo_salida_dinero = Convert.ToInt32(lookUpEditGastos.EditValue);
            formReporte.opcion = checkEdit1.Checked == true ? 1 : 2;
            formReporte.ShowDialog();
        }
    }
}