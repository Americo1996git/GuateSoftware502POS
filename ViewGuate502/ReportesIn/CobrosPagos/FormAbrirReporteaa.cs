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

namespace ViewGuate502.Reportes.Cobros
{
    public partial class FormAbrirReporte : DevExpress.XtraEditors.XtraForm
    {
        public FormAbrirReporte()
        {
            InitializeComponent();
        }

        private void FormAbrirReporte_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = ControllerMostrar.TipoDePagos();
            lookUpEdit1.Properties.ValueMember = "id_tipo_pago";
            lookUpEdit1.Properties.DisplayMember = "tipo_pago";

            lookUpEdit2.Properties.DataSource = ControllerMostrar.TipoDePagos();
            lookUpEdit2.Properties.ValueMember = "id_usuario";
            lookUpEdit2.Properties.DisplayMember = "nombre_usuario";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            IngresosDiarios.FormImprimirReporte reporte = new IngresosDiarios.FormImprimirReporte(
                Configuraciones.Configuraciones.idtienda
                , Convert.ToInt32(lookUpEdit2.EditValue)
                , Convert.ToInt32(lookUpEdit1.EditValue)
                ,Configuraciones.Configuraciones.tienda
                ,Convert.ToDateTime(dateEditInicial.EditValue)
                ,Convert.ToDateTime(dateEditFinal.EditValue)
                ,"EJE"
                ,0);
            
        }
    }
}