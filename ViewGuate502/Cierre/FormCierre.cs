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
using MODELOS502;

namespace ViewGuate502.Cierre
{
    public partial class FormCierre : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DashBoard menu;
        public FormCierre(DashBoard principal)
        {
            InitializeComponent();
            menu = principal;
        }

        private void FormCierre_Load(object sender, EventArgs e)
        {
            if (!Configuraciones.Configuraciones.InventarioCerrado())
            {
                txtFecha.Text = ((DateTime.Now.Month) -(1)).ToString() + "/" + DateTime.Now.Year.ToString();
            }
            else
            {
                txtFecha.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            }
            memoEdit1.Text = "Este proceso es muy delicado, asegurese que ningun usuario este en el modulo de inventario trabajando. Se realizara la copia de saldos de los productos";


            //dateEdit1.Properties.Mask.EditMask = "Y";

        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea cerrar el inventario?", "Cierre de inventario", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                string rpta = "", anio, mes;

                MCierre cierre = new MCierre();
                cierre.Idtienda = Configuraciones.Configuraciones.idtienda;
                cierre.Fecha = DateTime.Now;
                cierre.Anio_cierre = DateTime.Now.Year.ToString();
                cierre.Mes_cierre = DateTime.Now.Month.ToString();
                cierre.Abierto = "0";
                cierre.Mes = DateTime.Now.Month - 1;

                MCierreDetalle det = new MCierreDetalle();
                det.Idtienda = Configuraciones.Configuraciones.idtienda;
                rpta = ControllerCierre.CerrarInventario(cierre, det);
                if (rpta == "OK")
                {
                    XtraMessageBox.Show(this, "El inventario se ha cerrado correctamente", "Cierre mensual de inventario");
                    //menu.barHeaderItemAlertaCierre.Caption = "";
                    //menu.barHeaderItemAlertaCierre.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show(this, "Error al cerrar el inventario, por favor consulte a su administrador de datos " + rpta, "Error al cerrar inventario");
                }
            }
           

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCierre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}