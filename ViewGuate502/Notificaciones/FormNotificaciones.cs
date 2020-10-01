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

namespace ViewGuate502.Notificaciones
{
    public partial class FormNotificaciones : DevExpress.XtraEditors.XtraForm
    {
        public FormNotificaciones()
        {
            InitializeComponent();
        }

        private void FormNotificaciones_Load(object sender, EventArgs e)
        {
            gridControlNotificaciones.DataSource = ControllerNotificacion.Mostrar(Configuraciones.Configuraciones.idtienda,0);
            gridControlNotificaciones.ForceInitialize();
            gridViewNotificaciones.BestFitColumns();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNotificaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}