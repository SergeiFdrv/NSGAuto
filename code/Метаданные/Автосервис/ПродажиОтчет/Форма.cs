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
    
    public partial class ПродажиОтчетФорма

    {
        public ПродажиОтчетФорма()
        {
            InitializeComponent();
		}

		#region #Comments_Data# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Data# NsgSoft.Forms.NsgReportForm

		#region #Comments_Constructors# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Constructors# NsgSoft.Forms.NsgReportForm

		#region #Comments_Methods# NsgSoft.Forms.NsgReportForm
		
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
            var регистр = Продажи.Новый();
            NsgCompare cmp = NsgObjectFilter.Compare;
            var table = регистр.GetCirculate(NsgPeriodPicker.Period.Begin, NsgPeriodPicker.Period.End, cmp,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit,
                Продажи.Names.Контрагент, Продажи.Names.Номенклатура);
            vmoИтоги.Data.BeginUpdateData(); // блокирует отображение изменений
            vmoИтоги.Data.MemoryTable.Clear(); // очищает таблицу
            var cmp1 = new NsgCompare();
            foreach (var tableRow in table.Rows)
            {
                var mtRow = vmoИтоги.Data.MemoryTable.NewRow();
                mtRow[Номенклатура_vmoИтоги].Value = tableRow[Продажи.Names.Номенклатура].ToReferent() as Номенклатура;
                mtRow[Контрагент_vmoИтоги].Value = tableRow[Продажи.Names.Контрагент].ToReferent() as Контрагент;
                mtRow[Количество_vmoИтоги].Value = tableRow[Продажи.Names.Количество].ToDecimal();
                cmp1.Add(Продажи.Names.Контрагент, tableRow[Продажи.Names.Контрагент].ToReferent() as Контрагент);
                cmp1.Add(Продажи.Names.Номенклатура, tableRow[Продажи.Names.Номенклатура].ToReferent() as Номенклатура);
                cmp1.Add(Продажи.Names.ДатаДокумента, NsgPeriodPicker.Period.Begin, NsgSoft.Database.NsgComparison.GreaterOrEqual);
                cmp1.Add(Продажи.Names.ДатаДокумента, NsgPeriodPicker.Period.End, NsgSoft.Database.NsgComparison.Less);
                var count = регистр.SelectCount(cmp1);
                cmp1.Clear();
                var avgСумма = tableRow[Продажи.Names.Сумма].ToDecimal();
                var avgПрибыль = tableRow[Продажи.Names.Прибыль].ToDecimal();
                var avgРент = tableRow[Продажи.Names.Рентабильность].ToDecimal();
                if (count != 0)
                {
                    avgСумма /= count;
                    avgПрибыль /= count;
                    avgРент /= count;
                }
                mtRow[Сумма_vmoИтоги].Value = avgСумма;
                mtRow[Прибыль_vmoИтоги].Value = avgПрибыль;
                mtRow[Рентабильность_vmoИтоги].Value = avgРент;
                mtRow.Post();
            }
            vmoИтоги.Data.UpdateDataAsync(this); // разблокирует отображение изменений
        }

        void PopulateReport()
        {
            var регистр = Продажи.Новый();
            NsgCompare cmp = NsgObjectFilter.Compare;
            var table = регистр.GetCirculate(NsgPeriodPicker.Period.Begin, NsgPeriodPicker.Period.End, cmp,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit,
                Продажи.Names.Контрагент, Продажи.Names.Номенклатура);
            vmoДок.Data.MemoryTable.Clear();
            var cmp1 = new NsgCompare();
            foreach (var tableRow in table.Rows)
            {
                var mtRow = vmoДок.Data.MemoryTable.NewRow();
                mtRow[Номенклатура_vmoДок].Value = tableRow[Продажи.Names.Номенклатура].ToReferent() as Номенклатура;
                mtRow[Контрагент_vmoДок].Value = tableRow[Продажи.Names.Контрагент].ToReferent() as Контрагент;
                mtRow[Количество_vmoДок].Value = tableRow[Продажи.Names.Количество].ToDecimal();
                cmp1.Add(Продажи.Names.Контрагент, tableRow[Продажи.Names.Контрагент].ToReferent() as Контрагент);
                cmp1.Add(Продажи.Names.Номенклатура, tableRow[Продажи.Names.Номенклатура].ToReferent() as Номенклатура);
                cmp1.Add(Продажи.Names.ДатаДокумента, NsgPeriodPicker.Period.Begin, NsgSoft.Database.NsgComparison.GreaterOrEqual);
                cmp1.Add(Продажи.Names.ДатаДокумента, NsgPeriodPicker.Period.End, NsgSoft.Database.NsgComparison.Less);
                var count = регистр.SelectCount(cmp1);
                cmp1.Clear();
                var avgСумма = tableRow[Продажи.Names.Сумма].ToDecimal();
                var avgПрибыль = tableRow[Продажи.Names.Прибыль].ToDecimal();
                var avgРент = tableRow[Продажи.Names.Рентабильность].ToDecimal();
                if (count != 0)
                {
                    avgСумма /= count;
                    avgПрибыль /= count;
                    avgРент /= count;
                }
                mtRow[Сумма_vmoДок].Value = avgСумма;
                mtRow[Прибыль_vmoДок].Value = avgПрибыль;
                mtRow[Рентабельность_vmoДок].Value = avgРент;
                mtRow.Post();
            }
        }

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgReportForm

        #region #Comments_Properties# NsgSoft.Forms.NsgReportForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgReportForm

        private void NsgButton_AsyncClick(object sender, DoWorkEventArgs e)
        {
            PopulateGrid();
        }
    }
    


}