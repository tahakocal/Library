namespace Library.Book
{
    partial class BookRemove
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
            label5 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(41, 44);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 19;
            label5.Text = "Id";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(122, 200);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(41, 204);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 17;
            label3.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(41, 145);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 16;
            label2.Text = "Yazar Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(41, 92);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 15;
            label1.Text = "Kitap Adı";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(122, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(122, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(122, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(97, 377);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(122, 256);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(41, 260);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 20;
            label4.Text = "Açıklama";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(97, 301);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 38;
            label6.Text = "Kiralandı mı ?";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Enabled = false;
            radioButton2.Location = new Point(179, 324);
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
            radioButton1.Enabled = false;
            radioButton1.Location = new Point(64, 324);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 24);
            radioButton1.TabIndex = 36;
            radioButton1.TabStop = true;
            radioButton1.Text = "Evet";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // BookRemove
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 443);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookRemove";
            Text = "BookRemove";
            Load += BookRemove_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        public TextBox textBox4;
        private Label label3;
        private Label label2;
        public Label label1;
        public TextBox textBox3;
        public TextBox textBox2;
        public TextBox textBox1;
        private Button button1;
        public TextBox textBox5;
        private Label label4;
        private Label label6;
        public RadioButton radioButton2;
        public RadioButton radioButton1;
    }
}