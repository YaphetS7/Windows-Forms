using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LIST.Items.Add("Казань");
            LIST.Items.Add("Химки");
            LIST.Items.Add("Ижевск");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Численности form2 = new Численности();
            Form3 form3 = new Form3();
            if (radioButton1.Checked)
                form3.ShowDialog();

            if (radioButton2.Checked)
                form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void Do_Checked()
        {
            button1.Enabled = checkBox1.Checked;
        }
    }
}