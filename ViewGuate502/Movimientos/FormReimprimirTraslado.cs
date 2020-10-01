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

namespace ViewGuate502.Movimientos
{
    public partial class FormReimprimirTraslado : DevExpress.XtraEditors.XtraForm
    {
        int id_origen = 0, id_destino = 0;
        string tipo_de_operacion = "";

        public FormReimprimirTraslado(string tipo_operacion)
        {
            InitializeComponent();
            this.tipo_de_operacion = tipo_operacion;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReimprimirTraslado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                bool mostrar = true;
                bool ingresado = true;
                if (Convert.ToInt32(spinEditNumeroDeDocumento.EditValue) == 0)
                {
                    XtraMessageBox.Show("DEBE ESCRIBIR EL CORRELATIVO DE FORMA CORRECTA", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrar = false;
                }
                if (lookUpEditTipoDeDocumento.ItemIndex < 0)
                {
                    XtraMessageBox.Show("DEBE SELECCIONAR EL TIPO DE DOCUMENTO", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrar = false;
                }
                if (mostrar)
                {

                    id_origen = Configuraciones.Configuraciones.idtienda;
                    if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) == 2)
                    {
                        id_origen = Convert.ToInt32(lookUpEditTiendas.EditValue);
                        id_destino = Configuraciones.Configuraciones.idtienda;
                        ingresado = true;
                    }
                    if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) == 3)
                    {
                        id_origen = Configuraciones.Configuraciones.idtienda;
                        id_destino = Convert.ToInt32(lookUpEditTiendas.EditValue);
                        ingresado = true;
                    }

