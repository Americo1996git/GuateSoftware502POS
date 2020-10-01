namespace ViewGuate502.MaestroProductos
{
    partial class FormMaestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaestro));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtBuscrProducto = new DevExpress.XtraEditors.TextEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.dateEditFechaFinal = new DevExpress.XtraEditors.DateEdit();
            this.dateEditFechaInicial = new DevExpress.XtraEditors.DateEdit();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditDocumento = new DevExpress.XtraEditors.LookUpEdit();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditProducto = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscrProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtBuscrProducto);
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Controls.Add(this.dateEditFechaFinal);
            this.layoutControl1.Controls.Add(this.dateEditFechaInicial);
            this.layoutControl1.Controls.Add(this.btnSalir);
            this.layoutControl1.Controls.Add(this.lookUpEditDocumento);
            this.layoutControl1.Controls.Add(this.btnImprimir);
            this.layoutControl1.Controls.Add(this.lookUpEditProducto);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 54);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(553, 364);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtBuscrProducto
            // 
            this.txtBuscrProducto.Location = new System.Drawing.Point(118, 142);
            this.txtBuscrProducto.Name = "txtBuscrProducto";
            this.txtBuscrProducto.Size = new System.Drawing.Size(411, 20);
            this.txtBuscrProducto.StyleController = this.layoutControl1;
            this.txtBuscrProducto.TabIndex = 51;
            this.txtBuscrProducto.EditValueChanged += new System.EventHandler(this.txtBuscrProducto_EditValueChanged);
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(24, 190);
            this.radioGroup1.MenuManager = this.ribbonControl1;
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Todos los documentos"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Por tipo de documento")});
            this.radioGroup1.Size = new System.Drawing.Size(505, 25);
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.TabIndex = 11;
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
            this.ribbonControl1.Size = new System.Drawing.Size(553, 54);
            // 
            // dateEditFechaFinal
            // 
            this.dateEditFechaFinal.EditValue = null;
            this.dateEditFechaFinal.Location = new System.Drawing.Point(118, 118);
            this.dateEditFechaFinal.Name = "dateEditFechaFinal";
            this.dateEditFechaFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFechaFinal.Size = new System.Drawing.Size(411, 20);
            this.dateEditFechaFinal.StyleController = this.layoutControl1;
            this.dateEditFechaFinal.TabIndex = 10;
            // 
            // dateEditFechaInicial
            // 
            this.dateEditFechaInicial.EditValue = null;
            this.dateEditFechaInicial.Location = new System.Drawing.Point(118, 94);
            this.dateEditFechaInicial.Name = "dateEditFechaInicial";
            this.dateEditFechaInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFechaInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFechaInicial.Size = new System.Drawing.Size(411, 20);
            this.dateEditFechaInicial.StyleController = this.layoutControl1;
            this.dateEditFechaInicial.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(12, 316);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(262, 36);
            this.btnSalir.StyleController = this.layoutControl1;
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "[Esc] Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lookUpEditDocumento
            // 
            this.lookUpEditDocumento.Location = new System.Drawing.Point(118, 219);
            this.lookUpEditDocumento.Name = "lookUpEditDocumento";
            this.lookUpEditDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDocumento.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Documento")});
            this.lookUpEditDocumento.Size = new System.Drawing.Size(411, 20);
            this.lookUpEditDocumento.StyleController = this.layoutControl1;
            this.lookUpEditDocumento.TabIndex = 7;
            // 
            // btnImprimir
            // 
            this.btnImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.ImageOptions.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(278, 316);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(263, 36);
            this.btnImprimir.StyleController = this.layoutControl1;
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lookUpEditProducto
            // 
            this.lookUpEditProducto.Location = new System.Drawing.Point(118, 166);
            this.lookUpEditProducto.Name = "lookUpEditProducto";
            this.lookUpEditProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditProducto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Producto"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("linea", "Linea")});
            this.lookUpEditProducto.Size = new System.Drawing.Size(411, 20);
            this.lookUpEditProducto.StyleController = this.layoutControl1;
            this.lookUpEditProducto.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem5,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(553, 364);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(533, 304);
            this.layoutControlGroup2.Text = "Imprimir maestro de productos";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnSalir;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 304);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(266, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnImprimir;
            this.layoutControlItem3.Location = new System.Drawing.Point(266, 304);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(267, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 200);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(509, 61);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(509, 51);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEditFechaInicial;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 51);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(509, 24);
            this.layoutControlItem2.Text = "Fecha inicial";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dateEditFechaFinal;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 75);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(509, 24);
            this.layoutControlItem6.Text = "Fecha final";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lookUpEditProducto;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 123);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(509, 24);
            this.layoutControlItem1.Text = "Producto";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.radioGroup1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 147);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(509, 29);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lookUpEditDocumento;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 176);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(509, 24);
            this.layoutControlItem4.Text = "Tipo de documento";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtBuscrProducto;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 99);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(509, 24);
            this.layoutControlItem8.Text = "Buscar";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(91, 13);
            // 
            // FormMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 418);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.KeyPreview = true;
            this.Name = "FormMaestro";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir maestro de productos";
            this.Load += new System.EventHandler(this.FormMaestro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMaestro_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscrProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDocumento;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditProducto;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.DateEdit dateEditFechaFinal;
        private DevExpress.XtraEditors.DateEdit dateEditFechaInicial;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.TextEdit txtBuscrProducto;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}