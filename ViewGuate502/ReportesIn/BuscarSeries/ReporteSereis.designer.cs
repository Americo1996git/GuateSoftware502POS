namespace ViewGuate502.Reportes.BuscarSeries
{
    partial class ReporteSereis
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
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.productName = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.headerTable = new DevExpress.XtraReports.UI.XRTable();
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantityCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.productNameCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPriceCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.dataSetReportes1 = new ViewGuate502.DataSetReportes();
            this.sPMostrar_ReporteOrdenDeCompraDetalladoTableAdapter = new ViewGuate502.DataSetReportesTableAdapters.SPMostrar_ReporteOrdenDeCompraDetalladoTableAdapter();
            this.dataSetReportes2 = new ViewGuate502.DataSetReportes();
            this.dataSetReportes3 = new ViewGuate502.DataSetReportes();
            this.spMostrar_BuscarSeriesTableAdapter1 = new ViewGuate502.DataSetReportesTableAdapters.SPMostrar_BuscarSeriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes3)).BeginInit();
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
            this.detailTable.SizeF = new System.Drawing.SizeF(825.9998F, 23F);
            this.detailTable.StylePriority.UseFont = false;
            // 
            // detailTableRow
            // 
            this.detailTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell3,
            this.quantity,
            this.productName,
            this.unitPrice,
            this.lineTotal});
            this.detailTableRow.Name = "detailTableRow";
            this.detailTableRow.Weight = 10.58D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[codigo_producto]")});
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 0.15545277879311584D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[producto]")});
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell3.Weight = 0.4925118903532642D;
            // 
            // quantity
            // 
            this.quantity.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.quantity.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[correlativo]")});
            this.quantity.Name = "quantity";
            this.quantity.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.quantity.StylePriority.UseBorders = false;
            this.quantity.StylePriority.UsePadding = false;
            this.quantity.StylePriority.UseTextAlignment = false;
            this.quantity.Text = "1";
            this.quantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.quantity.Weight = 0.13838673734004059D;
            // 
            // productName
            // 
            this.productName.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.productName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[numero]")});
            this.productName.Name = "productName";
            this.productName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.productName.StylePriority.UseBorders = false;
            this.productName.StylePriority.UsePadding = false;
            this.productName.StylePriority.UseTextAlignment = false;
            this.productName.Text = "ProductName";
            this.productName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.productName.Weight = 0.11969094951422687D;
            // 
            // unitPrice
            // 
            this.unitPrice.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.unitPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[serie]")});
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.unitPrice.StylePriority.UseBorders = false;
            this.unitPrice.StylePriority.UsePadding = false;
            this.unitPrice.StylePriority.UseTextAlignment = false;
            this.unitPrice.Text = "Q0.00";
            this.unitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.unitPrice.Weight = 0.30889998178009287D;
            // 
            // lineTotal
            // 
            this.lineTotal.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lineTotal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[documento]")});
            this.lineTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lineTotal.Name = "lineTotal";
            this.lineTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.lineTotal.StylePriority.UseBorders = false;
            this.lineTotal.StylePriority.UseFont = false;
            this.lineTotal.StylePriority.UseForeColor = false;
            this.lineTotal.StylePriority.UsePadding = false;
            this.lineTotal.StylePriority.UseTextAlignment = false;
            this.lineTotal.Text = "Q0.00";
            this.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lineTotal.Weight = 0.47666745426837209D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 23.95833F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 75F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 67.16668F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StyleName = "baseControlStyle";
            this.GroupHeader2.StylePriority.UseBackColor = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(88.54166F, 23F);
            this.xrLabel1.Text = "Empresa agly";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 0F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.StyleName = "baseControlStyle";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.headerTable});
            this.GroupHeader1.HeightF = 25F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StyleName = "baseControlStyle";
            // 
            // headerTable
            // 
            this.headerTable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.headerTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.headerTable.Name = "headerTable";
            this.headerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.headerTableRow});
            this.headerTable.SizeF = new System.Drawing.SizeF(826F, 25F);
            this.headerTable.StylePriority.UseFont = false;
            this.headerTable.StylePriority.UsePadding = false;
            // 
            // headerTableRow
            // 
            this.headerTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrTableCell1,
            this.quantityCaption,
            this.productNameCaption,
            this.unitPriceCaption,
            this.lineTotalCaption});
            this.headerTableRow.Name = "headerTableRow";
            this.headerTableRow.Weight = 11.5D;
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
            this.xrTableCell2.Text = "Codigo";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell2.Weight = 0.20014958336473007D;
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
            this.xrTableCell1.Text = "Producto";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 0.634122362502796D;
            // 
            // quantityCaption
            // 
            this.quantityCaption.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.quantityCaption.Name = "quantityCaption";
            this.quantityCaption.StylePriority.UseBorders = false;
            this.quantityCaption.StylePriority.UseTextAlignment = false;
            this.quantityCaption.Text = "Correlativo";
            this.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.quantityCaption.Weight = 0.17817626077588605D;
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
            this.productNameCaption.Text = "Numero";
            this.productNameCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.productNameCaption.Weight = 0.15410545582517063D;
            // 
            // unitPriceCaption
            // 
            this.unitPriceCaption.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.unitPriceCaption.Name = "unitPriceCaption";
            this.unitPriceCaption.StylePriority.UseBorders = false;
            this.unitPriceCaption.StylePriority.UseTextAlignment = false;
            this.unitPriceCaption.Text = "Serie";
            this.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.unitPriceCaption.Weight = 0.39771676312468285D;
            // 
            // lineTotalCaption
            // 
            this.lineTotalCaption.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lineTotalCaption.Name = "lineTotalCaption";
            this.lineTotalCaption.StylePriority.UseBorders = false;
            this.lineTotalCaption.StylePriority.UseTextAlignment = false;
            this.lineTotalCaption.Text = "Documento";
            this.lineTotalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lineTotalCaption.Weight = 0.61372265072999566D;
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
            // dataSetReportes2
            // 
            this.dataSetReportes2.DataSetName = "DataSetReportes";
            this.dataSetReportes2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetReportes3
            // 
            this.dataSetReportes3.DataSetName = "DataSetReportes";
            this.dataSetReportes3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spMostrar_BuscarSeriesTableAdapter1
            // 
            this.spMostrar_BuscarSeriesTableAdapter1.ClearBeforeFill = true;
            // 
            // ReporteSereis
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
            this.dataSetReportes3});
            this.DataAdapter = this.spMostrar_BuscarSeriesTableAdapter1;
            this.DataMember = "SPMostrar_BuscarSeries";
            this.DataSource = this.dataSetReportes1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(12, 12, 24, 75);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.StyleSheetPath = "";
            this.Version = "19.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.ReporteSereis_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes3)).EndInit();
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
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable headerTable;
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow;
        private DevExpress.XtraReports.UI.XRTableCell quantityCaption;
        private DevExpress.XtraReports.UI.XRTableCell productNameCaption;
        private DevExpress.XtraReports.UI.XRTableCell unitPriceCaption;
        private DevExpress.XtraReports.UI.XRTableCell lineTotalCaption;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DataSetReportes dataSetReportes1;
        private DataSetReportesTableAdapters.SPMostrar_ReporteOrdenDeCompraDetalladoTableAdapter sPMostrar_ReporteOrdenDeCompraDetalladoTableAdapter;
        private DataSetReportes dataSetReportes2;
        private DataSetReportes dataSetReportes3;
        private DataSetReportesTableAdapters.SPMostrar_BuscarSeriesTableAdapter spMostrar_BuscarSeriesTableAdapter1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
