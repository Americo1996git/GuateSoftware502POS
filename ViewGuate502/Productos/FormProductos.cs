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
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic.Devices;
using System.IO;
using MODELOS502;
using System.Windows.Media.Imaging;
using DevExpress.Data.Filtering;

namespace ViewGuate502.Productos
{
    public partial class FormProductos : DevExpress.XtraEditors.XtraForm
    {
        MProducto producto;
        DataTable dtCaracteristicasEliminacion = null;
        DataTable dtCaracteristicas = null;


        string imagenEliminacion = "";
        string imagenInsercion = "";
        string CodigoProducto = "";

        string nombreExistenteImagenEdicion = "";

        int count_teclado_foco = 0;
        bool cambiar_foco = false;
        bool utilizaImagen = false;

        bool en_bodega;
        string activarImagen = "neutro";
       
        
        //___________variables para saber si se presiono el boton nuevo producto o editar__
        //____________se esta creando un nuevo producto y editando________________
        //esNuevo=sirve para guardar un nuevo producto
        //esEditar= sirve para actulizar un producto
        bool esNuevo = false, esEditar = false;
        bool ListaProductosActivos = true;
        bool perdio_el_foco = false;
        //_____________________________________________________________
        //____________________________________________________________
        //esta variable sirve para insertar o no caracteristicas a la DB
        bool utilizarCaracterisicas = false;
        bool utilizaCodigoAutomatico = false;

        bool utilizasublinea = false;
        bool utilizamarca = false;

        bool conCaracteristicas;
        //_____________________________________________________________


        //______________________Variables para enviar id sublinea y marca si lo utiliza el producto
        int idSublinea = 0, idmarca = 0;
        //__________________________________________________________________
        //_________________________________________________________________
        //_______________vairables para validar si utilizar sublinea y marca

        bool utilizaSublinea = false;
        bool utilizaMarca = false;
        //_________________________________________________________________
        //_________________________________________________________________

        //_______________Variable para cargae la imagen por ruta______________
        string rutaimagen = "";
        string NombreImagenDeProducto = "";//esta variable es para gaurdar la imagen en la capreta y el nombre en la base de datos
        //____________________________________________________________________

        //___________________esta variable sirve para saber si el usuario esta en proceso 
        //_______de creacion de un prodcuto por lo tanto si preciona cancelar o salir,
        //este indica que debe terminar el proceso o cancelarlo
        bool enProcesoDeCreacion = false;
        bool enProcesoDeEdicion = false;
        //________________________________________________________________________________

        //______________Estas variables sivern para el detalle de las caracteristicas____________________________________________
        DataTable dtDetalleCaracteristicasInsercion;//esta variable se encarga de enviar a la base de datos
        DataTable dtDetalleCaracteristicasInsercionAgregar;//esta variable es una copia par poder editar todo el detalle
                                   //_____________________________________________________________________

        //______________id del producto para editarlo
        int idproducto = 0;
        //___________________________________________


        //______________________________________________
        List<Control> controles = new List<Control>(); //esta vaiable es para revisar los controles o campos obligatorios
        //_______________________________________________
        Computer mycomputer = new Computer(); // Así accederemos al "FileSystem".

        string tipo_de_operacion = "";
        public FormProductos(string tipo_operacion)
        {
            InitializeComponent();
            this.Text = tipo_operacion;
            this.tipo_de_operacion = tipo_operacion;
        }


        //___________________________________________________________________
        //___________________funciones para limpiear cajas de texto ___________________________________________
        void limpiarEntradasCaracteristicas()
        {
            textTitulo.Text = string.Empty;
            textDescripcion.Text = string.Empty;

            if (conCaracteristicas)
            {
                dtCaracteristicas.Rows.Clear();

            }
            else
            {
                dtDetalleCaracteristicasInsercion.Rows.Clear();
            }



        }
     
        void RecargarTodo()
        {
            mostrarProductos();
            mostrarProductosConImagen();


        }
        //______________________________________________________________________________
        //______________________________________________________________________________

        //______________________________________________________________________________


        void limpiarEntradasProducto()
        {
            txtNombre.Text = string.Empty;
            txtPresentacion.Text = string.Empty;
            spinEditMesesGarantia.EditValue = 0;
            spinEditPrecioA.EditValue = 0;
            spinEditPrecioB.EditValue = 0;
            spinEditPrecioC.EditValue = 0;
            spinEditDescuento.EditValue = 0;
            txtCodigoProducto.Text = string.Empty;
            this.pictureEditImagen.Image = null;
            rutaimagen = "";


        }
        //___________________________________________________________________
        //___________________________________________________________________

        //____________________________________________________________________________________
        //_____________________________es funcion sirve para limpiar todas la entradas___________________________________________
        // y para terminar el proceso de creacion.
        void terminarProcesos()
        {
            limpiarEntradasCaracteristicas();
            limpiarEntradasProducto();
            if (esEditar)
            {
                if (utilizaImagen)
                {
                    System.IO.File.Delete("./assets/ImagenesTemporal/" + imagenEliminacion);
                    NombreImagenDeProducto = "";
                }

            }
        }

        void MostrarMensajeDeCancelar(string mensaje, string titulo)
        {
            if (XtraMessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo) != DialogResult.No)
            {
                terminarProcesos();
                enProcesoDeCreacion = false;
                esEditar = false;
                esNuevo = false;

                if (tipo_de_operacion.Equals("Agregar"))
                {
                    this.Close();
                }
                if (tipo_de_operacion.Equals("Editar"))
                {
                    xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;

                    //if (ListaProductosActivos == false)
                    //{
                    //    layoutControlGroupListaProductos.Text = "LISTA DE PRODUCTOS INACTIVOS";
                    //    mostrarProductosInactivos();
                    //}
                    //if (ListaProductosActivos)
                    //{
                    //    layoutControlGroupListaProductos.Text = "LISTA DE PRODUCTOS ACTIVOS";
                    //    mostrarProductos();

                    //}
                }



            }
        }
        //____________________________________________________________________________________
        //____________________________________________________________________________________

        //_____________________Funcioens para crear datatable con sus variables para el detalle de caracteristicas____
        //__________________________________________________________________________________________________________
        public void createTableDetCaracteristicasParaDB()
        {
            this.dtDetalleCaracteristicasInsercion = new DataTable();
            //this.dtDetalleCaracteristicasInsercion.Columns.Add("idcaracteristicaproducto", System.Type.GetType("System.Int32"));
            //this.dtDetalleCaracteristicasInsercion.Columns.Add("titulo", System.Type.GetType("System.String"));
            //this.dtDetalleCaracteristicasInsercion.Columns.Add("descripcion", System.Type.GetType("System.String"));

            this.gridControlDetalleCaracteristicas.DataSource = this.dtDetalleCaracteristicasInsercion;


        }

