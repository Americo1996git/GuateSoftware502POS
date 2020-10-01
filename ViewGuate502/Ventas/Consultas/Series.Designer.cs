namespace ViewGuate502.Ventas.Consultas
{
    partial class Series
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
            this.gcseries = new DevExpress.XtraEditors.GroupControl();
            this.btngenerar = new DevExpress.XtraEditors.SimpleButton();
            this.defechafin = new DevExpress.XtraEditors.DateEdit();
            this.defechainicio = new DevExpress.XtraEditors.DateEdit();
            this.lblfechafin = new DevExpress.XtraEditors.LabelControl();
            this.lblfechainicio = new DevExpress.XtraEditors.LabelControl();
            this.teidproducto = new DevExpress.XtraEditors.TextEdit();
            this.tbnombreproducto = new DevExpress.XtraEditors.TextEdit();
            this.btnbuscarproducto = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcseries)).BeginInit();
            this.gcseries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defechafin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechafin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechainicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechainicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teidproducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnombreproducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcseries);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(762, 569);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcseries
            // 
            this.gcseries.Controls.Add(this.btngenerar);
            this.gcseries.Controls.Add(this.defechafin);
            this.gcseries.Controls.Add(this.defechainicio);
            this.gcseries.Controls.Add(this.lblfechafin);
            this.gcseries.Controls.Add(this.lblfechainicio);
            this.gcseries.Controls.Add(this.teidproducto);
            this.gcseries.Controls.Add(this.tbnombreproducto);
            this.gcseries.Controls.Add(this.btnbuscarproducto);
            this.gcseries.Location = new System.Drawing.Point(11, 10);
            this.gcseries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcseries.Name = "gcseries";
            this.gcseries.Size = new System.Drawing.Size(740, 549);
            this.gcseries.TabIndex = 0;
            this.gcseries.Text = "Consulta series";
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(26, 195);
            this.btngenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(94, 24);
            this.btngenerar.TabIndex = 5;
            this.btngenerar.Text = "Generar reporte";
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // defechafin
            // 
            this.defechafin.EditValue = null;
            this.defechafin.Location = new System.Drawing.Point(26, 156);
            this.defechafin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.defechafin.Name = "defechafin";
            this.defechafin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.defechafin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.defechafin.Properties.NullText = "Seleccione...";
            this.defechafin.Size = new System.Drawing.Size(214, 20);
            this.defechafin.TabIndex = 4;
            // 
            // defechainicio
            // 
            this.defechainicio.EditValue = null;
            this.defechainicio.Location = new System.Drawing.Point(26, 115);
            this.defechainicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.defechainicio.Name = "defechainicio";
            this.defechainicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.defechainicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.defechainicio.Properties.NullText = "Seleccione...";
            this.defechainicio.Size = new System.Drawing.Size(214, 20);
            this.defechainicio.TabIndex = 3;
            // 
            // lblfechafin
            // 
            this.lblfechafin.Location = new System.Drawing.Point(26, 138);
            this.lblfechafin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblfechafin.Name = "lblfechafin";
            this.lblfechafin.Size = new System.Drawing.Size(44, 13);
            this.lblfechafin.TabIndex = 4;
            this.lblfechafin.Text = "Fecha fin";
            // 
            // lblfechainicio
            // 
            this.lblfechainicio.Location = new System.Drawing.Point(26, 98);
            this.lblfechainicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblfechainicio.Name = "lblfechainicio";
            this.lblfechainicio.Size = new System.Drawing.Size(59, 13);
            this.lblfechainicio.TabIndex = 3;
            this.lblfechainicio.Text = "Fecha inicio:";
            // 
            // teidproducto
            // 
            this.teidproducto.Enabled = false;
            this.teidproducto.Location = new System.Drawing.Point(669, 51);
            this.teidproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teidproducto.Name = "teidproducto";
            this.teidproducto.Size = new System.Drawing.Size(45, 20);
            this.teidproducto.TabIndex = 2;
            this.teidproducto.Visible = false;
            // 
            // tbnombreproducto
            // 
            this.tbnombreproducto.Enabled = false;
            this.tbnombreproducto.Location = new System.Drawing.Point(125, 51);
            this.tbnombreproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbnombreproducto.Name = "tbnombreproducto";
            this.tbnombreproducto.Size = new System.Drawing.Size(539, 20);
            this.tbnombreproducto.TabIndex = 1;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.AutoSize = true;
            this.btnbuscarproducto.Location = new System.Drawing.Point(26, 49);
            this.btnbuscarproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(87, 22);
            this.btnbuscarproducto.TabIndex = 0;
            this.btnbuscarproducto.Text = "Buscar producto";
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(762, 569);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcseries;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(744, 553);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Series
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 569);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Series";
            this.Text = "Series";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcseries)).EndInit();
            this.gcseries.ResumeLayout(false);
            this.gcseries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defechafin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechafin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechainicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechainicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teidproducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnombreproducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl gcseries;
        private DevExpress.XtraEditors.SimpleButton btngenerar;
        private DevExpress.XtraEditors.DateEdit defechafin;
        private DevExpress.XtraEditors.DateEdit defechainicio;
        private DevExpress.XtraEditors.LabelControl lblfechafin;
        private DevExpress.XtraEditors.LabelControl lblfechainicio;
        private DevExpress.XtraEditors.SimpleButton btnbuscarproducto;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        public DevExpress.XtraEditors.TextEdit teidproducto;
        public DevExpress.XtraEditors.TextEdit tbnombreproducto;
    }
}