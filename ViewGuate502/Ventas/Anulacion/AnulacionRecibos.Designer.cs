﻿namespace ViewGuate502.Ventas.Anulacion
{
    partial class AnulacionRecibos
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
            this.gcanulacionenvios = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDetalleDePago = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetallePago = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueserie = new DevExpress.XtraEditors.LookUpEdit();
            this.btnimprimirenvio = new DevExpress.XtraEditors.SimpleButton();
            this.tbmontofactura = new DevExpress.XtraEditors.TextEdit();
            this.tbcliente = new DevExpress.XtraEditors.TextEdit();
            this.tbcorrelativoenvio = new DevExpress.XtraEditors.TextEdit();
            this.tbserieenvio = new DevExpress.XtraEditors.TextEdit();
            this.tbenvio = new DevExpress.XtraEditors.TextEdit();
            this.lblmontofactura = new DevExpress.XtraEditors.LabelControl();
            this.lblnombrecliente = new DevExpress.XtraEditors.LabelControl();
            this.lblcorrelativoenvio = new DevExpress.XtraEditors.LabelControl();
            this.lblserieenvio = new DevExpress.XtraEditors.LabelControl();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.tbcorrelativo = new DevExpress.XtraEditors.TextEdit();
            this.lblcorrelativo = new System.Windows.Forms.Label();
            this.lblserie = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Root1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcanulacionenvios)).BeginInit();
            this.gcanulacionenvios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleDePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetallePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueserie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmontofactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcorrelativoenvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbserieenvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbenvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcorrelativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcanulacionenvios);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(807, 382, 812, 500);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(475, 468);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcanulacionenvios
            // 
            this.gcanulacionenvios.Controls.Add(this.gridControlDetalleDePago);
            this.gcanulacionenvios.Controls.Add(this.lueserie);
            this.gcanulacionenvios.Controls.Add(this.btnimprimirenvio);
            this.gcanulacionenvios.Controls.Add(this.tbmontofactura);
            this.gcanulacionenvios.Controls.Add(this.tbcliente);
            this.gcanulacionenvios.Controls.Add(this.tbcorrelativoenvio);
            this.gcanulacionenvios.Controls.Add(this.tbserieenvio);
            this.gcanulacionenvios.Controls.Add(this.tbenvio);
            this.gcanulacionenvios.Controls.Add(this.lblmontofactura);
            this.gcanulacionenvios.Controls.Add(this.lblnombrecliente);
            this.gcanulacionenvios.Controls.Add(this.lblcorrelativoenvio);
            this.gcanulacionenvios.Controls.Add(this.lblserieenvio);
            this.gcanulacionenvios.Controls.Add(this.btnbuscar);
            this.gcanulacionenvios.Controls.Add(this.tbcorrelativo);
            this.gcanulacionenvios.Controls.Add(this.lblcorrelativo);
            this.gcanulacionenvios.Controls.Add(this.lblserie);
            this.gcanulacionenvios.Location = new System.Drawing.Point(22, 22);
            this.gcanulacionenvios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcanulacionenvios.Name = "gcanulacionenvios";
            this.gcanulacionenvios.Size = new System.Drawing.Size(431, 424);
            this.gcanulacionenvios.TabIndex = 0;
            this.gcanulacionenvios.Text = "Anulación de recibos";
            // 
            // gridControlDetalleDePago
            // 
            this.gridControlDetalleDePago.Location = new System.Drawing.Point(214, 115);
            this.gridControlDetalleDePago.MainView = this.gridViewDetallePago;
            this.gridControlDetalleDePago.Name = "gridControlDetalleDePago";
            this.gridControlDetalleDePago.Size = new System.Drawing.Size(201, 288);
            this.gridControlDetalleDePago.TabIndex = 15;
            this.gridControlDetalleDePago.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetallePago});
            this.gridControlDetalleDePago.Visible = false;
            // 
            // gridViewDetallePago
            // 
            this.gridViewDetallePago.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewDetallePago.GridControl = this.gridControlDetalleDePago;
            this.gridViewDetallePago.Name = "gridViewDetallePago";
            this.gridViewDetallePago.OptionsView.ColumnAutoWidth = false;
            this.gridViewDetallePago.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "CUOTA";
            this.gridColumn1.FieldName = "cuota";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "MONTO";
            this.gridColumn2.FieldName = "monto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // lueserie
            // 
            this.lueserie.Location = new System.Drawing.Point(83, 37);
            this.lueserie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueserie.Name = "lueserie";
            this.lueserie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueserie.Properties.NullText = "Seleccione...";
            this.lueserie.Size = new System.Drawing.Size(107, 20);
            this.lueserie.TabIndex = 0;
            // 
            // btnimprimirenvio
            // 
            this.btnimprimirenvio.Location = new System.Drawing.Point(14, 275);
            this.btnimprimirenvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnimprimirenvio.Name = "btnimprimirenvio";
            this.btnimprimirenvio.Size = new System.Drawing.Size(110, 24);
            this.btnimprimirenvio.TabIndex = 8;
            this.btnimprimirenvio.Text = "Anular recibo";
            this.btnimprimirenvio.Click += new System.EventHandler(this.btnimprimirenvio_Click);
            // 
            // tbmontofactura
            // 
            this.tbmontofactura.Enabled = false;
            this.tbmontofactura.Location = new System.Drawing.Point(92, 240);
            this.tbmontofactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmontofactura.Name = "tbmontofactura";
            this.tbmontofactura.Size = new System.Drawing.Size(107, 20);
            this.tbmontofactura.TabIndex = 7;
            // 
            // tbcliente
            // 
            this.tbcliente.Enabled = false;
            this.tbcliente.Location = new System.Drawing.Point(92, 210);
            this.tbcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcliente.Name = "tbcliente";
            this.tbcliente.Size = new System.Drawing.Size(107, 20);
            this.tbcliente.TabIndex = 6;
            // 
            // tbcorrelativoenvio
            // 
            this.tbcorrelativoenvio.Enabled = false;
            this.tbcorrelativoenvio.Location = new System.Drawing.Point(92, 178);
            this.tbcorrelativoenvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcorrelativoenvio.Name = "tbcorrelativoenvio";
            this.tbcorrelativoenvio.Size = new System.Drawing.Size(107, 20);
            this.tbcorrelativoenvio.TabIndex = 5;
            // 
            // tbserieenvio
            // 
            this.tbserieenvio.Enabled = false;
            this.tbserieenvio.Location = new System.Drawing.Point(92, 150);
            this.tbserieenvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbserieenvio.Name = "tbserieenvio";
            this.tbserieenvio.Size = new System.Drawing.Size(107, 20);
            this.tbserieenvio.TabIndex = 4;
            // 
            // tbenvio
            // 
            this.tbenvio.Enabled = false;
            this.tbenvio.Location = new System.Drawing.Point(92, 121);
            this.tbenvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbenvio.Name = "tbenvio";
            this.tbenvio.Size = new System.Drawing.Size(107, 20);
            this.tbenvio.TabIndex = 3;
            this.tbenvio.Visible = false;
            // 
            // lblmontofactura
            // 
            this.lblmontofactura.Location = new System.Drawing.Point(14, 243);
            this.lblmontofactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblmontofactura.Name = "lblmontofactura";
            this.lblmontofactura.Size = new System.Drawing.Size(62, 13);
            this.lblmontofactura.TabIndex = 9;
            this.lblmontofactura.Text = "Monto recibo";
            // 
            // lblnombrecliente
            // 
            this.lblnombrecliente.Location = new System.Drawing.Point(14, 212);
            this.lblnombrecliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblnombrecliente.Name = "lblnombrecliente";
            this.lblnombrecliente.Size = new System.Drawing.Size(33, 13);
            this.lblnombrecliente.TabIndex = 10;
            this.lblnombrecliente.Text = "Cliente";
            // 
            // lblcorrelativoenvio
            // 
            this.lblcorrelativoenvio.Location = new System.Drawing.Point(14, 180);
            this.lblcorrelativoenvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblcorrelativoenvio.Name = "lblcorrelativoenvio";
            this.lblcorrelativoenvio.Size = new System.Drawing.Size(53, 13);
            this.lblcorrelativoenvio.TabIndex = 11;
            this.lblcorrelativoenvio.Text = "Correlativo";
            // 
            // lblserieenvio
            // 
            this.lblserieenvio.Location = new System.Drawing.Point(14, 152);
            this.lblserieenvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblserieenvio.Name = "lblserieenvio";
            this.lblserieenvio.Size = new System.Drawing.Size(56, 13);
            this.lblserieenvio.TabIndex = 12;
            this.lblserieenvio.Text = "Serie recibo";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(225, 59);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(81, 24);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // tbcorrelativo
            // 
            this.tbcorrelativo.Location = new System.Drawing.Point(83, 65);
            this.tbcorrelativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcorrelativo.Name = "tbcorrelativo";
            this.tbcorrelativo.Size = new System.Drawing.Size(107, 20);
            this.tbcorrelativo.TabIndex = 1;
            // 
            // lblcorrelativo
            // 
            this.lblcorrelativo.AutoSize = true;
            this.lblcorrelativo.Location = new System.Drawing.Point(11, 69);
            this.lblcorrelativo.Name = "lblcorrelativo";
            this.lblcorrelativo.Size = new System.Drawing.Size(60, 13);
            this.lblcorrelativo.TabIndex = 13;
            this.lblcorrelativo.Text = "Correlativo";
            // 
            // lblserie
            // 
            this.lblserie.Location = new System.Drawing.Point(14, 42);
            this.lblserie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(24, 13);
            this.lblserie.TabIndex = 14;
            this.lblserie.Text = "Serie";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Root1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(475, 468);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // Root1
            // 
            this.Root1.CustomizationFormText = "Root";
            this.Root1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root1.GroupBordersVisible = false;
            this.Root1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root1.Location = new System.Drawing.Point(0, 0);
            this.Root1.Name = "Root1";
            this.Root1.Size = new System.Drawing.Size(455, 448);
            this.Root1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root1.Text = "Root";
            this.Root1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcanulacionenvios;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(435, 428);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // AnulacionRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 468);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnulacionRecibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anulación Recibos";
            this.Load += new System.EventHandler(this.AnulacionRecibos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcanulacionenvios)).EndInit();
            this.gcanulacionenvios.ResumeLayout(false);
            this.gcanulacionenvios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleDePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetallePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueserie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmontofactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcorrelativoenvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbserieenvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbenvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcorrelativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl gcanulacionenvios;
        private DevExpress.XtraEditors.LookUpEdit lueserie;
        private DevExpress.XtraEditors.SimpleButton btnimprimirenvio;
        private DevExpress.XtraEditors.TextEdit tbmontofactura;
        private DevExpress.XtraEditors.TextEdit tbcliente;
        private DevExpress.XtraEditors.TextEdit tbcorrelativoenvio;
        private DevExpress.XtraEditors.TextEdit tbserieenvio;
        private DevExpress.XtraEditors.TextEdit tbenvio;
        private DevExpress.XtraEditors.LabelControl lblmontofactura;
        private DevExpress.XtraEditors.LabelControl lblnombrecliente;
        private DevExpress.XtraEditors.LabelControl lblcorrelativoenvio;
        private DevExpress.XtraEditors.LabelControl lblserieenvio;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private DevExpress.XtraEditors.TextEdit tbcorrelativo;
        private System.Windows.Forms.Label lblcorrelativo;
        private DevExpress.XtraEditors.LabelControl lblserie;
        private DevExpress.XtraLayout.LayoutControlGroup Root1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControlDetalleDePago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetallePago;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}