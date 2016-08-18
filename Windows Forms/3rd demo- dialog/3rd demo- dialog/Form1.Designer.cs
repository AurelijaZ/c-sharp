namespace _3rd_demo__dialog
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonNextForm = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonOpen.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(46, 78);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(139, 75);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open File";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonColor.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColor.Location = new System.Drawing.Point(46, 194);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(139, 75);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Change Background Color ";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonNextForm
            // 
            this.buttonNextForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonNextForm.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextForm.Location = new System.Drawing.Point(46, 300);
            this.buttonNextForm.Name = "buttonNextForm";
            this.buttonNextForm.Size = new System.Drawing.Size(139, 69);
            this.buttonNextForm.TabIndex = 2;
            this.buttonNextForm.Text = "Go to next form";
            this.buttonNextForm.UseVisualStyleBackColor = false;
            this.buttonNextForm.Click += new System.EventHandler(this.buttonNextForm_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(308, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(305, 155);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(662, 442);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonNextForm);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Dialogue & Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonNextForm;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

