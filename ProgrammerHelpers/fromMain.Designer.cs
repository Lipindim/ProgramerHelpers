﻿namespace ProgrammerHelpers
{
    partial class formMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linqToSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Linq_LinqToSQL_CreateClass = new System.Windows.Forms.ToolStripMenuItem();
            this.pMain = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.winFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_WinForms_TabControl_HiddenTitleTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linqToolStripMenuItem,
            this.winFormsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linqToolStripMenuItem
            // 
            this.linqToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linqToSQLToolStripMenuItem});
            this.linqToolStripMenuItem.Name = "linqToolStripMenuItem";
            this.linqToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.linqToolStripMenuItem.Text = "Linq";
            // 
            // linqToSQLToolStripMenuItem
            // 
            this.linqToSQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Linq_LinqToSQL_CreateClass});
            this.linqToSQLToolStripMenuItem.Name = "linqToSQLToolStripMenuItem";
            this.linqToSQLToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.linqToSQLToolStripMenuItem.Text = "Linq To SQL";
            // 
            // Menu_Linq_LinqToSQL_CreateClass
            // 
            this.Menu_Linq_LinqToSQL_CreateClass.Name = "Menu_Linq_LinqToSQL_CreateClass";
            this.Menu_Linq_LinqToSQL_CreateClass.Size = new System.Drawing.Size(223, 26);
            this.Menu_Linq_LinqToSQL_CreateClass.Text = "Создание классов";
            this.Menu_Linq_LinqToSQL_CreateClass.Click += new System.EventHandler(this.Menu_Linq_LinqToSQL_CreateClass_Click);
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 29);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(460, 334);
            this.pMain.TabIndex = 1;
            // 
            // winFormsToolStripMenuItem
            // 
            this.winFormsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabControlToolStripMenuItem});
            this.winFormsToolStripMenuItem.Name = "winFormsToolStripMenuItem";
            this.winFormsToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.winFormsToolStripMenuItem.Text = "WinForms";
            // 
            // tabControlToolStripMenuItem
            // 
            this.tabControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_WinForms_TabControl_HiddenTitleTab});
            this.tabControlToolStripMenuItem.Name = "tabControlToolStripMenuItem";
            this.tabControlToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.tabControlToolStripMenuItem.Text = "TabControl";
            // 
            // Menu_WinForms_TabControl_HiddenTitleTab
            // 
            this.Menu_WinForms_TabControl_HiddenTitleTab.Name = "Menu_WinForms_TabControl_HiddenTitleTab";
            this.Menu_WinForms_TabControl_HiddenTitleTab.Size = new System.Drawing.Size(283, 26);
            this.Menu_WinForms_TabControl_HiddenTitleTab.Text = "Убрать названия вкладок";
            this.Menu_WinForms_TabControl_HiddenTitleTab.Click += new System.EventHandler(this.Menu_WinForms_TabControl_HiddenTitleTab_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(460, 363);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMain";
            this.Text = "Помощник программиста";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.ToolStripMenuItem linqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linqToSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Linq_LinqToSQL_CreateClass;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem winFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_WinForms_TabControl_HiddenTitleTab;
    }
}

