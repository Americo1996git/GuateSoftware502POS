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
    public partial class VistaLibroVentasEspecial : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = CadenaConexionSqlServer.oCnx1;
        ReportDocument rprt = new ReportDocument();
        int id_tienda;
        DateTime fecha_inicio;
        DateTime fecha_fin;
        int id_linea;

        public VistaLibroVentasEspecial(int it, DateTime fi, DateTime ff, int il)
        {
            InitializeComponent();
            id_tienda = it;
            fecha_inicio = fi;
            fecha_fin = ff;
            id_linea = il;
        }

        private void VistaLibroVentasEspecial_Load(object sender, EventArgs e)
        {
            rprt.Load(Application.StartupPath.Replace("\\GuateSoftware502\\bin\\Debug", "") + "\\ViewGuate502\\Ventas\\Reportes\\ReporteLibroVentasEspecial.rpt");
            SqlCommand cmd = new SqlCommand("Reporte_Libro_Ventas_Especial", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_tienda", SqlDbType.Int).Value = id_tienda;
            cmd.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fecha_inicio;
            cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fecha_fin;
            cmd.Parameters.Add("@id_linea", SqlDbType.Int).Value = id_linea;
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Configuraciones.Configuraciones.idusuario;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Reporte_Libro_Ventas_Especial");
            rprt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rprt;
        }
    }
}