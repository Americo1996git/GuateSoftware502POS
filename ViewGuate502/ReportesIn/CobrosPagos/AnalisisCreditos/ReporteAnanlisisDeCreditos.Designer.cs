namespace ViewGuate502.ReportesIn.CobrosPagos.AnalisisCreditos
{
    partial class ReporteAnanlisisDeCreditos
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
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.dataSetReportes1 = new ViewGuate502.DataSetReportes();
            this.sPMostrar_ReporteCatalogoProductosTableAdapter = new ViewGuate502.DataSetReportesTableAdapters.SPMostrar_ReporteCatalogoProductosTableAdapter();
            this.spMostrar_ReporteAnalisisDeCreditoEncabezadoTableAdapter1 = new ViewGuate502.DataSetReportesTableAdapters.SPMostrar_ReporteAnalisisDeCreditoEncabezadoTableAdapter();
            this.fecha_emision = new DevExpress.XtraReports.Parameters.Parameter();
            this.tienda = new DevExpress.XtraReports.Parameters.Parameter();
            this.cliente = new DevExpress.XtraReports.Parameters.Parameter();
            this.sPMostrar_ReporteEstadoDeCuentaTableAdapter = new ViewGuate502.DataSetReportesTableAdapters.SPMostrar_ReporteEstadoDeCuentaTableAdapter();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport1,
            this.detailTable});
            this.Detail.HeightF = 51.20831F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // detailTable
            // 
            this.detailTable.BackColor = System.Drawing.Color.Transparent;
            this.detailTable.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.detailTable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.detailTable.Name = "detailTable";
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow});
            this.detailTable.SizeF = new System.Drawing.SizeF(825.9999F, 23F);
            this.detailTable.StylePriority.UseBackColor = false;
            this.detailTable.StylePriority.UseBorders = false;
            this.detailTable.StylePriority.UseFont = false;
            // 
            // detailTableRow
            // 
            this.detailTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.quantity,
            this.productName,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.detailTableRow.Name = "detailTableRow";
            this.detailTableRow.Weight = 10.58D;
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
            this.quantity.TextFormatString = "ENVIO: {0}";
            this.quantity.Weight = 0.21798252913016433D;
            // 
            // productName
            // 
            this.productName.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.productName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[total]")});
            this.productName.Name = "productName";
            this.productName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.productName.StylePriority.UseBorders = false;
            this.productName.StylePriority.UsePadding = false;
            this.productName.StylePriority.UseTextAlignment = false;
            this.productName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.productName.TextFormatString = "TOTAL: {0}";
            this.productName.Weight = 0.22975719350501453D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cantidad_cuotas]")});
            this.xrTableCell1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.TextFormatString = "NUM PAGOS: {0}";
            this.xrTableCell1.Weight = 0.59477017996005088D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[fecha_creacion]")});
            this.xrTableCell2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.TextFormatString = "FECHA: {0:dd/MM/yyyy}";
            this.xrTableCell2.Weight = 0.36725895754010052D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[tienda]")});
            this.xrTableCell3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseForeColor = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.TextFormatString = "TIENDA: {0}";
            this.xrTableCell3.Weight = 0.36725895754010052D;
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
            this.BottomMargin.HeightF = 12F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrPageInfo1,
            this.xrLabel1});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 77.33332F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StyleName = "baseControlStyle";
            this.GroupHeader2.StylePriority.UseBackColor = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?cliente")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 46F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(359.375F, 23F);
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextFormatString = "CLIENTE: {0}";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?fecha_emision")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(586.9583F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(239.0416F, 23F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel3.TextFormatString = "FECHA EMISIÓN: {0:d}";
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?tienda")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(207.2917F, 23F);
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextFormatString = "TIENDA: {0}";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(586.9583F, 23F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(239.0416F, 23F);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrPageInfo1.TextFormatString = "PAGINA {0} DE {1}";
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(468.75F, 23F);
            this.xrLabel1.Text = "REPORTE DE ANALISIS DE CREDITO";
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
            this.GroupHeader1.HeightF = 0F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StyleName = "baseControlStyle";
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.HeightF = 48.39986F;
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
            // spMostrar_ReporteAnalisisDeCreditoEncabezadoTableAdapter1
            // 
            this.spMostrar_ReporteAnalisisDeCreditoEncabezadoTableAdapter1.ClearBeforeFill = true;
            // 
            // fecha_emision
            // 
            this.fecha_emision.Description = "Parameter1";
            this.fecha_emision.Name = "fecha_emision";
            this.fecha_emision.Type = typeof(System.DateTime);
            this.fecha_emision.ValueInfo = "2020-09-18";
            this.fecha_emision.Visible = false;
            // 
            // tienda
            // 
            this.tienda.Description = "Parameter1";
            this.tienda.Name = "tienda";
            this.tienda.Visible = false;
            // 
            // cliente
            // 
            this.cliente.Description = "Parameter1";
            this.cliente.Name = "cliente";
            this.cliente.Visible = false;
            // 
            // sPMostrar_ReporteEstadoDeCuentaTableAdapter
            // 
            this.sPMostrar_ReporteEstadoDeCuentaTableAdapter.ClearBeforeFill = true;
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.99999F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("id_promesa_pago", null, "SPMostrar_ReporteAnalisisDeCreditoEncabezado.id_promesa_pago"));
            this.xrSubreport1.ReportSource = new ViewGuate502.ReportesIn.CobrosPagos.AnalisisCreditos.SubReporteAnalisisCreditoDetalle();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(826F, 28.20832F);
            // 
            // ReporteAnanlisisDeCreditos
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
            this.DataAdapter = this.spMostrar_ReporteAnalisisDeCreditoEncabezadoTableAdapter1;
            this.DataMember = "SPMostrar_ReporteAnalisisDeCreditoEncabezado";
            this.DataSource = this.dataSetReportes1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(12, 12, 14, 12);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.fecha_emision,
            this.tienda,
            this.cliente});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.StyleSheetPath = "";
            this.Version = "19.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.ReporteAnanlisisDeCreditos_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable detailTable;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow;
        private DevExpress.XtraReports.UI.XRTableCell quantity;
        private DevExpress.XtraReports.UI.XRTableCell productName;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DataSetReportes dataSetReportes1;
        private DataSetReportesTableAdapters.SPMostrar_ReporteCatalogoProductosTableAdapter sPMostrar_ReporteCatalogoProductosTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DataSetReportesTableAdapters.SPMostrar_ReporteAnalisisDeCreditoEncabezadoTableAdapter spMostrar_ReporteAnalisisDeCreditoEncabezadoTableAdapter1;
        private DevExpress.XtraReports.Parameters.Parameter fecha_emision;
        private DevExpress.XtraReports.Parameters.Parameter tienda;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.Parameters.Parameter cliente;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DataSetReportesTableAdapters.SPMostrar_ReporteEstadoDeCuentaTableAdapter sPMostrar_ReporteEstadoDeCuentaTableAdapter;
    }
}
