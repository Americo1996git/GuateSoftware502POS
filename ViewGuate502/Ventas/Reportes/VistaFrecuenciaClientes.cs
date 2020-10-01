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
    public partial class VistaFrecuenciaClientes : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = CadenaConexionSqlServer.oCnx1;
        ReportDocument rprt = new ReportDocument();
        int tipo_reporte = 0;
        int id_tienda;
        DateTime fecha_inicio;
        DateTime fecha_fin;
        public VistaFrecuenciaClientes(int tr, int it, DateTime fi, DateTime ff)
        {
            InitializeComponent();
            tipo_reporte = tr;
            id_tienda = it;
            fecha_inicio = fi;
            fecha_fin = ff;
        }

        private void VistaFrecuenciaClientes_Load(object sender, EventArgs e)
        {
            rprt.Load(Application.StartupPath.Replace("\\GuateSoftware502\\bin\\Debug", "") + "\\ViewGuate502\\Ventas\\Reportes\\ReporteFrecuenciaClientes.rpt");
            SqlCommand cmd = new SqlCommand("Reporte_frecuencia_clientes", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tipo_reporte", SqlDbType.Int).Value = tipo_reporte;
            cmd.Parameters.Add("@id_tienda", SqlDbType.Int).Value = id_tienda;
            cmd.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fecha_inicio;
            cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fecha_fin;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Reporte_frecuencia_clientes");
            rprt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rprt;
        }
    }
}