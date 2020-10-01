﻿using System;
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
    public partial class ImprimirEnvio : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = CadenaConexionSqlServer.oCnx1;
        ReportDocument rprt = new ReportDocument();
        int id_venta_enc = 0;
        public ImprimirEnvio(int id)
        {
            InitializeComponent();
            id_venta_enc = id;
        }

        private void ImprimirEnvio_Load(object sender, EventArgs e)
        {
            rprt.Load(Application.StartupPath.Replace("\\GuateSoftware502\\bin\\Debug", "") + "\\ViewGuate502\\Ventas\\Complementos\\GenerarEnvio.rpt");
            SqlCommand cmd = new SqlCommand("GenerarPromesasPago", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id_venta_enc;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "GenerarPromesasPago");
            rprt.Database.Tables[0].SetDataSource(ds);

            SqlCommand cmd2 = new SqlCommand("ListadoPromesasPago", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("@id_venta_enc", SqlDbType.Int).Value = id_venta_enc;
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            sda2.Fill(ds2, "ListadoPromesasPago");

            rprt.Database.Tables[1].SetDataSource(ds2);
            rprt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rprt;
        }
    }
}