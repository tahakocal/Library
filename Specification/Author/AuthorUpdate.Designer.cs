namespace Library.Specification.Author
{
    partial class AuthorUpdate
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(112, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 234);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 22;
            label3.Text = "Açıklama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 173);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 21;
            label2.Text = "Soyisim";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 115);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 20;
            label1.Text = "İsim";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(113, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 73);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 27;
            label4.Text = "Id";
            // 
            // button1
            // 
            button1.Location = new Point(90, 319);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 28;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AuthorUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AuthorUpdate";
            Text = "AuthorUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBox3;
        public TextBox textBox2;
        public TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox textBox4;
        private Label label4;
        private Button button1;
    }
}