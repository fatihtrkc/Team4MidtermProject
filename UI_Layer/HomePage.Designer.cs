﻿namespace UI_Layer
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
            ogunler = new ToolStripMenuItem();
            kahvaltıToolStripMenuItem = new ToolStripMenuItem();
            öğlenToolStripMenuItem = new ToolStripMenuItem();
            akşamToolStripMenuItem = new ToolStripMenuItem();
            araToolStripMenuItem = new ToolStripMenuItem();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            günlükToolStripMenuItem = new ToolStripMenuItem();
            haftalıkToolStripMenuItem = new ToolStripMenuItem();
            aylıkToolStripMenuItem = new ToolStripMenuItem();
            menus.SuspendLayout();
            SuspendLayout();
            // 
            // menus
            // 
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
            kisiselBilgiler.Name = "kisiselBilgiler";
            kisiselBilgiler.Size = new Size(90, 20);
            kisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // ogunler
            // 
            ogunler.DropDownItems.AddRange(new ToolStripItem[] { kahvaltıToolStripMenuItem, öğlenToolStripMenuItem, akşamToolStripMenuItem, araToolStripMenuItem });
            ogunler.Name = "ogunler";
            ogunler.Size = new Size(73, 20);
            ogunler.Text = "Öğün Ekle";
            // 
            // kahvaltıToolStripMenuItem
            // 
            kahvaltıToolStripMenuItem.Name = "kahvaltıToolStripMenuItem";
            kahvaltıToolStripMenuItem.Size = new Size(176, 22);
            kahvaltıToolStripMenuItem.Text = "Kahvaltı Ekle";
            kahvaltıToolStripMenuItem.Click += kahvaltıToolStripMenuItem_Click;
            // 
            // öğlenToolStripMenuItem
            // 
            öğlenToolStripMenuItem.Name = "öğlenToolStripMenuItem";
            öğlenToolStripMenuItem.Size = new Size(176, 22);
            öğlenToolStripMenuItem.Text = "Öğlen Yemeği Ekle";
            öğlenToolStripMenuItem.Click += öğlenToolStripMenuItem_Click;
            // 
            // akşamToolStripMenuItem
            // 
            akşamToolStripMenuItem.Name = "akşamToolStripMenuItem";
            akşamToolStripMenuItem.Size = new Size(176, 22);
            akşamToolStripMenuItem.Text = "Akşam Yemeği Ekle";
            akşamToolStripMenuItem.Click += akşamToolStripMenuItem_Click;
            // 
            // araToolStripMenuItem
            // 
            araToolStripMenuItem.Name = "araToolStripMenuItem";
            araToolStripMenuItem.Size = new Size(176, 22);
            araToolStripMenuItem.Text = "Ara Öğün Ekle";
            araToolStripMenuItem.Click += araToolStripMenuItem_Click;
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { günlükToolStripMenuItem, haftalıkToolStripMenuItem, aylıkToolStripMenuItem });
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(63, 20);
            raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // günlükToolStripMenuItem
            // 
            günlükToolStripMenuItem.Name = "günlükToolStripMenuItem";
            günlükToolStripMenuItem.Size = new Size(115, 22);
            günlükToolStripMenuItem.Text = "Günlük";
            // 
            // haftalıkToolStripMenuItem
            // 
            haftalıkToolStripMenuItem.Name = "haftalıkToolStripMenuItem";
            haftalıkToolStripMenuItem.Size = new Size(115, 22);
            haftalıkToolStripMenuItem.Text = "Haftalık";
            // 
            // aylıkToolStripMenuItem
            // 
            aylıkToolStripMenuItem.Name = "aylıkToolStripMenuItem";
            aylıkToolStripMenuItem.Size = new Size(115, 22);
            aylıkToolStripMenuItem.Text = "Aylık";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menus);
            IsMdiContainer = true;
            Name = "HomePage";
            Text = "HomePage";
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
        private ToolStripMenuItem aylıkToolStripMenuItem;
    }
}