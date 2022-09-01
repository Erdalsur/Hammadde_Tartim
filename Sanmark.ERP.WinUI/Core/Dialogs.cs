using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.Core
{
    public class Dialogs
    {
        public static string SaveFile(string title, string filter, params string[] FN)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                string name = FN.Length > 0 ? FN[0] : Application.ProductName;
                int n = name.LastIndexOf(".") + 1;
                if (n > 0) name = name.Substring(n, name.Length - n);
                dlg.Title = "Gönder " + title;
                dlg.FileName = name;
                dlg.Filter = filter;
                if (dlg.ShowDialog() == DialogResult.OK)
                    return dlg.FileName;
                return "";
            }
        }

        public static DialogResult EminMisiniz()
        {
            return XtraMessageBox.Show("Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
    }
}