        public void createTableDetCaracteristicasParaCopia()
        {
            this.dtCaracteristicas = new DataTable();
            //this.dtDetalleCaracteristicasInsercionAgregar.Columns.Add("idcaracteristicaproducto", System.Type.GetType("System.Int32"));
            //this.dtDetalleCaracteristicasInsercionAgregar.Columns.Add("titulo", System.Type.GetType("System.String"));
            //this.dtDetalleCaracteristicasInsercionAgregar.Columns.Add("descripcion", System.Type.GetType("System.String"));
            //__relacionar nuesto datagridview con nuestro datatable



        }
        //__________________________________________________________________________________________________________
        //__________________________________________________________________________________________________________
        //__________________________________________________________________________________________________________




        //________________________________________________________________________________
        //________________________________________________________________________________
        //__________________________Funciones para mostrar productos________________________________________
        public void mostrarProductos()
        {
            gridControlListTodos.DataSource = ControllerProducto.MostrarProductos();
            gridControlListTodos.ForceInitialize();
            gridViewListaTodos.BestFitColumns();

        }

        public void mostrarProductosInactivos()
        {
            gridControlListTodos.DataSource = ControllerProducto.MostrarProductosInactivos();
            gridControlListTodos.ForceInitialize();
            gridViewListaTodos.BestFitColumns();

        }



        public void mostrarProductosConImagen()
        {
            //gridControlListaConImagen.DataSource = ControllerProducto.MostrarProductos();
        }


        public void mostrarProductosSinMarca()
        {
            //gridControlListaSinMarca.DataSource = ControllerProducto.MostrarProductosSinMarcar();
        }
        //________________________________________________________________________________
        //________________________________________________________________________________

        //________________________________________________________________________________
        //________________________________________________________________________________
        //__________________________Funciones para mostrar linea, sublinea y marcaa en un control combobox lookupedit________________________________________
        //---1 recibe el control lookupedit, nombre d el campo a mostrar, y el id a evaluar
        //cunado el usaruio seleccione en el combobox, y un datable que trae los datos de la DB 
        public void mostrarEnComboboxLookUp(LookUpEdit lookupeditnombre, string nombreDisplay, string idvalue, DataTable datos)
        {

            lookupeditnombre.Properties.DisplayMember = nombreDisplay;
            lookupeditnombre.Properties.ValueMember = idvalue;
            lookupeditnombre.Properties.DataSource = datos;
            //lookupeditnombre.EditValue = datos.Rows[0][lookupeditnombre.Properties.ValueMember];
        }


        //________________________________________________________________________________
        //________________________________________________________________________________
        //_______________________________Funcion para Cargar la imagen el el picturebox____________________________________

 
        private void cargarImagenPictureBox(string rutaImagen)
        {
            this.pictureEditImagen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            if (rutaImagen == "")
            {

                this.pictureEditImagen.Image = null;
            }
            else
            {

                BitmapImage image = new BitmapImage();

                using (var stream = File.OpenRead(rutaImagen))
                {
                    image.BeginInit();
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.StreamSource = stream;
                    image.EndInit();

                    this.pictureEditImagen.Image = Image.FromStream(stream);
                }



            }


        }
        //________________________________________________________________________________

        void Editar()
        {
            if (gridViewListaTodos.DataRowCount > 0)
            {
                esEditar = true;
                enProcesoDeCreacion = true;

                if (!tipo_de_operacion.Equals("Catalogo"))
                {
                    tipo_de_operacion = "Editar";
                }

                if (tipo_de_operacion.Equals("Catalogo"))
                {
                    tipo_de_operacion = "Detalle";
                }
           

                bool conMarca;
                string aplicaSerie;
                mostrarEnComboboxLookUp(lookUpEditLinea, "nombre", "idlinea", ControllerProducto.MostrarLineasActivas());
                mostrarEnComboboxLookUp(lookUpEditMarca, "Nombre", "idmarca", ControllerProducto.MostrarMarcasActivas());
                mostrarEnComboboxLookUp(lookUpEditSubLinea, "descripcion", "idsublinea", ControllerProducto.MostrarSubLineasActivas(Convert.ToInt32(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "idlinea"))));

                idproducto = Convert.ToInt32(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "idproducto"));



