namespace ViewGuate502.SalidasDinero.Gastos
{
    partial class FormNuevoGasto
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
            this.spinEditMonto = new DevExpress.XtraEditors.SpinEdit();
            this.btnGrabar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.txtObservaciones = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditGastos = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDestino = new DevExpress.XtraEditors.TextEdit();
            this.txtSerieFactura = new DevExpress.XtraEditors.TextEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.spinEditCorrelativo = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGastos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCorrelativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spinEditCorrelativo);
            this.layoutControl1.Controls.Add(this.spinEditMonto);
            this.layoutControl1.Controls.Add(this.btnGrabar);
            this.layoutControl1.Controls.Add(this.btnSalir);
            this.layoutControl1.Controls.Add(this.txtObservaciones);
            this.layoutControl1.Controls.Add(this.lookUpEditGastos);
            this.layoutControl1.Controls.Add(this.txtDestino);
            this.layoutControl1.Controls.Add(this.txtSerieFactura);
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(644, 361);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // spinEditMonto
            // 
            this.spinEditMonto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditMonto.Location = new System.Drawing.Point(533, 168);
            this.spinEditMonto.Name = "spinEditMonto";
            this.spinEditMonto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditMonto.Size = new System.Drawing.Size(87, 20);
            this.spinEditMonto.StyleController = this.layoutControl1;
            this.spinEditMonto.TabIndex = 12;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(385, 327);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(125, 22);
            this.btnGrabar.StyleController = this.layoutControl1;
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(514, 327);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 22);
            this.btnSalir.StyleController = this.layoutControl1;
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "[ESC] SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(111, 240);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(509, 20);
            this.txtObservaciones.StyleController = this.layoutControl1;
            this.txtObservaciones.TabIndex = 9;
            // 
            // lookUpEditGastos
            // 
            this.lookUpEditGastos.Location = new System.Drawing.Point(111, 216);
            this.lookUpEditGastos.Name = "lookUpEditGastos";
            this.lookUpEditGastos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditGastos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "NOMBRE")});
            this.lookUpEditGastos.Size = new System.Drawing.Size(509, 20);
            this.lookUpEditGastos.StyleController = this.layoutControl1;
            this.lookUpEditGastos.TabIndex = 8;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(111, 192);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(509, 20);
            this.txtDestino.StyleController = this.layoutControl1;
            this.txtDestino.TabIndex = 7;
            // 
            // txtSerieFactura
            // 
            this.txtSerieFactura.Location = new System.Drawing.Point(111, 168);
            this.txtSerieFactura.Name = "txtSerieFactura";
            this.txtSerieFactura.Size = new System.Drawing.Size(162, 20);
            this.txtSerieFactura.StyleController = this.layoutControl1;
            this.txtSerieFactura.TabIndex = 5;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(24, 126);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "TIENDA"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "OTROS")});
            this.radioGroup1.Size = new System.Drawing.Size(596, 38);
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(644, 361);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem3,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(624, 315);
            this.layoutControlGroup1.Text = "CAPTURAR SALIDA POR MEDIO DE GASTOS";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.radioGroup1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(600, 58);
            this.layoutControlItem1.Text = "TIPO";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSerieFactura;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(253, 24);
            this.layoutControlItem2.Text = "SERIE FACTURA";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 215);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(600, 51);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtDestino;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 143);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(600, 24);
            this.layoutControlItem4.Text = "PROVEEDOR";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lookUpEditGastos;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 167);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(600, 24);
            this.layoutControlItem5.Text = "GASTO";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtObservaciones;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 191);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(600, 24);
            this.layoutControlItem6.Text = "OBSERVACIONES";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(84, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(600, 61);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.spinEditMonto;
            this.layoutControlItem9.Location = new System.Drawing.Point(467, 119);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(133, 24);
            this.layoutControlItem9.Text = "MONTO";
            this.layoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(37, 13);
            this.layoutControlItem9.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnSalir;
            this.layoutControlItem7.Location = new System.Drawing.Point(502, 315);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(122, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnGrabar;
            this.layoutControlItem8.Location = new System.Drawing.Point(373, 315);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(129, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 315);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(373, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // spinEditCorrelativo
            // 
            this.spinEditCorrelativo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCorrelativo.Location = new System.Drawing.Point(364, 168);
            this.spinEditCorrelativo.Name = "spinEditCorrelativo";
            this.spinEditCorrelativo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCorrelativo.Size = new System.Drawing.Size(123, 20);
            this.spinEditCorrelativo.StyleController = this.layoutControl1;
            this.spinEditCorrelativo.TabIndex = 13;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.spinEditCorrelativo;
            this.layoutControlItem10.Location = new System.Drawing.Point(253, 119);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(214, 24);
            this.layoutControlItem10.Text = "CORRELATIVO";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(84, 13);
            // 
            // FormNuevoGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 361);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "FormNuevoGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPTURA DE GASTOS";
            this.Load += new System.EventHandler(this.FormNuevoGasto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormNuevoGasto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGastos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCorrelativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnGrabar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        public DevExpress.XtraEditors.TextEdit txtObservaciones;
        public DevExpress.XtraEditors.LookUpEdit lookUpEditGastos;
        public DevExpress.XtraEditors.TextEdit txtDestino;
        public DevExpress.XtraEditors.TextEdit txtSerieFactura;
        public DevExpress.XtraEditors.SpinEdit spinEditMonto;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        public DevExpress.XtraEditors.SpinEdit spinEditCorrelativo;
    }
}