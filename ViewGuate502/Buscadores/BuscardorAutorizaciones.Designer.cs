namespace ViewGuate502.Buscadores
{
    partial class BuscardorAutorizaciones
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
            this.gcbuscadorautorizaciones = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.mecomentarios = new DevExpress.XtraEditors.MemoEdit();
            this.btnguardar = new DevExpress.XtraEditors.SimpleButton();
            this.gclistadoautorizaciones = new DevExpress.XtraGrid.GridControl();
            this.gvlistadoautorizaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcresultadosautorizaciones = new DevExpress.XtraGrid.GridControl();
            this.tbltiposaprobacioncreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSoftwareGTDataSet = new ViewGuate502.dbSoftwareGTDataSet();
            this.gvresultadosautorizaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_tipo_aprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_aprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tbl_tipos_aprobacion_creditoTableAdapter = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.tbl_tipos_aprobacion_creditoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcbuscadorautorizaciones)).BeginInit();
            this.gcbuscadorautorizaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mecomentarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadoautorizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadoautorizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcresultadosautorizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltiposaprobacioncreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvresultadosautorizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcbuscadorautorizaciones);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(773, 633);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcbuscadorautorizaciones
            // 
            this.gcbuscadorautorizaciones.Controls.Add(this.labelControl1);
            this.gcbuscadorautorizaciones.Controls.Add(this.mecomentarios);
            this.gcbuscadorautorizaciones.Controls.Add(this.btnguardar);
            this.gcbuscadorautorizaciones.Controls.Add(this.gclistadoautorizaciones);
            this.gcbuscadorautorizaciones.Controls.Add(this.gcresultadosautorizaciones);
            this.gcbuscadorautorizaciones.Location = new System.Drawing.Point(12, 12);
            this.gcbuscadorautorizaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcbuscadorautorizaciones.Name = "gcbuscadorautorizaciones";
            this.gcbuscadorautorizaciones.Size = new System.Drawing.Size(749, 609);
            this.gcbuscadorautorizaciones.TabIndex = 0;
            this.gcbuscadorautorizaciones.Text = "Buscador autorizaciones";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(667, 466);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Comentarios";
            // 
            // mecomentarios
            // 
            this.mecomentarios.Location = new System.Drawing.Point(311, 484);
            this.mecomentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mecomentarios.Name = "mecomentarios";
            this.mecomentarios.Size = new System.Drawing.Size(420, 81);
            this.mecomentarios.TabIndex = 2;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(651, 578);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(81, 24);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // gclistadoautorizaciones
            // 
            this.gclistadoautorizaciones.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gclistadoautorizaciones.Location = new System.Drawing.Point(0, 244);
            this.gclistadoautorizaciones.MainView = this.gvlistadoautorizaciones;
            this.gclistadoautorizaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gclistadoautorizaciones.Name = "gclistadoautorizaciones";
            this.gclistadoautorizaciones.Size = new System.Drawing.Size(735, 210);
            this.gclistadoautorizaciones.TabIndex = 1;
            this.gclistadoautorizaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlistadoautorizaciones});
            // 
            // gvlistadoautorizaciones
            // 
            this.gvlistadoautorizaciones.DetailHeight = 284;
            this.gvlistadoautorizaciones.GridControl = this.gclistadoautorizaciones;
            this.gvlistadoautorizaciones.Name = "gvlistadoautorizaciones";
            this.gvlistadoautorizaciones.OptionsBehavior.Editable = false;
            this.gvlistadoautorizaciones.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvlistadoautorizaciones.OptionsView.ShowGroupPanel = false;
            // 
            // gcresultadosautorizaciones
            // 
            this.gcresultadosautorizaciones.DataSource = this.tbltiposaprobacioncreditoBindingSource;
            this.gcresultadosautorizaciones.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcresultadosautorizaciones.Location = new System.Drawing.Point(0, 29);
            this.gcresultadosautorizaciones.MainView = this.gvresultadosautorizaciones;
            this.gcresultadosautorizaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcresultadosautorizaciones.Name = "gcresultadosautorizaciones";
            this.gcresultadosautorizaciones.Size = new System.Drawing.Size(735, 210);
            this.gcresultadosautorizaciones.TabIndex = 0;
            this.gcresultadosautorizaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvresultadosautorizaciones});
            // 
            // tbltiposaprobacioncreditoBindingSource
            // 
            this.tbltiposaprobacioncreditoBindingSource.DataMember = "tbl_tipos_aprobacion_credito";
            this.tbltiposaprobacioncreditoBindingSource.DataSource = this.dbSoftwareGTDataSet;
            // 
            // dbSoftwareGTDataSet
            // 
            this.dbSoftwareGTDataSet.DataSetName = "dbSoftwareGTDataSet";
            this.dbSoftwareGTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvresultadosautorizaciones
            // 
            this.gvresultadosautorizaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_tipo_aprobacion,
            this.coltipo_aprobacion,
            this.colactivo,
            this.colfecha_creacion,
            this.colid_usuario_creacion});
            this.gvresultadosautorizaciones.DetailHeight = 284;
            this.gvresultadosautorizaciones.GridControl = this.gcresultadosautorizaciones;
            this.gvresultadosautorizaciones.Name = "gvresultadosautorizaciones";
            this.gvresultadosautorizaciones.OptionsBehavior.Editable = false;
            this.gvresultadosautorizaciones.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvresultadosautorizaciones.OptionsView.ShowGroupPanel = false;
            this.gvresultadosautorizaciones.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvresultadosautorizaciones_RowClick);
            // 
            // colid_tipo_aprobacion
            // 
            this.colid_tipo_aprobacion.Caption = "Id";
            this.colid_tipo_aprobacion.FieldName = "id_tipo_aprobacion";
            this.colid_tipo_aprobacion.MinWidth = 17;
            this.colid_tipo_aprobacion.Name = "colid_tipo_aprobacion";
            this.colid_tipo_aprobacion.Width = 64;
            // 
            // coltipo_aprobacion
            // 
            this.coltipo_aprobacion.Caption = "Tipo aprobación";
            this.coltipo_aprobacion.FieldName = "tipo_aprobacion";
            this.coltipo_aprobacion.MinWidth = 17;
            this.coltipo_aprobacion.Name = "coltipo_aprobacion";
            this.coltipo_aprobacion.Visible = true;
            this.coltipo_aprobacion.VisibleIndex = 0;
            this.coltipo_aprobacion.Width = 64;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 17;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 64;
            // 
            // colfecha_creacion
            // 
            this.colfecha_creacion.FieldName = "fecha_creacion";
            this.colfecha_creacion.MinWidth = 17;
            this.colfecha_creacion.Name = "colfecha_creacion";
            this.colfecha_creacion.Width = 64;
            // 
            // colid_usuario_creacion
            // 
            this.colid_usuario_creacion.FieldName = "id_usuario_creacion";
            this.colid_usuario_creacion.MinWidth = 17;
            this.colid_usuario_creacion.Name = "colid_usuario_creacion";
            this.colid_usuario_creacion.Width = 64;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(773, 633);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcbuscadorautorizaciones;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(753, 613);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tbl_tipos_aprobacion_creditoTableAdapter
            // 
            this.tbl_tipos_aprobacion_creditoTableAdapter.ClearBeforeFill = true;
            // 
            // BuscardorAutorizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 633);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuscardorAutorizaciones";
            this.Text = "BuscardorAutorizaciones";
            this.Load += new System.EventHandler(this.BuscardorAutorizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcbuscadorautorizaciones)).EndInit();
            this.gcbuscadorautorizaciones.ResumeLayout(false);
            this.gcbuscadorautorizaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mecomentarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadoautorizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadoautorizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcresultadosautorizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltiposaprobacioncreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvresultadosautorizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl gcbuscadorautorizaciones;
        private DevExpress.XtraGrid.GridControl gcresultadosautorizaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gvresultadosautorizaciones;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnguardar;
        private DevExpress.XtraGrid.GridControl gclistadoautorizaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlistadoautorizaciones;
        private dbSoftwareGTDataSet dbSoftwareGTDataSet;
        private System.Windows.Forms.BindingSource tbltiposaprobacioncreditoBindingSource;
        private dbSoftwareGTDataSetTableAdapters.tbl_tipos_aprobacion_creditoTableAdapter tbl_tipos_aprobacion_creditoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_aprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_aprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario_creacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit mecomentarios;
    }
}