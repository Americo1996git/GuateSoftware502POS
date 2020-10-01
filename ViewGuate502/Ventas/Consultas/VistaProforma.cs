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

namespace ViewGuate502.Ventas.Consultas
{
    public partial class VistaProforma : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = CadenaConexionSqlServer.oCnx1;
        ReportDocument rprt = new ReportDocument();
        int id_proforma;

        public VistaProforma(int idp)
        {
            InitializeComponent();
            id_proforma = idp;
        }

        private void VistaProforma_Load(object sender, EventArgs e)
        {
            rprt.Load(Application.StartupPath.Replace("\\GuateSoftware502\\bin\\Debug", "") + "\\ViewGuate502\\Ventas\\Consultas\\Proforma.rpt");
            SqlCommand cmd = new SqlCommand("Generar_proforma", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_proforma", SqlDbType.Int).Value = id_proforma;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Generar_proforma");
            rprt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rprt;
        }
    }
}