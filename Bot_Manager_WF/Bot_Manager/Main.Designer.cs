namespace Bot_Manager
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.New = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.List1 = new System.Windows.Forms.ListBox();
            this.List2 = new System.Windows.Forms.ListBox();
            this.List3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(176, 338);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 0;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(281, 338);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 1;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(713, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(75, 23);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // List1
            // 
            this.List1.FormattingEnabled = true;
            this.List1.Location = new System.Drawing.Point(12, 35);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(290, 277);
            this.List1.TabIndex = 3;
            this.List1.SelectedIndexChanged += new System.EventHandler(this.List1_SelectedIndexChanged);
            // 
            // List2
            // 
            this.List2.FormattingEnabled = true;
            this.List2.Location = new System.Drawing.Point(308, 35);
            this.List2.Name = "List2";
            this.List2.Size = new System.Drawing.Size(207, 277);
            this.List2.TabIndex = 4;
            this.List2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // List3
            // 
            this.List3.FormattingEnabled = true;
            this.List3.Location = new System.Drawing.Point(521, 35);
            this.List3.Name = "List3";
            this.List3.Size = new System.Drawing.Size(174, 277);
            this.List3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Исполнители и их текущие задания:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список задач исполнителя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Информация о процессе работы:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List3);
            this.Controls.Add(this.List2);
            this.Controls.Add(this.List1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.New);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox List1;
        private System.Windows.Forms.ListBox List2;
        private System.Windows.Forms.ListBox List3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

