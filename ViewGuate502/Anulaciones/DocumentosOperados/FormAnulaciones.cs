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
using MODELOS502;

namespace ViewGuate502.Anulaciones.DocumentosOperados
{
    public partial class FormAnulaciones : DevExpress.XtraEditors.XtraForm
    {
        public int codigo,id_encabezado,id_tienda_destino,id_tipo_documento,opcion,id_bodega;

        public DataTable dt;
        public string documento, observaciones;
        public string origen_o_destino;

        private void FormAnulaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Anular();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }


        public FormAnulaciones()
        {
            InitializeComponent();
        }

        void Anular()
        {

            string res;
            bool anular = true;
            if (string.IsNullOrWhiteSpace(txtRazon.Text))
            {
                anular = false;
                dxErrorProvider1.SetError(txtRazon, "ESTE CAMPO ES OBLIGATORIO");
            }
            if (anular)
            {
                if (XtraMessageBox.Show("¿ANULAR DOCUMENTO?", Configuraciones.Configuraciones.NombreDelSistema, MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    MAnularOperacion objAnular = new MAnularOperacion();
                    objAnular.Codito = codigo;
                    objAnular.IdTiendaDestino = id_tienda_destino;
                    objAnular.IdTienda = Configuraciones.Configuraciones.idtienda;
                    objAnular.IdTipoDeDocumento = id_tipo_documento;
                    objAnular.IdEncabezado = id_encabezado;
                    objAnular.Opcion = 0;

                    List<MAnularOperacionDetalle> listaEliminar = new List<MAnularOperacionDetalle>();
                    for (int i = 0; i < gridViewDetalle.DataRowCount; i++)
                    {
                        MAnularOperacionDetalle objDetalle = new MAnularOperacionDetalle();
                        objDetalle.IdEncabezado = id_encabezado;
                        objDetalle.IdTienda = Configuraciones.Configuraciones.idtienda;
                        objDetalle.IdDetalle = Convert.ToInt32(gridViewDetalle.GetRowCellValue(i, "id_movimiento_det"));
                        objDetalle.IdProducto = Convert.ToInt32(gridViewDetalle.GetRowCellValue(i, "idproducto"));
                        objDetalle.IdBodega = Convert.ToInt32(gridViewDetalle.GetRowCellValue(i, "id_bodega"));
                        objDetalle.Cantidad = Convert.ToInt32(gridViewDetalle.GetRowCellValue(i, "cantidad"));
                        objDetalle.Opcion = 0;
                        objDetalle.Opcion = id_tipo_documento;
                        listaEliminar.Add(objDetalle);
                    }

                    res = ControllerAnulaciones.AnularOperacion(objAnular, listaEliminar);
                    if (res == "OK")
                    {
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("ERROR AL REALIZAR LA OPERACIÓN " + res);
                    }
                }
            }
        }
        private void FormAnulaciones_Load(object sender, EventArgs e)
        {
            txtTipoDeDocumento.Text = documento;
            seCorrelativo.EditValue = codigo;
            txtOrgienDestino.Text = origen_o_destino;
            txtRazon.Focus();
            gridControlDetalle.DataSource = dt;


        }
    }
}