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

namespace ViewGuate502.Auditoria
{
    public partial class Escalados : DevExpress.XtraEditors.XtraForm
    {
        object snd;
        EventArgs ea;
        public Escalados()
        {
            InitializeComponent();
        }   

        private void Escalados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSoftwareGTDataSet.Auditoria_pendientes' Puede moverla o quitarla según sea necesario.
            this.auditoria_pendientesTableAdapter.Fill(this.dbSoftwareGTDataSet.Auditoria_pendientes, 2);
            snd = sender;
            ea = e;
            gvlistadopendientes.BestFitColumns();
        }

        private void btnaprobar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gvlistadopendientes.GetFocusedRowCellValue("id_venta_enc").ToString());
            string envio = gvlistadopendientes.GetFocusedRowCellValue("envio").ToString();
            AprobarEnvio aprobarEnvio = new AprobarEnvio(id, envio, null, this, null, 2);
            aprobarEnvio.ShowDialog();
        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gvlistadopendientes.GetFocusedRowCellValue("id_venta_enc").ToString());
            Ventas.Reportes.VistaEnvioCompleto vistaEnvioCompleto = new Ventas.Reportes.VistaEnvioCompleto(1, id);
            vistaEnvioCompleto.ShowDialog();
        }

        private void btnaprobar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(gvlistadopendientes.GetFocusedRowCellValue("id_venta_enc").ToString());
            string envio = gvlistadopendientes.GetFocusedRowCellValue("envio").ToString();
            DetalleAprobacion detalleAprobacion = new DetalleAprobacion(id, envio, null, this, null, 2);
            detalleAprobacion.ShowDialog();
        }

        public void recargar()
        {
            Escalados_Load(snd, ea);
        }
    }
}