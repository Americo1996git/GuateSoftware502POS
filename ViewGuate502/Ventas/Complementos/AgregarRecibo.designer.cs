namespace ViewGuate502.Ventas.Complementos
{
    partial class AgregarRecibo
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
            this.gcagregaranticipo = new DevExpress.XtraEditors.GroupControl();
            this.tbnoboleta = new DevExpress.XtraEditors.TextEdit();
            this.tbfechadeposito = new DevExpress.XtraEditors.TextEdit();
            this.tbbanco = new DevExpress.XtraEditors.TextEdit();
            this.tbcliente = new DevExpress.XtraEditors.TextEdit();
            this.lblcliente = new DevExpress.XtraEditors.LabelControl();
            this.btngenerarrecibo = new DevExpress.XtraEditors.SimpleButton();
            this.tbcorrelativo = new DevExpress.XtraEditors.TextEdit();
            this.lblcorrelativo = new System.Windows.Forms.Label();
            this.btnguardar = new DevExpress.XtraEditors.SimpleButton();
            this.medescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.lbldescripcion = new DevExpress.XtraEditors.LabelControl();
            this.luetipopago = new DevExpress.XtraEditors.LookUpEdit();
            this.tbltipospagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSoftwareGTDataSet = new ViewGuate502.dbSoftwareGTDataSet();
            this.lblmonto = new DevExpress.XtraEditors.LabelControl();
            this.lblserie = new DevExpress.XtraEditors.LabelControl();
            this.lbltipopago = new DevExpress.XtraEditors.LabelControl();
            this.tbmonto = new DevExpress.XtraEditors.TextEdit();
            this.tbserie = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tbl_tipos_pagoTableAdapter = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.tbl_tipos_pagoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcagregaranticipo)).BeginInit();
            this.gcagregaranticipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbnoboleta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfechadeposito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcorrelativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetipopago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipospagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbserie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcagregaranticipo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(489, 427);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcagregaranticipo
            // 
            this.gcagregaranticipo.Controls.Add(this.tbnoboleta);
            this.gcagregaranticipo.Controls.Add(this.tbfechadeposito);
            this.gcagregaranticipo.Controls.Add(this.tbbanco);
            this.gcagregaranticipo.Controls.Add(this.tbcliente);
            this.gcagregaranticipo.Controls.Add(this.lblcliente);
            this.gcagregaranticipo.Controls.Add(this.btngenerarrecibo);
            this.gcagregaranticipo.Controls.Add(this.tbcorrelativo);
            this.gcagregaranticipo.Controls.Add(this.lblcorrelativo);
            this.gcagregaranticipo.Controls.Add(this.btnguardar);
            this.gcagregaranticipo.Controls.Add(this.medescripcion);
            this.gcagregaranticipo.Controls.Add(this.lbldescripcion);
            this.gcagregaranticipo.Controls.Add(this.luetipopago);
            this.gcagregaranticipo.Controls.Add(this.lblmonto);
            this.gcagregaranticipo.Controls.Add(this.lblserie);
            this.gcagregaranticipo.Controls.Add(this.lbltipopago);
            this.gcagregaranticipo.Controls.Add(this.tbmonto);
            this.gcagregaranticipo.Controls.Add(this.tbserie);
            this.gcagregaranticipo.Location = new System.Drawing.Point(12, 12);
            this.gcagregaranticipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcagregaranticipo.Name = "gcagregaranticipo";
            this.gcagregaranticipo.Size = new System.Drawing.Size(465, 403);
            this.gcagregaranticipo.TabIndex = 0;
            this.gcagregaranticipo.Text = "Agregar anticipo";
            // 
            // tbnoboleta
            // 
            this.tbnoboleta.Location = new System.Drawing.Point(27, 299);
            this.tbnoboleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbnoboleta.Name = "tbnoboleta";
            this.tbnoboleta.Properties.NullText = "Ingrese el número de boleta...";
            this.tbnoboleta.Size = new System.Drawing.Size(165, 20);
            this.tbnoboleta.TabIndex = 7;
            this.tbnoboleta.Visible = false;
            // 
            // tbfechadeposito
            // 
            this.tbfechadeposito.Location = new System.Drawing.Point(27, 263);
            this.tbfechadeposito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbfechadeposito.Name = "tbfechadeposito";
            this.tbfechadeposito.Properties.NullText = "Ingrese fecha del depósito...";
            this.tbfechadeposito.Size = new System.Drawing.Size(165, 20);
            this.tbfechadeposito.TabIndex = 6;
            this.tbfechadeposito.Visible = false;
            // 
            // tbbanco
            // 
            this.tbbanco.Location = new System.Drawing.Point(27, 231);
            this.tbbanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbbanco.Name = "tbbanco";
            this.tbbanco.Properties.NullText = "Ingrese banco del depósito...";
            this.tbbanco.Size = new System.Drawing.Size(165, 20);
            this.tbbanco.TabIndex = 5;
            this.tbbanco.Visible = false;
            // 
            // tbcliente
            // 
            this.tbcliente.Location = new System.Drawing.Point(27, 103);
            this.tbcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcliente.Name = "tbcliente";
            this.tbcliente.Size = new System.Drawing.Size(391, 20);
            this.tbcliente.TabIndex = 2;
            // 
            // lblcliente
            // 
            this.lblcliente.Location = new System.Drawing.Point(27, 85);
            this.lblcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(33, 13);
            this.lblcliente.TabIndex = 15;
            this.lblcliente.Text = "Cliente";
            // 
            // btngenerarrecibo
            // 
            this.btngenerarrecibo.Location = new System.Drawing.Point(113, 362);
            this.btngenerarrecibo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngenerarrecibo.Name = "btngenerarrecibo";
            this.btngenerarrecibo.Size = new System.Drawing.Size(87, 24);
            this.btngenerarrecibo.TabIndex = 10;
            this.btngenerarrecibo.Text = "Generar recibo";
            this.btngenerarrecibo.Click += new System.EventHandler(this.btngenerarrecibo_Click);
            // 
            // tbcorrelativo
            // 
            this.tbcorrelativo.Location = new System.Drawing.Point(95, 63);
            this.tbcorrelativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcorrelativo.Name = "tbcorrelativo";
            this.tbcorrelativo.Size = new System.Drawing.Size(61, 20);
            this.tbcorrelativo.TabIndex = 1;
            // 
            // lblcorrelativo
            // 
            this.lblcorrelativo.AutoSize = true;
            this.lblcorrelativo.Location = new System.Drawing.Point(93, 45);
            this.lblcorrelativo.Name = "lblcorrelativo";
            this.lblcorrelativo.Size = new System.Drawing.Size(60, 13);
            this.lblcorrelativo.TabIndex = 12;
            this.lblcorrelativo.Text = "Correlativo";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(27, 362);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(81, 24);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // medescripcion
            // 
            this.medescripcion.Location = new System.Drawing.Point(27, 231);
            this.medescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medescripcion.Name = "medescripcion";
            this.medescripcion.Size = new System.Drawing.Size(391, 127);
            this.medescripcion.TabIndex = 8;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.Location = new System.Drawing.Point(27, 213);
            this.lbldescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(54, 13);
            this.lbldescripcion.TabIndex = 8;
            this.lbldescripcion.Text = "Descripción";
            // 
            // luetipopago
            // 
            this.luetipopago.Location = new System.Drawing.Point(27, 190);
            this.luetipopago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.luetipopago.Name = "luetipopago";
            this.luetipopago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luetipopago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_tipo_pago", "id_tipo_pago", 96, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo_pago", "tipo_pago", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 43, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("fecha_creacion", "fecha_creacion", 96, DevExpress.Utils.FormatType.DateTime, "d/MM/yyyy", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_usuario_creacion", "id_usuario_creacion", 124, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luetipopago.Properties.DataSource = this.tbltipospagoBindingSource;
            this.luetipopago.Properties.DisplayMember = "tipo_pago";
            this.luetipopago.Properties.NullText = "Seleccione...";
            this.luetipopago.Properties.ValueMember = "id_tipo_pago";
            this.luetipopago.Size = new System.Drawing.Size(165, 20);
            this.luetipopago.TabIndex = 4;
            this.luetipopago.EditValueChanged += new System.EventHandler(this.luetipopago_EditValueChanged);
            // 
            // tbltipospagoBindingSource
            // 
            this.tbltipospagoBindingSource.DataMember = "tbl_tipos_pago";
            this.tbltipospagoBindingSource.DataSource = this.dbSoftwareGTDataSet;
            // 
            // dbSoftwareGTDataSet
            // 
            this.dbSoftwareGTDataSet.DataSetName = "dbSoftwareGTDataSet";
            this.dbSoftwareGTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblmonto
            // 
            this.lblmonto.Location = new System.Drawing.Point(27, 132);
            this.lblmonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(30, 13);
            this.lblmonto.TabIndex = 6;
            this.lblmonto.Text = "Monto";
            // 
            // lblserie
            // 
            this.lblserie.Location = new System.Drawing.Point(27, 45);
            this.lblserie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(24, 13);
            this.lblserie.TabIndex = 5;
            this.lblserie.Text = "Serie";
            // 
            // lbltipopago
            // 
            this.lbltipopago.Location = new System.Drawing.Point(27, 172);
            this.lbltipopago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbltipopago.Name = "lbltipopago";
            this.lbltipopago.Size = new System.Drawing.Size(62, 13);
            this.lbltipopago.TabIndex = 4;
            this.lbltipopago.Text = "Tipo de pago";
            // 
            // tbmonto
            // 
            this.tbmonto.Location = new System.Drawing.Point(27, 150);
            this.tbmonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmonto.Name = "tbmonto";
            this.tbmonto.Size = new System.Drawing.Size(107, 20);
            this.tbmonto.TabIndex = 3;
            // 
            // tbserie
            // 
            this.tbserie.Location = new System.Drawing.Point(27, 63);
            this.tbserie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbserie.Name = "tbserie";
            this.tbserie.Size = new System.Drawing.Size(56, 20);
            this.tbserie.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(489, 427);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcagregaranticipo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(469, 407);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tbl_tipos_pagoTableAdapter
            // 
            this.tbl_tipos_pagoTableAdapter.ClearBeforeFill = true;
            // 
            // AgregarRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 427);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarRecibo";
            this.Text = "AgregarRecibo";
            this.Load += new System.EventHandler(this.AgregarRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcagregaranticipo)).EndInit();
            this.gcagregaranticipo.ResumeLayout(false);
            this.gcagregaranticipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbnoboleta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfechadeposito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcorrelativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetipopago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipospagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbserie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl gcagregaranticipo;
        private DevExpress.XtraEditors.LabelControl lblmonto;
        private DevExpress.XtraEditors.LabelControl lblserie;
        private DevExpress.XtraEditors.LabelControl lbltipopago;
        private DevExpress.XtraEditors.TextEdit tbmonto;
        private DevExpress.XtraEditors.TextEdit tbserie;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit luetipopago;
        private dbSoftwareGTDataSet dbSoftwareGTDataSet;
        private System.Windows.Forms.BindingSource tbltipospagoBindingSource;
        private dbSoftwareGTDataSetTableAdapters.tbl_tipos_pagoTableAdapter tbl_tipos_pagoTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnguardar;
        private DevExpress.XtraEditors.MemoEdit medescripcion;
        private DevExpress.XtraEditors.LabelControl lbldescripcion;
        private DevExpress.XtraEditors.TextEdit tbcorrelativo;
        private System.Windows.Forms.Label lblcorrelativo;
        private DevExpress.XtraEditors.SimpleButton btngenerarrecibo;
        private DevExpress.XtraEditors.TextEdit tbcliente;
        private DevExpress.XtraEditors.LabelControl lblcliente;
        private DevExpress.XtraEditors.TextEdit tbnoboleta;
        private DevExpress.XtraEditors.TextEdit tbfechadeposito;
        private DevExpress.XtraEditors.TextEdit tbbanco;
    }
}