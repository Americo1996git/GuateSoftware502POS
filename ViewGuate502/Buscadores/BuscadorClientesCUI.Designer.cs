namespace ViewGuate502.Buscadores
{
    partial class BuscadorClientesCUI
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
            this.gcbuscadorclientescui = new DevExpress.XtraEditors.GroupControl();
            this.gcresultadoclientes = new DevExpress.XtraGrid.GridControl();
            this.gvresultadoclientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbcuicliente = new DevExpress.XtraEditors.TextEdit();
            this.lblcuicliente = new System.Windows.Forms.Label();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcbuscadorclientescui)).BeginInit();
            this.gcbuscadorclientescui.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcresultadoclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvresultadoclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcuicliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcbuscadorclientescui);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(855, 468);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcbuscadorclientescui
            // 
            this.gcbuscadorclientescui.Controls.Add(this.gcresultadoclientes);
            this.gcbuscadorclientescui.Controls.Add(this.tbcuicliente);
            this.gcbuscadorclientescui.Controls.Add(this.lblcuicliente);
            this.gcbuscadorclientescui.Controls.Add(this.btnbuscar);
            this.gcbuscadorclientescui.Location = new System.Drawing.Point(11, 10);
            this.gcbuscadorclientescui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcbuscadorclientescui.Name = "gcbuscadorclientescui";
            this.gcbuscadorclientescui.Size = new System.Drawing.Size(833, 448);
            this.gcbuscadorclientescui.TabIndex = 0;
            this.gcbuscadorclientescui.Text = "Buscador Clientes";
            // 
            // gcresultadoclientes
            // 
            this.gcresultadoclientes.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcresultadoclientes.Location = new System.Drawing.Point(25, 85);
            this.gcresultadoclientes.MainView = this.gvresultadoclientes;
            this.gcresultadoclientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcresultadoclientes.Name = "gcresultadoclientes";
            this.gcresultadoclientes.Size = new System.Drawing.Size(789, 353);
            this.gcresultadoclientes.TabIndex = 2;
            this.gcresultadoclientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvresultadoclientes});
            // 
            // gvresultadoclientes
            // 
            this.gvresultadoclientes.DetailHeight = 284;
            this.gvresultadoclientes.GridControl = this.gcresultadoclientes;
            this.gvresultadoclientes.Name = "gvresultadoclientes";
            this.gvresultadoclientes.OptionsView.ShowGroupPanel = false;
            this.gvresultadoclientes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvresultadoclientes_RowClick);
            this.gvresultadoclientes.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvresultadoclientes_CellValueChanged);
            // 
            // tbcuicliente
            // 
            this.tbcuicliente.Location = new System.Drawing.Point(25, 63);
            this.tbcuicliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcuicliente.Name = "tbcuicliente";
            this.tbcuicliente.Size = new System.Drawing.Size(185, 20);
            this.tbcuicliente.TabIndex = 0;
            // 
            // lblcuicliente
            // 
            this.lblcuicliente.AutoSize = true;
            this.lblcuicliente.Location = new System.Drawing.Point(22, 46);
            this.lblcuicliente.Name = "lblcuicliente";
            this.lblcuicliente.Size = new System.Drawing.Size(25, 13);
            this.lblcuicliente.TabIndex = 1;
            this.lblcuicliente.Text = "CUI";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(215, 57);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(81, 24);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(855, 468);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcbuscadorclientescui;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(837, 452);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // BuscadorClientesCUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 468);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuscadorClientesCUI";
            this.Text = "BuscadorClientesCUI";
            this.Load += new System.EventHandler(this.BuscadorClientesCUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcbuscadorclientescui)).EndInit();
            this.gcbuscadorclientescui.ResumeLayout(false);
            this.gcbuscadorclientescui.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcresultadoclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvresultadoclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcuicliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl gcbuscadorclientescui;
        private DevExpress.XtraGrid.GridControl gcresultadoclientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvresultadoclientes;
        private DevExpress.XtraEditors.TextEdit tbcuicliente;
        private System.Windows.Forms.Label lblcuicliente;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}