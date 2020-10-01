namespace ViewGuate502.Reportes
{
    partial class XtraReporteCatalogoDeProductos
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
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.headerTable = new DevExpress.XtraReports.UI.XRTable();
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.quantityCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.productNameCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.dataSetReportes1 = new ViewGuate502.DataSetReportes();
            this.sPMostrar_ReporteCatalogoProductosTableAdapter = new ViewGuate502.DataSetReportesTableAdapters.SPMostrar_ReporteCatalogoProductosTableAdapter();
            this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Empresa = new DevExpress.XtraReports.Parameters.Parameter();
            this.fecha_emision = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.detailTable});
            this.Detail.HeightF = 13.00001F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // detailTable
            // 
            this.detailTable.BorderColor = System.Drawing.Color.Transparent;
            this.detailTable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.detailTable.Name = "detailTable";
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow});
            this.detailTable.SizeF = new System.Drawing.SizeF(821.0001F, 13.00001F);
            this.detailTable.StylePriority.UseBorderColor = false;
            this.detailTable.StylePriority.UseFont = false;
            // 
            // detailTableRow
            // 
            this.detailTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.quantity,
            this.productName,
            this.xrTableCell6,
            this.xrTableCell5,
            this.xrTableCell9,
            this.xrTableCell4});
            this.detailTableRow.Name = "detailTableRow";
            this.detailTableRow.Weight = 10.58D;
            // 
            // quantity
            // 
            this.quantity.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.quantity.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[codigo]")});
            this.quantity.Name = "quantity";
            this.quantity.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.quantity.StylePriority.UseBorders = false;
            this.quantity.StylePriority.UsePadding = false;
            this.quantity.StylePriority.UseTextAlignment = false;
            this.quantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.quantity.Weight = 0.37520346315312741D;
            // 
            // productName
            // 
            this.productName.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.productName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[nombre]")});
            this.productName.Name = "productName";
            this.productName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.productName.StylePriority.UseBorders = false;
            this.productName.StylePriority.UsePadding = false;
            this.productName.StylePriority.UseTextAlignment = false;
            this.productName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.productName.Weight = 2.9733106080297005D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[stock]")});
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell6.Weight = 0.30311896634538005D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[precioa]")});
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell5.Weight = 0.34936963345630884D;
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
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 0.63564706454014086D;
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
            this.BottomMargin.HeightF = 12.91669F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 0F;
            this.GroupHeader2.Level = 2;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StyleName = "baseControlStyle";
            this.GroupHeader2.StylePriority.UseBackColor = false;
            this.GroupHeader2.StylePriority.UseTextAlignment = false;
            this.GroupHeader2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[fecha_emision]")});
            this.xrLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(668.9168F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(152.0833F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel3.TextFormatString = "Fecha: {0:d}";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(410.4167F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Reporte catalogo de productos";
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[Empresa]")});
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(198.9583F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextFormatString = "Tienda: {0}";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 36.80848F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.StyleName = "baseControlStyle";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.headerTable});
            this.GroupHeader1.HeightF = 14.58333F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StyleName = "baseControlStyle";
            // 
            // headerTable
            // 
            this.headerTable.BorderColor = System.Drawing.Color.Transparent;
            this.headerTable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.headerTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.headerTable.Name = "headerTable";
            this.headerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.headerTableRow});
            this.headerTable.SizeF = new System.Drawing.SizeF(821.0001F, 14.58333F);
            this.headerTable.StylePriority.UseBorderColor = false;
            this.headerTable.StylePriority.UseFont = false;
            this.headerTable.StylePriority.UsePadding = false;
            // 
            // headerTableRow
            // 
            this.headerTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.quantityCaption,
            this.productNameCaption,
            this.xrTableCell7,
            this.xrTableCell2,
            this.xrTableCell8,
            this.xrTableCell3});
            this.headerTableRow.Name = "headerTableRow";
            this.headerTableRow.Weight = 11.5D;
            // 
            // quantityCaption
            // 
            this.quantityCaption.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.quantityCaption.Name = "quantityCaption";
            this.quantityCaption.StylePriority.UseBorders = false;
            this.quantityCaption.StylePriority.UseTextAlignment = false;
            this.quantityCaption.Text = "Codigo";
            this.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.quantityCaption.Weight = 0.32093010024742491D;
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
            this.productNameCaption.Text = "Descripción";
            this.productNameCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.productNameCaption.Weight = 2.3582751129792485D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "Stock";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell7.Weight = 0.24253145121384648D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Precio a";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell2.Weight = 0.27953624366347335D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Info";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 0.508592589639947D;
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.HeightF = 48.74999F;
            this.GroupFooter2.KeepTogether = true;
            this.GroupFooter2.Level = 2;
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
            // GroupHeader3
            // 
            this.GroupHeader3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.GroupHeader3.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("linea_sublinea", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader3.HeightF = 13.12497F;
            this.GroupHeader3.Level = 1;
            this.GroupHeader3.Name = "GroupHeader3";
            // 
            // xrTable1
            // 
            this.xrTable1.BackColor = System.Drawing.Color.Gainsboro;
            this.xrTable1.BorderColor = System.Drawing.Color.Transparent;
            this.xrTable1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(820.9999F, 13.12497F);
            this.xrTable1.StylePriority.UseBackColor = false;
            this.xrTable1.StylePriority.UseBorderColor = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UsePadding = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 11.5D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[linea_sublinea]")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Codigo";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.TextFormatString = "Linea {0}";
            this.xrTableCell1.Weight = 3.5932081750183458D;
            // 
            // Empresa
            // 
            this.Empresa.Description = "Parameter1";
            this.Empresa.Name = "Empresa";
            this.Empresa.Visible = false;
            // 
            // fecha_emision
            // 
            this.fecha_emision.Description = "Parameter1";
            this.fecha_emision.Name = "fecha_emision";
            this.fecha_emision.Type = typeof(System.DateTime);
            this.fecha_emision.Visible = false;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(721.0001F, 23F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.PageHeader.HeightF = 61.33335F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "Descuento";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell8.Weight = 0.34673558330071308D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[descuento]")});
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell9.Weight = 0.43335569771647003D;
            // 
            // XtraReporteCatalogoDeProductos
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader2,
            this.GroupFooter1,
            this.GroupHeader1,
            this.GroupFooter2,
            this.GroupHeader3,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dataSetReportes1});
            this.DataAdapter = this.sPMostrar_ReporteCatalogoProductosTableAdapter;
            this.DataMember = "SPMostrar_ReporteCatalogoProductos";
            this.DataSource = this.dataSetReportes1;
            this.Margins = new System.Drawing.Printing.Margins(15, 14, 14, 13);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Empresa,
            this.fecha_emision});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.UI.XRTable headerTable;
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow;
        private DevExpress.XtraReports.UI.XRTableCell quantityCaption;
        private DevExpress.XtraReports.UI.XRTableCell productNameCaption;
        private DevExpress.XtraReports.UI.XRTable detailTable;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow;
        private DevExpress.XtraReports.UI.XRTableCell quantity;
        private DevExpress.XtraReports.UI.XRTableCell productName;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DataSetReportes dataSetReportes1;
        private DataSetReportesTableAdapters.SPMostrar_ReporteCatalogoProductosTableAdapter sPMostrar_ReporteCatalogoProductosTableAdapter;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader3;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.Parameters.Parameter Empresa;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.Parameters.Parameter fecha_emision;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
    }
}
