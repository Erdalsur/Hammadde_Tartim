using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Core.Utilities.Tipler;
using DevExpress.Data;
using System.Globalization;

namespace Sanmark.ERP.WinUI.BaseForms
{
    public partial class XForm : XtraForm
    {
        public bool isPopup = false;
        public string Hash { get; set; }
        public XForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }
        public static int WhoAmI { get { return AppSession.WhoAmI; } }

        public void InitGridView(GridView gridview)
        {

            try
            {
                gridview.SelectionChanged -= gridview_SelectionChanged;
                gridview.SelectionChanged += gridview_SelectionChanged;
                //gridview.OptionsView.EnableAppearanceOddRow = AppSession.Settings.EnableAppearanceEvenRow;
                gridview.OptionsSelection.MultiSelect = false;
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridview.Columns)
                {
                    col.Visible = true;
                    if (col.FieldName == "Id" || col.FieldName == "SirketId")
                    {
                        col.OptionsColumn.AllowEdit = false;
                        col.AppearanceCell.BackColor = System.Drawing.Color.LightYellow;
                    }
                    //col.OptionsColumn.AllowEdit = col.FieldName != "KayitUserId";    //userId sonradan değiştirilemesin diye!
                    if (col.FieldName == "KayitUserId" || col.FieldName == "DegistirmeUserId"|| col.FieldName == "DegistirmeTarihi"|| col.FieldName == "KayitTarihi")
                    {
                        col.OptionsColumn.AllowEdit = false;
                        
                    }
                }
                //gridview.BestFitMaxRowCount = 50;
                gridview.GridControl.ShowOnlyPredefinedDetails = true;
                gridview.HorzScrollStep = 50;
                gridview.NewItemRowText = "Yeni kayıt girmek için tıklayınız.";
                gridview.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
                //gridview.OptionsBehavior.EditorShowMode = Session.Settings.EditorShowMode;  //checkbox hemen seçilebilsin diye
                gridview.OptionsBehavior.ImmediateUpdateRowPosition = false;
                gridview.OptionsBehavior.KeepFocusedRowOnUpdate = true;
                gridview.OptionsFilter.AllowColumnMRUFilterList = true;
                gridview.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;
                gridview.OptionsFilter.ShowAllTableValuesInFilterPopup = false;
                gridview.OptionsFind.HighlightFindResults = true;
                gridview.OptionsHint.ShowColumnHeaderHints = true;
                gridview.OptionsMenu.EnableColumnMenu = true;
                gridview.OptionsMenu.ShowDateTimeGroupIntervalItems = true;
                gridview.OptionsNavigation.UseOfficePageNavigation = true;
                //gridview.OptionsSelection.MultiSelect = true;
                //gridview.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
                gridview.OptionsView.ColumnAutoWidth = false;
                gridview.OptionsView.EnableAppearanceOddRow = true;
                gridview.OptionsView.RowAutoHeight = true;
                gridview.OptionsView.ShowAutoFilterRow = true;
                gridview.OptionsView.ShowDetailButtons = false;
                gridview.OptionsView.ShowGroupPanel = false;
                gridview.ViewCaption = gridview.ViewCaption.Replace("gv", string.Empty);
                gridview.OptionsMenu.ShowConditionalFormattingItem = true;
                gridview.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;

            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
            finally
            {
                //gridview.EndUpdate();
            }
        }
        string adet = "Adet: ";
        string toplam = "Toplam: ";
        private void gridview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridView g = sender as GridView;
            DevExpress.XtraGrid.Views.Base.GridCell[] cells = g.GetSelectedCells();
            if (cells.Length == 0)
                return;

            double sum = 0;

            foreach (DevExpress.XtraGrid.Views.Base.GridCell gc in cells)
            {
                double val = 0.0;
                string cellVal = g.GetRowCellDisplayText(gc.RowHandle, gc.Column);
                CultureInfo ci = Application.CurrentCulture;
                double.TryParse(cellVal, NumberStyles.Any, ci, out val);

                sum += val;
            }

            adet = string.Format("{0}{1:n0}", "Adet: ", cells.Length);

            if (sum > 0)
                toplam = string.Format("{0}{1:n1}", "Toplam: ", sum);
            else
                toplam = "";

