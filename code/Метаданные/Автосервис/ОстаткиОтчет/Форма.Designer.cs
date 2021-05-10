using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace NSGAuto.Метаданные.Автосервис

{
    
    public partial class ОстаткиОтчетФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ОстаткиОтчетФорма));
            NsgSoft.Forms.NsgGridColumn nsgGridColumn1 = new NsgSoft.Forms.NsgGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn5 = new NsgSoft.Forms.NsgIGridColumn();
            this.nsgObjectFilter1 = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.vmoФильтр = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Номенклатура_vmoФильтр = new NSGAuto.Метаданные.Автосервис.Номенклатура.ColumnDescriptor();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoИтоги = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Номенклатура_vmoИтоги = new NSGAuto.Метаданные.Автосервис.Номенклатура.ColumnDescriptor();
            this.НачОстаток_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Приход_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Расход_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.КонОстаток_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.НачОстатокКоличество_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.ПриходКоличество_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.РасходКоличество_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.КонОстатокКоличество_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.nsgGroupsList1 = new NsgSoft.ReportBuilder.NsgGroupsList();
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.nsgReportDataSource1 = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("nsgReportDataSource1", this.nsgReportDataSource1);
            this.ДокDataSource = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoДок = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Номенклатура_vmoДок = new NSGAuto.Метаданные.Автосервис.Номенклатура.ColumnDescriptor();
            this.Приход_vmoДок = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Расход_vmoДок = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Документ_vmoДок = new NsgSoft.Forms.NsgColumnDescriptor.UntypedMultipleObject();
            this.ПриходКоличество_vmoДок = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.РасходКоличество_vmoДок = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("ДокDataSource", this.ДокDataSource);
            this.ЗаголовокDataSource = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoЗаголовок = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.Период_vmoЗаголовок = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.Фильтр_vmoЗаголовок = new NsgSoft.Forms.NsgColumnDescriptor.String();
            this.stiReportDataSource3 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("ЗаголовокDataSource", this.ЗаголовокDataSource);
            this.nsgPeriodPicker1 = new NsgSoft.Forms.NsgPeriodPicker();
            this.nsgLabel2 = new NsgSoft.Forms.NsgLabel();
            this.nsgButton1 = new NsgSoft.Design.NsgButton();
            this.Период = new NsgSoft.Forms.NsgColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтоги)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgReportDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ДокDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДок)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ЗаголовокDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoЗаголовок)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateReport.DisabledImageKey = "disabled_nsgdatadocument";
            this.btnCreateReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreateReport.ImageKey = "nsgdatadocument";
            this.btnCreateReport.Location = new System.Drawing.Point(0, 0);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(112, 28);
            this.btnCreateReport.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.btnCreateReport.TabIndex = 0;
            this.btnCreateReport.Text = "Сформировать";
            this.btnCreateReport.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelButtonReportForm
            // 
            this.panelButtonReportForm.AllowDrop = true;
            this.panelButtonReportForm.Controls.Add(this.formSettingsButton);
            this.panelButtonReportForm.Controls.Add(this.printButton);
            this.panelButtonReportForm.Controls.Add(this.btnCreateReport);
            this.panelButtonReportForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 362);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(858, 28);
            this.panelButtonReportForm.TabIndex = 0;
            // 
            // printButton
            // 
            this.printButton.AutoSize = true;
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printButton.ButtonEnabled = true;
            this.printButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("printButton.ButtonImage")));
            this.printButton.ButtonText = "Печать";
            this.printButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.printButton.ImageKey = "Print";
            this.printButton.Location = new System.Drawing.Point(838, 0);
            this.printButton.Name = "printButton";
            this.printButton.ShowImage = false;
            this.printButton.ShowText = false;
            this.printButton.Size = new System.Drawing.Size(20, 28);
            this.printButton.TabIndex = 1;
            // 
            // formSettingsButton
            // 
            this.formSettingsButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.formSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.formSettingsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.formSettingsButton.DisabledImageKey = "disabled_Settings";
            this.formSettingsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.formSettingsButton.ImageKey = "Settings";
            this.formSettingsButton.ImagePosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.formSettingsButton.Location = new System.Drawing.Point(112, 0);
            this.formSettingsButton.Name = "formSettingsButton";
            this.formSettingsButton.Size = new System.Drawing.Size(28, 28);
            this.formSettingsButton.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.formSettingsButton.TabIndex = 2;
            this.formSettingsButton.TextPosition = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nsgVisualMultipleObject
            // 
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Период);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
            // 
            // nsgObjectFilter1
            // 
            this.nsgObjectFilter1.AllowDrop = true;
            this.nsgObjectFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nsgObjectFilter1.AutoSetCompare = true;
            this.nsgObjectFilter1.BackColor = System.Drawing.SystemColors.Control;
            nsgGridColumn1.Caption = "";
            nsgGridColumn1.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn1.ImportedFromVMO = false;
            nsgGridColumn1.Name = "Номенклатура";
            nsgGridColumn1.Root = this.nsgObjectFilter1.Columns.Collection;
            this.nsgObjectFilter1.Columns.Collection.Add(nsgGridColumn1);
            this.nsgObjectFilter1.FilterTypeCaption = "Тип Фильтра";
            this.nsgObjectFilter1.Grouping = false;
            this.nsgObjectFilter1.IsModify = true;
            this.nsgObjectFilter1.LineHeight = 20;
            this.nsgObjectFilter1.Location = new System.Drawing.Point(12, 199);
            this.nsgObjectFilter1.LockAdditionalColumns = false;
            this.nsgObjectFilter1.LockUpdateColumnsFromSourceObject = false;
            this.nsgObjectFilter1.Name = "NsgObjectFilter";
            this.nsgObjectFilter1.ReadOnly = false;
            this.nsgObjectFilter1.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.nsgObjectFilter1.RekvisitCaption = "Имя Фильтра";
            this.nsgObjectFilter1.SaveSettings = true;
            this.nsgObjectFilter1.Size = new System.Drawing.Size(290, 157);
            this.nsgObjectFilter1.SourceObject = this.vmoФильтр;
            this.nsgObjectFilter1.TabIndex = 17;
            this.nsgObjectFilter1.ValueCaption = "Фильтр";
            // 
            // vmoФильтр
            // 
            this.vmoФильтр.Columns.Collection.Add(this.Номенклатура_vmoФильтр);
            this.vmoФильтр.IsActive = true;
            this.vmoФильтр.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoФильтр.MetaDataName = "";
            this.vmoФильтр.FullName = "";
            // 
            // Номенклатура_vmoФильтр
            // 
            this.Номенклатура_vmoФильтр.Caption = "Номенклатура";
            this.Номенклатура_vmoФильтр.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_vmoФильтр.Name = "Номенклатура";
            this.Номенклатура_vmoФильтр.NSGType = typeof(NSGAuto.Метаданные.Автосервис.Номенклатура);
            this.Номенклатура_vmoФильтр.PropertyType = typeof(NSGAuto.Метаданные.Автосервис.Номенклатура);
            this.Номенклатура_vmoФильтр.SearchCondition.OwnerComponent = this.Номенклатура_vmoФильтр;
            this.Номенклатура_vmoФильтр.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgIGrid1
            // 
            this.nsgIGrid1.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.nsgIGrid1.AllowSaveColParamsToXML = true;
            this.nsgIGrid1.AllowSaveColPositionToXML = true;
            this.nsgIGrid1.AllowSaveColWidthToXML = true;
            this.nsgIGrid1.AllowSaveSettingsToXML = true;
            this.nsgIGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsgIGrid1.AutoResizeCols = true;
            nsgIGridColumn1.AllowFilter = true;
            nsgIGridColumn1.AllowGroupSelect = false;
            nsgIGridColumn1.AllowResize = true;
            nsgIGridColumn1.AutoResize = true;
            nsgIGridColumn1.Caption = "";
            nsgIGridColumn1.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn1.DateFormat = null;
            nsgIGridColumn1.ImportedFromVMO = false;
            nsgIGridColumn1.Name = "Номенклатура";
            nsgIGridColumn1.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn1.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn1.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn1.UseAsHeaderImage = false;
            nsgIGridColumn1.Width = 100;
            nsgIGridColumn2.AllowFilter = true;
            nsgIGridColumn2.AllowGroupSelect = false;
            nsgIGridColumn2.AllowResize = true;
            nsgIGridColumn2.AutoResize = true;
            nsgIGridColumn2.Caption = "";
            nsgIGridColumn2.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn2.DateFormat = null;
            nsgIGridColumn2.ImportedFromVMO = false;
            nsgIGridColumn2.Name = "НачОстаток";
            nsgIGridColumn2.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn2.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn2.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn2.UseAsHeaderImage = false;
            nsgIGridColumn2.Width = 100;
            nsgIGridColumn3.AllowFilter = true;
            nsgIGridColumn3.AllowGroupSelect = false;
            nsgIGridColumn3.AllowResize = true;
            nsgIGridColumn3.AutoResize = true;
            nsgIGridColumn3.Caption = "";
            nsgIGridColumn3.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn3.DateFormat = null;
            nsgIGridColumn3.ImportedFromVMO = false;
            nsgIGridColumn3.Name = "Приход";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn3.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn3.UseAsHeaderImage = false;
            nsgIGridColumn3.Width = 100;
            nsgIGridColumn4.AllowFilter = true;
            nsgIGridColumn4.AllowGroupSelect = false;
            nsgIGridColumn4.AllowResize = true;
            nsgIGridColumn4.AutoResize = true;
            nsgIGridColumn4.Caption = "";
            nsgIGridColumn4.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn4.DateFormat = null;
            nsgIGridColumn4.ImportedFromVMO = false;
            nsgIGridColumn4.Name = "Расход";
            nsgIGridColumn4.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn4.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn4.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn4.UseAsHeaderImage = false;
            nsgIGridColumn4.Width = 100;
            nsgIGridColumn5.AllowFilter = true;
            nsgIGridColumn5.AllowGroupSelect = false;
            nsgIGridColumn5.AllowResize = true;
            nsgIGridColumn5.AutoResize = true;
            nsgIGridColumn5.Caption = "";
            nsgIGridColumn5.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn5.DateFormat = null;
            nsgIGridColumn5.ImportedFromVMO = false;
            nsgIGridColumn5.Name = "КонОстаток";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn5.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn5.UseAsHeaderImage = false;
            nsgIGridColumn5.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn1);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn2);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn3);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn4);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn5);
            this.nsgIGrid1.Filter = false;
            this.nsgIGrid1.FrozenColumns = 0;
            this.nsgIGrid1.Grouping = true;
            this.nsgIGrid1.Hierarhy = true;
            this.nsgIGrid1.ImageList = null;
            this.nsgIGrid1.IsCanMultiSelect = false;
            this.nsgIGrid1.IsCanSingleSelect = false;
            this.nsgIGrid1.LineHeight = 20;
            this.nsgIGrid1.Location = new System.Drawing.Point(308, 12);
            this.nsgIGrid1.MarkReadOnly = false;
            this.nsgIGrid1.MasterObject = null;
            this.nsgIGrid1.Name = "NsgIGrid";
            this.nsgIGrid1.PageSelector = false;
            this.nsgIGrid1.ReadOnly = false;
            this.nsgIGrid1.RowChangeInterval = 200;
            this.nsgIGrid1.RowHeaderImageList = null;
            this.nsgIGrid1.RowMode = false;
            this.nsgIGrid1.ScrollWidth = 0;
            this.nsgIGrid1.SelectedRow = -1;
            this.nsgIGrid1.ShowHeader = true;
            this.nsgIGrid1.ShowLineImages = true;
            this.nsgIGrid1.ShowLineNumbers = false;
            this.nsgIGrid1.ShowPanel = true;
            this.nsgIGrid1.ShowTotals = false;
            this.nsgIGrid1.ShowTree = false;
            this.nsgIGrid1.Size = new System.Drawing.Size(538, 344);
            this.nsgIGrid1.SourceObject = this.vmoИтоги;
            this.nsgIGrid1.TabIndex = 21;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoИтоги
            // 
            this.vmoИтоги.Columns.Collection.Add(this.Номенклатура_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.НачОстаток_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.Приход_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.Расход_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.КонОстаток_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.НачОстатокКоличество_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.ПриходКоличество_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.РасходКоличество_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.КонОстатокКоличество_vmoИтоги);
            this.vmoИтоги.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoИтоги.MetaDataName = "";
            this.vmoИтоги.FullName = "";
            // 
            // Номенклатура_vmoИтоги
            // 
            this.Номенклатура_vmoИтоги.Caption = "Номенклатура";
            this.Номенклатура_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_vmoИтоги.Name = "Номенклатура";
            this.Номенклатура_vmoИтоги.NSGType = typeof(NSGAuto.Метаданные.Автосервис.Номенклатура);
            this.Номенклатура_vmoИтоги.PropertyType = typeof(NSGAuto.Метаданные.Автосервис.Номенклатура);
            this.Номенклатура_vmoИтоги.SearchCondition.OwnerComponent = this.Номенклатура_vmoИтоги;
            this.Номенклатура_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НачОстаток_vmoИтоги
            // 
            this.НачОстаток_vmoИтоги.CalcTotal = false;
            this.НачОстаток_vmoИтоги.Caption = "НачОстаток";
            this.НачОстаток_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НачОстаток_vmoИтоги.Name = "НачОстаток";
            this.НачОстаток_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.НачОстаток_vmoИтоги.PropertyType = typeof(decimal);
            this.НачОстаток_vmoИтоги.SearchCondition.OwnerComponent = this.НачОстаток_vmoИтоги;
            this.НачОстаток_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Приход_vmoИтоги
            // 
            this.Приход_vmoИтоги.CalcTotal = false;
            this.Приход_vmoИтоги.Caption = "Приход";
            this.Приход_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Приход_vmoИтоги.Name = "Приход";
            this.Приход_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Приход_vmoИтоги.PropertyType = typeof(decimal);
            this.Приход_vmoИтоги.SearchCondition.OwnerComponent = this.Приход_vmoИтоги;
            this.Приход_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Расход_vmoИтоги
            // 
            this.Расход_vmoИтоги.CalcTotal = false;
            this.Расход_vmoИтоги.Caption = "Расход";
            this.Расход_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Расход_vmoИтоги.Name = "Расход";
            this.Расход_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Расход_vmoИтоги.PropertyType = typeof(decimal);
            this.Расход_vmoИтоги.SearchCondition.OwnerComponent = this.Расход_vmoИтоги;
            this.Расход_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КонОстаток_vmoИтоги
            // 
            this.КонОстаток_vmoИтоги.CalcTotal = false;
            this.КонОстаток_vmoИтоги.Caption = "КонОстаток";
            this.КонОстаток_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КонОстаток_vmoИтоги.Name = "КонОстаток";
            this.КонОстаток_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.КонОстаток_vmoИтоги.PropertyType = typeof(decimal);
            this.КонОстаток_vmoИтоги.SearchCondition.OwnerComponent = this.КонОстаток_vmoИтоги;
            this.КонОстаток_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // НачОстатокКоличество_vmoИтоги
            // 
            this.НачОстатокКоличество_vmoИтоги.CalcTotal = false;
            this.НачОстатокКоличество_vmoИтоги.Caption = "НачОстатокКоличество";
            this.НачОстатокКоличество_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.НачОстатокКоличество_vmoИтоги.Name = "НачОстатокКоличество";
            this.НачОстатокКоличество_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.НачОстатокКоличество_vmoИтоги.PropertyType = typeof(decimal);
            this.НачОстатокКоличество_vmoИтоги.SearchCondition.OwnerComponent = this.НачОстатокКоличество_vmoИтоги;
            this.НачОстатокКоличество_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПриходКоличество_vmoИтоги
            // 
            this.ПриходКоличество_vmoИтоги.CalcTotal = false;
            this.ПриходКоличество_vmoИтоги.Caption = "ПриходКоличество";
            this.ПриходКоличество_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ПриходКоличество_vmoИтоги.Name = "ПриходКоличество";
            this.ПриходКоличество_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ПриходКоличество_vmoИтоги.PropertyType = typeof(decimal);
            this.ПриходКоличество_vmoИтоги.SearchCondition.OwnerComponent = this.ПриходКоличество_vmoИтоги;
            this.ПриходКоличество_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // РасходКоличество_vmoИтоги
            // 
            this.РасходКоличество_vmoИтоги.CalcTotal = false;
            this.РасходКоличество_vmoИтоги.Caption = "РасходКоличество";
            this.РасходКоличество_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.РасходКоличество_vmoИтоги.Name = "РасходКоличество";
            this.РасходКоличество_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.РасходКоличество_vmoИтоги.PropertyType = typeof(decimal);
            this.РасходКоличество_vmoИтоги.SearchCondition.OwnerComponent = this.РасходКоличество_vmoИтоги;
            this.РасходКоличество_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // КонОстатокКоличество_vmoИтоги
            // 
            this.КонОстатокКоличество_vmoИтоги.CalcTotal = false;
            this.КонОстатокКоличество_vmoИтоги.Caption = "КонОстатокКоличество";
            this.КонОстатокКоличество_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.КонОстатокКоличество_vmoИтоги.Name = "КонОстатокКоличество";
            this.КонОстатокКоличество_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.КонОстатокКоличество_vmoИтоги.PropertyType = typeof(decimal);
            this.КонОстатокКоличество_vmoИтоги.SearchCondition.OwnerComponent = this.КонОстатокКоличество_vmoИтоги;
            this.КонОстатокКоличество_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgGroupsList1
            // 
            this.nsgGroupsList1.AllowDrop = true;
            this.nsgGroupsList1.BackColor = System.Drawing.SystemColors.Control;
            this.nsgGroupsList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgGroupsList1.DisableComponents = ((System.Collections.Generic.List<string>)(resources.GetObject("nsgGroupsList1.DisableComponents")));
            this.nsgGroupsList1.Location = new System.Drawing.Point(12, 43);
            this.nsgGroupsList1.MinimumSize = new System.Drawing.Size(290, 150);
            this.nsgGroupsList1.Name = "NsgGroupsList";
            this.nsgGroupsList1.NsgRemoveMasterComponent = true;
            this.nsgGroupsList1.SetReport = this.nsgReport1;
            this.nsgGroupsList1.SetTitle = "title";
            this.nsgGroupsList1.Size = new System.Drawing.Size(290, 150);
            this.nsgGroupsList1.TabIndex = 16;
            // 
            // nsgReport1
            // 
            this.nsgReport1.CurrentProgressValue = 0;
            this.nsgReport1.HighlightedComponent = null;
            this.nsgReport1.IsSyncMode = true;
            this.nsgReport1.MaxProgressValue = 100;
            this.nsgReport1.OwnerForm = null;
            this.nsgReport1.ProgressEventType = NsgSoft.DataObjects.NsgThread.ProgressEventsType.Asynchronous;
            this.nsgReport1.ProgressObject = null;
            this.nsgReport1.ProgressProcentage = 0;
            this.nsgReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "NsgSoft.ReportControls.Dll",
        "NsgSoft.ReportBase.Dll",
        "NsgSoft.ReportBuilder.Dll",
        "NsgSoft.Common.Dll",
        "NsgSoft.Database.Dll",
        "NsgSoft.DataObjects.Dll",
        "NsgSoft.Design.Dll",
        "NsgSoft.Forms.Dll",
        "NsgSoft.FormsComponents.dll",
        "NsgSoft.Tools.dll",
        "NsgSoft.CityGuide.Dll"};
            this.nsgReport1.ReportAlias = "Отчет";
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource1);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource2);
            this.nsgReport1.ReportDataSources.Add(this.stiReportDataSource3);
            this.nsgReport1.ReportGuid = "702ff4fb3acd49cfa58262d278bb4513";
            this.nsgReport1.ReportLoaded = true;
            this.nsgReport1.ReportName = "Отчет";
            this.nsgReport1.ReportSource = resources.GetString("nsgReport1.ReportSource");
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
            // 
            // nsgReportDataSource1
            // 
            this.nsgReportDataSource1.MasterComponent = this.vmoИтоги;
            this.nsgReportDataSource1.Name = "nsgReportDataSource1";
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.nsgReportDataSource1;
            this.stiReportDataSource1.Name = "nsgReportDataSource1";
            // 
            // ДокDataSource
            // 
            this.ДокDataSource.MasterComponent = this.vmoДок;
            this.ДокDataSource.Name = "ДокDataSource";
            // 
            // vmoДок
            // 
            this.vmoДок.Columns.Collection.Add(this.Номенклатура_vmoДок);
            this.vmoДок.Columns.Collection.Add(this.Приход_vmoДок);
            this.vmoДок.Columns.Collection.Add(this.Расход_vmoДок);
            this.vmoДок.Columns.Collection.Add(this.Документ_vmoДок);
            this.vmoДок.Columns.Collection.Add(this.ПриходКоличество_vmoДок);
            this.vmoДок.Columns.Collection.Add(this.РасходКоличество_vmoДок);
            this.vmoДок.IsActive = true;
            this.vmoДок.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДок.MetaDataName = "";
            this.vmoДок.FullName = "";
            // 
            // Номенклатура_vmoДок
            // 
            this.Номенклатура_vmoДок.Caption = "Номенклатура";
            this.Номенклатура_vmoДок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Номенклатура_vmoДок.Name = "Номенклатура";
            this.Номенклатура_vmoДок.NSGType = typeof(NSGAuto.Метаданные.Автосервис.Номенклатура);
            this.Номенклатура_vmoДок.PropertyType = typeof(NSGAuto.Метаданные.Автосервис.Номенклатура);
            this.Номенклатура_vmoДок.SearchCondition.OwnerComponent = this.Номенклатура_vmoДок;
            this.Номенклатура_vmoДок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Приход_vmoДок
            // 
            this.Приход_vmoДок.CalcTotal = false;
            this.Приход_vmoДок.Caption = "Приход";
            this.Приход_vmoДок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Приход_vmoДок.Name = "Приход";
            this.Приход_vmoДок.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Приход_vmoДок.PropertyType = typeof(decimal);
            this.Приход_vmoДок.SearchCondition.OwnerComponent = this.Приход_vmoДок;
            this.Приход_vmoДок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Расход_vmoДок
            // 
            this.Расход_vmoДок.CalcTotal = false;
            this.Расход_vmoДок.Caption = "Расход";
            this.Расход_vmoДок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Расход_vmoДок.Name = "Расход";
            this.Расход_vmoДок.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Расход_vmoДок.PropertyType = typeof(decimal);
            this.Расход_vmoДок.SearchCondition.OwnerComponent = this.Расход_vmoДок;
            this.Расход_vmoДок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Документ_vmoДок
            // 
            this.Документ_vmoДок.Caption = "Документ";
            this.Документ_vmoДок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Документ_vmoДок.Name = "Документ";
            this.Документ_vmoДок.NSGType = typeof(NsgSoft.DataObjects.NsgDataUntypedReference);
            this.Документ_vmoДок.PropertyType = typeof(NsgSoft.DataObjects.NsgDataUntypedReference);
            this.Документ_vmoДок.ReferentFilter = new NsgSoft.DataObjects.NsgObjectsFilter(((NsgSoft.DataObjects.NsgFiltration)(NsgSoft.DataObjects.NsgFiltration.List)), new string[0]);
            this.Документ_vmoДок.SearchCondition.OwnerComponent = this.Документ_vmoДок;
            this.Документ_vmoДок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ПриходКоличество_vmoДок
            // 
            this.ПриходКоличество_vmoДок.CalcTotal = false;
            this.ПриходКоличество_vmoДок.Caption = "ПриходКоличество";
            this.ПриходКоличество_vmoДок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.ПриходКоличество_vmoДок.Name = "ПриходКоличество";
            this.ПриходКоличество_vmoДок.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.ПриходКоличество_vmoДок.PropertyType = typeof(decimal);
            this.ПриходКоличество_vmoДок.SearchCondition.OwnerComponent = this.ПриходКоличество_vmoДок;
            this.ПриходКоличество_vmoДок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // РасходКоличество_vmoДок
            // 
            this.РасходКоличество_vmoДок.CalcTotal = false;
            this.РасходКоличество_vmoДок.Caption = "РасходКоличество";
            this.РасходКоличество_vmoДок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.РасходКоличество_vmoДок.Name = "РасходКоличество";
            this.РасходКоличество_vmoДок.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.РасходКоличество_vmoДок.PropertyType = typeof(decimal);
            this.РасходКоличество_vmoДок.SearchCondition.OwnerComponent = this.РасходКоличество_vmoДок;
            this.РасходКоличество_vmoДок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.ДокDataSource;
            this.stiReportDataSource2.Name = "ДокDataSource";
            // 
            // ЗаголовокDataSource
            // 
            this.ЗаголовокDataSource.MasterComponent = this.vmoЗаголовок;
            this.ЗаголовокDataSource.Name = "ЗаголовокDataSource";
            this.ЗаголовокDataSource.Records = NsgSoft.Forms.NsgSourceRows.CurentRow;
            // 
            // vmoЗаголовок
            // 
            this.vmoЗаголовок.Columns.Collection.Add(this.Период_vmoЗаголовок);
            this.vmoЗаголовок.Columns.Collection.Add(this.Фильтр_vmoЗаголовок);
            this.vmoЗаголовок.IsActive = true;
            this.vmoЗаголовок.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoЗаголовок.MetaDataName = "";
            this.vmoЗаголовок.FullName = "";
            // 
            // Период_vmoЗаголовок
            // 
            this.Период_vmoЗаголовок.Caption = "Период";
            this.Период_vmoЗаголовок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Период_vmoЗаголовок.Name = "Период";
            this.Период_vmoЗаголовок.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Период_vmoЗаголовок.PropertyType = typeof(string);
            this.Период_vmoЗаголовок.SearchCondition.OwnerComponent = this.Период_vmoЗаголовок;
            this.Период_vmoЗаголовок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Фильтр_vmoЗаголовок
            // 
            this.Фильтр_vmoЗаголовок.Caption = "Фильтр";
            this.Фильтр_vmoЗаголовок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Фильтр_vmoЗаголовок.Name = "Фильтр";
            this.Фильтр_vmoЗаголовок.NSGType = typeof(NsgSoft.DataObjects.NsgDataString);
            this.Фильтр_vmoЗаголовок.PropertyType = typeof(string);
            this.Фильтр_vmoЗаголовок.SearchCondition.OwnerComponent = this.Фильтр_vmoЗаголовок;
            this.Фильтр_vmoЗаголовок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // stiReportDataSource3
            // 
            this.stiReportDataSource3.Item = this.ЗаголовокDataSource;
            this.stiReportDataSource3.Name = "ЗаголовокDataSource";
            // 
            // nsgPeriodPicker1
            // 
            this.nsgPeriodPicker1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.nsgPeriodPicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgPeriodPicker1.Location = new System.Drawing.Point(63, 12);
            this.nsgPeriodPicker1.MinimumSize = new System.Drawing.Size(2, 4);
            this.nsgPeriodPicker1.Name = "NsgPeriodPicker";
            this.nsgPeriodPicker1.Size = new System.Drawing.Size(151, 27);
            this.nsgPeriodPicker1.TabIndex = 20;
            // 
            // nsgLabel2
            // 
            this.nsgLabel2.AutoSize = true;
            this.nsgLabel2.ConfigurationName = "";
            this.nsgLabel2.FullName = "";
            this.nsgLabel2.IsInitialized = false;
            this.nsgLabel2.Location = new System.Drawing.Point(12, 21);
            this.nsgLabel2.MetaDataName = "";
            this.nsgLabel2.Name = "nsgLabel1";
            this.nsgLabel2.Requsite = "";
            this.nsgLabel2.Size = new System.Drawing.Size(45, 13);
            this.nsgLabel2.TabIndex = 19;
            this.nsgLabel2.Text = "Период";
            // 
            // nsgButton1
            // 
            this.nsgButton1.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nsgButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nsgButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nsgButton1.Location = new System.Drawing.Point(220, 12);
            this.nsgButton1.Name = "NsgButton";
            this.nsgButton1.Size = new System.Drawing.Size(82, 25);
            this.nsgButton1.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.nsgButton1.TabIndex = 18;
            this.nsgButton1.Text = "Просмотр";
            this.nsgButton1.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nsgButton1.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton1_AsyncClick);
            // 
            // Период
            // 
            this.Период.Caption = "Период";
            this.Период.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Период.Name = "Период";
            this.Период.NSGType = typeof(NsgSoft.DataObjects.NsgDataPeriod);
            this.Период.PropertyType = typeof(NsgSoft.DataObjects.NsgDataPeriod);
            this.Период.SearchCondition.OwnerComponent = this.Период;
            this.Период.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ОстаткиОтчетФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(858, 410);
            this.Controls.Add(this.nsgGroupsList1);
            this.Controls.Add(this.nsgObjectFilter1);
            this.Controls.Add(this.nsgIGrid1);
            this.Controls.Add(this.nsgPeriodPicker1);
            this.Controls.Add(this.nsgLabel2);
            this.Controls.Add(this.nsgButton1);
            this.Controls.Add(this.panelButtonReportForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.MainReport = null;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NsgReportForm";
            this.SelectedObject = null;
            this.TabText = "NsgMultipleObjectBaseForm";
            this.Text = "NsgReportForm";
            this.Controls.SetChildIndex(this.panelButtonReportForm, 0);
            this.Controls.SetChildIndex(this.nsgButton1, 0);
            this.Controls.SetChildIndex(this.nsgLabel2, 0);
            this.Controls.SetChildIndex(this.nsgPeriodPicker1, 0);
            this.Controls.SetChildIndex(this.nsgIGrid1, 0);
            this.Controls.SetChildIndex(this.nsgObjectFilter1, 0);
            this.Controls.SetChildIndex(this.nsgGroupsList1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтоги)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgReportDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ДокDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДок)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ЗаголовокDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoЗаголовок)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NsgSoft.ReportBuilder.NsgReport nsgReport1;
        private NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter1;
        private NsgVisualMultipleObject vmoФильтр;
        private NsgIGrid nsgIGrid1;
        private NsgVisualMultipleObject vmoИтоги;
        private NsgVisualMultipleObject vmoДок;
        private NsgSoft.ReportBuilder.NsgReportDataSource nsgReportDataSource1;
        private NsgSoft.ReportBuilder.NsgReportDataSource ДокDataSource;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource3;
        private NsgVisualMultipleObject vmoЗаголовок;
        private Номенклатура.ColumnDescriptor Номенклатура_vmoИтоги;
        private NsgColumnDescriptor.Decimal НачОстаток_vmoИтоги;
        private NsgColumnDescriptor.Decimal Приход_vmoИтоги;
        private NsgColumnDescriptor.Decimal Расход_vmoИтоги;
        private NsgColumnDescriptor.Decimal КонОстаток_vmoИтоги;
        private NsgSoft.ReportBuilder.NsgGroupsList nsgGroupsList1;
        private NsgPeriodPicker nsgPeriodPicker1;
        private NsgLabel nsgLabel2;
        private NsgColumnDescriptor Период;
        private NsgSoft.Design.NsgButton nsgButton1;
        private Номенклатура.ColumnDescriptor Номенклатура_vmoДок;
        private NsgColumnDescriptor.Decimal Приход_vmoДок;
        private NsgColumnDescriptor.Decimal Расход_vmoДок;
        private NsgColumnDescriptor.UntypedMultipleObject Документ_vmoДок;
        private Номенклатура.ColumnDescriptor Номенклатура_vmoФильтр;
        private NsgColumnDescriptor.Decimal НачОстатокКоличество_vmoИтоги;
        private NsgColumnDescriptor.Decimal ПриходКоличество_vmoИтоги;
        private NsgColumnDescriptor.Decimal РасходКоличество_vmoИтоги;
        private NsgColumnDescriptor.Decimal КонОстатокКоличество_vmoИтоги;
        private NsgColumnDescriptor.Decimal ПриходКоличество_vmoДок;
        private NsgColumnDescriptor.Decimal РасходКоличество_vmoДок;
        private NsgColumnDescriptor.String Период_vmoЗаголовок;
        private NsgColumnDescriptor.String Фильтр_vmoЗаголовок;
        private NsgSoft.ReportBuilder.NsgReportDataSource ЗаголовокDataSource;
    }
}