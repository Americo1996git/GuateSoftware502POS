namespace ViewGuate502.ReportesIn.CobrosPagos.IngresosDiarios
{
    partial class FormModalAbrirReporte
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
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditFinal = new DevExpress.XtraEditors.DateEdit();
            this.dateEditInicial = new DevExpress.XtraEditors.DateEdit();
            this.lookUpEditReceptores = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditTiposPagos = new DevExpress.XtraEditors.LookUpEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyRadioGroup = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lyTipoPago = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyReceptor = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditReceptores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTiposPagos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyRadioGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTipoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyReceptor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.checkEdit1);
            this.layoutControl1.Controls.Add(this.btnSalir);
            this.layoutControl1.Controls.Add(this.btnImprimir);
            this.layoutControl1.Controls.Add(this.dateEditFinal);
            this.layoutControl1.Controls.Add(this.dateEditInicial);
            this.layoutControl1.Controls.Add(this.lookUpEditReceptores);
            this.layoutControl1.Controls.Add(this.lookUpEditTiposPagos);
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(448, 333);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(206, 287);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 22);
            this.btnSalir.StyleController = this.layoutControl1;
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "[ESC] SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(313, 287);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(111, 22);
            this.btnImprimir.StyleController = this.layoutControl1;
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dateEditFinal
            // 
            this.dateEditFinal.EditValue = null;
            this.dateEditFinal.Location = new System.Drawing.Point(101, 222);
            this.dateEditFinal.Name = "dateEditFinal";
            this.dateEditFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFinal.Size = new System.Drawing.Size(323, 20);
            this.dateEditFinal.StyleController = this.layoutControl1;
            this.dateEditFinal.TabIndex = 8;
            // 
            // dateEditInicial
            // 
            this.dateEditInicial.EditValue = null;
            this.dateEditInicial.Location = new System.Drawing.Point(101, 198);
            this.dateEditInicial.Name = "dateEditInicial";
            this.dateEditInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInicial.Size = new System.Drawing.Size(323, 20);
            this.dateEditInicial.StyleController = this.layoutControl1;
            this.dateEditInicial.TabIndex = 7;
            // 
            // lookUpEditReceptores
            // 
            this.lookUpEditReceptores.Location = new System.Drawing.Point(101, 174);
            this.lookUpEditReceptores.Name = "lookUpEditReceptores";
            this.lookUpEditReceptores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditReceptores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre_usuario", "USUARIO")});
            this.lookUpEditReceptores.Size = new System.Drawing.Size(323, 20);
            this.lookUpEditReceptores.StyleController = this.layoutControl1;
            this.lookUpEditReceptores.TabIndex = 6;
            // 
            // lookUpEditTiposPagos
            // 
            this.lookUpEditTiposPagos.Location = new System.Drawing.Point(101, 150);
            this.lookUpEditTiposPagos.Name = "lookUpEditTiposPagos";
            this.lookUpEditTiposPagos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTiposPagos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo_pago", "TIPO ")});
            this.lookUpEditTiposPagos.Size = new System.Drawing.Size(323, 20);
            this.lookUpEditTiposPagos.StyleController = this.layoutControl1;
            this.lookUpEditTiposPagos.TabIndex = 5;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(24, 65);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "ORDENADO POF FECHAS Y FORMA DE PAGO"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "ORDENADO POR RECEPTOR Y FECHAS")});
            this.radioGroup1.Size = new System.Drawing.Size(400, 57);
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.TabIndex = 4;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(448, 333);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyRadioGroup,
            this.emptySpaceItem1,
            this.lyTipoPago,
            this.lyReceptor,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(428, 313);
            this.layoutControlGroup1.Text = "DATOS DEL REPORTE";
            // 
            // lyRadioGroup
            // 
            this.lyRadioGroup.Control = this.radioGroup1;
            this.lyRadioGroup.Location = new System.Drawing.Point(0, 0);
            this.lyRadioGroup.Name = "lyRadioGroup";
            this.lyRadioGroup.Size = new System.Drawing.Size(404, 77);
            this.lyRadioGroup.Text = "OPCIONES";
            this.lyRadioGroup.TextLocation = DevExpress.Utils.Locations.Top;
            this.lyRadioGroup.TextSize = new System.Drawing.Size(74, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 197);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(404, 41);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lyTipoPago
            // 
            this.lyTipoPago.Control = this.lookUpEditTiposPagos;
            this.lyTipoPago.Location = new System.Drawing.Point(0, 101);
            this.lyTipoPago.Name = "lyTipoPago";
            this.lyTipoPago.Size = new System.Drawing.Size(404, 24);
            this.lyTipoPago.Text = "TIPO DE PAGO";
            this.lyTipoPago.TextSize = new System.Drawing.Size(74, 13);
            // 
            // lyReceptor
            // 
            this.lyReceptor.Control = this.lookUpEditReceptores;
            this.lyReceptor.Location = new System.Drawing.Point(0, 125);
            this.lyReceptor.Name = "lyReceptor";
            this.lyReceptor.Size = new System.Drawing.Size(404, 24);
            this.lyReceptor.Text = "RECEPTOR";
            this.lyReceptor.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dateEditInicial;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 149);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(404, 24);
            this.layoutControlItem4.Text = "FECHA INICIAL";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dateEditFinal;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 173);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(404, 24);
            this.layoutControlItem5.Text = "FECHA FINAL";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnImprimir;
            this.layoutControlItem6.Location = new System.Drawing.Point(289, 238);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(115, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnSalir;
            this.layoutControlItem7.Location = new System.Drawing.Point(182, 238);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(107, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 238);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(182, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(24, 126);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "VER TODOS";
            this.checkEdit1.Size = new System.Drawing.Size(400, 20);
            this.checkEdit1.StyleController = this.layoutControl1;
            this.checkEdit1.TabIndex = 11;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 77);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(404, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FormModalAbrirReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 333);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "FormModalAbrirReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAGOS EFECTUADOS POR CLIENTES";
            this.Load += new System.EventHandler(this.FormModalAbrirReporte_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormModalAbrirReporte_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditReceptores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTiposPagos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyRadioGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTipoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyReceptor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lyRadioGroup;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTiposPagos;
        private DevExpress.XtraLayout.LayoutControlItem lyTipoPago;
        private DevExpress.XtraEditors.DateEdit dateEditFinal;
        private DevExpress.XtraEditors.DateEdit dateEditInicial;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditReceptores;
        private DevExpress.XtraLayout.LayoutControlItem lyReceptor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}