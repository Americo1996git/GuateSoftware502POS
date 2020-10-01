namespace ViewGuate502.Buscadores
{
    partial class BuscadorProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lookUpEditBodegas = new DevExpress.XtraEditors.LookUpEdit();
            this.gclistadoproductos = new DevExpress.XtraGrid.GridControl();
            this.listadoProductosVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSoftwareGTDataSet = new ViewGuate502.dbSoftwareGTDataSet();
            this.gvlistadoproductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidexistenciadetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecioa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpreciob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecioc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.listadoProductosVentaTableAdapter = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.ListadoProductosVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditBodegas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadoproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductosVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadoproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lookUpEditBodegas);
            this.layoutControl1.Controls.Add(this.gclistadoproductos);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 100, 812, 500);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1004, 330);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lookUpEditBodegas
            // 
            this.lookUpEditBodegas.Location = new System.Drawing.Point(51, 12);
            this.lookUpEditBodegas.Name = "lookUpEditBodegas";
            this.lookUpEditBodegas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditBodegas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre de bodega"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccion", "Ubicación")});
            this.lookUpEditBodegas.Size = new System.Drawing.Size(941, 20);
            this.lookUpEditBodegas.StyleController = this.layoutControl1;
            this.lookUpEditBodegas.TabIndex = 6;
            this.lookUpEditBodegas.EditValueChanged += new System.EventHandler(this.lookUpEditBodegas_EditValueChanged);
            // 
            // gclistadoproductos
            // 
            this.gclistadoproductos.DataSource = this.listadoProductosVentaBindingSource;
            this.gclistadoproductos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gclistadoproductos.Location = new System.Drawing.Point(12, 36);
            this.gclistadoproductos.MainView = this.gvlistadoproductos;
            this.gclistadoproductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gclistadoproductos.Name = "gclistadoproductos";
            this.gclistadoproductos.Size = new System.Drawing.Size(980, 282);
            this.gclistadoproductos.TabIndex = 0;
            this.gclistadoproductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlistadoproductos});
            // 
            // listadoProductosVentaBindingSource
            // 
            this.listadoProductosVentaBindingSource.DataMember = "ListadoProductosVenta";
            this.listadoProductosVentaBindingSource.DataSource = this.dbSoftwareGTDataSet;
            // 
            // dbSoftwareGTDataSet
            // 
            this.dbSoftwareGTDataSet.DataSetName = "dbSoftwareGTDataSet";
            this.dbSoftwareGTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvlistadoproductos
            // 
            this.gvlistadoproductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidexistenciadetalle,
            this.colidbodega,
            this.colidproducto,
            this.colstock,
            this.colnombre,
            this.colbodega,
            this.colproducto,
            this.colcodigo_producto,
            this.colprecioa,
            this.colpreciob,
            this.colprecioc,
            this.coldescuento_producto});
            this.gvlistadoproductos.DetailHeight = 284;
            this.gvlistadoproductos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvlistadoproductos.GridControl = this.gclistadoproductos;
            this.gvlistadoproductos.Name = "gvlistadoproductos";
            this.gvlistadoproductos.OptionsBehavior.Editable = false;
            this.gvlistadoproductos.OptionsBehavior.ReadOnly = true;
            this.gvlistadoproductos.OptionsFind.AlwaysVisible = true;
            this.gvlistadoproductos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvlistadoproductos.OptionsView.ColumnAutoWidth = false;
            this.gvlistadoproductos.OptionsView.ShowGroupPanel = false;
            this.gvlistadoproductos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvlistadoproductos_RowClick);
            // 
            // colidexistenciadetalle
            // 
            this.colidexistenciadetalle.FieldName = "idexistenciadetalle";
            this.colidexistenciadetalle.MinWidth = 17;
            this.colidexistenciadetalle.Name = "colidexistenciadetalle";
            this.colidexistenciadetalle.Width = 64;
            // 
            // colidbodega
            // 
            this.colidbodega.FieldName = "idbodega";
            this.colidbodega.MinWidth = 17;
            this.colidbodega.Name = "colidbodega";
            this.colidbodega.Width = 64;
            // 
            // colidproducto
            // 
            this.colidproducto.FieldName = "idproducto";
            this.colidproducto.MinWidth = 17;
            this.colidproducto.Name = "colidproducto";
            this.colidproducto.Width = 64;
            // 
            // colstock
            // 
            this.colstock.Caption = "Stock";
            this.colstock.FieldName = "stock";
            this.colstock.MinWidth = 17;
            this.colstock.Name = "colstock";
            this.colstock.Visible = true;
            this.colstock.VisibleIndex = 0;
            this.colstock.Width = 64;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Tienda";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 17;
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 8;
            this.colnombre.Width = 64;
            // 
            // colbodega
            // 
            this.colbodega.Caption = "Bodega";
            this.colbodega.FieldName = "bodega";
            this.colbodega.MinWidth = 17;
            this.colbodega.Name = "colbodega";
            this.colbodega.Visible = true;
            this.colbodega.VisibleIndex = 1;
            this.colbodega.Width = 64;
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Producto";
            this.colproducto.FieldName = "producto";
            this.colproducto.MinWidth = 17;
            this.colproducto.Name = "colproducto";
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 2;
            this.colproducto.Width = 64;
            // 
            // colcodigo_producto
            // 
            this.colcodigo_producto.Caption = "Código producto";
            this.colcodigo_producto.FieldName = "codigo_producto";
            this.colcodigo_producto.MinWidth = 17;
            this.colcodigo_producto.Name = "colcodigo_producto";
            this.colcodigo_producto.Visible = true;
            this.colcodigo_producto.VisibleIndex = 3;
            this.colcodigo_producto.Width = 64;
            // 
            // colprecioa
            // 
            this.colprecioa.Caption = "Precio A";
            this.colprecioa.FieldName = "precioa";
            this.colprecioa.MinWidth = 17;
            this.colprecioa.Name = "colprecioa";
            this.colprecioa.Visible = true;
            this.colprecioa.VisibleIndex = 4;
            this.colprecioa.Width = 64;
            // 
            // colpreciob
            // 
            this.colpreciob.Caption = "Precio B";
            this.colpreciob.FieldName = "preciob";
            this.colpreciob.MinWidth = 17;
            this.colpreciob.Name = "colpreciob";
            this.colpreciob.Visible = true;
            this.colpreciob.VisibleIndex = 5;
            this.colpreciob.Width = 64;
            // 
            // colprecioc
            // 
            this.colprecioc.Caption = "Precio C";
            this.colprecioc.FieldName = "precioc";
            this.colprecioc.MinWidth = 17;
            this.colprecioc.Name = "colprecioc";
            this.colprecioc.Visible = true;
            this.colprecioc.VisibleIndex = 6;
            this.colprecioc.Width = 64;
            // 
            // coldescuento_producto
            // 
            this.coldescuento_producto.Caption = "Desc. Producto";
            this.coldescuento_producto.FieldName = "descuento_producto";
            this.coldescuento_producto.MinWidth = 17;
            this.coldescuento_producto.Name = "coldescuento_producto";
            this.coldescuento_producto.Visible = true;
            this.coldescuento_producto.VisibleIndex = 7;
            this.coldescuento_producto.Width = 64;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1004, 330);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gclistadoproductos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(984, 286);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookUpEditBodegas;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(984, 24);
            this.layoutControlItem2.Text = "Bodega";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(36, 13);
            // 
            // listadoProductosVentaTableAdapter
            // 
            this.listadoProductosVentaTableAdapter.ClearBeforeFill = true;
            // 
            // BuscadorProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 330);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuscadorProductos";
            this.Text = "BuscadorProductos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuscadorProductos_FormClosed);
            this.Load += new System.EventHandler(this.BuscadorProductos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BuscadorProductos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditBodegas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadoproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProductosVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadoproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gclistadoproductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlistadoproductos;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private dbSoftwareGTDataSet dbSoftwareGTDataSet;
        private System.Windows.Forms.BindingSource listadoProductosVentaBindingSource;
        private dbSoftwareGTDataSetTableAdapters.ListadoProductosVentaTableAdapter listadoProductosVentaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colidexistenciadetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colidbodega;
        private DevExpress.XtraGrid.Columns.GridColumn colidproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colstock;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colprecioa;
        private DevExpress.XtraGrid.Columns.GridColumn colpreciob;
        private DevExpress.XtraGrid.Columns.GridColumn colprecioc;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento_producto;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditBodegas;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}