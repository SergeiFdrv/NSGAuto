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
            var рег = Взаиморасчеты.Новый(this);
            рег.New();
            // {
            рег.Контрагент = Контрагент;
            рег.Сумма = ИтогоСумма;
            рег.ВидДвижения = Сервис.ВидыДвижений.Расход;
            рег.AddMovement();
            // }
            рег.Post();

            return true;
        }

        #endregion //Свойства

        #region Методы
        #endregion //Методы
    }

}
