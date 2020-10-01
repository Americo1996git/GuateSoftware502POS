namespace ViewGuate502.Anulaciones.DocumentosOperados
{
    partial class FormAnulaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnulaciones));
            this.gridControlDetalle = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seCorrelativo = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtOrgienDestino = new DevExpress.XtraEditors.TextEdit();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnular = new DevExpress.XtraEditors.SimpleButton();
            this.txtRazon = new DevExpress.XtraEditors.TextEdit();
            this.txtTipoDeDocumento = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCorrelativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrgienDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoDeDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDetalle
            // 
            this.gridControlDetalle.Location = new System.Drawing.Point(12, 36);
            this.gridControlDetalle.MainView = this.gridViewDetalle;
            this.gridControlDetalle.Name = "gridControlDetalle";
            this.gridControlDetalle.Size = new System.Drawing.Size(856, 371);
            this.gridControlDetalle.TabIndex = 70;
            this.gridControlDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalle});
            // 
            // gridViewDetalle
            // 
            this.gridViewDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewDetalle.GridControl = this.gridControlDetalle;
            this.gridViewDetalle.Name = "gridViewDetalle";
            this.gridViewDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "CODIGO";
            this.gridColumn1.FieldName = "codigo_producto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "PRODUCTO";
            this.gridColumn2.FieldName = "producto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "PRECIO A";
            this.gridColumn3.FieldName = "precioa";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "CANTIDAD";
            this.gridColumn4.FieldName = "cantidad";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // seCorrelativo
            // 
            this.seCorrelativo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seCorrelativo.Location = new System.Drawing.Point(86, 12);
            this.seCorrelativo.Name = "seCorrelativo";
            this.seCorrelativo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seCorrelativo.Properties.ReadOnly = true;
            this.seCorrelativo.Size = new System.Drawing.Size(136, 20);
            this.seCorrelativo.StyleController = this.layoutControl1;
            this.seCorrelativo.TabIndex = 73;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtOrgienDestino);
            this.layoutControl1.Controls.Add(this.btnSalir);
            this.layoutControl1.Controls.Add(this.btnAnular);
            this.layoutControl1.Controls.Add(this.txtRazon);
            this.layoutControl1.Controls.Add(this.seCorrelativo);
            this.layoutControl1.Controls.Add(this.txtTipoDeDocumento);
            this.layoutControl1.Controls.Add(this.gridControlDetalle);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(880, 483);
            this.layoutControl1.TabIndex = 77;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtOrgienDestino
            // 
            this.txtOrgienDestino.Location = new System.Drawing.Point(726, 12);
            this.txtOrgienDestino.Name = "txtOrgienDestino";
            this.txtOrgienDestino.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrgienDestino.Properties.ReadOnly = true;
            this.txtOrgienDestino.Size = new System.Drawing.Size(142, 20);
            this.txtOrgienDestino.StyleController = this.layoutControl1;
            this.txtOrgienDestino.TabIndex = 78;
            // 
            // btnSalir
            // 
            this.btnSalir.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.btnSalir.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.btnSalir.AppearanceHovered.Options.UseBackColor = true;
            this.btnSalir.AppearanceHovered.Options.UseBorderColor = true;
            this.btnSalir.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(182)))), ((int)(((byte)(191)))));
            this.btnSalir.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(182)))), ((int)(((byte)(191)))));
            this.btnSalir.AppearancePressed.Options.UseBackColor = true;
            this.btnSalir.AppearancePressed.Options.UseBorderColor = true;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(593, 435);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 36);
            this.btnSalir.StyleController = this.layoutControl1;
            this.btnSalir.TabIndex = 77;
            this.btnSalir.Text = "[ESC] CANCELAR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.ImageOptions.Image")));
            this.btnAnular.Location = new System.Drawing.Point(732, 435);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(136, 36);
            this.btnAnular.StyleController = this.layoutControl1;
            this.btnAnular.TabIndex = 75;
            this.btnAnular.Text = "[SUPR] ANULAR";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(52, 411);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazon.Size = new System.Drawing.Size(816, 20);
            this.txtRazon.StyleController = this.layoutControl1;
            this.txtRazon.TabIndex = 76;
            // 
            // txtTipoDeDocumento
            // 
            this.txtTipoDeDocumento.Location = new System.Drawing.Point(300, 12);
            this.txtTipoDeDocumento.Name = "txtTipoDeDocumento";
            this.txtTipoDeDocumento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoDeDocumento.Properties.ReadOnly = true;
            this.txtTipoDeDocumento.Size = new System.Drawing.Size(422, 20);
            this.txtTipoDeDocumento.StyleController = this.layoutControl1;
            this.txtTipoDeDocumento.TabIndex = 74;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(880, 483);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlDetalle;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(860, 375);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTipoDeDocumento;
            this.layoutControlItem2.Location = new System.Drawing.Point(214, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(500, 24);
            this.layoutControlItem2.Text = "DOCUMENTO";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.seCorrelativo;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(214, 24);
            this.layoutControlItem3.Text = "CORRELATIVO";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtRazon;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 399);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(860, 24);
            this.layoutControlItem5.Text = "RAZÓN";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(35, 13);
            this.layoutControlItem5.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnSalir;
            this.layoutControlItem7.Location = new System.Drawing.Point(581, 423);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(139, 40);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(139, 40);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(139, 40);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnAnular;
            this.layoutControlItem6.Location = new System.Drawing.Point(720, 423);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(140, 40);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(140, 40);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(140, 40);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 423);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(581, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtOrgienDestino;
            this.layoutControlItem4.Location = new System.Drawing.Point(714, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(146, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // FormAnulaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 483);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormAnulaciones";
            this.Text = "ANULAR DOCUMENTO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAnulaciones_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAnulaciones_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCorrelativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOrgienDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoDeDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalle;
        public DevExpress.XtraEditors.SpinEdit seCorrelativo;
        public DevExpress.XtraEditors.TextEdit txtTipoDeDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        public DevExpress.XtraGrid.GridControl gridControlDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnAnular;
        public DevExpress.XtraEditors.TextEdit txtRazon;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit txtOrgienDestino;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}