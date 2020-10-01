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

namespace ViewGuate502.ConfigGenerales
{
    public partial class FormVerListas : DevExpress.XtraEditors.XtraForm
    {
        string tipo_listado = "";
        string tipo_de_creacion = "";
        public FormVerListas(string tipo_listado)
        {
            InitializeComponent();
            this.tipo_listado = tipo_listado;
            this.Text = tipo_listado;
        }

        public void MostrarListado(string tipo_de_lista)
        {
            if (tipo_de_lista.Equals("Lineas"))
            {
                gridControlList.DataSource = ControllerLinea.MostrarLineas();
                tipo_de_creacion = "Linea";
            }
            if (tipo_de_lista.Equals("Sub lineas"))
            {
                gridControlList.DataSource = ControllerSubLinea.MostrarSubLienasParaElModulo();
                gridView1.Columns[5].Visible = false;
                tipo_de_creacion = "Sub linea";
            }
            if (tipo_de_lista.Equals("Marcas"))
            {
                gridControlList.DataSource = ControllerMarca.MostrarMarcas();
                tipo_de_creacion = "Marca";
            }
            if (tipo_de_lista.Equals("Bodegas"))
            {
                gridControlList.DataSource = ControllerBodega.MostrarBodega(Configuraciones.Configuraciones.idtienda);
                tipo_de_creacion = "Bodega";
            }
            gridView1.Columns[0].Visible = false;
            gridControlList.ForceInitialize();
            gridView1.BestFitColumns();
        }
        public void Editar()
        {
            int id_linea = 0;
            decimal descuento = 0;
            string abreviatura = "";
            string tipo_edicion = "";
            if (tipo_listado.Equals("Lineas"))
            {
                tipo_edicion = "Linea";
                id_linea = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "idlinea"));
                descuento = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Descuento"));
            }
            if (tipo_listado.Equals("Sub lineas"))
            {
                tipo_edicion = "Sub linea";
                id_linea = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "idlinea"));
                descuento = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Descuento"));
                abreviatura = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Abreviatura"));
            }
            if (tipo_listado.Equals("Marcas"))
            {
                tipo_edicion = "Marca";
                id_linea = 0;
            }
            if (tipo_listado.Equals("Bodegas"))
            {
                tipo_edicion = "Bodega";
                id_linea = 0;
            }

            FormAgregar editar = new FormAgregar(tipo_edicion, "Editar");
            editar.MostrarDatosParaEditar(
                Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]))
                , id_linea
                , Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nombre"))
                , Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Descripción"))
                , descuento
                , abreviatura);
            editar.ShowDialog();

            if (tipo_listado.Equals("Lineas"))
            {
                gridControlList.DataSource = ControllerLinea.MostrarLineas();
            }
            if (tipo_listado.Equals("Sub lineas"))
            {
                gridControlList.DataSource = ControllerSubLinea.MostrarSubLienasParaElModulo();
                gridView1.Columns[5].Visible = false;
            }
            if (tipo_listado.Equals("Marcas"))
            {
                gridControlList.DataSource = ControllerMarca.MostrarMarcas();
            }
            if (tipo_listado.Equals("Bodegas"))
            {
                gridControlList.DataSource = ControllerBodega.MostrarBodega(Configuraciones.Configuraciones.idtienda);
            }
            gridView1.Columns[0].Visible = false;
            gridControlList.ForceInitialize();
            gridView1.BestFitColumns();
        }
        private void FormVerListas_Load(object sender, EventArgs e)
        {
            layoutControlGroupTitulo.Text = "Lista de "+tipo_listado;
            MostrarListado(tipo_listado);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVerListas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Editar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConfigGenerales.FormAgregar agregar = new ConfigGenerales.FormAgregar(tipo_de_creacion, "Agregar");
            agregar.ShowDialog();
            MostrarListado(tipo_listado);
        }
    }
}