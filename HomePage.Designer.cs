namespace Library
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
            menuStrip1 = new MenuStrip();
            üyelerToolStripMenuItem = new ToolStripMenuItem();
            üyeEkleToolStripMenuItem = new ToolStripMenuItem();
            personelToolStripMenuItem = new ToolStripMenuItem();
            personelEkleToolStripMenuItem = new ToolStripMenuItem();
            kitapKayıtToolStripMenuItem = new ToolStripMenuItem();
            kitapListeleToolStripMenuItem = new ToolStripMenuItem();
            kitapÖdünçAlmaToolStripMenuItem = new ToolStripMenuItem();
            kitapVerToolStripMenuItem = new ToolStripMenuItem();
            kitapGeriAlmaToolStripMenuItem = new ToolStripMenuItem();
            raporlaToolStripMenuItem = new ToolStripMenuItem();
            üyeleriRaporlaToolStripMenuItem = new ToolStripMenuItem();
            personelleriRaporlaToolStripMenuItem = new ToolStripMenuItem();
            yazarlarıRaporlaToolStripMenuItem = new ToolStripMenuItem();
            ödünçVerilenKitaplarıRaporlaToolStripMenuItem = new ToolStripMenuItem();
            tanımlamalarToolStripMenuItem = new ToolStripMenuItem();
            kitapTürleriToolStripMenuItem = new ToolStripMenuItem();
            yayınEviToolStripMenuItem = new ToolStripMenuItem();
            yazarToolStripMenuItem = new ToolStripMenuItem();
            dolaplarToolStripMenuItem = new ToolStripMenuItem();
            salonlarToolStripMenuItem = new ToolStripMenuItem();
            raflarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { üyelerToolStripMenuItem, personelToolStripMenuItem, kitapKayıtToolStripMenuItem, kitapÖdünçAlmaToolStripMenuItem, raporlaToolStripMenuItem, tanımlamalarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1193, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // üyelerToolStripMenuItem
            // 
            üyelerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { üyeEkleToolStripMenuItem });
            üyelerToolStripMenuItem.Name = "üyelerToolStripMenuItem";
            üyelerToolStripMenuItem.Size = new Size(65, 24);
            üyelerToolStripMenuItem.Text = "Üyeler";
            // 
            // üyeEkleToolStripMenuItem
            // 
            üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            üyeEkleToolStripMenuItem.Size = new Size(224, 26);
            üyeEkleToolStripMenuItem.Text = "Üye İşlemleri";
            üyeEkleToolStripMenuItem.Click += üyeEkleToolStripMenuItem_Click;
            // 
            // personelToolStripMenuItem
            // 
            personelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personelEkleToolStripMenuItem });
            personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            personelToolStripMenuItem.Size = new Size(78, 24);
            personelToolStripMenuItem.Text = "Personel";
            // 
            // personelEkleToolStripMenuItem
            // 
            personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            personelEkleToolStripMenuItem.Size = new Size(224, 26);
            personelEkleToolStripMenuItem.Text = "Personel İşlemleri";
            personelEkleToolStripMenuItem.Click += personelEkleToolStripMenuItem_Click;
            // 
            // kitapKayıtToolStripMenuItem
            // 
            kitapKayıtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapListeleToolStripMenuItem });
            kitapKayıtToolStripMenuItem.Name = "kitapKayıtToolStripMenuItem";
            kitapKayıtToolStripMenuItem.Size = new Size(118, 24);
            kitapKayıtToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapListeleToolStripMenuItem
            // 
            kitapListeleToolStripMenuItem.Name = "kitapListeleToolStripMenuItem";
            kitapListeleToolStripMenuItem.Size = new Size(224, 26);
            kitapListeleToolStripMenuItem.Text = "Kitap Listele";
            kitapListeleToolStripMenuItem.Click += kitapListeleToolStripMenuItem_Click;
            // 
            // kitapÖdünçAlmaToolStripMenuItem
            // 
            kitapÖdünçAlmaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapVerToolStripMenuItem, kitapGeriAlmaToolStripMenuItem });
            kitapÖdünçAlmaToolStripMenuItem.Name = "kitapÖdünçAlmaToolStripMenuItem";
            kitapÖdünçAlmaToolStripMenuItem.Size = new Size(144, 24);
            kitapÖdünçAlmaToolStripMenuItem.Text = "Kitap Ödünç Alma";
            // 
            // kitapVerToolStripMenuItem
            // 
            kitapVerToolStripMenuItem.Name = "kitapVerToolStripMenuItem";
            kitapVerToolStripMenuItem.Size = new Size(197, 26);
            kitapVerToolStripMenuItem.Text = "Kitap Ver";
            kitapVerToolStripMenuItem.Click += kitapVerToolStripMenuItem_Click;
            // 
            // kitapGeriAlmaToolStripMenuItem
            // 
            kitapGeriAlmaToolStripMenuItem.Name = "kitapGeriAlmaToolStripMenuItem";
            kitapGeriAlmaToolStripMenuItem.Size = new Size(197, 26);
            kitapGeriAlmaToolStripMenuItem.Text = "Kitap Geri Alma";
            kitapGeriAlmaToolStripMenuItem.Click += kitapGeriAlmaToolStripMenuItem_Click;
            // 
            // raporlaToolStripMenuItem
            // 
            raporlaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { üyeleriRaporlaToolStripMenuItem, personelleriRaporlaToolStripMenuItem, yazarlarıRaporlaToolStripMenuItem, ödünçVerilenKitaplarıRaporlaToolStripMenuItem });
            raporlaToolStripMenuItem.Name = "raporlaToolStripMenuItem";
            raporlaToolStripMenuItem.Size = new Size(96, 24);
            raporlaToolStripMenuItem.Text = "Raporlama";
            // 
            // üyeleriRaporlaToolStripMenuItem
            // 
            üyeleriRaporlaToolStripMenuItem.Name = "üyeleriRaporlaToolStripMenuItem";
            üyeleriRaporlaToolStripMenuItem.Size = new Size(300, 26);
            üyeleriRaporlaToolStripMenuItem.Text = "Üyeleri Raporla";
            üyeleriRaporlaToolStripMenuItem.Click += üyeleriRaporlaToolStripMenuItem_Click;
            // 
            // personelleriRaporlaToolStripMenuItem
            // 
            personelleriRaporlaToolStripMenuItem.Name = "personelleriRaporlaToolStripMenuItem";
            personelleriRaporlaToolStripMenuItem.Size = new Size(300, 26);
            personelleriRaporlaToolStripMenuItem.Text = "Personelleri Raporla";
            personelleriRaporlaToolStripMenuItem.Click += personelleriRaporlaToolStripMenuItem_Click;
            // 
            // yazarlarıRaporlaToolStripMenuItem
            // 
            yazarlarıRaporlaToolStripMenuItem.Name = "yazarlarıRaporlaToolStripMenuItem";
            yazarlarıRaporlaToolStripMenuItem.Size = new Size(300, 26);
            yazarlarıRaporlaToolStripMenuItem.Text = "Yazarları Raporla";
            yazarlarıRaporlaToolStripMenuItem.Click += yazarlarıRaporlaToolStripMenuItem_Click;
            // 
            // ödünçVerilenKitaplarıRaporlaToolStripMenuItem
            // 
            ödünçVerilenKitaplarıRaporlaToolStripMenuItem.Name = "ödünçVerilenKitaplarıRaporlaToolStripMenuItem";
            ödünçVerilenKitaplarıRaporlaToolStripMenuItem.Size = new Size(300, 26);
            ödünçVerilenKitaplarıRaporlaToolStripMenuItem.Text = "Ödünç Verilen Kitapları Raporla";
            ödünçVerilenKitaplarıRaporlaToolStripMenuItem.Click += ödünçVerilenKitaplarıRaporlaToolStripMenuItem_Click;
            // 
            // tanımlamalarToolStripMenuItem
            // 
            tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapTürleriToolStripMenuItem, yayınEviToolStripMenuItem, yazarToolStripMenuItem, dolaplarToolStripMenuItem, salonlarToolStripMenuItem, raflarToolStripMenuItem });
            tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            tanımlamalarToolStripMenuItem.Size = new Size(112, 24);
            tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // kitapTürleriToolStripMenuItem
            // 
            kitapTürleriToolStripMenuItem.Name = "kitapTürleriToolStripMenuItem";
            kitapTürleriToolStripMenuItem.Size = new Size(173, 26);
            kitapTürleriToolStripMenuItem.Text = "Kitap Türleri";
            kitapTürleriToolStripMenuItem.Click += kitapTürleriToolStripMenuItem_Click;
            // 
            // yayınEviToolStripMenuItem
            // 
            yayınEviToolStripMenuItem.Name = "yayınEviToolStripMenuItem";
            yayınEviToolStripMenuItem.Size = new Size(173, 26);
            yayınEviToolStripMenuItem.Text = "Yayın Evi";
            yayınEviToolStripMenuItem.Click += yayınEviToolStripMenuItem_Click;
            // 
            // yazarToolStripMenuItem
            // 
            yazarToolStripMenuItem.Name = "yazarToolStripMenuItem";
            yazarToolStripMenuItem.Size = new Size(173, 26);
            yazarToolStripMenuItem.Text = "Yazar";
            yazarToolStripMenuItem.Click += yazarToolStripMenuItem_Click;
            // 
            // dolaplarToolStripMenuItem
            // 
            dolaplarToolStripMenuItem.Name = "dolaplarToolStripMenuItem";
            dolaplarToolStripMenuItem.Size = new Size(173, 26);
            dolaplarToolStripMenuItem.Text = "Dolaplar";
            dolaplarToolStripMenuItem.Click += dolaplarToolStripMenuItem_Click;
            // 
            // salonlarToolStripMenuItem
            // 
            salonlarToolStripMenuItem.Name = "salonlarToolStripMenuItem";
            salonlarToolStripMenuItem.Size = new Size(173, 26);
            salonlarToolStripMenuItem.Text = "Salonlar";
            salonlarToolStripMenuItem.Click += salonlarToolStripMenuItem_Click;
            // 
            // raflarToolStripMenuItem
            // 
            raflarToolStripMenuItem.Name = "raflarToolStripMenuItem";
            raflarToolStripMenuItem.Size = new Size(173, 26);
            raflarToolStripMenuItem.Text = "Raflar";
            raflarToolStripMenuItem.Click += raflarToolStripMenuItem_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.librayHomePage;
            ClientSize = new Size(1193, 711);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += HomePage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripMenuItem kitapGeriAlmaToolStripMenuItem;
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