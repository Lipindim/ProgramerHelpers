using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgrammerHelpers
{
    public partial class OutInformationContol : UserControl
    {
        private string pathToFile;
        public OutInformationContol(string aPathToFile)
        {
            InitializeComponent();
            pathToFile = aPathToFile;
            if (File.Exists(pathToFile))
            {
                richTextBox1.LoadFile(pathToFile);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Path.GetDirectoryName(pathToFile)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(pathToFile));
            }
            richTextBox1.SaveFile(pathToFile);
            MessageBox.Show("Сохранено!");
        }
    }
}
