namespace ProgrammerHelpers
{
    partial class UC_Linq_LinqToSQL_CreateClass
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bTestConnection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboTableName = new System.Windows.Forms.ComboBox();
            this.bChoose = new System.Windows.Forms.Button();
            this.rbAllTables = new System.Windows.Forms.RadioButton();
            this.rbOrderTables = new System.Windows.Forms.RadioButton();
            this.rbOneTable = new System.Windows.Forms.RadioButton();
            this.lblTableName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnAllRight = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lbTo = new System.Windows.Forms.ListBox();
            this.lbFrom = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBrowse = new System.Windows.Forms.TextBox();
            this.tbNamespace = new System.Windows.Forms.TextBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dialogOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.comboDataBase = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.comboDataBase);
            this.panel1.Controls.Add(this.bTestConnection);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 91);
            this.panel1.TabIndex = 0;
            // 
            // bTestConnection
            // 
            this.bTestConnection.Location = new System.Drawing.Point(442, 19);
            this.bTestConnection.Name = "bTestConnection";
            this.bTestConnection.Size = new System.Drawing.Size(144, 52);
            this.bTestConnection.TabIndex = 3;
            this.bTestConnection.Text = "Test connection";
            this.bTestConnection.UseVisualStyleBackColor = true;
            this.bTestConnection.Click += new System.EventHandler(this.bTestConnection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "База данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сервер";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(181, 12);
            this.tbServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(232, 26);
            this.tbServer.TabIndex = 0;
            this.tbServer.TextChanged += new System.EventHandler(this.tbServer_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.comboTableName);
            this.panel2.Controls.Add(this.bChoose);
            this.panel2.Controls.Add(this.rbAllTables);
            this.panel2.Controls.Add(this.rbOrderTables);
            this.panel2.Controls.Add(this.rbOneTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 111);
            this.panel2.TabIndex = 1;
            // 
            // comboTableName
            // 
            this.comboTableName.FormattingEnabled = true;
            this.comboTableName.Location = new System.Drawing.Point(202, 8);
            this.comboTableName.Name = "comboTableName";
            this.comboTableName.Size = new System.Drawing.Size(105, 28);
            this.comboTableName.TabIndex = 6;
            this.comboTableName.DropDown += new System.EventHandler(this.comboTableName_DropDown);
            // 
            // bChoose
            // 
            this.bChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bChoose.Location = new System.Drawing.Point(354, 23);
            this.bChoose.Name = "bChoose";
            this.bChoose.Size = new System.Drawing.Size(193, 69);
            this.bChoose.TabIndex = 5;
            this.bChoose.Text = "Choose!";
            this.bChoose.UseVisualStyleBackColor = true;
            this.bChoose.Click += new System.EventHandler(this.bStart_Click);
            // 
            // rbAllTables
            // 
            this.rbAllTables.AutoSize = true;
            this.rbAllTables.Location = new System.Drawing.Point(54, 68);
            this.rbAllTables.Name = "rbAllTables";
            this.rbAllTables.Size = new System.Drawing.Size(100, 24);
            this.rbAllTables.TabIndex = 2;
            this.rbAllTables.Text = "Все сразу";
            this.rbAllTables.UseVisualStyleBackColor = true;
            // 
            // rbOrderTables
            // 
            this.rbOrderTables.AutoSize = true;
            this.rbOrderTables.Location = new System.Drawing.Point(54, 38);
            this.rbOrderTables.Name = "rbOrderTables";
            this.rbOrderTables.Size = new System.Drawing.Size(143, 24);
            this.rbOrderTables.TabIndex = 1;
            this.rbOrderTables.Text = "Все по порядку";
            this.rbOrderTables.UseVisualStyleBackColor = true;
            // 
            // rbOneTable
            // 
            this.rbOneTable.AutoSize = true;
            this.rbOneTable.Checked = true;
            this.rbOneTable.Location = new System.Drawing.Point(54, 8);
            this.rbOneTable.Name = "rbOneTable";
            this.rbOneTable.Size = new System.Drawing.Size(132, 24);
            this.rbOneTable.TabIndex = 0;
            this.rbOneTable.TabStop = true;
            this.rbOneTable.Text = "Одну таблицу";
            this.rbOneTable.UseVisualStyleBackColor = true;
            this.rbOneTable.CheckedChanged += new System.EventHandler(this.rbOneTable_CheckedChanged);
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTableName.Location = new System.Drawing.Point(213, 13);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(166, 31);
            this.lblTableName.TabIndex = 4;
            this.lblTableName.Text = "Table name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnLeft);
            this.panel3.Controls.Add(this.btnAllRight);
            this.panel3.Controls.Add(this.btnRight);
            this.panel3.Controls.Add(this.lbTo);
            this.panel3.Controls.Add(this.lbFrom);
            this.panel3.Controls.Add(this.lblTableName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 304);
            this.panel3.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(12, 141);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 44);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(511, 141);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(79, 44);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeft.Location = new System.Drawing.Point(257, 223);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(91, 36);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.Text = "<<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnAllRight
            // 
            this.btnAllRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllRight.Location = new System.Drawing.Point(257, 125);
            this.btnAllRight.Name = "btnAllRight";
            this.btnAllRight.Size = new System.Drawing.Size(91, 36);
            this.btnAllRight.TabIndex = 8;
            this.btnAllRight.Text = "all >>>";
            this.btnAllRight.UseVisualStyleBackColor = true;
            this.btnAllRight.Click += new System.EventHandler(this.btnAllRight_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRight.Location = new System.Drawing.Point(257, 85);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(91, 36);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = ">>>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lbTo
            // 
            this.lbTo.FormattingEnabled = true;
            this.lbTo.ItemHeight = 20;
            this.lbTo.Location = new System.Drawing.Point(354, 63);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(146, 224);
            this.lbTo.TabIndex = 6;
            // 
            // lbFrom
            // 
            this.lbFrom.FormattingEnabled = true;
            this.lbFrom.ItemHeight = 20;
            this.lbFrom.Location = new System.Drawing.Point(106, 63);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(145, 224);
            this.lbFrom.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.btnBrowse);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.tbBrowse);
            this.panel4.Controls.Add(this.tbNamespace);
            this.panel4.Controls.Add(this.btnReady);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 506);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(602, 164);
            this.panel4.TabIndex = 10;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(461, 50);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 28);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Где создавать?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Namespace";
            // 
            // tbBrowse
            // 
            this.tbBrowse.Location = new System.Drawing.Point(163, 51);
            this.tbBrowse.Name = "tbBrowse";
            this.tbBrowse.Size = new System.Drawing.Size(267, 26);
            this.tbBrowse.TabIndex = 2;
            // 
            // tbNamespace
            // 
            this.tbNamespace.Location = new System.Drawing.Point(163, 19);
            this.tbNamespace.Name = "tbNamespace";
            this.tbNamespace.Size = new System.Drawing.Size(267, 26);
            this.tbNamespace.TabIndex = 1;
            // 
            // btnReady
            // 
            this.btnReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReady.Location = new System.Drawing.Point(219, 89);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(156, 60);
            this.btnReady.TabIndex = 0;
            this.btnReady.Text = "Create!";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboDataBase
            // 
            this.comboDataBase.FormattingEnabled = true;
            this.comboDataBase.Location = new System.Drawing.Point(181, 48);
            this.comboDataBase.Name = "comboDataBase";
            this.comboDataBase.Size = new System.Drawing.Size(232, 28);
            this.comboDataBase.TabIndex = 7;
            // 
            // UC_Linq_LinqToSQL_CreateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Linq_LinqToSQL_CreateClass";
            this.Size = new System.Drawing.Size(602, 670);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Button bTestConnection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bChoose;
        private System.Windows.Forms.RadioButton rbAllTables;
        private System.Windows.Forms.RadioButton rbOrderTables;
        private System.Windows.Forms.RadioButton rbOneTable;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.ListBox lbTo;
        private System.Windows.Forms.ListBox lbFrom;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnAllRight;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBrowse;
        private System.Windows.Forms.TextBox tbNamespace;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FolderBrowserDialog dialogOutputFolder;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboTableName;
        private System.Windows.Forms.ComboBox comboDataBase;
    }
}
