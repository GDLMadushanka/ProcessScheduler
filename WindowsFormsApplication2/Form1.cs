using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public String[] processNames = new String[5];
        public int[] runTime = new int[5];
        public int[] burstTimes = new int[5];
        public int[] ioLine = new int[5];
      

        Queue<int> readyQueue= new Queue<int>(5);
        Queue<int> blockedQueue = new Queue<int>(5);
        
        public int[] suspendedQueue = new int[5];

        

        int readyCount = 5;
        int blockedCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.setform(this);
            frm2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = processNames[0].ToString()+" (ready)";
          
            pro1.Maximum = burstTimes[0];
            label6.Text = processNames[1].ToString() + " (ready)";
           
            pro2.Maximum = burstTimes[1];
            label7.Text = processNames[2].ToString() + " (ready)";
        
            pro3.Maximum = burstTimes[2];
            label8.Text = processNames[3].ToString() + " (ready)";
           
            pro4.Maximum = burstTimes[3];
            label9.Text = processNames[4].ToString() + " (ready)";
          
            pro5.Maximum = burstTimes[4];

            ready.Text = processNames[0] + " " + processNames[1] + " " + processNames[2] + " " + processNames[3] + " " + processNames[4];
            for (int i = 0; i < 5; i++) 
            {
                readyQueue.Enqueue(i);
            }
            timer1.Enabled = true;
        }

        private void ready_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (readyCount <= 0)
            {
                timer1.Enabled = false;
            }
            else
            {
                int i = readyQueue.Dequeue();
                updateReadyQueue();
                readyCount--;
                if (runTime[i] +1 == ioLine[i]) 
                {
                    blockedQueue.Enqueue(i);
                    blockedCount++;
                    updateBlockedQueue();
                    switch(i)
                    {
                        case 0: { label5.Text = processNames[0].ToString() + " (blocked)"; break; }
                        case 1: { label6.Text = processNames[1].ToString() + " (blocked)"; break; }
                        case 2: { label7.Text = processNames[2].ToString() + " (blocked)"; break; }
                        case 3: { label8.Text = processNames[3].ToString() + " (blocked)"; break; }
                        case 4: { label9.Text = processNames[4].ToString() + " (blocked)"; break; }

                    }
                }
                else if (runTime[i] < burstTimes[i])
                {
                    running.Text = processNames[i];
                    runTime[i]++;
                    incfProgressbar(i);
                    readyQueue.Enqueue(i);
                    updateReadyQueue();
                    readyCount++;
                }
            }
            mm.Value = readyCount + blockedCount;
          
        }
        public void updateReadyQueue() 
        {
            ready.Text = "";
            int[] temp = new int[5];
            readyQueue.CopyTo(temp,0);
            for (int i = 0; i < readyCount; i++) 
            {
                    ready.Text += " " + processNames[temp[i]];
            }
        }

        public void updateBlockedQueue()
        {
            blocked.Text = "";
            int[] temp = new int[5];
            blockedQueue.CopyTo(temp, 0);
            for (int i = 0; i < blockedCount; i++)
            {
                blocked.Text += " " + processNames[temp[i]];
            }
        }

        public void incfProgressbar(int i)
        {
            switch (i) 
            {
                case 0: { pro1.Value++; if (pro1.Value == burstTimes[0]) { label5.Text = processNames[0] + " (finished)"; } break; }
                case 1: { pro2.Value++; if (pro2.Value == burstTimes[1]) { label6.Text = processNames[1] + " (finished)"; } break; }
                case 2: { pro3.Value++; if (pro3.Value == burstTimes[2]) { label7.Text = processNames[2] + " (finished)"; } break; }
                case 3: { pro4.Value++; if (pro4.Value == burstTimes[3]) { label8.Text = processNames[3] + " (finished)"; } break; }
                case 4: { pro5.Value++; if (pro5.Value == burstTimes[4]) { label9.Text = processNames[4] + " (finished)"; } break; }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int temp = blockedQueue.Dequeue();
                blockedCount--;
                updateBlockedQueue();
                readyQueue.Enqueue(temp);
                readyCount++;
                updateReadyQueue();
                textBox1.Text = "";
                ++runTime[temp];
                incfProgressbar(temp);
                timer1.Enabled = true;

                switch (temp)
                {
                    case 0: { label5.Text = processNames[0].ToString() + " (ready)"; break; }
                    case 1: { label6.Text = processNames[1].ToString() + " (ready)"; break; }
                    case 2: { label7.Text = processNames[2].ToString() + " (ready)"; break; }
                    case 3: { label8.Text = processNames[3].ToString() + " (ready)"; break; }
                    case 4: { label9.Text = processNames[4].ToString() + " (ready)"; break; }

                }
            }

        }

        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                timer1.Interval += 50;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 100)
            {
                timer1.Interval -= 50;
            }
        }

        
    }

}
