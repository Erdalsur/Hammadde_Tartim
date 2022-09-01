using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Sanmark.Core.Utilities;
using Sanmark.Erp.Entities.Concrete;
using Sanmark.Erp.Framework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sanmark.Erp.Entities
{
    public class CodeTool
    {
        BarManager manager = new BarManager();
        private PopupMenu menu;
        private XtraForm _form;
        private IKodService _kodService;
        Table _table;
        public enum Table
        {
            Cari,
            Stok,
            Fis,
            IsEmri
        }
        public CodeTool(XtraForm form,Table table,IKodService kodService)
        {
            _form = form;
            _kodService = kodService;
            _table = table;
            manager.Form = _form;
            menu = new PopupMenu(manager);
        }

        public void BarButtonOlustur()
        {
            string tablo = _table.ToString();
            List<Kod> liste = _kodService.GetAll(c => c.Tablo == tablo && c.DonemId == UserSession.Donem.Id && c.SirketId == UserSession.Sirket.Id);

            foreach (var kod in liste )
            {
                BarButtonItem item = new BarButtonItem
                {
                    Name = "btnKod" + kod.SonDeger,
                    Tag = kod.Id,
                    ImageOptions = {Image=Sanmark.Erp.Framework.Properties.Resources.code_16x16},
                    Caption = KodOlustur(kod.OnEki, kod.SonDeger,kod.Uzunlugu)
                };
                item.ItemClick += Button_Click;
                menu.AddItem(item);
            }

            BarButtonItem yeniKodEkle = new BarButtonItem
            {
                Name = "btnYeniKodEkle",
                ImageOptions = { Image = Sanmark.Erp.Framework.Properties.Resources.note_add },
                Caption = "Yeni Kod Oluştur"
            };
            yeniKodEkle.ItemClick += YeniKodEkle_Click;
            menu.AddItem(yeniKodEkle).BeginGroup=true;
            BarButtonItem guncelleButton = new BarButtonItem
            {
                Name = "btnGuncelle",
                //ImageOptions = { Image = Sanmark.Erp.Framework.Properties.Resources.note_ok },
                Caption = "Güncelle"
            };
            guncelleButton.ItemClick += Guncelle_Click;
            menu.AddItem(guncelleButton);
            DropDownButton button = (DropDownButton)_form.Controls.Find("btnKod", true).SingleOrDefault();
            button.MenuManager = manager;
            button.DropDownControl = menu;
        }

        private void YeniKodEkle_Click(object sender, ItemClickEventArgs e)
        {
            Type tip = Assembly.Load("Sanmark.ERP.WinUI").GetTypes().SingleOrDefault(c => c.Name == "FrmKodlar");
            XtraForm form = (XtraForm)Activator.CreateInstance(tip, _table.ToString());
            form.ShowDialog();
            BarButtonSil();
            BarButtonOlustur();
        }

        private void Guncelle_Click(object sender, ItemClickEventArgs e)
        {
            BarButtonSil();
            BarButtonOlustur();
        }

        private void BarButtonSil()
        {
            menu.ItemLinks.Clear();
        }

        private void Button_Click(object sender, ItemClickEventArgs e)
        {
            TextEdit text =(TextEdit) _form.Controls.Find("txtKod",true).SingleOrDefault();
            text.Text = e.Item.Caption;
        }

        private string KodOlustur(string onEki, int sonDeger,int kodUzunlugu)
        {
            int sifirSayisi = kodUzunlugu - (onEki.Length + sonDeger.ToString().Length);
            string sifirDizisi = new string('0', sifirSayisi);
            return onEki + sifirDizisi + sonDeger;
        }
        public void KodArttirma()
        {
            TextEdit text = (TextEdit)_form.Controls.Find("txtKod", true).SingleOrDefault();
            BarItemLink button = menu.ItemLinks.SingleOrDefault(c => c.Caption == text.Text);
            if (button!=null)
            {
                int id = Convert.ToInt32(button.Item.Tag.ToString());
                var kod = _kodService.GetById(id);
                kod.SonDeger += 1;
                _kodService.Update(kod);
            }
        }
    }
    
}
