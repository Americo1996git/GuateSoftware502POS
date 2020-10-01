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
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using ModelSoft502;

namespace ViewGuate502.Ventas.Complementos
{
    public partial class ImprimirRecibo : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = CadenaConexionSqlServer.oCnx1;
        ReportDocument rprt = new ReportDocument();
        int id_recibo = 0;
        public ImprimirRecibo(int id)
        {
            InitializeComponent();
            id_recibo = id;
        }

        private void ImprimirRecibo_Load(object sender, EventArgs e)
        {
            rprt.Load(Application.StartupPath.Replace("\\GuateSoftware502\\bin\\Debug", "") + "\\ViewGuate502\\Ventas\\Complementos\\GenerarRecibo.rpt");
            SqlCommand cmd = new SqlCommand("GenerarRecibo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_recibo", SqlDbType.Int).Value = id_recibo;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "GenerarRecibo");
            rprt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rprt;
        }
    }
}