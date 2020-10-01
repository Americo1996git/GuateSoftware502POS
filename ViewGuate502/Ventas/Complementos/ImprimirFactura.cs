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
    public partial class ImprimirFactura : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = CadenaConexionSqlServer.oCnx1;
        ReportDocument rprt = new ReportDocument();
        string serie;
        int correlativo;
        int id_tienda;
        
        public ImprimirFactura(string sr, int crr, int idt)
        {
            InitializeComponent();
            serie = sr;
            correlativo = crr;
            id_tienda = idt;
        }

        private void ImprimirFactura_Load(object sender, EventArgs e)
        {
            rprt.Load(Application.StartupPath.Replace("\\GuateSoftware502\\bin\\Debug", "") + "\\ViewGuate502\\Ventas\\Complementos\\GenerarFactura.rpt");
            SqlCommand cmd = new SqlCommand("GenerarFactura", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@serie", SqlDbType.VarChar).Value = serie.ToString();
            cmd.Parameters.Add("@correlativo", SqlDbType.Int).Value = int.Parse(correlativo.ToString());
            cmd.Parameters.Add("@id_tienda", SqlDbType.Int).Value = int.Parse(Configuraciones.Configuraciones.idtienda.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "GenerarFactura");
            rprt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rprt;
        }
    }
}