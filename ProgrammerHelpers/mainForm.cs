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
        public static MenuStrip MainMenu;
        public formMain()
        {
            InitializeComponent();
            MainMenu = menuStrip;
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
            this.Height += menuStrip.Height;
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

        private void Menu_Web_References_Click(object sender, EventArgs e)
        {
            OutputText(@"Files\Web\References.rtf");
        }

        private void Menu_Other_Regedit_Click(object sender, EventArgs e)
        {
            OutputText(@"Files\Other\Regedit.rtf");
        }

        private void Menu_Repeator_Click(object sender, EventArgs e)
        {
            AddControlToForm(new UserControls.Builder.Repeator());
        }

        private void menu_add_Click(object sender, EventArgs e)
        {
            new menuForm().ShowDialog();
        }
    }
}
