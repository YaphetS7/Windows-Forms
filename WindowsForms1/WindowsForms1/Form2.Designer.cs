namespace WindowsForms1
{
    partial class Численности
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
            this.LIST2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LIST2
            // 
            this.LIST2.FormattingEnabled = true;
            this.LIST2.Items.AddRange(new object[] {
            "Численность населения Казани - 1.169 млн. человек",
            "Численность населения Химок - 218 275 человек",
            "Численность населения Ижевска - 631 182 человек"});
            this.LIST2.Location = new System.Drawing.Point(101, 33);
            this.LIST2.Name = "LIST2";
            this.LIST2.Size = new System.Drawing.Size(300, 147);
            this.LIST2.TabIndex = 0;
            // 
            // Численности
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 261);
            this.Controls.Add(this.LIST2);
            this.Name = "Численности";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LIST2;
    }
}