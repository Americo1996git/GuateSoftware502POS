namespace ViewGuate502.Ingresos
{
    partial class FormBuscarOrdenCompra
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
            this.gridControlBuscar = new DevExpress.XtraGrid.GridControl();
            this.gridViewBuscar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlBuscar
            // 
            this.gridControlBuscar.Location = new System.Drawing.Point(12, 12);
            this.gridControlBuscar.MainView = this.gridViewBuscar;
            this.gridControlBuscar.Name = "gridControlBuscar";
            this.gridControlBuscar.Size = new System.Drawing.Size(550, 378);
            this.gridControlBuscar.TabIndex = 0;
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
            this.gridViewBuscar.DoubleClick += new System.EventHandler(this.gridViewBuscar_DoubleClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlBuscar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(574, 402);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(574, 402);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlBuscar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(554, 382);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FormBuscarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 402);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormBuscarOrdenCompra";
            this.Text = "FormBuscarOrdenCompra";
            this.Load += new System.EventHandler(this.FormBuscarOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlBuscar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBuscar;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}