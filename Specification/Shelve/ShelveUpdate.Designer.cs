using System.Drawing;
using System.Windows.Forms;

namespace LibraryAutomation.Specification.Shelve
{
    partial class ShelveUpdate
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
            button1 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(79, 263);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 60;
            button1.Text = "Guncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 89);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 59;
            label4.Text = "Id";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 58;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 57;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(99, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 189);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 55;
            label2.Text = "Raf Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 131);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 54;
            label1.Text = "Raf No";
            // 
            // ShelveUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ShelveUpdate";
            Text = "ShelveUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        public TextBox textBox3;
        public TextBox textBox2;
        public TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}