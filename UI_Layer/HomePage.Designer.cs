namespace UI_Layer
{
    partial class HomePage
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
            menus = new MenuStrip();
            anaSayfa = new ToolStripMenuItem();
            kisiselBilgiler = new ToolStripMenuItem();
            boyToolStripMenuItem = new ToolStripMenuItem();
            kişiselBilgileriGüncelleToolStripMenuItem = new ToolStripMenuItem();
            şifreGünceleToolStripMenuItem = new ToolStripMenuItem();
            ogunler = new ToolStripMenuItem();
            kahvaltıToolStripMenuItem = new ToolStripMenuItem();
            öğlenToolStripMenuItem = new ToolStripMenuItem();
            akşamToolStripMenuItem = new ToolStripMenuItem();
            araToolStripMenuItem = new ToolStripMenuItem();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            günlükToolStripMenuItem = new ToolStripMenuItem();
            haftalıkToolStripMenuItem = new ToolStripMenuItem();
            menus.SuspendLayout();
            SuspendLayout();
            // 
            // menus
            // 
            menus.BackColor = Color.PaleVioletRed;
            menus.Items.AddRange(new ToolStripItem[] { anaSayfa, kisiselBilgiler, ogunler, raporlarToolStripMenuItem });
            menus.Location = new Point(0, 0);
            menus.Name = "menus";
            menus.Size = new Size(800, 24);
            menus.TabIndex = 41;
            menus.Text = "menus";
            // 
            // anaSayfa
            // 
            anaSayfa.Name = "anaSayfa";
            anaSayfa.Size = new Size(71, 20);
            anaSayfa.Text = "Ana Sayfa";
            anaSayfa.Click += anaSayfa_Click;
            // 
            // kisiselBilgiler
            // 
            kisiselBilgiler.BackColor = Color.PaleVioletRed;
            kisiselBilgiler.DropDownItems.AddRange(new ToolStripItem[] { boyToolStripMenuItem, kişiselBilgileriGüncelleToolStripMenuItem, şifreGünceleToolStripMenuItem });
            kisiselBilgiler.Name = "kisiselBilgiler";
            kisiselBilgiler.Size = new Size(90, 20);
            kisiselBilgiler.Text = "Kişisel Bilgiler";
            kisiselBilgiler.Click += kisiselBilgiler_Click;
            // 
            // boyToolStripMenuItem
            // 
            boyToolStripMenuItem.BackColor = Color.PaleVioletRed;
            boyToolStripMenuItem.Name = "boyToolStripMenuItem";
            boyToolStripMenuItem.Size = new Size(197, 22);
            boyToolStripMenuItem.Text = "Hedef Güncelle";
            boyToolStripMenuItem.Click += boyToolStripMenuItem_Click;
            // 
            // kişiselBilgileriGüncelleToolStripMenuItem
            // 
            kişiselBilgileriGüncelleToolStripMenuItem.BackColor = Color.PaleVioletRed;
            kişiselBilgileriGüncelleToolStripMenuItem.Name = "kişiselBilgileriGüncelleToolStripMenuItem";
            kişiselBilgileriGüncelleToolStripMenuItem.Size = new Size(197, 22);
            kişiselBilgileriGüncelleToolStripMenuItem.Text = "Kişisel Bilgileri Güncelle";
            kişiselBilgileriGüncelleToolStripMenuItem.Click += kişiselBilgileriGüncelleToolStripMenuItem_Click;
            // 
            // şifreGünceleToolStripMenuItem
            // 
            şifreGünceleToolStripMenuItem.BackColor = Color.PaleVioletRed;
            şifreGünceleToolStripMenuItem.Name = "şifreGünceleToolStripMenuItem";
            şifreGünceleToolStripMenuItem.Size = new Size(197, 22);
            şifreGünceleToolStripMenuItem.Text = "Şifre Güncele";
            şifreGünceleToolStripMenuItem.Click += şifreGünceleToolStripMenuItem_Click;
            // 
            // ogunler
            // 
            ogunler.BackColor = Color.PaleVioletRed;
            ogunler.DropDownItems.AddRange(new ToolStripItem[] { kahvaltıToolStripMenuItem, öğlenToolStripMenuItem, akşamToolStripMenuItem, araToolStripMenuItem });
            ogunler.Name = "ogunler";
            ogunler.Size = new Size(73, 20);
            ogunler.Text = "Öğün Ekle";
            // 
            // kahvaltıToolStripMenuItem
            // 
            kahvaltıToolStripMenuItem.BackColor = Color.PaleVioletRed;
            kahvaltıToolStripMenuItem.Name = "kahvaltıToolStripMenuItem";
            kahvaltıToolStripMenuItem.Size = new Size(176, 22);
            kahvaltıToolStripMenuItem.Text = "Kahvaltı Ekle";
            kahvaltıToolStripMenuItem.Click += kahvaltıToolStripMenuItem_Click;
            // 
            // öğlenToolStripMenuItem
            // 
            öğlenToolStripMenuItem.BackColor = Color.PaleVioletRed;
            öğlenToolStripMenuItem.Name = "öğlenToolStripMenuItem";
            öğlenToolStripMenuItem.Size = new Size(176, 22);
            öğlenToolStripMenuItem.Text = "Öğlen Yemeği Ekle";
            öğlenToolStripMenuItem.Click += öğlenToolStripMenuItem_Click;
            // 
            // akşamToolStripMenuItem
            // 
            akşamToolStripMenuItem.BackColor = Color.PaleVioletRed;
            akşamToolStripMenuItem.Name = "akşamToolStripMenuItem";
            akşamToolStripMenuItem.Size = new Size(176, 22);
            akşamToolStripMenuItem.Text = "Akşam Yemeği Ekle";
            akşamToolStripMenuItem.Click += akşamToolStripMenuItem_Click;
            // 
            // araToolStripMenuItem
            // 
            araToolStripMenuItem.BackColor = Color.PaleVioletRed;
            araToolStripMenuItem.Name = "araToolStripMenuItem";
            araToolStripMenuItem.Size = new Size(176, 22);
            araToolStripMenuItem.Text = "Ara Öğün Ekle";
            araToolStripMenuItem.Click += araToolStripMenuItem_Click;
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.BackColor = Color.PaleVioletRed;
            raporlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { günlükToolStripMenuItem, haftalıkToolStripMenuItem });
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(63, 20);
            raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // günlükToolStripMenuItem
            // 
            günlükToolStripMenuItem.BackColor = Color.PaleVioletRed;
            günlükToolStripMenuItem.Name = "günlükToolStripMenuItem";
            günlükToolStripMenuItem.Size = new Size(182, 22);
            günlükToolStripMenuItem.Text = "Aylık ve Haftalık";
            günlükToolStripMenuItem.Click += günlükToolStripMenuItem_Click;
            // 
            // haftalıkToolStripMenuItem
            // 
            haftalıkToolStripMenuItem.BackColor = Color.PaleVioletRed;
            haftalıkToolStripMenuItem.Name = "haftalıkToolStripMenuItem";
            haftalıkToolStripMenuItem.Size = new Size(182, 22);
            haftalıkToolStripMenuItem.Text = "Yemek İstatistiklerim";
            haftalıkToolStripMenuItem.Click += haftalıkToolStripMenuItem_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(800, 450);
            Controls.Add(menus);
            IsMdiContainer = true;
            Name = "HomePage";
            Text = "HomePage";
            FormClosed += HomePage_FormClosed;
            Load += HomePage_Load;
            menus.ResumeLayout(false);
            menus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menus;
        private ToolStripMenuItem anaSayfa;
        private ToolStripMenuItem kisiselBilgiler;
        private ToolStripMenuItem ogunler;
        private ToolStripMenuItem kahvaltıToolStripMenuItem;
        private ToolStripMenuItem öğlenToolStripMenuItem;
        private ToolStripMenuItem akşamToolStripMenuItem;
        private ToolStripMenuItem araToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private ToolStripMenuItem günlükToolStripMenuItem;
        private ToolStripMenuItem haftalıkToolStripMenuItem;
        private ToolStripMenuItem boyToolStripMenuItem;
        private ToolStripMenuItem kişiselBilgileriGüncelleToolStripMenuItem;
        private ToolStripMenuItem şifreGünceleToolStripMenuItem;
    }
}