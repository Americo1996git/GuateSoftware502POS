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
using ViewGuate502.Ventas;

namespace ViewGuate502.Ventas.Complementos
{
    public partial class CalcularCuotas : DevExpress.XtraEditors.XtraForm
    {
        VentaForm ventaForm = null;
        int tipo_venta = 0;
        decimal monto_venta = 0;
        decimal monto_anticipos = 0;
        public DataTable dt;
        List<int> no_cuota = new List<int>();
        List<decimal> monto_cuota = new List<decimal>();
        List<DateTime> fecha_pago = new List<DateTime>();
        RealizarVenta realizarVenta = null;

        public CalcularCuotas(int id_tipo_venta, VentaForm ventas, decimal monto_financiar, decimal anticipos, RealizarVenta rv)
        {
            InitializeComponent();
            ventaForm = ventas;
            tipo_venta = id_tipo_venta;
            monto_venta = monto_financiar;
            monto_anticipos = anticipos;
            realizarVenta = rv;
        }

        private void tbcantcuotas_Leave(object sender, EventArgs e)
        {
            if(tbcantcuotas.Text != "")
            {
                int x = 0;
                if(int.TryParse(tbcantcuotas.Text, out x))
                {
                }
                else
                {
                    MessageBox.Show("La cantidad de cuotas ingresada no es válida. Inténtelo de nuevo.");
                    tbcantcuotas.Text = "";
                }
            }
        }

