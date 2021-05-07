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
    
    public partial class РасходнаяНакладнаяФормаЭлемента

    {
        public РасходнаяНакладнаяФормаЭлемента()
        {
            InitializeComponent();
		}

        #region #Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        protected override void OnSetFormObject(NsgMultipleObject formObject)
        {
            base.OnSetFormObject(formObject);
            //if (formObject != null)
            //{
            //    var obj = formObject as РасходнаяНакладная;
            //}
        }

        void Populate()
        {
            Random random = new Random();
            const int howMany = 10;
            РасходнаяНакладная рн = РасходнаяНакладная.Новый();
            var контрагенты = Автосервис.Контрагент.Новый().GetAll();
            var номенклатуры = Автосервис.Номенклатура.Новый().GetAll();
            //var getRandomDay = RandomDayFunc();
            _SystemTables.АвтосервисРасходнаяНакладнаяТаблица.Строка строка;

            for (int i = 0; i < howMany; i++)
            {
                ReportProgress(i * 100 / howMany, "");
                рн.New();
                рн.Контрагент = контрагенты[random.Next(контрагенты.Count)] as Контрагент;
                рн.ДатаДокумента = RandomDayFunc();

                строка = рн.Таблица.NewRow();
                строка.Номенклатура = номенклатуры.Find(н => (н as Номенклатура).Наименование == "Автозапчасть") as Номенклатура;
                строка.Количество = 5;
                строка.Цена = строка.Номенклатура.Цена + строка.Номенклатура.Цена / 2;
                строка.Сумма = строка.Количество * строка.Цена;
                строка.Post();

                строка = рн.Таблица.NewRow();
                строка.Номенклатура = номенклатуры.Find(н => (н as Номенклатура).Наименование == "Ключ на 22") as Номенклатура;
                строка.Количество = 5;
                строка.Цена = строка.Номенклатура.Цена + строка.Номенклатура.Цена / 2;
                строка.Сумма = строка.Количество * строка.Цена;
                строка.Post();

                рн.Post();
                рн.Handle(); // Провести накладную
            }
        }
        DateTime RandomDayFunc()
        {
            DateTime start = new DateTime(2021, 1, 1);
            Random gen = new Random();
            int range = ((new DateTime(2021, 5, 1) - start)).Days;
            return start.AddDays(gen.Next(range));
        }

        void Clear()
        {
            РасходнаяНакладная.Новый().DeleteArray(new NsgCompare());
        }

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        private void NsgIGrid_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Номенклатура.Name)
            {
                Цена.Value = Номенклатура.Value.Цена;
                Сумма.Value = Цена.Value * Количество.Value;
            }
            if (e.ColumnName == Цена.Name)
            {
                Сумма.Value = Цена.Value * Количество.Value;
            }
            //if (e.ColumnName == Сумма.Name)
            //{
            //    if (Количество.Value != 0)
            //    {
            //        Цена.Value = Сумма.Value / Количество.Value;
            //    }
            //}
            if (e.ColumnName == Количество.Name)
            {
                Сумма.Value = Цена.Value * Количество.Value;
                if (Количество.Value > 100)
                {
                    e.RowObject.AddUserProperty(NsgIGrid.BACKCOLOR, Color.Red);
                    e.CellObject.AddUserProperty(NsgIGrid.BLINK, true);
                }
                else
                {
                    e.RowObject.DeleteUserProperty(NsgIGrid.BACKCOLOR);
                    e.CellObject.DeleteUserProperty(NsgIGrid.BLINK);
                }
            }
        }

        private void NsgIGrid_CellRequestEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Сумма.Name)
            {
                e.Cancel = true;
            }
            //if (e.ColumnName == Сумма.Name && Цена.Value == 0)
            //{
            //    e.Cancel = true;
            ////    if (e.RowObject[_SystemTables.АвтосервисРасходнаяНакладнаяТаблица.Names.Сумма].ToFloat() > 500)
            ////    {
            ////        e.Cancel = true;
            ////    }
            //}
        }

        private void NsgIGrid_GetAvailableTools(object sender, ref NsgSoft.Common.NsgWorkPanelTools tools)
        {
            //if (Сумма.Value > 500)
            //{
            //    tools &= ~NsgSoft.Common.NsgWorkPanelTools.Delete; // .Copy;
            //    // побитовое "и не"
            //}
        }

        private void nsgButton1_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void nsgButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
    


}