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

namespace ViewGuate502
{
    public partial class FormPantallaInicio : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        int count_teclado_foco = 0;
        bool utilizaImagen = false;
        bool cambiar_foco = false;
        public FormPantallaInicio()
        {
            InitializeComponent();
        }

   

      

        private void FormPantallaInicio_Load(object sender, EventArgs e)
        {
            lookUpEditTiendas.Properties.DataSource = ControllerProductosEnBodega.MostrarTiendas();
            lookUpEditTiendas.Properties.ValueMember = "idtienda";
            lookUpEditTiendas.Properties.DisplayMember = "nombre";

           
         
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "admin" && textPassWord.Text == "123456")
            {
                Configuraciones.Configuraciones.idtienda = Convert.ToInt32(lookUpEditTiendas.EditValue);
                Configuraciones.Configuraciones.tienda = (lookUpEditTiendas.Text);
                Configuraciones.Configuraciones.usuario = textUsuario.Text;

                this.Hide();
                DashBoard principal = new DashBoard();
                principal.tienda = (lookUpEditTiendas.Text);
                principal.Show();
                //FormDashboard principal = new FormDashboard();


            }
        }

        private void btnSalirDeSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lookUpEditTiendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (count_teclado_foco == 1)
                {
                    count_teclado_foco = 0;
                    cambiar_foco = true;
                }

                if (!cambiar_foco)
                {
                    count_teclado_foco++;
                }
                if (cambiar_foco)
                {
                    cambiar_foco = false;
                    textUsuario.Focus();
                }

            }
        }

        private void textUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textPassWord.Focus();
            }
        }

        private void textPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcceder.Focus();
            }
        }

        private void FormPantallaInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}