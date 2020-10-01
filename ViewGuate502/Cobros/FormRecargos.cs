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


namespace ViewGuate502.Cobros
{
    public partial class FormRecargos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int id_promesa_pago_enc, correlativo;
        public string serie;
        public int envio;
        public FormRecargos()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRecargos_Load(object sender, EventArgs e)
        {
            spinEditMonto.Focus();
            dateEdit1.EditValue = DateTime.Now;
            txtEnvio.Text = envio.ToString();
            txtSerie.Text = serie;
            gridControlRecargos.DataSource = ControllerPagoCredito.MostrarDetalleDeRecargos(id_promesa_pago_enc);
            gridControlRecargos.ForceInitialize();
            gridViewRecargos.BestFitColumns();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool agregar = true;
            string rpta = "";
            if (Convert.ToDecimal(spinEditMonto.EditValue) == 0)
            {
                XtraMessageBox.Show("El monto debe ser mayor a 0","Agregando recargos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                agregar = false;
                spinEditMonto.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                XtraMessageBox.Show("Debe escribir la descripción de forma correcta", "Agregando recargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                agregar = false;
                txtDescripcion.Focus();
            }

            if (agregar)
            {
                if (gridViewRecargos.DataRowCount > 0)
                {
                    int utlima_fila = (gridViewRecargos.DataRowCount)-1;
                    correlativo = Convert.ToInt32(gridViewRecargos.GetRowCellValue(utlima_fila, "correlativo"));
                }
                rpta = ControllerPagoCredito.AgregarRecargos(Configuraciones.Configuraciones.idtienda,id_promesa_pago_enc,Configuraciones.Configuraciones.idusuario,correlativo+1,Convert.ToDecimal(spinEditMonto.EditValue),txtDescripcion.Text,Convert.ToDateTime(dateEdit1.EditValue),2);
                if (rpta == "OK")
                {
                    gridControlRecargos.DataSource = ControllerPagoCredito.MostrarDetalleDeRecargos(id_promesa_pago_enc);
                    gridControlRecargos.ForceInitialize();
                    gridViewRecargos.BestFitColumns();
                    spinEditMonto.EditValue = 0;
                    txtDescripcion.Text = string.Empty;
                    spinEditMonto.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un erro al crear el recargo, por favor consulte a su administrador de datos", "Error recargos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}