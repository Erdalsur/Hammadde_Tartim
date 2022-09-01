using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.BaseForms
{
    public partial class XPopupForm : XForm
    {
        private bool escCloses = true;
        public XPopupForm()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += new KeyEventHandler(XPopupForm_KeyDown);
        }
        

        public bool ESCCloses
        {
            get => escCloses;
            set => escCloses = value;
        }
        private void XPopupForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!ESCCloses || e.KeyCode != Keys.Escape)
                return;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
