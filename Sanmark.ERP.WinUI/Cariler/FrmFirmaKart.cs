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
using Sanmark.Erp.Entities.Concrete.Cari;
using Sanmark.Erp.Entities.Concrete;
using DevExpress.XtraEditors.Repository;
using Sanmark.Core.Utilities.Tipler;
using FluentValidation;

namespace Sanmark.ERP.WinUI.Cariler
{
    public partial class FrmFirmaKart : XPopupForm
    {
        private Firma _firmaKarti;
        private bool _isUpdate=false;
        private Sirket sirket;

        public FrmFirmaKart()
        {
            InitializeComponent();
            _firmaKarti = new Firma();
            //_firmaKarti.KayitTarihi =
            //    _firmaKarti.DegistirmeTarihi = DateTime.Now;
            //_firmaKarti.KayitUserId =
            //_firmaKarti.DegistirmeUserId = AppSession.CurrentUser.Id;
            sirket = AppSession.Sirket;
            gleFirmaTipi.EditValue = 0;
            gleKartTipi.EditValue = 0;
            //_firmaKarti.SirketId = sirket.Id;
        }
        public FrmFirmaKart (int FirmaId): this()
        {
            _firmaKarti = DataSession.FirmaService.GetById(FirmaId);
            txtAd.Text = _firmaKarti.Ad;
            txtKod.Text = _firmaKarti.Kod;
            txtSoyad.Text = _firmaKarti.Soyad;
            txtVergiDairesi.Text = _firmaKarti.VergiDairesi;
            txtVergiNo.Text = _firmaKarti.VergiNo;
            gleFirmaTipi.EditValue = _firmaKarti.FirmaTip;
            gleKartTipi.EditValue = _firmaKarti.FirmaKartTip;
            _isUpdate = true;
        }

        private void FrmFirmaKart_Load(object sender, EventArgs e)
        {
            RepositoryItemGridLookUpEdit gleFirmaTipleri = GetGLEEnum((List<EnumListesi>)typeof(FirmaTipi).ToList2(), "Ad");
            gleFirmaTipi.Properties.Assign(gleFirmaTipleri);
            
            RepositoryItemGridLookUpEdit gleKartTipleri = GetGLEEnum((List<EnumListesi>)typeof(FirmaKartTipi).ToList2(), "Ad");
            gleKartTipi.Properties.Assign(gleKartTipleri);
            
        }

        private void BbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _firmaKarti.SirketId = sirket.Id;
            _firmaKarti.Ad = txtAd.Text.Trim();
            _firmaKarti.Soyad = txtSoyad.Text.Trim();
            _firmaKarti.Kod = txtKod.Text.Trim();
            _firmaKarti.VergiDairesi = txtVergiDairesi.Text.Trim();
            _firmaKarti.VergiNo = txtVergiNo.Text.Trim();
            _firmaKarti.FirmaKartTip = Convert.ToInt16(gleKartTipi.EditValue);
            _firmaKarti.FirmaTip = Convert.ToInt16(gleFirmaTipi.EditValue);
            try
            {
                if (_isUpdate)
                {
                    _firmaKarti.DegistirmeTarihi = DateTime.Now;
                    _firmaKarti.DegistirmeUserId = AppSession.CurrentUser.Id;
                    DataSession.FirmaService.Update(_firmaKarti);
                }
                else
                {
                    _firmaKarti.DegistirmeTarihi = DateTime.Now;
                    _firmaKarti.DegistirmeUserId = AppSession.CurrentUser.Id;
                    _firmaKarti.KayitTarihi = DateTime.Now;
                    _firmaKarti.KayitUserId = AppSession.CurrentUser.Id;
                    DataSession.FirmaService.Add(_firmaKarti);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (ValidationException ex)
            {
                XtraMessageBox.Show("Firma Nesne Hatası.\r\n\r\n Hata: " + ex.Message.Replace("Validation failed: \r\n", ""), "Validasyon Hatası");
            }
        }
    }
}