            //AppSession.MainForm.NotifySelectionInfo(this);
        }

        #region Parse Functions
        public decimal decimalParse(BindingSource bs, string ColumnName)
        {
            decimal tmp = 0;
            if (bs.Current != null)
                decimal.TryParse(((DataRowView)bs.Current).Row[ColumnName].ToString(), out tmp);
            return tmp;
        }

        public int intParse(BindingSource bs, string ColumnName)
        {
            int tmp = 0;
            if (bs != null)
                if (bs.Current != null)
                    int.TryParse(((DataRowView)bs.Current).Row[ColumnName].ToString(), out tmp);
            return tmp;
        }

        public string strParse(BindingSource bs, string ColumnName)
        {
            string tmp = string.Empty;
            if (bs != null)
                if (bs.Current != null)
                    tmp = ((DataRowView)bs.Current).Row[ColumnName].ToString();
            return tmp;
        }

        public bool boolParse(object str)
        {
            if (str == null)
                return false;
            else
            {
                bool tmp = false;
                bool.TryParse(str.ToString(), out tmp);
                return tmp;
            }
        }

        public int intParse(object str)
        {
            if (str == null)
                return 0;
            else
            {
                int tmp = 0;
                int.TryParse(str.ToString(), out tmp);
                return tmp;
            }
        }

        public string strParse(object str)
        {
            if (str == null)
                return string.Empty;
            else
                return str.ToString();
        }

        public decimal decimalParse(object str)
        {
            if (str == null)
                return 0;
            else
            {
                decimal tmp = 0;
                decimal.TryParse(str.ToString(), out tmp);
                return tmp;
            }
        }

        public DateTime datetimeParse(object str)
        {
            DateTime tmp = new DateTime(2000, 1, 1);  //DateTime.MinValue;
            if (str != null)
                if (str != DBNull.Value)
                    DateTime.TryParse(str.ToString(), out tmp);

            return tmp;
        }

        #endregion

        #region GridLookup
        static void gleSablon_Popup(object sender, EventArgs e)
        {
            GridLookUpEdit gle = (GridLookUpEdit)sender;
            RepositoryItemGridLookUpEdit ri = gle.Properties;
            //ri.View.CustomRowFilter -= View_CustomRowFilter;
            //ri.View.CustomRowFilter += View_CustomRowFilter;
        }
        //static void View_CustomRowFilter(object sender, RowFilterEventArgs e)
        //{
        //    //e.Visible = true;
        //    //return;
        //    GridView gv = sender as GridView;
        //    if (gv.Columns["Deleted"] != null && gv.GetDataRow(e.ListSourceRow)["Deleted"].ToBool())
        //    {
        //        e.Visible = false;
        //        e.Handled = true;
        //    }
        //    else
        //    {
        //        e.Visible = true;
        //        e.Handled = false;
        //    }
        //}
        //public static bool ToBool(this object value)
        //{
        //    bool result = false;

        //    if (value != null)
        //        if (value != DBNull.Value)
        //            if (value.ToString() != "")
        //                try
        //                {
        //                    result = Convert.ToBoolean(value);
        //                }
        //                catch
        //                {
        //                }
        //    return result;
        //}
        public static RepositoryItemGridLookUpEdit GetGLESablon<T>(List<T> SourceListe, string DisplayMember, string ValueMember)
        {
            RepositoryItemGridLookUpEdit gleSablon = new RepositoryItemGridLookUpEdit();
            gleSablon.AllowNullInput = DefaultBoolean.True;
            gleSablon.View.OptionsView.ColumnAutoWidth = false;
            gleSablon.View.OptionsView.ShowAutoFilterRow = true;
            gleSablon.View.OptionsBehavior.Editable = false;
            gleSablon.View.BestFitMaxRowCount = 50;
            gleSablon.View.OptionsFind.HighlightFindResults = true;
            gleSablon.View.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            gleSablon.TextEditStyle = TextEditStyles.Standard; // DisableTextEditor;
            gleSablon.NullText = string.Empty;
            gleSablon.ImmediatePopup = true;

            gleSablon.PopupFormMinSize = new Size(500, 500);
            gleSablon.BestFitMode = BestFitMode.BestFit;

            gleSablon.Popup += gleSablon_Popup;
            gleSablon.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Default;
            gleSablon.DataSource = SourceListe;
            gleSablon.DisplayMember = DisplayMember;
            gleSablon.ValueMember = ValueMember;

            gleSablon.PopulateViewColumns();
            foreach (GridColumn gc in gleSablon.View.Columns)
            {
                gc.FilterMode = ColumnFilterMode.DisplayText;
                gc.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;// : AutoFilterCondition.Like;

            }
            return gleSablon;
        }
        
        public RepositoryItemGridLookUpEdit GetGLEEnum<T>(List<T> listeEnum, string baslik)
        {
            RepositoryItemGridLookUpEdit ri = GetGLESablon(listeEnum, "Value", "Key");
            ri.View.Columns["Key"].Visible = false;
            ri.View.Columns["Value"].Caption = baslik;
            return ri;
        }

        public RepositoryItemGridLookUpEdit GetCustomGLE<T>(List<T> liste, string displayMember, string valueMember)
        {
            RepositoryItemGridLookUpEdit ri = GetGLESablon(liste, displayMember, valueMember);

            // ri.View.Columns.Clear();
            ri.View.Columns["Id"].Visible = false;
            try
            {
                ri.View.Columns["SirketId"].Visible = false;
                ri.View.Columns["KayitTarihi"].Visible = false;
                ri.View.Columns["DegistirmeTarihi"].Visible = false;
                ri.View.Columns["KayitUserId"].Visible = false;
                ri.View.Columns["DegistirmeUserId"].Visible = false;
            }
            catch { }
            return ri;
        }

        public LookUpEdit GetLookUpEdit<T>(List<T> liste, string displayMember, string valueMember)
        {
            LookUpEdit edit = new LookUpEdit();
            edit.Properties.DataSource = liste;
            edit.Properties.DisplayMember = displayMember;
            edit.Properties.ValueMember = valueMember;

            return edit;
        }

        #endregion

        private void XForm_Load(object sender, EventArgs e)
        {

        }
    }
}