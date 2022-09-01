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
using Sanmark.Erp.Entities.Concrete.Stok;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;
using FluentValidation.Results;
using DevExpress.XtraEditors.Repository;
using Sanmark.Core.Utilities.Tipler;
using FluentValidation;
using Sanmark.Erp.Entities;

namespace Sanmark.ERP.WinUI.Stoklar
{
    public partial class FrmStokKart :XPopupForm
    {
        StokKarti _stokKarti;
        Sirket sirket;
        private bool _isUpdate=false;
        CodeTool codeTool;

        public FrmStokKart()
        {
            InitializeComponent();
            _stokKarti = new StokKarti();
            sirket = AppSession.Sirket;
            this.gleTur.EditValue = StokTipi.None;
            codeTool = new CodeTool(this, CodeTool.Table.Stok, DataSession.KodService);
            codeTool.BarButtonOlustur();
        }
        public FrmStokKart(int StokKartId) : this()
        {
            _stokKarti = DataSession.StokKartService.GetById(StokKartId);
            txtAd.Text = _stokKarti.Ad;
            txtBarkod.Text = _stokKarti.Barkod;
            txtKod.Text = _stokKarti.Kod;
            gleGrup.EditValue = _stokKarti.StokGrupId;
            gleBirim.EditValue = _stokKarti.StokBirimId;
            gleAmbalaj.EditValue = _stokKarti.AmbalajId;
            gleTur.EditValue = _stokKarti.Tip;
            gleBirim2.EditValue = _stokKarti.Birim2Id;
            gleBirim3.EditValue = _stokKarti.Birim3Id;
            txtBirim2Pay.Text = _stokKarti.Birim2Pay.ToString();
            txtBirim2Payda.Text = _stokKarti.Birim2Payda.ToString();
            txtBirim3Pay.Text = _stokKarti.Birim3Pay.ToString();
            txtBirim3Payda.Text = _stokKarti.Birim3Payda.ToString();
            _isUpdate = true;
        }

        private void FrmStokKart_Load(object sender, EventArgs e)
        {
            RepositoryItemGridLookUpEdit gleAmbalajlar = GetCustomGLE(DataSession.AmbalajService.GetAll(s=>s.SirketId==AppSession.Sirket.Id), "Ad", "Id");
            gleAmbalajlar.View.OptionsView.ColumnAutoWidth = true;
            gleAmbalaj.Properties.Assign(gleAmbalajlar);
            gleAmbalaj.Properties.View.Columns["SirketId"].Visible = false;
            gleAmbalaj.Properties.View.BestFitColumns();
            RepositoryItemGridLookUpEdit gleStokTur = GetGLEEnum((List<EnumListesi>)typeof(StokTipi).ToList2(), "Ad");            
            gleTur.Properties.Assign(gleStokTur);

            RepositoryItemGridLookUpEdit gleBirimler= GetCustomGLE(DataSession.StokBirimService.GetAll(s => s.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleBirimler.View.OptionsView.ColumnAutoWidth = true;
            gleBirim.Properties.Assign(gleBirimler);
            gleBirim.Properties.View.Columns["KayitTarihi"].Visible =
                gleBirim.Properties.View.Columns["KayitUserId"].Visible =
                gleBirim.Properties.View.Columns["DegistirmeTarihi"].Visible =
                gleBirim.Properties.View.Columns["DegistirmeUserId"].Visible =
            gleBirim.Properties.View.Columns["SirketId"].Visible = false;
            gleBirim.Properties.View.BestFitColumns();

            gleBirim2.Properties.Assign(gleBirimler);
            gleBirim2.Properties.View.Columns["KayitTarihi"].Visible =
                gleBirim2.Properties.View.Columns["KayitUserId"].Visible =
                gleBirim2.Properties.View.Columns["DegistirmeTarihi"].Visible =
                gleBirim2.Properties.View.Columns["DegistirmeUserId"].Visible =
            gleBirim2.Properties.View.Columns["SirketId"].Visible = false;
            gleBirim2.Properties.View.BestFitColumns();

            gleBirim3.Properties.Assign(gleBirimler);
            gleBirim3.Properties.View.Columns["KayitTarihi"].Visible =
                gleBirim3.Properties.View.Columns["KayitUserId"].Visible =
                gleBirim3.Properties.View.Columns["DegistirmeTarihi"].Visible =
                gleBirim3.Properties.View.Columns["DegistirmeUserId"].Visible =
            gleBirim3.Properties.View.Columns["SirketId"].Visible = false;
            gleBirim3.Properties.View.BestFitColumns();


            RepositoryItemGridLookUpEdit gleGruplar = GetCustomGLE(DataSession.StokGrupService.GetAll(g => g.SirketId == AppSession.Sirket.Id), "Ad", "Id");
            gleGruplar.View.OptionsView.ColumnAutoWidth = true;
            gleGrup.Properties.Assign(gleGruplar);
            gleGrup.Properties.View.Columns["ParentId"].Visible =
            gleGrup.Properties.View.Columns["SirketId"].Visible = false;
            gleGrup.Properties.View.BestFitColumns();
        }
        

        private void BbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _stokKarti.Ad = txtAd.Text.Trim();
            _stokKarti.Kod = txtKod.Text.Trim();
            _stokKarti.SirketId = AppSession.Sirket.Id;
            _stokKarti.StokGrupId = intParse(gleGrup.EditValue);
            _stokKarti.StokBirimId = intParse(gleBirim.EditValue);
            _stokKarti.Tip =Convert.ToInt16(gleTur.EditValue);
            _stokKarti.Barkod = txtBarkod.Text.Trim();
            _stokKarti.AmbalajId = intParse(gleAmbalaj.EditValue);
            _stokKarti.Birim2Id= intParse(gleBirim2.EditValue);
            _stokKarti.Birim2Pay = Convert.ToDecimal(txtBirim2Pay.Text);
            _stokKarti.Birim2Payda = Convert.ToDecimal(txtBirim2Payda.Text);
            _stokKarti.Birim3Id = intParse(gleBirim3.EditValue);
            _stokKarti.Birim3Pay = Convert.ToDecimal(txtBirim3Pay.Text);
            _stokKarti.Birim3Payda = Convert.ToDecimal(txtBirim3Payda.Text);
            try
            {
                if (_isUpdate)
                {
                    DataSession.StokKartService.Update(_stokKarti);
                }
                else
                {
                    DataSession.StokKartService.Add(_stokKarti);
                }
                codeTool.KodArttirma();
                this.DialogResult = DialogResult.OK;
            }
            catch (ValidationException ex)
            {
                XtraMessageBox.Show("Stok Nesne Hatası.\r\n\r\n Hata: " + ex.Message.Replace("Validation failed: \r\n", ""), "Validasyon Hatası");
            }
        }

        private void FrmStokKart_Shown(object sender, EventArgs e)
        {
            //this.gleTur.Properties.View.Columns["Key"].Visible = false;            
            //this.gleTur.Properties.View.BestFitColumns();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}