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
using Sanmark.ERP.WinUI.BaseForms;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;
using FluentValidation.Results;
using FluentValidation;

namespace Sanmark.ERP.WinUI.Sirketler
{
    public partial class FrmSirket : XPopupForm
    {
        Sirket _sirket=new Sirket();
        int _gelenSirketId;
        private bool IsUpdate = false;
        public FrmSirket()
        {
            InitializeComponent();
        }

        public FrmSirket(int SirketId) : this()
        {
            _gelenSirketId = SirketId;
        }
        private void FrmSirket_Load(object sender, EventArgs e)
        {
            txtEmail.Properties.AppearanceFocused.BackColor =
            txtAd.Properties.AppearanceFocused.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            txtEmail.Properties.AppearanceFocused.Options.UseBackColor =
            txtAd.Properties.AppearanceFocused.Options.UseBackColor = true;
            Text = "Yeni Şirket";
            if (_gelenSirketId != 0)
            {
                _sirket = DataSession.SirketService.GetById(_gelenSirketId);
                Text = "Şirket :" + _sirket.Ad;
                txtAd.Text = _sirket.Ad;
                txtEmail.Text = _sirket.Email;
                txtKod.Text = _sirket.Kod;
                IsUpdate = true;
            }
            
        }

        private void BbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _sirket.Ad = txtAd.Text;
            _sirket.Email = txtEmail.Text;
            _sirket.Kod = txtKod.Text;
            try
            {
                if (!IsUpdate)
                {
                    DataSession.SirketService.Add(_sirket);
                }
                else
                {
                    DataSession.SirketService.Update(_sirket);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (ValidationException ex)
            {
                XtraMessageBox.Show("Şirket Nesne Hatası.\r\n\r\n Hata: " + ex.Message.Replace("Validation failed: \r\n", ""), "Validasyon Hatası");
            }
        }
    }
}