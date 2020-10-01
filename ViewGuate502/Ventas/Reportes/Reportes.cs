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

namespace ViewGuate502.Ventas.Reportes
{
    public partial class Reportes : DevExpress.XtraEditors.XtraForm
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void cmbreporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.tbl_reportes_ventas' Puede moverla o quitarla según sea necesario.
            this.tbl_reportes_ventasTableAdapter.Fill(this.dbSoftwareGTDataSet.tbl_reportes_ventas);

        }

        private void luereporte_EditValueChanged(object sender, EventArgs e)
        {
            if (luereporte.EditValue != null)
            {
                if(int.Parse(luereporte.EditValue.ToString()) != 11)
                {
                    GeneradorReportes generadorReportes = new GeneradorReportes(int.Parse(luereporte.EditValue.ToString()), luereporte.Text, this);
                    generadorReportes.Show();
                }
                else
                {
                    EnvioCompleto envioCompleto = new EnvioCompleto();
                    envioCompleto.Show();
                }
            }
            else
            {
            }
        }

        private void luereporte_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}