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

namespace ViewGuate502.GenerarOrdenCompra
{
    public partial class FormModalHistorialPrecios : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int id_producto;
        public string  producto,proveedor;
        public int id_proveedor;
        public FormModalHistorialPrecios()
        {
            InitializeComponent();
        }

        private void FormModalHistorialPrecios_Load(object sender, EventArgs e)
        {
            txtProducto.Text = producto;
            txtProveedor.Text = proveedor;
            gridControlHistorial.DataSource = ControllerGenerarOrdenCompra.MostrarHistorialDePrecios(id_producto,id_proveedor);
            gridControlHistorial.ForceInitialize();
            gridViewHistorial.BestFitColumns();
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModalHistorialPrecios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}