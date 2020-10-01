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
using DevExpress.XtraEditors.Controls;

namespace ViewGuate502.Ventas
{
    public partial class NuevaVenta : DevExpress.XtraEditors.XtraForm
    {
        int id_tipo_venta;
        dbSoftwareGTDataSet db = new dbSoftwareGTDataSet();
        tbl_vendedores_tiendaTableAdapter tbl_vendedores_tienda = new tbl_vendedores_tiendaTableAdapter();
        tbl_vendedoresTableAdapter tbl_vendedores = new tbl_vendedoresTableAdapter();
        tbl_usuariosTableAdapter tbl_usuarios = new tbl_usuariosTableAdapter();
        object sndr = null;
        EventArgs evnt = null;

        public NuevaVenta(int id_tv)
        {
            InitializeComponent();
            id_tipo_venta = id_tv;
        }

        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            sndr = sender;
            evnt = e;

            CargarTablas();
            if(id_tipo_venta == 1)
            {
                lbltitulo.Text = "Nueva venta de contado";
                this.Name = "Contado";
                this.Text = "Contado";
            }
            else
            {
                lbltitulo.Text = "Nueva venta al crédito";
                this.Name = "Credito";
                this.Text = "Crédito";
            }

            tbfecha.Text = DateTime.Now.ToLongDateString();

            if(id_tipo_venta == 1)
            {
                lciautorizador.Dispose();
                lueautorizador.Dispose();
                btnfiadores.Dispose();
                btnautorizaciones.Dispose();
                btncuotas.Dispose();
            }

            var vendedores = (from a in db.tbl_vendedores_tienda
                              join b in db.tbl_vendedores on a.id_vendedor equals b.id_vendedor
                              join c in db.tbl_usuarios on b.id_usuario equals c.id_usuario
                              where a.id_tienda == Configuraciones.Configuraciones.idtienda &&
                              a.activo == true
                              select new
                              {
                                  a.id_vendedor,
                                  c.nombre_usuario
                              }).ToList();

            if (vendedores.Count > 0)
            {
                luevendedor.Properties.DataSource = vendedores;
                luevendedor.Properties.DisplayMember = "nombre_usuario";
                luevendedor.Properties.ValueMember = "id_vendedor";

                if (luevendedor.Properties.Columns.Count == 0)
                {
                    luevendedor.Properties.Columns.Add(new LookUpColumnInfo("id_vendedor", "Id"));
                    luevendedor.Properties.Columns.Add(new LookUpColumnInfo("nombre_usuario", "Nombre"));
                }

                luevendedor.Properties.Columns[0].Visible = false;
                //enable text editing 
                luevendedor.Properties.TextEditStyle = TextEditStyles.Standard;
            }
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            if(id_tipo_venta == 1)
            {
            }
        }

        private void btnlimpiarcliente_Click(object sender, EventArgs e)
        {
            tbcliente.Text = "";
            tbnit.Text = "";
            tbdirección.Text = "";
            tbtelefono.Text = "";
            tbidcliente.Text = "";

            tbcliente.Enabled = true;
            tbnit.Enabled = true;
            tbdirección.Enabled = true;
            tbtelefono.Enabled = true;
            tbidcliente.Enabled = true;
        }

        public void CargarTablas()
        {
            tbl_vendedores_tienda.Fill(db.tbl_vendedores_tienda);
            tbl_vendedores.Fill(db.tbl_vendedores);
            tbl_usuarios.Fill(db.tbl_usuarios);
        }

        private void btnnuevaventa_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                LimpiarFormulario(control);
            }
            NuevaVenta_Load(sndr, evnt);
        }

        public static void LimpiarFormulario(Control Ctrl)
        {
            foreach (Control ctrl in Ctrl.Controls)
            {
                BaseEdit edior = ctrl as BaseEdit;
                if (edior != null)
                    edior.EditValue = null;

                LimpiarFormulario(ctrl);//Recursive  
            }

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
        }
    }
}