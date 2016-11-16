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
using System.Data.SqlClient;
using Microsoft.Win32;

namespace ProgrammerHelpers
{
    public partial class UC_Linq_LinqToSQL_CreateClass : UserControl
    {
        private SqlConnection sqlConnection;
        private string localPath = @"\Linq\LinqToSQL\CreateClass";



        public UC_Linq_LinqToSQL_CreateClass()
        {
            InitializeComponent();
            tbServer.Text = RegistryOperation.Read(localPath, "Server");
            tbDataBase.Text = RegistryOperation.Read(localPath, "Data Base");
        }

        private void bTestConnection_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbDataBase.Text.Trim()) || string.IsNullOrEmpty(tbServer.Text.Trim()))
            {
                MessageBox.Show("Куда коннектишься то?");
                return;
            }
            try
            {
                string _connectString = string.Format("Data Source = {0}; Initial catalog = {1}; Integrated security = true", tbServer.Text, tbDataBase.Text);
                sqlConnection = new SqlConnection(_connectString);
                sqlConnection.Open();
                sqlConnection.Close();

                RegistryOperation.Write(localPath, "Server", tbServer.Text);
                RegistryOperation.Write(localPath, "Data Base", tbDataBase.Text);

                bTestConnection.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                bTestConnection.BackColor = Color.LightPink;
            }
        }

        private void rbOneTable_CheckedChanged(object sender, EventArgs e)
        {
            if(rbOneTable.Checked)
            {
                comboTableName.Enabled = true;
            }
            else
            {
                comboTableName.Enabled = false;
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            bTestConnection.PerformClick();
            MakeVisibleNextBack();

            if(rbOneTable.Checked)
            {
                string _tableName = comboTableName.Text;
                if (string.IsNullOrEmpty(_tableName))
                {
                    MessageBox.Show("Не задано имя таблицы!");
                    return;
                }
                string _QueryColumns = string.Format("Select * from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='{0}'", _tableName);
                string _QueryKey = string.Format("Select * from INFORMATION_SCHEMA.KEY_COLUMN_USAGE where TABLE_NAME='{0}'", _tableName);

                DataTable _DTColumns = GetDataTable(_QueryColumns);
                DataTable _DTKey = GetDataTable(_QueryKey);

                IEnumerable<TableInfo> _IEnumTableInfo = from Row in _DTColumns.Rows.Cast<DataRow>()
                                                         select new TableInfo
                                                         {
                                                             Name = Row["COLUMN_NAME"].ToString(),
                                                             IsNullable = Row["IS_NULLABLE"].ToString() == "YES"?true:false,
                                                             DataType = Row["DATA_TYPE"].ToString(),
                                                             IsPrimaryKey = false,
                                                             IsGeneratedDB = false
                                                         };



                //Получить список столбцов из таблицы
                //Метод, который по таблице и базе данных строит коллекцию TableInfo
            }
            if (rbOrderTables.Checked)
            {
                //Получить список таблиц
            }
            if (rbAllTables.Checked)
            {
                //Пожарить всё!
            }

        }

        private void MakeVisibleNextBack()
        {
            if (rbOrderTables.Checked)
            {
                btnNext.Visible = true;
                btnBack.Visible = true;
            }
            else
            {
                btnNext.Visible = false;
                btnBack.Visible = false;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                lbTo.Items.Add(lbFrom.SelectedItem);
                lbFrom.Items.Remove(lbFrom.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            foreach (object _item in lbFrom.Items)
            {
                lbTo.Items.Add(_item);
            }
            lbFrom.Items.Clear();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                lbFrom.Items.Add(lbTo.SelectedItem);
                lbTo.Items.Remove(lbTo.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dialogOutputFolder.ShowDialog() == DialogResult.OK)
            {
                tbBrowse.Text = dialogOutputFolder.SelectedPath;
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNamespace.Text))
            {
                MessageBox.Show("Не введено пространство имён!");
                return;
            }
        }

        private void comboTableName_DropDown(object sender, EventArgs e)
        {
            comboTableName.DataSource = GetListTables().ToList();
        }

        private IEnumerable<string> GetListTables()
        {
            string _StrQuery = "Select TABLE_NAME from INFORMATION_SCHEMA.TABLES";
            DataTable _DataTable = GetDataTable(_StrQuery);
            return  from Row in _DataTable.Rows.Cast<DataRow>()
                                         select Row["TABLE_NAME"].ToString();
        }

        private DataTable GetDataTable(string aStrQuery)
        {
            bTestConnection.PerformClick();
            DataTable rDataTable = new DataTable();
            SqlDataAdapter _SqlAdapter = new SqlDataAdapter()
            {
                SelectCommand = new SqlCommand()
                {
                    Connection = sqlConnection,
                    CommandText = aStrQuery,
                    CommandType = CommandType.Text
                }
            };
            sqlConnection.Open();
            _SqlAdapter.Fill(rDataTable);
            sqlConnection.Close();
            return rDataTable;
        }

        private void tbServer_TextChanged(object sender, EventArgs e)
        {
            bTestConnection.BackColor = Color.LightPink;
        }
    }
}
