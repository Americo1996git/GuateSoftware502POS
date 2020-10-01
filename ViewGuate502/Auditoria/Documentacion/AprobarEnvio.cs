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

namespace ViewGuate502.Auditoria.Documentacion
{
    public partial class AprobarEnvio : DevExpress.XtraEditors.XtraForm
    {
        dbSoftwareGTDataSet db = new dbSoftwareGTDataSet();
        tbl_ventas_encTableAdapter tbl_ventas_enc = new tbl_ventas_encTableAdapter();
        tbl_auditoria_revision_doctosTableAdapter tbl_auditoria_revision_doctos = new tbl_auditoria_revision_doctosTableAdapter();
        Auditoria_documentacionTableAdapter auditoria_documentacion = new Auditoria_documentacionTableAdapter();
        int id_venta_enc;
        string envio;
        Pendientes_doc pendientes;
        EnRevision_doc escalados;
        Finalizados_doc finalizados;
        int id_reporte;

        public AprobarEnvio(int ive, string env, Pendientes_doc pnd, EnRevision_doc esc, Finalizados_doc fn, int ir)
        {
            InitializeComponent();
            id_venta_enc = ive;
            envio = env;
            tbenvio.Text = envio;
            pendientes = pnd;
            tbl_ventas_enc.Fill(db.tbl_ventas_enc);
            tbl_auditoria_revision_doctos.Fill(db.tbl_auditoria_revision_doctos);
            escalados = esc;
            finalizados = fn;
            id_reporte = ir;

            if (id_reporte == 2)
            {
                btnrevision.Visible = false;
            }

            if (id_reporte == 3)
            {
                lueautorizacion.ReadOnly = true;
                mecomentarioaprobacion.ReadOnly = true;
                btnaprobar.Visible = false;
                btnrevision.Visible = false;
            }
        }

        private void btnrevision_Click(object sender, EventArgs e)
        {
            if (mecomentarioaprobacion.Text != "" && lueautorizacion.EditValue != null)
            {
                DialogResult enviarrevision = MessageBox.Show("Pasar envío a revisión", "¿Desea pasar este envío a la pantalla de revisión?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (enviarrevision == DialogResult.Yes)
                {
                    bool aprobado_ok = false; ;
                    if (int.Parse(lueautorizacion.EditValue.ToString()) == 0)
                    {
                        aprobado_ok = false;
                    }
                    else if (int.Parse(lueautorizacion.EditValue.ToString()) == 1)
                    {
                        aprobado_ok = true;
                    }

                    (from a in db.tbl_auditoria_revision_doctos
                     where a.id_venta_enc == id_venta_enc
                     select a).ToList().ForEach(a => { a.comentarios_auditor = mecomentarioaprobacion.Text; a.id_estatus_auditoria = 2; a.documentacion_ok = aprobado_ok; a.fecha_revision = DateTime.Now; });
                    tbl_auditoria_revision_doctos.Update(db);
                    if(id_reporte == 1)
                    {
                        pendientes.recargar();
                    }
                    else
                    {
                        escalados.recargar();
                    }
                    
                    this.Close();

                    MessageBox.Show("El envío se ha pasado a la pantalla de revisión.");
                }
            }
            else
            {
                MessageBox.Show("Es necesario que ingrese un comentario para continuar.");
            }
        }

        private void btnaprobar_Click(object sender, EventArgs e)
        {
            if (mecomentarioaprobacion.Text != "" && lueautorizacion.EditValue != null)
            {
                DialogResult aprobar = MessageBox.Show("Aprobación de envío", "¿Confirma que desea aprobar la documentación de este envío?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (aprobar == DialogResult.Yes)
                {
                    bool aprobado_ok = false; ;
                    if (int.Parse(lueautorizacion.EditValue.ToString()) == 0)
                    {
                        aprobado_ok = false;
                    }
                    else if (int.Parse(lueautorizacion.EditValue.ToString()) == 1)
                    {
                        aprobado_ok = true;
                    }

                    (from a in db.tbl_auditoria_revision_doctos
                     where a.id_venta_enc == id_venta_enc
                     select a).ToList().ForEach(a => { a.comentarios_auditor = mecomentarioaprobacion.Text; a.id_estatus_auditoria = 3; a.documentacion_ok = aprobado_ok; a.fecha_finalizacion = DateTime.Now; });
                    tbl_auditoria_revision_doctos.Update(db);
                    if(id_reporte == 1)
                    {
                        pendientes.recargar();
                    }
                    else
                    {
                        escalados.recargar();
                    }
                    MessageBox.Show("El envío se ha aprobado correctamente.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Es necesario que ingrese un comentario para continuar.");
            }
        }

        private void AprobarEnvio_Load(object sender, EventArgs e)
        {
            IDictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Bien autorizado", 1);
            dictionary.Add("Mal autorizado", 0);
            lueautorizacion.Properties.DataSource = dictionary;
            lueautorizacion.Properties.ValueMember = "Value";
            lueautorizacion.Properties.DisplayMember = "Key";

            if(id_reporte == 3 || id_reporte == 2)
            {
                bool autorizacion = (from a in db.tbl_auditoria_revision_doctos
                                    where a.id_venta_enc == id_venta_enc
                                    select a.documentacion_ok).FirstOrDefault();

                if (autorizacion)
                {
                    lueautorizacion.EditValue = 1;
                }
                else
                {
                    lueautorizacion.EditValue = 0;
                }

                mecomentarioaprobacion.Text = (from a in db.tbl_auditoria_revision_doctos
                                               where a.id_venta_enc == id_venta_enc
                                               select a.comentarios_auditor).FirstOrDefault();
            }
        }
    }
}