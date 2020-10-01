namespace ViewGuate502.Auditoria.Documentacion
{
    partial class AprobarEnvio
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblaprobacion = new DevExpress.XtraEditors.LabelControl();
            this.lueautorizacion = new DevExpress.XtraEditors.LookUpEdit();
            this.lblcomentarios = new DevExpress.XtraEditors.LabelControl();
            this.btnaprobar = new DevExpress.XtraEditors.SimpleButton();
            this.btnrevision = new DevExpress.XtraEditors.SimpleButton();
            this.mecomentarioaprobacion = new DevExpress.XtraEditors.MemoEdit();
            this.lblenvio = new DevExpress.XtraEditors.LabelControl();
            this.tbenvio = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueautorizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecomentarioaprobacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbenvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(637, 440);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(637, 440);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblaprobacion);
            this.groupControl1.Controls.Add(this.lueautorizacion);
            this.groupControl1.Controls.Add(this.lblcomentarios);
            this.groupControl1.Controls.Add(this.btnaprobar);
            this.groupControl1.Controls.Add(this.btnrevision);
            this.groupControl1.Controls.Add(this.mecomentarioaprobacion);
            this.groupControl1.Controls.Add(this.lblenvio);
            this.groupControl1.Controls.Add(this.tbenvio);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(613, 416);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Aprobar envío";
            // 
            // lblaprobacion
            // 
            this.lblaprobacion.Location = new System.Drawing.Point(20, 101);
            this.lblaprobacion.Name = "lblaprobacion";
            this.lblaprobacion.Size = new System.Drawing.Size(164, 16);
            this.lblaprobacion.TabIndex = 7;
            this.lblaprobacion.Text = "¿Se autorizó correctamente?";
            // 
            // lueautorizacion
            // 
            this.lueautorizacion.Location = new System.Drawing.Point(20, 123);
            this.lueautorizacion.Name = "lueautorizacion";
            this.lueautorizacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueautorizacion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Key"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueautorizacion.Properties.NullText = "Seleccione...";
            this.lueautorizacion.Properties.ShowHeader = false;
            this.lueautorizacion.Size = new System.Drawing.Size(125, 22);
            this.lueautorizacion.TabIndex = 6;
            // 
            // lblcomentarios
            // 
            this.lblcomentarios.Location = new System.Drawing.Point(20, 151);
            this.lblcomentarios.Name = "lblcomentarios";
            this.lblcomentarios.Size = new System.Drawing.Size(72, 16);
            this.lblcomentarios.TabIndex = 5;
            this.lblcomentarios.Text = "Comentarios";
            // 
            // btnaprobar
            // 
            this.btnaprobar.Location = new System.Drawing.Point(484, 357);
            this.btnaprobar.Name = "btnaprobar";
            this.btnaprobar.Size = new System.Drawing.Size(94, 29);
            this.btnaprobar.TabIndex = 4;
            this.btnaprobar.Text = "Aprobar";
            this.btnaprobar.Click += new System.EventHandler(this.btnaprobar_Click);
            // 
            // btnrevision
            // 
            this.btnrevision.Location = new System.Drawing.Point(347, 357);
            this.btnrevision.Name = "btnrevision";
            this.btnrevision.Size = new System.Drawing.Size(131, 29);
            this.btnrevision.TabIndex = 3;
            this.btnrevision.Text = "En revisión";
            this.btnrevision.Click += new System.EventHandler(this.btnrevision_Click);
            // 
            // mecomentarioaprobacion
            // 
            this.mecomentarioaprobacion.Location = new System.Drawing.Point(20, 173);
            this.mecomentarioaprobacion.Name = "mecomentarioaprobacion";
            this.mecomentarioaprobacion.Size = new System.Drawing.Size(558, 157);
            this.mecomentarioaprobacion.TabIndex = 2;
            // 
            // lblenvio
            // 
            this.lblenvio.Location = new System.Drawing.Point(20, 51);
            this.lblenvio.Name = "lblenvio";
            this.lblenvio.Size = new System.Drawing.Size(90, 16);
            this.lblenvio.TabIndex = 1;
            this.lblenvio.Text = "Envío a aprobar";
            // 
            // tbenvio
            // 
            this.tbenvio.Location = new System.Drawing.Point(20, 73);
            this.tbenvio.Name = "tbenvio";
            this.tbenvio.Properties.ReadOnly = true;
            this.tbenvio.Size = new System.Drawing.Size(125, 22);
            this.tbenvio.TabIndex = 0;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(617, 420);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // AprobarEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 440);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AprobarEnvio";
            this.Text = "AprobarEnvio";
            this.Load += new System.EventHandler(this.AprobarEnvio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueautorizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecomentarioaprobacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbenvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblaprobacion;
        private DevExpress.XtraEditors.LookUpEdit lueautorizacion;
        private DevExpress.XtraEditors.LabelControl lblcomentarios;
        private DevExpress.XtraEditors.SimpleButton btnaprobar;
        private DevExpress.XtraEditors.SimpleButton btnrevision;
        private DevExpress.XtraEditors.MemoEdit mecomentarioaprobacion;
        private DevExpress.XtraEditors.LabelControl lblenvio;
        private DevExpress.XtraEditors.TextEdit tbenvio;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}