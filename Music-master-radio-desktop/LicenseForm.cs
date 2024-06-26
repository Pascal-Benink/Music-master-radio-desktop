using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;
using mshtml;
using System.IO;

namespace MusicMaster2._0
{
    public partial class LicenseForm : Form
    {

        public LicenseForm()
        {
            InitializeComponent();
            LoadLicenseText();
        }

        private void LoadLicenseText()
        {
            string licenseText = File.ReadAllText("LICENSE.md");
            string htmlText = Markdown.ToHtml(licenseText);

            // Convert HTML to RTF and set the RTF content to the RichTextBox
            string rtfText = ConvertHtmlToRtf(htmlText);
            richTextBoxLicense.Rtf = rtfText;

            ChangeFontToArial();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private string ConvertHtmlToRtf(string html)
        {
            using (WebBrowser webBrowser = new WebBrowser())
            {
                webBrowser.DocumentText = html;

                while (webBrowser.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }

                // Copy the rendered HTML to the clipboard in RTF format
                webBrowser.Document.ExecCommand("SelectAll", false, null);
                webBrowser.Document.ExecCommand("Copy", false, null);

                // Retrieve the RTF from the clipboard
                IDataObject data = Clipboard.GetDataObject();
                if (data != null && data.GetDataPresent(DataFormats.Rtf))
                {
                    return data.GetData(DataFormats.Rtf).ToString();
                }
            }
            return string.Empty;
        }

        private void ChangeFontToArial()
        {
            richTextBoxLicense.SelectAll();
            richTextBoxLicense.SelectionFont = new Font("Arial", richTextBoxLicense.SelectionFont.Size);
            richTextBoxLicense.DeselectAll();
        }
    }
}