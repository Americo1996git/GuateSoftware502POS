namespace ViewGuate502.Buscadores
{
    partial class BuscadorAnticipos
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
            this.gcbuscadoranticipos = new DevExpress.XtraEditors.GroupControl();
            this.btnguardar = new DevExpress.XtraEditors.SimpleButton();
            this.gclistadoanticipos = new DevExpress.XtraGrid.GridControl();
            this.gvlistadoanticipos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcresultadosanticipos = new DevExpress.XtraGrid.GridControl();
            this.tblrecibosanticiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSoftwareGTDataSet = new ViewGuate502.dbSoftwareGTDataSet();
            this.gvresultadosanticipos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_recibos_anticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_recibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldetalle_recibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_usuario_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tienda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colserie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorrelativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tbl_recibos_anticiposTableAdapter = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.tbl_recibos_anticiposTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcbuscadoranticipos)).BeginInit();
            this.gcbuscadoranticipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadoanticipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadoanticipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcresultadosanticipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrecibosanticiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvresultadosanticipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcbuscadoranticipos);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(756, 549);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcbuscadoranticipos
            // 
            this.gcbuscadoranticipos.Controls.Add(this.btnguardar);
            this.gcbuscadoranticipos.Controls.Add(this.gclistadoanticipos);
            this.gcbuscadoranticipos.Controls.Add(this.gcresultadosanticipos);
            this.gcbuscadoranticipos.Location = new System.Drawing.Point(11, 10);
            this.gcbuscadoranticipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcbuscadoranticipos.Name = "gcbuscadoranticipos";
            this.gcbuscadoranticipos.Size = new System.Drawing.Size(734, 529);
            this.gcbuscadoranticipos.TabIndex = 0;
            this.gcbuscadoranticipos.Text = "Buscador de anticipos";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(642, 467);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(81, 24);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // gclistadoanticipos
            // 
            this.gclistadoanticipos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gclistadoanticipos.Location = new System.Drawing.Point(0, 244);
            this.gclistadoanticipos.MainView = this.gvlistadoanticipos;
            this.gclistadoanticipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gclistadoanticipos.Name = "gclistadoanticipos";
            this.gclistadoanticipos.Size = new System.Drawing.Size(735, 210);
            this.gclistadoanticipos.TabIndex = 0;
            this.gclistadoanticipos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlistadoanticipos});
            // 
            // gvlistadoanticipos
            // 
            this.gvlistadoanticipos.DetailHeight = 284;
            this.gvlistadoanticipos.GridControl = this.gclistadoanticipos;
            this.gvlistadoanticipos.Name = "gvlistadoanticipos";
            this.gvlistadoanticipos.OptionsBehavior.Editable = false;
            this.gvlistadoanticipos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvlistadoanticipos.OptionsView.ShowGroupPanel = false;
            // 
            // gcresultadosanticipos
            // 
            this.gcresultadosanticipos.DataSource = this.tblrecibosanticiposBindingSource;
            this.gcresultadosanticipos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcresultadosanticipos.Location = new System.Drawing.Point(0, 29);
            this.gcresultadosanticipos.MainView = this.gvresultadosanticipos;
            this.gcresultadosanticipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcresultadosanticipos.Name = "gcresultadosanticipos";
            this.gcresultadosanticipos.Size = new System.Drawing.Size(735, 210);
            this.gcresultadosanticipos.TabIndex = 0;
            this.gcresultadosanticipos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvresultadosanticipos});
            // 
            // tblrecibosanticiposBindingSource
            // 
            this.tblrecibosanticiposBindingSource.DataMember = "tbl_recibos_anticipos";
            this.tblrecibosanticiposBindingSource.DataSource = this.dbSoftwareGTDataSet;
            // 
            // dbSoftwareGTDataSet
            // 
            this.dbSoftwareGTDataSet.DataSetName = "dbSoftwareGTDataSet";
            this.dbSoftwareGTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvresultadosanticipos
            // 
            this.gvresultadosanticipos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_recibos_anticipo,
            this.colmonto_recibo,
            this.colid_tipo_pago,
            this.colid_cliente,
            this.colnombre_cliente,
            this.coldetalle_recibo,
            this.colfecha_creacion,
            this.colactivo,
            this.colid_usuario_creacion,
            this.colid_tienda,
            this.colserie,
            this.colcorrelativo,
            this.colid_serie});
            this.gvresultadosanticipos.DetailHeight = 284;
            this.gvresultadosanticipos.GridControl = this.gcresultadosanticipos;
            this.gvresultadosanticipos.Name = "gvresultadosanticipos";
            this.gvresultadosanticipos.OptionsBehavior.Editable = false;
            this.gvresultadosanticipos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvresultadosanticipos.OptionsView.ShowGroupPanel = false;
            this.gvresultadosanticipos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvresultadosanticipos_RowClick);
            // 
            // colid_recibos_anticipo
            // 
            this.colid_recibos_anticipo.FieldName = "id_recibos_anticipo";
            this.colid_recibos_anticipo.MinWidth = 17;
            this.colid_recibos_anticipo.Name = "colid_recibos_anticipo";
            this.colid_recibos_anticipo.OptionsColumn.ReadOnly = true;
            this.colid_recibos_anticipo.Width = 64;
            // 
            // colmonto_recibo
            // 
            this.colmonto_recibo.FieldName = "monto_recibo";
            this.colmonto_recibo.MinWidth = 17;
            this.colmonto_recibo.Name = "colmonto_recibo";
            this.colmonto_recibo.OptionsColumn.ReadOnly = true;
            this.colmonto_recibo.Visible = true;
            this.colmonto_recibo.VisibleIndex = 0;
            this.colmonto_recibo.Width = 64;
            // 
            // colid_tipo_pago
            // 
            this.colid_tipo_pago.FieldName = "id_tipo_pago";
            this.colid_tipo_pago.MinWidth = 17;
            this.colid_tipo_pago.Name = "colid_tipo_pago";
            this.colid_tipo_pago.OptionsColumn.ReadOnly = true;
            this.colid_tipo_pago.Width = 64;
            // 
            // colid_cliente
            // 
            this.colid_cliente.FieldName = "id_cliente";
            this.colid_cliente.MinWidth = 17;
            this.colid_cliente.Name = "colid_cliente";
            this.colid_cliente.OptionsColumn.ReadOnly = true;
            this.colid_cliente.Width = 64;
            // 
            // colnombre_cliente
            // 
            this.colnombre_cliente.FieldName = "nombre_cliente";
            this.colnombre_cliente.MinWidth = 17;
            this.colnombre_cliente.Name = "colnombre_cliente";
            this.colnombre_cliente.OptionsColumn.ReadOnly = true;
            this.colnombre_cliente.Visible = true;
            this.colnombre_cliente.VisibleIndex = 1;
            this.colnombre_cliente.Width = 64;
            // 
            // coldetalle_recibo
            // 
            this.coldetalle_recibo.FieldName = "detalle_recibo";
            this.coldetalle_recibo.MinWidth = 17;
            this.coldetalle_recibo.Name = "coldetalle_recibo";
            this.coldetalle_recibo.OptionsColumn.ReadOnly = true;
            this.coldetalle_recibo.Visible = true;
            this.coldetalle_recibo.VisibleIndex = 2;
            this.coldetalle_recibo.Width = 64;
            // 
            // colfecha_creacion
            // 
            this.colfecha_creacion.FieldName = "fecha_creacion";
            this.colfecha_creacion.MinWidth = 17;
            this.colfecha_creacion.Name = "colfecha_creacion";
            this.colfecha_creacion.OptionsColumn.ReadOnly = true;
            this.colfecha_creacion.Visible = true;
            this.colfecha_creacion.VisibleIndex = 3;
            this.colfecha_creacion.Width = 64;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 17;
            this.colactivo.Name = "colactivo";
            this.colactivo.OptionsColumn.ReadOnly = true;
            this.colactivo.Width = 64;
            // 
            // colid_usuario_creacion
            // 
            this.colid_usuario_creacion.FieldName = "id_usuario_creacion";
            this.colid_usuario_creacion.MinWidth = 17;
            this.colid_usuario_creacion.Name = "colid_usuario_creacion";
            this.colid_usuario_creacion.OptionsColumn.ReadOnly = true;
            this.colid_usuario_creacion.Width = 64;
            // 
            // colid_tienda
            // 
            this.colid_tienda.FieldName = "id_tienda";
            this.colid_tienda.MinWidth = 17;
            this.colid_tienda.Name = "colid_tienda";
            this.colid_tienda.OptionsColumn.ReadOnly = true;
            this.colid_tienda.Width = 64;
            // 
            // colserie
            // 
            this.colserie.FieldName = "serie";
            this.colserie.MinWidth = 17;
            this.colserie.Name = "colserie";
            this.colserie.OptionsColumn.ReadOnly = true;
            this.colserie.Visible = true;
            this.colserie.VisibleIndex = 4;
            this.colserie.Width = 64;
            // 
            // colcorrelativo
            // 
            this.colcorrelativo.FieldName = "correlativo";
            this.colcorrelativo.MinWidth = 17;
            this.colcorrelativo.Name = "colcorrelativo";
            this.colcorrelativo.OptionsColumn.ReadOnly = true;
            this.colcorrelativo.Visible = true;
            this.colcorrelativo.VisibleIndex = 5;
            this.colcorrelativo.Width = 64;
            // 
            // colid_serie
            // 
            this.colid_serie.FieldName = "id_serie";
            this.colid_serie.MinWidth = 17;
            this.colid_serie.Name = "colid_serie";
            this.colid_serie.OptionsColumn.ReadOnly = true;
            this.colid_serie.Width = 64;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(756, 549);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcbuscadoranticipos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(738, 533);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tbl_recibos_anticiposTableAdapter
            // 
            this.tbl_recibos_anticiposTableAdapter.ClearBeforeFill = true;
            // 
            // BuscadorAnticipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 549);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuscadorAnticipos";
            this.Text = "BuscadorAnticipos";
            this.Load += new System.EventHandler(this.BuscadorAnticipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcbuscadoranticipos)).EndInit();
            this.gcbuscadoranticipos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclistadoanticipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadoanticipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcresultadosanticipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblrecibosanticiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvresultadosanticipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl gcbuscadoranticipos;
        private DevExpress.XtraEditors.SimpleButton btnguardar;
        private DevExpress.XtraGrid.GridControl gclistadoanticipos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlistadoanticipos;
        private DevExpress.XtraGrid.GridControl gcresultadosanticipos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvresultadosanticipos;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private dbSoftwareGTDataSet dbSoftwareGTDataSet;
        private System.Windows.Forms.BindingSource tblrecibosanticiposBindingSource;
        private dbSoftwareGTDataSetTableAdapters.tbl_recibos_anticiposTableAdapter tbl_recibos_anticiposTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid_recibos_anticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_recibo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_pago;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn coldetalle_recibo;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_usuario_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tienda;
        private DevExpress.XtraGrid.Columns.GridColumn colserie;
        private DevExpress.XtraGrid.Columns.GridColumn colcorrelativo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_serie;
    }
}