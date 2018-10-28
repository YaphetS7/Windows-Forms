using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bot_Manager
{
   
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public List<Performer> performers = new List<Performer>();
        Random rand = new Random();
        public int CntOfPerf;
        public int CntOfTasks;
        public int CntOfTicks = 0;

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            CntOfTicks++;
            if (rand.Next(0, 2) == 1)
                B();
            timer1.Interval = Properties.Settings.Default.Tick * 1000;
            Check();
        }

        private void New_Click(object sender, EventArgs e)
        {
            timer1.Interval = Properties.Settings.Default.Tick * 1000;
            CntOfTicks = 0;
            List1.Items.Clear();
            List2.Items.Clear();
            List3.Items.Clear();
            int i;
            Performers perf = new Performers();
            timer1.Enabled = true;
            CntOfPerf = rand.Next(Properties.Settings.Default.minPerformers, Properties.Settings.Default.maxPerformers + 1);
            CntOfTasks = rand.Next(Properties.Settings.Default.minTask, Properties.Settings.Default.maxTask + 1);
            int start = rand.Next(1, 10);
            for (i = 0; i < CntOfPerf; i++)
            { 
                Performer temp = new Performer(perf.names[i + start], perf.V[i + start]);
                performers.Add(temp);
            }
            A();
            for (i = 0; i < CntOfPerf; i++)
                List1.Items.Add(performers[i].name + " " 
                    + performers[i].V + " "
                    + performers[i].tasks[performers[i].CurrentTask].name
                    + " " + performers[i].tasks[performers[i].CurrentTask].Complexity);
        }
        public void A()
        {
            int k = rand.Next(1, 7), i = 0, j = 0;
            Tasks task = new Tasks();
            while (j < CntOfTasks)
            {
                Task temp = new Task(task.names[j + k], task.complexities[j + k]);
                performers[i].tasks.Add(temp);
                if (i == CntOfPerf - 1)
                    i = 0;
                else
                    i++;
                j++;
            }
        }
        public void B()
        {
            int i, j;
            List<Task> temp = new List<Task>();
            for (j = 0; j < performers[CntOfPerf - 1].tasks.Count; j++)
            {
                temp.Add(performers[CntOfPerf - 1].tasks[j]);
            }
            performers[CntOfPerf - 1].tasks.Clear();
            performers[CntOfPerf - 1].tasks.Add(performers[0].tasks[0]);
            for (j = 1; j < temp.Count; j++)
            {
                performers[CntOfPerf - 1].tasks.Add(temp[j]);
            }
            for (i = 0; i <= CntOfPerf - 2; i++)
            {
                List<Task> task1 = new List<Task>();
                
                
                for(j = 0; j < performers[i].tasks.Count; j++)
                {
                    task1.Add(performers[i].tasks[j]);
                }

                performers[i].tasks.Clear();
                performers[i].tasks.Add(performers[i + 1].tasks[0]);
                for (j = 1; j < task1.Count; j++)
                {
                    performers[i].tasks.Add(task1[j]);
                }
            }
        }
        public void Check()
        {
            int i, indexOfTask;
            bool check = true;
            for (i = 0; i < CntOfPerf; i++)
            {
                indexOfTask = performers[i].CurrentTask;
                if (indexOfTask < performers[i].tasks.Count)
                {
                    check = false;
                    performers[i].result += performers[i].V;
                    if (performers[i].tasks[indexOfTask].Complexity <= performers[i].result)
                    {
                        List3.Items.Add(performers[i].name
                            + " " + performers[i].tasks[indexOfTask].name
                            + " " + CntOfTicks);
                        performers[i].CurrentTask++;
                        if (indexOfTask + 1 < performers[i].tasks.Count)
                        {
                            List1.Items.RemoveAt(i);

                            List1.Items.Insert(i, performers[i].name + " "
                                 + performers[i].V + " "
                                 + performers[i].tasks[performers[i].CurrentTask].name
                                 + " " + performers[i].tasks[performers[i].CurrentTask].Complexity);

                            performers[i].result = performers[i].result - performers[i].tasks[indexOfTask].Complexity;
                        }
                    }

                }
            }
            if (check)
            {
                timer1.Enabled = false;
                MessageBox.Show("Все задачи выполнены!");
            }
        }
        
        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            FormSettings form2 = new FormSettings();
            form2.ShowDialog();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void List1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List2.Items.Clear();
            int i;
            int index = List1.SelectedIndex;
            if (index != -1)
            {
                for (i = 0; i < performers[index].tasks.Count; i++)
                    List2.Items.Add(performers[index].tasks[i].name + " " + performers[index].tasks[i].Complexity);
            }
        }
    }
    public class Performer
    {
        public string name;
        public int V;
        public int CurrentTask = 0;
        public int result = 0;
        public Performer(string name, int V)
        {
            this.name = name;
            this.V = V;
        }
        public List<Task> tasks = new List<Task>();
    }
    public class Task
    {
        public string name;
        public int Complexity;
        public Task(string name, int Complexity)
        {
            this.name = name;
            this.Complexity = Complexity;
        }
    }
    public class Tasks
    {
        public List<string> names = new List<string>
        {
            "temp",
            "FindABook",
            "RealizationTask",
            "TestForDynArray",
            "FindABug",
            "CalculateTheSum",
            "TestForNET",
            "FindInfo",
            "Cracking",
            "SeekSlotForSmth",
            "FindPlace",
            "TestForStack",
            "FindMax",
            "TestForBinTree",
            "RemakeTheSong",
            "FindMin",
            "CodeSnake",
            "RushB",
            "DoRandomForm"
        };
        public List<int> complexities = new List<int>
        {
            0,
            31,
            35,
            80,
            40,
            35,
            37,
            85,
            55,
            60,
            90,
            90,
            85,
            70,
            75,
            79,
            65,
            60,
            70
        };
    }
    public class Performers
    {
        public List<string> names = new List<string>
        {
            "temp",
            "Dan",
            "ICL",
            "Yunus",
            "Anton",
            "Ira",
            "Alice",
            "Roberto",
            "OpenAI",
            "Nick",
            "Ferrador",
            "Patrick",
            "Sam",
            "Paul",
            "Mira",
            "Loser",
            "BestCoder",
            "Prick"
        };
        public List<int> V = new List<int>
        {
            0,
            80,
            90,
            100,
            65,
            60,
            50,
            75,
            80,
            54,
            63,
            70,
            68,
            75,
            90,
            80,
        };
       
    }
}
