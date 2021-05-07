using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace NSGAuto.Метаданные.Автосервис

{
    
    public partial class ПродажиОтчетФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПродажиОтчетФорма));
            NsgSoft.Forms.NsgGridColumn nsgGridColumn1 = new NsgSoft.Forms.NsgGridColumn();
            NsgSoft.Forms.NsgGridColumn nsgGridColumn2 = new NsgSoft.Forms.NsgGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn1 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn2 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn3 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn4 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn5 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn6 = new NsgSoft.Forms.NsgIGridColumn();
            this.NsgObjectFilter = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.vmoФильтр = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.NsgIGrid = new NsgSoft.Forms.NsgIGrid();
            this.vmoИтоги = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.NsgGroupsList = new NsgSoft.ReportBuilder.NsgGroupsList();
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.nsgReportDataSource1 = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("nsgReportDataSource1", this.nsgReportDataSource1);
            this.ДокDataSource = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoДок = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("ДокDataSource", this.ДокDataSource);
            this.NsgPeriodPicker = new NsgSoft.Forms.NsgPeriodPicker();
            this.nsgLabel1 = new NsgSoft.Forms.NsgLabel();
            this.NsgButton = new NsgSoft.Design.NsgButton();
            this.Количество_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Сумма_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Прибыль_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Рентабильность_vmoИтоги = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Количество_vmoДок = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Сумма_vmoДок = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Прибыль_vmoДок = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Рентабельность_vmoДок = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.Период = new NsgSoft.Forms.NsgColumnDescriptor();
            this.Контрагент_vmoИтоги = new NSGAuto.Метаданные.Автосервис.Контрагент.ColumnDescriptor();
            this.Номенклатура_vmoИтоги = new NSGAuto.Метаданные.Автосервис.Номенклатура.ColumnDescriptor();
            this.Номенклатура_vmoДок = new NSGAuto.Метаданные.Автосервис.Номенклатура.ColumnDescriptor();
            this.Контрагент_vmoДок = new NSGAuto.Метаданные.Автосервис.Контрагент.ColumnDescriptor();
            this.Контрагент_vmoФильтр = new NSGAuto.Метаданные.Автосервис.Контрагент.ColumnDescriptor();
            this.Номенклатура_vmoФильтр = new NSGAuto.Метаданные.Автосервис.Номенклатура.ColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NsgObjectFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NsgIGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтоги)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NsgGroupsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgReportDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ДокDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДок)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NsgButton)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 383);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(839, 28);
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
            this.printButton.Location = new System.Drawing.Point(819, 0);
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
            // NsgObjectFilter
            // 
            this.NsgObjectFilter.AllowDrop = true;
            this.NsgObjectFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NsgObjectFilter.AutoSetCompare = true;
            this.NsgObjectFilter.BackColor = System.Drawing.SystemColors.Control;
            nsgGridColumn1.Caption = "";
            nsgGridColumn1.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn1.ImportedFromVMO = false;
            nsgGridColumn1.Name = "Номенклатура";
            nsgGridColumn1.Root = this.NsgObjectFilter.Columns.Collection;
            nsgGridColumn2.Caption = "";
            nsgGridColumn2.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn2.ImportedFromVMO = false;
            nsgGridColumn2.Name = "Контрагент";
            nsgGridColumn2.Root = this.NsgObjectFilter.Columns.Collection;
            this.NsgObjectFilter.Columns.Collection.Add(nsgGridColumn1);
            this.NsgObjectFilter.Columns.Collection.Add(nsgGridColumn2);
            this.NsgObjectFilter.FilterTypeCaption = "Тип Фильтра";
            this.NsgObjectFilter.Grouping = false;
            this.NsgObjectFilter.IsModify = true;
            this.NsgObjectFilter.LineHeight = 20;
            this.NsgObjectFilter.Location = new System.Drawing.Point(12, 199);
            this.NsgObjectFilter.LockAdditionalColumns = false;
            this.NsgObjectFilter.LockUpdateColumnsFromSourceObject = false;
            this.NsgObjectFilter.Name = "NsgObjectFilter";
            this.NsgObjectFilter.ReadOnly = false;
            this.NsgObjectFilter.Regime = NsgSoft.Forms.NsgIGridView.NsgObjectFilter.Regimes.Filter;
            this.NsgObjectFilter.RekvisitCaption = "Имя Фильтра";
            this.NsgObjectFilter.SaveSettings = true;
            this.NsgObjectFilter.Size = new System.Drawing.Size(290, 158);
            this.NsgObjectFilter.SourceObject = this.vmoФильтр;
            this.NsgObjectFilter.TabIndex = 23;
            this.NsgObjectFilter.ValueCaption = "Фильтр";
            // 
            // vmoФильтр
            // 
            this.vmoФильтр.Columns.Collection.Add(this.Контрагент_vmoФильтр);
            this.vmoФильтр.Columns.Collection.Add(this.Номенклатура_vmoФильтр);
            this.vmoФильтр.IsActive = true;
            this.vmoФильтр.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoФильтр.MetaDataName = "";
            this.vmoФильтр.FullName = "";
            // 
            // NsgIGrid
            // 
            this.NsgIGrid.Action = NsgSoft.DataObjects.FormShowMode.None;
            this.NsgIGrid.AllowSaveColParamsToXML = true;
            this.NsgIGrid.AllowSaveColPositionToXML = true;
            this.NsgIGrid.AllowSaveColWidthToXML = true;
            this.NsgIGrid.AllowSaveSettingsToXML = true;
            this.NsgIGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NsgIGrid.AutoResizeCols = true;
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
            nsgIGridColumn1.Name = "Контрагент";
            nsgIGridColumn1.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn1.Root = this.NsgIGrid.Columns.Collection;
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
            nsgIGridColumn2.Name = "Номенклатура";
            nsgIGridColumn2.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn2.Root = this.NsgIGrid.Columns.Collection;
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
            nsgIGridColumn3.Name = "Количество";
            nsgIGridColumn3.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn3.Root = this.NsgIGrid.Columns.Collection;
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
            nsgIGridColumn4.Name = "Цена";
            nsgIGridColumn4.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn4.Root = this.NsgIGrid.Columns.Collection;
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
            nsgIGridColumn5.Name = "Прибыль";
            nsgIGridColumn5.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn5.Root = this.NsgIGrid.Columns.Collection;
            nsgIGridColumn5.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn5.UseAsHeaderImage = false;
            nsgIGridColumn5.Width = 100;
            nsgIGridColumn6.AllowFilter = true;
            nsgIGridColumn6.AllowGroupSelect = false;
            nsgIGridColumn6.AllowResize = true;
            nsgIGridColumn6.AutoResize = true;
            nsgIGridColumn6.Caption = "";
            nsgIGridColumn6.ChangedProperties = new string[] {
        "Visible",
        "Index"};
            nsgIGridColumn6.DateFormat = null;
            nsgIGridColumn6.ImportedFromVMO = false;
            nsgIGridColumn6.Name = "Рентабильность";
            nsgIGridColumn6.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn6.Root = this.NsgIGrid.Columns.Collection;
            nsgIGridColumn6.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn6.UseAsHeaderImage = false;
            nsgIGridColumn6.Width = 100;
            this.NsgIGrid.Columns.Collection.Add(nsgIGridColumn1);
            this.NsgIGrid.Columns.Collection.Add(nsgIGridColumn2);
            this.NsgIGrid.Columns.Collection.Add(nsgIGridColumn3);
            this.NsgIGrid.Columns.Collection.Add(nsgIGridColumn4);
            this.NsgIGrid.Columns.Collection.Add(nsgIGridColumn5);
            this.NsgIGrid.Columns.Collection.Add(nsgIGridColumn6);
            this.NsgIGrid.Filter = false;
            this.NsgIGrid.FrozenColumns = 0;
            this.NsgIGrid.Grouping = true;
            this.NsgIGrid.Hierarhy = true;
            this.NsgIGrid.ImageList = null;
            this.NsgIGrid.IsCanMultiSelect = false;
            this.NsgIGrid.IsCanSingleSelect = false;
            this.NsgIGrid.LineHeight = 20;
            this.NsgIGrid.Location = new System.Drawing.Point(308, 12);
            this.NsgIGrid.MarkReadOnly = false;
            this.NsgIGrid.MasterObject = null;
            this.NsgIGrid.Name = "NsgIGrid";
            this.NsgIGrid.PageSelector = false;
            this.NsgIGrid.ReadOnly = false;
            this.NsgIGrid.RowChangeInterval = 200;
            this.NsgIGrid.RowHeaderImageList = null;
            this.NsgIGrid.RowMode = false;
            this.NsgIGrid.ScrollWidth = 0;
            this.NsgIGrid.SelectedRow = -1;
            this.NsgIGrid.ShowHeader = true;
            this.NsgIGrid.ShowLineImages = true;
            this.NsgIGrid.ShowLineNumbers = false;
            this.NsgIGrid.ShowPanel = true;
            this.NsgIGrid.ShowTotals = false;
            this.NsgIGrid.ShowTree = false;
            this.NsgIGrid.Size = new System.Drawing.Size(519, 345);
            this.NsgIGrid.SourceObject = this.vmoИтоги;
            this.NsgIGrid.TabIndex = 27;
            this.NsgIGrid.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoИтоги
            // 
            this.vmoИтоги.Columns.Collection.Add(this.Количество_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.Сумма_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.Прибыль_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.Контрагент_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.Рентабильность_vmoИтоги);
            this.vmoИтоги.Columns.Collection.Add(this.Номенклатура_vmoИтоги);
            this.vmoИтоги.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoИтоги.MetaDataName = "";
            this.vmoИтоги.FullName = "";
            // 
            // NsgGroupsList
            // 
            this.NsgGroupsList.AllowDrop = true;
            this.NsgGroupsList.BackColor = System.Drawing.SystemColors.Control;
            this.NsgGroupsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NsgGroupsList.DisableComponents = ((System.Collections.Generic.List<string>)(resources.GetObject("NsgGroupsList.DisableComponents")));
            this.NsgGroupsList.Location = new System.Drawing.Point(12, 43);
            this.NsgGroupsList.MinimumSize = new System.Drawing.Size(290, 150);
            this.NsgGroupsList.Name = "NsgGroupsList";
            this.NsgGroupsList.NsgRemoveMasterComponent = true;
            this.NsgGroupsList.SetReport = this.nsgReport1;
            this.NsgGroupsList.SetTitle = "title";
            this.NsgGroupsList.Size = new System.Drawing.Size(290, 150);
            this.NsgGroupsList.TabIndex = 22;
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
            this.nsgReport1.ReportGuid = "aa5683170273477ca85cc0d739d4e168";
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
            this.vmoДок.Columns.Collection.Add(this.Количество_vmoДок);
            this.vmoДок.Columns.Collection.Add(this.Сумма_vmoДок);
            this.vmoДок.Columns.Collection.Add(this.Прибыль_vmoДок);
            this.vmoДок.Columns.Collection.Add(this.Рентабельность_vmoДок);
            this.vmoДок.Columns.Collection.Add(this.Контрагент_vmoДок);
            this.vmoДок.IsActive = true;
            this.vmoДок.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДок.MetaDataName = "";
            this.vmoДок.FullName = "";
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.ДокDataSource;
            this.stiReportDataSource2.Name = "ДокDataSource";
            // 
            // NsgPeriodPicker
            // 
            this.NsgPeriodPicker.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.NsgPeriodPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NsgPeriodPicker.Location = new System.Drawing.Point(63, 12);
            this.NsgPeriodPicker.MinimumSize = new System.Drawing.Size(2, 4);
            this.NsgPeriodPicker.Name = "NsgPeriodPicker";
            this.NsgPeriodPicker.Size = new System.Drawing.Size(151, 27);
            this.NsgPeriodPicker.TabIndex = 26;
            // 
            // nsgLabel1
            // 
            this.nsgLabel1.AutoSize = true;
            this.nsgLabel1.ConfigurationName = "";
            this.nsgLabel1.FullName = "";
            this.nsgLabel1.IsInitialized = false;
            this.nsgLabel1.Location = new System.Drawing.Point(12, 21);
            this.nsgLabel1.MetaDataName = "";
            this.nsgLabel1.Name = "nsgLabel1";
            this.nsgLabel1.Requsite = "";
            this.nsgLabel1.Size = new System.Drawing.Size(45, 13);
            this.nsgLabel1.TabIndex = 25;
            this.nsgLabel1.Text = "Период";
            // 
            // NsgButton
            // 
            this.NsgButton.ActiveBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NsgButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NsgButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NsgButton.Location = new System.Drawing.Point(220, 12);
            this.NsgButton.Name = "NsgButton";
            this.NsgButton.Size = new System.Drawing.Size(82, 25);
            this.NsgButton.StatesCollection = new NsgSoft.Design.NsgButton.StateCollectionElemnt[0];
            this.NsgButton.TabIndex = 24;
            this.NsgButton.Text = "Просмотр";
            this.NsgButton.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.NsgButton.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.NsgButton_AsyncClick);
            // 
            // Количество_vmoИтоги
            // 
            this.Количество_vmoИтоги.CalcTotal = false;
            this.Количество_vmoИтоги.Caption = "Количество";
            this.Количество_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Количество_vmoИтоги.Name = "Количество";
            this.Количество_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Количество_vmoИтоги.PropertyType = typeof(decimal);
            this.Количество_vmoИтоги.SearchCondition.OwnerComponent = this.Количество_vmoИтоги;
            this.Количество_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сумма_vmoИтоги
            // 
            this.Сумма_vmoИтоги.CalcTotal = false;
            this.Сумма_vmoИтоги.Caption = "Цена";
            this.Сумма_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сумма_vmoИтоги.Name = "Цена";
            this.Сумма_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Сумма_vmoИтоги.PropertyType = typeof(decimal);
            this.Сумма_vmoИтоги.SearchCondition.OwnerComponent = this.Сумма_vmoИтоги;
            this.Сумма_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Прибыль_vmoИтоги
            // 
            this.Прибыль_vmoИтоги.CalcTotal = false;
            this.Прибыль_vmoИтоги.Caption = "Прибыль";
            this.Прибыль_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Прибыль_vmoИтоги.Name = "Прибыль";
            this.Прибыль_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Прибыль_vmoИтоги.PropertyType = typeof(decimal);
            this.Прибыль_vmoИтоги.SearchCondition.OwnerComponent = this.Прибыль_vmoИтоги;
            this.Прибыль_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Рентабильность_vmoИтоги
            // 
            this.Рентабильность_vmoИтоги.CalcTotal = false;
            this.Рентабильность_vmoИтоги.Caption = "Рентабильность";
            this.Рентабильность_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Рентабильность_vmoИтоги.Name = "Рентабильность";
            this.Рентабильность_vmoИтоги.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Рентабильность_vmoИтоги.PropertyType = typeof(decimal);
            this.Рентабильность_vmoИтоги.SearchCondition.OwnerComponent = this.Рентабильность_vmoИтоги;
            this.Рентабильность_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Количество_vmoДок
            // 
            this.Количество_vmoДок.CalcTotal = false;
            this.Количество_vmoДок.Caption = "Количество";
            this.Количество_vmoДок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Количество_vmoДок.Name = "Количество";
            this.Количество_vmoДок.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Количество_vmoДок.PropertyType = typeof(decimal);
            this.Количество_vmoДок.SearchCondition.OwnerComponent = this.Количество_vmoДок;
            this.Количество_vmoДок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Сумма_vmoДок
            // 
            this.Сумма_vmoДок.CalcTotal = false;
            this.Сумма_vmoДок.Caption = "Цена";
            this.Сумма_vmoДок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Сумма_vmoДок.Name = "Цена";
            this.Сумма_vmoДок.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Сумма_vmoДок.PropertyType = typeof(decimal);
            this.Сумма_vmoДок.SearchCondition.OwnerComponent = this.Сумма_vmoДок;
            this.Сумма_vmoДок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Прибыль_vmoДок
            // 
            this.Прибыль_vmoДок.CalcTotal = false;
            this.Прибыль_vmoДок.Caption = "Прибыль";
            this.Прибыль_vmoДок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Прибыль_vmoДок.Name = "Прибыль";
            this.Прибыль_vmoДок.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Прибыль_vmoДок.PropertyType = typeof(decimal);
            this.Прибыль_vmoДок.SearchCondition.OwnerComponent = this.Прибыль_vmoДок;
            this.Прибыль_vmoДок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Рентабельность_vmoДок
            // 
            this.Рентабельность_vmoДок.CalcTotal = false;
            this.Рентабельность_vmoДок.Caption = "Рентабельность";
            this.Рентабельность_vmoДок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Рентабельность_vmoДок.Name = "Рентабельность";
            this.Рентабельность_vmoДок.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.Рентабельность_vmoДок.PropertyType = typeof(decimal);
            this.Рентабельность_vmoДок.SearchCondition.OwnerComponent = this.Рентабельность_vmoДок;
            this.Рентабельность_vmoДок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // Контрагент_vmoИтоги
            // 
            this.Контрагент_vmoИтоги.Caption = "Контрагент";
            this.Контрагент_vmoИтоги.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Контрагент_vmoИтоги.Name = "Контрагент";
            this.Контрагент_vmoИтоги.NSGType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.Контрагент_vmoИтоги.PropertyType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.Контрагент_vmoИтоги.SearchCondition.OwnerComponent = this.Контрагент_vmoИтоги;
            this.Контрагент_vmoИтоги.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // Контрагент_vmoДок
            // 
            this.Контрагент_vmoДок.Caption = "Контрагент";
            this.Контрагент_vmoДок.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Контрагент_vmoДок.Name = "Контрагент";
            this.Контрагент_vmoДок.NSGType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.Контрагент_vmoДок.PropertyType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.Контрагент_vmoДок.SearchCondition.OwnerComponent = this.Контрагент_vmoДок;
            this.Контрагент_vmoДок.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // Контрагент_vmoФильтр
            // 
            this.Контрагент_vmoФильтр.Caption = "Контрагент";
            this.Контрагент_vmoФильтр.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Контрагент_vmoФильтр.Name = "Контрагент";
            this.Контрагент_vmoФильтр.NSGType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.Контрагент_vmoФильтр.PropertyType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.Контрагент_vmoФильтр.SearchCondition.OwnerComponent = this.Контрагент_vmoФильтр;
            this.Контрагент_vmoФильтр.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            // ПродажиОтчетФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(839, 411);
            this.Controls.Add(this.NsgGroupsList);
            this.Controls.Add(this.NsgObjectFilter);
            this.Controls.Add(this.NsgIGrid);
            this.Controls.Add(this.NsgPeriodPicker);
            this.Controls.Add(this.nsgLabel1);
            this.Controls.Add(this.NsgButton);
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
            this.Controls.SetChildIndex(this.NsgButton, 0);
            this.Controls.SetChildIndex(this.nsgLabel1, 0);
            this.Controls.SetChildIndex(this.NsgPeriodPicker, 0);
            this.Controls.SetChildIndex(this.NsgIGrid, 0);
            this.Controls.SetChildIndex(this.NsgObjectFilter, 0);
            this.Controls.SetChildIndex(this.NsgGroupsList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).EndInit();
            this.panelButtonReportForm.ResumeLayout(false);
            this.panelButtonReportForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NsgObjectFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NsgIGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтоги)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NsgGroupsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgReportDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ДокDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДок)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NsgButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected NsgSoft.ReportBuilder.NsgGroupsList NsgGroupsList;
        protected NsgPeriodPicker NsgPeriodPicker;
        protected NsgLabel nsgLabel1;
        protected NsgSoft.Design.NsgButton NsgButton;
        protected NsgColumnDescriptor.Decimal Количество_vmoИтоги;
        private NsgSoft.ReportBuilder.NsgReport nsgReport1;
        private NsgSoft.Forms.NsgIGridView.NsgObjectFilter NsgObjectFilter;
        protected NsgColumnDescriptor Период;
        protected NsgColumnDescriptor.Decimal Сумма_vmoИтоги;
        protected NsgColumnDescriptor.Decimal Прибыль_vmoИтоги;
        protected Контрагент.ColumnDescriptor Контрагент_vmoФильтр;
        protected Номенклатура.ColumnDescriptor Номенклатура_vmoФильтр;
        protected Контрагент.ColumnDescriptor Контрагент_vmoИтоги;
        protected NsgColumnDescriptor.Decimal Рентабильность_vmoИтоги;
        protected Номенклатура.ColumnDescriptor Номенклатура_vmoДок;
        protected NsgColumnDescriptor.Decimal Количество_vmoДок;
        protected NsgColumnDescriptor.Decimal Сумма_vmoДок;
        protected NsgColumnDescriptor.Decimal Прибыль_vmoДок;
        protected NsgColumnDescriptor.Decimal Рентабельность_vmoДок;
        protected Контрагент.ColumnDescriptor Контрагент_vmoДок;
        protected Номенклатура.ColumnDescriptor Номенклатура_vmoИтоги;
        protected NsgSoft.ReportBuilder.NsgReportDataSource nsgReportDataSource1;
        protected NsgSoft.ReportBuilder.NsgReportDataSource ДокDataSource;
        protected NsgIGrid NsgIGrid;
        protected NsgVisualMultipleObject vmoИтоги;
        protected NsgVisualMultipleObject vmoФильтр;
        protected NsgVisualMultipleObject vmoДок;
        protected NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        protected NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
    }
}