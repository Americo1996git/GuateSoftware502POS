namespace ViewGuate502.Cobros
{
    partial class FormModalObservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModalObservaciones));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtNumeroCuota = new DevExpress.XtraEditors.TextEdit();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.gridControlObservacionesCuota = new DevExpress.XtraGrid.GridControl();
            this.gridViewObservacionesCuota = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroCuota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlObservacionesCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewObservacionesCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonControl1.ApplicationButtonImageOptions.Image")));
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(781, 60);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Controls.Add(this.txtNumeroCuota);
            this.layoutControl1.Controls.Add(this.btnAgregar);
            this.layoutControl1.Controls.Add(this.txtDescripcion);
            this.layoutControl1.Controls.Add(this.gridControlObservacionesCuota);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 60);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(781, 524);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(267, 476);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 36);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "[Esc] Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNumeroCuota
            // 
            this.txtNumeroCuota.Location = new System.Drawing.Point(95, 49);
            this.txtNumeroCuota.MenuManager = this.ribbonControl1;
            this.txtNumeroCuota.Name = "txtNumeroCuota";
            this.txtNumeroCuota.Properties.ReadOnly = true;
            this.txtNumeroCuota.Size = new System.Drawing.Size(60, 20);
            this.txtNumeroCuota.StyleController = this.layoutControl1;
            this.txtNumeroCuota.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(396, 476);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 36);
            this.btnAgregar.StyleController = this.layoutControl1;
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(95, 73);
            this.txtDescripcion.MenuManager = this.ribbonControl1;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(662, 20);
            this.txtDescripcion.StyleController = this.layoutControl1;
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // gridControlObservacionesCuota
            // 
            this.gridControlObservacionesCuota.Location = new System.Drawing.Point(24, 97);
            this.gridControlObservacionesCuota.MainView = this.gridViewObservacionesCuota;
            this.gridControlObservacionesCuota.MenuManager = this.ribbonControl1;
            this.gridControlObservacionesCuota.Name = "gridControlObservacionesCuota";
            this.gridControlObservacionesCuota.Size = new System.Drawing.Size(733, 363);
            this.gridControlObservacionesCuota.TabIndex = 5;
            this.gridControlObservacionesCuota.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewObservacionesCuota});
            // 
            // gridViewObservacionesCuota
            // 
            this.gridViewObservacionesCuota.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn1});
            this.gridViewObservacionesCuota.GridControl = this.gridControlObservacionesCuota;
            this.gridViewObservacionesCuota.Name = "gridViewObservacionesCuota";
            this.gridViewObservacionesCuota.OptionsView.ColumnAutoWidth = false;
            this.gridViewObservacionesCuota.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha de creación";
            this.gridColumn3.FieldName = "fecha_creacion";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Descripción";
            this.gridColumn4.FieldName = "descripcion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Usuario responsable";
            this.gridColumn1.FieldName = "usuario";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(781, 524);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(761, 464);
            this.layoutControlGroup4.Text = "Observaciones de cuota";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlObservacionesCuota;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(737, 367);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtDescripcion;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(737, 24);
            this.layoutControlItem3.Text = "Descripción";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtNumeroCuota;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(135, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(135, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(135, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Cuota número";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(68, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(135, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(602, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnCancelar;
            this.layoutControlItem5.Location = new System.Drawing.Point(255, 464);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(129, 40);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(129, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(129, 40);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnAgregar;
            this.layoutControlItem4.Location = new System.Drawing.Point(384, 464);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(126, 40);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(126, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(126, 40);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 464);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(255, 40);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(510, 464);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(251, 40);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormModalObservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 584);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.KeyPreview = true;
            this.Name = "FormModalObservaciones";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregando observaciones";
            this.Activated += new System.EventHandler(this.FormModalObservaciones_Activated);
            this.Load += new System.EventHandler(this.FormModalObservaciones_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormModalObservaciones_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroCuota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlObservacionesCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewObservacionesCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraGrid.GridControl gridControlObservacionesCuota;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewObservacionesCuota;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.TextEdit txtNumeroCuota;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}