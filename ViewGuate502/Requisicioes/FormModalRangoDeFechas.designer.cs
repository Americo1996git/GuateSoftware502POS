namespace ViewGuate502.Requisicioes
{
    partial class FormModalRangoDeFechas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModalRangoDeFechas));
            this.dateEditFechaIncial = new DevExpress.XtraEditors.DateEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnImprimrTodos = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditFechaFinal = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupTitulo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemFechaInicial = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemFechaFinal = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.spinEditCodigo = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItemCodigo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaIncial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaIncial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFechaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFechaFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEditFechaIncial
            // 
            this.dateEditFechaIncial.EditValue = null;
            this.dateEditFechaIncial.Location = new System.Drawing.Point(143, 105);
            this.dateEditFechaIncial.Name = "dateEditFechaIncial";
            this.dateEditFechaIncial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFechaIncial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFechaIncial.Size = new System.Drawing.Size(146, 20);
            this.dateEditFechaIncial.StyleController = this.layoutControl1;
            this.dateEditFechaIncial.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spinEditCodigo);
            this.layoutControl1.Controls.Add(this.btnImprimrTodos);
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Controls.Add(this.dateEditFechaFinal);
            this.layoutControl1.Controls.Add(this.dateEditFechaIncial);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 60);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(380, 239);
            this.layoutControl1.TabIndex = 39;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnImprimrTodos
            // 
            this.btnImprimrTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprimrTodos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimrTodos.ImageOptions.Image")));
            this.btnImprimrTodos.Location = new System.Drawing.Point(193, 179);
            this.btnImprimrTodos.Name = "btnImprimrTodos";
            this.btnImprimrTodos.Size = new System.Drawing.Size(163, 36);
            this.btnImprimrTodos.StyleController = this.layoutControl1;
            this.btnImprimrTodos.TabIndex = 10;
            this.btnImprimrTodos.Text = "Imprimir";
            this.btnImprimrTodos.Click += new System.EventHandler(this.btnImprimrTodos_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(24, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 36);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "[Esc] Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dateEditFechaFinal
            // 
            this.dateEditFechaFinal.EditValue = null;
            this.dateEditFechaFinal.Location = new System.Drawing.Point(143, 129);
            this.dateEditFechaFinal.Name = "dateEditFechaFinal";
            this.dateEditFechaFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFechaFinal.Size = new System.Drawing.Size(146, 20);
            this.dateEditFechaFinal.StyleController = this.layoutControl1;
            this.dateEditFechaFinal.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupTitulo});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(380, 239);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroupTitulo
            // 
            this.layoutControlGroupTitulo.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.layoutControlGroupTitulo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemFechaInicial,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.layoutControlItemFechaFinal,
            this.layoutControlItemCodigo});
            this.layoutControlGroupTitulo.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupTitulo.Name = "layoutControlGroupTitulo";
            this.layoutControlGroupTitulo.Size = new System.Drawing.Size(360, 219);
            this.layoutControlGroupTitulo.Text = "Imprimir requisiciones ";
            // 
            // layoutControlItemFechaInicial
            // 
            this.layoutControlItemFechaInicial.Control = this.dateEditFechaIncial;
            this.layoutControlItemFechaInicial.Location = new System.Drawing.Point(59, 56);
            this.layoutControlItemFechaInicial.Name = "layoutControlItemFechaInicial";
            this.layoutControlItemFechaInicial.Size = new System.Drawing.Size(210, 24);
            this.layoutControlItemFechaInicial.Text = "Fecha inicial";
            this.layoutControlItemFechaInicial.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnCancelar;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(169, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnImprimrTodos;
            this.layoutControlItem4.Location = new System.Drawing.Point(169, 130);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(167, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(59, 104);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(210, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(59, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(210, 32);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(59, 130);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(269, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(67, 130);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemFechaFinal
            // 
            this.layoutControlItemFechaFinal.Control = this.dateEditFechaFinal;
            this.layoutControlItemFechaFinal.Location = new System.Drawing.Point(59, 80);
            this.layoutControlItemFechaFinal.Name = "layoutControlItemFechaFinal";
            this.layoutControlItemFechaFinal.Size = new System.Drawing.Size(210, 24);
            this.layoutControlItemFechaFinal.Text = "Fecha final";
            this.layoutControlItemFechaFinal.TextSize = new System.Drawing.Size(57, 13);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonControl1.ApplicationButtonImageOptions.Image")));
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsStubGlyphs.Padding = new System.Windows.Forms.Padding(0);
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(380, 60);
            // 
            // spinEditCodigo
            // 
            this.spinEditCodigo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCodigo.Location = new System.Drawing.Point(143, 81);
            this.spinEditCodigo.MenuManager = this.ribbonControl1;
            this.spinEditCodigo.Name = "spinEditCodigo";
            this.spinEditCodigo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCodigo.Size = new System.Drawing.Size(146, 20);
            this.spinEditCodigo.StyleController = this.layoutControl1;
            this.spinEditCodigo.TabIndex = 39;
            // 
            // layoutControlItemCodigo
            // 
            this.layoutControlItemCodigo.Control = this.spinEditCodigo;
            this.layoutControlItemCodigo.Location = new System.Drawing.Point(59, 32);
            this.layoutControlItemCodigo.Name = "layoutControlItemCodigo";
            this.layoutControlItemCodigo.Size = new System.Drawing.Size(210, 24);
            this.layoutControlItemCodigo.Text = "Codigo";
            this.layoutControlItemCodigo.TextSize = new System.Drawing.Size(57, 13);
            // 
            // FormModalRangoDeFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 299);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(380, 299);
            this.MinimumSize = new System.Drawing.Size(354, 255);
            this.Name = "FormModalRangoDeFechas";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir ";
            this.Load += new System.EventHandler(this.FormModalRangoDeFechas_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormModalRangoDeFechas_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaIncial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaIncial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFechaFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFechaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemFechaFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEditFechaIncial;
        private DevExpress.XtraEditors.DateEdit dateEditFechaFinal;
        private DevExpress.XtraEditors.SimpleButton btnImprimrTodos;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemFechaFinal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemFechaInicial;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupTitulo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.SpinEdit spinEditCodigo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCodigo;
    }
}