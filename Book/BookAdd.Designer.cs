namespace Library.Book
{
    partial class BookAdd
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(109, 196);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 200);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 31;
            label4.Text = "Açıklama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 144);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 28;
            label3.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 85);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 27;
            label2.Text = "Yazar Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 26;
            label1.Text = "Kitap Adı";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(86, 302);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(109, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 33;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(109, 141);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 28);
            comboBox2.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 241);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 38;
            label6.Text = "Kiralandı mı ?";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(162, 264);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 24);
            radioButton2.TabIndex = 37;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hayir";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(47, 264);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 24);
            radioButton1.TabIndex = 36;
            radioButton1.TabStop = true;
            radioButton1.Text = "Evet";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // BookAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 369);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Name = "BookAdd";
            Text = "BookAdd";
            Load += BookAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBox5;
        private Label label4;
        private Label label3;
        private Label label2;
        public Label label1;
        public TextBox textBox2;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        public RadioButton radioButton2;
        public RadioButton radioButton1;
    }
}