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
    public partial class FormCalcularMoras : DevExpress.XtraEditors.XtraForm
    {
        public FormCalcularMoras()
        {
            InitializeComponent();
        }

        private void FormCalcularMoras_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now.Date;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (spinEdit1.Value > 0)
            {
                if (XtraMessageBox.Show("DESA CONTINUAR", "CALCULO DE MORAS", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    string rpt = "";
                    rpt = ControllerPagoCredito.CalcularMoras(Configuraciones.Configuraciones.idtienda,Configuraciones.Configuraciones.idusuario,Convert.ToInt32(spinEdit1.Value));
                    if (rpt.Equals("OK"))
                    {
                        XtraMessageBox.Show("LAS MORAS SE APLICARON CON EXITO","CALCULO DE MORAS");
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("NO SE APLICARON MORAS", "CALCULO DE MORAS");
                    }
                }
            }
        }
    }
}