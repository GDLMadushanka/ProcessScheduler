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
    public partial class Form2 : Form
    {
        Form1 frm1;
        int counter = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.processNames[counter] = textBox1.Text;
            frm1.burstTimes[counter] = int.Parse(textBox2.Text);
            frm1.ioLine[counter] = int.Parse(textBox3.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            counter++;
            if (counter == 5)
            {
                this.Close();
            }
        }
        public void setform(Form1 cv) 
        {
            frm1 = cv;
        }


    }
}
