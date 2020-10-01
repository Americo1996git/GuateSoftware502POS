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

namespace ViewGuate502.Cuadres
{
    public partial class FormCuadreDia : DevExpress.XtraEditors.XtraForm
    {
        public FormCuadreDia()
        {
            InitializeComponent();
        }

        private void FormCuadreDia_Load(object sender, EventArgs e)
        {
            dateEdit1.EditValue = DateTime.Now;
            lyDiferencia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lyTtoalGastos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (spinEditMonto.Value > 0)
            {
                DataTable dt = new DataTable();
                dt = ControllerMovimientoDinero.ObtenerTotalesEntradasSalidas(Configuraciones.Configuraciones.idtienda, DateTime.Now);
                if (dt.Rows.Count > 0)
                {
                    string rpt = "";
                    decimal total_ingresos;
                    decimal total_salidas;
                    total_ingresos = Convert.ToDecimal(dt.Rows[0]["total"]);
                    total_salidas = Convert.ToDecimal(dt.Rows[1]["total"]);


                    rpt = ControllerPagoCredito.GrabarEnHistorialDeCuadreDinero(Configuraciones.Configuraciones.idtienda,Configuraciones.Configuraciones.idusuario,total_ingresos,total_salidas,spinEditMonto.Value);
                    if (rpt.Equals("OK"))
                    {
                        decimal diferencia = spinEditMonto.Value - (total_ingresos - total_salidas);
                        lyDiferencia.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        lyTtoalGastos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        spinEditDiferencia.Value = diferencia;
                        spinEditTotalGastos.Value = total_salidas;
                    }
                    else
                    {
                        XtraMessageBox.Show("OCURRIO UN ERROR EN LA OPERACION. ERROR: = "+rpt,"ERROR");
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCuadreDia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnReporteCuadre_Click(object sender, EventArgs e)
        {
            FormImprimirReporte formReporte = new FormImprimirReporte();
            formReporte.id_tienda = Configuraciones.Configuraciones.idtienda;
            formReporte.fecha_inicial = DateTime.Now.Date;
            formReporte.fecha_final = DateTime.Now.Date;
            formReporte.tienda = Configuraciones.Configuraciones.tienda;
            formReporte.ShowDialog();
        }
    }
}