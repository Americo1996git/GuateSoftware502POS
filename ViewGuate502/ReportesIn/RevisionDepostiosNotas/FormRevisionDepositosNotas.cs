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
using ControllerSoft502;
using DevExpress.XtraEditors.Controls;

namespace ViewGuate502.Reportes.RevisionDepostiosNotas
{
    public partial class FormRevisionDepositosNotas : DevExpress.XtraEditors.XtraForm
    {
        public FormRevisionDepositosNotas()
        {
            InitializeComponent();
        }

        private void btnProceder_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ControllerPagoCredito.MostrarPagosNotas(Configuraciones.Configuraciones.idtienda, Convert.ToDateTime(dateEditInicial.EditValue), Convert.ToDateTime(dateEditFinal.EditValue), Convert.ToInt32(radioGroup1.EditValue),0);
            gridControl1.DataSource = dt;
            gridControl1.ForceInitialize();
            gridView1.BestFitColumns();
            if (dt.Rows.Count > 0)
            {
                gridView1.Columns["id_recibos_anticipo"].Visible = false;
                gridView1.Columns["id_tipo_pago"].Visible = false;
                gridView1.Columns["id_cliente"].Visible = false;
                gridView1.Columns["id_promesa_pago"].Visible = false;
                gridView1.Columns["BOLETA"].Visible = false;
                gridView1.Columns["BANCO"].Visible = false;
            }
        }

        private void FormRevisionDepositosNotas_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ControllerMostrar.TiposDePagos();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    radioGroup1.Properties.Items.Add(new RadioGroupItem(dt.Rows[i]["id_tipo_pago"], Convert.ToString(dt.Rows[i]["tipo_pago"])));
                }
                radioGroup1.SelectedIndex = 0;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRevisionDepositosNotas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                Cobros.FormImprimirEstadoDeCuenta modal = new Cobros.FormImprimirEstadoDeCuenta();
                modal.id_promesas_enca = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id_promesa_pago"));
                modal.cliente = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "cliente"));
                modal.producto = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "producto"));
                modal.ShowDialog();
            }
        }
    }
}