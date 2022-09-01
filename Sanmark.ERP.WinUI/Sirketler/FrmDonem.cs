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
using FluentValidation.Results;
using Sanmark.Erp.Framework.ValidationRules.FluentValidation;
using FluentValidation;

namespace Sanmark.ERP.WinUI.Sirketler
{
    public partial class FrmDonem : XPopupForm
    {
        Sirket sirket;
        Donem donem;
        private bool _yeni=true;
        private int _gelenDonemId;

        public FrmDonem()
        {
            InitializeComponent();
        }

        public FrmDonem(int donemId):this()
        {
            _gelenDonemId = donemId;
            sirket = AppSession.Sirket;
            
        }


        private void FrmDonem_Load(object sender, EventArgs e)
        {
            donem = new Donem();
            sirket = AppSession.Sirket;
            txtSirket.Text = sirket.Ad;
            txtYil.Text = DateTime.Now.Year.ToString();
            dateBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1);
            dateBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31);
            if (_gelenDonemId!=0)
            {
                donem = DataSession.DonemService.GetById(_gelenDonemId);
                sirket = DataSession.SirketService.GetById(donem.SirketId);
                Text = sirket.Ad +"-"+ donem.Yil.ToString()+" Dönemi";
                txtSirket.Text = sirket.Ad;
                txtYil.Text = donem.Yil.ToString();
                dateBaslangic.DateTime = donem.Baslangic;
                dateBitis.DateTime = donem.Bitis;
                _yeni = false;
            }
        }

        private void TxtSirket_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmSirketBul sirketBul = new FrmSirketBul();
            sirketBul.ShowDialog();
            if (sirketBul.DialogResult==DialogResult.OK)
            {
                sirket = sirketBul.sirket;
                txtSirket.Text = sirket.Ad;
            }
        }

        private void BbiKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            donem.Baslangic = Convert.ToDateTime(dateBaslangic.DateTime.Date);
            donem.Bitis = dateBitis.DateTime.Date;
            donem.Yil = Convert.ToInt16(txtYil.Text);
            donem.SirketId = sirket.Id;
            try
            {
                if (_yeni)
                {
                    DataSession.DonemService.Add(donem);
                }
                else
                {
                    DataSession.DonemService.Update(donem);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch(ValidationException ex)
            {
                XtraMessageBox.Show("Dönem Nesne Hatası.\r\n\r\n Hata: " + ex.Message.Replace("Validation failed: \r\n", ""), "Validasyon Hatası");
            }
        }

        private void PanelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}