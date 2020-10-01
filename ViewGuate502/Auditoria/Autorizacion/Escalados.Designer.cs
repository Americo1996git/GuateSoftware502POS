namespace ViewGuate502.Auditoria
{
    partial class Escalados
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
            this.auditoriapendientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSoftwareGTDataSet = new ViewGuate502.dbSoftwareGTDataSet();
            this.auditoria_pendientesTableAdapter = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.Auditoria_pendientesTableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcescalados = new DevExpress.XtraEditors.GroupControl();
            this.gclistadopendientes = new DevExpress.XtraGrid.GridControl();
            this.gvlistadopendientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_venta_enc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_creacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenvio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltienda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgenerado_por = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colautorizador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_cuotas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_enganche = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmonto_financiamiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaprobaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btndetalle = new DevExpress.XtraEditors.SimpleButton();
            this.btnaprobar = new DevExpress.XtraEditors.SimpleButton();
            this.lbltitulo = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.auditoriapendientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcescalados)).BeginInit();
            this.gcescalados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadopendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadopendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // auditoriapendientesBindingSource
            // 
            this.auditoriapendientesBindingSource.DataMember = "Auditoria_pendientes";
            this.auditoriapendientesBindingSource.DataSource = this.dbSoftwareGTDataSet;
            // 
            // dbSoftwareGTDataSet
            // 
            this.dbSoftwareGTDataSet.DataSetName = "dbSoftwareGTDataSet";
            this.dbSoftwareGTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditoria_pendientesTableAdapter
            // 
            this.auditoria_pendientesTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcescalados);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1510, 592);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcescalados
            // 
            this.gcescalados.Controls.Add(this.gclistadopendientes);
            this.gcescalados.Controls.Add(this.btndetalle);
            this.gcescalados.Controls.Add(this.btnaprobar);
            this.gcescalados.Controls.Add(this.lbltitulo);
            this.gcescalados.Location = new System.Drawing.Point(11, 10);
            this.gcescalados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcescalados.Name = "gcescalados";
            this.gcescalados.Size = new System.Drawing.Size(1488, 572);
            this.gcescalados.TabIndex = 6;
            this.gcescalados.Text = "Escalados";
            // 
            // gclistadopendientes
            // 
            this.gclistadopendientes.DataSource = this.auditoriapendientesBindingSource;
            this.gclistadopendientes.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gclistadopendientes.Location = new System.Drawing.Point(19, 89);
            this.gclistadopendientes.MainView = this.gvlistadopendientes;
            this.gclistadopendientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gclistadopendientes.Name = "gclistadopendientes";
            this.gclistadopendientes.Size = new System.Drawing.Size(1449, 394);
            this.gclistadopendientes.TabIndex = 2;
            this.gclistadopendientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlistadopendientes});
            // 
            // gvlistadopendientes
            // 
            this.gvlistadopendientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_venta_enc,
            this.colfecha_creacion,
            this.colenvio,
            this.coltienda,
            this.colgenerado_por,
            this.colvendedor,
            this.colautorizador,
            this.coltotal,
            this.colcantidad_cuotas,
            this.colmonto_enganche,
            this.colmonto_financiamiento,
            this.colaprobaciones});
            this.gvlistadopendientes.DetailHeight = 284;
            this.gvlistadopendientes.GridControl = this.gclistadopendientes;
            this.gvlistadopendientes.Name = "gvlistadopendientes";
            this.gvlistadopendientes.OptionsBehavior.Editable = false;
            this.gvlistadopendientes.OptionsFind.AlwaysVisible = true;
            this.gvlistadopendientes.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvlistadopendientes.OptionsView.ShowGroupPanel = false;
            // 
            // colid_venta_enc
            // 
            this.colid_venta_enc.FieldName = "id_venta_enc";
            this.colid_venta_enc.MinWidth = 17;
            this.colid_venta_enc.Name = "colid_venta_enc";
            this.colid_venta_enc.Width = 64;
            // 
            // colfecha_creacion
            // 
            this.colfecha_creacion.Caption = "Fecha creación";
            this.colfecha_creacion.FieldName = "fecha_creacion";
            this.colfecha_creacion.MinWidth = 17;
            this.colfecha_creacion.Name = "colfecha_creacion";
            this.colfecha_creacion.Visible = true;
            this.colfecha_creacion.VisibleIndex = 0;
            this.colfecha_creacion.Width = 64;
            // 
            // colenvio
            // 
            this.colenvio.Caption = "No- Envío";
            this.colenvio.FieldName = "envio";
            this.colenvio.MinWidth = 17;
            this.colenvio.Name = "colenvio";
            this.colenvio.Visible = true;
            this.colenvio.VisibleIndex = 1;
            this.colenvio.Width = 64;
            // 
            // coltienda
            // 
            this.coltienda.Caption = "Tienda";
            this.coltienda.FieldName = "tienda";
            this.coltienda.MinWidth = 17;
            this.coltienda.Name = "coltienda";
            this.coltienda.Visible = true;
            this.coltienda.VisibleIndex = 2;
            this.coltienda.Width = 64;
            // 
            // colgenerado_por
            // 
            this.colgenerado_por.Caption = "Generado por";
            this.colgenerado_por.FieldName = "generado_por";
            this.colgenerado_por.MinWidth = 17;
            this.colgenerado_por.Name = "colgenerado_por";
            this.colgenerado_por.Visible = true;
            this.colgenerado_por.VisibleIndex = 3;
            this.colgenerado_por.Width = 64;
            // 
            // colvendedor
            // 
            this.colvendedor.Caption = "Vendedor";
            this.colvendedor.FieldName = "vendedor";
            this.colvendedor.MinWidth = 17;
            this.colvendedor.Name = "colvendedor";
            this.colvendedor.Visible = true;
            this.colvendedor.VisibleIndex = 4;
            this.colvendedor.Width = 64;
            // 
            // colautorizador
            // 
            this.colautorizador.Caption = "Autorizador";
            this.colautorizador.FieldName = "autorizador";
            this.colautorizador.MinWidth = 17;
            this.colautorizador.Name = "colautorizador";
            this.colautorizador.Visible = true;
            this.colautorizador.VisibleIndex = 5;
            this.colautorizador.Width = 64;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.FieldName = "total";
            this.coltotal.MinWidth = 17;
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 6;
            this.coltotal.Width = 64;
            // 
            // colcantidad_cuotas
            // 
            this.colcantidad_cuotas.Caption = "Cantidad de cuotas";
            this.colcantidad_cuotas.FieldName = "cantidad_cuotas";
            this.colcantidad_cuotas.MinWidth = 17;
            this.colcantidad_cuotas.Name = "colcantidad_cuotas";
            this.colcantidad_cuotas.Visible = true;
            this.colcantidad_cuotas.VisibleIndex = 7;
            this.colcantidad_cuotas.Width = 64;
            // 
            // colmonto_enganche
            // 
            this.colmonto_enganche.Caption = "Enganche";
            this.colmonto_enganche.FieldName = "monto_enganche";
            this.colmonto_enganche.MinWidth = 17;
            this.colmonto_enganche.Name = "colmonto_enganche";
            this.colmonto_enganche.Visible = true;
            this.colmonto_enganche.VisibleIndex = 8;
            this.colmonto_enganche.Width = 64;
            // 
            // colmonto_financiamiento
            // 
            this.colmonto_financiamiento.Caption = "Financiamiento";
            this.colmonto_financiamiento.FieldName = "monto_financiamiento";
            this.colmonto_financiamiento.MinWidth = 17;
            this.colmonto_financiamiento.Name = "colmonto_financiamiento";
            this.colmonto_financiamiento.Visible = true;
            this.colmonto_financiamiento.VisibleIndex = 9;
            this.colmonto_financiamiento.Width = 64;
            // 
            // colaprobaciones
            // 
            this.colaprobaciones.Caption = "Aprobaciones";
            this.colaprobaciones.FieldName = "aprobaciones";
            this.colaprobaciones.MinWidth = 17;
            this.colaprobaciones.Name = "colaprobaciones";
            this.colaprobaciones.Visible = true;
            this.colaprobaciones.VisibleIndex = 10;
            this.colaprobaciones.Width = 64;
            // 
            // btndetalle
            // 
            this.btndetalle.Location = new System.Drawing.Point(1387, 509);
            this.btndetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(81, 24);
            this.btndetalle.TabIndex = 4;
            this.btndetalle.Text = "Ver detalle";
            // 
            // btnaprobar
            // 
            this.btnaprobar.Location = new System.Drawing.Point(1301, 509);
            this.btnaprobar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaprobar.Name = "btnaprobar";
            this.btnaprobar.Size = new System.Drawing.Size(81, 24);
            this.btnaprobar.TabIndex = 3;
            this.btnaprobar.Text = "Aprobar";
            this.btnaprobar.Click += new System.EventHandler(this.btnaprobar_Click_1);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lbltitulo.Appearance.Options.UseFont = true;
            this.lbltitulo.Location = new System.Drawing.Point(19, 46);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(457, 29);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Listado de envíos escalados a supervisores";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1510, 592);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcescalados;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1492, 576);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Escalados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 592);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Escalados";
            this.Text = "ESCALADOS";
            this.Load += new System.EventHandler(this.Escalados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.auditoriapendientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcescalados)).EndInit();
            this.gcescalados.ResumeLayout(false);
            this.gcescalados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadopendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadopendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource auditoriapendientesBindingSource;
        private dbSoftwareGTDataSet dbSoftwareGTDataSet;
        private dbSoftwareGTDataSetTableAdapters.Auditoria_pendientesTableAdapter auditoria_pendientesTableAdapter;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl gcescalados;
        public DevExpress.XtraGrid.GridControl gclistadopendientes;
        public DevExpress.XtraGrid.Views.Grid.GridView gvlistadopendientes;
        private DevExpress.XtraGrid.Columns.GridColumn colid_venta_enc;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_creacion;
        private DevExpress.XtraGrid.Columns.GridColumn colenvio;
        private DevExpress.XtraGrid.Columns.GridColumn coltienda;
        private DevExpress.XtraGrid.Columns.GridColumn colgenerado_por;
        private DevExpress.XtraGrid.Columns.GridColumn colvendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colautorizador;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_cuotas;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_enganche;
        private DevExpress.XtraGrid.Columns.GridColumn colmonto_financiamiento;
        private DevExpress.XtraEditors.SimpleButton btndetalle;
        private DevExpress.XtraEditors.SimpleButton btnaprobar;
        private DevExpress.XtraEditors.LabelControl lbltitulo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colaprobaciones;
    }
}