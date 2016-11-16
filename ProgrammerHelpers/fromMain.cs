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
            Menu_Linq_LinqToSQL_CreateClass.PerformClick();
        }

        private void Menu_Linq_LinqToSQL_CreateClass_Click(object sender, EventArgs e)
        {
            UC_Linq_LinqToSQL_CreateClass _myControl = new UC_Linq_LinqToSQL_CreateClass();
            pMain.Controls.Clear();
            pMain.Controls.Add(_myControl);
            pMain.Size = _myControl.Size;
            //this.Size = _myControl.Size;
            //this.Height += menuStrip1.Height + 35;
            //this.Width += 15;
            this.Refresh();
            this.ClientSize = _myControl.Size;
            this.Height += menuStrip1.Height;
        }
    }
}
