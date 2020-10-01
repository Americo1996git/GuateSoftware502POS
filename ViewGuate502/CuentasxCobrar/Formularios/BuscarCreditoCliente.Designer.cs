namespace ViewGuate502.CuentasxCobrar.Formularios
{
    partial class BuscarCreditoCliente
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gclistadoclientes = new DevExpress.XtraGrid.GridControl();
            this.cXCClientesconcreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSoftwareGTDataSet = new ViewGuate502.dbSoftwareGTDataSet();
            this.gvlistadoclientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldpi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cXCClientes_con_creditoTableAdapter = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.CXCClientes_con_creditoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadoclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cXCClientesconcreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadoclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1323, 745);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gclistadoclientes);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1299, 721);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Buscar crédito";
            // 
            // gclistadoclientes
            // 
            this.gclistadoclientes.DataSource = this.cXCClientesconcreditoBindingSource;
            this.gclistadoclientes.Location = new System.Drawing.Point(22, 60);
            this.gclistadoclientes.MainView = this.gvlistadoclientes;
            this.gclistadoclientes.Name = "gclistadoclientes";
            this.gclistadoclientes.Size = new System.Drawing.Size(1251, 385);
            this.gclistadoclientes.TabIndex = 0;
            this.gclistadoclientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlistadoclientes});
            // 
            // cXCClientesconcreditoBindingSource
            // 
            this.cXCClientesconcreditoBindingSource.DataMember = "CXCClientes_con_credito";
            this.cXCClientesconcreditoBindingSource.DataSource = this.dbSoftwareGTDataSet;
            // 
            // dbSoftwareGTDataSet
            // 
            this.dbSoftwareGTDataSet.DataSetName = "dbSoftwareGTDataSet";
            this.dbSoftwareGTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvlistadoclientes
            // 
            this.gvlistadoclientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_cliente,
            this.coldpi});
            this.gvlistadoclientes.GridControl = this.gclistadoclientes;
            this.gvlistadoclientes.Name = "gvlistadoclientes";
            this.gvlistadoclientes.OptionsBehavior.Editable = false;
            this.gvlistadoclientes.OptionsFind.AlwaysVisible = true;
            this.gvlistadoclientes.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvlistadoclientes.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre_cliente
            // 
            this.colnombre_cliente.Caption = "Cliente";
            this.colnombre_cliente.FieldName = "nombre_cliente";
            this.colnombre_cliente.Name = "colnombre_cliente";
            this.colnombre_cliente.Visible = true;
            this.colnombre_cliente.VisibleIndex = 1;
            // 
            // coldpi
            // 
            this.coldpi.Caption = "DPI";
            this.coldpi.FieldName = "dpi";
            this.coldpi.Name = "coldpi";
            this.coldpi.Visible = true;
            this.coldpi.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1323, 745);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1303, 725);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // cXCClientes_con_creditoTableAdapter
            // 
            this.cXCClientes_con_creditoTableAdapter.ClearBeforeFill = true;
            // 
            // BuscarCreditoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 745);
            this.Controls.Add(this.layoutControl1);
            this.Name = "BuscarCreditoCliente";
            this.Text = "Buscador de créditos por cliente";
            this.Load += new System.EventHandler(this.BuscarCreditoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclistadoclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cXCClientesconcreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadoclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gclistadoclientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlistadoclientes;
        private System.Windows.Forms.BindingSource cXCClientesconcreditoBindingSource;
        private dbSoftwareGTDataSet dbSoftwareGTDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn coldpi;
        private dbSoftwareGTDataSetTableAdapters.CXCClientes_con_creditoTableAdapter cXCClientes_con_creditoTableAdapter;
    }
}