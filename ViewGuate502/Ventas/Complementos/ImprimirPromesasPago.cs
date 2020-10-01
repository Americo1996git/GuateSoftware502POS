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
    public partial class ImprimirPromesasPago : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = CadenaConexionSqlServer.oCnx1;
        ReportDocument rprt = new ReportDocument();
        int id_venta_enc = 0;
        public ImprimirPromesasPago(int id)
        {
            InitializeComponent();
            id_venta_enc = id;
        }

        private void ImprimirPromesasPago_Load(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds;

            rprt.Load(Application.StartupPath.Replace("\\GuateSoftware502\\bin\\Debug", "") + "\\ViewGuate502\\Ventas\\Complementos\\GenerarPromesasPago.rpt");
            cmd = new SqlCommand("GenerarPromesasPago", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id_venta_enc;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "GenerarPromesasPago");
            rprt.Database.Tables[0].SetDataSource(ds);

            cmd = new SqlCommand("ListadoPromesasPago", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id_venta_enc;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "ListadoPromesasPago");
            rprt.Database.Tables[1].SetDataSource(ds);

            cmd = new SqlCommand("Reporte_EC_PRD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id_venta_enc;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "Reporte_EC_PRD");
            rprt.Database.Tables[2].SetDataSource(ds);

            rprt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rprt;
        }
    }
}