namespace ViewGuate502.SalidasDinero.Gastos
{
    partial class ReporteSalidasGastos
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
            this.productName = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
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
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.headerTable = new DevExpress.XtraReports.UI.XRTable();
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.productNameCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPriceCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.dataSetReportes1 = new ViewGuate502.DataSetReportes();
            this.sPMostrar_ReporteCatalogoProductosTableAdapter = new ViewGuate502.DataSetReportesTableAdapters.SPMostrar_ReporteCatalogoProductosTableAdapter();
            this.spMostrar_ReporteDeSalidasDineroTableAdapter1 = new ViewGuate502.DataSetReportesTableAdapters.SPMostrar_ReporteDeSalidasDineroTableAdapter();
            this.tienda = new DevExpress.XtraReports.Parameters.Parameter();
            this.fecha_emision = new DevExpress.XtraReports.Parameters.Parameter();
            this.fecha_inicial = new DevExpress.XtraReports.Parameters.Parameter();
            this.fecha_final = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
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
            this.detailTable.BorderColor = System.Drawing.Color.White;
            this.detailTable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.detailTable.Name = "detailTable";
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow});
            this.detailTable.SizeF = new System.Drawing.SizeF(825.9999F, 23F);
            this.detailTable.StylePriority.UseBorderColor = false;
            this.detailTable.StylePriority.UseFont = false;
            // 
            // detailTableRow
            // 
            this.detailTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.quantity,
            this.productName,
            this.unitPrice,
            this.lineTotal,
            this.xrTableCell4,
            this.xrTableCell5});
            this.detailTableRow.Name = "detailTableRow";
            this.detailTableRow.Weight = 10.58D;
            // 
            // quantity
            // 
            this.quantity.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.quantity.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fecha_creacion]")});
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.quantity.Name = "quantity";
            this.quantity.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.quantity.StylePriority.UseBorders = false;
            this.quantity.StylePriority.UseFont = false;
            this.quantity.StylePriority.UsePadding = false;
            this.quantity.StylePriority.UseTextAlignment = false;
            this.quantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.quantity.TextFormatString = "{0:dd/MM/yyyy}";
            this.quantity.Weight = 0.20719668084790538D;
            // 
            // productName
            // 
            this.productName.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.productName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Concat([serie_factura],[correlativo_factura] )")});
            this.productName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.productName.Name = "productName";
            this.productName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.productName.StylePriority.UseBorders = false;
            this.productName.StylePriority.UseFont = false;
            this.productName.StylePriority.UsePadding = false;
            this.productName.StylePriority.UseTextAlignment = false;
            this.productName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.productName.Weight = 0.29401119905021433D;
            // 
            // unitPrice
            // 
            this.unitPrice.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.unitPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[tipo_salida]")});
            this.unitPrice.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.unitPrice.StylePriority.UseBorders = false;
            this.unitPrice.StylePriority.UseFont = false;
            this.unitPrice.StylePriority.UsePadding = false;
            this.unitPrice.StylePriority.UseTextAlignment = false;
            this.unitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.unitPrice.TextFormatString = "{0:$0.00}";
            this.unitPrice.Weight = 0.62235996358328849D;
            // 
            // lineTotal
            // 
            this.lineTotal.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lineTotal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[destino]")});
            this.lineTotal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lineTotal.Name = "lineTotal";
            this.lineTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.lineTotal.StylePriority.UseBorders = false;
            this.lineTotal.StylePriority.UseFont = false;
            this.lineTotal.StylePriority.UseForeColor = false;
            this.lineTotal.StylePriority.UsePadding = false;
            this.lineTotal.StylePriority.UseTextAlignment = false;
            this.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lineTotal.TextFormatString = "{0:$0.00}";
            this.lineTotal.Weight = 0.46534157837671908D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[monto]")});
            this.xrTableCell4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseForeColor = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 0.15637112844084594D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[observaciones]")});
            this.xrTableCell5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseForeColor = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.40827806488463686D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 12F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 10.46927F;
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
            this.GroupHeader2.HeightF = 70.91669F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StyleName = "baseControlStyle";
            this.GroupHeader2.StylePriority.UseBackColor = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?fecha_final")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(136.9583F, 46F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(128.125F, 23F);
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
            this.xrLabel4.SizeF = new System.Drawing.SizeF(136.9583F, 23F);
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextFormatString = "DEL: {0:d}";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(622.875F, 23F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(203.1249F, 23F);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrPageInfo1.TextFormatString = "PAGINA {0} DE {1}";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?fecha_emision")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(622.875F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(203.1249F, 23F);
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
            this.xrLabel2.SizeF = new System.Drawing.SizeF(453.125F, 23F);
            this.xrLabel2.Text = "REPORTE DE GASTOS POR RANGO DE FECHAS";
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?tienda")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(294.7917F, 23F);
            this.xrLabel1.TextFormatString = "TIENDA: {0}";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.totalTable});
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 26.80849F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.StyleName = "baseControlStyle";
            // 
            // totalTable
            // 
            this.totalTable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.totalTable.ForeColor = System.Drawing.Color.Black;
            this.totalTable.LocationFloat = new DevExpress.Utils.PointFloat(430.9457F, 0F);
            this.totalTable.Name = "totalTable";
            this.totalTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.totalRow});
            this.totalTable.SizeF = new System.Drawing.SizeF(238.4586F, 26.80849F);
            this.totalTable.StylePriority.UseFont = false;
            this.totalTable.StylePriority.UseForeColor = false;
            // 
            // totalRow
            // 
            this.totalRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.totalCaption,
            this.total});
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
            this.totalCaption.Text = "TOTALES >>> ";
            this.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.totalCaption.Weight = 1.1880226676600341D;
            // 
            // total
            // 
            this.total.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.total.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([monto])")});
            this.total.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.total.Name = "total";
            this.total.StylePriority.UseBorders = false;
            this.total.StylePriority.UseFont = false;
            this.total.StylePriority.UseTextAlignment = false;
            this.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.total.TextFormatString = "{0:0.00}";
            this.total.Weight = 0.39921731417290518D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.headerTable});
            this.GroupHeader1.HeightF = 14.16664F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StyleName = "baseControlStyle";
            // 
            // headerTable
            // 
            this.headerTable.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.headerTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.headerTable.Name = "headerTable";
            this.headerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.headerTableRow});
            this.headerTable.SizeF = new System.Drawing.SizeF(825.9999F, 14.16664F);
            this.headerTable.StylePriority.UseFont = false;
            this.headerTable.StylePriority.UsePadding = false;
            // 
            // headerTableRow
            // 
            this.headerTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productNameCaption,
            this.unitPriceCaption,
            this.lineTotalCaption,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.headerTableRow.Name = "headerTableRow";
            this.headerTableRow.Weight = 11.5D;
            // 
            // productNameCaption
            // 
            this.productNameCaption.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.productNameCaption.Name = "productNameCaption";
            this.productNameCaption.StylePriority.UseBorders = false;
            this.productNameCaption.StylePriority.UsePadding = false;
            this.productNameCaption.StylePriority.UseTextAlignment = false;
            this.productNameCaption.Text = "FECHA";
            this.productNameCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.productNameCaption.Weight = 0.18422444062725821D;
            // 
            // unitPriceCaption
            // 
            this.unitPriceCaption.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.unitPriceCaption.Name = "unitPriceCaption";
            this.unitPriceCaption.StylePriority.UseBorders = false;
            this.unitPriceCaption.StylePriority.UseTextAlignment = false;
            this.unitPriceCaption.Text = "FACTURA";
            this.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.unitPriceCaption.Weight = 0.26141382131747154D;
            // 
            // lineTotalCaption
            // 
            this.lineTotalCaption.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lineTotalCaption.Name = "lineTotalCaption";
            this.lineTotalCaption.StylePriority.UseBorders = false;
            this.lineTotalCaption.StylePriority.UseTextAlignment = false;
            this.lineTotalCaption.Text = "TIPO DE GASTO";
            this.lineTotalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lineTotalCaption.Weight = 0.5533579733196794D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "PROVEEDOR";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.41374824107236546D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "MONTO";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.13903419179277837D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "OBSERVACIONES";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 0.3630116169337903D;
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.HeightF = 49.77484F;
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
            // spMostrar_ReporteDeSalidasDineroTableAdapter1
            // 
            this.spMostrar_ReporteDeSalidasDineroTableAdapter1.ClearBeforeFill = true;
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
            // ReporteSalidasGastos
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader2,
            this.GroupFooter1,
            this.GroupHeader1,
            this.GroupFooter2});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dataSetReportes1});
            this.DataAdapter = this.spMostrar_ReporteDeSalidasDineroTableAdapter1;
            this.DataMember = "SPMostrar_ReporteDeSalidasDinero";
            this.DataSource = this.dataSetReportes1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(12, 12, 12, 10);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.tienda,
            this.fecha_emision,
            this.fecha_inicial,
            this.fecha_final});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.StyleSheetPath = "";
            this.Version = "19.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.ReporteSalidasGastos_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable detailTable;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow;
        private DevExpress.XtraReports.UI.XRTableCell quantity;
        private DevExpress.XtraReports.UI.XRTableCell productName;
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
        private DevExpress.XtraReports.UI.XRTable headerTable;
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow;
        private DevExpress.XtraReports.UI.XRTableCell productNameCaption;
        private DevExpress.XtraReports.UI.XRTableCell unitPriceCaption;
        private DevExpress.XtraReports.UI.XRTableCell lineTotalCaption;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DataSetReportes dataSetReportes1;
        private DataSetReportesTableAdapters.SPMostrar_ReporteCatalogoProductosTableAdapter sPMostrar_ReporteCatalogoProductosTableAdapter;
        private DataSetReportesTableAdapters.SPMostrar_ReporteDeSalidasDineroTableAdapter spMostrar_ReporteDeSalidasDineroTableAdapter1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.Parameters.Parameter tienda;
        private DevExpress.XtraReports.Parameters.Parameter fecha_emision;
        private DevExpress.XtraReports.Parameters.Parameter fecha_inicial;
        private DevExpress.XtraReports.Parameters.Parameter fecha_final;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
    }
}
