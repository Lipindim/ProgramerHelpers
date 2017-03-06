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
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(formMain.MainMenu);
            AddNewElement(formMain.MainMenu.Items);
            formMain.MainMenu.Items.Add("New element");
        }

        private static void AddNewElement(ToolStripItemCollection collection)
        {
            foreach (var item in collection.Cast<ToolStripMenuItem>())
            {
                AddNewElement(item.DropDownItems);
                item.DropDownItems.Add("New element");
                var newItem =  item.DropDownItems[item.DropDownItems.Count-1];
                newItem.Click += Item_Click;
            }
        }

        private static void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (sender as ToolStripMenuItem);
            //menu.Owner.Text
            throw new NotImplementedException();
        }
    }
}
