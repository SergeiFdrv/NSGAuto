using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Design;
using System.IO;
using NsgSoft.Common;

namespace NSGAuto.Метаданные
{
    public partial class Метаданные : NsgSoft.DataObjects.NsgMetaData
    {
        #region Данные
        #endregion //Данные

        #region Инициализация


        public static Метаданные Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("e255bf48-4b44-4ee9-a6f1-bf88ebed8105"));
            if (obj == null)
                obj = new Метаданные();
            return obj as Метаданные;
        }

        /// <summary>
        /// Инициализация
        /// </summary>
        protected override void InitObjectList()
        {
            ObjectList.AddRange( new NsgMultipleObject[] {NSGAuto.Метаданные.Сервис.DataAssemblyObject.Новый(),
	 NSGAuto.Метаданные.Сервис.БазыДанныхДляОбмена.Новый(),
	 NSGAuto.Метаданные.Сервис.ОбъектыОбмена.Новый(),
	 NSGAuto.Метаданные.Сервис.ТипыОбмена.Новый(),
	 NSGAuto.Метаданные.Сервис.ПравилаОбменаДанными.Новый(),
	 NSGAuto.Метаданные.Сервис.ПротоколОбмена.Новый(),
	 NSGAuto.Метаданные.Сервис.НастройкиКаналаОбмена.Новый(),
	 NSGAuto.Метаданные.Сервис.ОбменДанными.Новый(),
	 NSGAuto.Метаданные.Сервис.ИмпортДанных.Новый(),
	 NSGAuto.Метаданные.Сервис.СервисноеОбслуживание.Новый(),
	 NSGAuto.Метаданные.Сервис.СостоянияОбъекта.Новый(),
	 NSGAuto.Метаданные.Сервис.ВидыДвижений.Новый(),
	 NSGAuto.Метаданные.Сервис.ОбщийЖурнал.Новый(),
	 NSGAuto.Метаданные.Сервис.НеактуальностьИтоговРегистров.Новый(),
	 NSGAuto.Метаданные.Сервис.ПечатныеФормы.Новый(),
	 NSGAuto.Метаданные._SystemTables.СервисПечатныеФормыДвижения.Новый(),
	 NSGAuto.Метаданные.Сервис.КорректировкаРегистра.Новый(),
	 NSGAuto.Метаданные._SystemTables.PeriodicTable.Новый(),
	 NSGAuto.Метаданные.Сервис.ТаблицаРолиМенюПользователя.Новый(),
	 NSGAuto.Метаданные.Сервис.РольПользователяМеню.Новый(),
	 NSGAuto.Метаданные.Сервис.ДействиеЭлементаМеню.Новый(),
	 NSGAuto.Метаданные.Сервис.ТаблицаЭлементаМенюПользователя.Новый(),
	 NSGAuto.Метаданные.Сервис.ЭлементМенюПользователя.Новый(),
	 NSGAuto.Метаданные.Сервис.ДействияПользователей.Новый(),
	 NSGAuto.Метаданные.Сервис.РазрешениеОперацииПользователя.Новый(),
	 NSGAuto.Метаданные.Сервис.Пользователи.Новый(),
	 NSGAuto.Метаданные.Сервис.ТипСообщения.Новый(),
	 NSGAuto.Метаданные.Сервис.СписокСообщений.Новый(),
	 NSGAuto.Метаданные.Сервис.Приоритет.Новый(),
	 NSGAuto.Метаданные.Сервис.ТипЗадачиНаСервере.Новый(),
	 NSGAuto.Метаданные.Сервис.СервернаяЗадача.Новый(),
	 NSGAuto.Метаданные.Сервис.НастройкиПользователей.Новый(),
	 NSGAuto.Метаданные.Сервис.ПраваПользователей.Новый(),
	 NSGAuto.Метаданные._SystemTables.СервисПраваПользователейДвижения.Новый(),
	 NSGAuto.Метаданные.Сервис.ОбновленияСистемы.Новый(),
	 NSGAuto.Метаданные.Автосервис.Номенклатура.Новый(),
	 NSGAuto.Метаданные._SystemTables.АвтосервисПриходнаяНакладнаяТаблица.Новый(),
	 NSGAuto.Метаданные.Автосервис.Контрагент.Новый(),
	 NSGAuto.Метаданные.Автосервис.ПриходнаяНакладная.Новый(),
	 NSGAuto.Метаданные._SystemTables.АвтосервисРасходнаяНакладнаяТаблица.Новый(),
	 NSGAuto.Метаданные.Автосервис.РасходнаяНакладная.Новый(),
	 NSGAuto.Метаданные._SystemTables.АвтосервисВзаиморасчетыДвижения.Новый(),
	 NSGAuto.Метаданные.Автосервис.Долги.Новый(),
	 NSGAuto.Метаданные._SystemTables.АвтосервисВзаиморасчетыНакопления.Новый(),
	 NSGAuto.Метаданные._SystemTables.АвтосервисВзаиморасчетыНакопления_1.Новый(),
	 NSGAuto.Метаданные.Автосервис.Взаиморасчеты.Новый(),
	 NSGAuto.Метаданные._SystemTables.АвтосервисОстаткиДвижения.Новый(),
	 NSGAuto.Метаданные._SystemTables.АвтосервисОстаткиНакопления.Новый(),
	 NSGAuto.Метаданные._SystemTables.АвтосервисОстаткиНакопления_1.Новый(),
	 NSGAuto.Метаданные.Автосервис.ОстаткиОтчет.Новый(),
	 NSGAuto.Метаданные.Автосервис.Остатки.Новый(),
	 NSGAuto.Метаданные.Автосервис.ПродажиОтчет.Новый(),
	 NSGAuto.Метаданные._SystemTables.АвтосервисПродажиДвижения.Новый(),
	 NSGAuto.Метаданные._SystemTables.АвтосервисПродажиНакопления.Новый(),
	 NSGAuto.Метаданные._SystemTables.АвтосервисПродажиНакопления_1.Новый(),
	 NSGAuto.Метаданные.Автосервис.Продажи.Новый(),
	 NSGAuto.Метаданные.Автосервис.ПриходнаяНакладнаяПечать.Новый(),
	 NSGAuto.Метаданные.Автосервис.РасходнаяНакладнаяПечать.Новый()});
        }
        
        /// <summary>
        /// Инициализация
        /// </summary>
        private void InitializeComponent()
        {
            	//NsgMetaData
	IsLoadedFromDll = true;
	Guid = NsgService.StringToGuid("e255bf48-4b44-4ee9-a6f1-bf88ebed8105");
	PeriodicTable = "_SystemTables.PeriodicTable";
	SystemGroup = "_SystemTables";
	Version = "2021.5.11.0";
	ContainsUserInformation = true;
	UserActionsRegisteration = true;
	UseUserMenu = true;
	Groups = new System.String[]{"Сервис", "Автосервис"};
	Name = "Метаданные";
	
            AfterLoad();
        }

        #endregion //Инициализация

        #region Свойства
        #endregion //Свойства

        #region Методы
        /// <summary>
        /// Идентификатор текущего уровня метаданных
        /// </summary>
        private string ID
        {
            get
            {
                return "NSGAuto";
            }
        }
        #endregion //Методы
    }
}
