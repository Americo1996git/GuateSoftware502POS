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

namespace ViewGuate502.Ventas.Reportes
{
    public partial class VistaEnvioCompleto : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = CadenaConexionSqlServer.oCnx1;
        ReportDocument rprt = new ReportDocument();
        int id_tienda;
        int id_venta_enc;
        
        public VistaEnvioCompleto(int it, int ive)
        {
            InitializeComponent();
            id_tienda = it;
            id_venta_enc = ive;
        }

        private void VistaEnvioCompleto_Load(object sender, EventArgs e)
        {
            rprt.Load(Application.StartupPath.Replace("\\GuateSoftware502\\bin\\Debug", "") + "\\ViewGuate502\\Ventas\\Reportes\\ReporteEnvioCompleto.rpt");

            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds;

            cmd = new SqlCommand("Reporte_EC_ENC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_tienda", SqlDbType.Int).Value = id_tienda;
            cmd.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id_venta_enc;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "Reporte_EC_ENC");
            rprt.Database.Tables[0].SetDataSource(ds);

            cmd = new SqlCommand("Reporte_EC_PRD", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id_venta_enc;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "Reporte_EC_PRD");
            rprt.Database.Tables[1].SetDataSource(ds);

            cmd = new SqlCommand("Reporte_EC_PP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id_venta_enc;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "Reporte_EC_PP");
            rprt.Database.Tables[2].SetDataSource(ds);

            cmd = new SqlCommand("Reporte_EC_LF", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id_venta_enc;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "Reporte_EC_LF");
            rprt.Database.Tables[3].SetDataSource(ds);

            cmd = new SqlCommand("Reporte_EC_LF", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id_venta_enc;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "Reporte_EC_LF");
            rprt.Database.Tables[3].SetDataSource(ds);

            cmd = new SqlCommand("Reporte_EC_LAC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id_venta_enc;
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "Reporte_EC_LAC");
            rprt.Database.Tables[4].SetDataSource(ds);

            rprt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rprt;

            /*rprt.Load(@"D:\Proyectos\GuateSoftware502\ViewGuate502\Ventas\Reportes\ReporteEnvioCompleto.rpt");
            SqlCommand cmd = new SqlCommand("Reporte_EC_ENC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_tienda", SqlDbType.Int).Value = id_tienda;
            cmd.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id_venta_enc;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Reporte_EC_ENC");
            rprt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rprt;*/
        }
    }
}
 