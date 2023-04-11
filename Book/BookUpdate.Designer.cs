namespace Library.Book
{
    partial class BookUpdate
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
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(109, 247);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 251);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 31;
            label4.Text = "Açıklama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(28, 35);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 30;
            label5.Text = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 83);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 26;
            label1.Text = "Kitap Adı";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(109, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(84, 368);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(41, 319);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 24);
            radioButton1.TabIndex = 33;
            radioButton1.TabStop = true;
            radioButton1.Text = "Evet";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(156, 319);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 24);
            radioButton2.TabIndex = 34;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hayir";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 296);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 35;
            label6.Text = "Kiralandı mı ?";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(109, 200);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 28);
            comboBox2.TabIndex = 39;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(109, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 200);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 37;
            label3.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 141);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 36;
            label2.Text = "Yazar Adı";
            // 
            // BookUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "BookUpdate";
            Text = "BookUpdate";
            Load += BookUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBox5;
        private Label label4;
        private Label label5;
        public Label label1;
        public TextBox textBox2;
        public TextBox textBox1;
        private Button button1;
        private Label label6;
        public RadioButton radioButton1;
        public RadioButton radioButton2;
        private Label label3;
        private Label label2;
        public ComboBox comboBox2;
        public ComboBox comboBox1;
    }
}