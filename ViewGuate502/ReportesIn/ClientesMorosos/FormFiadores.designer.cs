namespace ViewGuate502.ReportesIn.ClientesMorosos
{
    partial class FormFiadores
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
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnEstadoDeCuenta = new DevExpress.XtraEditors.SimpleButton();
            this.txtEnvio = new DevExpress.XtraEditors.TextEdit();
            this.gridControlFiadores = new DevExpress.XtraGrid.GridControl();
            this.gridViewFiadores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemNumeroEnvio = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemBtnEstadoDeCuenta = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNumeroEnvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemBtnEstadoDeCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSalir);
            this.layoutControl1.Controls.Add(this.btnEstadoDeCuenta);
            this.layoutControl1.Controls.Add(this.txtEnvio);
            this.layoutControl1.Controls.Add(this.gridControlFiadores);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(830, 417);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(548, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 22);
            this.btnSalir.StyleController = this.layoutControl1;
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "[Esc] Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEstadoDeCuenta
            // 
            this.btnEstadoDeCuenta.Location = new System.Drawing.Point(692, 383);
            this.btnEstadoDeCuenta.Name = "btnEstadoDeCuenta";
            this.btnEstadoDeCuenta.Size = new System.Drawing.Size(126, 22);
            this.btnEstadoDeCuenta.StyleController = this.layoutControl1;
            this.btnEstadoDeCuenta.TabIndex = 6;
            this.btnEstadoDeCuenta.Text = "Estado de cuenta";
            this.btnEstadoDeCuenta.Click += new System.EventHandler(this.btnEstadoDeCuenta_Click);
            // 
            // txtEnvio
            // 
            this.txtEnvio.Location = new System.Drawing.Point(53, 49);
            this.txtEnvio.Name = "txtEnvio";
            this.txtEnvio.Properties.ReadOnly = true;
            this.txtEnvio.Size = new System.Drawing.Size(753, 20);
            this.txtEnvio.StyleController = this.layoutControl1;
            this.txtEnvio.TabIndex = 5;
            // 
            // gridControlFiadores
            // 
            this.gridControlFiadores.Location = new System.Drawing.Point(24, 93);
            this.gridControlFiadores.MainView = this.gridViewFiadores;
            this.gridControlFiadores.Name = "gridControlFiadores";
            this.gridControlFiadores.Size = new System.Drawing.Size(782, 274);
            this.gridControlFiadores.TabIndex = 4;
            this.gridControlFiadores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFiadores});
            // 
            // gridViewFiadores
            // 
            this.gridViewFiadores.GridControl = this.gridControlFiadores;
            this.gridViewFiadores.Name = "gridViewFiadores";
            this.gridViewFiadores.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem4,
            this.layoutControlItemBtnEstadoDeCuenta,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(830, 417);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItemNumeroEnvio,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(810, 371);
            this.layoutControlGroup2.Text = "Fiadores ";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlFiadores;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(786, 278);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItemNumeroEnvio
            // 
            this.layoutControlItemNumeroEnvio.Control = this.txtEnvio;
            this.layoutControlItemNumeroEnvio.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemNumeroEnvio.Name = "layoutControlItemNumeroEnvio";
            this.layoutControlItemNumeroEnvio.Size = new System.Drawing.Size(786, 24);
            this.layoutControlItemNumeroEnvio.Text = "Envio";
            this.layoutControlItemNumeroEnvio.TextSize = new System.Drawing.Size(26, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(786, 20);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSalir;
            this.layoutControlItem4.Location = new System.Drawing.Point(536, 371);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(144, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItemBtnEstadoDeCuenta
            // 
            this.layoutControlItemBtnEstadoDeCuenta.Control = this.btnEstadoDeCuenta;
            this.layoutControlItemBtnEstadoDeCuenta.Location = new System.Drawing.Point(680, 371);
            this.layoutControlItemBtnEstadoDeCuenta.Name = "layoutControlItemBtnEstadoDeCuenta";
            this.layoutControlItemBtnEstadoDeCuenta.Size = new System.Drawing.Size(130, 26);
            this.layoutControlItemBtnEstadoDeCuenta.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemBtnEstadoDeCuenta.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 371);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(536, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormFiadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 417);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormFiadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiadores";
            this.Load += new System.EventHandler(this.FormFiadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEnvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNumeroEnvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemBtnEstadoDeCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtEnvio;
        private DevExpress.XtraGrid.GridControl gridControlFiadores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFiadores;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemNumeroEnvio;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.SimpleButton btnEstadoDeCuenta;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemBtnEstadoDeCuenta;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}