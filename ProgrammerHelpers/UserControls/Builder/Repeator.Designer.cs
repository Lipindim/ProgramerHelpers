namespace ProgrammerHelpers.UserControls.Builder
{
    partial class Repeator
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
            this.btnClearResults = new System.Windows.Forms.Button();
            this.btnClearReplecer = new System.Windows.Forms.Button();
            this.btnClearCode = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.tbReplacer = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClearResults
            // 
            this.btnClearResults.Location = new System.Drawing.Point(396, 732);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(95, 27);
            this.btnClearResults.TabIndex = 16;
            this.btnClearResults.Text = "Очистить";
            this.btnClearResults.UseVisualStyleBackColor = true;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // btnClearReplecer
            // 
            this.btnClearReplecer.Location = new System.Drawing.Point(672, 373);
            this.btnClearReplecer.Name = "btnClearReplecer";
            this.btnClearReplecer.Size = new System.Drawing.Size(95, 27);
            this.btnClearReplecer.TabIndex = 17;
            this.btnClearReplecer.Text = "Очистить";
            this.btnClearReplecer.UseVisualStyleBackColor = true;
            this.btnClearReplecer.Click += new System.EventHandler(this.btnClearReplecer_Click);
            // 
            // btnClearCode
            // 
            this.btnClearCode.Location = new System.Drawing.Point(106, 357);
            this.btnClearCode.Name = "btnClearCode";
            this.btnClearCode.Size = new System.Drawing.Size(95, 27);
            this.btnClearCode.TabIndex = 18;
            this.btnClearCode.Text = "Очистить";
            this.btnClearCode.UseVisualStyleBackColor = true;
            this.btnClearCode.Click += new System.EventHandler(this.btnClearCode_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(383, 373);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 67);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Копи паст";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(12, 476);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResults.Size = new System.Drawing.Size(853, 254);
            this.tbResults.TabIndex = 14;
            // 
            // tbReplacer
            // 
            this.tbReplacer.Location = new System.Drawing.Point(578, 36);
            this.tbReplacer.Multiline = true;
            this.tbReplacer.Name = "tbReplacer";
            this.tbReplacer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReplacer.Size = new System.Drawing.Size(287, 331);
            this.tbReplacer.TabIndex = 13;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(350, 36);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(202, 26);
            this.tbKey.TabIndex = 12;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(12, 36);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCode.Size = new System.Drawing.Size(321, 315);
            this.tbCode.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(705, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "На";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 443);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Заменять";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Повторяемый код";
            // 
            // Repeator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClearResults);
            this.Controls.Add(this.btnClearReplecer);
            this.Controls.Add(this.btnClearCode);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.tbReplacer);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Repeator";
            this.Size = new System.Drawing.Size(890, 772);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.Button btnClearReplecer;
        private System.Windows.Forms.Button btnClearCode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.TextBox tbReplacer;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
