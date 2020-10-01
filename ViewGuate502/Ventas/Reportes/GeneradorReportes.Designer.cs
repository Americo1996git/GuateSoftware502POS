namespace ViewGuate502.Ventas.Reportes
{
    partial class GeneradorReportes
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
            this.gcgeneradorreportes = new DevExpress.XtraEditors.GroupControl();
            this.chktodastiendas = new DevExpress.XtraEditors.CheckEdit();
            this.luetienda = new DevExpress.XtraEditors.LookUpEdit();
            this.tiendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSoftwareGTDataSet1 = new ViewGuate502.dbSoftwareGTDataSet();
            this.lblidtienda = new DevExpress.XtraEditors.LabelControl();
            this.gcresultados = new DevExpress.XtraEditors.GroupControl();
            this.tbservicios = new DevExpress.XtraEditors.TextEdit();
            this.tbrenegociadas = new DevExpress.XtraEditors.TextEdit();
            this.tbsubtotal = new DevExpress.XtraEditors.TextEdit();
            this.tbcredito = new DevExpress.XtraEditors.TextEdit();
            this.tbcontado = new DevExpress.XtraEditors.TextEdit();
            this.lblcontado = new System.Windows.Forms.Label();
            this.lblcredito = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.lblservicios = new System.Windows.Forms.Label();
            this.lblrenegociadas = new System.Windows.Forms.Label();
            this.luetiporeporte = new DevExpress.XtraEditors.LookUpEdit();
            this.lbltitulo = new DevExpress.XtraEditors.LabelControl();
            this.btngenerar = new DevExpress.XtraEditors.SimpleButton();
            this.defechafin = new DevExpress.XtraEditors.DateEdit();
            this.defechainicio = new DevExpress.XtraEditors.DateEdit();
            this.lblfechafin = new DevExpress.XtraEditors.LabelControl();
            this.lblfechainicio = new DevExpress.XtraEditors.LabelControl();
            this.lbltiporeporte = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tiendaTableAdapter = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.TiendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcgeneradorreportes)).BeginInit();
            this.gcgeneradorreportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chktodastiendas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetienda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcresultados)).BeginInit();
            this.gcresultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbservicios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrenegociadas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcredito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcontado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetiporeporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechafin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechafin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechainicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechainicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcgeneradorreportes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(711, 504);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcgeneradorreportes
            // 
            this.gcgeneradorreportes.Controls.Add(this.chktodastiendas);
            this.gcgeneradorreportes.Controls.Add(this.luetienda);
            this.gcgeneradorreportes.Controls.Add(this.lblidtienda);
            this.gcgeneradorreportes.Controls.Add(this.gcresultados);
            this.gcgeneradorreportes.Controls.Add(this.luetiporeporte);
            this.gcgeneradorreportes.Controls.Add(this.lbltitulo);
            this.gcgeneradorreportes.Controls.Add(this.btngenerar);
            this.gcgeneradorreportes.Controls.Add(this.defechafin);
            this.gcgeneradorreportes.Controls.Add(this.defechainicio);
            this.gcgeneradorreportes.Controls.Add(this.lblfechafin);
            this.gcgeneradorreportes.Controls.Add(this.lblfechainicio);
            this.gcgeneradorreportes.Controls.Add(this.lbltiporeporte);
            this.gcgeneradorreportes.Location = new System.Drawing.Point(12, 12);
            this.gcgeneradorreportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcgeneradorreportes.Name = "gcgeneradorreportes";
            this.gcgeneradorreportes.Size = new System.Drawing.Size(687, 480);
            this.gcgeneradorreportes.TabIndex = 0;
            this.gcgeneradorreportes.Text = "Generador de reportes";
            // 
            // chktodastiendas
            // 
            this.chktodastiendas.Location = new System.Drawing.Point(300, 130);
            this.chktodastiendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chktodastiendas.Name = "chktodastiendas";
            this.chktodastiendas.Properties.Caption = "Todas las tiendas";
            this.chktodastiendas.Size = new System.Drawing.Size(118, 20);
            this.chktodastiendas.TabIndex = 3;
            this.chktodastiendas.CheckedChanged += new System.EventHandler(this.chktodastiendas_CheckedChanged);
            // 
            // luetienda
            // 
            this.luetienda.Location = new System.Drawing.Point(300, 107);
            this.luetienda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.luetienda.Name = "luetienda";
            this.luetienda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luetienda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idtienda", "idtienda", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ubicacion", "ubicacion", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luetienda.Properties.DataSource = this.tiendaBindingSource;
            this.luetienda.Properties.DisplayMember = "nombre";
            this.luetienda.Properties.NullText = "Seleccione...";
            this.luetienda.Properties.ShowHeader = false;
            this.luetienda.Properties.ValueMember = "idtienda";
            this.luetienda.Size = new System.Drawing.Size(241, 20);
            this.luetienda.TabIndex = 1;
            // 
            // tiendaBindingSource
            // 
            this.tiendaBindingSource.DataMember = "Tienda";
            this.tiendaBindingSource.DataSource = this.dbSoftwareGTDataSet1;
            // 
            // dbSoftwareGTDataSet1
            // 
            this.dbSoftwareGTDataSet1.DataSetName = "dbSoftwareGTDataSet";
            this.dbSoftwareGTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblidtienda
            // 
            this.lblidtienda.Location = new System.Drawing.Point(300, 89);
            this.lblidtienda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblidtienda.Name = "lblidtienda";
            this.lblidtienda.Size = new System.Drawing.Size(32, 13);
            this.lblidtienda.TabIndex = 11;
            this.lblidtienda.Text = "Tienda";
            // 
            // gcresultados
            // 
            this.gcresultados.Controls.Add(this.tbservicios);
            this.gcresultados.Controls.Add(this.tbrenegociadas);
            this.gcresultados.Controls.Add(this.tbsubtotal);
            this.gcresultados.Controls.Add(this.tbcredito);
            this.gcresultados.Controls.Add(this.tbcontado);
            this.gcresultados.Controls.Add(this.lblcontado);
            this.gcresultados.Controls.Add(this.lblcredito);
            this.gcresultados.Controls.Add(this.lblsubtotal);
            this.gcresultados.Controls.Add(this.lblservicios);
            this.gcresultados.Controls.Add(this.lblrenegociadas);
            this.gcresultados.Location = new System.Drawing.Point(161, 266);
            this.gcresultados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcresultados.Name = "gcresultados";
            this.gcresultados.Size = new System.Drawing.Size(380, 197);
            this.gcresultados.TabIndex = 10;
            this.gcresultados.Text = "Resultados";
            this.gcresultados.Visible = false;
            // 
            // tbservicios
            // 
            this.tbservicios.Location = new System.Drawing.Point(139, 122);
            this.tbservicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbservicios.Name = "tbservicios";
            this.tbservicios.Properties.ReadOnly = true;
            this.tbservicios.Size = new System.Drawing.Size(107, 20);
            this.tbservicios.TabIndex = 4;
            // 
            // tbrenegociadas
            // 
            this.tbrenegociadas.Location = new System.Drawing.Point(139, 99);
            this.tbrenegociadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbrenegociadas.Name = "tbrenegociadas";
            this.tbrenegociadas.Properties.ReadOnly = true;
            this.tbrenegociadas.Size = new System.Drawing.Size(107, 20);
            this.tbrenegociadas.TabIndex = 3;
            // 
            // tbsubtotal
            // 
            this.tbsubtotal.Location = new System.Drawing.Point(139, 76);
            this.tbsubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbsubtotal.Name = "tbsubtotal";
            this.tbsubtotal.Properties.ReadOnly = true;
            this.tbsubtotal.Size = new System.Drawing.Size(107, 20);
            this.tbsubtotal.TabIndex = 2;
            // 
            // tbcredito
            // 
            this.tbcredito.Location = new System.Drawing.Point(139, 54);
            this.tbcredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcredito.Name = "tbcredito";
            this.tbcredito.Properties.ReadOnly = true;
            this.tbcredito.Size = new System.Drawing.Size(107, 20);
            this.tbcredito.TabIndex = 1;
            // 
            // tbcontado
            // 
            this.tbcontado.Location = new System.Drawing.Point(139, 31);
            this.tbcontado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcontado.Name = "tbcontado";
            this.tbcontado.Properties.ReadOnly = true;
            this.tbcontado.Size = new System.Drawing.Size(107, 20);
            this.tbcontado.TabIndex = 0;
            // 
            // lblcontado
            // 
            this.lblcontado.AutoSize = true;
            this.lblcontado.Location = new System.Drawing.Point(15, 35);
            this.lblcontado.Name = "lblcontado";
            this.lblcontado.Size = new System.Drawing.Size(48, 13);
            this.lblcontado.TabIndex = 2;
            this.lblcontado.Text = "Contado";
            // 
            // lblcredito
            // 
            this.lblcredito.AutoSize = true;
            this.lblcredito.Location = new System.Drawing.Point(15, 58);
            this.lblcredito.Name = "lblcredito";
            this.lblcredito.Size = new System.Drawing.Size(42, 13);
            this.lblcredito.TabIndex = 3;
            this.lblcredito.Text = "Crédito";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Location = new System.Drawing.Point(15, 80);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblsubtotal.TabIndex = 4;
            this.lblsubtotal.Text = "SubTotal";
            // 
            // lblservicios
            // 
            this.lblservicios.AutoSize = true;
            this.lblservicios.Location = new System.Drawing.Point(15, 126);
            this.lblservicios.Name = "lblservicios";
            this.lblservicios.Size = new System.Drawing.Size(49, 13);
            this.lblservicios.TabIndex = 6;
            this.lblservicios.Text = "Servicios";
            // 
            // lblrenegociadas
            // 
            this.lblrenegociadas.AutoSize = true;
            this.lblrenegociadas.Location = new System.Drawing.Point(15, 103);
            this.lblrenegociadas.Name = "lblrenegociadas";
            this.lblrenegociadas.Size = new System.Drawing.Size(74, 13);
            this.lblrenegociadas.TabIndex = 5;
            this.lblrenegociadas.Text = "Renegociadas";
            // 
            // luetiporeporte
            // 
            this.luetiporeporte.Location = new System.Drawing.Point(26, 107);
            this.luetiporeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.luetiporeporte.Name = "luetiporeporte";
            this.luetiporeporte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luetiporeporte.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", ""),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "")});
            this.luetiporeporte.Properties.NullText = "Seleccione...";
            this.luetiporeporte.Properties.ShowHeader = false;
            this.luetiporeporte.Size = new System.Drawing.Size(257, 20);
            this.luetiporeporte.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbltitulo.Appearance.Options.UseFont = true;
            this.lbltitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbltitulo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbltitulo.Location = new System.Drawing.Point(26, 41);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(633, 29);
            this.lbltitulo.TabIndex = 7;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(26, 222);
            this.btngenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(81, 24);
            this.btngenerar.TabIndex = 5;
            this.btngenerar.Text = "Generar";
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // defechafin
            // 
            this.defechafin.EditValue = null;
            this.defechafin.Location = new System.Drawing.Point(26, 188);
            this.defechafin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.defechafin.Name = "defechafin";
            this.defechafin.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.defechafin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.defechafin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.defechafin.Properties.NullText = "Seleccione...";
            this.defechafin.Size = new System.Drawing.Size(257, 20);
            this.defechafin.TabIndex = 4;
            // 
            // defechainicio
            // 
            this.defechainicio.EditValue = null;
            this.defechainicio.Location = new System.Drawing.Point(26, 148);
            this.defechainicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.defechainicio.Name = "defechainicio";
            this.defechainicio.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.defechainicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.defechainicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.defechainicio.Properties.NullText = "Seleccione...";
            this.defechainicio.Size = new System.Drawing.Size(257, 20);
            this.defechainicio.TabIndex = 2;
            // 
            // lblfechafin
            // 
            this.lblfechafin.Location = new System.Drawing.Point(26, 171);
            this.lblfechafin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblfechafin.Name = "lblfechafin";
            this.lblfechafin.Size = new System.Drawing.Size(44, 13);
            this.lblfechafin.TabIndex = 2;
            this.lblfechafin.Text = "Fecha fin";
            // 
            // lblfechainicio
            // 
            this.lblfechainicio.Location = new System.Drawing.Point(26, 130);
            this.lblfechainicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblfechainicio.Name = "lblfechainicio";
            this.lblfechainicio.Size = new System.Drawing.Size(55, 13);
            this.lblfechainicio.TabIndex = 1;
            this.lblfechainicio.Text = "Fecha inicio";
            // 
            // lbltiporeporte
            // 
            this.lbltiporeporte.Location = new System.Drawing.Point(26, 89);
            this.lbltiporeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbltiporeporte.Name = "lbltiporeporte";
            this.lbltiporeporte.Size = new System.Drawing.Size(74, 13);
            this.lbltiporeporte.TabIndex = 0;
            this.lbltiporeporte.Text = "Tipo de reporte";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(711, 504);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcgeneradorreportes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(691, 484);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tiendaTableAdapter
            // 
            this.tiendaTableAdapter.ClearBeforeFill = true;
            // 
            // GeneradorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 504);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GeneradorReportes";
            this.Text = "Generador de Reportes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneradorReportes_FormClosed);
            this.Load += new System.EventHandler(this.GeneradorReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcgeneradorreportes)).EndInit();
            this.gcgeneradorreportes.ResumeLayout(false);
            this.gcgeneradorreportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chktodastiendas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetienda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcresultados)).EndInit();
            this.gcresultados.ResumeLayout(false);
            this.gcresultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbservicios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrenegociadas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcredito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcontado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetiporeporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechafin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechafin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechainicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defechainicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl gcgeneradorreportes;
        private DevExpress.XtraEditors.LabelControl lbltitulo;
        private DevExpress.XtraEditors.SimpleButton btngenerar;
        private DevExpress.XtraEditors.DateEdit defechafin;
        private DevExpress.XtraEditors.DateEdit defechainicio;
        private DevExpress.XtraEditors.LabelControl lblfechafin;
        private DevExpress.XtraEditors.LabelControl lblfechainicio;
        private DevExpress.XtraEditors.LabelControl lbltiporeporte;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit luetiporeporte;
        private DevExpress.XtraEditors.GroupControl gcresultados;
        private DevExpress.XtraEditors.TextEdit tbservicios;
        private DevExpress.XtraEditors.TextEdit tbrenegociadas;
        private DevExpress.XtraEditors.TextEdit tbsubtotal;
        private DevExpress.XtraEditors.TextEdit tbcredito;
        private DevExpress.XtraEditors.TextEdit tbcontado;
        private System.Windows.Forms.Label lblcontado;
        private System.Windows.Forms.Label lblcredito;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label lblservicios;
        private System.Windows.Forms.Label lblrenegociadas;
        private DevExpress.XtraEditors.LookUpEdit luetienda;
        private DevExpress.XtraEditors.LabelControl lblidtienda;
        private dbSoftwareGTDataSet dbSoftwareGTDataSet1;
        private System.Windows.Forms.BindingSource tiendaBindingSource;
        private dbSoftwareGTDataSetTableAdapters.TiendaTableAdapter tiendaTableAdapter;
        private DevExpress.XtraEditors.CheckEdit chktodastiendas;
    }
}