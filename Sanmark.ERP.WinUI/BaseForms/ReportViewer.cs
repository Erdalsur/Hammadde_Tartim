using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanmark.ERP.WinUI.BaseForms
{
    public partial class ReportViewer : XForm
    {
        public XtraReport Report;
        public ReportViewer(XtraReport report, string email, string caption)
        {
            InitializeComponent();
            this.Report = report;
            txtEmail.EditValue = email;
            this.Text = caption;

        }


        private void ReportViewer_Load(object sender, EventArgs e)
        {
            docViewer.DocumentSource = Report;
            Report.CreateDocument();

            //lblMail.Text = Language.ReportViewer.ClientMail;
            //btnSendEmail.Text = Language.ReportViewer.SendMail;

        }

        private void btnEpostaGonder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.UseWaitCursor = true;
            MailMessage email = new MailMessage();
            email.From = new MailAddress("info@sanmark.com.tr", "Sanmark İlaç Gıda");
            email.Subject = "Sanmark Tartım Raporu";
            email.Body = "Sanmark Tartım Raporu ekte ...";

            email.IsBodyHtml = true;
            email.To.Add(txtEmail.EditValue.ToString());
            string sipNo = this.Text.Replace("Tartim:", "");

            string FileName = "SanmarkTartımRaporu." + DateTime.Now.ToString("yyyyMMhhmmss")+"."+sipNo + ".pdf";
            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\" + FileName;
            Report.ExportToPdf(FilePath);
            Stream stream = new MemoryStream(File.ReadAllBytes(FilePath));
            email.Attachments.Add(new Attachment(stream, FileName));

            try
            {
                using (SmtpClient emailClient = new SmtpClient("webmail.sanmark.com.tr", 587))
                {
                    emailClient.Credentials = new NetworkCredential("info@sanmark.com.tr", "SemsaSanmark@2019");
                    emailClient.EnableSsl = false;
                    emailClient.Send(email);
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                this.UseWaitCursor = false;
                throw new ApplicationException("E-mail gönderilemedi. İnternetinizi kontrol edin." + ex.ToString() + "...");
            }

            XtraMessageBox.Show("E-mail gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cursor.Current = Cursors.Default;
            this.UseWaitCursor = false;
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.UseWaitCursor = true;
            string sipNo = this.Text.Replace("Tartim:", "");
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "*.pdf|PDF Dosyaları";
                sfd.FileName = "SanmarkTartim." + sipNo + ".pdf";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Report.ExportToPdf(sfd.FileName);
                    //Report.ExportToXls(sfd.FileName.Replace(".pdf", ".xls"));
                }
            }
            Cursor.Current = Cursors.Default;
            this.UseWaitCursor = false;
        }

        private void bbiExcell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.UseWaitCursor = true;
            string sipNo = this.Text.Replace("Tartim:", "");
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel|*.xls|Excel 2010|*.xlsx";
                sfd.FileName = "SanmarkTartim." + sipNo + ".xlsx";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Report.ExportToXlsx(sfd.FileName);
                    //Report.ExportToXls(sfd.FileName.Replace(".pdf", ".xls"));
                }
            }
            Cursor.Current = Cursors.Default;
            this.UseWaitCursor = false;
        }
    }
}
