namespace ViewGuate502.Reportes.Ventas
{
    partial class SubReporteProductos
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
            this.productName = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.headerTable = new DevExpress.XtraReports.UI.XRTable();
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.dataSetReportes1 = new ViewGuate502.DataSetReportes();
            this.sPMostrar_ReporteOrdenDeCompraDetalladoTableAdapter = new ViewGuate502.DataSetReportesTableAdapters.SPMostrar_ReporteOrdenDeCompraDetalladoTableAdapter();
            this.reporte_EC_PRDTableAdapter1 = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.Reporte_EC_PRDTableAdapter();
            this.reporte_EC_PRDTableAdapter2 = new ViewGuate502.DataSetReportesTableAdapters.Reporte_EC_PRDTableAdapter();
            this.reporte_EC_PRDTableAdapter3 = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.Reporte_EC_PRDTableAdapter();
            this.dataSetReportes2 = new ViewGuate502.DataSetReportes();
            this.reporte_EC_PRDTableAdapter4 = new ViewGuate502.dbSoftwareGTDataSetTableAdapters.Reporte_EC_PRDTableAdapter();
            this.dbSoftwareGTDataSet11 = new ViewGuate502.dbSoftwareGTDataSet();
            this.id_venta_enc = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet11)).BeginInit();
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
            this.detailTable.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.detailTable.Name = "detailTable";
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow});
            this.detailTable.SizeF = new System.Drawing.SizeF(1076F, 23F);
            this.detailTable.StylePriority.UseFont = false;
            // 
            // detailTableRow
            // 
            this.detailTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productName,
            this.unitPrice,
            this.lineTotal,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13});
            this.detailTableRow.Name = "detailTableRow";
            this.detailTableRow.Weight = 10.58D;
            // 
            // productName
            // 
            this.productName.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.productName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[producto]")});
            this.productName.Name = "productName";
            this.productName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.productName.StylePriority.UseBorders = false;
            this.productName.StylePriority.UsePadding = false;
            this.productName.StylePriority.UseTextAlignment = false;
            this.productName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.productName.Weight = 0.91221531882437057D;
            // 
            // unitPrice
            // 
            this.unitPrice.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.unitPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[codigo]")});
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.unitPrice.StylePriority.UseBorders = false;
            this.unitPrice.StylePriority.UsePadding = false;
            this.unitPrice.StylePriority.UseTextAlignment = false;
            this.unitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.unitPrice.TextFormatString = "{0:$0.00}";
            this.unitPrice.Weight = 0.14338198950282211D;
            // 
            // lineTotal
            // 
            this.lineTotal.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lineTotal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[sublinea]")});
            this.lineTotal.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lineTotal.Name = "lineTotal";
            this.lineTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.lineTotal.StylePriority.UseBorders = false;
            this.lineTotal.StylePriority.UseFont = false;
            this.lineTotal.StylePriority.UseForeColor = false;
            this.lineTotal.StylePriority.UsePadding = false;
            this.lineTotal.StylePriority.UseTextAlignment = false;
            this.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lineTotal.TextFormatString = "{0:$0.00}";
            this.lineTotal.Weight = 0.28932014208491763D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[linea]")});
            this.xrTableCell9.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell9.Weight = 0.2413688460104462D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[bodega]")});
            this.xrTableCell10.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UsePadding = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell10.Weight = 0.20175684668741184D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[no_serie_articulos]")});
            this.xrTableCell11.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell11.StylePriority.UseBorders = false;
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell11.Weight = 0.15380554297802546D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cantidad]")});
            this.xrTableCell12.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell12.StylePriority.UseBorders = false;
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.StylePriority.UsePadding = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell12.Weight = 0.10168448400411367D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[total]")});
            this.xrTableCell13.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell13.StylePriority.UseBorders = false;
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UsePadding = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell13.Weight = 0.11002391054910216D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 13.54167F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 75.20834F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLine1});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 34.54167F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StyleName = "baseControlStyle";
            this.GroupHeader2.StylePriority.UseBackColor = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 11.54167F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Productos";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2});
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 11.54167F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.StyleName = "baseControlStyle";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.headerTable});
            this.GroupHeader1.HeightF = 25.62498F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StyleName = "baseControlStyle";
            // 
            // headerTable
            // 
            this.headerTable.BackColor = System.Drawing.Color.Gainsboro;
            this.headerTable.BorderColor = System.Drawing.Color.Gainsboro;
            this.headerTable.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.headerTable.LocationFloat = new DevExpress.Utils.PointFloat(7.629395E-06F, 0F);
            this.headerTable.Name = "headerTable";
            this.headerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.headerTableRow});
            this.headerTable.SizeF = new System.Drawing.SizeF(1076F, 25.62498F);
            this.headerTable.StylePriority.UseBackColor = false;
            this.headerTable.StylePriority.UseBorderColor = false;
            this.headerTable.StylePriority.UseFont = false;
            this.headerTable.StylePriority.UsePadding = false;
            this.headerTable.StylePriority.UseTextAlignment = false;
            this.headerTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // headerTableRow
            // 
            this.headerTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
            this.headerTableRow.Name = "headerTableRow";
            this.headerTableRow.Weight = 11.5D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Producto";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 5.3857601413844307D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Codigo";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.84653021115929783D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Sub linea";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 1.7081601090804157D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Linea";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 1.4250534620225572D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Bodega";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 1.1911817736511443D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "No. Serie";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell6.Weight = 0.9080771099762871D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "Cant";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 0.60035054942334209D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "Total";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell8.Weight = 0.64958622933996946D;
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.HeightF = 55F;
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
            // sPMostrar_ReporteOrdenDeCompraDetalladoTableAdapter
            // 
            this.sPMostrar_ReporteOrdenDeCompraDetalladoTableAdapter.ClearBeforeFill = true;
            // 
            // reporte_EC_PRDTableAdapter1
            // 
            this.reporte_EC_PRDTableAdapter1.ClearBeforeFill = true;
            // 
            // reporte_EC_PRDTableAdapter2
            // 
            this.reporte_EC_PRDTableAdapter2.ClearBeforeFill = true;
            // 
            // reporte_EC_PRDTableAdapter3
            // 
            this.reporte_EC_PRDTableAdapter3.ClearBeforeFill = true;
            // 
            // dataSetReportes2
            // 
            this.dataSetReportes2.DataSetName = "DataSetReportes";
            this.dataSetReportes2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte_EC_PRDTableAdapter4
            // 
            this.reporte_EC_PRDTableAdapter4.ClearBeforeFill = true;
            // 
            // dbSoftwareGTDataSet11
            // 
            this.dbSoftwareGTDataSet11.DataSetName = "dbSoftwareGTDataSet1";
            this.dbSoftwareGTDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_venta_enc
            // 
            this.id_venta_enc.Description = "Parameter1";
            this.id_venta_enc.Name = "id_venta_enc";
            this.id_venta_enc.Type = typeof(int);
            this.id_venta_enc.ValueInfo = "0";
            this.id_venta_enc.Visible = false;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1076F, 11.54167F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1076F, 11.54167F);
            // 
            // SubReporteProductos
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
            this.dataSetReportes1,
            this.dataSetReportes2,
            this.dbSoftwareGTDataSet11});
            this.DataAdapter = this.reporte_EC_PRDTableAdapter4;
            this.DataMember = "Reporte_EC_PRD";
            this.DataSource = this.dataSetReportes1;
            this.FilterString = "[id_venta_enc] = [id_venta_enc]";
            this.Margins = new System.Drawing.Printing.Margins(12, 12, 14, 75);
            this.PageHeight = 1700;
            this.PageWidth = 1100;
            this.PaperKind = System.Drawing.Printing.PaperKind.Tabloid;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.id_venta_enc});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.SubReporteProductos_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSoftwareGTDataSet11)).EndInit();
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
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable headerTable;
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DataSetReportes dataSetReportes1;
        private DataSetReportesTableAdapters.SPMostrar_ReporteOrdenDeCompraDetalladoTableAdapter sPMostrar_ReporteOrdenDeCompraDetalladoTableAdapter;
        private dbSoftwareGTDataSetTableAdapters.Reporte_EC_PRDTableAdapter reporte_EC_PRDTableAdapter1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DataSetReportesTableAdapters.Reporte_EC_PRDTableAdapter reporte_EC_PRDTableAdapter2;
        private dbSoftwareGTDataSetTableAdapters.Reporte_EC_PRDTableAdapter reporte_EC_PRDTableAdapter3;
        private DataSetReportes dataSetReportes2;
        private dbSoftwareGTDataSetTableAdapters.Reporte_EC_PRDTableAdapter reporte_EC_PRDTableAdapter4;
        private dbSoftwareGTDataSet dbSoftwareGTDataSet11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.Parameters.Parameter id_venta_enc;
        private DevExpress.XtraReports.UI.XRTableCell productName;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
    }
}
