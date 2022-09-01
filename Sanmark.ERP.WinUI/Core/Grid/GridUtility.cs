using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.Core.Grid
{
    public class GridManager
    {
        private GridView gridView;
        public GridUtility Utility;
        public static Dictionary<int, GridManager> GridManagers = new Dictionary<int, GridManager>();

        private GridManager(GridView gridView)
        {
            GridView = gridView;
            Utility = new GridUtility(gridView);
            Grid.KeyPress += new KeyPressEventHandler(Grid_KeyPress);
            GridView.RowStyle += GridView_RowStyle;
        }
        public GridControl Grid
        {
            get { return gridView.GridControl; }

        }
        static void gridView_Disposed(object sender, EventArgs e)
        {
            int hash = (sender as GridView).GetHashCode();
            GridManagers.Remove(hash);
        }
        public static GridManager GetManager(GridView gridView, bool disableRowDelete = false, bool sadeceDoluOlanlariGoster = false)
        {
            GridManager gridManager = null;

            bool exists = GridManagers.TryGetValue(gridView.GetHashCode(), out gridManager);

            if (!exists)
            {
                GridManager gm = new GridManager(gridView);
                GridManager.GridManagers.Add(gridView.GetHashCode(), gm);
                GridManagers.TryGetValue(gridView.GetHashCode(), out gridManager);
                gridView.Disposed += gridView_Disposed;

            }

            return gridManager;
        }

        public GridView GridView
        {
            get { return gridView; }
            set { gridView = value; }
        }
        private bool rowSelectionEnabled = false;
        public bool RowSelectionEnabled
        {
            get
            {
                return rowSelectionEnabled;
            }
            set
            {
                rowSelectionEnabled = value;
                //GridMenu.CreateRowMenu();
            }
        }

        void Grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 22 || e.KeyChar == 7)  //char(22) is Synchronous Idle, but is better known as "Ctrl+V" or "Paste"
                e.Handled = true;
        }
        void GridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle == GridControl.AutoFilterRowHandle)
                e.Appearance.BackColor = Color.LightGoldenrodYellow;
        }
    }
    public class GridUtility
    {
        #region Memebers
        private GridView gridView;
        public GridView GridView
        {
            get
            {
                return this.gridView;
            }
            set
            {
                this.gridView = value;
            }
        }
        #endregion
        #region Constructors
        public GridUtility(GridView view)
        {
            this.gridView = view;
        }

        public GridUtility(GridManager gridManager)
        {
            this.gridView = gridManager.GridView;
        }

        #endregion

        public void CopyWithHeaders()
        {
            //bool val = GridView.OptionsBehavior.CopyToClipboardWithColumnHeaders;
            //GridView.OptionsBehavior.CopyToClipboardWithColumnHeaders = true;
            //GridView.CopyToClipboard();
            //GridView.OptionsBehavior.CopyToClipboardWithColumnHeaders = val;

            DevExpress.Utils.DefaultBoolean val = GridView.OptionsClipboard.CopyColumnHeaders;
            GridView.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
            GridView.CopyToClipboard();
            GridView.OptionsClipboard.CopyColumnHeaders = val;
        }
        public void SelectAll()
        {
            GridView.SelectAll();
        }
        public static bool IsReadOnly(GridColumn col)
        {
            return col.View.OptionsBehavior.ReadOnly || !col.OptionsColumn.AllowEdit;
        }

        public static bool IsReadOnly(GridView GridView)
        {
            return GridView.OptionsBehavior.ReadOnly;
        }
    }
}
