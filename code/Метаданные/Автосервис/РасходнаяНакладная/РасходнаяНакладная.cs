using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Database;
using System.IO;
using NsgSoft.Common;



namespace NSGAuto.Метаданные.Автосервис
{
    
    public partial class РасходнаяНакладная
    {
        #region Данные
        #endregion //Данные

        #region Конструкторы
        #endregion //Конструкторы

        #region Свойства

        protected override bool Handling()
        {
            var вз = Взаиморасчеты.Новый(this);
            вз.New();
            вз.Контрагент = Контрагент;
            var table = Таблица.Rows;
            decimal price = 0;
            foreach (var i in table)
            {
                price += i.Номенклатура.Цена * i.Количество;
            }
            вз.Сумма = price;
            вз.ВидДвижения = Сервис.ВидыДвижений.Приход;
            вз.AddMovement();

            var ост = Остатки.Новый(this);
            ост.New();

            var продажи = Продажи.Новый(this);
            продажи.New();
            продажи.Контрагент = Контрагент;
            //продажи.GetRest();
            foreach (var i in table)
            {
                ост.Номенклатура = i.Номенклатура;
                ост.GetRest();
                if (ост.Количество + i.Количество > 0)
                {
                    throw new Exception(
                        $"В наличии не хватает " +
                        (ост.Количество + i.Количество) +
                        " единиц товара " + i.Номенклатура.Наименование);
                }
                ост.Количество = i.Количество;
                ост.Сумма = i.Сумма;
                ост.ВидДвижения = Сервис.ВидыДвижений.Приход;
                ост.AddMovement();

                продажи.Номенклатура = i.Номенклатура;
                продажи.Количество = i.Количество;
                продажи.Цена = i.Цена; // цена за единицу
                продажи.Сумма = i.Цена * i.Количество; // TODO: высчитывать
                продажи.Прибыль = i.Сумма - i.Номенклатура.Цена * i.Количество; // TODO: высчитывать
                продажи.Рентабильность = (продажи.Прибыль) / (i.Номенклатура.Цена * i.Количество); // % прибыли // TODO: высчитывать
                продажи.ВидДвижения = Сервис.ВидыДвижений.Приход;
                продажи.AddMovement();
            }
            вз.Post();
            ост.Post();
            продажи.Post();
            return true;
        }

        #endregion //Свойства

        #region Методы
        #endregion //Методы
    }

}
