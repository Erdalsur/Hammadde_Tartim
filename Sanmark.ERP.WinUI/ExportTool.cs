using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI
{
    public class ExportTool
    {
        private XtraForm _form;
        private BarButtonItem _button;
        private BarSubItem subItem;
        private GridView _grid;

        BarManager manager = new BarManager();
        private PopupMenu menu;
        public ExportTool(XtraForm form, GridView gridView, BarButtonItem dropDownButton)
        {
            _form = form;
            _button = dropDownButton;            
            _grid = gridView;
            menu = new PopupMenu(manager);
            //_button.MenuManager = manager;
            _button.ButtonStyle=BarButtonStyle.DropDown;
            _button.DropDownControl = menu;
            //PDF
            BarButtonItem pdfExport = new BarButtonItem
            {
                Name = "pdf",
                Caption = "PDF Dosyası",
                ImageOptions = {Image=Properties.Resources.Pdf_24x24}

            };
            menu.AddItem(pdfExport);
            pdfExport.ItemClick += Export;
            //XLSX
            BarButtonItem xlsx = new BarButtonItem
            {
                Name = "xlsx",
                Caption = "Excell Dosyası",
                ImageOptions = { Image = Properties.Resources.excel_24x24 }

            };
            xlsx.ItemClick += Export;
            menu.AddItem(xlsx);
            
        }

        private void Export(object sender, ItemClickEventArgs e)
        {
            //BarButtonItem button = (BarButtonItem)sender;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = $"{e.Item.Caption}|*.{e.Item.Name}";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                switch(e.Item.Name)
                {
                    case "pdf":
                        _grid.OptionsPrint.PrintDetails=
                        _grid.OptionsPrint.ExpandAllDetails = true;
                        _grid.ExportToPdf(dialog.FileName);
                        break;
                    case "xlsx":
                        DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;
                        _grid.OptionsPrint.PrintDetails =
                        _grid.OptionsPrint.ExpandAllDetails = true;
                        _grid.ZoomView();
                        _grid.ExportToXlsx(dialog.FileName);
                        break;
                }
            }
        }
    }
}
