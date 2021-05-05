using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.IO;

using NsgSoft.DataObjects;
using NsgSoft.Design;
using NsgSoft.Database;
using NsgSoft.Common;

// ================================================================ //
// Этот файл создается автоматически, все изменения будут потеряны. //
// ================================================================ //

namespace NSGAuto.Метаданные._SystemTables
{
    public partial class АвтосервисВзаиморасчетыНакопления_1
{
    [NsgTypeName("NsgDataTableRow", Guid = "c21aa901-f424-4378-b1f8-1fcf5e3bc9fb")]
    public partial class Строка : NsgSoft.DataObjects.NsgDataTableRow
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataTableRow
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataTableRow

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataTableRow
        

		/// <summary>
        /// "Пустой" конструктор для строки таблицы, необходимо указание таблицы которой принадлежит строка
        /// </summary>
        public Строка(NsgDataTable owner)
            : base(owner)
        {
        }
        



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataTableRow

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected Строка()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Строка(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Строка Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("c21aa901-f424-4378-b1f8-1fcf5e3bc9fb"));
            if (obj == null)
                obj = new Строка();
            return obj as Строка;
        }

        /// <summary>
        /// Инициализация реквизитов объекта
        /// </summary>
        protected override void CreatePreDefinedFields()
		{
			#region необходимые операции до создания реквизитов и заполнения полей
			if (NsgSettings.Regime == NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
			#endregion //необходимые операции до создания реквизитов и заполнения полей
			#region начало инициализации NsgSoft.DataObjects.NsgDataTableRow
			

            if (NsgSettings.Regime != NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
        



			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataTableRow
			

			#region заполнение полей класса
			
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataTableRow
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataTableRow

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            this.FieldsCash.Clear();
			foreach (NsgSimpleObject obj in ObjectList.All)
                if (!string.IsNullOrEmpty(obj.FieldName))
					this.FieldsCash.Add(obj.FieldName, obj.Name);
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataTableRow.Names
        {
            
            /// <summary>
            /// Сумма
            /// </summary>
            public static String Сумма
            {
                get
                {
                    return "Сумма";
                }
            }
            
            /// <summary>
            /// Автоинкремент
            /// </summary>
            public static String Автоинкремент
            {
                get
                {
                    return "Автоинкремент";
                }
            }
            
            /// <summary>
            /// Контрагент
            /// </summary>
            public static String Контрагент
            {
                get
                {
                    return "Контрагент";
                }
            }
            
            /// <summary>
            /// Дата документа
            /// </summary>
            public static String ДатаДокумента
            {
                get
                {
                    return "ДатаДокумента";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public static string GetFullName()
        {
            return "_SystemTables.Строка";
        }

        
        /// <summary>
        /// Сумма
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Сумма
        {
            get
            {
				 NsgDataFloat __Сумма = ObjectList["Сумма"] as NsgDataFloat;
                 return (System.Decimal)__Сумма.Value;
            }
            set
            {
                NsgDataFloat __Сумма = ObjectList["Сумма"] as NsgDataFloat;
                __Сумма.Value = value;
            }
        }
        
        /// <summary>
        /// Автоинкремент
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 Автоинкремент
        {
            get
            {
				 NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                 return (System.Int64)__Автоинкремент.Value;
            }
            set
            {
                NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                __Автоинкремент.Value = value;
            }
        }
        
        /// <summary>
        /// Контрагент
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Автосервис.Контрагент Контрагент
        {
            get
            {
				 NsgDataTypedReference __Контрагент = ObjectList["Контрагент"] as NsgDataTypedReference;
                 return (Автосервис.Контрагент)__Контрагент.Referent;
            }
            set
            {
                NsgDataTypedReference __Контрагент = ObjectList["Контрагент"] as NsgDataTypedReference;
                __Контрагент.Referent = value;
            }
        }
        
        /// <summary>
        /// Дата документа
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаДокумента
        {
            get
            {
				 NsgDataDateTime __ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаДокумента.Value;
            }
            set
            {
                NsgDataDateTime __ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                __ДатаДокумента.Value = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataTableRow
        




        #endregion // Свойства NsgSoft.DataObjects.NsgDataTableRow

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataTableRow
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataTableRow

        #region Методы NsgMultipleObject
        private Строка[] convertArray(NsgMultipleObject[] array)
        {
            Строка[] res = new Строка[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск множества результатов на полное совпадение. Перегруженные методы.
        /// <summary>
        /// Метод поиска в БД по одному и более реквизитов с ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        /// </remarks>
        /// <param name="compare">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual Строка[] FindAll(NsgCompare compare)
        {
            return convertArray(base.FindAll(compare));
        }

        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному и более реквизитов
        ///  c ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="paramAll">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual Строка[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, compare));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Имя реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual Строка[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Идентификатор реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual Строка[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Строка(this as NsgObject);
            }
        }

        #endregion // Методы NsgMultipleObject
        #endregion // Методы

        /// <summary>
        /// Описатель колонки источника данных
        /// </summary>
        public new class ColumnDescriptor : NsgSoft.Forms.NsgColumnDescriptor
        {
            public ColumnDescriptor()
                : base()
            {
                base.NSGType = typeof(Строка);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Строка Value
            {
                get
                {
                    return (Строка)base.Value;
                }
                set
                {
                    base.Value = value;
                }
            }

            /// <summary>
            /// Имя иконки колонки
            /// </summary>
            public override string ImageKey
            {
                get
                {
                    return "s_NsgDataTableRow";
                }
            }
        }
    }
}
}
