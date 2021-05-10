using NsgSoft.Forms;
using NsgSoft.DataObjects;
namespace NSGAuto.Метаданные.Автосервис

{
    
    public partial class ДолгиФорма:NsgSoft.Forms.NsgReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ДолгиФорма));
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn6 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn7 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn8 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn9 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgIGridColumn nsgIGridColumn10 = new NsgSoft.Forms.NsgIGridColumn();
            NsgSoft.Forms.NsgGridColumn nsgGridColumn2 = new NsgSoft.Forms.NsgGridColumn();
            this.nsgIGrid1 = new NsgSoft.Forms.NsgIGrid();
            this.vmoИтоги = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.vmoИтоги_Контрагент = new NSGAuto.Метаданные.Автосервис.Контрагент.ColumnDescriptor();
            this.vmoИтоги_НачОстаток = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoИтоги_Приход = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoИтоги_Расход = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoИтоги_КонОстаток = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.nsgObjectFilter1 = new NsgSoft.Forms.NsgIGridView.NsgObjectFilter();
            this.vmoФильтр = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.vmoФильтр_Контрагент = new NSGAuto.Метаданные.Автосервис.Контрагент.ColumnDescriptor();
            this.nsgButton1 = new NsgSoft.Design.NsgButton();
            this.nsgLabel2 = new NsgSoft.Forms.NsgLabel();
            this.nsgPeriodPicker1 = new NsgSoft.Forms.NsgPeriodPicker();
            this.nsgReportDataSource1 = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.nsgReport1 = new NsgSoft.ReportBuilder.NsgReport(this.components);
            this.stiReportDataSource1 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("nsgReportDataSource1", this.nsgReportDataSource1);
            this.ДокDataSource = new NsgSoft.ReportBuilder.NsgReportDataSource(this.components);
            this.vmoДок = new NsgSoft.Forms.NsgVisualMultipleObject(this.components);
            this.vmoДок_Контрагент = new NSGAuto.Метаданные.Автосервис.Контрагент.ColumnDescriptor();
            this.vmoДок_Приход = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoДок_Расход = new NsgSoft.Forms.NsgColumnDescriptor.Decimal();
            this.vmoДок_Документ = new NsgSoft.Forms.NsgColumnDescriptor.UntypedMultipleObject();
            this.stiReportDataSource2 = new NsgSoft.ReportBuilder.Design.StiReportDataSource("ДокDataSource", this.ДокDataSource);
            this.Период = new NsgSoft.Forms.NsgColumnDescriptor();
            this.nsgGroupsList1 = new NsgSoft.ReportBuilder.NsgGroupsList();
            this.Контрагент = new NSGAuto.Метаданные.Автосервис.Контрагент.ColumnDescriptor();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateReport)).BeginInit();
            this.panelButtonReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formSettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgVisualMultipleObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтоги)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgReportDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ДокDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДок)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).BeginInit();
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
            this.panelButtonReportForm.Location = new System.Drawing.Point(0, 370);
            this.panelButtonReportForm.Name = "panelButtonReportForm";
            this.panelButtonReportForm.Size = new System.Drawing.Size(802, 28);
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
            this.printButton.Location = new System.Drawing.Point(782, 0);
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
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Контрагент);
            this.nsgVisualMultipleObject.Columns.Collection.Add(this.Период);
            this.nsgVisualMultipleObject.IsActive = true;
            this.nsgVisualMultipleObject.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.nsgVisualMultipleObject.MetaDataName = "";
            this.nsgVisualMultipleObject.FullName = "";
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
            nsgIGridColumn6.AllowFilter = true;
            nsgIGridColumn6.AllowGroupSelect = false;
            nsgIGridColumn6.AllowResize = true;
            nsgIGridColumn6.AutoResize = true;
            nsgIGridColumn6.Caption = "";
            nsgIGridColumn6.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn6.DateFormat = null;
            nsgIGridColumn6.Name = "Контрагент";
            nsgIGridColumn6.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn6.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn6.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn6.UseAsHeaderImage = false;
            nsgIGridColumn6.Width = 100;
            nsgIGridColumn7.AllowFilter = true;
            nsgIGridColumn7.AllowGroupSelect = false;
            nsgIGridColumn7.AllowResize = true;
            nsgIGridColumn7.AutoResize = true;
            nsgIGridColumn7.Caption = "";
            nsgIGridColumn7.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn7.DateFormat = null;
            nsgIGridColumn7.Name = "НачОстаток";
            nsgIGridColumn7.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn7.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn7.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn7.UseAsHeaderImage = false;
            nsgIGridColumn7.Width = 100;
            nsgIGridColumn8.AllowFilter = true;
            nsgIGridColumn8.AllowGroupSelect = false;
            nsgIGridColumn8.AllowResize = true;
            nsgIGridColumn8.AutoResize = true;
            nsgIGridColumn8.Caption = "";
            nsgIGridColumn8.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn8.DateFormat = null;
            nsgIGridColumn8.Name = "Приход";
            nsgIGridColumn8.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn8.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn8.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn8.UseAsHeaderImage = false;
            nsgIGridColumn8.Width = 100;
            nsgIGridColumn9.AllowFilter = true;
            nsgIGridColumn9.AllowGroupSelect = false;
            nsgIGridColumn9.AllowResize = true;
            nsgIGridColumn9.AutoResize = true;
            nsgIGridColumn9.Caption = "";
            nsgIGridColumn9.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn9.DateFormat = null;
            nsgIGridColumn9.Name = "Расход";
            nsgIGridColumn9.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn9.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn9.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn9.UseAsHeaderImage = false;
            nsgIGridColumn9.Width = 100;
            nsgIGridColumn10.AllowFilter = true;
            nsgIGridColumn10.AllowGroupSelect = false;
            nsgIGridColumn10.AllowResize = true;
            nsgIGridColumn10.AutoResize = true;
            nsgIGridColumn10.Caption = "";
            nsgIGridColumn10.ChangedProperties = new string[] {
        "Visible"};
            nsgIGridColumn10.DateFormat = null;
            nsgIGridColumn10.Name = "КонОстаток";
            nsgIGridColumn10.Position = ((NsgSoft.Forms.NsgIGrid.ColumnPosition)(NsgSoft.Forms.NsgIGrid.ColumnPosition.NextColumn));
            nsgIGridColumn10.Root = this.nsgIGrid1.Columns.Collection;
            nsgIGridColumn10.SortDirection = NsgSoft.Database.NsgSortDirection.None;
            nsgIGridColumn10.UseAsHeaderImage = false;
            nsgIGridColumn10.Width = 100;
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn6);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn7);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn8);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn9);
            this.nsgIGrid1.Columns.Collection.Add(nsgIGridColumn10);
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
            this.nsgIGrid1.Size = new System.Drawing.Size(482, 352);
            this.nsgIGrid1.SourceObject = this.vmoИтоги;
            this.nsgIGrid1.TabIndex = 15;
            this.nsgIGrid1.TableType = NsgSoft.Forms.NsgIGrid.TableTypes.Journal;
            // 
            // vmoИтоги
            // 
            this.vmoИтоги.Columns.Collection.Add(this.vmoИтоги_Контрагент);
            this.vmoИтоги.Columns.Collection.Add(this.vmoИтоги_НачОстаток);
            this.vmoИтоги.Columns.Collection.Add(this.vmoИтоги_Приход);
            this.vmoИтоги.Columns.Collection.Add(this.vmoИтоги_Расход);
            this.vmoИтоги.Columns.Collection.Add(this.vmoИтоги_КонОстаток);
            this.vmoИтоги.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoИтоги.MetaDataName = "";
            this.vmoИтоги.FullName = "";
            // 
            // vmoИтоги_Контрагент
            // 
            this.vmoИтоги_Контрагент.Caption = "Контрагент";
            this.vmoИтоги_Контрагент.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoИтоги_Контрагент.Name = "Контрагент";
            this.vmoИтоги_Контрагент.NSGType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.vmoИтоги_Контрагент.PropertyType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.vmoИтоги_Контрагент.SearchCondition.OwnerComponent = this.vmoИтоги_Контрагент;
            this.vmoИтоги_Контрагент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoИтоги_НачОстаток
            // 
            this.vmoИтоги_НачОстаток.CalcTotal = false;
            this.vmoИтоги_НачОстаток.Caption = "НачОстаток";
            this.vmoИтоги_НачОстаток.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoИтоги_НачОстаток.Name = "НачОстаток";
            this.vmoИтоги_НачОстаток.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoИтоги_НачОстаток.PropertyType = typeof(decimal);
            this.vmoИтоги_НачОстаток.SearchCondition.OwnerComponent = this.vmoИтоги_НачОстаток;
            this.vmoИтоги_НачОстаток.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoИтоги_Приход
            // 
            this.vmoИтоги_Приход.CalcTotal = false;
            this.vmoИтоги_Приход.Caption = "Приход";
            this.vmoИтоги_Приход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoИтоги_Приход.Name = "Приход";
            this.vmoИтоги_Приход.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoИтоги_Приход.PropertyType = typeof(decimal);
            this.vmoИтоги_Приход.SearchCondition.OwnerComponent = this.vmoИтоги_Приход;
            this.vmoИтоги_Приход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoИтоги_Расход
            // 
            this.vmoИтоги_Расход.CalcTotal = false;
            this.vmoИтоги_Расход.Caption = "Расход";
            this.vmoИтоги_Расход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoИтоги_Расход.Name = "Расход";
            this.vmoИтоги_Расход.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoИтоги_Расход.PropertyType = typeof(decimal);
            this.vmoИтоги_Расход.SearchCondition.OwnerComponent = this.vmoИтоги_Расход;
            this.vmoИтоги_Расход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoИтоги_КонОстаток
            // 
            this.vmoИтоги_КонОстаток.CalcTotal = false;
            this.vmoИтоги_КонОстаток.Caption = "КонОстаток";
            this.vmoИтоги_КонОстаток.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoИтоги_КонОстаток.Name = "КонОстаток";
            this.vmoИтоги_КонОстаток.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoИтоги_КонОстаток.PropertyType = typeof(decimal);
            this.vmoИтоги_КонОстаток.SearchCondition.OwnerComponent = this.vmoИтоги_КонОстаток;
            this.vmoИтоги_КонОстаток.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // nsgObjectFilter1
            // 
            this.nsgObjectFilter1.AllowDrop = true;
            this.nsgObjectFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nsgObjectFilter1.AutoSetCompare = true;
            this.nsgObjectFilter1.BackColor = System.Drawing.SystemColors.Control;
            nsgGridColumn2.Caption = "";
            nsgGridColumn2.ChangedProperties = new string[] {
        "Visible"};
            nsgGridColumn2.ImportedFromVMO = false;
            nsgGridColumn2.Name = "Контрагент";
            nsgGridColumn2.Root = this.nsgObjectFilter1.Columns.Collection;
            this.nsgObjectFilter1.Columns.Collection.Add(nsgGridColumn2);
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
            this.nsgObjectFilter1.Size = new System.Drawing.Size(290, 165);
            this.nsgObjectFilter1.SourceObject = this.vmoФильтр;
            this.nsgObjectFilter1.TabIndex = 0;
            this.nsgObjectFilter1.ValueCaption = "Фильтр";
            // 
            // vmoФильтр
            // 
            this.vmoФильтр.Columns.Collection.Add(this.vmoФильтр_Контрагент);
            this.vmoФильтр.IsActive = true;
            this.vmoФильтр.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoФильтр.MetaDataName = "";
            this.vmoФильтр.FullName = "";
            // 
            // vmoФильтр_Контрагент
            // 
            this.vmoФильтр_Контрагент.Caption = "Контрагент";
            this.vmoФильтр_Контрагент.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoФильтр_Контрагент.Name = "Контрагент";
            this.vmoФильтр_Контрагент.NSGType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.vmoФильтр_Контрагент.PropertyType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.vmoФильтр_Контрагент.SearchCondition.OwnerComponent = this.vmoФильтр_Контрагент;
            this.vmoФильтр_Контрагент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
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
            this.nsgButton1.TabIndex = 11;
            this.nsgButton1.Text = "Просмотр";
            this.nsgButton1.TextPosition = System.Drawing.ContentAlignment.MiddleCenter;
            this.nsgButton1.AsyncClick += new System.ComponentModel.DoWorkEventHandler(this.nsgButton1_AsyncClick);
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
            this.nsgLabel2.TabIndex = 13;
            this.nsgLabel2.Text = "Период";
            // 
            // nsgPeriodPicker1
            // 
            this.nsgPeriodPicker1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.nsgPeriodPicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsgPeriodPicker1.Location = new System.Drawing.Point(63, 12);
            this.nsgPeriodPicker1.MinimumSize = new System.Drawing.Size(2, 4);
            this.nsgPeriodPicker1.Name = "NsgPeriodPicker";
            this.nsgPeriodPicker1.Size = new System.Drawing.Size(151, 27);
            this.nsgPeriodPicker1.TabIndex = 14;
            // 
            // nsgReportDataSource1
            // 
            this.nsgReportDataSource1.MasterComponent = this.vmoИтоги;
            this.nsgReportDataSource1.Name = "nsgReportDataSource1";
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
            this.nsgReport1.ReportGuid = "c8b573b72bba4f018fc5408fd323df11";
            this.nsgReport1.ReportLoaded = true;
            this.nsgReport1.ReportName = "Отчет";
            this.nsgReport1.ReportSource = resources.GetString("nsgReport1.ReportSource");
            this.nsgReport1.ReportUnit = NsgSoft.ReportBuilder.StiReportUnitType.Centimeters;
            this.nsgReport1.ScriptLanguage = NsgSoft.ReportBuilder.StiReportLanguageType.CSharp;
            this.nsgReport1.ShowBookmarksPanel = false;
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
            this.vmoДок.Columns.Collection.Add(this.vmoДок_Контрагент);
            this.vmoДок.Columns.Collection.Add(this.vmoДок_Приход);
            this.vmoДок.Columns.Collection.Add(this.vmoДок_Расход);
            this.vmoДок.Columns.Collection.Add(this.vmoДок_Документ);
            this.vmoДок.IsActive = true;
            this.vmoДок.DataSourceType = NsgSoft.Forms.NsgDataSourceType.DynamicObject;
            this.vmoДок.MetaDataName = "";
            this.vmoДок.FullName = "";
            // 
            // vmoДок_Контрагент
            // 
            this.vmoДок_Контрагент.Caption = "Контрагент";
            this.vmoДок_Контрагент.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoДок_Контрагент.Name = "Контрагент";
            this.vmoДок_Контрагент.NSGType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.vmoДок_Контрагент.PropertyType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.vmoДок_Контрагент.SearchCondition.OwnerComponent = this.vmoДок_Контрагент;
            this.vmoДок_Контрагент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoДок_Приход
            // 
            this.vmoДок_Приход.CalcTotal = false;
            this.vmoДок_Приход.Caption = "Приход";
            this.vmoДок_Приход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoДок_Приход.Name = "Приход";
            this.vmoДок_Приход.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoДок_Приход.PropertyType = typeof(decimal);
            this.vmoДок_Приход.SearchCondition.OwnerComponent = this.vmoДок_Приход;
            this.vmoДок_Приход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoДок_Расход
            // 
            this.vmoДок_Расход.CalcTotal = false;
            this.vmoДок_Расход.Caption = "Расход";
            this.vmoДок_Расход.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoДок_Расход.Name = "Расход";
            this.vmoДок_Расход.NSGType = typeof(NsgSoft.DataObjects.NsgDataFloat);
            this.vmoДок_Расход.PropertyType = typeof(decimal);
            this.vmoДок_Расход.SearchCondition.OwnerComponent = this.vmoДок_Расход;
            this.vmoДок_Расход.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // vmoДок_Документ
            // 
            this.vmoДок_Документ.Caption = "Документ";
            this.vmoДок_Документ.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.vmoДок_Документ.Name = "Документ";
            this.vmoДок_Документ.NSGType = typeof(NsgSoft.DataObjects.NsgDataUntypedReference);
            this.vmoДок_Документ.PropertyType = typeof(NsgSoft.DataObjects.NsgDataUntypedReference);
            this.vmoДок_Документ.ReferentFilter = new NsgSoft.DataObjects.NsgObjectsFilter(((NsgSoft.DataObjects.NsgFiltration)(NsgSoft.DataObjects.NsgFiltration.List)), new string[0]);
            this.vmoДок_Документ.SearchCondition.OwnerComponent = this.vmoДок_Документ;
            this.vmoДок_Документ.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.ДокDataSource;
            this.stiReportDataSource2.Name = "ДокDataSource";
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
            this.nsgGroupsList1.TabIndex = 0;
            // 
            // Контрагент
            // 
            this.Контрагент.Caption = "Контрагент";
            this.Контрагент.Creator = typeof(NsgSoft.Forms.NsgReportForm);
            this.Контрагент.Name = "Контрагент";
            this.Контрагент.NSGType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.Контрагент.PropertyType = typeof(NSGAuto.Метаданные.Автосервис.Контрагент);
            this.Контрагент.SearchCondition.OwnerComponent = this.Контрагент;
            this.Контрагент.SearchCondition.Parameters = new NsgSoft.DataObjects.NsgCompareParam[0];
            // 
            // ДолгиФорма
            // 
            this.AllowDrop = true;
            this.AllowGroupSelect = true;
            this.AutoActivateOnShown = true;
            this.AutoPostOnClose = false;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BlockShowReport = false;
            this.ClientSize = new System.Drawing.Size(802, 418);
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
            ((System.ComponentModel.ISupportInitialize)(this.nsgIGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoИтоги)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgObjectFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoФильтр)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgReportDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ДокDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmoДок)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsgGroupsList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Контрагент.ColumnDescriptor Контрагент;
        protected NsgColumnDescriptor Период;
        protected NsgSoft.Design.NsgButton nsgButton1;
        protected NsgLabel nsgLabel2;
        protected NsgPeriodPicker nsgPeriodPicker1;
        protected Контрагент.ColumnDescriptor vmoИтоги_Контрагент;
        protected NsgColumnDescriptor.Decimal vmoИтоги_НачОстаток;
        protected NsgColumnDescriptor.Decimal vmoИтоги_Приход;
        protected NsgColumnDescriptor.Decimal vmoИтоги_Расход;
        protected NsgColumnDescriptor.Decimal vmoИтоги_КонОстаток;
        protected Контрагент.ColumnDescriptor vmoДок_Контрагент;
        protected NsgColumnDescriptor.Decimal vmoДок_Приход;
        protected NsgColumnDescriptor.Decimal vmoДок_Расход;
        protected NsgColumnDescriptor.UntypedMultipleObject vmoДок_Документ;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource1;
        private NsgSoft.ReportBuilder.Design.StiReportDataSource stiReportDataSource2;
        private NsgSoft.ReportBuilder.NsgReport nsgReport1;
        private NsgSoft.Forms.NsgIGridView.NsgObjectFilter nsgObjectFilter1;
        private NsgSoft.ReportBuilder.NsgGroupsList nsgGroupsList1;
        protected Контрагент.ColumnDescriptor vmoФильтр_Контрагент;
        protected NsgSoft.ReportBuilder.NsgReportDataSource nsgReportDataSource1;
        private NsgIGrid nsgIGrid1;
        private NsgVisualMultipleObject vmoИтоги;
        private NsgVisualMultipleObject vmoДок;
        private NsgVisualMultipleObject vmoФильтр;
        private NsgSoft.ReportBuilder.NsgReportDataSource ДокDataSource;
    }
}