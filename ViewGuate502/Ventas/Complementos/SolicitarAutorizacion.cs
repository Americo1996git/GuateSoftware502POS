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
using System.Net.Mail;
using System.Net;

namespace ViewGuate502.Ventas.Complementos
{
    public partial class SolicitarAutorizacion : DevExpress.XtraEditors.XtraForm
    {
        
        VentaForm ventaForm = null;
        int id_autorizador = 0;
        tbl_autorizadores_creditoTableAdapter tbl_autorizadores = new tbl_autorizadores_creditoTableAdapter();
        tbl_usuariosTableAdapter tbl_usuarios = new tbl_usuariosTableAdapter();
        dbSoftwareGTDataSet dbSoftwareGTDataSet = new dbSoftwareGTDataSet();
        string codigo_autorizacion = "";
        RealizarVenta realizarVenta = null;
        bool validar_aut = false;

        public SolicitarAutorizacion(VentaForm venta, int autorizador ,RealizarVenta rv)
        {
            InitializeComponent();
            IniciarTablas();
            btnvalidar.Enabled = false;
            btnvalidar.Visible = false;
            btnenviarcorreo.Enabled = false;
            btnenviarcorreo.Visible = false;
            lblvalidacion.Visible = false;
            lblvalidacion.Text = "";
            cbtipoautorizacion.SelectedValue = null;
            tbtextovalidacion.Visible = false;
            tbtextovalidacion.Text = "";
            ventaForm = venta;
            id_autorizador = autorizador;
            realizarVenta = rv;
        }

        private void cbtipoautorizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbtipoautorizacion.Enabled = false;
            if (cbtipoautorizacion.Text == "Contraseña")
            {
                lblvalidacion.Visible = true;
                lblvalidacion.Text = "Ingrese la contraseña del autorizador:";
                tbtextovalidacion.Visible = true;
                tbtextovalidacion.Properties.PasswordChar = '*';
                btnvalidar.Visible = true;
                btnvalidar.Enabled = false;
            }
            else if (cbtipoautorizacion.Text == "Correo")
            {
                lblvalidacion.Visible = true;
                lblvalidacion.Text = "Ingrese el código de autorización:";
                tbtextovalidacion.Visible = true;
                btnvalidar.Visible = true;
                btnvalidar.Enabled = false;
                btnenviarcorreo.Enabled = true;
                btnenviarcorreo.Visible = true;
            }
        }

        private void tbtextovalidacion_EditValueChanged(object sender, EventArgs e)
        {
            if(tbtextovalidacion.Text != "")
            {
                btnvalidar.Visible = true;
                btnvalidar.Enabled = true;
            }
        }

        private void btnenviarcorreo_Click(object sender, EventArgs e)
        {

            string email = (from a in dbSoftwareGTDataSet.tbl_autorizadores_credito
                            join b in dbSoftwareGTDataSet.tbl_usuarios on a.id_usuario equals b.id_usuario
                            where a.id_autorizador == id_autorizador
                            select b.email).SingleOrDefault();

            if (email != "")
            {
                string mensaje = CrearMensajeCorreo(email);
            }
            else
            {
                MessageBox.Show("¡El autorizador seleccionado no tienen ningún correo registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            if(cbtipoautorizacion.Text == "Contraseña")
            {
                string contrasenia = tbtextovalidacion.Text;
                var validacion = (from a in dbSoftwareGTDataSet.tbl_autorizadores_credito
                                  join b in dbSoftwareGTDataSet.tbl_usuarios on a.id_usuario equals b.id_usuario
                                  where a.id_autorizador == id_autorizador &&
                                  b.contrasenia == contrasenia
                                  select a).SingleOrDefault();

                if (validacion != null)
                {
                    if(ventaForm != null)
                    {
                        ventaForm.validar_autorizacion = true;
                        MessageBox.Show("¡Validación correcta!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ventaForm.lueautorizador.Enabled = false;
                        ventaForm.btnagregarproductos.Enabled = false;
                    }
                    else if (realizarVenta != null)
                    {
                        MessageBox.Show("¡Validación correcta!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        validar_aut = true;
                        realizarVenta.lueautorizador.Enabled = false;
                        realizarVenta.gclistaproductos.Enabled = false;
                        realizarVenta.btneliminarlinea.Enabled = false;
                        realizarVenta.btnagregaranticipo.Enabled = false;
                        realizarVenta.btncrearanticipo.Enabled = false;
                        realizarVenta.btncuotas.Enabled = false;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("¡Error en validación. Inténtelo nuevamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(cbtipoautorizacion.Text == "Correo")
            {
                if(tbtextovalidacion.Text == codigo_autorizacion)
                {
                    ventaForm.validar_autorizacion = true;
                    MessageBox.Show("¡Validación correcta!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ventaForm.lueautorizador.Enabled = false;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("¡Error en validación. Inténtelo nuevamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void IniciarTablas()
        {
            tbl_autorizadores.Fill(dbSoftwareGTDataSet.tbl_autorizadores_credito);
            tbl_usuarios.Fill(dbSoftwareGTDataSet.tbl_usuarios);
        }

        public string CrearMensajeCorreo(string destinatario)
        {
            string caracteres = "1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            foreach (var a in new int[6])
            {
                res.Append(caracteres[rnd.Next(caracteres.Length)]);
            }

            string token = res.ToString();

            var fromAddress = new MailAddress("direcciondecorreo", "Sistema Agly");
            var toAddress = new MailAddress(destinatario);
            const string fromPassword = "contraseñacorreo";
            const string subject = "SISTEMA AGLY - CÓDIGO AUTORIZACIÓN VENTA";
            //string mensaje = "Estimado " + nombres + " \n\nSe ha solicitado una contraseña temporal de tu usuario para acceder al Sistema Orión. Si no has sido tú quién solicitó esta contraseña temporal puedes reportar el incidente al departamento de IT o hacer omiso a este mensaje.\n\nCONTRASEÑA TEMPORAL: " + contrasenia_temp + "\n\nSaludos cordiales,";
            string mensaje = "<html>" +
                                "<body> " +
                                "<p>Estimado usuario,</p> " +
                                "<p>Se ha solicitado un token de autorización de crédito a su nombre en el sistema Agly.</p> " +
                                "<p><b>TOKEN: " + token + "</br></br>" +
                                "VENDEDOR: " + token + "</br>" +
                                "MONTO: " + token + "</br></p>" +
                                "<div>" +
                                "<p>Saludos,</p>" +
                                "</div>" +
                                "</body> " +
                                "</html> ";

            string body = mensaje;

            var smtp = new SmtpClient
            {
                Host = "smtpdelacuenta",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            try
            {
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                })
                {
                    smtp.Send(message);
                    smtp.Dispose();
                    codigo_autorizacion = token;
                    return ("Se ha enviado el correo electrónico con el código de autorización.");
                }
            }
            catch (Exception e)
            {
                return (e.Message + ".\n Error en el envío de mensaje.");
            }
        }

        private void SolicitarAutorizacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(ventaForm != null)
            {
                if (ventaForm.validar_autorizacion == false)
                {
                    ventaForm.lueautorizador.EditValue = null;
                }
            }
            else if(realizarVenta != null)
            {
                if(validar_aut == false)
                {
                    realizarVenta.lueautorizador.EditValue = null;
                }
            }
        }
    }
}