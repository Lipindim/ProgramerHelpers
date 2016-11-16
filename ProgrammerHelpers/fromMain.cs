using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerHelpers
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            //Menu_Linq_LinqToSQL_CreateClass.PerformClick();
        }

        private void Menu_Linq_LinqToSQL_CreateClass_Click(object sender, EventArgs e)
        {
            AddControlToForm(new UC_Linq_LinqToSQL_CreateClass());
        }

        private void AddControlToForm(UserControl aUserControl)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(aUserControl);
            pMain.Size = aUserControl.Size;
            //this.Size = _myControl.Size;
            //this.Height += menuStrip1.Height + 35;
            //this.Width += 15;
            this.Refresh();
            this.ClientSize = aUserControl.Size;
            this.Height += menuStrip1.Height;
        }

        private void Menu_WinForms_TabControl_HiddenTitleTab_Click(object sender, EventArgs e)
        {
            OutputText(@"Files\WinForms\TabControl\HiddenTitleTab.rtf");
        }

        private void OutputText(string aPathToFile)
        {
            OutInformationContol _outInformation = new OutInformationContol(aPathToFile);
            AddControlToForm(_outInformation);
        }
    }
}
