namespace ViewGuate502.Ventas.Consultas
{
    partial class HistoricoSeries
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
            this.gchistoricoseries = new DevExpress.XtraEditors.GroupControl();
            this.btndetalle = new DevExpress.XtraEditors.SimpleButton();
            this.gclistadoseries = new DevExpress.XtraGrid.GridControl();
            this.gvlistadoseries = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.lblserie = new DevExpress.XtraEditors.LabelControl();
            this.tbserie = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gchistoricoseries)).BeginInit();
            this.gchistoricoseries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadoseries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadoseries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbserie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gchistoricoseries);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(741, 473);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gchistoricoseries
            // 
            this.gchistoricoseries.Controls.Add(this.btndetalle);
            this.gchistoricoseries.Controls.Add(this.gclistadoseries);
            this.gchistoricoseries.Controls.Add(this.btnbuscar);
            this.gchistoricoseries.Controls.Add(this.lblserie);
            this.gchistoricoseries.Controls.Add(this.tbserie);
            this.gchistoricoseries.Location = new System.Drawing.Point(11, 10);
            this.gchistoricoseries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gchistoricoseries.Name = "gchistoricoseries";
            this.gchistoricoseries.Size = new System.Drawing.Size(719, 453);
            this.gchistoricoseries.TabIndex = 0;
            this.gchistoricoseries.Text = "Histórico series";
            // 
            // btndetalle
            // 
            this.btndetalle.Location = new System.Drawing.Point(620, 375);
            this.btndetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(81, 24);
            this.btndetalle.TabIndex = 3;
            this.btndetalle.Text = "Ver detalle";
            this.btndetalle.Click += new System.EventHandler(this.btndetalle_Click);
            // 
            // gclistadoseries
            // 
            this.gclistadoseries.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gclistadoseries.Location = new System.Drawing.Point(18, 104);
            this.gclistadoseries.MainView = this.gvlistadoseries;
            this.gclistadoseries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gclistadoseries.Name = "gclistadoseries";
            this.gclistadoseries.Size = new System.Drawing.Size(682, 256);
            this.gclistadoseries.TabIndex = 2;
            this.gclistadoseries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlistadoseries});
            // 
            // gvlistadoseries
            // 
            this.gvlistadoseries.DetailHeight = 284;
            this.gvlistadoseries.GridControl = this.gclistadoseries;
            this.gvlistadoseries.Name = "gvlistadoseries";
            this.gvlistadoseries.OptionsBehavior.Editable = false;
            this.gvlistadoseries.OptionsBehavior.ReadOnly = true;
            this.gvlistadoseries.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvlistadoseries.OptionsView.ShowGroupPanel = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(247, 56);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(69, 24);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblserie
            // 
            this.lblserie.Location = new System.Drawing.Point(18, 44);
            this.lblserie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(44, 13);
            this.lblserie.TabIndex = 1;
            this.lblserie.Text = "No. Serie";
            // 
            // tbserie
            // 
            this.tbserie.Location = new System.Drawing.Point(18, 62);
            this.tbserie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbserie.Name = "tbserie";
            this.tbserie.Size = new System.Drawing.Size(224, 20);
            this.tbserie.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(741, 473);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gchistoricoseries;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(723, 457);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // HistoricoSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 473);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HistoricoSeries";
            this.Text = "HistoricoSeries";
            this.Load += new System.EventHandler(this.HistoricoSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gchistoricoseries)).EndInit();
            this.gchistoricoseries.ResumeLayout(false);
            this.gchistoricoseries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclistadoseries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistadoseries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbserie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl gchistoricoseries;
        private DevExpress.XtraEditors.SimpleButton btndetalle;
        private DevExpress.XtraGrid.GridControl gclistadoseries;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlistadoseries;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private DevExpress.XtraEditors.LabelControl lblserie;
        private DevExpress.XtraEditors.TextEdit tbserie;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}