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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.linqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linqToSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Linq_LinqToSQL_CreateClass = new System.Windows.Forms.ToolStripMenuItem();
            this.winFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_WinForms_TabControl_HiddenTitleTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_web = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Web_References = new System.Windows.Forms.ToolStripMenuItem();
            this.разноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Other_Regedit = new System.Windows.Forms.ToolStripMenuItem();
            this.builderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Repeator = new System.Windows.Forms.ToolStripMenuItem();
            this.pMain = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menu_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linqToolStripMenuItem,
            this.winFormsToolStripMenuItem,
            this.menu_web,
            this.разноеToolStripMenuItem,
            this.builderToolStripMenuItem,
            this.menu_add});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(563, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
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
            // menu_web
            // 
            this.menu_web.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Web_References});
            this.menu_web.Name = "menu_web";
            this.menu_web.Size = new System.Drawing.Size(57, 25);
            this.menu_web.Text = "Web";
            // 
            // Menu_Web_References
            // 
            this.Menu_Web_References.Name = "Menu_Web_References";
            this.Menu_Web_References.Size = new System.Drawing.Size(140, 26);
            this.Menu_Web_References.Text = "Ссылки";
            this.Menu_Web_References.Click += new System.EventHandler(this.Menu_Web_References_Click);
            // 
            // разноеToolStripMenuItem
            // 
            this.разноеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Other_Regedit});
            this.разноеToolStripMenuItem.Name = "разноеToolStripMenuItem";
            this.разноеToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.разноеToolStripMenuItem.Text = "Разное";
            // 
            // Menu_Other_Regedit
            // 
            this.Menu_Other_Regedit.Name = "Menu_Other_Regedit";
            this.Menu_Other_Regedit.Size = new System.Drawing.Size(133, 26);
            this.Menu_Other_Regedit.Text = "Реестр";
            this.Menu_Other_Regedit.Click += new System.EventHandler(this.Menu_Other_Regedit_Click);
            // 
            // builderToolStripMenuItem
            // 
            this.builderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Repeator});
            this.builderToolStripMenuItem.Name = "builderToolStripMenuItem";
            this.builderToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.builderToolStripMenuItem.Text = "Builder";
            // 
            // Menu_Repeator
            // 
            this.Menu_Repeator.Name = "Menu_Repeator";
            this.Menu_Repeator.Size = new System.Drawing.Size(148, 26);
            this.Menu_Repeator.Text = "Repeater";
            this.Menu_Repeator.Click += new System.EventHandler(this.Menu_Repeator_Click);
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 29);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(563, 334);
            this.pMain.TabIndex = 1;
            // 
            // menu_add
            // 
            this.menu_add.Name = "menu_add";
            this.menu_add.Size = new System.Drawing.Size(98, 25);
            this.menu_add.Text = "Добавить";
            this.menu_add.Click += new System.EventHandler(this.menu_add_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(563, 363);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMain";
            this.Text = "Помощник программиста";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.ToolStripMenuItem linqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linqToSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Linq_LinqToSQL_CreateClass;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem winFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_WinForms_TabControl_HiddenTitleTab;
        private System.Windows.Forms.ToolStripMenuItem menu_web;
        private System.Windows.Forms.ToolStripMenuItem Menu_Web_References;
        private System.Windows.Forms.ToolStripMenuItem разноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Other_Regedit;
        private System.Windows.Forms.ToolStripMenuItem builderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Repeator;
        private System.Windows.Forms.ToolStripMenuItem menu_add;
    }
}

