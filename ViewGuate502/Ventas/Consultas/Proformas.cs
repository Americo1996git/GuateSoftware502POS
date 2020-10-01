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
    public partial class Proformas : DevExpress.XtraEditors.XtraForm
    {
        public DataTable dt;
        decimal monto_total_factura = 0;
        decimal abonos_aplicados = 0;
        dbSoftwareGTDataSet db = new dbSoftwareGTDataSet();
        tbl_proforma_encTableAdapter tbl_Proforma_EncTableAdapter = new tbl_proforma_encTableAdapter();
        tbl_proforma_detTableAdapter tbl_Proforma_DetTableAdapter = new tbl_proforma_detTableAdapter();
        tbl_seriesTableAdapter tbl_SeriesTableAdapter = new tbl_seriesTableAdapter();
        int id_proforma = 0;

        public Proformas()
        {
            InitializeComponent();
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            Buscadores.BuscadorClientes buscadorClientes = new Buscadores.BuscadorClientes(1, null, this, null);
            buscadorClientes.ShowDialog();
        }

        private void btnagregarproductos_Click(object sender, EventArgs e)
        {
            Buscadores.BuscadorProductos buscadorProductos = new Buscadores.BuscadorProductos(1, null, null, this, null);
            buscadorProductos.ShowDialog();
        }

        private void Proformas_Load(object sender, EventArgs e)
        {
            tbanticipo.Text = "0";
            tbcantpagos.Text = "0";
            tbvalorcuota.Text = "0";
            tbanticipo.ReadOnly = true;
            tbcantpagos.ReadOnly = true;
            btncalcularcuotas.Enabled = false;
            btnimprimir.Enabled = false;

            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("IdBodega", typeof(int));
            dt.Columns.Add("IdProducto", typeof(int));
            dt.Columns.Add("Stock", typeof(int));
            dt.Columns.Add("Tienda", typeof(string));
            dt.Columns.Add("Bodega", typeof(string));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Cod. Producto", typeof(string));
            dt.Columns.Add("Precio A", typeof(decimal));
            dt.Columns.Add("Precio B", typeof(decimal));
            dt.Columns.Add("Precio C", typeof(decimal));
            dt.Columns.Add("Descuento", typeof(int));
            dt.Columns.Add("PrecioUnitario", typeof(decimal));

            gclistadoproductos.DataSource = dt;

            for (int i = 0; i < 4; i++)
            {
                gvlistadoproductos.Columns[i].Visible = false;
            }

            for (int i = 0; i < 12; i++)
            {
                gvlistadoproductos.Columns[i].OptionsColumn.ReadOnly = true;
                gvlistadoproductos.Columns[i].OptionsColumn.AllowEdit = false;
            }

            gvlistadoproductos.Columns[8].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvlistadoproductos.Columns[9].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvlistadoproductos.Columns[10].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvlistadoproductos.Columns[11].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gvlistadoproductos.Columns[12].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;

            gvlistadoproductos.Columns[8].DisplayFormat.FormatString = "c2";
            gvlistadoproductos.Columns[9].DisplayFormat.FormatString = "c2";
            gvlistadoproductos.Columns[10].DisplayFormat.FormatString = "c2";
            gvlistadoproductos.Columns[11].DisplayFormat.FormatString = "{0:n0} %";
            gvlistadoproductos.Columns[12].DisplayFormat.FormatString = "c2";

            gvlistadoproductos.Columns[12].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
        }

        private void btncalcularcuotas_Click(object sender, EventArgs e)
        {
            if (gvlistadoproductos.DataRowCount > 0)
            {
                decimal total_venta = 0;
                int errores = 0;
                if(tbanticipo.Text != "" && decimal.Parse(tbanticipo.Text) > 0)
                {
                    abonos_aplicados = decimal.Parse(tbanticipo.Text);
                }
                for (int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                {
                    if (decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) > 0)
                    {
                        total_venta = total_venta + decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString());
                    }
                    else
                    {
                        MessageBox.Show("No se ha ingresado el valor unitario para todos los productos. Revise e intente nuevamente.");
                        errores = errores + 1;
                        i = gvlistadoproductos.DataRowCount;
                    }
                }

                if (errores == 0)
                {
                    int cant_cuotas = 0;
                    if (tbcantpagos.Text != "")
                    {
                        cant_cuotas = int.Parse(tbcantpagos.Text);
                    }
                    
                    monto_total_factura = total_venta;
                    if(cant_cuotas != 0)
                    {
                        tbvalorcuota.Text = (decimal.Round((monto_total_factura - abonos_aplicados) / (cant_cuotas), 2)).ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No ha ingresado ningún producto.");
            }
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            CargarTablas();
            decimal anticipo = 0;
            decimal monto_cuota = 0;
            int cant_cuotas = 0;

            if (tbanticipo.Text == "")
            {
                tbanticipo.Text = anticipo.ToString();
            }

            if(tbcantpagos.Text == "")
            {
                tbcantpagos.Text = cant_cuotas.ToString();
            }

            if(tbvalorcuota.Text == "")
            {
                tbvalorcuota.Text = monto_cuota.ToString();
            }

            if(gvlistadoproductos.RowCount == 0 || tbidcliente.Text == "")
            {
                MessageBox.Show("Complete la información para generar la proforma.");
            }
            else
            {
                int id_tienda = 1;
                decimal total_proforma = 0;
                for(int i = 0; i < gvlistadoproductos.RowCount; i++)
                {
                    total_proforma = total_proforma + decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString());
                }
                decimal sub_total = total_proforma - (total_proforma * .12m);
                decimal iva = total_proforma * .12m;

                var serie = (from a in db.tbl_series
                             where a.id_tienda == 1
                             && a.activo == true
                             && a.id_tipo_serie == 4
                             select a).SingleOrDefault();

                int id_cliente = int.Parse(tbidcliente.Text);
                string cliente = tbcliente.Text;
                int id_tipo_venta = 1;
                if(chktipoventa.Checked)
                {
                    id_tipo_venta = 2;
                }

                if (chktipoventa.Checked)
                {
                    if (tbvalorcuota.Text != "" && tbcantpagos.Text != "")
                    {
                        decimal total_venta = 0;
                        int errores = 0;
                        if (tbanticipo.Text != "" && decimal.Parse(tbanticipo.Text) > 0)
                        {
                            abonos_aplicados = decimal.Parse(tbanticipo.Text);
                        }
                        for (int i = 0; i < gvlistadoproductos.DataRowCount; i++)
                        {
                            if (decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) > 0)
                            {
                                total_venta = total_venta + decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString());
                            }
                            else
                            {
                                MessageBox.Show("No se ha ingresado el valor unitario para todos los productos. Revise e intente nuevamente.");
                                errores = errores + 1;
                                i = gvlistadoproductos.DataRowCount;
                            }
                        }

                        if (errores == 0)
                        {
                            int cnt_cuotas = 0;
                            if (tbcantpagos.Text != "")
                            {
                                cnt_cuotas = int.Parse(tbcantpagos.Text);
                            }

                            monto_total_factura = total_venta;
                            if (cnt_cuotas != 0)
                            {
                                tbvalorcuota.Text = (decimal.Round((monto_total_factura - abonos_aplicados) / (cnt_cuotas), 2)).ToString();
                            }
                        }
                    }
                }

                tbl_Proforma_EncTableAdapter.Insert(id_cliente, cliente, tbnitcliente.Text, tbtelefono.Text, serie.id_serie, serie.serie, (int.Parse(serie.correlativo.ToString()) + 1), id_tienda, 1, sub_total, iva, total_proforma, 1, DateTime.Now, id_tipo_venta, decimal.Parse(tbanticipo.Text), int.Parse(tbcantpagos.Text), decimal.Parse(tbvalorcuota.Text));
                tbl_Proforma_EncTableAdapter.Update(db);
                (from a in db.tbl_series
                 where a.id_serie == serie.id_serie
                 select a).ToList().ForEach(a => { a.correlativo++; });
                tbl_SeriesTableAdapter.Update(db);
                CargarTablas();
                var proforma = (from a in db.tbl_proforma_enc
                                where a.activo == 1
                                select a).OrderByDescending(a => a.id_proforma_enc).Take(1).FirstOrDefault();

                id_proforma = proforma.id_proforma_enc;

                for(int i = 0; i < gvlistadoproductos.RowCount; i++)
                {
                    if(gvlistadoproductos.GetRowCellValue(i, "Id").ToString() != "")
                    {
                        tbl_Proforma_DetTableAdapter.Insert(int.Parse(gvlistadoproductos.GetRowCellValue(i, "Id").ToString()), 1, decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()), decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) - (decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) * .12m), decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) * .12m, decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()), proforma.id_proforma_enc, true, DateTime.Now, 1, "");
                    }
                    else
                    {
                        tbl_Proforma_DetTableAdapter.Insert(null, 1, decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()), decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) - (decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) * .12m), decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()) * .12m, decimal.Parse(gvlistadoproductos.GetRowCellValue(i, "PrecioUnitario").ToString()), proforma.id_proforma_enc, true, DateTime.Now, 1, gvlistadoproductos.GetRowCellValue(i, "Producto").ToString());
                    }
                    tbl_Proforma_DetTableAdapter.Update(db);
                }

                MessageBox.Show("Proforma registrada.");
                BloquearControles();
            }
        }

        public void CargarTablas()
        {
            tbl_Proforma_EncTableAdapter.Fill(db.tbl_proforma_enc);
            tbl_Proforma_DetTableAdapter.Fill(db.tbl_proforma_det);
            tbl_SeriesTableAdapter.Fill(db.tbl_series);
        }

        public void BloquearControles()
        {
            tbcliente.ReadOnly = true;
            tbdireccioncliente.ReadOnly = true;
            tbnitcliente.ReadOnly = true;
            tbtelefono.ReadOnly = true;
            tbanticipo.ReadOnly = true;
            tbcantpagos.ReadOnly = true;
            gclistadoproductos.Enabled = false;
            btngenerar.Enabled = false;
            btnimprimir.Enabled = true;
            btnbuscarcliente.Enabled = false;
            btnagregarproductos.Enabled = false;
            btncalcularcuotas.Enabled = false;
            chktipoventa.ReadOnly = true;
            chkapm.ReadOnly = true;
            tbnombreproducto.Enabled = false;
            tbpreciounitario.Enabled = false;
            btnapm.Enabled = false;
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            VistaProforma proforma = new VistaProforma(id_proforma);
            proforma.Show();
        }

        private void chktipoventa_CheckedChanged(object sender, EventArgs e)
        {
            if(chktipoventa.Checked)
            {
                tbanticipo.ReadOnly = false;
                tbcantpagos.ReadOnly = false;
                btncalcularcuotas.Enabled = true;
            }
            else
            {
                tbanticipo.ReadOnly = true;
                tbcantpagos.ReadOnly = true;
                btncalcularcuotas.Enabled = false;
                tbanticipo.Text = "0";
                tbcantpagos.Text = "0";
                tbvalorcuota.Text = "0";
            }
        }

        private void chkapm_CheckedChanged(object sender, EventArgs e)
        {
            if(chkapm.Checked)
            {
                btnapm.Enabled = true;
                tbnombreproducto.Enabled = true;
                tbpreciounitario.Enabled = true;
            }
            else
            {
                btnapm.Enabled = false;
                tbnombreproducto.Enabled = false;
                tbpreciounitario.Enabled = false;
            }
        }

        private void btnapm_Click(object sender, EventArgs e)
        {
            if(tbnombreproducto.Text != "" && tbpreciounitario.Text != "")
            {
                gvlistadoproductos.AddNewRow();

                int rowHandle = gvlistadoproductos.GetRowHandle(gvlistadoproductos.DataRowCount);
                if (gvlistadoproductos.IsNewItemRow(rowHandle))
                {
                    gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[6], tbnombreproducto.Text);
                    gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[8], tbpreciounitario.Text);
                    gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[9], tbpreciounitario.Text);
                    gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[10], tbpreciounitario.Text);
                    gvlistadoproductos.SetRowCellValue(rowHandle, gvlistadoproductos.Columns[12], tbpreciounitario.Text);
                    gvlistadoproductos.UpdateCurrentRow();
                }
            }
            else
            {
                MessageBox.Show("Ingrese precio y nombre del producto para poder ingresarlo.");
            }
        }
    }
}