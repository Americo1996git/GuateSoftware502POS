namespace ViewGuate502.Productos
{
    partial class FormModalReporteProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModalReporteProductos));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditLinea = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditSubLinea = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemLinea = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSubLinea = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLinea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSubLinea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSubLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(494, 60);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Controls.Add(this.btnImprimir);
            this.layoutControl1.Controls.Add(this.btnSalir);
            this.layoutControl1.Controls.Add(this.lookUpEditLinea);
            this.layoutControl1.Controls.Add(this.lookUpEditSubLinea);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 60);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(494, 388);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(36, 165);
            this.radioGroup1.MenuManager = this.ribbonControl1;
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Todas las lines"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Linea"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Sub linea")});
            this.radioGroup1.Size = new System.Drawing.Size(422, 34);
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.TabIndex = 19;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.ImageOptions.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(249, 340);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(233, 36);
            this.btnImprimir.StyleController = this.layoutControl1;
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(12, 340);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(233, 36);
            this.btnSalir.StyleController = this.layoutControl1;
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "[ESC] SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lookUpEditLinea
            // 
            this.lookUpEditLinea.Location = new System.Drawing.Point(96, 203);
            this.lookUpEditLinea.Name = "lookUpEditLinea";
            this.lookUpEditLinea.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpEditLinea.Properties.Appearance.BorderColor = System.Drawing.Color.SlateGray;
            this.lookUpEditLinea.Properties.Appearance.Options.UseBorderColor = true;
            this.lookUpEditLinea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditLinea.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")});
            this.lookUpEditLinea.Properties.NullText = "";
            this.lookUpEditLinea.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditLinea.Size = new System.Drawing.Size(362, 20);
            this.lookUpEditLinea.StyleController = this.layoutControl1;
            this.lookUpEditLinea.TabIndex = 15;
            this.lookUpEditLinea.EditValueChanged += new System.EventHandler(this.lookUpEditLinea_EditValueChanged);
            // 
            // lookUpEditSubLinea
            // 
            this.lookUpEditSubLinea.Location = new System.Drawing.Point(96, 227);
            this.lookUpEditSubLinea.Name = "lookUpEditSubLinea";
            this.lookUpEditSubLinea.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.lookUpEditSubLinea.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.lookUpEditSubLinea.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.lookUpEditSubLinea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSubLinea.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "Sub linea"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("abreviatura", "Abreviatur")});
            this.lookUpEditSubLinea.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditSubLinea.Properties.UseReadOnlyAppearance = false;
            this.lookUpEditSubLinea.Properties.PopupFilter += new DevExpress.XtraEditors.Controls.PopupFilterEventHandler(this.lookUpEditSubLinea_Properties_PopupFilter);
            this.lookUpEditSubLinea.Size = new System.Drawing.Size(362, 20);
            this.lookUpEditSubLinea.StyleController = this.layoutControl1;
            this.lookUpEditSubLinea.TabIndex = 16;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(494, 388);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSalir;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 328);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(237, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnImprimir;
            this.layoutControlItem4.Location = new System.Drawing.Point(237, 328);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(237, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.emptySpaceItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(474, 328);
            this.layoutControlGroup2.Text = "REPORTE DE PRODUCTOS";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItemLinea,
            this.layoutControlItemSubLinea});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 63);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(450, 151);
            this.layoutControlGroup3.Text = "DATOS DE IMPRESIÓN";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.radioGroup1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(426, 54);
            this.layoutControlItem5.Text = "Imprimir por";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItemLinea
            // 
            this.layoutControlItemLinea.Control = this.lookUpEditLinea;
            this.layoutControlItemLinea.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItemLinea.Name = "layoutControlItemLinea";
            this.layoutControlItemLinea.Size = new System.Drawing.Size(426, 24);
            this.layoutControlItemLinea.Text = "Linea";
            this.layoutControlItemLinea.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItemSubLinea
            // 
            this.layoutControlItemSubLinea.Control = this.lookUpEditSubLinea;
            this.layoutControlItemSubLinea.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItemSubLinea.Name = "layoutControlItemSubLinea";
            this.layoutControlItemSubLinea.Size = new System.Drawing.Size(426, 24);
            this.layoutControlItemSubLinea.Text = "Sub linea";
            this.layoutControlItemSubLinea.TextSize = new System.Drawing.Size(57, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(450, 63);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 214);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(450, 65);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormModalReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 448);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.KeyPreview = true;
            this.Name = "FormModalReporteProductos";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPRIMIR";
            this.Load += new System.EventHandler(this.FormModalReporteProductos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormModalReporteProductos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLinea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSubLinea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSubLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditLinea;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditSubLinea;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLinea;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSubLinea;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    }
}