                txtNombre.Text = Convert.ToString(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "nombre"));
                txtModelo.Text = Convert.ToString(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "modelo"));
                txtPresentacion.Text = Convert.ToString(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "presentacion"));
                txtCodigoProducto.Text = Convert.ToString(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "codigo"));
                CodigoProducto = Convert.ToString(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "codigo"));
                lookUpEditLinea.EditValue = Convert.ToInt32(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "idlinea"));
                lookUpEditSubLinea.EditValue = Convert.ToInt32(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "idsublinea"));
                spinEditPrecioA.EditValue = Convert.ToDecimal(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "precioa"));
                spinEditPrecioB.EditValue = Convert.ToDecimal(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "preciob"));
                spinEditPrecioC.EditValue = Convert.ToDecimal(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "precioc"));
                spinEditMesesGarantia.EditValue = Convert.ToInt32(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "num_meses_garantia"));
                spinEditDescuento.EditValue = Convert.ToDecimal(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "descuento"));
                txtCodigoProducto.Text = CodigoProducto;
                conMarca = Convert.ToBoolean(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "utilizamarca"));
                conCaracteristicas = Convert.ToBoolean(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "conCaracteristicas"));
                utilizaImagen = Convert.ToBoolean(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "utilizaImagen"));
                aplicaSerie = Convert.ToString(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "aplica_serie"));
                en_bodega = Convert.ToBoolean(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "en_bodega"));

                if (conMarca)
                {
                    radioGroupMarca.SelectedIndex = 1;
                    lookUpEditMarca.EditValue = Convert.ToInt32(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "idmarca"));
                }
                else
                {
                    radioGroupMarca.SelectedIndex = 0;
                }


                if (conCaracteristicas)
                {
                    radioGroupCaracteristicas.SelectedIndex = 1;
                    dtCaracteristicas = ControllerProducto.MostrarCaracteristicas(idproducto);
                    dtDetalleCaracteristicasInsercion = ControllerProducto.MostrarCaracteristicas(idproducto);
                    this.gridControlDetalleCaracteristicas.DataSource = this.dtDetalleCaracteristicasInsercion;
                    gridControlDetalleCaracteristicas.ForceInitialize();
                    gridViewDetalleCaracteristicas.BestFitColumns();
                }
                else
                {
                    radioGroupCaracteristicas.SelectedIndex = 0;
                    dtDetalleCaracteristicasInsercion = ControllerProducto.MostrarCaracteristicas(idproducto);
                    this.gridControlDetalleCaracteristicas.DataSource = this.dtDetalleCaracteristicasInsercion;
                }

                if (utilizaImagen)
                {
                    rutaimagen = "./assets/ImagenesProductos/" + gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "nombreImagen").ToString();
                    NombreImagenDeProducto = gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "nombreImagen").ToString();
                    imagenEliminacion = gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "nombreImagen").ToString();
                    cargarImagenPictureBox(rutaimagen);


                    if (File.Exists("./assets/ImagenesTemporal/ " + NombreImagenDeProducto))
                    {
                        //XtraMessageBox.Show("OTRO PRODUCTO YA TIENE LA MISMA IMAGEN, SI DESEA USARLA PARA EL PRODUCTO QUE ESTÁ CREANDO DEBE CAMBIAR EL NOMBRE EN EL ORIGEN.", "IMAGEN DE PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.IO.File.Delete("./assets/ImagenesTemporal/" + gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "nombreImagen").ToString());
                        //NombreImagenDeProducto = "";
                    }
                    else
                    {
                        System.IO.File.Copy(rutaimagen, "./assets/ImagenesTemporal/" + NombreImagenDeProducto);
                    }

                }
                else
                {
                    cargarImagenPictureBox("");
                    NombreImagenDeProducto = "";
                    imagenEliminacion = "";
                }

                if (aplicaSerie == "Si aplica")
                {
                    radioGroupAplicaSerie.SelectedIndex = 1;
                }
                else
                {
                    radioGroupAplicaSerie.SelectedIndex = 0;
                }




                xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
                layoutControlItemBtnAnular.Enabled = true;
                layoutControlItemCodigo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                if (ListaProductosActivos)
                {
                    btnAnular.Text = "DESACTIVAR";
                    layoutControlItemBtnGuardar.Enabled = true;
                    lyBtnQuitarImagen.Enabled = true;
                    lyBtnAgregarImagen.Enabled = true;
                }
                else
                {
                    btnAnular.Text = "ACTIVAR";
                    layoutControlItemBtnGuardar.Enabled = false;
                    lyBtnQuitarImagen.Enabled = false;
                    lyBtnAgregarImagen.Enabled = false;
                }



            }

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

            bool mostrarErrorProvier = true;
            xtraTabControlMenuOpciones.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            radioGroupCaracteristicas.SelectedIndex = 0;

            if (tipo_de_operacion.Equals("Agregar"))
            {
                xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;

                esNuevo = true;

                dxErrorProvider1.SetError(txtNombre, "ESTE CAMPO ES OBLIGATORIO");
                dxErrorProvider1.SetError(txtPresentacion, "ESTE CAMPO ES OBLIGATORIO");
                dxErrorProvider1.SetError(lookUpEditSubLinea, "ESTE CAMPO ES OBLIGATORIO");
                dxErrorProvider1.SetError(lookUpEditSubLinea, "ESTE CAMPO ES OBLIGATORIO");
                mostrarEnComboboxLookUp(lookUpEditLinea, "nombre", "idlinea", ControllerProducto.MostrarLineasActivas());
                mostrarEnComboboxLookUp(lookUpEditMarca, "Nombre", "idmarca", ControllerProducto.MostrarMarcasActivas());
                enProcesoDeCreacion = true;


                dtDetalleCaracteristicasInsercion = ControllerProducto.MostrarCaracteristicas(0);

                this.gridControlDetalleCaracteristicas.DataSource = this.dtDetalleCaracteristicasInsercion;

                xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
                txtNombre.Focus();
                layoutControlItemBtnAnular.Enabled = false;
                layoutControlItemCodigo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                if (ListaProductosActivos == true || ListaProductosActivos == false)
                {
                    btnAnular.Text = "DESACTIVAR";
                    layoutControlItemBtnGuardar.Enabled = true;
                    lyBtnQuitarImagen.Enabled = true;
                    lyBtnAgregarImagen.Enabled = true;
                }

            }
            if (tipo_de_operacion.Equals("Lista"))
            {
                xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                mostrarProductos();
            }
            if (tipo_de_operacion.Equals("Catalogo"))
            {
                mostrarErrorProvier = false;
                xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                layoutControlItemBtnActivos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemInactivos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemBtnGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemBtnAnular.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                btnEditar.Text = "[Enter] Ver";

                txtNombre.ReadOnly = true;
                txtModelo.ReadOnly = true;
                txtPresentacion.ReadOnly = true;
                lookUpEditLinea.ReadOnly = true;
                lookUpEditSubLinea.ReadOnly = true;
                lookUpEditMarca.ReadOnly = true;
                radioGroupMarca.ReadOnly = true;
                radioGroupCaracteristicas.ReadOnly = true;
                radioGroupAplicaSerie.ReadOnly = true;
                spinEditMesesGarantia.ReadOnly = true;
                spinEditPrecioA.ReadOnly = true;
                spinEditPrecioB.ReadOnly = true;
                spinEditPrecioC.ReadOnly = true;
                spinEditDescuento.ReadOnly = true;
                txtCodigoProducto.ReadOnly = true;
                layoutControlItemTituloCaracteristicas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItemDescCaracterericticas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyBtnAddCarcat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyBtnQuitCaract.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyBtnAgregarImagen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lyBtnQuitarImagen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                gridViewDetalleCaracteristicas.OptionsBehavior.ReadOnly = true;
                mostrarProductos();
            }

            if (mostrarErrorProvier)
            {

                dxErrorProvider1.SetError(txtNombre, "ESTE CAMPO ES OBLIGATORIO");
                dxErrorProvider1.SetError(txtPresentacion, "ESTE CAMPO ES OBLIGATORIO");
                dxErrorProvider1.SetError(lookUpEditSubLinea, "ESTE CAMPO ES OBLIGATORIO");
                dxErrorProvider1.SetError(lookUpEditSubLinea, "ESTE CAMPO ES OBLIGATORIO");
            }





        }

        string ImageDir = @"assets\ImagenesProductos\";
        Hashtable Images = new Hashtable();

        string GetFileName(string color)
        {
            if (color == null || color == string.Empty)
                return string.Empty;
            return color;
        }



        private void FormProductos_Activated(object sender, EventArgs e)
        {
            lookUpEditLinea.Focus();

        }

        private void FormProductos_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (enProcesoDeCreacion == false)
            {
                if (e.KeyChar == 27)//si se preciona la tecla [ENTER]
                {
                    this.Close();
                }
            }

            if (esNuevo)//si es nuevo prodcuto entonces entra al proceso de cracion y la tecla [ESC] funciona solo para cancelar el proceso de creacion
            {
                if (e.KeyChar == 27)//si se preciona la tecla [ENTER]
                {
                    MostrarMensajeDeCancelar("¿DESEA CANCELAR EL PROCESO DE CREACIÓN?", "CREACIÓN EN PROCESO");
                }
            }
            if (esEditar)
            {
                if (e.KeyChar == 27)//lo contario cierra el formulario productos
                {
                    //MostrarMensajeDeCancelar("¿DESEA CANCELAR EL PROCESO DE EDICIÓN?", "EDICIÓN EN PROCESO");

                    //if (ListaProductosActivos == false)
                    //{
                    //    layoutControlGroupListaProductos.Text = "LISTA DE PRODUCTOS INACTIVOS";
                    //    mostrarProductosInactivos();
                    //}
                    //if (ListaProductosActivos)
                    //{
                    //    layoutControlGroupListaProductos.Text = "LISTA DE PRODUCTOS ACTIVOS";
                    //    mostrarProductos();

                    //}

                    if (esEditar)
                    {
                        if (tipo_de_operacion.Equals("Detalle"))
                        {
                            terminarProcesos();
                            xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                            tipo_de_operacion = "Catalogo";

                            enProcesoDeCreacion = false;
                            esEditar = false;
                            esNuevo = false;
                        }
                        else
                        {
                            MostrarMensajeDeCancelar("¿DESEA CANCELAR EL PROCESO DE EDICIÓN?", "EDICIÓN EN PROCESO");
                        }


                    }

                }
            }





        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (esEditar)
            {
                if (tipo_de_operacion.Equals("Detalle"))
                {
                    terminarProcesos();
                    xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                    tipo_de_operacion = "Catalogo";
                    terminarProcesos();
                    enProcesoDeCreacion = false;
                    esEditar = false;
                    esNuevo = false;
                }
                else
                {
                    MostrarMensajeDeCancelar("¿DESEA CANCELAR EL PROCESO DE EDICIÓN?", "EDICIÓN EN PROCESO");
                }


            }

            if (esNuevo)
            {
                MostrarMensajeDeCancelar("¿DESEA CANCELAR EL PROCESO DE CREACIÓN?", "CREACIÓN EN PROCESO");
                if (ListaProductosActivos == false)
                {
                    layoutControlGroupListaProductos.Text = "LISTA DE PRODUCTOS INACTIVOS";
                    mostrarProductosInactivos();
                }
                if (ListaProductosActivos)
                {
                    layoutControlGroupListaProductos.Text = "LISTA DE PRODUCTOS ACTIVOS";
                    mostrarProductos();

                }
            }

         

        }









        //__________________________________________________________________
        //______________________Botones para cargar y quitar la imagen la imagen_________________________________________
        public void CargarImagen()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "'c:\'";
            openFileDialog.Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png|gif (*.gif)|*.gif|Todos los archivos (*.*)|*.*";
            //string destino = Path.Combine(Application.StartupPath, String.Format(@"assets/ImagenesProductos/ {0}", Path.GetFileName(openFileDialog.FileName)));

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaimagen = openFileDialog.FileName;
                string destino = Path.Combine(Application.StartupPath, String.Format(@"assets\ImagenesProductos\{0}", Path.GetFileName(openFileDialog.FileName)));
                string nombreOriginalImagen = Path.GetFileName(rutaimagen);
                //MessageBox.Show(openFileDialog.FileName);
                if (File.Exists(destino))
                {
                    XtraMessageBox.Show("OTRO PRODUCTO YA TIENE LA MISMA IMAGEN, SI DESEA USARLA PARA EL PRODUCTO QUE ESTÁ CREANDO DEBE CAMBIAR EL NOMBRE EN EL ORIGEN.", "IMAGEN DE PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //NombreImagenDeProducto = "";
                }
                else
                {
                    NombreImagenDeProducto = nombreOriginalImagen;
                    imagenInsercion = rutaimagen;
                    cargarImagenPictureBox(rutaimagen);
                    activarImagen = "activar";
                }
            }



        }
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            CargarImagen();

        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {

            this.pictureEditImagen.Image = null;
            rutaimagen = "";
            NombreImagenDeProducto = "";
            activarImagen = "desactivar";
           
        }
        //__________________________________________________________________________________
        //__________________________________________________________________________________

        //__________________________________________________________________________________________________________________________________________
        //_________________________________________________Mostrar subliena y marca acorde a la liena seleccionada._________________________________________________________________________________________

        private void lookUpEditLinea_EditValueChanged(object sender, EventArgs e)
        {

            if (lookUpEditLinea.ItemIndex > -1)
            {
                if (esEditar)
                {
                    mostrarEnComboboxLookUp(lookUpEditSubLinea, "descripcion", "idsublinea", ControllerProducto.MostrarSubLineasActivas(Convert.ToInt32(lookUpEditLinea.EditValue)));
                    txtCodigoProducto.Text = Convert.ToString(lookUpEditLinea.GetColumnValue("nombre")).Substring(0, 3) + CodigoProducto.Substring(3, 5);
                }
                if (esNuevo)
                {
                    mostrarEnComboboxLookUp(lookUpEditSubLinea, "descripcion", "idsublinea", ControllerProducto.MostrarSubLineasActivas(Convert.ToInt32(lookUpEditLinea.EditValue)));
                    txtCodigoProducto.Text = Convert.ToString(lookUpEditLinea.GetColumnValue("nombre"));
                }
          
             
            }


        }
        //________________________________________________________________________________________________________________________________________
        //________________________________________________________________________________________________________________________________________



        //_____________________________________________________________________________________________________
        //_______________________________eventos con el teclado  para cambiar de control___________________________________________________
        private void lookUpEditLinea_KeyUp(object sender, KeyEventArgs e)
        {
            //____________Este codigo es para reazliar convinacion de teclas por ejemplo Ctrl+N
            //if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Down))
            //{
            //    lookUpEditLinea.ShowPopup();
            //}
        }

        private void lookUpEditLinea_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (count_teclado_foco == 1)
                {
                    count_teclado_foco = 0;
                    cambiar_foco = true;
                }

                if (!cambiar_foco)
                {
                    count_teclado_foco++;
                }
                if (cambiar_foco)
                {
                    cambiar_foco = false;
                    lookUpEditSubLinea.Focus();
                }

            }
        }

        private void spinEditPrecioA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinEditPrecioB.Focus();
            }
        }

        private void spinEditPrecioB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinEditPrecioC.Focus();
            }
        }

        private void spinEditPrecioC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinEditDescuento.Focus();
            }
        }

        private void textCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinEditMesesGarantia.Focus();
            }
        }

        private void spinEditMesesGarantia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spinEditPrecioA.Focus();
            }
        }

        private void textNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtModelo.Focus();
            }

        }

        private void textTitulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //textDescripcion.Focus();
            }
        }

        

        



        private void gridViewConImagen_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {

                GridView view = sender as GridView;

                string colorName = (string)((DataRowView)e.Row)["nombre"];
                string fileName = GetFileName(colorName).ToLower();
                if (!Images.ContainsKey(fileName))
                {
                    Image img = null;
                    try
                    {
                        string filePath = ImageDir + fileName;
                        img = Image.FromFile(filePath);
                        Console.Write(filePath);
                    }
                    catch
                    {
                    }
                    Images.Add(fileName, img);
                }
                e.Value = Images[fileName];
            }
        }

        private void gridView5_DoubleClick(object sender, EventArgs e)
        {
            esEditar = true;
            idproducto = Convert.ToInt32(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "idproducto"));
            lookUpEditLinea.Text = gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "linea").ToString();
            lookUpEditSubLinea.Text = gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "sublinea").ToString();
            lookUpEditMarca.Text = gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "marca").ToString();
            txtNombre.Text = Convert.ToString(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "nombre"));

            //textCodigo.Text = gridView5.GetRowCellValue(gridView5.FocusedRowHandle, "codigo").ToString();
            spinEditPrecioA.EditValue = Convert.ToDecimal(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "precioa"));
            spinEditPrecioB.EditValue = Convert.ToDecimal(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "preciob"));
            spinEditPrecioC.EditValue = Convert.ToDecimal(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "precioc"));
            spinEditMesesGarantia.EditValue = Convert.ToInt32(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "num_meses_garantia"));


            rutaimagen = gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "imagen").ToString();
            cargarImagenPictureBox(rutaimagen);
            if (Convert.ToChar(gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "conCaracteristicas")) == '1')
            {
                radioGroupCaracteristicas.SelectedIndex = 0;
            }
            //dtDetalleCaracteristicasInsercionAgregar = ControllerSoft502.ControllerProducto.ShowDetail(idproducto);


            //foreach (DataRow rows1 in ControllerSoft502.ControllerProducto.ShowDetail(idproducto).Rows)
            //{
            //    DataRow row1 = dtDetalleCaracteristicasInsercion.NewRow();
            //    row1["idcaracteristicaproducto"] = Convert.ToInt32(rows1["idcaracteristicaproducto"]);
            //    row1["titulo"] = Convert.ToString(rows1["titulo"]);
            //    row1["descripcion"] = Convert.ToString(rows1["descripcion"]);
            //    dtDetalleCaracteristicasInsercion.Rows.Add(row1);
            //}
            xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
        }









       public void QuitarCaracteristica()
        {
            if (dtDetalleCaracteristicasInsercion.Rows.Count > 0)
            {
                int rowIndex = gridViewDetalleCaracteristicas.FocusedRowHandle;
                DataRow row = this.dtDetalleCaracteristicasInsercion.Rows[rowIndex];
                this.dtDetalleCaracteristicasInsercion.Rows.Remove(row);
            }
            else
            {
                if (esNuevo)
                {
                    XtraMessageBox.Show("NO HAY CARACTERISTICAS PARA QUITAR", "CREACIÓN DE PRODUCTO");
                }
                if (esEditar)
                {
                    XtraMessageBox.Show("NO HAY CARACTERISTICAS PARA QUITAR", "EDICIÓN DE PRODUCTO");
                }

            }
        }


       


        private void radioGroupCaracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupCaracteristicas.SelectedIndex == 0)
            {
                utilizarCaracterisicas = false;
                layoutControlGroupCaracteristicas.Enabled = false;
                dxErrorProvider1.SetError(textTitulo, "");
                dxErrorProvider1.SetError(textDescripcion, "");

            }
            if (radioGroupCaracteristicas.SelectedIndex == 1)
            {
                utilizarCaracterisicas = true;
                layoutControlGroupCaracteristicas.Enabled = true;
                dxErrorProvider1.SetError(textTitulo, "ESTE CAMPO ES OBLIGATORIO");
                dxErrorProvider1.SetError(textDescripcion, "ESTE CAMPO ES OBLIGATORIO");
            }
        }

        private void textPresentacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditLinea.Focus();
            }
        }

        private void lookUpEditSubLinea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (count_teclado_foco == 1)
                {
                    count_teclado_foco = 0;
                    cambiar_foco = true;
                }

                if (!cambiar_foco)
                {
                    count_teclado_foco++;
                }
                if (cambiar_foco)
                {
                    cambiar_foco = false;
                    radioGroupMarca.Focus();
                }

            }
        }

        private void lookUpEditMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lookUpEditMarca.SelectedText = lookUpEditMarca.Text;
                if (lookUpEditMarca.Text == "")
                {
                    XtraMessageBox.Show("Debe Seleccionar una marca");
                }
                else
                {
                    spinEditMesesGarantia.Focus();
                }
            }
        }

        private void spinEditDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                radioGroupCaracteristicas.Focus();
            }
        }

        private void radioGroupCaracteristicas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAgregarImagen.Focus();
            }
        }

        private void FormProductos_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F2)
            //{
            //    if (ListaProductosActivos)
            //    {

            //        if (esNuevo)
            //        {
            //            GuardarProducto();
            //        }
            //        if (esEditar)
            //        {
            //            ActualizarProducto();
            //        }
            //    }


            //}
        }

        private void radioGroupSublinea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (utilizaSublinea == true)
                {
                    lookUpEditSubLinea.Focus();
                }
                else
                {
                    radioGroupMarca.Focus();
                }

            }
        }

   

        private void radioGroupMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool mostrarErrorProvider = true;

            if (tipo_de_operacion.Equals("Detalle"))
            {
                mostrarErrorProvider = false;

            }

            if (!tipo_de_operacion.Equals("Detalle"))
            {
                mostrarErrorProvider = true;
  
            }

            if (radioGroupMarca.SelectedIndex == 0)
            {
                lookUpEditMarca.ReadOnly = true;
                utilizaMarca = false;
                idmarca = 0;

                dxErrorProvider1.SetError(lookUpEditMarca, "");
            }
            if (radioGroupMarca.SelectedIndex == 1)
            {
                lookUpEditMarca.ReadOnly = false;
                utilizaMarca = true;
                if (mostrarErrorProvider)
                {
                    dxErrorProvider1.SetError(lookUpEditMarca, "ESTE CAMPO ES OBLIGATORIO");
                }
          


            }
        }

        private void radioGroupMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (radioGroupMarca.SelectedIndex == 1)
                {
                    lookUpEditMarca.Focus();
                }
                else
                {
                    spinEditMesesGarantia.Focus();
                }
            }
        }

        private void lookUpEditSubLinea_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void lookUpEditMarca_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (lookUpEditLinea.SelectedText == lookUpEditLinea.Text)
            {
                MessageBox.Show("si");
            }
            else
            {
                MessageBox.Show("no");
            }

        }

      

        private void gridViewListaTodos_DoubleClick(object sender, EventArgs e)
        {
            //lookUpEditLinea.Text = gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "linea").ToString();
            //rutaimagen = gridViewListaTodos.GetRowCellValue(gridViewListaTodos.FocusedRowHandle, "imagen").ToString();
            //cargarImagenPictureBox(rutaimagen);
            //xtraTabControlMenuOpciones.SelectedTabPageIndex = 1;
        }

        private void gridViewListaTodos_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "marca")
            {
                if (Convert.ToString(e.Value) == "")
                {
                    e.DisplayText = "Sin marca";
                }
            }
            if (e.Column.FieldName == "sublinea")
            {
                if (Convert.ToString(e.Value) == "")
                {
                    e.DisplayText = "Sin sublinea";
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lookUpEditSubLinea_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {

        }

        public void LlenarObjeto()
        {
            producto = new MProducto();
            producto.Idproducto = idproducto;
            producto.Idtienda = Configuraciones.Configuraciones.idtienda;
            producto.Idsublinea = Convert.ToInt32(lookUpEditSubLinea.EditValue); 
            producto.Idmarca = radioGroupMarca.SelectedIndex == 1 ? Convert.ToInt32(lookUpEditMarca.EditValue) : 0;
            producto.Nombre = txtNombre.Text;
            producto.Modelo = string.IsNullOrWhiteSpace(txtModelo.Text) == true ? "" : txtModelo.Text;
            producto.Precioa = Convert.ToDecimal(spinEditPrecioA.EditValue);
            producto.Preciob = Convert.ToDecimal(spinEditPrecioB.EditValue);
            producto.Precioc = Convert.ToDecimal(spinEditPrecioC.EditValue);
            producto.RutaImagen = NombreImagenDeProducto == "" ? "ninguno" : NombreImagenDeProducto;
            producto.RutaImagenEliminacion = imagenEliminacion; 
            producto.UtilizaImagen = NombreImagenDeProducto == "" ? "0" : "1";
            producto.MesesGarantia = Convert.ToInt32(spinEditMesesGarantia.EditValue);
            producto.ConCaracteristica = radioGroupCaracteristicas.SelectedIndex == 0 ? "0" : "1";
            producto.Presentacion = txtPresentacion.Text;
            producto.EsReciente = "0";
            producto.Descuento = Convert.ToDecimal(spinEditDescuento.EditValue);
            producto.UtilizaMarca = radioGroupMarca.SelectedIndex == 1 ? "1" : "0";
            producto.Ultimocosto = 0;
            producto.NombreLinea = lookUpEditLinea.Text;
            producto.AplicaSerie = radioGroupAplicaSerie.SelectedIndex == 0 ? "0" : "1";
            producto.RutaImagenInsercion = imagenInsercion;
            producto.ActivarImagen = activarImagen;
            producto.Codigo = string.IsNullOrWhiteSpace(txtCodigoProducto.Text) ? "0": txtCodigoProducto.Text;
        }
        public  void GuardarProducto()
        {
            string respuesta = "";
            bool guardar = true;
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                XtraMessageBox.Show("DEBE ESCRIBIR LA DESCPRICIÓN", "CREACIÓN DE PRODUCTO");
                guardar = false;
            }
            //if (string.IsNullOrWhiteSpace(txtModelo.Text))
            //{
            //    XtraMessageBox.Show("DEBE ESCRIBIR EL MODELO", "CREACIÓN DE PRODUCTO");
            //    guardar = false;
            //}
            if (string.IsNullOrWhiteSpace(txtPresentacion.Text))
            {
                XtraMessageBox.Show("DEBE ESCRIBIR LA PRESENTACIÓN", "CREACIÓN DE PRODUCTO");
                guardar = false;
            }
            if (lookUpEditLinea.ItemIndex < 0)
            {
                XtraMessageBox.Show("DEBE SELECCIONAR UNA LINEA", "CREACIÓN DE PRODUCTO");
                guardar = false;
            }
            if (lookUpEditSubLinea.ItemIndex < 0)
            {
                XtraMessageBox.Show("DEBE SELECCIONAR LA SUBLINEA", "CREACIÓN DE PRODUCTO");
                guardar = false;
            }
            if (radioGroupMarca.SelectedIndex == 1)
            {
                if (lookUpEditMarca.ItemIndex < 0)
                {
                    XtraMessageBox.Show("DEBE SELECCIONAR LA MARCA", "CREACIÓN DE PRODUCTO");
                    guardar = false;
                }
            }
            if (radioGroupCaracteristicas.SelectedIndex == 1)
            {
                if (gridViewDetalleCaracteristicas.DataRowCount == 0)
                {
                    XtraMessageBox.Show("DEBE AGREGAR UNA O MAS CARACTERISTICAS", "CREACIÓN DE PRODUCTO");
                    guardar = false;
                }
            }

            if (guardar)//________________SI LA VARIABLE GAURDAR ES VERDADERA ENTOCE SPROCEDE A CREAR EL PRODUCTO EN LA BASE DE DATOS
            {
                LlenarObjeto();


                if (radioGroupCaracteristicas.SelectedIndex == 1)
                {
                    List<MCaracteristicasProducto> caracterisicasDetalle = new List<MCaracteristicasProducto>();
                    for (int i = 0; i < gridViewDetalleCaracteristicas.DataRowCount; i++)
                    {
                        MCaracteristicasProducto caracteritica = new MCaracteristicasProducto();
                        caracteritica.Idcaracteristica = (int)(gridViewDetalleCaracteristicas.GetRowCellValue(i, "idcaracteristicaproducto"));
                        caracteritica.Idtienda = Configuraciones.Configuraciones.idtienda;
                        caracteritica.Titulo = gridViewDetalleCaracteristicas.GetRowCellValue(i, "titulo").ToString();
                        caracteritica.Descripcion = gridViewDetalleCaracteristicas.GetRowCellValue(i, "descripcion").ToString();
                        caracteritica.Opcion = 1;
                        caracterisicasDetalle.Add(caracteritica);
                    }
                    respuesta = ControllerProducto.GuardarProducto(producto, caracterisicasDetalle);

                }
                else
                {
                    respuesta = ControllerProducto.GuardarProducto(producto, null);
                }

                if (respuesta == "OK")
                {
                    alertControl1.Show(this, "CREACIÓN DE PRODUCTO", "EL PRODUCTO SE CREO CORRECTAMENTE");
                    limpiarEntradasProducto();
                    limpiarEntradasCaracteristicas();
                    txtNombre.Focus();
                    NombreImagenDeProducto = "";
                    activarImagen = "neutro";

                    //if (ListaProductosActivos == false)
                    //{
                    //    layoutControlGroupListaProductos.Text = "LISTA DE PRODUCTOS INACTIVOS";
                    //    mostrarProductosInactivos();
                    //}
                    //if (ListaProductosActivos)
                    //{
                    //    layoutControlGroupListaProductos.Text = "LISTA DE PRODUCTOS ACTIVOS";
                    //    mostrarProductos();

                    //}


                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un erro al crear producto: " + respuesta, "Error al crear producto");
                }
            }


        }


        public void ActualizarProducto()
        {
            string respuesta = "";
            bool actualizar = true;
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                XtraMessageBox.Show("DEBE ESCRIBIR LA DESCPRICIÓN", "EDITANDO PRODUCTO");
                actualizar = false;
            }
            if (string.IsNullOrWhiteSpace(txtPresentacion.Text))
            {
                XtraMessageBox.Show("DEBE ESCRIBIR LA PRESENTACIÓN", "EDITANDO PRODUCTO");
                actualizar = false;
            }
            if (lookUpEditLinea.ItemIndex < 0)
            {
                XtraMessageBox.Show("DEBE SELECCIONAR UNA LINEA", "EDITANDO PRODUCTO");
                actualizar = false;
            }
            if (lookUpEditSubLinea.ItemIndex < 0)
            {
                XtraMessageBox.Show("DEBE SELECCIONAR LA SUBLINEA", "EDITANDO PRODUCTO");
                actualizar = false;
            }
            if (radioGroupMarca.SelectedIndex == 1)
            {
                if (lookUpEditMarca.ItemIndex < 0)
                {
                    XtraMessageBox.Show("DEBE SELECCIONAR LA MARCA", "EDITANDO PRODUCTO");
                    actualizar = false;
                }
            }
            if (radioGroupCaracteristicas.SelectedIndex == 1)
            {
                if (gridViewDetalleCaracteristicas.DataRowCount == 0)
                {
                    XtraMessageBox.Show("DEBE AGREGAR UNA O MAS CARACTERISTICAS", "EDITANDO PRODUCTO");
                    actualizar = false;
                }
            }




            if (actualizar)
            {
                LlenarObjeto();

                if (radioGroupCaracteristicas.SelectedIndex == 1)//_________aqui indicamos que si si selecciono la opcion que lleva caracteristicas
                {
                    if (conCaracteristicas)//_____________________-SI ya tien caracteristicas
                    {
                        List<MCaracteristicasProducto> caracterisicasDetalleEliminacion = new List<MCaracteristicasProducto>();
                        foreach (DataRow item in dtCaracteristicas.Rows)
                        {
                            MCaracteristicasProducto caracteritica = new MCaracteristicasProducto();
                            caracteritica.Idcaracteristica = (int)(item["idcaracteristicaproducto"]);
                            caracteritica.Idtienda = Configuraciones.Configuraciones.idtienda;
                            caracteritica.Idproducto = idproducto;
                            caracteritica.Titulo = (item["titulo"]).ToString();
                            caracteritica.Descripcion = (item["descripcion"]).ToString();
                            caracteritica.Opcion = 0;
                            caracterisicasDetalleEliminacion.Add(caracteritica);

                        }

                        List<MCaracteristicasProducto> caracterisicasDetalleInsercion = new List<MCaracteristicasProducto>();
                        for (int i = 0; i < gridViewDetalleCaracteristicas.DataRowCount; i++)
                        {
                            MCaracteristicasProducto caracteritica = new MCaracteristicasProducto();
                            caracteritica.Idcaracteristica = (int)(gridViewDetalleCaracteristicas.GetRowCellValue(i, "idcaracteristicaproducto"));
                            caracteritica.Idtienda = Configuraciones.Configuraciones.idtienda;
                            caracteritica.Titulo = gridViewDetalleCaracteristicas.GetRowCellValue(i, "titulo").ToString();
                            caracteritica.Descripcion = gridViewDetalleCaracteristicas.GetRowCellValue(i, "descripcion").ToString();
                            caracteritica.Opcion = 1;
                            caracterisicasDetalleInsercion.Add(caracteritica);
                        }
                        respuesta = ControllerProducto.ActualizarProducto(producto, caracterisicasDetalleEliminacion, caracterisicasDetalleInsercion);
                    }

                    else//__________________________si no tiene caracteristicas
                    {
                        List<MCaracteristicasProducto> caracterisicasDetalleInsercion = new List<MCaracteristicasProducto>();
                        for (int i = 0; i < gridViewDetalleCaracteristicas.DataRowCount; i++)
                        {
                            MCaracteristicasProducto caracteritica = new MCaracteristicasProducto();
                            caracteritica.Idcaracteristica = (int)(gridViewDetalleCaracteristicas.GetRowCellValue(i, "idcaracteristicaproducto"));
                            caracteritica.Idtienda = Configuraciones.Configuraciones.idtienda;
                            caracteritica.Titulo = gridViewDetalleCaracteristicas.GetRowCellValue(i, "titulo").ToString();
                            caracteritica.Descripcion = gridViewDetalleCaracteristicas.GetRowCellValue(i, "descripcion").ToString();
                            caracteritica.Opcion = 1;
                            caracterisicasDetalleInsercion.Add(caracteritica);
                        }
                        respuesta = ControllerProducto.ActualizarProducto(producto, null, caracterisicasDetalleInsercion);
                    }

                }
                else//_________aqui indicamos que si si selecciono la opcion que no lleva caracteristicas
                {
                    if (conCaracteristicas)//_____________________-SI ya tien caracteristicas
                    {
                        List<MCaracteristicasProducto> caracterisicasDetalleEliminacion = new List<MCaracteristicasProducto>();
                        foreach (DataRow item in dtCaracteristicas.Rows)
                        {
                            MCaracteristicasProducto caracteritica = new MCaracteristicasProducto();
                            caracteritica.Idcaracteristica = (int)(item["idcaracteristicaproducto"]);
                            caracteritica.Idtienda = Configuraciones.Configuraciones.idtienda;
                            caracteritica.Idproducto = idproducto;
                            caracteritica.Titulo = (item["titulo"]).ToString();
                            caracteritica.Descripcion = (item["descripcion"]).ToString();
                            caracteritica.Opcion = 0;
                            caracterisicasDetalleEliminacion.Add(caracteritica);

                        }

                        respuesta = ControllerProducto.ActualizarProducto(producto, caracterisicasDetalleEliminacion, null);
                    }

                    else//__________________________si no tiene caracteristicas
                    {
                        respuesta = ControllerProducto.ActualizarProducto(producto, null, null);
                    }
                }

                if (respuesta == "OK")
                {
                    alertControl1.Show(this, "EDICIÓN DE PRODUCTO", "EL PRODUCTO SE ACTUALIZO CORRECTAMENTE");
                    limpiarEntradasProducto();
                    mostrarProductos();
                    limpiarEntradasCaracteristicas();
                    txtNombre.Focus();
                    xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                    activarImagen = "neutro";
                    NombreImagenDeProducto = "";
                    lookUpEditLinea.Properties.DataSource = null;
                    lookUpEditSubLinea.Properties.DataSource = null;
                    enProcesoDeCreacion = false;
                    esEditar = false;
                    esNuevo = false;

                }
                else
                {
                    XtraMessageBox.Show("Ocurrio un erro al editar el producto: " + respuesta, "Error al editar producto");
                }
            }




            
        }


        private void gridControlListTodos_Click(object sender, EventArgs e)
        {

        }

        private void gridViewListaTodos_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            //if (e.Column.FieldName == "Image" && e.IsGetData)
            //{

            //    GridView view = sender as GridView;

            //    string colorName = (string)((DataRowView)e.Row)["nombreImagen"];
            //    string fileName = GetFileName(colorName).ToLower();
            //    if (!Images.ContainsKey(fileName))
            //    {
            //        Image img = null;
            //        try
            //        {
            //            string filePath = ImageDir + fileName;
            //            img = Image.FromFile(filePath);
            //            Console.Write(filePath);
            //        }
            //        catch
            //        {
            //        }
            //        Images.Add(fileName, img);
            //    }
            //    e.Value = Images[fileName];
            //}
        }

        private void gridViewDetalleCaracteristicas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                QuitarCaracteristica();
            }
        }

        private void FormProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (esNuevo || esEditar)
            {
                if (XtraMessageBox.Show("¿DESEA CANCELAR Y SALIR DEL PROCESO?", "PRODUCTO EN PROCESO", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    if (utilizaImagen)
                    {
                        System.IO.File.Delete("./assets/ImagenesTemporal/" + NombreImagenDeProducto);
                      
                    }
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }


        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (ListaProductosActivos)
            {
                if (XtraMessageBox.Show("¿DESEA DESACTIVAR EL PRODUCTO?", "DESACTIVAR PRODUCTO", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    string rpta = "";
                    if (en_bodega)
                    {
                        XtraMessageBox.Show("EL PRODUCTO ESTA EN BODEGA, NO SE PUEDE DESACTIVAR", "PRODUCTO EN BODEGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        rpta = ControllerProducto.DesactivarProducto(idproducto);
                        if (rpta == "OK")
                        {

                            XtraMessageBox.Show("EL PRODUCTO SE DESACTIVO CORRECTAMENTE", "PRODUCTO DESACTIVADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mostrarProductos();
                            terminarProcesos();
                            enProcesoDeCreacion = false;
                            esEditar = false;
                            esNuevo = false;
                            activarImagen = "neutro";
                            ListaProductosActivos = true;
                            xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                        }
                        else
                        {
                            XtraMessageBox.Show("OCURRIO UN ERROR AL DESACTIVAR EL PRODUCTO, POR FAVOR CONSULTE A SU ADMINISTRADOR DE DATOS " + rpta, "ERROR");
                        }

                    }
                }

            }
            if (!ListaProductosActivos)
            {
                if (XtraMessageBox.Show("¿DESEA ACTIVAR EL PRODUCTO?", "ACTIVAR PRODUCTO", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    string rpta = "";
                    rpta = ControllerProducto.ActivarProducto(idproducto);
                    if (rpta == "OK")
                    {

                        XtraMessageBox.Show("EL PRODUCTO SE ACTIVO CORRECTAMENTE", "PRODUCTO ACTIVADO");
                        mostrarProductosInactivos();
                        terminarProcesos();
                        enProcesoDeCreacion = false;
                        esEditar = false;
                        esNuevo = false;
                        activarImagen = "neutro";
                        ListaProductosActivos = false;
                        xtraTabControlMenuOpciones.SelectedTabPageIndex = 0;
                    }
                    else
                    {
                        XtraMessageBox.Show("OCURRIO UN ERROR AL ACTIVAR EL PRODUCTO, POR FAVOR CONSULTE A SU ADMINISTRADOR DE DATOS " + rpta, "ERROR");
                    }

                }

            }
        }

        private void btnProductosActivos_Click(object sender, EventArgs e)
        {
            if (ListaProductosActivos == false)
            {
                layoutControlGroupListaProductos.Text = "LISTA DE PRODUCTOS ACTIVOS";
                mostrarProductos();
                ListaProductosActivos = true;
            }
      
        }

        private void btnProductosInactivos_Click(object sender, EventArgs e)
        {


            if (ListaProductosActivos)
            {
                layoutControlGroupListaProductos.Text = "LISTA DE PRODUCTOS INACTIVOS";
                mostrarProductosInactivos();
                ListaProductosActivos = false; 
            }

        }

        private void gridControlListTodos_Click_1(object sender, EventArgs e)
        {

        }

        private void lookUpEditLinea_Leave(object sender, EventArgs e)
        {
            if (!perdio_el_foco)
            {
                count_teclado_foco = 0;
            }

        }

        private void txtModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPresentacion.Focus();
            }
        }

        private void lookUpEditSubLinea_Properties_PopupFilter(object sender, DevExpress.XtraEditors.Controls.PopupFilterEventArgs e)
        {
            if (string.IsNullOrEmpty(e.SearchText)) return;
            LookUpEdit edit = sender as LookUpEdit;
            PropertyDescriptorCollection propertyDescriptors = ListBindingHelper.GetListItemProperties(edit.Properties.DataSource);
            IEnumerable<FunctionOperator> operators = propertyDescriptors.OfType<PropertyDescriptor>().Select(
                t => new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(t.Name), new OperandValue(e.SearchText)));
            e.Criteria = new GroupOperator(GroupOperatorType.Or, operators);
            e.SuppressSearchCriteria = true;
        }

        private void textTitulo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
       
        }

        private void gridViewListaTodos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Editar();
            }
        }

        private void btnAddCaracteristica_Click(object sender, EventArgs e)
        {
            bool agregar = true;
            if (string.IsNullOrWhiteSpace(textTitulo.Text))
            {
                if (esNuevo)
                {
                    XtraMessageBox.Show("POR FAVOR DEBE ESCRIBIR EL TITULO", "CREACIÓN DE PRODUCTO");
                }
                if (esEditar)
                {
                    XtraMessageBox.Show("POR FAVOR DEBE ESCRIBIR EL TITULO", "EDICIÓN DE PRODUCTO");
                }

                agregar = false;
                textTitulo.Focus();
            }
            if (string.IsNullOrWhiteSpace(textDescripcion.Text))
            {
                if (esNuevo)
                {
                    XtraMessageBox.Show("POR FAVOR DEBE ESCRIBIR LA DESCRIPCIÓN", "CREACIÓN DE PRODUCTO");
                }
                if (esEditar)
                {
                    XtraMessageBox.Show("POR FAVOR DEBE ESCRIBIR LA DESCRIPCIÓN", "EDICIÓN DE PRODUCTO");
                }

                agregar = false;
                textDescripcion.Focus();
            }

            if (agregar)
            {

                DataRow row = dtDetalleCaracteristicasInsercion.NewRow();
                row["idcaracteristicaproducto"] = 0;
                row["idtienda"] = Configuraciones.Configuraciones.idtienda;
                row["idproducto"] = idproducto;
                row["titulo"] = textTitulo.Text;
                row["descripcion"] = textDescripcion.Text;
                dtDetalleCaracteristicasInsercion.Rows.Add(row);
                textTitulo.Focus();

                textDescripcion.Text = string.Empty;
                textTitulo.Text = string.Empty;

            }

            gridControlDetalleCaracteristicas.ForceInitialize();
            gridViewDetalleCaracteristicas.BestFitColumns();
        }

        private void btnQuitCaracteristica_Click(object sender, EventArgs e)
        {
            QuitarCaracteristica();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            mostrarProductos();
        }

  
    
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                GuardarProducto();
            }
            if (esEditar)
            {
                ActualizarProducto();
            }
        }
    }
}