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
using CrystalDecisions.CrystalReports.Engine;

namespace ViewGuate502.Ventas.Complementos
{
    public partial class AgregarRecibo : DevExpress.XtraEditors.XtraForm
    {
        tbl_recibos_anticiposTableAdapter tbl_recibos = new tbl_recibos_anticiposTableAdapter();
        tbl_seriesTableAdapter tbl_series = new tbl_seriesTableAdapter();
        int id_serie = 0;
        string serie = "";
        int correlativo = 0;
        int id_tipo_pago = 0;
        string descripcion = "";
        decimal monto = 0;
        int id_cliente = 0;
        string nombre_cliente = "";
        public AgregarRecibo()
        {
            InitializeComponent();
        }

        private void AgregarRecibo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.tbl_tipos_pago' Puede moverla o quitarla según sea necesario.
            this.tbl_tipos_pagoTableAdapter.Fill(this.dbSoftwareGTDataSet.tbl_tipos_pago);
            IniciarTablas();
            var datos_serie = (from a in dbSoftwareGTDataSet.tbl_series
                               where a.id_tipo_serie == 3 &&
                               a.id_tienda == 1
                               select a).SingleOrDefault();

            if(datos_serie != null)
            {
                id_serie = datos_serie.id_serie;
                serie = datos_serie.serie;
                tbserie.Text = datos_serie.serie;
            }
            tbserie.Enabled = false;
            tbcorrelativo.Enabled = false;
            btngenerarrecibo.Enabled = false;
            btnguardar.Enabled = true;
            tbmonto.Enabled = true;
            luetipopago.Enabled = true;
            medescripcion.Enabled = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(int.Parse(luetipopago.EditValue.ToString()) == 4 && (tbbanco.Text == "Ingrese banco del depósito..." || tbfechadeposito.Text == "Ingrese fecha del depósito..." || tbnoboleta.Text == "Ingrese el número de boleta..."))
            {
                MessageBox.Show("Complete todos los datos de la boleta para guardar.");
            }
            else
            {
                if (tbserie.Text != "" && tbmonto.Text != "" && luetipopago.EditValue != null && tbcliente.Text != "")
                {
                    id_tipo_pago = int.Parse(luetipopago.EditValue.ToString());
                    monto = decimal.Parse(tbmonto.Text);
                    if(int.Parse(luetipopago.EditValue.ToString()) == 4)
                    {
                        descripcion = tbbanco.Text + "\n\r " + tbfechadeposito.Text + "\n\r " + tbnoboleta.Text;
                    }
                    else
                    {
                        descripcion = medescripcion.Text;
                    }
                    
                    nombre_cliente = tbcliente.Text;

                    correlativo = (from a in dbSoftwareGTDataSet.tbl_recibos_anticipos
                                   where a.id_serie == id_serie
                                   select a.correlativo).Max();
                    correlativo = correlativo + 1;
                    tbl_recibos.Insert(monto, id_tipo_pago, id_cliente, nombre_cliente, descripcion, DateTime.Now, true, 1, correlativo, 1, serie, id_serie, 1);
                    tbl_recibos.Update(dbSoftwareGTDataSet);
                    (from a in dbSoftwareGTDataSet.tbl_series
                     where a.id_serie == id_serie
                     select a).ToList().ForEach(a => { a.correlativo = (a.correlativo + 1); });
                    tbl_series.Update(dbSoftwareGTDataSet);
                    IniciarTablas();
                    tbcorrelativo.Text = correlativo.ToString();
                    tbmonto.Enabled = false;
                    luetipopago.Enabled = false;
                    medescripcion.Enabled = false;
                    btngenerarrecibo.Enabled = true;
                    btnguardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Información incompleta. Favor de revisar.");
                }
            }
            
        }

        private void btngenerarrecibo_Click(object sender, EventArgs e)
        {
            int id_recibo = (from a in dbSoftwareGTDataSet.tbl_recibos_anticipos
                          where a.id_serie == id_serie &&
                          a.correlativo == correlativo
                          select a.id_recibos_anticipo).Max();

            ImprimirRecibo imprimir = new ImprimirRecibo(id_recibo);
            imprimir.ShowDialog();
        }

        public void IniciarTablas()
        {
            this.tbl_recibos.Fill(this.dbSoftwareGTDataSet.tbl_recibos_anticipos);
            this.tbl_series.Fill(this.dbSoftwareGTDataSet.tbl_series);
        }

        private void luetipopago_EditValueChanged(object sender, EventArgs e)
        {
            if(int.Parse(luetipopago.EditValue.ToString()) == 4)
            {
                medescripcion.Visible = false;
                tbbanco.Visible = true;
                tbfechadeposito.Visible = true;
                tbnoboleta.Visible = true;
            }
            else
            {
                medescripcion.Visible = true;
                tbbanco.Visible = false;
                tbfechadeposito.Visible = false;
                tbnoboleta.Visible = false;
            }
        }
    }
}