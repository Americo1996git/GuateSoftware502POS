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

namespace ViewGuate502.Bancos
{
    public partial class FormConfigurarPagos : DevExpress.XtraEditors.XtraForm
    {
        public FormConfigurarPagos()
        {
            InitializeComponent();
        }

        private void FormConfigurarPagos_Load(object sender, EventArgs e)
        {
            lookUpEditCuentaBancaria.Properties.DataSource = ControllerMostrar.CuentasBancarias();
            lookUpEditCuentaBancaria.Properties.DisplayMember = "nombre";
        }
    }
}