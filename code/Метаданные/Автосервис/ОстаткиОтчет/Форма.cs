using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;





namespace NSGAuto.Метаданные.Автосервис
{
    
    public partial class ОстаткиОтчетФорма

    {
        public ОстаткиОтчетФорма()
        {
            InitializeComponent();
		}

        #region #Comments_Data# NsgSoft.Forms.NsgReportForm

        #endregion //#Comments_Data# NsgSoft.Forms.NsgReportForm

        #region #Comments_Constructors# NsgSoft.Forms.NsgReportForm

        #endregion //#Comments_Constructors# NsgSoft.Forms.NsgReportForm

        #region #Comments_Methods# NsgSoft.Forms.NsgReportForm

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            vmoФильтр.Data.MemoryTable.Clear();
            vmoФильтр.Data.CurrentRow = vmoФильтр.Data.MemoryTable.NewRow();
        }

        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);
            PopulateGrid();
            PopulateReport();
        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);
        }

        void PopulateGrid()
        {
            var ост = Остатки.Новый();
            NsgCompare cmp = nsgObjectFilter1.Compare;
            var table = ост.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, cmp);
            vmoИтоги.Data.BeginUpdateData(); // блокирует отображение изменений
            vmoИтоги.Data.MemoryTable.Clear(); // очищает таблицу
            foreach (var tableRow in table.Rows)
            {
                var mtRow = vmoИтоги.Data.MemoryTable.NewRow();
                mtRow[Номенклатура_vmoИтоги].Value = tableRow[Остатки.Names.Номенклатура].ToReferent() as Номенклатура;
                mtRow[НачОстаток_vmoИтоги].Value = tableRow[Остатки.Names.Сумма].ToBegin();
                mtRow[Приход_vmoИтоги].Value = tableRow[Остатки.Names.Сумма].ToCredit();
                mtRow[Расход_vmoИтоги].Value = tableRow[Остатки.Names.Сумма].ToDebit();
                mtRow[КонОстаток_vmoИтоги].Value = tableRow[Остатки.Names.Сумма].ToEnd();
                mtRow[НачОстатокКоличество_vmoИтоги].Value = tableRow[Остатки.Names.Количество].ToBegin();
                mtRow[ПриходКоличество_vmoИтоги].Value = tableRow[Остатки.Names.Количество].ToCredit();
                mtRow[РасходКоличество_vmoИтоги].Value = tableRow[Остатки.Names.Количество].ToDebit();
                mtRow[КонОстатокКоличество_vmoИтоги].Value = tableRow[Остатки.Names.Количество].ToEnd();
                mtRow.Post();
            }
            vmoИтоги.Data.UpdateDataAsync(this); // разблокирует отображение изменений
        }

        void PopulateReport()
        {
            var ост = Остатки.Новый();
            NsgCompare cmp = nsgObjectFilter1.Compare;
            var table = ост.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, cmp,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit,
                Остатки.Names.Номенклатура, Остатки.Names.Владелец);
            vmoДок.Data.MemoryTable.Clear();
            Период_vmoЗаголовок.Value = nsgPeriodPicker1.Period.Value.ToString(); // WTF: пустая строка
            Фильтр_vmoЗаголовок.Value = cmp.ToString();
            foreach (var tableRow in table.Rows)
            {
                var mtRow = vmoДок.Data.MemoryTable.NewRow();
                mtRow[Номенклатура_vmoДок].Value = tableRow[Остатки.Names.Номенклатура].ToReferent() as Номенклатура;
                mtRow[Документ_vmoДок].Value = tableRow[Остатки.Names.Владелец].ToReferent();
                mtRow[Приход_vmoДок].Value = tableRow[Остатки.Names.Сумма].ToCredit();
                mtRow[Расход_vmoДок].Value = tableRow[Остатки.Names.Сумма].ToDebit();
                mtRow[ПриходКоличество_vmoДок].Value = tableRow[Остатки.Names.Количество].ToCredit();
                mtRow[РасходКоличество_vmoДок].Value = tableRow[Остатки.Names.Количество].ToDebit();
                mtRow.Post();
            }
        }

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgReportForm

        #region #Comments_Properties# NsgSoft.Forms.NsgReportForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgReportForm

        private void nsgButton1_AsyncClick(object sender, DoWorkEventArgs e)
        {
            PopulateGrid();
        }
    }
    


}