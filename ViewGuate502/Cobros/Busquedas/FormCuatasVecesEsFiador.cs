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
using ViewGuate502.DataSetReportesTableAdapters;
using ControllerSoft502;
namespace ViewGuate502.Cobros.Busquedas
{
    public partial class FormCuatasVecesEsFiador : DevExpress.XtraEditors.XtraForm
    {
        DataSetReportes DataReportes = new DataSetReportes();
        SPMostrar_BusquedaDeCodeudoresTableAdapter lista_deudores = new SPMostrar_BusquedaDeCodeudoresTableAdapter();

        public FormCuatasVecesEsFiador()
        {
            InitializeComponent();
        }

        private void FormCuatasVecesEsFiador_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                bool mostrar = true;
                DataTable dt = new DataTable();

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
              
                    dt = ControllerPagoCredito.MostrarDeudores(Configuraciones.Configuraciones.idtienda, "______000");
                    gridControl1.DataSource = dt;
                    gridControl1.ForceInitialize();
                    gridView1.BestFitColumns();
                }


                if (mostrar)
                {
                    dt = ControllerPagoCredito.MostrarDeudores(Configuraciones.Configuraciones.idtienda, txtBuscar.Text);
                    if (dt.Rows.Count > 0)
                    {
                        gridControl1.DataSource = dt;
                        gridControl1.ForceInitialize();
                        gridView1.BestFitColumns();
                       
                    }
                    else
                    {
                        gridControl1.DataSource = dt;
                        gridControl1.ForceInitialize();
                        gridView1.BestFitColumns();
                    }

                }
                gridView1.Columns["id_venta_enc"].Visible = false;
                gridView1.Columns["id_cliente"].Visible = false;
                gridView1.Columns["id_tipo_venta"].Visible = false;
                gridView1.Columns["activo"].Visible = false;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCuatasVecesEsFiador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}