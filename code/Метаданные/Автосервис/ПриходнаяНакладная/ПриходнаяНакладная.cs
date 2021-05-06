using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace NSGAuto.Метаданные.Автосервис
{
    
    public partial class ПриходнаяНакладная
    {
        #region Данные
        #endregion //Данные

        #region Конструкторы
        #endregion //Конструкторы

        #region Свойства

        protected override bool Handling()
        {
            // return base.Handling(); // Вызовет ошибку
            var вз = Взаиморасчеты.Новый(this);
            // {
            вз.New();
            вз.Контрагент = Контрагент;
            вз.Сумма = ИтогоСумма;
            вз.ВидДвижения = Сервис.ВидыДвижений.Расход;
            вз.AddMovement();
            // }
            вз.Post();

            var table = Таблица.FindAll(new NsgCompare().Add(
                _SystemTables.АвтосервисПриходнаяНакладнаяТаблица.Names.Владелец, this, NsgComparison.Equal));
            var ост = Остатки.Новый(this);
            foreach (var i in table)
            {
                ост.New();
                ост.Номенклатура = i[Остатки.Names.Номенклатура].ToReferent() as Номенклатура;
                ост.Количество = i[Остатки.Names.Количество].ToDecimal();
                ост.Сумма = i[Остатки.Names.Сумма].ToDecimal();
                ост.ВидДвижения = Сервис.ВидыДвижений.Расход;
                ост.AddMovement();
                ост.Post();
            }
            return true;
        }

        #endregion //Свойства

        #region Методы
        #endregion //Методы
    }

}
