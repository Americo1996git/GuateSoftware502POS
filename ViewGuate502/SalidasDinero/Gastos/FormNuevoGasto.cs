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
using ControllerSoft502;

namespace ViewGuate502.SalidasDinero.Gastos
{
    public partial class FormNuevoGasto : DevExpress.XtraEditors.XtraForm
    {
        public int id_salida_dinero = 0;
        public int id_tipo_salida_dinero;
        public string descripcion, destino, observaciones;
        public decimal monto;
        public string serie_factura, correlativo_factura;

        int opcion;
        string tipo_operacion = "";
        public FormNuevoGasto(string operacion)
        {
            InitializeComponent();
            tipo_operacion = operacion;
        }

        private void FormNuevoGasto_Load(object sender, EventArgs e)
        {
            if (tipo_operacion.Equals("AGREGAR"))
            {
                this.Text = "AGREGAR CAPTURA DE GASTOS";
                opcion = 0;
                btnGrabar.Text = "AGREGAR";
            }
            if (tipo_operacion.Equals("EDITAR"))
            {
                this.Text = "EDITAR CAPTURA DE GASTOS";
                opcion = 1;
                btnGrabar.Text = "EDITAR";
            }

            lookUpEditGastos.Properties.DataSource = ControllerMostrar.TiposDeGastos();
            lookUpEditGastos.Properties.DisplayMember = "nombre";
            lookUpEditGastos.Properties.ValueMember = "id_tipo_salida_dinero";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            bool grabar = true;
            string rpt = "";
            if (string.IsNullOrWhiteSpace(txtSerieFactura.Text))
            {
                grabar = false;
            }
            if (string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                grabar = false;
            }

            DataTable dt = new DataTable();
            dt = ControllerMovimientoDinero.ObtenerTotalesEntradasSalidas(Configuraciones.Configuraciones.idtienda, DateTime.Now);
            if (dt.Rows.Count > 0)
            {

                decimal total_ingresos;
                decimal total_salidas;
                total_ingresos = Convert.ToDecimal(dt.Rows[0]["total"]);
                if (spinEditMonto.Value > total_ingresos)
                {
                    XtraMessageBox.Show("FONDOS INSUFICIENTES",Configuraciones.Configuraciones.NombreDelSistema);
                    grabar = false;
                }
            }

            if (grabar)
            {
                rpt = ControllerMovimientoDinero.GrabarSalida(
                    id_salida_dinero
                    , Configuraciones.Configuraciones.idtienda
                    , 1
                    , Convert.ToInt32(lookUpEditGastos.EditValue)
                    , 5
                    , 1
                    , Configuraciones.Configuraciones.idusuario
                    , ""
                    , txtDestino.Text
                    , txtObservaciones.Text
                    , spinEditMonto.Value
                    , "A"
                    , 0
                    , txtSerieFactura.Text
                    , Convert.ToInt32(spinEditCorrelativo.Value)
                    ,opcion);
                if (rpt.Equals("OK"))
                {
                    txtSerieFactura.Text = string.Empty;
                    spinEditCorrelativo.Value = 0;
                    spinEditMonto.Value = 0;
                    txtDestino.Text = string.Empty;
                    txtObservaciones.Text = string.Empty;
                    txtSerieFactura.Focus();
                    XtraMessageBox.Show("EL GASTO SE HA REALIZADO",Configuraciones.Configuraciones.NombreDelSistema);
                    if (tipo_operacion.Equals("EDITAR"))
                    {
                        this.Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show("OCURRIO UN ERROR AL REALIZAR LA OPERACION. ERROR = : "+rpt);
                }
            }


        }

        private void FormNuevoGasto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}