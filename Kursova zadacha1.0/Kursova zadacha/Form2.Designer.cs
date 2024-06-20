namespace Kursova_zadacha
{
    partial class Form2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Име";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(54, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(109, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Адрес";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(54, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Телефонен номер";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(54, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(109, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "Имейл";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 247);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(54, 141);
            button1.Name = "button1";
            button1.Size = new Size(109, 41);
            button1.TabIndex = 5;
            button1.Text = "Ипзрати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 267);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Button button1;
    }
}