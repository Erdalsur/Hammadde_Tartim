using IniParser;
using IniParser.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sanmark.Core.Utilities.Win.Infrastructure
{
    public static class SettingsTool
    {
        static FileIniDataParser parser = new FileIniDataParser();
        static IniData data;
        static string dosyaAdi = "Ayarlar.ini";
        static SettingsTool()
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\" + dosyaAdi) == true)
            {
                data = parser.ReadFile(dosyaAdi);
            }
            else
            {
                using (System.IO.File.Create(Application.StartupPath + "\\" + dosyaAdi))
                {
                };
                data = parser.ReadFile(dosyaAdi);
            }
        }
        public enum Ayarlar
        {
            HTarti_Port,
            HTarti_Parity,
            HTarti_DataBits,
            HTarti_StopBits,
            HTarti_BaudRate,
            HTarti_Birimi,
            BarkodYazici_Name,
            BarkodYazici_OtomatikBasim,
            Birimler_Kilogram,
            Birimler_Gram,
            Birimler_Ton,
            DataSetting_Host,
            DataSetting_DataBase,
            DataSetting_User,
            DataSetting_Password,
            Depo_VarsayilanDepo,
            Genel_LogoYolu

        }
        public static void AyarDegistir(Ayarlar ayarlar, string value)
        {
            string[] gelenAyar = ayarlar.ToString().Split(Convert.ToChar("_"));
            if (data != null)
            {
                if (data.Sections.Count(c => c.SectionName == gelenAyar[0]) == 0)
                {
                    data.Sections.AddSection(gelenAyar[0]);
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);
                }
                else
                {
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);
                }
                data[gelenAyar[0]][gelenAyar[1]] = value;
            }
        }

        public static string AyarOku(Ayarlar ayarlar)
        {
            string[] gelenAyar = ayarlar.ToString().Split(Convert.ToChar("_"));
            return data[gelenAyar[0]][gelenAyar[1]];
        }
        public static void Save()
        {
            parser.WriteFile(dosyaAdi, data);
        }

        public static void AyarDegistir(object depo_Varsayilan, string v)
        {
            throw new NotImplementedException();
        }
    }
}
