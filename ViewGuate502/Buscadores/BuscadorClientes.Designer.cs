namespace ViewGuate502.Buscadores
{
    partial class BuscadorClientes
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
            this.gcbuscadorclientes = new DevExpress.XtraEditors.GroupControl();
            this.gclistadoclientes = new DevExpress.XtraGrid.GridControl();
            this.listadoclientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dbSoftwareGTDataSet = new ViewGuate502.dbSoftwareGTDataSet();
            this.gvlistadoclientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldpi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colesFiador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.listadoclientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listadoclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listado_clientesTableAdapter = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.Listado_clientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcbuscadorclientes)).BeginInit();
            this.gcbuscadorclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadoclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoclientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadoclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoclientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoclientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcbuscadorclientes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 90, 812, 500);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(709, 325);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcbuscadorclientes
            // 
            this.gcbuscadorclientes.Controls.Add(this.gclistadoclientes);
            this.gcbuscadorclientes.Location = new System.Drawing.Point(11, 10);
            this.gcbuscadorclientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcbuscadorclientes.Name = "gcbuscadorclientes";
            this.gcbuscadorclientes.Size = new System.Drawing.Size(687, 305);
            this.gcbuscadorclientes.TabIndex = 0;
            this.gcbuscadorclientes.Text = "Buscador de clientes";
            // 
            // gclistadoclientes
            // 
            this.gclistadoclientes.DataSource = this.listadoclientesBindingSource2;
            this.gclistadoclientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclistadoclientes.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gclistadoclientes.Location = new System.Drawing.Point(2, 27);
            this.gclistadoclientes.MainView = this.gvlistadoclientes;
            this.gclistadoclientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gclistadoclientes.Name = "gclistadoclientes";
            this.gclistadoclientes.Size = new System.Drawing.Size(683, 276);
            this.gclistadoclientes.TabIndex = 0;
            this.gclistadoclientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlistadoclientes});
            // 
            // listadoclientesBindingSource2
            // 
            this.listadoclientesBindingSource2.DataMember = "Listado_clientes";
            this.listadoclientesBindingSource2.DataSource = this.dbSoftwareGTDataSet;
            // 
            // dbSoftwareGTDataSet
            // 
            this.dbSoftwareGTDataSet.DataSetName = "dbSoftwareGTDataSet";
            this.dbSoftwareGTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvlistadoclientes
            // 
            this.gvlistadoclientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_cliente,
            this.colnit,
            this.colemail,
            this.colfecha_creacion,
            this.colnombre_cliente,
            this.coldpi,
            this.colesFiador,
            this.coltelefono,
            this.coldireccion});
            this.gvlistadoclientes.DetailHeight = 284;
            this.gvlistadoclientes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvlistadoclientes.GridControl = this.gclistadoclientes;
            this.gvlistadoclientes.Name = "gvlistadoclientes";
            this.gvlistadoclientes.OptionsFind.AlwaysVisible = true;
            this.gvlistadoclientes.OptionsView.ShowGroupPanel = false;
            this.gvlistadoclientes.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltelefono, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvlistadoclientes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gvlistadoclientes.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvlistadoclientes_CellValueChanged);
            // 
            // colid_cliente
            // 
            this.colid_cliente.Caption = "Id";
            this.colid_cliente.FieldName = "id_cliente";
            this.colid_cliente.MinWidth = 17;
            this.colid_cliente.Name = "colid_cliente";
            this.colid_cliente.OptionsColumn.AllowEdit = false;
            this.colid_cliente.OptionsColumn.ReadOnly = true;
            this.colid_cliente.Visible = true;
            this.colid_cliente.VisibleIndex = 0;
            this.colid_cliente.Width = 46;
            // 
            // colnit
            // 
            this.colnit.Caption = "NIT";
            this.colnit.FieldName = "nit";
            this.colnit.MinWidth = 17;
            this.colnit.Name = "colnit";
            this.colnit.OptionsColumn.AllowEdit = false;
            this.colnit.OptionsColumn.ReadOnly = true;
            this.colnit.Visible = true;
            this.colnit.VisibleIndex = 1;
            this.colnit.Width = 81;
            // 
            // colemail
            // 
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.MinWidth = 17;
            this.colemail.Name = "colemail";
            this.colemail.OptionsColumn.AllowEdit = false;
            this.colemail.OptionsColumn.ReadOnly = true;
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 2;
            this.colemail.Width = 81;
            // 
            // colfecha_creacion
            // 
            this.colfecha_creacion.Caption = "Fecha creación";
            this.colfecha_creacion.FieldName = "fecha_creacion";
            this.colfecha_creacion.MinWidth = 17;
            this.colfecha_creacion.Name = "colfecha_creacion";
            this.colfecha_creacion.OptionsColumn.AllowEdit = false;
            this.colfecha_creacion.OptionsColumn.ReadOnly = true;
            this.colfecha_creacion.Visible = true;
            this.colfecha_creacion.VisibleIndex = 3;
            this.colfecha_creacion.Width = 90;
            // 
            // colnombre_cliente
            // 
            this.colnombre_cliente.Caption = "Cliente";
            this.colnombre_cliente.FieldName = "nombre_cliente";
            this.colnombre_cliente.MinWidth = 17;
            this.colnombre_cliente.Name = "colnombre_cliente";
            this.colnombre_cliente.OptionsColumn.AllowEdit = false;
            this.colnombre_cliente.OptionsColumn.ReadOnly = true;
            this.colnombre_cliente.Visible = true;
            this.colnombre_cliente.VisibleIndex = 4;
            this.colnombre_cliente.Width = 79;
            // 
            // coldpi
            // 
            this.coldpi.Caption = "CUI";
            this.coldpi.FieldName = "dpi";
            this.coldpi.MinWidth = 17;
            this.coldpi.Name = "coldpi";
            this.coldpi.OptionsColumn.AllowEdit = false;
            this.coldpi.OptionsColumn.ReadOnly = true;
            this.coldpi.Visible = true;
            this.coldpi.VisibleIndex = 5;
            this.coldpi.Width = 79;
            // 
            // colesFiador
            // 
            this.colesFiador.Caption = "¿Fiador?";
            this.colesFiador.FieldName = "esFiador";
            this.colesFiador.MinWidth = 17;
            this.colesFiador.Name = "colesFiador";
            this.colesFiador.OptionsColumn.AllowEdit = false;
            this.colesFiador.OptionsColumn.ReadOnly = true;
            this.colesFiador.Width = 53;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Teléfono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.MinWidth = 17;
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 6;
            this.coltelefono.Width = 71;
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "Dirección";
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.MinWidth = 17;
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.OptionsColumn.AllowEdit = false;
            this.coldireccion.OptionsColumn.ReadOnly = true;
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 7;
            this.coldireccion.Width = 88;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(709, 325);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcbuscadorclientes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(691, 309);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // listadoclientesBindingSource1
            // 
            this.listadoclientesBindingSource1.DataMember = "Listado_clientes";
            this.listadoclientesBindingSource1.DataSource = this.dbSoftwareGTDataSet;
            // 
            // listadoclientesBindingSource
            // 
            this.listadoclientesBindingSource.DataMember = "Listado_clientes";
            this.listadoclientesBindingSource.DataSource = this.dbSoftwareGTDataSet;
            // 
            // listado_clientesTableAdapter
            // 
            this.listado_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // BuscadorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 325);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuscadorClientes";
            this.Text = "BuscandorClientes";
            this.Load += new System.EventHandler(this.BuscandorClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcbuscadorclientes)).EndInit();
            this.gcbuscadorclientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclistadoclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoclientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadoclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoclientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoclientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl gcbuscadorclientes;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private dbSoftwareGTDataSet dbSoftwareGTDataSet;
        private System.Windows.Forms.BindingSource listadoclientesBindingSource;
        private dbSoftwareGTDataSetTableAdapters.Listado_clientesTableAdapter listado_clientesTableAdapter;
        private System.Windows.Forms.BindingSource listadoclientesBindingSource1;
        private DevExpress.XtraGrid.GridControl gclistadoclientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlistadoclientes;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colnit;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn coldpi;
        private DevExpress.XtraGrid.Columns.GridColumn colesFiador;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        protected DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private System.Windows.Forms.BindingSource listadoclientesBindingSource2;
    }
}