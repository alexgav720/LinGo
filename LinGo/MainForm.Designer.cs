namespace LinGo
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.levelChoseButton5 = new LinGo.LevelChoseButton();
            this.levelChoseButton4 = new LinGo.LevelChoseButton();
            this.levelChoseButton3 = new LinGo.LevelChoseButton();
            this.roundedPanel1 = new LinGo.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.levelChoseButton2 = new LinGo.LevelChoseButton();
            this.levelChoseButton1 = new LinGo.LevelChoseButton();
            this.roundedButton1 = new LinGo.RoundedButton();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "LinGo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(161)))));
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Controls.Add(this.roundedButton1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-3, -9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 662);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(1, 4);
            this.tabControl1.Location = new System.Drawing.Point(233, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 656);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 8);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(181, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 48);
            this.label5.TabIndex = 8;
            this.label5.Text = "профиль TODO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(160, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 68);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(64, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Модуль 1: Начало";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.levelChoseButton5);
            this.tabPage1.Controls.Add(this.levelChoseButton4);
            this.tabPage1.Controls.Add(this.levelChoseButton3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.roundedPanel1);
            this.tabPage1.Controls.Add(this.levelChoseButton2);
            this.tabPage1.Controls.Add(this.levelChoseButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 8);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // levelChoseButton5
            // 
            this.levelChoseButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(204)))), ((int)(((byte)(2)))));
            this.levelChoseButton5.ButtonRoundRadius = 50;
            this.levelChoseButton5.Color = System.Drawing.Color.WhiteSmoke;
            this.levelChoseButton5.FlatAppearance.BorderSize = 0;
            this.levelChoseButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelChoseButton5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.levelChoseButton5.Location = new System.Drawing.Point(290, 667);
            this.levelChoseButton5.Name = "levelChoseButton5";
            this.levelChoseButton5.PathLevel = 5;
            this.levelChoseButton5.Size = new System.Drawing.Size(100, 76);
            this.levelChoseButton5.TabIndex = 11;
            this.levelChoseButton5.Text = "5";
            this.levelChoseButton5.UseVisualStyleBackColor = false;
            // 
            // levelChoseButton4
            // 
            this.levelChoseButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(204)))), ((int)(((byte)(2)))));
            this.levelChoseButton4.ButtonRoundRadius = 50;
            this.levelChoseButton4.Color = System.Drawing.Color.WhiteSmoke;
            this.levelChoseButton4.FlatAppearance.BorderSize = 0;
            this.levelChoseButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelChoseButton4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.levelChoseButton4.Location = new System.Drawing.Point(456, 577);
            this.levelChoseButton4.Name = "levelChoseButton4";
            this.levelChoseButton4.PathLevel = 4;
            this.levelChoseButton4.Size = new System.Drawing.Size(100, 76);
            this.levelChoseButton4.TabIndex = 10;
            this.levelChoseButton4.Text = "4";
            this.levelChoseButton4.UseVisualStyleBackColor = false;
            this.levelChoseButton4.Click += new System.EventHandler(this.btn_Click);
            // 
            // levelChoseButton3
            // 
            this.levelChoseButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(204)))), ((int)(((byte)(2)))));
            this.levelChoseButton3.ButtonRoundRadius = 50;
            this.levelChoseButton3.Color = System.Drawing.Color.WhiteSmoke;
            this.levelChoseButton3.FlatAppearance.BorderSize = 0;
            this.levelChoseButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelChoseButton3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.levelChoseButton3.Location = new System.Drawing.Point(290, 484);
            this.levelChoseButton3.Name = "levelChoseButton3";
            this.levelChoseButton3.PathLevel = 3;
            this.levelChoseButton3.Size = new System.Drawing.Size(100, 76);
            this.levelChoseButton3.TabIndex = 9;
            this.levelChoseButton3.Text = "3";
            this.levelChoseButton3.UseVisualStyleBackColor = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(204)))), ((int)(((byte)(2)))));
            this.roundedPanel1.ButtonRoundRadius = 50;
            this.roundedPanel1.Color = System.Drawing.Color.WhiteSmoke;
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Location = new System.Drawing.Point(105, 162);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(580, 100);
            this.roundedPanel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Introduce you";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Раздел 1";
            // 
            // levelChoseButton2
            // 
            this.levelChoseButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(204)))), ((int)(((byte)(2)))));
            this.levelChoseButton2.ButtonRoundRadius = 50;
            this.levelChoseButton2.Color = System.Drawing.Color.WhiteSmoke;
            this.levelChoseButton2.FlatAppearance.BorderSize = 0;
            this.levelChoseButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelChoseButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.levelChoseButton2.Location = new System.Drawing.Point(439, 390);
            this.levelChoseButton2.Name = "levelChoseButton2";
            this.levelChoseButton2.PathLevel = 2;
            this.levelChoseButton2.Size = new System.Drawing.Size(100, 76);
            this.levelChoseButton2.TabIndex = 5;
            this.levelChoseButton2.Text = "2";
            this.levelChoseButton2.UseVisualStyleBackColor = false;
            this.levelChoseButton2.Click += new System.EventHandler(this.btn_Click);
            // 
            // levelChoseButton1
            // 
            this.levelChoseButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(204)))), ((int)(((byte)(2)))));
            this.levelChoseButton1.ButtonRoundRadius = 50;
            this.levelChoseButton1.Color = System.Drawing.Color.WhiteSmoke;
            this.levelChoseButton1.FlatAppearance.BorderSize = 0;
            this.levelChoseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelChoseButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelChoseButton1.Location = new System.Drawing.Point(290, 306);
            this.levelChoseButton1.Name = "levelChoseButton1";
            this.levelChoseButton1.PathLevel = 1;
            this.levelChoseButton1.Size = new System.Drawing.Size(100, 80);
            this.levelChoseButton1.TabIndex = 4;
            this.levelChoseButton1.Text = "1";
            this.levelChoseButton1.UseVisualStyleBackColor = false;
            this.levelChoseButton1.Click += new System.EventHandler(this.btn_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.roundedButton1.ButtonRoundRadius = 50;
            this.roundedButton1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(206)))), ((int)(((byte)(161)))));
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(176)))), ((int)(((byte)(246)))));
            this.roundedButton1.Location = new System.Drawing.Point(9, 121);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(0);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(206, 64);
            this.roundedButton1.TabIndex = 4;
            this.roundedButton1.Text = "обучение";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 641);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinGo";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private LevelChoseButton levelChoseButton5;
        private LevelChoseButton levelChoseButton4;
        private LevelChoseButton levelChoseButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private LevelChoseButton levelChoseButton2;
        private LevelChoseButton levelChoseButton1;
    }
}

