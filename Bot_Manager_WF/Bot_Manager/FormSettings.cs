using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bot_Manager.Properties;
namespace Bot_Manager
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            minPerf.Items.Add(1);
            minPerf.Items.Add(2);
            minPerf.Items.Add(3);
            minPerf.Items.Add(4);
            maxPerf.Items.Add(5);
            maxPerf.Items.Add(6);
            minV.Items.Add(30);
            minV.Items.Add(40);
            maxV.Items.Add(90);
            maxV.Items.Add(100);
            minTasks.Items.Add(5);
            minTasks.Items.Add(8);
            maxTasks.Items.Add(10);
            maxTasks.Items.Add(12);
            minDifficult.Items.Add(50);
            minDifficult.Items.Add(70);
            maxDifficult.Items.Add(90);
            maxDifficult.Items.Add(100);
            TickRate.Items.Add(1);
            TickRate.Items.Add(2);
            TickRate.Items.Add(3);


        }
        public int minPerformers;
        public int maxPerformers;
        public int MinV;
        public int MaxV;
        public int maxTask;
        public int minTask;
        public int maxDiff;
        public int minDiff;
        public int Tick;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void minPerf_SelectedIndexChanged(object sender, EventArgs e)
        {
            minPerformers = Convert.ToInt32(minPerf.SelectedItem.ToString());
            Settings.Default["minPerformers"] = minPerformers;
        }

        private void FormSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void maxPerf_SelectedIndexChanged(object sender, EventArgs e)
        {
            maxPerformers = Convert.ToInt32(maxPerf.SelectedItem.ToString());
            Settings.Default["maxPerformers"] = maxPerformers;
        }

        private void minV_SelectedIndexChanged(object sender, EventArgs e)
        {
            MinV = Convert.ToInt32(minV.SelectedItem.ToString());
            Settings.Default["MinV"] = MinV;
        }

        private void maxV_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaxV = Convert.ToInt32(maxV.SelectedItem.ToString());
            Settings.Default["MaxV"] = MaxV;
        }

        private void minTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            minTask = Convert.ToInt32(minTasks.SelectedItem.ToString());
            Settings.Default["minTask"] = minTask;
        }

        private void maxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            maxTask = Convert.ToInt32(maxTasks.SelectedItem.ToString());
            Settings.Default["maxTask"] = maxTask;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }

        private void minDifficult_SelectedIndexChanged(object sender, EventArgs e)
        {
            minDiff = Convert.ToInt32(minDifficult.SelectedItem.ToString());
            Settings.Default["minDiff"] = minDiff;
        }

        private void maxDifficult_SelectedIndexChanged(object sender, EventArgs e)
        {
            maxDiff = Convert.ToInt32(maxDifficult.SelectedItem.ToString());
            Settings.Default["maxDiff"] = maxDiff;
        }

        private void TickRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tick = Convert.ToInt32(TickRate.SelectedItem.ToString());
            Settings.Default["Tick"] = Tick;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            TickRate.Text = Settings.Default.Tick.ToString();
            maxDifficult.Text = Settings.Default.maxDiff.ToString();
            minDifficult.Text = Settings.Default.minDiff.ToString();
            maxTasks.Text = Settings.Default.maxTask.ToString();
            minTasks.Text = Settings.Default.minTask.ToString();
            minPerf.Text = Settings.Default.minPerformers.ToString();
            maxPerf.Text = Settings.Default.maxPerformers.ToString();
            minV.Text = Settings.Default.MinV.ToString();
            maxV.Text = Settings.Default.MaxV.ToString();
            maxTasks.Text = Settings.Default.maxTask.ToString();
            minTasks.Text = Settings.Default.minTask.ToString();
        }
    }
}
