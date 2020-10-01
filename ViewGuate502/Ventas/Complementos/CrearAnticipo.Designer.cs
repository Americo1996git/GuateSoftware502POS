namespace ViewGuate502.Ventas.Complementos
{
    partial class CrearAnticipo
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
            this.gcnuevoanticipo = new DevExpress.XtraEditors.GroupControl();
            this.tbnoboleta = new DevExpress.XtraEditors.TextEdit();
            this.tbfechadeposito = new DevExpress.XtraEditors.TextEdit();
            this.tbbanco = new DevExpress.XtraEditors.TextEdit();
            this.btnguardar = new DevExpress.XtraEditors.SimpleButton();
            this.medescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.luetipopago = new DevExpress.XtraEditors.LookUpEdit();
            this.tbltipospagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSoftwareGTDataSet = new ViewGuate502.dbSoftwareGTDataSet();
            this.tbmontoanticipo = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltipopago = new System.Windows.Forms.Label();
            this.lblmontoanticipo = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tbl_tipos_pagoTableAdapter = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.tbl_tipos_pagoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcnuevoanticipo)).BeginInit();
            this.gcnuevoanticipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbnoboleta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfechadeposito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetipopago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipospagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmontoanticipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcnuevoanticipo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(612, 466);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcnuevoanticipo
            // 
            this.gcnuevoanticipo.Controls.Add(this.tbnoboleta);
            this.gcnuevoanticipo.Controls.Add(this.tbfechadeposito);
            this.gcnuevoanticipo.Controls.Add(this.tbbanco);
            this.gcnuevoanticipo.Controls.Add(this.btnguardar);
            this.gcnuevoanticipo.Controls.Add(this.medescripcion);
            this.gcnuevoanticipo.Controls.Add(this.luetipopago);
            this.gcnuevoanticipo.Controls.Add(this.tbmontoanticipo);
            this.gcnuevoanticipo.Controls.Add(this.label3);
            this.gcnuevoanticipo.Controls.Add(this.lbltipopago);
            this.gcnuevoanticipo.Controls.Add(this.lblmontoanticipo);
            this.gcnuevoanticipo.Location = new System.Drawing.Point(12, 12);
            this.gcnuevoanticipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcnuevoanticipo.Name = "gcnuevoanticipo";
            this.gcnuevoanticipo.Size = new System.Drawing.Size(588, 442);
            this.gcnuevoanticipo.TabIndex = 0;
            this.gcnuevoanticipo.Text = "Nuevo anticipo";
            // 
            // tbnoboleta
            // 
            this.tbnoboleta.Location = new System.Drawing.Point(15, 216);
            this.tbnoboleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbnoboleta.Name = "tbnoboleta";
            this.tbnoboleta.Properties.NullText = "Ingrese el número de boleta...";
            this.tbnoboleta.Size = new System.Drawing.Size(245, 20);
            this.tbnoboleta.TabIndex = 6;
            this.tbnoboleta.Visible = false;
            // 
            // tbfechadeposito
            // 
            this.tbfechadeposito.Location = new System.Drawing.Point(16, 180);
            this.tbfechadeposito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbfechadeposito.Name = "tbfechadeposito";
            this.tbfechadeposito.Properties.NullText = "Ingrese fecha del depósito...";
            this.tbfechadeposito.Size = new System.Drawing.Size(245, 20);
            this.tbfechadeposito.TabIndex = 5;
            this.tbfechadeposito.Visible = false;
            // 
            // tbbanco
            // 
            this.tbbanco.Location = new System.Drawing.Point(16, 142);
            this.tbbanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbbanco.Name = "tbbanco";
            this.tbbanco.Properties.NullText = "Ingrese banco del depósito...";
            this.tbbanco.Size = new System.Drawing.Size(245, 20);
            this.tbbanco.TabIndex = 4;
            this.tbbanco.Visible = false;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(16, 267);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(81, 24);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // medescripcion
            // 
            this.medescripcion.Location = new System.Drawing.Point(15, 142);
            this.medescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medescripcion.Name = "medescripcion";
            this.medescripcion.Size = new System.Drawing.Size(246, 110);
            this.medescripcion.TabIndex = 3;
            // 
            // luetipopago
            // 
            this.luetipopago.Location = new System.Drawing.Point(15, 98);
            this.luetipopago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.luetipopago.Name = "luetipopago";
            this.luetipopago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luetipopago.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_tipo_pago", "id_tipo_pago", 96, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo_pago", "tipo_pago", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luetipopago.Properties.DataSource = this.tbltipospagoBindingSource;
            this.luetipopago.Properties.DisplayMember = "tipo_pago";
            this.luetipopago.Properties.NullText = "Seleccione...";
            this.luetipopago.Properties.ValueMember = "id_tipo_pago";
            this.luetipopago.Size = new System.Drawing.Size(146, 20);
            this.luetipopago.TabIndex = 2;
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
            // tbmontoanticipo
            // 
            this.tbmontoanticipo.Location = new System.Drawing.Point(15, 58);
            this.tbmontoanticipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmontoanticipo.Name = "tbmontoanticipo";
            this.tbmontoanticipo.Size = new System.Drawing.Size(146, 20);
            this.tbmontoanticipo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion";
            // 
            // lbltipopago
            // 
            this.lbltipopago.AutoSize = true;
            this.lbltipopago.Location = new System.Drawing.Point(13, 79);
            this.lbltipopago.Name = "lbltipopago";
            this.lbltipopago.Size = new System.Drawing.Size(54, 13);
            this.lbltipopago.TabIndex = 9;
            this.lbltipopago.Text = "Tipo pago";
            // 
            // lblmontoanticipo
            // 
            this.lblmontoanticipo.AutoSize = true;
            this.lblmontoanticipo.Location = new System.Drawing.Point(13, 42);
            this.lblmontoanticipo.Name = "lblmontoanticipo";
            this.lblmontoanticipo.Size = new System.Drawing.Size(77, 13);
            this.lblmontoanticipo.TabIndex = 0;
            this.lblmontoanticipo.Text = "Monto anticipo";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(612, 466);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcnuevoanticipo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(592, 446);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tbl_tipos_pagoTableAdapter
            // 
            this.tbl_tipos_pagoTableAdapter.ClearBeforeFill = true;
            // 
            // CrearAnticipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 466);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CrearAnticipo";
            this.Text = "CrearAnticipo";
            this.Load += new System.EventHandler(this.CrearAnticipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcnuevoanticipo)).EndInit();
            this.gcnuevoanticipo.ResumeLayout(false);
            this.gcnuevoanticipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbnoboleta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfechadeposito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetipopago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipospagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmontoanticipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl gcnuevoanticipo;
        private DevExpress.XtraEditors.LookUpEdit luetipopago;
        private DevExpress.XtraEditors.TextEdit tbmontoanticipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltipopago;
        private System.Windows.Forms.Label lblmontoanticipo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private dbSoftwareGTDataSet dbSoftwareGTDataSet;
        private System.Windows.Forms.BindingSource tbltipospagoBindingSource;
        private dbSoftwareGTDataSetTableAdapters.tbl_tipos_pagoTableAdapter tbl_tipos_pagoTableAdapter;
        private DevExpress.XtraEditors.MemoEdit medescripcion;
        private DevExpress.XtraEditors.SimpleButton btnguardar;
        private DevExpress.XtraEditors.TextEdit tbnoboleta;
        private DevExpress.XtraEditors.TextEdit tbfechadeposito;
        private DevExpress.XtraEditors.TextEdit tbbanco;
    }
}