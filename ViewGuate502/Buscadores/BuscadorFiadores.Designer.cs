namespace ViewGuate502.Buscadores
{
    partial class BuscadorFiadores
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcagregarfiadores = new DevExpress.XtraEditors.GroupControl();
            this.btnguardar = new DevExpress.XtraEditors.SimpleButton();
            this.gcfiadores = new DevExpress.XtraGrid.GridControl();
            this.gvfiadores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblresultadosbusqueda = new System.Windows.Forms.Label();
            this.gcresultadosbusqueda = new DevExpress.XtraGrid.GridControl();
            this.gvresultadosbusqueda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbcuifiador = new DevExpress.XtraEditors.TextEdit();
            this.lblcuifiador = new System.Windows.Forms.Label();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcagregarfiadores)).BeginInit();
            this.gcagregarfiadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcfiadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvfiadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcresultadosbusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvresultadosbusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcuifiador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcagregarfiadores);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(642, 530);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcagregarfiadores
            // 
            this.gcagregarfiadores.Controls.Add(this.btnguardar);
            this.gcagregarfiadores.Controls.Add(this.gcfiadores);
            this.gcagregarfiadores.Controls.Add(this.lblresultadosbusqueda);
            this.gcagregarfiadores.Controls.Add(this.gcresultadosbusqueda);
            this.gcagregarfiadores.Controls.Add(this.tbcuifiador);
            this.gcagregarfiadores.Controls.Add(this.lblcuifiador);
            this.gcagregarfiadores.Controls.Add(this.btnbuscar);
            this.gcagregarfiadores.Location = new System.Drawing.Point(12, 12);
            this.gcagregarfiadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcagregarfiadores.Name = "gcagregarfiadores";
            this.gcagregarfiadores.Size = new System.Drawing.Size(618, 506);
            this.gcagregarfiadores.TabIndex = 0;
            this.gcagregarfiadores.Text = "Agregar fiador";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(524, 463);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(81, 24);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // gcfiadores
            // 
            this.gcfiadores.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcfiadores.Location = new System.Drawing.Point(16, 284);
            this.gcfiadores.MainView = this.gvfiadores;
            this.gcfiadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcfiadores.Name = "gcfiadores";
            this.gcfiadores.Size = new System.Drawing.Size(588, 162);
            this.gcfiadores.TabIndex = 3;
            this.gcfiadores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvfiadores});
            // 
            // gvfiadores
            // 
            this.gvfiadores.DetailHeight = 284;
            this.gvfiadores.GridControl = this.gcfiadores;
            this.gvfiadores.Name = "gvfiadores";
            this.gvfiadores.OptionsBehavior.Editable = false;
            this.gvfiadores.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvfiadores.OptionsView.ShowGroupPanel = false;
            // 
            // lblresultadosbusqueda
            // 
            this.lblresultadosbusqueda.AutoSize = true;
            this.lblresultadosbusqueda.Location = new System.Drawing.Point(14, 78);
            this.lblresultadosbusqueda.Name = "lblresultadosbusqueda";
            this.lblresultadosbusqueda.Size = new System.Drawing.Size(136, 13);
            this.lblresultadosbusqueda.TabIndex = 4;
            this.lblresultadosbusqueda.Text = "Resultados de la búsqueda";
            // 
            // gcresultadosbusqueda
            // 
            this.gcresultadosbusqueda.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcresultadosbusqueda.Location = new System.Drawing.Point(16, 103);
            this.gcresultadosbusqueda.MainView = this.gvresultadosbusqueda;
            this.gcresultadosbusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcresultadosbusqueda.Name = "gcresultadosbusqueda";
            this.gcresultadosbusqueda.Size = new System.Drawing.Size(588, 162);
            this.gcresultadosbusqueda.TabIndex = 2;
            this.gcresultadosbusqueda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvresultadosbusqueda});
            this.gcresultadosbusqueda.Click += new System.EventHandler(this.gcresultadosbusqueda_Click);
            // 
            // gvresultadosbusqueda
            // 
            this.gvresultadosbusqueda.DetailHeight = 284;
            this.gvresultadosbusqueda.GridControl = this.gcresultadosbusqueda;
            this.gvresultadosbusqueda.Name = "gvresultadosbusqueda";
            this.gvresultadosbusqueda.OptionsView.ShowGroupPanel = false;
            this.gvresultadosbusqueda.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvresultadosbusqueda_CellValueChanged);
            // 
            // tbcuifiador
            // 
            this.tbcuifiador.Location = new System.Drawing.Point(16, 50);
            this.tbcuifiador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcuifiador.Name = "tbcuifiador";
            this.tbcuifiador.Size = new System.Drawing.Size(208, 20);
            this.tbcuifiador.TabIndex = 0;
            this.tbcuifiador.EditValueChanged += new System.EventHandler(this.tbcuifiador_EditValueChanged);
            // 
            // lblcuifiador
            // 
            this.lblcuifiador.AutoSize = true;
            this.lblcuifiador.Location = new System.Drawing.Point(14, 34);
            this.lblcuifiador.Name = "lblcuifiador";
            this.lblcuifiador.Size = new System.Drawing.Size(25, 13);
            this.lblcuifiador.TabIndex = 1;
            this.lblcuifiador.Text = "CUI";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(230, 45);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(642, 530);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcagregarfiadores;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(622, 510);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // BuscadorFiadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 530);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuscadorFiadores";
            this.Text = "BuscadorFiadores";
            this.Load += new System.EventHandler(this.BuscadorFiadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcagregarfiadores)).EndInit();
            this.gcagregarfiadores.ResumeLayout(false);
            this.gcagregarfiadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcfiadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvfiadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcresultadosbusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvresultadosbusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcuifiador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl gcagregarfiadores;
        private DevExpress.XtraEditors.TextEdit tbcuifiador;
        private System.Windows.Forms.Label lblcuifiador;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Label lblresultadosbusqueda;
        private DevExpress.XtraEditors.SimpleButton btnguardar;
        private DevExpress.XtraGrid.GridControl gcfiadores;
        private DevExpress.XtraGrid.Views.Grid.GridView gvfiadores;
        public DevExpress.XtraGrid.GridControl gcresultadosbusqueda;
        public DevExpress.XtraGrid.Views.Grid.GridView gvresultadosbusqueda;
    }
}