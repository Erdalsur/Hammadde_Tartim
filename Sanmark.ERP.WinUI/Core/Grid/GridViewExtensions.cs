using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sanmark.ERP.WinUI.Core.Grid
{
    public static class GridViewExtensions
    {
        public static GridManager GetManager(this GridView gridView)
        {
            return GridManager.GetManager(gridView);
        }
        #region Extensions
        public static void SetViewCaption(this GridView gridView, string Caption)
        {
            gridView.OptionsView.ShowViewCaption = true;
            gridView.ViewCaption = Caption;
        }
        /// <summary>
        /// Sütun başlıklarını düzenler."Id:Referans Numarası","Email:E-mail Adresi" Şeklinde
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="pairs">Sütunİsmi:Başlık, Sütunİsmi:Başlık , ...</param>
        public static void SetCaptions(this GridView gridView, params string[] pairs)
        {
            List<string> invalidColumns = new List<string>();

            foreach (string pair in pairs)
            {
                string[] vals = pair.Split(':');
                string colName = vals[0].Trim().Replace("Id", "Id");
                string caption = vals[1].Trim();
                GridColumn col = gridView.Columns[colName];
                if (col != null)
                {
                    col.Caption = caption;
                    if (caption == "#")
                        col.ToolTip = colName;
                }
                else
                    invalidColumns.Add(colName);
            }

            //invalidColumns.CheckInvalidColumns();
        }
        public static void MakeColumnsReadOnly(this GridView gridView, params string[] columnNames)
        {
            List<string> invalidColumns = new List<string>();

            foreach (string colName in columnNames)
            {
                GridColumn col = gridView.Columns[colName];//.Replace("ProductId", "PRO")];
                if (col != null)
                    col.OptionsColumn.AllowEdit = false;
                else
                    invalidColumns.Add(colName);
            }

            //invalidColumns.CheckInvalidColumns();
        }
        public static void MakeColumnVisible(this GridView gridView, params string[] columnNames)
        {
            List<string> invalidColumns = new List<string>();

            foreach (string colName in columnNames)
            {
                GridColumn col = gridView.Columns[colName.Replace("Id", "Id")];
                if (col != null)
                    col.Visible = true;
                else
                    invalidColumns.Add(colName);
            }

            //invalidColumns.CheckInvalidColumns();
        }
        /// <summary>
        /// Kolonları Gizlemek İçin Kullanılır. Örnek "Kolon Adı","Kolon Adı"
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="columnNames"></param>
        public static void MakeColumnInvisible(this GridView gridView, params string[] columnNames)
        {
            List<string> invalidColumns = new List<string>();

            foreach (string colName in columnNames)
            {
                GridColumn col = gridView.Columns[colName.Replace("Id", "Id")];

                if (col != null)
                    col.Visible = false;
                else
                    invalidColumns.Add(colName);
            }

            //invalidColumns.CheckInvalidColumns();
        }
        private static void SetEditable(this GridView gridView, bool MakeEditable, params string[] ExceptTheseColumns)
        {
            List<string> invalidColumns = new List<string>();

            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = MakeEditable;

            foreach (string colName in ExceptTheseColumns)
            {
                GridColumn col;
                if (colName == "Id")
                {
                    col = gridView.Columns["Id"];

                    if (col != null)
                        col.OptionsColumn.AllowEdit = !MakeEditable;
                    else
                        invalidColumns.Add(colName);
                }

                col = gridView.Columns[colName.Replace("Id", "Id")];

                if (col != null)
                    col.OptionsColumn.AllowEdit = !MakeEditable;
                else
                    invalidColumns.Add(colName);
            }

            //invalidColumns.CheckInvalidColumns();
        }
        public static void MakeReadOnly(this GridView gridView, params string[] ExceptTheseColumns)
        {
            gridView.SetEditable(false, ExceptTheseColumns);
        }
        public static void SetAlternateRowStyle(this GridView gridView, bool Status)
        {
            gridView.OptionsView.EnableAppearanceEvenRow = Status;
            gridView.OptionsView.EnableAppearanceOddRow = false;
        }
        /// <summary>
        /// Seçili (yoksa focused) satırlarda, belirtilen sütundaki değerleri virgül ile birleştirip döndürür.
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static string GetSelectedValues(this GridView gridView, string columnName)
        {
            List<string> vals = new List<string>();
            if (gridView.Columns[columnName] == null)
                throw new KeyNotFoundException(columnName + " sütunu yok!");
            else
            {
                foreach (int rowHandle in gridView.GetSelectedRows())
                    if (rowHandle > -1)
                        vals.Add(gridView.GetRowCellValue(rowHandle, columnName).ToString());

                if (vals.Count == 0
                    && GridControl.NewItemRowHandle != gridView.FocusedRowHandle
                    && GridControl.AutoFilterRowHandle != gridView.FocusedRowHandle
                    )
                    vals.Add(gridView.GetFocusedRowCellValue(columnName).ToString());

                return string.Join(",", vals);
            }
        }

        public static void EnableNewRow(this GridView gridView, NewItemRowPosition Position = NewItemRowPosition.Bottom)
        {
            gridView.OptionsView.NewItemRowPosition = Position;
        }
        public static void EnableNewRowTop(this GridView gridView, NewItemRowPosition Position = NewItemRowPosition.Top)
        {
            gridView.OptionsView.NewItemRowPosition = Position;
        }

        public static void AddSummary(this GridView gridView, params string[] columnNames)
        {
            gridView.BeginDataUpdate();
            List<string> scanColumns = new List<string>() { "Scan", "Photo", "ScanA", "ScA" };
            List<string> invalidColumns = new List<string>();

            gridView.OptionsView.ShowFooter = true;
            if (gridView.VisibleColumns.Count > 0)
            {
                GridColumn col = gridView.VisibleColumns[0];
                if (scanColumns.Contains(col.FieldName))
                    col = gridView.VisibleColumns[1];

                col.SummaryItem.SummaryType = SummaryItemType.Count;
                col.SummaryItem.DisplayFormat = "{0:#,##0} Kayıt";
            }

            foreach (string colName in columnNames)
            {
                string columnName = colName.Replace("Id", "Referans No");
                GridColumn col = gridView.Columns[colName];

                if (col != null)
                {
                    GridColumn gc = gridView.Columns[colName];

                    gc.SummaryItem.FieldName = colName;
                    gc.SummaryItem.SummaryType = SummaryItemType.Sum;
                    gc.SummaryItem.DisplayFormat = "{0:#,##0.#}";
                }
                else
                    invalidColumns.Add(colName);
            }

            //invalidColumns.CheckInvalidColumns();
            gridView.EndDataUpdate();

        }

        public static void AddSummaryKilo(this GridView gridView, params string[] columnNames)
        {
            gridView.BeginDataUpdate();
            List<string> scanColumns = new List<string>() { "Scan", "Photo", "ScanA", "ScA" };
            List<string> invalidColumns = new List<string>();

            gridView.OptionsView.ShowFooter = true;
            if (gridView.VisibleColumns.Count > 0)
            {
                GridColumn col = gridView.VisibleColumns[0];
                if (scanColumns.Contains(col.FieldName))
                    col = gridView.VisibleColumns[1];

                col.SummaryItem.SummaryType = SummaryItemType.Count;
                col.SummaryItem.DisplayFormat = "{0:#,##0} Kayıt";
            }

            foreach (string colName in columnNames)
            {
                string columnName = colName.Replace("Id", "Referans No");
                GridColumn col = gridView.Columns[colName];

                if (col != null)
                {
                    GridColumn gc = gridView.Columns[colName];

                    gc.SummaryItem.FieldName = colName;
                    gc.SummaryItem.SummaryType = SummaryItemType.Sum;
                    gc.SummaryItem.DisplayFormat = "{0:N6}";
                }
                else
                    invalidColumns.Add(colName);
            }

            //invalidColumns.CheckInvalidColumns();
            gridView.EndDataUpdate();

        }
        public static void FormatAsNumber(this GridView gridView, int decimalPoints, params string[] columnNames)
        {
            gridView.BeginDataUpdate();
            List<string> invalidColumns = new List<string>();

            foreach (string colName in columnNames)
            {
                GridColumn col = gridView.Columns[colName];

                if (col != null)
                {
                    col.DisplayFormat.FormatType = FormatType.Numeric;
                    string format = "#,##0.";
                    for (int i = 0; i < decimalPoints; i++)
                        format += "0";

                    if (format.EndsWith("."))
                        format = format.Substring(0, format.Length - 1);
                    col.DisplayFormat.FormatString = format + ";-" + format + "; ";

                    col.FilterMode = ColumnFilterMode.Value;
                    col.ColumnEdit = MaskedNumeric(decimalPoints != 1 ? decimalPoints : 2);
                }
                else
                    invalidColumns.Add(colName);
            }
            RepositoryItemTextEdit MaskedNumeric(int digits = 0)
            {
                RepositoryItemTextEdit ri = new RepositoryItemTextEdit();
                ri.AutoHeight = false;
                ri.Mask.EditMask = "f" + digits.ToString();
                ri.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                //ri.Mask.UseMaskAsDisplayFormat = true;            
                return ri;
            }

            //invalidColumns.CheckInvalidColumns();
            gridView.EndDataUpdate();
        }

        public static void EndEditing(this GridView gridView)
        {
            gridView.CloseEditor();
            gridView.UpdateCurrentRow();
        }
        
        #endregion
        #region YanYanaGetir
        public static void YanYanaGetir(this GridView gridView, params string[] pairs)
        {
            List<string> invalidColumns = new List<string>();

            foreach (string pair in pairs)
            {
                string[] vals = pair.Split(':');
                string colName1 = vals[0].Trim().Replace("Id", "Id");
                string colName2 = vals[1].Trim();

                GridColumn col1 = gridView.Columns[colName1];
                GridColumn col2 = gridView.Columns[colName2];

                if (col1 == null)
                    invalidColumns.Add(colName1);
                else if (col2 == null)
                    invalidColumns.Add(colName2);
                else
                    col1.VisibleIndex = col2.VisibleIndex;
            }

            //invalidColumns.CheckInvalidColumns();
        }

        private static void YanYanaGetirYonlu(this GridView gridView, string BaseColumn, bool Soluna, params string[] columnNames)
        {
            List<string> invalidColumns = new List<string>();

            bool isBanded = gridView.GetType() == typeof(BandedGridView);
            GridColumn colBase = gridView.Columns[BaseColumn];
            if (colBase == null)
                invalidColumns.Add(BaseColumn);
            else
            {
                int i = 0;

                if (Soluna)
                {
                    if (isBanded)
                        i = (colBase as BandedGridColumn).ColVIndex - 1;
                    else
                        i = colBase.VisibleIndex;
                }
                else
                {
                    Array.Reverse(columnNames);

                    if (isBanded)
                        i = (colBase as BandedGridColumn).ColVIndex + 1;
                    else
                        i = colBase.VisibleIndex + 1;
                }

                foreach (string colName in columnNames)
                {
                    GridColumn col = gridView.Columns[colName.Replace("Id", "Id")];

                    if (col != null)
                        col.VisibleIndex = i;
                    else
                        invalidColumns.Add(colName);
                }
            }

            //invalidColumns.CheckInvalidColumns();
        }

        public static void YanYanaGetirSoluna(this GridView gridView, string BaseColumn, params string[] columnNames)
        {
            gridView.YanYanaGetirYonlu(BaseColumn, true, columnNames);
        }

        public static void YanYanaGetirSagina(this GridView gridView, string BaseColumn, params string[] columnNames)
        {
            gridView.YanYanaGetirYonlu(BaseColumn, false, columnNames);
        }
        #endregion

        #region AddColumn

        private static void AddColumn(this GridView gridView, string name, string expression = null)
        {
            GridColumn col = new GridColumn();
            if (gridView is BandedGridView)
                col = new BandedGridColumn();

            col.FieldName = col.Caption = col.Name = name;
            if (expression != null)
            {
                col.UnboundType = UnboundColumnType.Bound;
                col.UnboundExpression = expression;
            }
            col.Visible = true;
            gridView.Columns.Add(col);
        }

        
        #endregion
    }
}
