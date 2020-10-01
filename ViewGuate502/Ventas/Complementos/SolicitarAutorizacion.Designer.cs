namespace ViewGuate502.Ventas.Complementos
{
    partial class SolicitarAutorizacion
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
            this.gcautorizacion = new DevExpress.XtraEditors.GroupControl();
            this.btnvalidar = new DevExpress.XtraEditors.SimpleButton();
            this.lblvalidacion = new System.Windows.Forms.Label();
            this.tbtextovalidacion = new DevExpress.XtraEditors.TextEdit();
            this.btnenviarcorreo = new DevExpress.XtraEditors.SimpleButton();
            this.cbtipoautorizacion = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcautorizacion)).BeginInit();
            this.gcautorizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtextovalidacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcautorizacion);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(491, 311);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcautorizacion
            // 
            this.gcautorizacion.Controls.Add(this.btnvalidar);
            this.gcautorizacion.Controls.Add(this.lblvalidacion);
            this.gcautorizacion.Controls.Add(this.tbtextovalidacion);
            this.gcautorizacion.Controls.Add(this.btnenviarcorreo);
            this.gcautorizacion.Controls.Add(this.cbtipoautorizacion);
            this.gcautorizacion.Location = new System.Drawing.Point(12, 12);
            this.gcautorizacion.Name = "gcautorizacion";
            this.gcautorizacion.Size = new System.Drawing.Size(467, 287);
            this.gcautorizacion.TabIndex = 4;
            this.gcautorizacion.Text = "Autorización crédito";
            // 
            // btnvalidar
            // 
            this.btnvalidar.Location = new System.Drawing.Point(5, 130);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(94, 29);
            this.btnvalidar.TabIndex = 4;
            this.btnvalidar.Text = "Validar";
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // lblvalidacion
            // 
            this.lblvalidacion.AutoSize = true;
            this.lblvalidacion.Location = new System.Drawing.Point(5, 82);
            this.lblvalidacion.Name = "lblvalidacion";
            this.lblvalidacion.Size = new System.Drawing.Size(0, 17);
            this.lblvalidacion.TabIndex = 3;
            // 
            // tbtextovalidacion
            // 
            this.tbtextovalidacion.Location = new System.Drawing.Point(5, 102);
            this.tbtextovalidacion.Name = "tbtextovalidacion";
            this.tbtextovalidacion.Size = new System.Drawing.Size(164, 22);
            this.tbtextovalidacion.TabIndex = 2;
            this.tbtextovalidacion.EditValueChanged += new System.EventHandler(this.tbtextovalidacion_EditValueChanged);
            // 
            // btnenviarcorreo
            // 
            this.btnenviarcorreo.Location = new System.Drawing.Point(271, 37);
            this.btnenviarcorreo.Name = "btnenviarcorreo";
            this.btnenviarcorreo.Size = new System.Drawing.Size(119, 29);
            this.btnenviarcorreo.TabIndex = 1;
            this.btnenviarcorreo.Text = "Enviar correo";
            this.btnenviarcorreo.Click += new System.EventHandler(this.btnenviarcorreo_Click);
            // 
            // cbtipoautorizacion
            // 
            this.cbtipoautorizacion.FormattingEnabled = true;
            this.cbtipoautorizacion.Items.AddRange(new object[] {
            "Contraseña",
            "Correo"});
            this.cbtipoautorizacion.Location = new System.Drawing.Point(5, 41);
            this.cbtipoautorizacion.Name = "cbtipoautorizacion";
            this.cbtipoautorizacion.Size = new System.Drawing.Size(251, 24);
            this.cbtipoautorizacion.TabIndex = 0;
            this.cbtipoautorizacion.Text = "Seleccione el tipo de autorización...";
            this.cbtipoautorizacion.SelectedIndexChanged += new System.EventHandler(this.cbtipoautorizacion_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(491, 311);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcautorizacion;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(471, 291);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // SolicitarAutorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 311);
            this.Controls.Add(this.layoutControl1);
            this.Name = "SolicitarAutorizacion";
            this.Text = "SolicitarAutorizacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SolicitarAutorizacion_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcautorizacion)).EndInit();
            this.gcautorizacion.ResumeLayout(false);
            this.gcautorizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtextovalidacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl gcautorizacion;
        private System.Windows.Forms.ComboBox cbtipoautorizacion;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Label lblvalidacion;
        private DevExpress.XtraEditors.TextEdit tbtextovalidacion;
        private DevExpress.XtraEditors.SimpleButton btnenviarcorreo;
        private DevExpress.XtraEditors.SimpleButton btnvalidar;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}