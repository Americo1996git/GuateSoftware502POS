namespace ViewGuate502.Cuadres
{
    partial class ReporteIngresosSalidasCuADRE
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.detailTable = new DevExpress.XtraReports.UI.XRTable();
            this.detailTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.quantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.totalTable = new DevExpress.XtraReports.UI.XRTable();
            this.totalRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.totalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.total = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.dataSetReportes1 = new ViewGuate502.DataSetReportes();
            this.sPMostrar_ReporteCatalogoProductosTableAdapter = new ViewGuate502.DataSetReportesTableAdapters.SPMostrar_ReporteCatalogoProductosTableAdapter();
            this.spMostrar_ReporteCuadreDeDiaTableAdapter1 = new ViewGuate502.DataSetReportesTableAdapters.SPMostrar_ReporteCuadreDeDiaTableAdapter();
            this.tienda = new DevExpress.XtraReports.Parameters.Parameter();
            this.fecha_emision = new DevExpress.XtraReports.Parameters.Parameter();
            this.fecha_inicial = new DevExpress.XtraReports.Parameters.Parameter();
            this.fecha_final = new DevExpress.XtraReports.Parameters.Parameter();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.detailTable});
            this.Detail.HeightF = 23F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // detailTable
            // 
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.detailTable.Name = "detailTable";
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow});
            this.detailTable.SizeF = new System.Drawing.SizeF(826F, 23F);
            this.detailTable.StylePriority.UseFont = false;
            // 
            // detailTableRow
            // 
            this.detailTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.quantity,
            this.unitPrice,
            this.xrTableCell4,
            this.lineTotal,
            this.xrTableCell1,
            this.xrTableCell2});
            this.detailTableRow.Name = "detailTableRow";
            this.detailTableRow.Weight = 10.58D;
            // 
            // quantity
            // 
            this.quantity.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.quantity.Name = "quantity";
            this.quantity.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.quantity.StylePriority.UseBorders = false;
            this.quantity.StylePriority.UsePadding = false;
            this.quantity.StylePriority.UseTextAlignment = false;
            this.quantity.Text = "EFECTIVO";
            this.quantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.quantity.Weight = 0.40579607467321704D;
            // 
            // unitPrice
            // 
            this.unitPrice.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.unitPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[total_entrada]")});
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.unitPrice.StylePriority.UseBorders = false;
            this.unitPrice.StylePriority.UsePadding = false;
            this.unitPrice.StylePriority.UseTextAlignment = false;
            this.unitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.unitPrice.TextFormatString = "{0:0.00}";
            this.unitPrice.Weight = 0.50107668031157759D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "GASTOS:";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 0.43609018786536929D;
            // 
            // lineTotal
            // 
            this.lineTotal.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lineTotal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[total_salida]")});
            this.lineTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lineTotal.Name = "lineTotal";
            this.lineTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.lineTotal.StylePriority.UseBorders = false;
            this.lineTotal.StylePriority.UseFont = false;
            this.lineTotal.StylePriority.UseForeColor = false;
            this.lineTotal.StylePriority.UsePadding = false;
            this.lineTotal.StylePriority.UseTextAlignment = false;
            this.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lineTotal.TextFormatString = "{0:0.00}";
            this.lineTotal.Weight = 0.51435530124961237D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "TOTAL POR USUARIO";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.51865778449049293D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[total_entrada]-[total_salida]")});
            this.xrTableCell2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.33623834530123176D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 14F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 8.09896F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel4,
            this.xrPageInfo1,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 83.83334F;
            this.GroupHeader2.Level = 2;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StyleName = "baseControlStyle";
            this.GroupHeader2.StylePriority.UseBackColor = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?fecha_final")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(137.5F, 46F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(132.2917F, 23F);
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextFormatString = "AL: {0:d}";
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?fecha_inicial")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 46F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(137.5F, 23F);
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextFormatString = "DEL: {0:d}";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(576F, 23F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(250F, 23F);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrPageInfo1.TextFormatString = "PAGINA {0} DE {1}";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?fecha_emision")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(576F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(250F, 23F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel3.TextFormatString = "FECHA EMISIÓN: {0:d}";
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(492.7084F, 23F);
            this.xrLabel2.Text = "REPORTE DE INGRESOS Y SALIDAS PARA CUADRE DEL DÍA";
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?tienda")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(179.1667F, 23F);
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextFormatString = "TIENDA: {0}";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.totalTable});
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 15.65606F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.StyleName = "baseControlStyle";
            // 
            // totalTable
            // 
            this.totalTable.BorderColor = System.Drawing.Color.White;
            this.totalTable.ForeColor = System.Drawing.Color.Black;
            this.totalTable.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 0F);
            this.totalTable.Name = "totalTable";
            this.totalTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.totalRow});
            this.totalTable.SizeF = new System.Drawing.SizeF(825.9999F, 15.65606F);
            this.totalTable.StylePriority.UseBorderColor = false;
            this.totalTable.StylePriority.UseForeColor = false;
            // 
            // totalRow
            // 
            this.totalRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.totalCaption,
            this.total,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell3});
            this.totalRow.Name = "totalRow";
            this.totalRow.Weight = 1.4D;
            // 
            // totalCaption
            // 
            this.totalCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.totalCaption.Name = "totalCaption";
            this.totalCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.totalCaption.StylePriority.UseFont = false;
            this.totalCaption.StylePriority.UsePadding = false;
            this.totalCaption.StylePriority.UseTextAlignment = false;
            this.totalCaption.Text = "TOTAL FINAL >>>";
            this.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.totalCaption.Weight = 1.0695554938583607D;
            // 
            // total
            // 
            this.total.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.total.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([total_entrada])")});
            this.total.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.total.Name = "total";
            this.total.StylePriority.UseBorders = false;
            this.total.StylePriority.UseFont = false;
            this.total.StylePriority.UseTextAlignment = false;
            this.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.total.TextFormatString = "{0:0.00}";
            this.total.Weight = 1.3206871208173039D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 1.1494034746817561D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([total_salida])")});
            this.xrTableCell6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell6.Weight = 1.3556860401985988D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 2.2532474134602012D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.HeightF = 0F;
            this.GroupHeader1.Level = 1;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StyleName = "baseControlStyle";
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.HeightF = 58.93785F;
            this.GroupFooter2.KeepTogether = true;
            this.GroupFooter2.Level = 1;
            this.GroupFooter2.Name = "GroupFooter2";
            this.GroupFooter2.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            this.GroupFooter2.PrintAtBottom = true;
            this.GroupFooter2.StyleName = "baseControlStyle";
            // 
            // baseControlStyle
            // 
            this.baseControlStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.baseControlStyle.Name = "baseControlStyle";
            this.baseControlStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // dataSetReportes1
            // 
            this.dataSetReportes1.DataSetName = "DataSetReportes";
            this.dataSetReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPMostrar_ReporteCatalogoProductosTableAdapter
            // 
            this.sPMostrar_ReporteCatalogoProductosTableAdapter.ClearBeforeFill = true;
            // 
            // spMostrar_ReporteCuadreDeDiaTableAdapter1
            // 
            this.spMostrar_ReporteCuadreDeDiaTableAdapter1.ClearBeforeFill = true;
            // 
            // tienda
            // 
            this.tienda.Description = "Parameter1";
            this.tienda.Name = "tienda";
            this.tienda.Visible = false;
            // 
            // fecha_emision
            // 
            this.fecha_emision.Description = "Parameter1";
            this.fecha_emision.Name = "fecha_emision";
            this.fecha_emision.Type = typeof(System.DateTime);
            this.fecha_emision.ValueInfo = "2020-09-22";
            this.fecha_emision.Visible = false;
            // 
            // fecha_inicial
            // 
            this.fecha_inicial.Description = "Parameter1";
            this.fecha_inicial.Name = "fecha_inicial";
            this.fecha_inicial.Type = typeof(System.DateTime);
            this.fecha_inicial.ValueInfo = "2020-09-22";
            this.fecha_inicial.Visible = false;
            // 
            // fecha_final
            // 
            this.fecha_final.Description = "Parameter1";
            this.fecha_final.Name = "fecha_final";
            this.fecha_final.Type = typeof(System.DateTime);
            this.fecha_final.ValueInfo = "2020-09-22";
            this.fecha_final.Visible = false;
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6});
            this.groupHeaderBand1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("tipo_pago_o_usuario_receptor", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.groupHeaderBand1.HeightF = 23F;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[usuario_receptor]")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(440.625F, 23F);
            this.xrLabel6.Text = "xrLabel6";
            this.xrLabel6.TextFormatString = "RECEPTOR: {0}";
            // 
            // ReporteIngresosSalidasCuADRE
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader2,
            this.GroupFooter1,
            this.GroupHeader1,
            this.GroupFooter2,
            this.groupHeaderBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dataSetReportes1});
            this.DataAdapter = this.spMostrar_ReporteCuadreDeDiaTableAdapter1;
            this.DataMember = "SPMostrar_ReporteCuadreDeDia";
            this.DataSource = this.dataSetReportes1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(12, 12, 14, 8);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.tienda,
            this.fecha_emision,
            this.fecha_inicial,
            this.fecha_final});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.StyleSheetPath = "";
            this.Version = "19.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.ReporteIngresosSalidasCuADRE_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable detailTable;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow;
        private DevExpress.XtraReports.UI.XRTableCell unitPrice;
        private DevExpress.XtraReports.UI.XRTableCell lineTotal;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRTable totalTable;
        private DevExpress.XtraReports.UI.XRTableRow totalRow;
        private DevExpress.XtraReports.UI.XRTableCell totalCaption;
        private DevExpress.XtraReports.UI.XRTableCell total;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DataSetReportes dataSetReportes1;
        private DataSetReportesTableAdapters.SPMostrar_ReporteCatalogoProductosTableAdapter sPMostrar_ReporteCatalogoProductosTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DataSetReportesTableAdapters.SPMostrar_ReporteCuadreDeDiaTableAdapter spMostrar_ReporteCuadreDeDiaTableAdapter1;
        private DevExpress.XtraReports.Parameters.Parameter tienda;
        private DevExpress.XtraReports.Parameters.Parameter fecha_emision;
        private DevExpress.XtraReports.Parameters.Parameter fecha_inicial;
        private DevExpress.XtraReports.Parameters.Parameter fecha_final;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell quantity;
    }
}
