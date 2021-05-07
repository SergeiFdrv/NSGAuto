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
            вз.New();
            вз.Контрагент = Контрагент;
            вз.Сумма = ИтогоСумма;
            вз.ВидДвижения = Сервис.ВидыДвижений.Расход;
            вз.AddMovement();
            вз.Post();

            var table = Таблица.Rows;
            var ост = Остатки.Новый(this);
            ост.New();
            foreach (var i in table)
            {
                ост.Номенклатура = i.Номенклатура;
                ост.Количество = i.Количество;
                ост.Сумма = i.Сумма;
                ост.ВидДвижения = Сервис.ВидыДвижений.Расход;
                ост.AddMovement();
            }
            ост.Post();
            return true;
        }

        #endregion //Свойства

        #region Методы
        #endregion //Методы
    }

}
