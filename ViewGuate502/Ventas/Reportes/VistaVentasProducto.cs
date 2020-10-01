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
    public partial class VistaVentasProducto : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = CadenaConexionSqlServer.oCnx1;
        ReportDocument rprt = new ReportDocument();
        int tipo_reporte = 0;
        int id_tienda;
        DateTime fecha_inicio;
        DateTime fecha_fin;
        public VistaVentasProducto(int tr, int it, DateTime fi, DateTime ff)
        {
            InitializeComponent();
            tipo_reporte = tr;
            id_tienda = it;
            fecha_inicio = fi;
            fecha_fin = ff;
        }

        private void VistaVentasProducto_Load(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds;
            if (tipo_reporte == 1)
            {
                rprt.Load(Application.StartupPath.Replace("\\GuateSoftware502\\bin\\Debug", "") + "\\ViewGuate502\\Ventas\\Reportes\\ReporteVentasProducto.rpt");
                cmd = new SqlCommand("Reporte_ventas_x_producto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tipo_reporte", SqlDbType.Int).Value = tipo_reporte;
                cmd.Parameters.Add("@id_tienda", SqlDbType.Int).Value = id_tienda;
                cmd.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fecha_inicio;
                cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fecha_fin;
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Configuraciones.Configuraciones.idusuario;
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                sda.Fill(ds, "Reporte_ventas_x_producto");
                rprt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rprt;
            }
            else if (tipo_reporte == 2)
            {
                rprt.Load(Application.StartupPath.Replace("\\GuateSoftware502\\bin\\Debug", "") + "\\ViewGuate502\\Ventas\\Reportes\\ReporteVentasProductoResumido.rpt");
                cmd = new SqlCommand("Reporte_ventas_producto_resumen", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tipo_reporte", SqlDbType.Int).Value = tipo_reporte;
                cmd.Parameters.Add("@id_tienda", SqlDbType.Int).Value = id_tienda;
                cmd.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fecha_inicio;
                cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fecha_fin;
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Configuraciones.Configuraciones.idusuario;
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                sda.Fill(ds, "Reporte_ventas_producto_resumen");
                rprt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rprt;
            }
            
        }
    }
}