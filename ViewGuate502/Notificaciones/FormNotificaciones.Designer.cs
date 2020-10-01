namespace ViewGuate502.Notificaciones
{
    partial class FormNotificaciones
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControlNotificaciones = new DevExpress.XtraGrid.GridControl();
            this.gridViewNotificaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNotificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNotificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSalir);
            this.layoutControl1.Controls.Add(this.gridControlNotificaciones);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(769, 553);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(769, 553);
            this.Root.TextVisible = false;
            // 
            // gridControlNotificaciones
            // 
            this.gridControlNotificaciones.Location = new System.Drawing.Point(12, 12);
            this.gridControlNotificaciones.MainView = this.gridViewNotificaciones;
            this.gridControlNotificaciones.Name = "gridControlNotificaciones";
            this.gridControlNotificaciones.Size = new System.Drawing.Size(745, 503);
            this.gridControlNotificaciones.TabIndex = 4;
            this.gridControlNotificaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNotificaciones});
            // 
            // gridViewNotificaciones
            // 
            this.gridViewNotificaciones.GridControl = this.gridControlNotificaciones;
            this.gridViewNotificaciones.Name = "gridViewNotificaciones";
            this.gridViewNotificaciones.OptionsBehavior.ReadOnly = true;
            this.gridViewNotificaciones.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlNotificaciones;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(749, 507);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(645, 519);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 22);
            this.btnSalir.StyleController = this.layoutControl1;
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "[ESC] SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSalir;
            this.layoutControlItem2.Location = new System.Drawing.Point(633, 507);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(116, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(116, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(116, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 507);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(633, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 553);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "FormNotificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOCUMENTOS PENDIENTES";
            this.Load += new System.EventHandler(this.FormNotificaciones_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormNotificaciones_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNotificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNotificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControlNotificaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNotificaciones;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}