using System.Windows.Forms;

namespace LibraryAutomation.Pages
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapÖdünçAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTürleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayınEviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raflarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeleriRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelleriRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarıRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçVerilenKitaplarıRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyelerToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.kitapKayıtToolStripMenuItem,
            this.kitapÖdünçAlmaToolStripMenuItem,
            this.tanımlamalarToolStripMenuItem,
            this.raporlaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üyelerToolStripMenuItem
            // 
            this.üyelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeEkleToolStripMenuItem});
            this.üyelerToolStripMenuItem.Name = "üyelerToolStripMenuItem";
            this.üyelerToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.üyelerToolStripMenuItem.Text = "Üyeler";
            // 
            // üyeEkleToolStripMenuItem
            // 
            this.üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            this.üyeEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.üyeEkleToolStripMenuItem.Text = "Üye İşlemleri";
            this.üyeEkleToolStripMenuItem.Click += new System.EventHandler(this.üyeEkleToolStripMenuItem_Click_1);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personelEkleToolStripMenuItem.Text = "Personel İşlemleri";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click_1);
            // 
            // kitapKayıtToolStripMenuItem
            // 
            this.kitapKayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapListeleToolStripMenuItem});
            this.kitapKayıtToolStripMenuItem.Name = "kitapKayıtToolStripMenuItem";
            this.kitapKayıtToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.kitapKayıtToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapListeleToolStripMenuItem
            // 
            this.kitapListeleToolStripMenuItem.Name = "kitapListeleToolStripMenuItem";
            this.kitapListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kitapListeleToolStripMenuItem.Text = "Kitap Listele";
            this.kitapListeleToolStripMenuItem.Click += new System.EventHandler(this.kitapListeleToolStripMenuItem_Click_1);
            // 
            // kitapÖdünçAlmaToolStripMenuItem
            // 
            this.kitapÖdünçAlmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapVerToolStripMenuItem});
            this.kitapÖdünçAlmaToolStripMenuItem.Name = "kitapÖdünçAlmaToolStripMenuItem";
            this.kitapÖdünçAlmaToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.kitapÖdünçAlmaToolStripMenuItem.Text = "Kitap Ödünç Alma";
            // 
            // kitapVerToolStripMenuItem
            // 
            this.kitapVerToolStripMenuItem.Name = "kitapVerToolStripMenuItem";
            this.kitapVerToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.kitapVerToolStripMenuItem.Text = "Kitap Ödünç İşlemleri";
            this.kitapVerToolStripMenuItem.Click += new System.EventHandler(this.kitapVerToolStripMenuItem_Click_1);
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapTürleriToolStripMenuItem,
            this.yayınEviToolStripMenuItem,
            this.yazarToolStripMenuItem,
            this.dolaplarToolStripMenuItem,
            this.salonlarToolStripMenuItem,
            this.raflarToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // kitapTürleriToolStripMenuItem
            // 
            this.kitapTürleriToolStripMenuItem.Name = "kitapTürleriToolStripMenuItem";
            this.kitapTürleriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kitapTürleriToolStripMenuItem.Text = "Kategoriler";
            this.kitapTürleriToolStripMenuItem.Click += new System.EventHandler(this.kitapTürleriToolStripMenuItem_Click_1);
            // 
            // yayınEviToolStripMenuItem
            // 
            this.yayınEviToolStripMenuItem.Name = "yayınEviToolStripMenuItem";
            this.yayınEviToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yayınEviToolStripMenuItem.Text = "Yayın Evi";
            this.yayınEviToolStripMenuItem.Click += new System.EventHandler(this.yayınEviToolStripMenuItem_Click_1);
            // 
            // yazarToolStripMenuItem
            // 
            this.yazarToolStripMenuItem.Name = "yazarToolStripMenuItem";
            this.yazarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yazarToolStripMenuItem.Text = "Yazar";
            this.yazarToolStripMenuItem.Click += new System.EventHandler(this.yazarToolStripMenuItem_Click_1);
            // 
            // dolaplarToolStripMenuItem
            // 
            this.dolaplarToolStripMenuItem.Name = "dolaplarToolStripMenuItem";
            this.dolaplarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dolaplarToolStripMenuItem.Text = "Dolaplar";
            this.dolaplarToolStripMenuItem.Click += new System.EventHandler(this.dolaplarToolStripMenuItem_Click_1);
            // 
            // salonlarToolStripMenuItem
            // 
            this.salonlarToolStripMenuItem.Name = "salonlarToolStripMenuItem";
            this.salonlarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salonlarToolStripMenuItem.Text = "Salonlar";
            this.salonlarToolStripMenuItem.Click += new System.EventHandler(this.salonlarToolStripMenuItem_Click_1);
            // 
            // raflarToolStripMenuItem
            // 
            this.raflarToolStripMenuItem.Name = "raflarToolStripMenuItem";
            this.raflarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.raflarToolStripMenuItem.Text = "Raflar";
            this.raflarToolStripMenuItem.Click += new System.EventHandler(this.raflarToolStripMenuItem_Click_1);
            // 
            // raporlaToolStripMenuItem
            // 
            this.raporlaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeleriRaporlaToolStripMenuItem,
            this.personelleriRaporlaToolStripMenuItem,
            this.yazarlarıRaporlaToolStripMenuItem,
            this.ödünçVerilenKitaplarıRaporlaToolStripMenuItem});
            this.raporlaToolStripMenuItem.Name = "raporlaToolStripMenuItem";
            this.raporlaToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.raporlaToolStripMenuItem.Text = "Raporlama";
            this.raporlaToolStripMenuItem.Visible = false;
            // 
            // üyeleriRaporlaToolStripMenuItem
            // 
            this.üyeleriRaporlaToolStripMenuItem.Name = "üyeleriRaporlaToolStripMenuItem";
            this.üyeleriRaporlaToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.üyeleriRaporlaToolStripMenuItem.Text = "Üyeleri Raporla";
            // 
            // personelleriRaporlaToolStripMenuItem
            // 
            this.personelleriRaporlaToolStripMenuItem.Name = "personelleriRaporlaToolStripMenuItem";
            this.personelleriRaporlaToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.personelleriRaporlaToolStripMenuItem.Text = "Personelleri Raporla";
            // 
            // yazarlarıRaporlaToolStripMenuItem
            // 
            this.yazarlarıRaporlaToolStripMenuItem.Name = "yazarlarıRaporlaToolStripMenuItem";
            this.yazarlarıRaporlaToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.yazarlarıRaporlaToolStripMenuItem.Text = "Yazarları Raporla";
            // 
            // ödünçVerilenKitaplarıRaporlaToolStripMenuItem
            // 
            this.ödünçVerilenKitaplarıRaporlaToolStripMenuItem.Name = "ödünçVerilenKitaplarıRaporlaToolStripMenuItem";
            this.ödünçVerilenKitaplarıRaporlaToolStripMenuItem.Size = new System.Drawing.Size(300, 26);
            this.ödünçVerilenKitaplarıRaporlaToolStripMenuItem.Text = "Ödünç Verilen Kitapları Raporla";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 569);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Anasayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem üyelerToolStripMenuItem;
        private ToolStripMenuItem üyeEkleToolStripMenuItem;
        private ToolStripMenuItem personelToolStripMenuItem;
        private ToolStripMenuItem personelEkleToolStripMenuItem;
        private ToolStripMenuItem kitapKayıtToolStripMenuItem;
        private ToolStripMenuItem kitapListeleToolStripMenuItem;
        private ToolStripMenuItem kitapÖdünçAlmaToolStripMenuItem;
        private ToolStripMenuItem kitapVerToolStripMenuItem;
        private ToolStripMenuItem raporlaToolStripMenuItem;
        private ToolStripMenuItem üyeleriRaporlaToolStripMenuItem;
        private ToolStripMenuItem personelleriRaporlaToolStripMenuItem;
        private ToolStripMenuItem yazarlarıRaporlaToolStripMenuItem;
        private ToolStripMenuItem ödünçVerilenKitaplarıRaporlaToolStripMenuItem;
        private ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private ToolStripMenuItem kitapTürleriToolStripMenuItem;
        private ToolStripMenuItem yayınEviToolStripMenuItem;
        private ToolStripMenuItem yazarToolStripMenuItem;
        private ToolStripMenuItem dolaplarToolStripMenuItem;
        private ToolStripMenuItem salonlarToolStripMenuItem;
        private ToolStripMenuItem raflarToolStripMenuItem;
    }
}