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

namespace ViewGuate502.Ventas.Complementos
{
    public partial class CrearAnticipo : DevExpress.XtraEditors.XtraForm
    {
        VentaForm ventaForm = null;
        int tipo_venta = 0;
        RealizarVenta realizarVenta = null;
        public CrearAnticipo(int id_tipo_venta, VentaForm ventas, RealizarVenta rv)
        {
            InitializeComponent();
            ventaForm = ventas;
            tipo_venta = id_tipo_venta;
            realizarVenta = rv;
        }

        private void CrearAnticipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.tbl_tipos_pago' Puede moverla o quitarla según sea necesario.
            this.tbl_tipos_pagoTableAdapter.Fill(this.dbSoftwareGTDataSet.tbl_tipos_pago);

            if(ventaForm != null)
            {
                if (ventaForm.anticipos.Count > 0)
                {
                    for (int i = 0; i < ventaForm.anticipos.Count; i++)
                    {
                        if (ventaForm.anticipos[i].Item1 == 0)
                        {
                            tbmontoanticipo.Text = ventaForm.anticipos[i].Item2.ToString();
                            luetipopago.EditValue = ventaForm.anticipos[i].Item3;
                            medescripcion.Text = ventaForm.anticipos[i].Item4.ToString();
                            btnguardar.Enabled = false;
                            tbmontoanticipo.Enabled = false;
                            luetipopago.Enabled = false;
                            medescripcion.Enabled = false;
                        }
                    }
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (int.Parse(luetipopago.EditValue.ToString()) == 4 && (tbbanco.Text == "Ingrese banco del depósito..." || tbfechadeposito.Text == "Ingrese fecha del depósito..." || tbnoboleta.Text == "Ingrese el número de boleta..."))
            {
                MessageBox.Show("Complete todos los datos de la boleta para guardar.");
            }
            else
            {
                if (ventaForm != null)
                {
                    ventaForm.anticipos.Add(new Tuple<int, decimal, int, string>(0, decimal.Parse(tbmontoanticipo.Text), int.Parse(luetipopago.EditValue.ToString()), medescripcion.Text));
                }
                else if(realizarVenta != null)
                {
                    Anticipo anticipo = new Anticipo
                    {
                        id_anticipo = 0,
                        monto_anticipo = decimal.Parse(tbmontoanticipo.Text),
                        id_tipo_pago = int.Parse(luetipopago.EditValue.ToString()),
                        descripcion = medescripcion.Text
                    };
                    realizarVenta.anticipos.Add(anticipo);
                    realizarVenta.btnagregaranticipo.Enabled = false;
                    realizarVenta.btncrearanticipo.Enabled = false;
                }
                
                MessageBox.Show("¡Anticipo agregado exitosamente!");
                this.Close();
            }
        }

        private void luetipopago_EditValueChanged(object sender, EventArgs e)
        {
            if (int.Parse(luetipopago.EditValue.ToString()) == 4)
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