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

namespace ViewGuate502.Ventas.Consultas
{
    public partial class HistoricoSeries : DevExpress.XtraEditors.XtraForm
    {
        dbSoftwareGTDataSet db = new dbSoftwareGTDataSet();
        tbl_ventas_encTableAdapter tbl_ventas_enc = new tbl_ventas_encTableAdapter();
        tbl_ventas_detTableAdapter tbl_ventas_det = new tbl_ventas_detTableAdapter();
        tbl_tipos_documentoTableAdapter tbl_tipos_documento = new tbl_tipos_documentoTableAdapter();
        TiendaTableAdapter tbl_tiendas = new TiendaTableAdapter();
        int id_tienda = 1;

        public HistoricoSeries()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if(tbserie.Text != "")
            {
                CargarTablas();

                DataTable dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("No. Serie");
                dt.Columns.Add("Fecha");
                dt.Columns.Add("Tienda");
                dt.Columns.Add("TipoDocumento");
                dt.Columns.Add("No. Docto");
                gclistadoseries.DataSource = dt;

                gvlistadoseries.Columns[0].Visible = false;

                string serie = tbserie.Text;
                var info_serie = (from a in db.tbl_ventas_enc
                                  join b in db.tbl_ventas_det on a.id_venta_enc equals b.id_venta_enc
                                  join c in db.tbl_tipos_documento on a.id_tipo_documento equals c.id_tipo_documento
                                  join d in db.Tienda on a.id_tienda equals d.idtienda
                                  where b.no_serie_articulos.Contains(serie)
                                  && a.activo == true
                                  select new
                                  {
                                      a.id_venta_enc,
                                      b.no_serie_articulos,
                                      a.fecha_creacion,
                                      tienda = (d.nombre + '-' + d.ubicacion),
                                      c.tipo_documento,
                                      envio = (a.serie + '-' + a.correlativo)
                                  }).ToList();

                if (info_serie != null)
                {
                    foreach (var a in info_serie)
                    {
                        gvlistadoseries.AddNewRow();

                        int rowHandle = gvlistadoseries.GetRowHandle(gvlistadoseries.DataRowCount);
                        if (gvlistadoseries.IsNewItemRow(rowHandle))
                        {
                            gvlistadoseries.SetRowCellValue(rowHandle, gvlistadoseries.Columns[0], a.id_venta_enc.ToString());
                            gvlistadoseries.SetRowCellValue(rowHandle, gvlistadoseries.Columns[1], a.no_serie_articulos.ToString());
                            gvlistadoseries.SetRowCellValue(rowHandle, gvlistadoseries.Columns[2], a.fecha_creacion.ToString());
                            gvlistadoseries.SetRowCellValue(rowHandle, gvlistadoseries.Columns[3], a.tienda.ToString());
                            gvlistadoseries.SetRowCellValue(rowHandle, gvlistadoseries.Columns[4], a.tipo_documento.ToString());
                            gvlistadoseries.SetRowCellValue(rowHandle, gvlistadoseries.Columns[5], a.envio.ToString());
                            gvlistadoseries.UpdateCurrentRow();
                        }
                    }
                }
            }
        }

        public void CargarTablas()
        {
            tbl_ventas_enc.Fill(db.tbl_ventas_enc);
            tbl_ventas_det.Fill(db.tbl_ventas_det);
            tbl_tipos_documento.Fill(db.tbl_tipos_documento);
            tbl_tiendas.Fill(db.Tienda);
        }

        private void HistoricoSeries_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("No. Serie");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Tienda");
            dt.Columns.Add("TipoDocumento");
            dt.Columns.Add("No. Docto");
            gclistadoseries.DataSource = dt;
            gvlistadoseries.Columns[0].Visible = false;
        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
            if(gvlistadoseries.RowCount > 0)
            {
                int id = int.Parse(gvlistadoseries.GetRowCellValue(gvlistadoseries.FocusedRowHandle, "Id").ToString());
                string serie = gvlistadoseries.GetRowCellValue(gvlistadoseries.FocusedRowHandle, "No. Serie").ToString();
                VistaHistoricoSerie vistaHistoricoSerie = new VistaHistoricoSerie(id, id_tienda, serie);
                vistaHistoricoSerie.ShowDialog();
            }
        }
    }
}