                    if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) == 4)
                    {
                        id_origen = Configuraciones.Configuraciones.idtienda;
                        id_destino = Convert.ToInt32(lookUpEditTiendas.EditValue);
                        ingresado = false;
                    }
                    if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) == 5)
                    {
                        id_origen = Configuraciones.Configuraciones.idtienda;
                        id_destino = Convert.ToInt32(lookUpEditTiendas.EditValue);
                        ingresado = false;
                    }
                    DocumentosInvetntario.DocumentosOperados.ImprimirDocumentoGenerado(
                        Convert.ToInt32(spinEditNumeroDeDocumento.Value)// correlativo del documento
                        ,Configuraciones.Configuraciones.idtienda // id del documento
                        ,Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue)// id tienda donde se reailizo la operacion
                        ,id_origen // id origen
                        ,id_destino
                        ,ingresado
                        ,0);
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("DEBE ESCRIBIR EL CORRELATIVO DE FORMA CORRECTA", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
  
        }

        private void lookUpEditTipoDeDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinEditNumeroDeDocumento.Focus();
            }
        }

        private void spinEditNumeroDeDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnImprimir.Focus();
            }
        }

        private void FormReimprimirTraslado_Load(object sender, EventArgs e)
        {
            if (tipo_de_operacion.Equals("IMPRIMIR"))
            {
                this.Text = "IMPRIMIR DOCUMENTO OPERADO";
                lyBtnSeries.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyBtnAnular.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            if (tipo_de_operacion.Equals("ANULAR"))
            {
                this.Text = "ANULAR DOCUMENTO OPERADO";
                lyBtnImprimir.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyBtnSeries.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            if (tipo_de_operacion.Equals("EDITAR"))
            {
                this.Text = "EDITAR SERIES DE DOCUMENTO OPERADO";
                lyBtnImprimir.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyBtnAnular.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }


            lookUpEditTipoDeDocumento.Properties.DataSource = ControllerDocumentosInventario.MostrarDocumentos();
            lookUpEditTipoDeDocumento.Properties.DisplayMember = "Nombre";
            lookUpEditTipoDeDocumento.Properties.ValueMember = "iddocumento";

            lookUpEditTiendas.Properties.DataSource = ControllerTrasladoTiedas.MostrarTiendasDeDestino(Configuraciones.Configuraciones.idtienda);
            lookUpEditTiendas.Properties.ValueMember = "idtienda";
            lookUpEditTiendas.Properties.DisplayMember = "nombre";

            layoutControlItemTiendas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void lookUpEditTipoDeDocumento_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) == 4)
            {
                layoutControlItemTiendas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItemTiendas.Text = "DESTINO";
            }
            if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) == 2)
            {
                layoutControlItemTiendas.Text = "ORIGEN";
                layoutControlItemTiendas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) != 2 && Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) != 4)
            {
                layoutControlItemTiendas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            id_origen = Configuraciones.Configuraciones.idtienda;
            if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) == 2)
            {
                id_origen = Convert.ToInt32(lookUpEditTiendas.EditValue);
                id_destino = Configuraciones.Configuraciones.idtienda;
            }

            if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) == 4)
            {
                id_origen = Configuraciones.Configuraciones.idtienda;
                id_destino = Convert.ToInt32(lookUpEditTiendas.EditValue);
            }
            if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) == 5)
            {
                id_origen = Configuraciones.Configuraciones.idtienda;
                id_destino = Convert.ToInt32(lookUpEditTiendas.EditValue);
            }

            dt =
                ControllerDocumentosInventario.MostrarDocumentoOperado(
                    Convert.ToInt32(spinEditNumeroDeDocumento.Value)// correlativo del documento
                    , Configuraciones.Configuraciones.idtienda // id del documento
                    , Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue)// id tienda donde se reailizo la operacion
                    , id_origen // id origen
                    , id_destino
                    ,true
                    ,0);

            if (dt.Rows.Count > 0)
            {
                Ingresos.FormIngresoPorTraslado traslados = new Ingresos.FormIngresoPorTraslado(3);
                traslados.tipo_de_operacion = "correcciones";
                traslados.documento = lookUpEditTipoDeDocumento.Text;
                traslados.correlativo = Convert.ToInt32(spinEditNumeroDeDocumento.Value);
                traslados.btnIngresarMercaderia.Text = "Corregir";
                traslados.layoutControlItemBtnGrabar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                traslados.origen = Convert.ToString(dt.Rows[0]["origen_documento"]);
                traslados.dtDetalleInsercion = dt;
                traslados.ShowDialog();
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            DataTable dt;
            string origen_o_destino="";
            bool esOrgigen = true;
            id_origen = Configuraciones.Configuraciones.idtienda;
            if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) == 2)
            {
                id_origen = Convert.ToInt32(lookUpEditTiendas.EditValue);
                id_destino = Configuraciones.Configuraciones.idtienda;

            }

            if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) == 4)
            {
                id_origen = Configuraciones.Configuraciones.idtienda;
                id_destino = Convert.ToInt32(lookUpEditTiendas.EditValue);
            }
            if (Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue) == 5)
            {
                id_origen = Configuraciones.Configuraciones.idtienda;
                id_destino = Convert.ToInt32(lookUpEditTiendas.EditValue);
            }
            dt = 
                ControllerDocumentosInventario.MostrarDocumentoOperado(
                    Convert.ToInt32(spinEditNumeroDeDocumento.Value)// correlativo del documento
                    , Configuraciones.Configuraciones.idtienda // id del documento
                    , Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue)// id tienda donde se reailizo la operacion
                    , id_origen // id origen
                    , id_destino
                    ,false
                    ,1);

            if (dt.Rows.Count > 0)
            {
                if (esOrgigen)
                {
                    origen_o_destino = Convert.ToString(dt.Rows[0]["origen_documento"]);
                }
                if (!esOrgigen)
                {
                    origen_o_destino = Convert.ToString(dt.Rows[0]["destino_documento"]);
                }
                Anulaciones.DocumentosOperados.FormAnulaciones form = new Anulaciones.DocumentosOperados.FormAnulaciones();
                form.codigo = Convert.ToInt32(spinEditNumeroDeDocumento.EditValue);
                //form.id_encabezado = Convert.ToInt32(dt.Rows[0]["codigo_tabla_documento"]);
                form.observaciones = Convert.ToString(dt.Rows[0]["observaciones_generales"]);
                form.documento = Convert.ToString(dt.Rows[0]["documento"]);
                form.id_tienda_destino = Convert.ToInt32(lookUpEditTiendas.EditValue);
                form.id_tipo_documento = Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue);
                form.origen_o_destino = origen_o_destino;
                //form.id_bodega = Convert.ToInt32(dt.Rows[0]["idbodega"]);
                form.opcion = /*lookUpEditTipoDeDocumento.ItemIndex == 0 ? 0: */Convert.ToInt32(lookUpEditTipoDeDocumento.EditValue);
                form.dt = dt;
                form.ShowDialog();
            }
        }
    }
}