namespace ViewGuate502.Ventas.Reportes
{
    partial class EnvioCompleto
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcenviocompleto = new DevExpress.XtraEditors.GroupControl();
            this.tbcorrelativo = new DevExpress.XtraEditors.TextEdit();
            this.lbltienda = new DevExpress.XtraEditors.LabelControl();
            this.luetienda = new DevExpress.XtraEditors.LookUpEdit();
            this.btngenerar = new DevExpress.XtraEditors.SimpleButton();
            this.lueserie = new DevExpress.XtraEditors.LookUpEdit();
            this.lblcorrelativo = new DevExpress.XtraEditors.LabelControl();
            this.lblserie = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tiendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSoftwareGTDataSet = new ViewGuate502.dbSoftwareGTDataSet();
            this.tblseriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_seriesTableAdapter = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.tbl_seriesTableAdapter();
            this.tiendaTableAdapter = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.TiendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcenviocompleto)).BeginInit();
            this.gcenviocompleto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbcorrelativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetienda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueserie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblseriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(20, 20);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcenviocompleto);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup2;
            this.layoutControl1.Size = new System.Drawing.Size(351, 256);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcenviocompleto
            // 
            this.gcenviocompleto.Controls.Add(this.tbcorrelativo);
            this.gcenviocompleto.Controls.Add(this.lbltienda);
            this.gcenviocompleto.Controls.Add(this.luetienda);
            this.gcenviocompleto.Controls.Add(this.btngenerar);
            this.gcenviocompleto.Controls.Add(this.lueserie);
            this.gcenviocompleto.Controls.Add(this.lblcorrelativo);
            this.gcenviocompleto.Controls.Add(this.lblserie);
            this.gcenviocompleto.Location = new System.Drawing.Point(12, 12);
            this.gcenviocompleto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcenviocompleto.Name = "gcenviocompleto";
            this.gcenviocompleto.Size = new System.Drawing.Size(327, 232);
            this.gcenviocompleto.TabIndex = 0;
            this.gcenviocompleto.Text = "Información completa sobre envío";
            // 
            // tbcorrelativo
            // 
            this.tbcorrelativo.Location = new System.Drawing.Point(33, 134);
            this.tbcorrelativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcorrelativo.Name = "tbcorrelativo";
            this.tbcorrelativo.Size = new System.Drawing.Size(129, 20);
            this.tbcorrelativo.TabIndex = 2;
            // 
            // lbltienda
            // 
            this.lbltienda.Location = new System.Drawing.Point(33, 35);
            this.lbltienda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbltienda.Name = "lbltienda";
            this.lbltienda.Size = new System.Drawing.Size(32, 13);
            this.lbltienda.TabIndex = 6;
            this.lbltienda.Text = "Tienda";
            // 
            // luetienda
            // 
            this.luetienda.Location = new System.Drawing.Point(33, 53);
            this.luetienda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.luetienda.Name = "luetienda";
            this.luetienda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luetienda.Properties.DataSource = this.tiendaBindingSource;
            this.luetienda.Properties.DisplayMember = "nombre";
            this.luetienda.Properties.NullText = "Seleccione...";
            this.luetienda.Properties.ValueMember = "idtienda";
            this.luetienda.Size = new System.Drawing.Size(129, 20);
            this.luetienda.TabIndex = 0;
            this.luetienda.EditValueChanged += new System.EventHandler(this.luetienda_EditValueChanged);
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(33, 165);
            this.btngenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(81, 24);
            this.btngenerar.TabIndex = 3;
            this.btngenerar.Text = "Generar";
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // lueserie
            // 
            this.lueserie.Location = new System.Drawing.Point(33, 93);
            this.lueserie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueserie.Name = "lueserie";
            this.lueserie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueserie.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_serie", "id_serie", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("serie", "serie", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("correlativo", "correlativo", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_tipo_serie", "id_tipo_serie", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_tipo_documento", "id_tipo_documento", 118, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 43, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("fecha_creacion", "fecha_creacion", 96, DevExpress.Utils.FormatType.DateTime, "d/MM/yyyy", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_tienda", "id_tienda", 62, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_usuario_creacion", "id_usuario_creacion", 124, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueserie.Properties.DataSource = this.tblseriesBindingSource;
            this.lueserie.Properties.DisplayMember = "serie";
            this.lueserie.Properties.NullText = "Seleccione...";
            this.lueserie.Properties.ShowHeader = false;
            this.lueserie.Properties.ValueMember = "id_serie";
            this.lueserie.Size = new System.Drawing.Size(129, 20);
            this.lueserie.TabIndex = 1;
            this.lueserie.EditValueChanged += new System.EventHandler(this.lueserie_EditValueChanged);
            // 
            // lblcorrelativo
            // 
            this.lblcorrelativo.Location = new System.Drawing.Point(33, 116);
            this.lblcorrelativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblcorrelativo.Name = "lblcorrelativo";
            this.lblcorrelativo.Size = new System.Drawing.Size(53, 13);
            this.lblcorrelativo.TabIndex = 1;
            this.lblcorrelativo.Text = "Correlativo";
            // 
            // lblserie
            // 
            this.lblserie.Location = new System.Drawing.Point(33, 76);
            this.lblserie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(53, 13);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "Serie envío";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(351, 256);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcenviocompleto;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(331, 236);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // tiendaBindingSource
            // 
            this.tiendaBindingSource.DataMember = "Tienda";
            this.tiendaBindingSource.DataSource = this.dbSoftwareGTDataSet;
            // 
            // dbSoftwareGTDataSet
            // 
            this.dbSoftwareGTDataSet.DataSetName = "dbSoftwareGTDataSet";
            this.dbSoftwareGTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblseriesBindingSource
            // 
            this.tblseriesBindingSource.DataMember = "tbl_series";
            this.tblseriesBindingSource.DataSource = this.dbSoftwareGTDataSet;
            // 
            // tbl_seriesTableAdapter
            // 
            this.tbl_seriesTableAdapter.ClearBeforeFill = true;
            // 
            // tiendaTableAdapter
            // 
            this.tiendaTableAdapter.ClearBeforeFill = true;
            // 
            // EnvioCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 256);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EnvioCompleto";
            this.Text = "EnvioCompleto";
            this.Load += new System.EventHandler(this.EnvioCompleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcenviocompleto)).EndInit();
            this.gcenviocompleto.ResumeLayout(false);
            this.gcenviocompleto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbcorrelativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetienda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueserie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblseriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl gcenviocompleto;
        private DevExpress.XtraEditors.LookUpEdit lueserie;
        private DevExpress.XtraEditors.LabelControl lblcorrelativo;
        private DevExpress.XtraEditors.LabelControl lblserie;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private dbSoftwareGTDataSet dbSoftwareGTDataSet;
        private System.Windows.Forms.BindingSource tblseriesBindingSource;
        private dbSoftwareGTDataSetTableAdapters.tbl_seriesTableAdapter tbl_seriesTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btngenerar;
        private DevExpress.XtraEditors.LabelControl lbltienda;
        private DevExpress.XtraEditors.LookUpEdit luetienda;
        private System.Windows.Forms.BindingSource tiendaBindingSource;
        private dbSoftwareGTDataSetTableAdapters.TiendaTableAdapter tiendaTableAdapter;
        private DevExpress.XtraEditors.TextEdit tbcorrelativo;
    }
}