namespace ViewGuate502.Clientes
{
    partial class FormListaDeClientes
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaDeClientes));
            this.gridControlClientes = new DevExpress.XtraGrid.GridControl();
            this.gridViewClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyBtnEditar = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyBtnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlClientes
            // 
            gridLevelNode2.RelationName = "Level1";
            this.gridControlClientes.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControlClientes.Location = new System.Drawing.Point(12, 12);
            this.gridControlClientes.MainView = this.gridViewClientes;
            this.gridControlClientes.Name = "gridControlClientes";
            this.gridControlClientes.Size = new System.Drawing.Size(1076, 480);
            this.gridControlClientes.TabIndex = 0;
            this.gridControlClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClientes});
            // 
            // gridViewClientes
            // 
            this.gridViewClientes.GridControl = this.gridControlClientes;
            this.gridViewClientes.Name = "gridViewClientes";
            this.gridViewClientes.OptionsBehavior.ReadOnly = true;
            this.gridViewClientes.OptionsFind.AlwaysVisible = true;
            this.gridViewClientes.OptionsView.ColumnAutoWidth = false;
            this.gridViewClientes.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSalir);
            this.layoutControl1.Controls.Add(this.btnEditar);
            this.layoutControl1.Controls.Add(this.gridControlClientes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1100, 544);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSalir
            // 
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(808, 496);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 36);
            this.btnSalir.StyleController = this.layoutControl1;
            this.btnSalir.TabIndex = 54;
            this.btnSalir.Text = "[ESC] SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(949, 496);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 36);
            this.btnEditar.StyleController = this.layoutControl1;
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "[ENTER] EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.lyBtnEditar,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1100, 544);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlClientes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1080, 484);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSalir;
            this.layoutControlItem3.Location = new System.Drawing.Point(796, 484);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(141, 40);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(141, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(141, 40);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // lyBtnEditar
            // 
            this.lyBtnEditar.Control = this.btnEditar;
            this.lyBtnEditar.Location = new System.Drawing.Point(937, 484);
            this.lyBtnEditar.MaxSize = new System.Drawing.Size(143, 40);
            this.lyBtnEditar.MinSize = new System.Drawing.Size(143, 40);
            this.lyBtnEditar.Name = "lyBtnEditar";
            this.lyBtnEditar.Size = new System.Drawing.Size(143, 40);
            this.lyBtnEditar.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lyBtnEditar.TextSize = new System.Drawing.Size(0, 0);
            this.lyBtnEditar.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 484);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(796, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormListaDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 544);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "FormListaDeClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.FormListaDeClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormListaDeClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyBtnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClientes;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        public DevExpress.XtraLayout.LayoutControlItem lyBtnEditar;
        public DevExpress.XtraEditors.SimpleButton btnEditar;
    }
}