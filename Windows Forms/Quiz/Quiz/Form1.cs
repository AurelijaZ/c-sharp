using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        int timeLeft = 60;
        bool q1Correct = false;
        bool q2Correct = false;
        bool q3Correct = false;

        public Form1()
        {
            //make the information invisible to the users
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void radioButtonQ1a1_CheckedChanged(object sender, EventArgs e)
        {
            //if the answer is wrong, it will show a cross
            if (radioButtonQ1a1.Checked)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "\u00fb"; //cross
                q1Correct = false;
            }
        }

        private void radioButtonQ1a2_CheckedChanged(object sender, EventArgs e)
        {
            //if the answer is correct, it will have a tick
            if (radioButtonQ1a2.Checked)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "\u00fc"; //tick
                q1Correct = true;
            }
        }

        private void radioButtonQ1a3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1a3.Checked)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "\u00fb"; //cross
                q1Correct = false;

            }
        }

        private void radioButtonQ2a1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2a1.Checked)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "\u00fc"; //tick
                q2Correct = true;
            }

        }

        private void radioButtonQ2a2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2a2.Checked)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "\u00fb"; //cross
                q2Correct = false;
            }
        }

        private void radioButtonQ2a3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2a3.Checked)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "\u00fb"; //cross
                q2Correct = false;
            }
        }

        private void radioButtonQ3a1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3a1.Checked)
            {
                label5.ForeColor = Color.Green;
                label5.Text = "\u00fc"; //tick
                q3Correct = true;
            }
        }

        private void radioButtonQ3a2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3a2.Checked)
            {
                label5.ForeColor = Color.Red;
                label5.Text = "\u00fb"; //cross
                q3Correct = false;
            }
        }

        private void radioButtonQ3a3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3a3.Checked)
            {
                label5.ForeColor = Color.Red;
                label5.Text = "\u00fb"; //cross
                q3Correct = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (q1Correct && q2Correct && q3Correct)
            {
                //get the timer to stop if all q are correct
                timer1.Stop();
                MessageBox.Show("You got everythign right!");
            }
            else if (timeLeft > 0)
            {
                //update and display time left
                timeLeft--;
                timerLabel.Text = timeLeft + "seconds";
            }
            else
            {
                //if the user runs out of time
                timer1.Stop();
                MessageBox.Show("You ran out of time.", "Sorry");
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //make a start button to function
            timer1.Start();
            buttonStart.Enabled = false; 
            pictureBox1.Visible = true; //make the box invisible to the user
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            
        }
    } //end 
}
