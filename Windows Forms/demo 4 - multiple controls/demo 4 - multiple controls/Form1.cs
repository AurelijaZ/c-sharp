using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_4___multiple_controls
{
    public partial class Form1 : Form
    {
        Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                Label numberLabel = control as Label;

                if (numberLabel != null) //if number label exist
                {
                    int randomNumber = random.Next(1, 59);
                    numberLabel.Text = randomNumber.ToString(); //.text is always a string 
                }
            }
        }
    }
}
