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
    
    public partial class ДолгиФорма

    {
        public ДолгиФорма()
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
            var вз = Взаиморасчеты.Новый();
            //вз.Контрагент = Контрагент.Value;// /_
            //вз.GetRest();                    // \ |
            // Формирует условия запроса по заданным реквизитам (в д. сл. - по контрагенту)
            // Объединяет результаты запроса в один, который записывается в регистр "вз"
            // Здесь вз.Сумма - общий долг данного контрагента
            //NsgCompare cmp = new NsgCompare();
            //if (!string.IsNullOrEmpty(Контрагент.Value.Код)) // Если Поле "Контрагент" не пусто
            //{
            //    cmp.Add(Взаиморасчеты.Names.Контрагент, Контрагент.Value);
            //}
            NsgCompare cmp = nsgObjectFilter1.Compare;
            var table = вз.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, cmp);
            // Возвращает все результаты запроса за период
            //table = вз.GetRests(cmp/*, params string[] resultDimensions*/);
            // Формирует запрос по условиям, заданным cmp. Возвращает поля, указанные в resultDinemsions
            // Пример:
            // NsgCompare cmp = new NsgCompare().Add(Взаиморасчеты.Names.Контрагент, Контрагент.Value);
            // var table = вз.GetRests(cmp, Взаиморасчеты.Names.Сумма);
            // =
            // SQL: SELECT Сумма FROM [Регистр взаиморасчетов] WHERE Контрагент = Контрагент.Value
            vmoИтоги.Data.BeginUpdateData(); // блокирует отображение изменений
            vmoИтоги.Data.MemoryTable.Clear(); // очищает таблицу
            foreach (var tableRow in table.Rows)
            {
                var mtRow = vmoИтоги.Data.MemoryTable.NewRow();
                mtRow[vmoИтоги_Контрагент].Value = tableRow[Взаиморасчеты.Names.Контрагент].ToReferent() as Контрагент;
                mtRow[vmoИтоги_НачОстаток].Value = tableRow[Взаиморасчеты.Names.Сумма].ToBegin();
                mtRow[vmoИтоги_Приход].Value = tableRow[Взаиморасчеты.Names.Сумма].ToCredit();
                mtRow[vmoИтоги_Расход].Value = tableRow[Взаиморасчеты.Names.Сумма].ToDebit();
                mtRow[vmoИтоги_КонОстаток].Value = tableRow[Взаиморасчеты.Names.Сумма].ToEnd();
                mtRow.Post();
            }
            //table.CopyTo(vmoИтоги.Data.MemoryTable);
            vmoИтоги.Data.UpdateDataAsync(this); // разблокирует отображение изменений
        }

        void PopulateReport()
        {
            var вз = Взаиморасчеты.Новый();
            NsgCompare cmp = nsgObjectFilter1.Compare;
            var table = вз.GetCirculate(nsgPeriodPicker1.Period.Begin, nsgPeriodPicker1.Period.End, cmp,
                NsgSoft.Common.NsgRegisterResult.Credit | NsgSoft.Common.NsgRegisterResult.Debit,
                Взаиморасчеты.Names.Контрагент, Взаиморасчеты.Names.Владелец);
            vmoДок.Data.MemoryTable.Clear();
            foreach (var tableRow in table.Rows)
            {
                var mtRow = vmoДок.Data.MemoryTable.NewRow();
                mtRow[vmoДок_Контрагент].Value = tableRow[Взаиморасчеты.Names.Контрагент].ToReferent() as Контрагент;
                mtRow[vmoДок_Документ].Value = tableRow[Взаиморасчеты.Names.Владелец].ToReferent();
                mtRow[vmoДок_Приход].Value = tableRow[Взаиморасчеты.Names.Сумма].ToCredit();
                mtRow[vmoДок_Расход].Value = tableRow[Взаиморасчеты.Names.Сумма].ToDebit();
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