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

namespace ViewGuate502.Auditoria.Documentacion
{
    public partial class Pendientes_doc : DevExpress.XtraEditors.XtraForm
    {
        object snd;
        EventArgs ea;

        public Pendientes_doc()
        {
            InitializeComponent();
        }

        private void auditoriadocumentacionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Pendientes_doc_Load(object sender, EventArgs e)
        {
            auditoria_documentacionTableAdapter.Fill(this.dbSoftwareGTDataSet.Auditoria_documentacion, 1);
            snd = sender;
            ea = e;
            gvlistadopendientes.BestFitColumns();
        }

        public void recargar()
        {
            Pendientes_doc_Load(snd, ea);
        }

        private void btnaprobar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gvlistadopendientes.GetFocusedRowCellValue("id_venta_enc").ToString());
            string envio = gvlistadopendientes.GetFocusedRowCellValue("envio").ToString();
            Documentacion.AprobarEnvio aprobarEnvio = new AprobarEnvio(id, envio, this, null, null, 1);
            aprobarEnvio.ShowDialog();
        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gvlistadopendientes.GetFocusedRowCellValue("id_venta_enc").ToString());
            Ventas.Reportes.VistaEnvioCompleto vistaEnvioCompleto = new Ventas.Reportes.VistaEnvioCompleto(1, id);
            vistaEnvioCompleto.ShowDialog();
        }
    }
}