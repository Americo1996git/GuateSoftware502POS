namespace ViewGuate502.Reportes.RevisionDepostiosNotas
{
    partial class FormRevisionDepositosNotas
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnEstadoCuenta = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnProceder = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditFinal = new DevExpress.XtraEditors.DateEdit();
            this.dateEditInicial = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(24, 105);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(798, 332);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Controls.Add(this.btnEstadoCuenta);
            this.layoutControl1.Controls.Add(this.btnSalir);
            this.layoutControl1.Controls.Add(this.btnProceder);
            this.layoutControl1.Controls.Add(this.dateEditFinal);
            this.layoutControl1.Controls.Add(this.dateEditInicial);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(846, 487);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnEstadoCuenta
            // 
            this.btnEstadoCuenta.Location = new System.Drawing.Point(537, 453);
            this.btnEstadoCuenta.Name = "btnEstadoCuenta";
            this.btnEstadoCuenta.Size = new System.Drawing.Size(139, 22);
            this.btnEstadoCuenta.StyleController = this.layoutControl1;
            this.btnEstadoCuenta.TabIndex = 7;
            this.btnEstadoCuenta.Text = "ESTADO DE CUENTA";
            this.btnEstadoCuenta.Click += new System.EventHandler(this.btnEstadoCuenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(680, 453);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 22);
            this.btnSalir.StyleController = this.layoutControl1;
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "[ESC] SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProceder
            // 
            this.btnProceder.Location = new System.Drawing.Point(732, 79);
            this.btnProceder.Name = "btnProceder";
            this.btnProceder.Size = new System.Drawing.Size(90, 22);
            this.btnProceder.StyleController = this.layoutControl1;
            this.btnProceder.TabIndex = 5;
            this.btnProceder.Text = "PROCEDER";
            this.btnProceder.Click += new System.EventHandler(this.btnProceder_Click);
            // 
            // dateEditFinal
            // 
            this.dateEditFinal.EditValue = null;
            this.dateEditFinal.Location = new System.Drawing.Point(353, 79);
            this.dateEditFinal.Name = "dateEditFinal";
            this.dateEditFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFinal.Size = new System.Drawing.Size(109, 20);
            this.dateEditFinal.StyleController = this.layoutControl1;
            this.dateEditFinal.TabIndex = 4;
            // 
            // dateEditInicial
            // 
            this.dateEditInicial.EditValue = null;
            this.dateEditInicial.Location = new System.Drawing.Point(134, 79);
            this.dateEditInicial.Name = "dateEditInicial";
            this.dateEditInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInicial.Size = new System.Drawing.Size(105, 20);
            this.dateEditInicial.StyleController = this.layoutControl1;
            this.dateEditInicial.TabIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(846, 487);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "REVISIÓN DEPOSITOS Y NOTAS";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(826, 441);
            this.layoutControlGroup1.Text = "REVISIÓN";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(802, 336);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEditInicial;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(219, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(219, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(219, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "FECHA INICIAL";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateEditFinal;
            this.layoutControlItem3.Location = new System.Drawing.Point(219, 30);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(223, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(223, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(223, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "FECHA FINAL";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(107, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnProceder;
            this.layoutControlItem4.Location = new System.Drawing.Point(708, 30);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(94, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(442, 30);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(266, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnSalir;
            this.layoutControlItem5.Location = new System.Drawing.Point(668, 441);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(158, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(158, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(158, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEstadoCuenta;
            this.layoutControlItem6.Location = new System.Drawing.Point(525, 441);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(143, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(143, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(143, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 441);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(525, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(24, 65);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(798, 10);
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.TabIndex = 8;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.radioGroup1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(802, 30);
            this.layoutControlItem7.Text = "TIPO DE DOCUMENTO";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(107, 13);
            // 
            // FormRevisionDepositosNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 487);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "FormRevisionDepositosNotas";
            this.Text = "REVISIÓN DEPOSITOS Y NOTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRevisionDepositosNotas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRevisionDepositosNotas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnProceder;
        private DevExpress.XtraEditors.DateEdit dateEditFinal;
        private DevExpress.XtraEditors.DateEdit dateEditInicial;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnEstadoCuenta;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}