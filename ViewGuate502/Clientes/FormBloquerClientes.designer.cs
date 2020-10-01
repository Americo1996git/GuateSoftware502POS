namespace ViewGuate502.Clientes
{
    partial class FormBloquerClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBloquerClientes));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.btnBloquear = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtObservaciones = new DevExpress.XtraEditors.TextEdit();
            this.txtDpi = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDpi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
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
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(605, 54);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnBuscar);
            this.layoutControl1.Controls.Add(this.txtCliente);
            this.layoutControl1.Controls.Add(this.btnBloquear);
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Controls.Add(this.txtObservaciones);
            this.layoutControl1.Controls.Add(this.txtDpi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 54);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(605, 406);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(290, 159);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 22);
            this.btnBuscar.StyleController = this.layoutControl1;
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(110, 185);
            this.txtCliente.MenuManager = this.ribbonControl1;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(459, 20);
            this.txtCliente.StyleController = this.layoutControl1;
            this.txtCliente.TabIndex = 8;
            // 
            // btnBloquear
            // 
            this.btnBloquear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBloquear.ImageOptions.Image")));
            this.btnBloquear.Location = new System.Drawing.Point(304, 346);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(136, 36);
            this.btnBloquear.StyleController = this.layoutControl1;
            this.btnBloquear.TabIndex = 7;
            this.btnBloquear.Text = "Bloquear";
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(164, 346);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 36);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(110, 209);
            this.txtObservaciones.MenuManager = this.ribbonControl1;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(459, 20);
            this.txtObservaciones.StyleController = this.layoutControl1;
            this.txtObservaciones.TabIndex = 5;
            // 
            // txtDpi
            // 
            this.txtDpi.Location = new System.Drawing.Point(110, 159);
            this.txtDpi.MenuManager = this.ribbonControl1;
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(176, 20);
            this.txtDpi.StyleController = this.layoutControl1;
            this.txtDpi.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(605, 406);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlGroup3,
            this.emptySpaceItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(585, 386);
            this.layoutControlGroup2.Text = "Bloqueos por cliente";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 202);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(561, 101);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnCancelar;
            this.layoutControlItem3.Location = new System.Drawing.Point(140, 303);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(140, 40);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(140, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(140, 40);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnBloquear;
            this.layoutControlItem4.Location = new System.Drawing.Point(280, 303);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(140, 40);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(140, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(140, 40);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 303);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(140, 40);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(420, 303);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(141, 40);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 85);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(561, 117);
            this.layoutControlGroup3.Text = "Datos";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtDpi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(254, 26);
            this.layoutControlItem1.Text = "DPI Cliente";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtObservaciones;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(537, 24);
            this.layoutControlItem2.Text = "Observaciones";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtCliente;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(537, 24);
            this.layoutControlItem5.Text = "Cliente";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnBuscar;
            this.layoutControlItem6.Location = new System.Drawing.Point(254, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(354, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(183, 26);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(561, 85);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormBloquerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 460);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormBloquerClientes";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Bloqueos por cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDpi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.SimpleButton btnBloquear;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.TextEdit txtObservaciones;
        private DevExpress.XtraEditors.TextEdit txtDpi;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    }
}