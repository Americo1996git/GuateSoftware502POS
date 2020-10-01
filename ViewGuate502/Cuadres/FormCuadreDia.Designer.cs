namespace ViewGuate502.Cuadres
{
    partial class FormCuadreDia
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
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditMonto = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.spinEditDiferencia = new DevExpress.XtraEditors.SpinEdit();
            this.lyDiferencia = new DevExpress.XtraLayout.LayoutControlItem();
            this.spinEditTotalGastos = new DevExpress.XtraEditors.SpinEdit();
            this.lyTtoalGastos = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnReporteCuadre = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditDiferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyDiferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditTotalGastos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTtoalGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnReporteCuadre);
            this.layoutControl1.Controls.Add(this.spinEditTotalGastos);
            this.layoutControl1.Controls.Add(this.spinEditDiferencia);
            this.layoutControl1.Controls.Add(this.btnGenerar);
            this.layoutControl1.Controls.Add(this.btnSalir);
            this.layoutControl1.Controls.Add(this.spinEditMonto);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(584, 200);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(355, 166);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(106, 22);
            this.btnGenerar.StyleController = this.layoutControl1;
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(465, 166);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 22);
            this.btnSalir.StyleController = this.layoutControl1;
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "[ESC] SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // spinEditMonto
            // 
            this.spinEditMonto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditMonto.Location = new System.Drawing.Point(90, 106);
            this.spinEditMonto.Name = "spinEditMonto";
            this.spinEditMonto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditMonto.Size = new System.Drawing.Size(78, 20);
            this.spinEditMonto.StyleController = this.layoutControl1;
            this.spinEditMonto.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(303, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "TOTAL: EFECTIVO, CHEQUES, MONEDAS, COMPRAS DOLARES";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(90, 65);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.ReadOnly = true;
            this.dateEdit1.Size = new System.Drawing.Size(144, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem3,
            this.emptySpaceItem5,
            this.lyDiferencia,
            this.lyTtoalGastos,
            this.emptySpaceItem6,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(584, 200);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 118);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(564, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(564, 53);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(226, 24);
            this.layoutControlItem1.Text = "FECHA";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.labelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 77);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(564, 17);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spinEditMonto;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(160, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(160, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(160, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "MONTO";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSalir;
            this.layoutControlItem4.Location = new System.Drawing.Point(453, 154);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(111, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(111, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(111, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnGenerar;
            this.layoutControlItem5.Location = new System.Drawing.Point(343, 154);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(110, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(110, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(110, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(226, 53);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(338, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 154);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(234, 26);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // spinEditDiferencia
            // 
            this.spinEditDiferencia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditDiferencia.Location = new System.Drawing.Point(250, 106);
            this.spinEditDiferencia.Name = "spinEditDiferencia";
            this.spinEditDiferencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditDiferencia.Properties.ReadOnly = true;
            this.spinEditDiferencia.Size = new System.Drawing.Size(84, 20);
            this.spinEditDiferencia.StyleController = this.layoutControl1;
            this.spinEditDiferencia.TabIndex = 9;
            // 
            // lyDiferencia
            // 
            this.lyDiferencia.Control = this.spinEditDiferencia;
            this.lyDiferencia.Location = new System.Drawing.Point(160, 94);
            this.lyDiferencia.MaxSize = new System.Drawing.Size(166, 24);
            this.lyDiferencia.MinSize = new System.Drawing.Size(166, 24);
            this.lyDiferencia.Name = "lyDiferencia";
            this.lyDiferencia.Size = new System.Drawing.Size(166, 24);
            this.lyDiferencia.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lyDiferencia.Text = "DIFERENCIA";
            this.lyDiferencia.TextSize = new System.Drawing.Size(75, 13);
            // 
            // spinEditTotalGastos
            // 
            this.spinEditTotalGastos.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditTotalGastos.Location = new System.Drawing.Point(416, 106);
            this.spinEditTotalGastos.Name = "spinEditTotalGastos";
            this.spinEditTotalGastos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditTotalGastos.Properties.ReadOnly = true;
            this.spinEditTotalGastos.Size = new System.Drawing.Size(79, 20);
            this.spinEditTotalGastos.StyleController = this.layoutControl1;
            this.spinEditTotalGastos.TabIndex = 10;
            // 
            // lyTtoalGastos
            // 
            this.lyTtoalGastos.Control = this.spinEditTotalGastos;
            this.lyTtoalGastos.Location = new System.Drawing.Point(326, 94);
            this.lyTtoalGastos.MaxSize = new System.Drawing.Size(161, 24);
            this.lyTtoalGastos.MinSize = new System.Drawing.Size(161, 24);
            this.lyTtoalGastos.Name = "lyTtoalGastos";
            this.lyTtoalGastos.Size = new System.Drawing.Size(161, 24);
            this.lyTtoalGastos.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lyTtoalGastos.Text = "TOTAL GASTOS";
            this.lyTtoalGastos.TextSize = new System.Drawing.Size(75, 13);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(487, 94);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(77, 24);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnReporteCuadre
            // 
            this.btnReporteCuadre.Location = new System.Drawing.Point(246, 166);
            this.btnReporteCuadre.Name = "btnReporteCuadre";
            this.btnReporteCuadre.Size = new System.Drawing.Size(105, 22);
            this.btnReporteCuadre.StyleController = this.layoutControl1;
            this.btnReporteCuadre.TabIndex = 11;
            this.btnReporteCuadre.Text = "REPORTE CUADRE";
            this.btnReporteCuadre.Click += new System.EventHandler(this.btnReporteCuadre_Click);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnReporteCuadre;
            this.layoutControlItem6.Location = new System.Drawing.Point(234, 154);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(109, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(109, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(109, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // FormCuadreDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 200);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "FormCuadreDia";
            this.Text = "CORTE DE CAJA DEL DIA";
            this.Load += new System.EventHandler(this.FormCuadreDia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCuadreDia_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditDiferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyDiferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditTotalGastos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTtoalGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.SpinEdit spinEditMonto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraEditors.SpinEdit spinEditDiferencia;
        private DevExpress.XtraLayout.LayoutControlItem lyDiferencia;
        private DevExpress.XtraEditors.SpinEdit spinEditTotalGastos;
        private DevExpress.XtraLayout.LayoutControlItem lyTtoalGastos;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraEditors.SimpleButton btnReporteCuadre;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}