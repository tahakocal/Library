namespace Library
{
    partial class MemberUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberUpdate));
            label5 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 42);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 37;
            label5.Text = "Id";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 194);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 194);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 35;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 140);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 34;
            label2.Text = "Soyisim";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 90);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 33;
            label1.Text = "İsim";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(132, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 30;
            // 
            // button1
            // 
            button1.Location = new Point(89, 262);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 29;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MemberUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 332);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MemberUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        public TextBox textBox4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox textBox3;
        public TextBox textBox2;
        public TextBox textBox1;
        private Button button1;
    }
}