        private void CalcularCuotas_Load(object sender, EventArgs e)
        {
            this.tbmontoventa.Properties.Mask.EditMask = "c";
            this.tbmontoventa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbanticipos.Properties.Mask.EditMask = "c";
            this.tbanticipos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbmontofinanciar.Properties.Mask.EditMask = "c";
            this.tbmontofinanciar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            tbmontoventa.Text = monto_venta.ToString();
            dpapartirde.EditValue = DateTime.Now;

            if (ventaForm != null && ventaForm.anticipos.Count > 0)
            {
                for (int i = 0; i < ventaForm.anticipos.Count; i++)
                {
                    monto_anticipos = monto_anticipos + ventaForm.anticipos[i].Item2;
                }
            }
            else if(realizarVenta != null && realizarVenta.anticipos.Count > 0)
            {
                monto_anticipos = realizarVenta.anticipos.Sum(a => a.monto_anticipo);
            }

            tbanticipos.Text = monto_anticipos.ToString();
            tbmontofinanciar.Text = (monto_venta - monto_anticipos).ToString();
            tbcantcuotas.Text = realizarVenta.cuotas.Count.ToString();

            dt = new DataTable();
            dt.Columns.Add("No. Cuota", typeof(int));
            dt.Columns.Add("Monto", typeof(decimal));
            dt.Columns.Add("Fecha pago", typeof(DateTime));

            gclistadocuotas.DataSource = dt;

            gvlistadocuotas.Columns[0].Width = 3;
            gvlistadocuotas.Columns[0].OptionsColumn.ReadOnly = true;
            btnnuevocalculo.Enabled = false;
            gvlistadocuotas.Columns[1].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;

            if (ventaForm != null && ventaForm.cuotas.Count > 0)
            {
                for (int i = 0; i < ventaForm.cuotas.Count; i++)
                {
                    this.gvlistadocuotas.AddNewRow();
                    var rowHandle = this.gvlistadocuotas.GetRowHandle(this.gvlistadocuotas.DataRowCount);
                    if (gvlistadocuotas.IsNewItemRow(rowHandle))
                    {
                        gvlistadocuotas.SetRowCellValue(rowHandle, gvlistadocuotas.Columns[0], ventaForm.cuotas[i].Item1);
                        gvlistadocuotas.SetRowCellValue(rowHandle, gvlistadocuotas.Columns[1], ventaForm.cuotas[i].Item2);
                        gvlistadocuotas.SetRowCellValue(rowHandle, gvlistadocuotas.Columns[2], ventaForm.cuotas[i].Item3);
                        gvlistadocuotas.UpdateCurrentRow();
                    }
                }
            }
            else if(realizarVenta != null && realizarVenta.cuotas.Count > 0)
            {
                for (int i = 0; i < realizarVenta.cuotas.Count; i++)
                {
                    this.gvlistadocuotas.AddNewRow();
                    var rowHandle = this.gvlistadocuotas.GetRowHandle(this.gvlistadocuotas.DataRowCount);
                    if (gvlistadocuotas.IsNewItemRow(rowHandle))
                    {
                        gvlistadocuotas.SetRowCellValue(rowHandle, gvlistadocuotas.Columns[0], realizarVenta.cuotas[i].no_cuota);
                        gvlistadocuotas.SetRowCellValue(rowHandle, gvlistadocuotas.Columns[1], realizarVenta.cuotas[i].monto_cuota);
                        gvlistadocuotas.SetRowCellValue(rowHandle, gvlistadocuotas.Columns[2], realizarVenta.cuotas[i].fecha_pago_cuota);
                        gvlistadocuotas.UpdateCurrentRow();
                    }
                }
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (tbcantcuotas.Text != "" && dpapartirde.Text != "" && tbcantcuotas.Text != "")
            {
                int cantidad_cuotas = int.Parse(tbcantcuotas.Text);
                decimal monto_financiar = decimal.Parse(tbmontofinanciar.Text);
                DateTime apartir_de = DateTime.Parse(dpapartirde.Text);
                decimal valor_cuota = decimal.Round(monto_financiar/cantidad_cuotas, 2);
                decimal diferencia = monto_financiar - (valor_cuota * cantidad_cuotas);

                for(int i = 0; i < cantidad_cuotas; i++)
                {
                    no_cuota.Add(i + 1);
                    if(i != (cantidad_cuotas - 1))
                    {
                        monto_cuota.Add(valor_cuota);
                    }
                    else
                    {
                        monto_cuota.Add(valor_cuota + diferencia);
                    }

                    if (i == 0)
                    {
                        fecha_pago.Add(apartir_de);
                    }
                    else
                    {
                        apartir_de = apartir_de.AddMonths(1);
                        fecha_pago.Add(apartir_de);
                    }
                }

                for(int i = 0; i < gvlistadocuotas.DataRowCount;)
                {
                    gvlistadocuotas.DeleteRow(i);
                }

                for(int i = 0; i < cantidad_cuotas; i++)
                {
                    gvlistadocuotas.AddNewRow();

                    int rowHandle1 = gvlistadocuotas.GetRowHandle(gvlistadocuotas.DataRowCount);
                    if (gvlistadocuotas.IsNewItemRow(rowHandle1))
                    {
                        gvlistadocuotas.SetRowCellValue(rowHandle1, gvlistadocuotas.Columns[0], no_cuota[i]);
                        gvlistadocuotas.SetRowCellValue(rowHandle1, gvlistadocuotas.Columns[1], monto_cuota[i]);
                        gvlistadocuotas.SetRowCellValue(rowHandle1, gvlistadocuotas.Columns[2], fecha_pago[i]);
                    }
                }

                tbcantcuotas.Enabled = false;
                dpapartirde.Enabled = false;
                btncalcular.Enabled = false;
                btnnuevocalculo.Enabled = true;
                btnguardar.Focus();

            }
            else
            {
                MessageBox.Show("Ingrese cantidad de cuotas y fecha \"Apartir de\" para continuar");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(gvlistadocuotas.DataRowCount > 0)
            {
                if(tbcantcuotas.Text != "" && dpapartirde.Text != "")
                {
                    decimal total = 0;
                    for(int i = 0; i < gvlistadocuotas.DataRowCount; i++)
                    {
                        total = total + decimal.Parse(gvlistadocuotas.GetRowCellValue(i, "Monto").ToString());
                    }

                    if (decimal.Parse(tbmontofinanciar.Text) != total)
                    {
                        MessageBox.Show("El total de las cuotas no coincide con el valor a financiar.");
                    }
                    else
                    {
                        if(ventaForm != null)
                        {
                            ventaForm.cuotas = new List<Tuple<int, decimal, DateTime>>();
                            for (int i = 0; i < gvlistadocuotas.DataRowCount; i++)
                            {
                                ventaForm.cuotas.Add(new Tuple<int, decimal, DateTime>(int.Parse(gvlistadocuotas.GetRowCellValue(i, "No. Cuota").ToString()), decimal.Parse(gvlistadocuotas.GetRowCellValue(i, "Monto").ToString()), DateTime.Parse(gvlistadocuotas.GetRowCellValue(i, "Fecha pago").ToString())));
                            }
                        }
                        else if(realizarVenta != null)
                        {
                            realizarVenta.cuotas = new List<Cuotas>();
                            for (int i = 0; i < gvlistadocuotas.DataRowCount; i++)
                            {
                                Cuotas cuotas = new Cuotas
                                {
                                    no_cuota = int.Parse(gvlistadocuotas.GetRowCellValue(i, "No. Cuota").ToString()),
                                    monto_cuota = decimal.Parse(gvlistadocuotas.GetRowCellValue(i, "Monto").ToString()),
                                    fecha_pago_cuota = DateTime.Parse(gvlistadocuotas.GetRowCellValue(i, "Fecha pago").ToString())
                                };
                                realizarVenta.cuotas.Add(cuotas);
                            }
                            realizarVenta.a_partir_de = DateTime.Parse(dpapartirde.EditValue.ToString());
                        }

                        MessageBox.Show("¡Cuotas guardadas exitosamente!");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha indicado la cantidad de cuotas o fecha \"A partir de\". Favor de revisar.");
                }
            }
            else
            {
                MessageBox.Show("No hay información por guardar");
                this.Close();
            }
        }

        private void btnnuevocalculo_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < gvlistadocuotas.DataRowCount;)
            {
                gvlistadocuotas.DeleteRow(i);
            }
            tbcantcuotas.Text = "";
            dpapartirde.Text = "";
            tbcantcuotas.Enabled = true;
            dpapartirde.Enabled = true;
            btnnuevocalculo.Enabled = false;
            btncalcular.Enabled = true;
        }
    }
}