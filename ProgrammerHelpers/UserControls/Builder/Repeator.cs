using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerHelpers.UserControls.Builder
{
    public partial class Repeator : UserControl
    {
        private string localPath = @"\Builder\Repeator";

        public Repeator()
        {
            InitializeComponent();
            tbCode.Text = RegistryOperation.Read(localPath, tbCode.Name);
            tbKey.Text = RegistryOperation.Read(localPath, tbKey.Name);
            tbReplacer.Text = RegistryOperation.Read(localPath, tbReplacer.Name);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tbResults.Text = string.Empty;
            string[] splitText = tbReplacer.Lines;

            foreach (string replacer in splitText)
            {
                tbResults.Text += tbCode.Text.Replace(tbKey.Text, replacer) + "\r\n";
            }
            Clipboard.SetText(tbReplacer.Text);
            RegistryOperation.Write(localPath, tbCode.Name, tbCode.Text);
            RegistryOperation.Write(localPath, tbKey.Name, tbKey.Text);
            RegistryOperation.Write(localPath, tbReplacer.Name, tbReplacer.Text);
        }

        private void btnClearCode_Click(object sender, EventArgs e)
        {
            tbCode.Text = string.Empty;
        }

        private void btnClearReplecer_Click(object sender, EventArgs e)
        {
            tbReplacer.Text = string.Empty;
        }

        private void btnClearResults_Click(object sender, EventArgs e)
        {
            tbResults.Text = string.Empty;
        }
    }
}
