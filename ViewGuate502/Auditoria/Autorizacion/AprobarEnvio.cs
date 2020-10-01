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

namespace ViewGuate502.Auditoria
{
    public partial class AprobarEnvio : DevExpress.XtraEditors.XtraForm
    {
        dbSoftwareGTDataSet db = new dbSoftwareGTDataSet();
        tbl_ventas_encTableAdapter tbl_ventas_enc = new tbl_ventas_encTableAdapter();
        tbl_auditoria_ventasTableAdapter tbl_auditoria_ventas = new tbl_auditoria_ventasTableAdapter();
        Auditoria_pendientesTableAdapter auditoria_pendientes = new Auditoria_pendientesTableAdapter();
        int id_venta_enc;
        string envio;
        Pendientes pendientes;
        Escalados escalados;
        Finalizados finalizados;
        int id_reporte;
        public AprobarEnvio(int ive, string env, Pendientes pnd, Escalados esc, Finalizados fn, int ir)
        {
            InitializeComponent();
            id_venta_enc = ive;
            envio = env;
            tbenvio.Text = envio;
            pendientes = pnd;
            tbl_ventas_enc.Fill(db.tbl_ventas_enc);
            tbl_auditoria_ventas.Fill(db.tbl_auditoria_ventas);
            escalados = esc;
            finalizados = fn;
            id_reporte = ir;

            if(id_reporte == 2)
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
            if(mecomentarioaprobacion.Text != "" && lueautorizacion.EditValue != null)
            {
                DialogResult enviarrevision = MessageBox.Show("ESCALAR ENVÍO A UN SUPERVISOR", "¿DESEA ESCALAR LA APROBACIÓN DE ESTE ENVÍO A UN SUPERVISOR?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

                    (from a in db.tbl_auditoria_ventas
                     where a.id_venta_enc == id_venta_enc
                     select a).ToList().ForEach(a => { a.comentarios_auditor = mecomentarioaprobacion.Text; a.id_estatus_auditoria = 2; a.autorizado_ok = aprobado_ok; a.fecha_escala = DateTime.Now; });
                    tbl_auditoria_ventas.Update(db);
                    pendientes.recargar();
                    this.Close();

                    MessageBox.Show("EL ENVÍO SE HA ESCALADO A UN SUPERVISOR.");
                }
            }
            else
            {
                MessageBox.Show("ES NECESARIO QUE INGRESE UN COMENTARIO PARA CONTINUAR.");
            }
        }

        private void btnaprobar_Click(object sender, EventArgs e)
        {
            if (mecomentarioaprobacion.Text != "" && lueautorizacion.EditValue != null)
            {
                DialogResult aprobar = MessageBox.Show("APROBACIÓN DE ENVÍO", "¿CONFIRMA QUE DESEA APROBAR ESTE ENVÍO?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (aprobar == DialogResult.Yes)
                {
                    bool aprobado_ok = false; ;
                    if(int.Parse(lueautorizacion.EditValue.ToString()) == 0)
                    {
                        aprobado_ok = false;
                    }
                    else if(int.Parse(lueautorizacion.EditValue.ToString()) == 1)
                    {
                        aprobado_ok = true;
                    }

                    (from a in db.tbl_auditoria_ventas
                     where a.id_venta_enc == id_venta_enc
                     select a).ToList().ForEach(a => { a.comentarios_auditor = mecomentarioaprobacion.Text; a.id_estatus_auditoria = 3; a.autorizado_ok = aprobado_ok; a.fecha_finalizacion = DateTime.Now; });
                    tbl_auditoria_ventas.Update(db);
                    pendientes.recargar();
                    MessageBox.Show("EL ENVIO SE HA APROBADO CORRECTAMENTE.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("ES NECESARIO QUE INGRESE UN COMENTARIO PARA CONTINUAR.",Configuraciones.Configuraciones.NombreDelSistema);
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

            if(id_reporte == 3)
            {
                bool autorizacion = (from a in db.tbl_auditoria_ventas
                                    where a.id_venta_enc == id_venta_enc
                                    select a.autorizado_ok).FirstOrDefault();

                if (autorizacion)
                {
                    lueautorizacion.EditValue = 1;
                }
                else
                {
                    lueautorizacion.EditValue = 0;
                }

                mecomentarioaprobacion.Text = (from a in db.tbl_auditoria_ventas
                                               where a.id_venta_enc == id_venta_enc
                                               select a.comentarios_auditor).FirstOrDefault();
            }
        }
    }
}