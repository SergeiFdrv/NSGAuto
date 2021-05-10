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

                var ном = tableRow[Продажи.Names.Номенклатура].ToReferent() as Номенклатура;
                var количество = tableRow[Продажи.Names.Количество].ToDecimal();

                mtRow[Номенклатура_vmoИтоги].Value = ном;
                mtRow[Контрагент_vmoИтоги].Value = tableRow[Продажи.Names.Контрагент].ToReferent() as Контрагент;
                mtRow[Количество_vmoИтоги].Value = количество;
                mtRow[Себестоимость_vmoИтоги].Value = ном.Цена;
                mtRow[Цена_vmoИтоги].Value = tableRow[Продажи.Names.Цена].ToDecimal();
                cmp1.Add(Продажи.Names.Контрагент, tableRow[Продажи.Names.Контрагент].ToReferent() as Контрагент);
                cmp1.Add(Продажи.Names.Номенклатура, ном);
                cmp1.Add(Продажи.Names.ДатаДокумента, NsgPeriodPicker.Period.Begin, NsgSoft.Database.NsgComparison.GreaterOrEqual);
                cmp1.Add(Продажи.Names.ДатаДокумента, NsgPeriodPicker.Period.End, NsgSoft.Database.NsgComparison.Less);
                var count = регистр.SelectCount(cmp1);
                cmp1.Clear();
                var avgЦена = tableRow[Продажи.Names.Цена].ToDecimal();
                var avgПрибыль = tableRow[Продажи.Names.Прибыль].ToDecimal();
                var avgРент = tableRow[Продажи.Names.Рентабильность].ToDecimal();
                if (count != 0)
                {
                    avgЦена /= count;
                    avgПрибыль /= count;
                    avgРент /= count;
                }

                mtRow[Цена_vmoИтоги].Value = avgЦена;
                //var сумма = avgЦена * (decimal)mtRow[Количество_vmoИтоги].Value;
                mtRow[Сумма_vmoИтоги].Value = tableRow[Продажи.Names.Сумма].ToDecimal();//сумма;
                //var прибыль = сумма - ном.Цена * количество;
                mtRow[Прибыль_vmoИтоги].Value = avgПрибыль;//прибыль / count;//avgПрибыль;
                mtRow[Рентабильность_vmoИтоги].Value = avgРент;//прибыль / (ном.Цена * количество);//avgРент;
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

                var ном = tableRow[Продажи.Names.Номенклатура].ToReferent() as Номенклатура;

                mtRow[Номенклатура_vmoДок].Value = ном;
                mtRow[Контрагент_vmoДок].Value = tableRow[Продажи.Names.Контрагент].ToReferent() as Контрагент;
                mtRow[Количество_vmoДок].Value = tableRow[Продажи.Names.Количество].ToDecimal();
                mtRow[Себестоимость_vmoДок].Value = ном.Цена;
                cmp1.Add(Продажи.Names.Контрагент, tableRow[Продажи.Names.Контрагент].ToReferent() as Контрагент);
                cmp1.Add(Продажи.Names.Номенклатура, tableRow[Продажи.Names.Номенклатура].ToReferent() as Номенклатура);
                cmp1.Add(Продажи.Names.ДатаДокумента, NsgPeriodPicker.Period.Begin, NsgSoft.Database.NsgComparison.GreaterOrEqual);
                cmp1.Add(Продажи.Names.ДатаДокумента, NsgPeriodPicker.Period.End, NsgSoft.Database.NsgComparison.Less);
                var count = регистр.SelectCount(cmp1);
                cmp1.Clear();
                var avgЦена = tableRow[Продажи.Names.Цена].ToDecimal();
                var avgПрибыль = tableRow[Продажи.Names.Прибыль].ToDecimal();
                var avgРент = tableRow[Продажи.Names.Рентабильность].ToDecimal();
                if (count != 0)
                {
                    avgЦена /= count;
                    avgПрибыль /= count;
                    avgРент /= count;
                }
                mtRow[Цена_vmoДок].Value = avgЦена;
                mtRow[Сумма_vmoДок].Value = tableRow[Продажи.Names.Сумма].ToDecimal();
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