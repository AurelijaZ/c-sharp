﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3rd_demo__dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //Open text file
            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.Filter = "Text files (*.txt)| *.txt|All Files (*.*)|*.*";


            if ((openFileDialog1.ShowDialog() == DialogResult.OK) &&
                (openFileDialog1.FileName.Length > 0))
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void buttonColor_Click(object sender, EventArgs e) //event
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void buttonNextForm_Click(object sender, EventArgs e)
        {
            Form2 nextForm = new Form2();
            nextForm.Show();
            this.Hide(); //hiding the current form when pressing the button

            FormState.previousPage = this;
        }
    }
        public static class FormState
        {
            public static Form previousPage;
        }
    }
    

