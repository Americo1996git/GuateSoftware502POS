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

namespace ViewGuate502.CuentasxCobrar.Formularios
{
    public partial class BuscarCreditoCliente : DevExpress.XtraEditors.XtraForm
    {
        public BuscarCreditoCliente()
        {
            InitializeComponent();
        }

        private void BuscarCreditoCliente_Load(object sender, EventArgs e)
        {
            cXCClientes_con_creditoTableAdapter.Fill(this.dbSoftwareGTDataSet.CXCClientes_con_credito, 1);
        }
    }
}