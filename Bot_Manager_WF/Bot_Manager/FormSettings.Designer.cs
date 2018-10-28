namespace Bot_Manager
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minPerf = new System.Windows.Forms.ComboBox();
            this.maxPerf = new System.Windows.Forms.ComboBox();
            this.minV = new System.Windows.Forms.ComboBox();
            this.maxV = new System.Windows.Forms.ComboBox();
            this.minTasks = new System.Windows.Forms.ComboBox();
            this.maxTasks = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.minDifficult = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maxDifficult = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TickRate = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Минимальное кол-во исполнителей:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Максимальное кол-во исполнителей:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Минимальная производительность:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Максимальная производительность:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Минимальное кол-во задач:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Максимальное кол-во задач:";
            // 
            // minPerf
            // 
            this.minPerf.FormattingEnabled = true;
            this.minPerf.Location = new System.Drawing.Point(12, 30);
            this.minPerf.Name = "minPerf";
            this.minPerf.Size = new System.Drawing.Size(121, 21);
            this.minPerf.TabIndex = 12;
            this.minPerf.SelectedIndexChanged += new System.EventHandler(this.minPerf_SelectedIndexChanged);
            // 
            // maxPerf
            // 
            this.maxPerf.FormattingEnabled = true;
            this.maxPerf.Location = new System.Drawing.Point(12, 74);
            this.maxPerf.Name = "maxPerf";
            this.maxPerf.Size = new System.Drawing.Size(121, 21);
            this.maxPerf.TabIndex = 13;
            this.maxPerf.SelectedIndexChanged += new System.EventHandler(this.maxPerf_SelectedIndexChanged);
            // 
            // minV
            // 
            this.minV.FormattingEnabled = true;
            this.minV.Location = new System.Drawing.Point(12, 151);
            this.minV.Name = "minV";
            this.minV.Size = new System.Drawing.Size(121, 21);
            this.minV.TabIndex = 14;
            this.minV.SelectedIndexChanged += new System.EventHandler(this.minV_SelectedIndexChanged);
            // 
            // maxV
            // 
            this.maxV.FormattingEnabled = true;
            this.maxV.Location = new System.Drawing.Point(12, 196);
            this.maxV.Name = "maxV";
            this.maxV.Size = new System.Drawing.Size(121, 21);
            this.maxV.TabIndex = 15;
            this.maxV.SelectedIndexChanged += new System.EventHandler(this.maxV_SelectedIndexChanged);
            // 
            // minTasks
            // 
            this.minTasks.FormattingEnabled = true;
            this.minTasks.Location = new System.Drawing.Point(12, 273);
            this.minTasks.Name = "minTasks";
            this.minTasks.Size = new System.Drawing.Size(121, 21);
            this.minTasks.TabIndex = 16;
            this.minTasks.SelectedIndexChanged += new System.EventHandler(this.minTasks_SelectedIndexChanged);
            // 
            // maxTasks
            // 
            this.maxTasks.FormattingEnabled = true;
            this.maxTasks.Location = new System.Drawing.Point(12, 316);
            this.maxTasks.Name = "maxTasks";
            this.maxTasks.Size = new System.Drawing.Size(121, 21);
            this.maxTasks.TabIndex = 17;
            this.maxTasks.SelectedIndexChanged += new System.EventHandler(this.maxTasks_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Мин. сложность:";
            // 
            // minDifficult
            // 
            this.minDifficult.FormattingEnabled = true;
            this.minDifficult.Location = new System.Drawing.Point(13, 378);
            this.minDifficult.Name = "minDifficult";
            this.minDifficult.Size = new System.Drawing.Size(121, 21);
            this.minDifficult.TabIndex = 19;
            this.minDifficult.SelectedIndexChanged += new System.EventHandler(this.minDifficult_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Макс. сложность:";
            // 
            // maxDifficult
            // 
            this.maxDifficult.FormattingEnabled = true;
            this.maxDifficult.Location = new System.Drawing.Point(12, 422);
            this.maxDifficult.Name = "maxDifficult";
            this.maxDifficult.Size = new System.Drawing.Size(121, 21);
            this.maxDifficult.TabIndex = 21;
            this.maxDifficult.SelectedIndexChanged += new System.EventHandler(this.maxDifficult_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Время срабатывания таймера:";
            // 
            // TickRate
            // 
            this.TickRate.FormattingEnabled = true;
            this.TickRate.Location = new System.Drawing.Point(350, 117);
            this.TickRate.Name = "TickRate";
            this.TickRate.Size = new System.Drawing.Size(121, 21);
            this.TickRate.TabIndex = 23;
            this.TickRate.SelectedIndexChanged += new System.EventHandler(this.TickRate_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TickRate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maxDifficult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.minDifficult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maxTasks);
            this.Controls.Add(this.minTasks);
            this.Controls.Add(this.maxV);
            this.Controls.Add(this.minV);
            this.Controls.Add(this.maxPerf);
            this.Controls.Add(this.minPerf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSettings_FormClosed);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox minPerf;
        private System.Windows.Forms.ComboBox maxPerf;
        private System.Windows.Forms.ComboBox minV;
        private System.Windows.Forms.ComboBox maxV;
        private System.Windows.Forms.ComboBox minTasks;
        private System.Windows.Forms.ComboBox maxTasks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox minDifficult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox maxDifficult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TickRate;
        private System.Windows.Forms.Button button1;
    }
}