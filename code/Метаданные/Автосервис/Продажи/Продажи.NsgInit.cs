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

namespace NSGAuto.Метаданные.Автосервис
{
    
    [NsgTypeName("NsgDataRegister", Guid = "4d0af52d-7931-4952-9a22-c4ab6d585ddb")]
    public partial class Продажи : NsgSoft.DataObjects.NsgDataRegister
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataRegister
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataRegister

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataRegister
        

        /// <summary>
        /// Конструктор для проведения документов, передается проводимый документ.
        /// </summary>
        public static Продажи Новый(NsgDataDocument document)
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("4d0af52d-7931-4952-9a22-c4ab6d585ddb"));
            if (obj == null)
                obj = new Продажи();
            (obj as Продажи).Document = document;
            return obj as Продажи;
        }
        



        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataRegister

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected Продажи()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected Продажи(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static Продажи Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("4d0af52d-7931-4952-9a22-c4ab6d585ddb"));
            if (obj == null)
                obj = new Продажи();
            return obj as Продажи;
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
			#region начало инициализации NsgSoft.DataObjects.NsgDataRegister
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataRegister
			
			#region создание System.Guid Идентификатор
			{  
                NsgDataGuid Идентификатор = null;
				if (ObjectList.Contains("Идентификатор"))
                    Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                else
                    Идентификатор = new NsgDataGuid();
	//NsgDataGuid
	Идентификатор.IsLoadedFromDll = true;
	Идентификатор.StringFormat = "";
	Идентификатор.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Идентификатор.IncludeInPredefined = false;
	Идентификатор.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Идентификатор.Required = false;
	Идентификатор.EmptyValue = "";
	Идентификатор.NullAllow = false;
	Идентификатор.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Идентификатор.FieldName = "_ID";
	Идентификатор.SaveInDatabase = true;
	Идентификатор.InformMetaDataOnValueChanged = false;
	Идентификатор.Visible = true;
	Идентификатор.Name = "Идентификатор";
	Идентификатор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Идентификатор.Description = "Идентификатор";
	Идентификатор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Идентификатор.GroupName = "";
	Идентификатор.Guid = NsgService.StringToGuid("ac1f4eda-5763-49ac-b890-cd44549771ab");
	
				if (!ObjectList.Contains("Идентификатор"))
                    ObjectList.Add(Идентификатор);
			}
			#endregion //создание System.Guid Идентификатор
			
			#region создание System.Int64 Автоинкремент
			{  
                NsgDataInteger Автоинкремент = null;
				if (ObjectList.Contains("Автоинкремент"))
                    Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                else
                    Автоинкремент = new NsgDataInteger();
	//NsgDataInteger
	Автоинкремент.IsLoadedFromDll = true;
	Автоинкремент.DefaultValue = 0M;
	Автоинкремент.MinValue = 0M;
	Автоинкремент.MaxValue = 0M;
	Автоинкремент.UseCalculator = true;
	Автоинкремент.StringFormat = "";
	Автоинкремент.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Автоинкремент.IncludeInPredefined = false;
	Автоинкремент.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Автоинкремент.Required = false;
	Автоинкремент.EmptyValue = "";
	Автоинкремент.NullAllow = false;
	Автоинкремент.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Автоинкремент.FieldName = "_AutoInc";
	Автоинкремент.SaveInDatabase = true;
	Автоинкремент.InformMetaDataOnValueChanged = false;
	Автоинкремент.Visible = true;
	Автоинкремент.Name = "Автоинкремент";
	Автоинкремент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Автоинкремент.Description = "Автоинкремент";
	Автоинкремент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	Автоинкремент.GroupName = "";
	Автоинкремент.Guid = NsgService.StringToGuid("8fd8f74e-8123-4a27-bd38-0f304d28caf6");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание _SystemTables.АвтосервисПродажиДвижения Движения
			{  
                NsgRegisterTable Движения = null;
				if (ObjectList.Contains("Движения"))
                    Движения = ObjectList["Движения"] as NsgRegisterTable;
                else
                    Движения = new NsgRegisterTable();
	//NsgRegisterTable
	Движения.IsLoadedFromDll = true;
	Движения.Name = "Движения";
	Движения.RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	Движения.RegisterPeriodCount = 1;
	Движения.ReferentGroup = "_SystemTables";
	Движения.ReferentName = "АвтосервисПродажиДвижения";
	Движения.SaveInDatabase = false;
	Движения.OwnerName = "";
	Движения.AllowEmptyOwner = false;
	Движения.StringFormat = "";
	Движения.SubType = NsgSoft.Common.NsgRekvisitSubType.TabMovement;
	Движения.IncludeInPredefined = false;
	Движения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Движения.Required = false;
	Движения.EmptyValue = "";
	Движения.NullAllow = false;
	Движения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Движения.FieldName = "Dvizhenija";
	Движения.InformMetaDataOnValueChanged = false;
	Движения.Visible = true;
	Движения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Движения.Description = "Движения";
	Движения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.NonRemovable;
	Движения.GroupName = "";
	Движения.Guid = NsgService.StringToGuid("0df25726-c523-4198-8869-58c8ae3911a8");
	
				if (!ObjectList.Contains("Движения"))
                    ObjectList.Add(Движения);
			}
			#endregion //создание _SystemTables.АвтосервисПродажиДвижения Движения
			
			#region создание _SystemTables.АвтосервисПродажиНакопления Накопления
			{  
                NsgRegisterTable Накопления = null;
				if (ObjectList.Contains("Накопления"))
                    Накопления = ObjectList["Накопления"] as NsgRegisterTable;
                else
                    Накопления = new NsgRegisterTable();
	//NsgRegisterTable
	Накопления.IsLoadedFromDll = true;
	Накопления.Name = "Накопления";
	Накопления.RegisterPeriod = NsgSoft.Common.NsgPeriod.None;
	Накопления.RegisterPeriodCount = 1;
	Накопления.ReferentGroup = "_SystemTables";
	Накопления.ReferentName = "АвтосервисПродажиНакопления";
	Накопления.SaveInDatabase = false;
	Накопления.OwnerName = "";
	Накопления.AllowEmptyOwner = false;
	Накопления.StringFormat = "";
	Накопления.SubType = NsgSoft.Common.NsgRekvisitSubType.TabAccumulate;
	Накопления.IncludeInPredefined = false;
	Накопления.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Накопления.Required = false;
	Накопления.EmptyValue = "";
	Накопления.NullAllow = false;
	Накопления.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Накопления.FieldName = "Nakoplenija";
	Накопления.InformMetaDataOnValueChanged = false;
	Накопления.Visible = true;
	Накопления.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Накопления.Description = "Накопления";
	Накопления.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.NonRemovable;
	Накопления.GroupName = "";
	Накопления.Guid = NsgService.StringToGuid("70e36f8a-94f3-4431-a482-507ded27a8e1");
	
				if (!ObjectList.Contains("Накопления"))
                    ObjectList.Add(Накопления);
			}
			#endregion //создание _SystemTables.АвтосервисПродажиНакопления Накопления
			
			#region создание _SystemTables.АвтосервисПродажиНакопления_1 Накопления_1
			{  
                NsgRegisterTable Накопления_1 = null;
				if (ObjectList.Contains("Накопления_1"))
                    Накопления_1 = ObjectList["Накопления_1"] as NsgRegisterTable;
                else
                    Накопления_1 = new NsgRegisterTable();
	//NsgRegisterTable
	Накопления_1.IsLoadedFromDll = true;
	Накопления_1.Name = "Накопления_1";
	Накопления_1.RegisterPeriod = NsgSoft.Common.NsgPeriod.Month;
	Накопления_1.RegisterPeriodCount = 1;
	Накопления_1.ReferentGroup = "_SystemTables";
	Накопления_1.ReferentName = "АвтосервисПродажиНакопления_1";
	Накопления_1.SaveInDatabase = false;
	Накопления_1.OwnerName = "";
	Накопления_1.AllowEmptyOwner = false;
	Накопления_1.StringFormat = "";
	Накопления_1.SubType = NsgSoft.Common.NsgRekvisitSubType.TabAccumulate;
	Накопления_1.IncludeInPredefined = false;
	Накопления_1.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Накопления_1.Required = false;
	Накопления_1.EmptyValue = "";
	Накопления_1.NullAllow = false;
	Накопления_1.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Накопления_1.FieldName = "Nakoplenija_1";
	Накопления_1.InformMetaDataOnValueChanged = false;
	Накопления_1.Visible = true;
	Накопления_1.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Накопления_1.Description = "Накопления_1";
	Накопления_1.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Накопления_1.GroupName = "";
	Накопления_1.Guid = NsgService.StringToGuid("f6d97f45-25b3-4694-82fb-6b45e0186a5f");
	
				if (!ObjectList.Contains("Накопления_1"))
                    ObjectList.Add(Накопления_1);
			}
			#endregion //создание _SystemTables.АвтосервисПродажиНакопления_1 Накопления_1
			
			#region создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			{  
                NsgDataUntypedReference Владелец = null;
				if (ObjectList.Contains("Владелец"))
                    Владелец = ObjectList["Владелец"] as NsgDataUntypedReference;
                else
                    Владелец = new NsgDataUntypedReference();
	//NsgDataUntypedReference
	Владелец.IsLoadedFromDll = true;
	Владелец.FilterTypeForConfigurator = NsgSoft.DataObjects.NsgFiltration.List;
	Владелец.FilterForConfigurator = "Сервис.КорректировкаРегистра,Автосервис.РасходнаяНакладная";
	Владелец.ReferentName = "";
	Владелец.ReferentGroup = "";
	Владелец.TypeSelectorName = "";
	Владелец.SaveInDatabase = true;
	Владелец.OwnerName = "";
	Владелец.AllowEmptyOwner = false;
	Владелец.StringFormat = "";
	Владелец.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Владелец.IncludeInPredefined = false;
	Владелец.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Владелец.Required = false;
	Владелец.EmptyValue = "";
	Владелец.NullAllow = false;
	Владелец.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Владелец.FieldName = "_Owner";
	Владелец.InformMetaDataOnValueChanged = false;
	Владелец.Visible = true;
	Владелец.Name = "Владелец";
	Владелец.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Владелец.Description = "Владелец";
	Владелец.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Владелец.GroupName = "";
	Владелец.Guid = NsgService.StringToGuid("441afce2-f9de-49f5-b17f-8f7f8039b412");
	
				if (!ObjectList.Contains("Владелец"))
                    ObjectList.Add(Владелец);
			}
			#endregion //создание NsgSoft.DataObjects.NsgReferencedObject Владелец
			
			#region создание Сервис.ВидыДвижений ВидДвижения
			{  
                NsgDataEnumReference ВидДвижения = null;
				if (ObjectList.Contains("ВидДвижения"))
                    ВидДвижения = ObjectList["ВидДвижения"] as NsgDataEnumReference;
                else
                    ВидДвижения = new NsgDataEnumReference();
	//NsgDataEnumReference
	ВидДвижения.IsLoadedFromDll = true;
	ВидДвижения.ReferentGroup = "Сервис";
	ВидДвижения.ReferentName = "ВидыДвижений";
	ВидДвижения.SaveInDatabase = true;
	ВидДвижения.OwnerName = "";
	ВидДвижения.AllowEmptyOwner = false;
	ВидДвижения.StringFormat = "";
	ВидДвижения.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	ВидДвижения.IncludeInPredefined = false;
	ВидДвижения.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ВидДвижения.Required = false;
	ВидДвижения.EmptyValue = "";
	ВидДвижения.NullAllow = false;
	ВидДвижения.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ВидДвижения.FieldName = "_Sign";
	ВидДвижения.InformMetaDataOnValueChanged = false;
	ВидДвижения.Visible = true;
	ВидДвижения.Name = "ВидДвижения";
	ВидДвижения.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ВидДвижения.Description = "Вид движения";
	ВидДвижения.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ВидДвижения.GroupName = "";
	ВидДвижения.Guid = NsgService.StringToGuid("3c5fa15d-d3c4-4882-974f-1f64923144a9");
	
				if (!ObjectList.Contains("ВидДвижения"))
                    ObjectList.Add(ВидДвижения);
			}
			#endregion //создание Сервис.ВидыДвижений ВидДвижения
			
			#region создание System.DateTime ДатаДокумента
			{  
                NsgDataDateTime ДатаДокумента = null;
				if (ObjectList.Contains("ДатаДокумента"))
                    ДатаДокумента = ObjectList["ДатаДокумента"] as NsgDataDateTime;
                else
                    ДатаДокумента = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаДокумента.IsLoadedFromDll = true;
	ДатаДокумента.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаДокумента.StringFormat = "";
	ДатаДокумента.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаДокумента.IncludeInPredefined = false;
	ДатаДокумента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаДокумента.Required = false;
	ДатаДокумента.EmptyValue = "";
	ДатаДокумента.NullAllow = false;
	ДатаДокумента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДатаДокумента.FieldName = "_Date";
	ДатаДокумента.SaveInDatabase = true;
	ДатаДокумента.InformMetaDataOnValueChanged = false;
	ДатаДокумента.Visible = true;
	ДатаДокумента.Name = "ДатаДокумента";
	ДатаДокумента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ДатаДокумента.Description = "Дата документа";
	ДатаДокумента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	ДатаДокумента.GroupName = "";
	ДатаДокумента.Guid = NsgService.StringToGuid("f7b6e91e-236f-43e4-a989-429d3902235e");
	
				if (!ObjectList.Contains("ДатаДокумента"))
                    ObjectList.Add(ДатаДокумента);
			}
			#endregion //создание System.DateTime ДатаДокумента
			
			#region создание System.Boolean Активность
			{  
                NsgDataBoolean Активность = null;
				if (ObjectList.Contains("Активность"))
                    Активность = ObjectList["Активность"] as NsgDataBoolean;
                else
                    Активность = new NsgDataBoolean();
	//NsgDataBoolean
	Активность.IsLoadedFromDll = true;
	Активность.DefaultValue = false;
	Активность.TrueString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Активность.FalseString = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Активность.StringFormat = "";
	Активность.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Активность.IncludeInPredefined = false;
	Активность.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Активность.Required = false;
	Активность.EmptyValue = "";
	Активность.NullAllow = false;
	Активность.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Активность.FieldName = "_Active";
	Активность.SaveInDatabase = true;
	Активность.InformMetaDataOnValueChanged = false;
	Активность.Visible = true;
	Активность.Name = "Активность";
	Активность.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Активность.Description = "Активность";
	Активность.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	Активность.GroupName = "";
	Активность.Guid = NsgService.StringToGuid("48c3c4e8-03bb-48ba-981f-e4d594268738");
	
				if (!ObjectList.Contains("Активность"))
                    ObjectList.Add(Активность);
			}
			#endregion //создание System.Boolean Активность
			
			#region создание Автосервис.Контрагент Контрагент
			{  
                NsgDataTypedReference Контрагент = null;
				if (ObjectList.Contains("Контрагент"))
                    Контрагент = ObjectList["Контрагент"] as NsgDataTypedReference;
                else
                    Контрагент = new NsgDataTypedReference();
	//NsgDataTypedReference
	Контрагент.IsLoadedFromDll = true;
	Контрагент.ReferentGroup = "Автосервис";
	Контрагент.ReferentName = "Контрагент";
	Контрагент.SaveInDatabase = true;
	Контрагент.OwnerName = "";
	Контрагент.AllowEmptyOwner = false;
	Контрагент.StringFormat = "";
	Контрагент.SubType = NsgSoft.Common.NsgRekvisitSubType.Dimension;
	Контрагент.IncludeInPredefined = false;
	Контрагент.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Контрагент.Required = false;
	Контрагент.EmptyValue = "";
	Контрагент.NullAllow = false;
	Контрагент.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Контрагент.FieldName = "Kontragent";
	Контрагент.RegisterDistributionType = NsgSoft.DataObjects.NsgRegisterDistributionType.Filter;
	Контрагент.CharacteristicCompareType = NsgSoft.Database.NsgComparison.Equal;
	Контрагент.CharactericticWeight = 1;
	Контрагент.InformMetaDataOnValueChanged = false;
	Контрагент.Visible = true;
	Контрагент.Name = "Контрагент";
	Контрагент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Контрагент.Description = "Контрагент";
	Контрагент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Контрагент.GroupName = "";
	Контрагент.Guid = NsgService.StringToGuid("753bd160-56a8-4612-afb9-b4b69573e2be");
	
				if (!ObjectList.Contains("Контрагент"))
                    ObjectList.Add(Контрагент);
			}
			#endregion //создание Автосервис.Контрагент Контрагент
			
			#region создание System.Decimal Количество
			{  
                NsgDataFloat Количество = null;
				if (ObjectList.Contains("Количество"))
                    Количество = ObjectList["Количество"] as NsgDataFloat;
                else
                    Количество = new NsgDataFloat();
	//NsgDataFloat
	Количество.IsLoadedFromDll = true;
	Количество.Precision = 2;
	Количество.HideZero = true;
	Количество.DefaultValue = 0M;
	Количество.MinValue = -1000000000000000M;
	Количество.MaxValue = 1000000000000000M;
	Количество.UseCalculator = true;
	Количество.StringFormat = "";
	Количество.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Количество.IncludeInPredefined = false;
	Количество.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Количество.Required = false;
	Количество.EmptyValue = "";
	Количество.NullAllow = false;
	Количество.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Количество.FieldName = "Kolichestvo";
	Количество.InformMetaDataOnValueChanged = false;
	Количество.Visible = true;
	Количество.Name = "Количество";
	Количество.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Количество.Description = "Количество";
	Количество.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Количество.GroupName = "";
	Количество.Guid = NsgService.StringToGuid("502e0df5-9590-48e5-a77d-6903456bab8e");
	
				if (!ObjectList.Contains("Количество"))
                    ObjectList.Add(Количество);
			}
			#endregion //создание System.Decimal Количество
			
			#region создание System.Decimal Сумма
			{  
                NsgDataFloat Сумма = null;
				if (ObjectList.Contains("Сумма"))
                    Сумма = ObjectList["Сумма"] as NsgDataFloat;
                else
                    Сумма = new NsgDataFloat();
	//NsgDataFloat
	Сумма.IsLoadedFromDll = true;
	Сумма.Precision = 2;
	Сумма.HideZero = true;
	Сумма.DefaultValue = 0M;
	Сумма.MinValue = -1000000000000000M;
	Сумма.MaxValue = 1000000000000000M;
	Сумма.UseCalculator = true;
	Сумма.StringFormat = "";
	Сумма.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Сумма.IncludeInPredefined = false;
	Сумма.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Сумма.Required = false;
	Сумма.EmptyValue = "";
	Сумма.NullAllow = false;
	Сумма.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Сумма.FieldName = "Summa";
	Сумма.InformMetaDataOnValueChanged = false;
	Сумма.Visible = true;
	Сумма.Name = "Сумма";
	Сумма.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Сумма.Description = "Сумма";
	Сумма.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Сумма.GroupName = "";
	Сумма.Guid = NsgService.StringToGuid("86115533-9749-400d-be43-f4d8e0d282c2");
	
				if (!ObjectList.Contains("Сумма"))
                    ObjectList.Add(Сумма);
			}
			#endregion //создание System.Decimal Сумма
			
			#region создание System.Decimal Прибыль
			{  
                NsgDataFloat Прибыль = null;
				if (ObjectList.Contains("Прибыль"))
                    Прибыль = ObjectList["Прибыль"] as NsgDataFloat;
                else
                    Прибыль = new NsgDataFloat();
	//NsgDataFloat
	Прибыль.IsLoadedFromDll = true;
	Прибыль.Precision = 2;
	Прибыль.HideZero = true;
	Прибыль.DefaultValue = 0M;
	Прибыль.MinValue = -1000000000000000M;
	Прибыль.MaxValue = 1000000000000000M;
	Прибыль.UseCalculator = true;
	Прибыль.StringFormat = "";
	Прибыль.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Прибыль.IncludeInPredefined = false;
	Прибыль.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Прибыль.Required = false;
	Прибыль.EmptyValue = "";
	Прибыль.NullAllow = false;
	Прибыль.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Прибыль.FieldName = "Pribyl";
	Прибыль.InformMetaDataOnValueChanged = false;
	Прибыль.Visible = true;
	Прибыль.Name = "Прибыль";
	Прибыль.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Прибыль.Description = "Прибыль";
	Прибыль.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Прибыль.GroupName = "";
	Прибыль.Guid = NsgService.StringToGuid("3c99dbde-79b9-4e54-8d29-d0a42e0816fb");
	
				if (!ObjectList.Contains("Прибыль"))
                    ObjectList.Add(Прибыль);
			}
			#endregion //создание System.Decimal Прибыль
			
			#region создание System.Decimal Рентабильность
			{  
                NsgDataFloat Рентабильность = null;
				if (ObjectList.Contains("Рентабильность"))
                    Рентабильность = ObjectList["Рентабильность"] as NsgDataFloat;
                else
                    Рентабильность = new NsgDataFloat();
	//NsgDataFloat
	Рентабильность.IsLoadedFromDll = true;
	Рентабильность.Precision = 2;
	Рентабильность.HideZero = true;
	Рентабильность.DefaultValue = 0M;
	Рентабильность.MinValue = -1000000000000000M;
	Рентабильность.MaxValue = 1000000000000000M;
	Рентабильность.UseCalculator = true;
	Рентабильность.StringFormat = "";
	Рентабильность.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Рентабильность.IncludeInPredefined = false;
	Рентабильность.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Рентабильность.Required = false;
	Рентабильность.EmptyValue = "";
	Рентабильность.NullAllow = false;
	Рентабильность.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Рентабильность.FieldName = "Rentabilnost";
	Рентабильность.InformMetaDataOnValueChanged = false;
	Рентабильность.Visible = true;
	Рентабильность.Name = "Рентабильность";
	Рентабильность.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Рентабильность.Description = "Рентабильность";
	Рентабильность.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Рентабильность.GroupName = "";
	Рентабильность.Guid = NsgService.StringToGuid("a4c6c043-5620-4187-9b6b-c6ed053c9018");
	
				if (!ObjectList.Contains("Рентабильность"))
                    ObjectList.Add(Рентабильность);
			}
			#endregion //создание System.Decimal Рентабильность
			
			#region создание Автосервис.Номенклатура Номенклатура
			{  
                NsgDataTypedReference Номенклатура = null;
				if (ObjectList.Contains("Номенклатура"))
                    Номенклатура = ObjectList["Номенклатура"] as NsgDataTypedReference;
                else
                    Номенклатура = new NsgDataTypedReference();
	//NsgDataTypedReference
	Номенклатура.IsLoadedFromDll = true;
	Номенклатура.ReferentGroup = "Автосервис";
	Номенклатура.ReferentName = "Номенклатура";
	Номенклатура.SaveInDatabase = true;
	Номенклатура.OwnerName = "";
	Номенклатура.AllowEmptyOwner = false;
	Номенклатура.StringFormat = "";
	Номенклатура.SubType = NsgSoft.Common.NsgRekvisitSubType.Property;
	Номенклатура.IncludeInPredefined = false;
	Номенклатура.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Номенклатура.Required = false;
	Номенклатура.EmptyValue = "";
	Номенклатура.NullAllow = false;
	Номенклатура.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Номенклатура.FieldName = "Nomenklatura";
	Номенклатура.InformMetaDataOnValueChanged = false;
	Номенклатура.Visible = true;
	Номенклатура.Name = "Номенклатура";
	Номенклатура.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Номенклатура.Description = "Номенклатура";
	Номенклатура.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Номенклатура.GroupName = "";
	Номенклатура.Guid = NsgService.StringToGuid("8adc0c16-2eb1-441f-907b-8a54313aa448");
	
				if (!ObjectList.Contains("Номенклатура"))
                    ObjectList.Add(Номенклатура);
			}
			#endregion //создание Автосервис.Номенклатура Номенклатура
			
			#region создание System.Decimal Цена
			{  
                NsgDataFloat Цена = null;
				if (ObjectList.Contains("Цена"))
                    Цена = ObjectList["Цена"] as NsgDataFloat;
                else
                    Цена = new NsgDataFloat();
	//NsgDataFloat
	Цена.IsLoadedFromDll = true;
	Цена.Precision = 2;
	Цена.HideZero = true;
	Цена.DefaultValue = 0M;
	Цена.MinValue = -1000000000000000M;
	Цена.MaxValue = 1000000000000000M;
	Цена.UseCalculator = true;
	Цена.StringFormat = "";
	Цена.SubType = NsgSoft.Common.NsgRekvisitSubType.Resource;
	Цена.IncludeInPredefined = false;
	Цена.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Цена.Required = false;
	Цена.EmptyValue = "";
	Цена.NullAllow = false;
	Цена.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	Цена.FieldName = "Cena";
	Цена.InformMetaDataOnValueChanged = false;
	Цена.Visible = true;
	Цена.Name = "Цена";
	Цена.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Цена.Description = "Цена";
	Цена.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	Цена.GroupName = "";
	Цена.Guid = NsgService.StringToGuid("36a4fef0-e773-447e-9c51-9dec0c993bc7");
	
				if (!ObjectList.Contains("Цена"))
                    ObjectList.Add(Цена);
			}
			#endregion //создание System.Decimal Цена
			

			#region заполнение полей класса
				//NsgDataRegister
	IsLoadedFromDll = true;
	SearchFieldName = "";
	RegisterType = NsgSoft.DataObjects.NsgRegisterType.Accummulate;
	QuantityName = "";
	HandlingWarnings = NsgSoft.DataObjects.NsgHandlingWarnings.None;
	Name = "Продажи";
	Visible = true;
	Guid = NsgService.StringToGuid("4d0af52d-7931-4952-9a22-c4ab6d585ddb");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "NSGA_reg_Prodazhi";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Description = "Регистр";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Full;
	GroupName = "Автосервис";
	ConnectAdditionalTables();

			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataRegister
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataRegister

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
        public new partial class Names// :NsgSoft.DataObjects.NsgDataRegister.Names
        {
            
            /// <summary>
            /// Идентификатор
            /// </summary>
            public static String Идентификатор
            {
                get
                {
                    return "Идентификатор";
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
            /// Движения
            /// </summary>
            public static String Движения
            {
                get
                {
                    return "Движения";
                }
            }
            
            /// <summary>
            /// Накопления
            /// </summary>
            public static String Накопления
            {
                get
                {
                    return "Накопления";
                }
            }
            
            /// <summary>
            /// Накопления_1
            /// </summary>
            public static String Накопления_1
            {
                get
                {
                    return "Накопления_1";
                }
            }
            
            /// <summary>
            /// Владелец
            /// </summary>
            public static String Владелец
            {
                get
                {
                    return "Владелец";
                }
            }
            
            /// <summary>
            /// Вид движения
            /// </summary>
            public static String ВидДвижения
            {
                get
                {
                    return "ВидДвижения";
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
            
            /// <summary>
            /// Активность
            /// </summary>
            public static String Активность
            {
                get
                {
                    return "Активность";
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
            /// Количество
            /// </summary>
            public static String Количество
            {
                get
                {
                    return "Количество";
                }
            }
            
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
            /// Прибыль
            /// </summary>
            public static String Прибыль
            {
                get
                {
                    return "Прибыль";
                }
            }
            
            /// <summary>
            /// Рентабильность
            /// </summary>
            public static String Рентабильность
            {
                get
                {
                    return "Рентабильность";
                }
            }
            
            /// <summary>
            /// Номенклатура
            /// </summary>
            public static String Номенклатура
            {
                get
                {
                    return "Номенклатура";
                }
            }
            
            /// <summary>
            /// Цена
            /// </summary>
            public static String Цена
            {
                get
                {
                    return "Цена";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public static string GetFullName()
        {
            return "Автосервис.Продажи";
        }

        
        /// <summary>
        /// Идентификатор
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid Идентификатор
        {
            get
            {
				 NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                 return (System.Guid)__Идентификатор.Value;
            }
            set
            {
                NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                __Идентификатор.Value = value;
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
        /// Движения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.АвтосервисПродажиДвижения Движения
        {
            get
            {
				 NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                 return (_SystemTables.АвтосервисПродажиДвижения)__Движения.Referent;
            }
            set
            {
                NsgRegisterTable __Движения = ObjectList["Движения"] as NsgRegisterTable;
                __Движения.Referent = value;
            }
        }
        
        /// <summary>
        /// Накопления
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.АвтосервисПродажиНакопления Накопления
        {
            get
            {
				 NsgRegisterTable __Накопления = ObjectList["Накопления"] as NsgRegisterTable;
                 return (_SystemTables.АвтосервисПродажиНакопления)__Накопления.Referent;
            }
            set
            {
                NsgRegisterTable __Накопления = ObjectList["Накопления"] as NsgRegisterTable;
                __Накопления.Referent = value;
            }
        }
        
        /// <summary>
        /// Накопления_1
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataTable")]
        
        public _SystemTables.АвтосервисПродажиНакопления_1 Накопления_1
        {
            get
            {
				 NsgRegisterTable __Накопления_1 = ObjectList["Накопления_1"] as NsgRegisterTable;
                 return (_SystemTables.АвтосервисПродажиНакопления_1)__Накопления_1.Referent;
            }
            set
            {
                NsgRegisterTable __Накопления_1 = ObjectList["Накопления_1"] as NsgRegisterTable;
                __Накопления_1.Referent = value;
            }
        }
        
        /// <summary>
        /// Владелец
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgReferencedObject")]
        [NsgReferentsFilterAttribute("Сервис.КорректировкаРегистра,Автосервис.РасходнаяНакладная")]
        public NsgSoft.DataObjects.NsgReferencedObject Владелец
        {
            get
            {
				 NsgDataUntypedReference __Владелец = ObjectList["Владелец"] as NsgDataUntypedReference;
                 return (NsgSoft.DataObjects.NsgReferencedObject)__Владелец.Referent;
            }
            set
            {
                NsgDataUntypedReference __Владелец = ObjectList["Владелец"] as NsgDataUntypedReference;
                __Владелец.Referent = value;
            }
        }
        
        /// <summary>
        /// Вид движения
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataEnum")]
        
        public Сервис.ВидыДвижений ВидДвижения
        {
            get
            {
				 NsgDataEnumReference __ВидДвижения = ObjectList["ВидДвижения"] as NsgDataEnumReference;
                 return (Сервис.ВидыДвижений)__ВидДвижения.Referent;
            }
            set
            {
                NsgDataEnumReference __ВидДвижения = ObjectList["ВидДвижения"] as NsgDataEnumReference;
                __ВидДвижения.Referent = value;
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
        
        /// <summary>
        /// Активность
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataBoolean")]
        
        public System.Boolean Активность
        {
            get
            {
				 NsgDataBoolean __Активность = ObjectList["Активность"] as NsgDataBoolean;
                 return (System.Boolean)__Активность.Value;
            }
            set
            {
                NsgDataBoolean __Активность = ObjectList["Активность"] as NsgDataBoolean;
                __Активность.Value = value;
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
        /// Количество
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Количество
        {
            get
            {
				 NsgDataFloat __Количество = ObjectList["Количество"] as NsgDataFloat;
                 return (System.Decimal)__Количество.Value;
            }
            set
            {
                NsgDataFloat __Количество = ObjectList["Количество"] as NsgDataFloat;
                __Количество.Value = value;
            }
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
        /// Прибыль
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Прибыль
        {
            get
            {
				 NsgDataFloat __Прибыль = ObjectList["Прибыль"] as NsgDataFloat;
                 return (System.Decimal)__Прибыль.Value;
            }
            set
            {
                NsgDataFloat __Прибыль = ObjectList["Прибыль"] as NsgDataFloat;
                __Прибыль.Value = value;
            }
        }
        
        /// <summary>
        /// Рентабильность
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Рентабильность
        {
            get
            {
				 NsgDataFloat __Рентабильность = ObjectList["Рентабильность"] as NsgDataFloat;
                 return (System.Decimal)__Рентабильность.Value;
            }
            set
            {
                NsgDataFloat __Рентабильность = ObjectList["Рентабильность"] as NsgDataFloat;
                __Рентабильность.Value = value;
            }
        }
        
        /// <summary>
        /// Номенклатура
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDictionary")]
        
        public Автосервис.Номенклатура Номенклатура
        {
            get
            {
				 NsgDataTypedReference __Номенклатура = ObjectList["Номенклатура"] as NsgDataTypedReference;
                 return (Автосервис.Номенклатура)__Номенклатура.Referent;
            }
            set
            {
                NsgDataTypedReference __Номенклатура = ObjectList["Номенклатура"] as NsgDataTypedReference;
                __Номенклатура.Referent = value;
            }
        }
        
        /// <summary>
        /// Цена
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataFloat")]
        
        public System.Decimal Цена
        {
            get
            {
				 NsgDataFloat __Цена = ObjectList["Цена"] as NsgDataFloat;
                 return (System.Decimal)__Цена.Value;
            }
            set
            {
                NsgDataFloat __Цена = ObjectList["Цена"] as NsgDataFloat;
                __Цена.Value = value;
            }
        }
        

        
        #region Свойства NsgSoft.DataObjects.NsgDataRegister
        




        #endregion // Свойства NsgSoft.DataObjects.NsgDataRegister

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataRegister
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataRegister

        #region Методы NsgMultipleObject
        private Продажи[] convertArray(NsgMultipleObject[] array)
        {
            Продажи[] res = new Продажи[array.Length];
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
        public new virtual Продажи[] FindAll(NsgCompare compare)
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
        public new virtual Продажи[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
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
        public new virtual Продажи[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
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
        public new virtual Продажи[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new Продажи(this as NsgObject);
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
                base.NSGType = typeof(Продажи);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new Продажи Value
            {
                get
                {
                    return (Продажи)base.Value;
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
                    return "s_NsgDataRegister";
                }
            }
        }
    }

}
