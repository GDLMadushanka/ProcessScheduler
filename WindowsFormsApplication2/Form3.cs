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
   
    public partial class Form3 : Form
    {
        Form1 frm1 =new Form1();
        bool state = true;
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(state==false){
                
                timer1.Enabled = false;
                this.Hide();
                frm1.Show();
            }
            state = false;
        }
     
    }
}
