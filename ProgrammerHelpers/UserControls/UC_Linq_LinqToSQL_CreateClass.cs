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
using System.Reflection;

namespace ProgrammerHelpers
{
    public partial class UC_Linq_LinqToSQL_CreateClass : UserControl
    {
        private SqlConnection sqlConnection;
        private string localPath = @"\Linq\LinqToSQL\CreateClass";
        private List<string> listTables;



        public UC_Linq_LinqToSQL_CreateClass()
        {
            InitializeComponent();
            tbServer.Text = RegistryOperation.Read(localPath, "Server");
            comboDataBase.Text = RegistryOperation.Read(localPath, "Data Base");
            tbNamespace.Text = RegistryOperation.Read(localPath, "nameSpace");
            tbBrowse.Text = RegistryOperation.Read(localPath, "path");
            dialogOutputFolder.SelectedPath = tbBrowse.Text;
        }

        private void bTestConnection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboDataBase.Text.Trim()) || string.IsNullOrEmpty(tbServer.Text.Trim()))
            {
                MessageBox.Show("Куда коннектишься то?");
                return;
            }
            try
            {
                string _connectString = string.Format("Data Source = {0}; Initial catalog = {1}; Integrated security = true", tbServer.Text, comboDataBase.Text);
                sqlConnection = new SqlConnection(_connectString);
                sqlConnection.Open();
                sqlConnection.Close();

                RegistryOperation.Write(localPath, "Server", tbServer.Text);
                RegistryOperation.Write(localPath, "Data Base", comboDataBase.Text);
                listTables = GetListTables().ToList();
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
            if (rbOneTable.Checked)
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
            try
            {
                bTestConnection.PerformClick();
                MakeVisibleNextBack();

                if (rbOneTable.Checked)
                {
                    GetTableInfo(comboTableName.Text);
                }
                if (rbOrderTables.Checked)
                {
                    if (listTables.Count == 0)
                    {
                        throw new Exception("Не найдены таблицы!");
                    }
                    else
                    {
                        GetTableInfo(listTables.FirstOrDefault());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetTableInfo(string aTableName)
        {
            lblTableName.Text = aTableName;

            if (string.IsNullOrEmpty(aTableName))
            {
                throw new Exception("Не задано имя таблицы!");
            }
            FillListBoxFrom(aTableName);
        }

        private void FillListBoxFrom(string aTableName)
        {
            lbFrom.Items.Clear();
            lbTo.Items.Clear();
            foreach (ColumnInfo _colInfo in GetColumnInfoCollection(aTableName))
            {
                lbFrom.Items.Add(_colInfo.Name);
            }
        }

        private void CreateClass(string _tableName)
        {
            IEnumerable<ColumnInfo> _iEnumColumnInfo = GetColumnInfoCollection(_tableName);

            string _propertyList = GetPropertyList(_iEnumColumnInfo);

            string _template = ReadTemplate();

            _template = _template.Replace("@TableName", _tableName).Replace("@PropertyList", _propertyList).Replace("@Namespace", tbNamespace.Text);

            WriteFile(_tableName, _template);
        }

        private string GetPropertyList(IEnumerable<ColumnInfo> aIEnumColumnInfo)
        {
            string _propertyList = string.Empty;

            foreach (ColumnInfo _colInfo in aIEnumColumnInfo)
            {
                if (lbTo.Items.Contains(_colInfo.Name))
                {
                    _propertyList += GetPropertyString(_colInfo);
                }
            }

            return _propertyList;
        }

        private static string ReadTemplate()
        {
            StreamReader _sr = new StreamReader(@"Files\Linq\Linq to SQL\Create class\Template.cs");
            return _sr.ReadToEnd();
        }

        private void WriteFile(string _tableName, string _template)
        {
            string _path = dialogOutputFolder.SelectedPath;
            if (string.IsNullOrEmpty(_path))
            {
                _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            }
            StreamWriter _sw = new StreamWriter(string.Format("{0}\\{1}.cs", _path, _tableName));
            _sw.Write(_template);
            _sw.Close();
        }

        private static string GetPropertyString(ColumnInfo _colInfo)
        {
            string _property = "\t\t[Column@ColParam]\r\n\t\tpublic @type @colName { get; set; }\r\n";
            string _typeNet = GetTypeDotNet(_colInfo.DataType, _colInfo.IsNullable);
            _property = _property.Replace("@type", _typeNet).Replace("@colName", _colInfo.Name);

            if (_colInfo.IsPrimaryKey == false && _colInfo.IsGeneratedDB == false)
            {
                _property = _property.Replace("@ColParam", string.Empty);
            }
            else
            {
                if (_colInfo.IsPrimaryKey == true && _colInfo.IsGeneratedDB == false)
                {
                    _property = _property.Replace("@ColParam", "(IsPrimaryKey = true)");
                }
                if (_colInfo.IsPrimaryKey == false && _colInfo.IsGeneratedDB == true)
                {
                    _property = _property.Replace("@ColParam", "(IsDbGenerated = true)");
                }
                if (_colInfo.IsPrimaryKey == true && _colInfo.IsGeneratedDB == true)
                {
                    _property = _property.Replace("@ColParam", "(IsDbGenerated = true, IsPrimaryKey = true)");
                }
            }

            return _property;
        }

        private static string GetTypeDotNet(string _TypeName, bool _IsNullable)
        {
            if (DataBaseOperation.TypeMap.ContainsKey(_TypeName))
            {
                return DataBaseOperation.TypeMap[_TypeName];
            }
            else
            {
                if (_IsNullable)
                {
                    return DataBaseOperation.TypeMapNullable[_TypeName] + '?';
                }
                else
                {
                    return DataBaseOperation.TypeMapNullable[_TypeName];
                }
            }

        }

        private IEnumerable<ColumnInfo> GetColumnInfoCollection(string _tableName)
        {
            string _QueryColumns = string.Format(@"Select * 
                                                   from INFORMATION_SCHEMA.COLUMNS 
                                                   where TABLE_NAME='{0}'",
                                                   _tableName);

            string _QueryKey = string.Format(@"Select COLUMN_NAME 
                                               from INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
                                               where TABLE_NAME='{0}'",
                                               _tableName);

            string _QueryIdentity = string.Format(@"select COLUMN_NAME 
                                                    from INFORMATION_SCHEMA.COLUMNS 
                                                    where COLUMNPROPERTY(object_id('{0}'),COLUMN_NAME,'IsIdentity') = 1",
                                                    _tableName);

            DataTable _DTColumns = GetDataTable(_QueryColumns, sqlConnection);
            DataTable _DTKey = GetDataTable(_QueryKey, sqlConnection);
            DataTable _DTIdentity = GetDataTable(_QueryIdentity, sqlConnection);

            string _columnKey = _DTKey.Rows.Count == 0 ? string.Empty : _DTKey.Rows[0]["COLUMN_NAME"].ToString();
            string _columnIdentity = _DTIdentity.Rows.Count == 0 ? string.Empty : _DTIdentity.Rows[0]["COLUMN_NAME"].ToString();

            IEnumerable<ColumnInfo> _IEnumColumnInfo = from Row in _DTColumns.Rows.Cast<DataRow>()
                                                       select new ColumnInfo
                                                       {
                                                           Name = Row["COLUMN_NAME"].ToString(),
                                                           IsNullable = Row["IS_NULLABLE"].ToString() == "YES" ? true : false,
                                                           DataType = Row["DATA_TYPE"].ToString(),
                                                           IsPrimaryKey = Row["COLUMN_NAME"].ToString() == _columnKey ? true : false,
                                                           IsGeneratedDB = Row["COLUMN_NAME"].ToString() == _columnIdentity ? true : false
                                                       };
            return _IEnumColumnInfo;
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
            try
            {
                if (string.IsNullOrEmpty(tbNamespace.Text))
                {
                    throw new Exception("Не введено пространство имён!");
                }
                if (string.IsNullOrEmpty(tbBrowse.Text))
                {
                    if (MessageBox.Show("Не указана директория. Записать в текущую директорию?", "Продолжить?", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                if (rbAllTables.Checked)
                {
                    bTestConnection.PerformClick();
                    foreach (string _tableName in listTables)
                    {
                        GetTableInfo(_tableName);
                        btnAllRight.PerformClick();
                        CreateClass(lblTableName.Text);
                    }
                }
                else
                {
                    CreateClass(lblTableName.Text);
                }
                RegistryOperation.Write(localPath, "nameSpace", tbNamespace.Text);
                RegistryOperation.Write(localPath, "path", tbBrowse.Text);
                MessageBox.Show("Done!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboTableName_DropDown(object sender, EventArgs e)
        {
            bTestConnection.PerformClick();
            comboTableName.DataSource = GetListTables().ToList();
        }

        private IEnumerable<string> GetListTables()
        {
            string _StrQuery = "Select TABLE_NAME from INFORMATION_SCHEMA.TABLES";
            DataTable _DataTable = GetDataTable(_StrQuery, sqlConnection);
            return from Row in _DataTable.Rows.Cast<DataRow>()
                   select Row["TABLE_NAME"].ToString();
        }

        private DataTable GetDataTable(string aStrQuery, SqlConnection aSqlConnection)
        {
            //bTestConnection.PerformClick();
            DataTable rDataTable = new DataTable();
            SqlDataAdapter _SqlAdapter = new SqlDataAdapter()
            {
                SelectCommand = new SqlCommand()
                {
                    Connection = aSqlConnection,
                    CommandText = aStrQuery,
                    CommandType = CommandType.Text
                }
            };
            aSqlConnection.Open();
            _SqlAdapter.Fill(rDataTable);
            aSqlConnection.Close();
            return rDataTable;
        }

        private void tbServer_TextChanged(object sender, EventArgs e)
        {
            bTestConnection.BackColor = Color.LightPink;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (listTables.IndexOf(lblTableName.Text) == 0)
            {
                MessageBox.Show("Не могу меньше! Это первая!");
            }
            else
            {
                GetTableInfo(listTables[listTables.IndexOf(lblTableName.Text) - 1]);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listTables.IndexOf(lblTableName.Text) == listTables.Count - 1)
            {
                MessageBox.Show("Нет больше! Это последняя!");
            }
            else
            {
                GetTableInfo(listTables[listTables.IndexOf(lblTableName.Text) + 1]);
            }
        }

        private void rbAllTables_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllTables.Checked)
            {
                bChoose.Enabled = false;
            }
            else
            {
                bChoose.Enabled = true;
            }
        }

        private void comboDataBase_DropDown(object sender, EventArgs e)
        {
            //Получить список БД
        }
    }
}
