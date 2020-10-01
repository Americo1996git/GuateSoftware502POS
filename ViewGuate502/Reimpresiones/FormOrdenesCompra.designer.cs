namespace ViewGuate502.Reimpresiones
{
    partial class FormOrdenesCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenesCompra));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlBuscar = new DevExpress.XtraGrid.GridControl();
            this.gridViewBuscar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSalir);
            this.layoutControl1.Controls.Add(this.btnImprimir);
            this.layoutControl1.Controls.Add(this.gridControlBuscar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 60);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(638, 342);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSalir
            // 
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(199, 294);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 36);
            this.btnSalir.StyleController = this.layoutControl1;
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "[ESC] Cancelar";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.ImageOptions.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(323, 294);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 36);
            this.btnImprimir.StyleController = this.layoutControl1;
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // gridControlBuscar
            // 
            this.gridControlBuscar.Location = new System.Drawing.Point(24, 49);
            this.gridControlBuscar.MainView = this.gridViewBuscar;
            this.gridControlBuscar.Name = "gridControlBuscar";
            this.gridControlBuscar.Size = new System.Drawing.Size(590, 229);
            this.gridControlBuscar.TabIndex = 4;
            this.gridControlBuscar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBuscar});
            // 
            // gridViewBuscar
            // 
            this.gridViewBuscar.GridControl = this.gridControlBuscar;
            this.gridViewBuscar.Name = "gridViewBuscar";
            this.gridViewBuscar.OptionsBehavior.Editable = false;
            this.gridViewBuscar.OptionsFind.AlwaysVisible = true;
            this.gridViewBuscar.OptionsFind.FindDelay = 100;
            this.gridViewBuscar.OptionsFind.ShowFindButton = false;
            this.gridViewBuscar.OptionsView.ColumnAutoWidth = false;
            this.gridViewBuscar.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlGroup2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(638, 342);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnImprimir;
            this.layoutControlItem2.Location = new System.Drawing.Point(311, 282);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(124, 40);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(124, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(124, 40);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(618, 282);
            this.layoutControlGroup2.Text = "ORDENES DE COMPRA QUE NO HAN SIDO INGRESADOS";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlBuscar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(594, 233);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSalir;
            this.layoutControlItem3.Location = new System.Drawing.Point(187, 282);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(124, 40);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(124, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(124, 40);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 282);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(187, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(435, 282);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(183, 40);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonControl1.ApplicationButtonImageOptions.Image")));
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsStubGlyphs.Padding = new System.Windows.Forms.Padding(0);
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(638, 60);
            // 
            // FormOrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 402);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.KeyPreview = true;
            this.Name = "FormOrdenesCompra";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REIMPRIMIR ORDENES DE COMPRA SIN INGRESAR";
            this.Load += new System.EventHandler(this.FormOrdenesCompra_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormOrdenesCompra_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraGrid.GridControl gridControlBuscar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBuscar;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}