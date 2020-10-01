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

namespace ViewGuate502.Ingresos
{
    public partial class FormImprimirDocumento : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int id_origen;
        int id_destino;
        public FormImprimirDocumento()
        {
            InitializeComponent();
        }

        private void btnImprimrTodos_Click(object sender, EventArgs e)
        {
            id_origen = Configuraciones.Configuraciones.idtienda;
            if (Convert.ToInt32(lookUpEditDocumento.EditValue) == 2)
            {
                id_origen = Convert.ToInt32(lookUpEditTiendas.EditValue);
                id_destino = Configuraciones.Configuraciones.idtienda;
            }

            if (Convert.ToInt32(lookUpEditDocumento.EditValue) == 4)
            {
                id_origen = Configuraciones.Configuraciones.idtienda;
                id_destino = Convert.ToInt32(lookUpEditTiendas.EditValue);
            }
            if (Convert.ToInt32(lookUpEditDocumento.EditValue) == 5)
            {
                id_origen = Configuraciones.Configuraciones.idtienda;
                id_destino = Convert.ToInt32(lookUpEditTiendas.EditValue);
            }


            FormImprimirIngreso imprimir = new FormImprimirIngreso();
            imprimir.codigo = 0;
            imprimir.id_tienda = Configuraciones.Configuraciones.idtienda;
            imprimir.id_documento_inventario = Convert.ToInt32(lookUpEditDocumento.EditValue);
            imprimir.id_origen = id_origen;
            imprimir.id_destino = id_destino;
            imprimir.fecha_inicial = Convert.ToDateTime(dateEditFechaIncial.EditValue);
            imprimir.fecha_final = Convert.ToDateTime(dateEditFechaFinal.EditValue);
            imprimir.ShowDialog();



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormImprimirDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormImprimirDocumento_Load(object sender, EventArgs e)
        {
            lookUpEditDocumento.Properties.DataSource = ControllerDocumentosInventario.MostrarDocumentosParaReportes();
            lookUpEditDocumento.Properties.DisplayMember = "Nombre";
            lookUpEditDocumento.Properties.ValueMember = "iddocumento";


            lookUpEditTiendas.Properties.DataSource = ControllerTrasladoTiedas.MostrarTiendasDeDestino(Configuraciones.Configuraciones.idtienda);
            lookUpEditTiendas.Properties.ValueMember = "idtienda";
            lookUpEditTiendas.Properties.DisplayMember = "nombre";

            lookUpEditBodegaOrigen.Properties.DataSource = ControllerTrasladoBodegas.MostrarBodegaOrigen(Configuraciones.Configuraciones.idtienda);
            lookUpEditBodegaOrigen.Properties.ValueMember = "idbodega";
            lookUpEditBodegaOrigen.Properties.DisplayMember = "nombre";

            lookUpEditDocumento.ItemIndex = 0;
        }

        private void lookUpEditDocumento_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditDocumento.ItemIndex > -1)
            {
                if (lookUpEditDocumento.ItemIndex == 0)
                {
                    layoutControlItem1TiendaOrigen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItemBodegaOrigen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItemBodegaDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
                if (lookUpEditDocumento.ItemIndex == 1)
                {
                    layoutControlItem1TiendaOrigen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlItemBodegaOrigen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItemBodegaDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
                if (lookUpEditDocumento.ItemIndex == 2)
                {
                    layoutControlItem1TiendaOrigen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItemBodegaOrigen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlItemBodegaDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
                if (lookUpEditDocumento.ItemIndex == 3)
                {
                    layoutControlItem1TiendaOrigen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlItem1TiendaOrigen.Text = "TIENDA DESTINO";
                    layoutControlItemBodegaOrigen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItemBodegaDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
                if (lookUpEditDocumento.ItemIndex == 4)
                {
                    layoutControlItem1TiendaOrigen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItemBodegaOrigen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlItemBodegaDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }

            }
        }

        private void lookUpEditBodegaDestino_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEditBodegaOrigen_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditBodegaOrigen.ItemIndex > -1)
            {
                lookUpEditBodegaDestino.Properties.DataSource = ControllerTrasladoBodegas.MostrarBodegaDestino(Configuraciones.Configuraciones.idtienda, Convert.ToInt32(lookUpEditBodegaOrigen.EditValue));
                lookUpEditBodegaDestino.Properties.ValueMember = "idbodega";
                lookUpEditBodegaDestino.Properties.DisplayMember = "nombre";
            }
        }
    }
}