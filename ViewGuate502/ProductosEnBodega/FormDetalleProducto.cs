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

namespace ViewGuate502.ProductosEnBodega
{
    public partial class FormDetalleProducto : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int idproducto;
        public string nombre, presentacion, linea, sublinea, marca, meses_garantia, precioa, preciob, precioc, codigo, rutaimagen="";
        public decimal descuento;
        private void FormDetalleProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public string utilizaImagen="";
        public FormDetalleProducto()
        {
            InitializeComponent();
        }

        private void cargarImagenPictureBox(string rutaImagen)
        {
            try
            {
                this.pictureEditImagen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
                if (rutaImagen == "")
                {

                    this.pictureEditImagen.Image = null;
                }
                else
                {
                    this.pictureEditImagen.Image = Image.FromFile(rutaImagen);
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Debe seleccionar el producto de forma correcta","Productos en existencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }



        }

        private void FormDetalleProducto_Load(object sender, EventArgs e)
        {
            textNombre.Text = nombre;
            textPresentacion.Text = presentacion;
          
            textMesesGarantia.Text = meses_garantia;
            textPrecioA.Text = precioa;
            textPrecioB.Text = preciob;
            textPrecioC.Text = precioc;
            textDescuento.Text = descuento.ToString(); ;
            textCodigo.Text = codigo;
            //gridControlListDetalle.DataSource = ControllerProducto.ShowDetail(idproducto);
            if (rutaimagen !="ninguno")
            {
                rutaimagen = "./assets/ImagenesProductos/" + rutaimagen;
                cargarImagenPictureBox(rutaimagen);
            }



        }
    }
}