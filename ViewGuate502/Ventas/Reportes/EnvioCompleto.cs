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
using ViewGuate502.dbSoftwareGTDataSetTableAdapters;

namespace ViewGuate502.Ventas.Reportes
{
    public partial class EnvioCompleto : DevExpress.XtraEditors.XtraForm
    {
        dbSoftwareGTDataSet db = new dbSoftwareGTDataSet();
        tbl_seriesTableAdapter tbl_Series = new tbl_seriesTableAdapter();
        tbl_ventas_encTableAdapter tbl_Ventas_Enc = new tbl_ventas_encTableAdapter();
        int id_serie = 0;
        int id_venta_enc = 0;
        int correlativo = 0;
        int id_tienda = Configuraciones.Configuraciones.idtienda;

        public EnvioCompleto()
        {
            InitializeComponent();
        }

        private void EnvioCompleto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.Tienda' Puede moverla o quitarla según sea necesario.
            this.tiendaTableAdapter.Fill(this.dbSoftwareGTDataSet.Tienda);
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.tbl_series' Puede moverla o quitarla según sea necesario.
            this.tbl_seriesTableAdapter.Fill(this.dbSoftwareGTDataSet.tbl_series);
            this.tbl_Ventas_Enc.Fill(db.tbl_ventas_enc);
            tbl_Series.Fill(db.tbl_series);
            lueserie.ReadOnly = true;
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            if(tbcorrelativo.Text != "")
            {
                correlativo = int.Parse(tbcorrelativo.Text);
            }
            id_venta_enc = (from a in db.tbl_ventas_enc
                            where a.id_serie == id_serie
                            && a.correlativo == correlativo
                            select a.id_venta_enc).FirstOrDefault();

            VistaEnvioCompleto vistaEnvioCompleto = new VistaEnvioCompleto(id_tienda, id_venta_enc);
            vistaEnvioCompleto.ShowDialog();
        }

        private void luetienda_EditValueChanged(object sender, EventArgs e)
        {
            if(luetienda.EditValue != null)
            {
                int id_tienda = int.Parse(luetienda.EditValue.ToString());
                BindingSource src = new BindingSource();
                src.DataSource = db.tbl_series.Where(a => a.id_tienda == id_tienda && (new int[] { 1, 2}).Contains(a.id_tipo_serie) && a.activo == true && a.id_tipo_documento == 4).ToList();
                lueserie.Properties.DataSource = src.List;
                lueserie.ReadOnly = false;
            }
        }

        private void lueserie_EditValueChanged(object sender, EventArgs e)
        {
            if(lueserie.EditValue != null)
            {
                id_serie = int.Parse(lueserie.EditValue.ToString());
            }
        }
    }
}