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
    public partial class VistaHistoricoSerie : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = CadenaConexionSqlServer.oCnx1;
        ReportDocument rprt = new ReportDocument();

        int id;
        int id_tienda;
        string serie;

        public VistaHistoricoSerie(int llave, int idt, string sr)
        {
            InitializeComponent();
            id = llave;
            id_tienda = idt;
            serie = sr;
        }

        private void VistaHistoricoSerie_Load(object sender, EventArgs e)
        {
            rprt.Load(Application.StartupPath.Replace("\\GuateSoftware502\\bin\\Debug", "") + "\\ViewGuate502\\Ventas\\Consultas\\HistoricoSerie.rpt");
            SqlCommand cmd = new SqlCommand("Reporte_series_historico", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@id_tienda", SqlDbType.Int).Value = id_tienda;
            cmd.Parameters.Add("@serie", SqlDbType.VarChar).Value = serie;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Reporte_series_historico");
            rprt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rprt;
        }
    }
}