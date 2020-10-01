namespace ViewGuate502.Auditoria
{
    partial class DetalleAprobacion
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblaprobacion = new DevExpress.XtraEditors.LabelControl();
            this.lueautorizacion = new DevExpress.XtraEditors.LookUpEdit();
            this.lblcomentariossup = new DevExpress.XtraEditors.LabelControl();
            this.mecomentariossupervisor = new DevExpress.XtraEditors.MemoEdit();
            this.lblcomentarios = new DevExpress.XtraEditors.LabelControl();
            this.btnaprobar = new DevExpress.XtraEditors.SimpleButton();
            this.btnrevision = new DevExpress.XtraEditors.SimpleButton();
            this.mecomentarioaprobacion = new DevExpress.XtraEditors.MemoEdit();
            this.lblenvio = new DevExpress.XtraEditors.LabelControl();
            this.tbenvio = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueautorizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecomentariossupervisor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecomentarioaprobacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbenvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(554, 520);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblaprobacion);
            this.groupControl1.Controls.Add(this.lueautorizacion);
            this.groupControl1.Controls.Add(this.lblcomentariossup);
            this.groupControl1.Controls.Add(this.mecomentariossupervisor);
            this.groupControl1.Controls.Add(this.lblcomentarios);
            this.groupControl1.Controls.Add(this.btnaprobar);
            this.groupControl1.Controls.Add(this.btnrevision);
            this.groupControl1.Controls.Add(this.mecomentarioaprobacion);
            this.groupControl1.Controls.Add(this.lblenvio);
            this.groupControl1.Controls.Add(this.tbenvio);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(530, 496);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "APROBAR ENVÍO";
            // 
            // lblaprobacion
            // 
            this.lblaprobacion.Location = new System.Drawing.Point(17, 82);
            this.lblaprobacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblaprobacion.Name = "lblaprobacion";
            this.lblaprobacion.Size = new System.Drawing.Size(169, 13);
            this.lblaprobacion.TabIndex = 9;
            this.lblaprobacion.Text = "¿SE AUTORIZÓ CORRECTAMENTE?";
            // 
            // lueautorizacion
            // 
            this.lueautorizacion.Location = new System.Drawing.Point(17, 100);
            this.lueautorizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueautorizacion.Name = "lueautorizacion";
            this.lueautorizacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueautorizacion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Key"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueautorizacion.Properties.NullText = "SELECCIONE...";
            this.lueautorizacion.Properties.ShowHeader = false;
            this.lueautorizacion.Size = new System.Drawing.Size(107, 20);
            this.lueautorizacion.TabIndex = 8;
            // 
            // lblcomentariossup
            // 
            this.lblcomentariossup.Location = new System.Drawing.Point(17, 285);
            this.lblcomentariossup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblcomentariossup.Name = "lblcomentariossup";
            this.lblcomentariossup.Size = new System.Drawing.Size(161, 13);
            this.lblcomentariossup.TabIndex = 7;
            this.lblcomentariossup.Text = "COMENTARIOS DEL SUPERVISOR";
            // 
            // mecomentariossupervisor
            // 
            this.mecomentariossupervisor.Location = new System.Drawing.Point(17, 303);
            this.mecomentariossupervisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mecomentariossupervisor.Name = "mecomentariossupervisor";
            this.mecomentariossupervisor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mecomentariossupervisor.Size = new System.Drawing.Size(478, 128);
            this.mecomentariossupervisor.TabIndex = 6;
            // 
            // lblcomentarios
            // 
            this.lblcomentarios.Location = new System.Drawing.Point(17, 123);
            this.lblcomentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblcomentarios.Name = "lblcomentarios";
            this.lblcomentarios.Size = new System.Drawing.Size(74, 13);
            this.lblcomentarios.TabIndex = 5;
            this.lblcomentarios.Text = "COMENTARIOS";
            // 
            // btnaprobar
            // 
            this.btnaprobar.Location = new System.Drawing.Point(415, 456);
            this.btnaprobar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaprobar.Name = "btnaprobar";
            this.btnaprobar.Size = new System.Drawing.Size(81, 24);
            this.btnaprobar.TabIndex = 4;
            this.btnaprobar.Text = "APROBAR";
            this.btnaprobar.Click += new System.EventHandler(this.btnaprobar_Click);
            // 
            // btnrevision
            // 
            this.btnrevision.Location = new System.Drawing.Point(249, 456);
            this.btnrevision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrevision.Name = "btnrevision";
            this.btnrevision.Size = new System.Drawing.Size(160, 24);
            this.btnrevision.TabIndex = 3;
            this.btnrevision.Text = "ESCALAR A SUPERVISOR";
            // 
            // mecomentarioaprobacion
            // 
            this.mecomentarioaprobacion.Location = new System.Drawing.Point(17, 141);
            this.mecomentarioaprobacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mecomentarioaprobacion.Name = "mecomentarioaprobacion";
            this.mecomentarioaprobacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mecomentarioaprobacion.Size = new System.Drawing.Size(478, 128);
            this.mecomentarioaprobacion.TabIndex = 2;
            // 
            // lblenvio
            // 
            this.lblenvio.Location = new System.Drawing.Point(17, 41);
            this.lblenvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblenvio.Name = "lblenvio";
            this.lblenvio.Size = new System.Drawing.Size(92, 13);
            this.lblenvio.TabIndex = 1;
            this.lblenvio.Text = "ENVÍO A APROBAR";
            // 
            // tbenvio
            // 
            this.tbenvio.Location = new System.Drawing.Point(17, 59);
            this.tbenvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbenvio.Name = "tbenvio";
            this.tbenvio.Properties.ReadOnly = true;
            this.tbenvio.Size = new System.Drawing.Size(107, 20);
            this.tbenvio.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(554, 520);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(534, 500);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // DetalleAprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 520);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DetalleAprobacion";
            this.Text = "DETALLE APROBACIÓN";
            this.Load += new System.EventHandler(this.DetalleAprobacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueautorizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecomentariossupervisor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mecomentarioaprobacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbenvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblcomentariossup;
        private DevExpress.XtraEditors.MemoEdit mecomentariossupervisor;
        private DevExpress.XtraEditors.LabelControl lblcomentarios;
        private DevExpress.XtraEditors.SimpleButton btnaprobar;
        private DevExpress.XtraEditors.SimpleButton btnrevision;
        private DevExpress.XtraEditors.MemoEdit mecomentarioaprobacion;
        private DevExpress.XtraEditors.LabelControl lblenvio;
        private DevExpress.XtraEditors.TextEdit tbenvio;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl lblaprobacion;
        private DevExpress.XtraEditors.LookUpEdit lueautorizacion;
    }
}