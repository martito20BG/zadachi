namespace Kursova_zadacha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column10 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Име";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(45, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(52, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Бройка";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(45, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(107, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "Цена на бройка";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(45, 94);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(107, 23);
            textBox5.TabIndex = 4;
            textBox5.Text = "Гаранция";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(103, 152);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // button1
            // 
            button1.Location = new Point(45, 181);
            button1.Name = "button1";
            button1.Size = new Size(107, 41);
            button1.TabIndex = 6;
            button1.Text = "Изпрати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 262);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column10, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dataGridView1.Location = new Point(201, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(943, 232);
            dataGridView1.TabIndex = 8;
            // 
            // Column10
            // 
            Column10.HeaderText = "Id";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Product Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Product Warranty";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Product PriceForOne";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Product Amount";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Manufacturer Name";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Manufacturer Address";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Manufacturer TelephoneNumber";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Manufacturer Email";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Total price";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(45, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(107, 23);
            comboBox1.TabIndex = 9;
            comboBox1.Tag = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(12, 228);
            button2.Name = "button2";
            button2.Size = new Size(166, 23);
            button2.TabIndex = 10;
            button2.Text = "Добави Производител";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(45, 47);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 11;
            label1.Text = "Производител";
            // 
            // button3
            // 
            button3.Location = new Point(200, 235);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1146, 263);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private NumericUpDown numericUpDown1;
        private ImageList imageList1;
        private ImageList imageList2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button button2;
        private Label label1;
        private Button button3;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}