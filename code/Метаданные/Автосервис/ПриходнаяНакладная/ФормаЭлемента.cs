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
    
    public partial class ПриходнаяНакладнаяФормаЭлемента

    {
        public ПриходнаяНакладнаяФормаЭлемента()
        {
            InitializeComponent();
		}

        #region #Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Data# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Constructors# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgMultipleObjectElementForm

        #region #Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgMultipleObjectElementForm

        private void nsgIGrid1_CellEndEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Номенклатура.Name)
            {
                Цена.Value = Номенклатура.Value.Цена;
                Сумма.Value = Номенклатура.Value.Цена * Количество.Value;
            }
            if (e.ColumnName == Цена.Name)
            {
                Сумма.Value = Цена.Value * Количество.Value;
            }
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
            //Сумма.Value = Номенклатура.Value.Цена * Количество.Value;
            //if (e.ColumnName == Количество.Name)
            //{
            //    if (Количество.Value > 100)
            //    {
            //        e.RowObject.AddUserProperty(NsgIGrid.BACKCOLOR, Color.Red);
            //        e.CellObject.AddUserProperty(NsgIGrid.BLINK, true);
            //    }
            //    else
            //    {
            //        e.RowObject.DeleteUserProperty(NsgIGrid.BACKCOLOR);
            //        e.CellObject.DeleteUserProperty(NsgIGrid.BLINK);
            //    }
            //}
        }

        private void nsgIGrid1_CellRequestEdit(object sender, NsgIGrid.NsgIGridCellEventArgs e)
        {
            if (e.ColumnName == Сумма.Name)
            {
                e.Cancel = true;
            }
        }
    }
    


}