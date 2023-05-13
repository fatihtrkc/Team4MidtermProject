namespace UI_Layer
{
    partial class AdminPage
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
            addFood = new ToolStripMenuItem();
            addCategory = new ToolStripMenuItem();
            menus.SuspendLayout();
            SuspendLayout();
            // 
            // menus
            // 
            menus.BackColor = Color.PaleVioletRed;
            menus.Items.AddRange(new ToolStripItem[] { anaSayfa, kisiselBilgiler });
            menus.Location = new Point(0, 0);
            menus.Name = "menus";
            menus.Size = new Size(800, 24);
            menus.TabIndex = 43;
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
            kisiselBilgiler.DropDownItems.AddRange(new ToolStripItem[] { addFood, addCategory });
            kisiselBilgiler.Name = "kisiselBilgiler";
            kisiselBilgiler.Size = new Size(79, 20);
            kisiselBilgiler.Text = "Veri Ekleme";
            // 
            // addFood
            // 
            addFood.BackColor = Color.PaleVioletRed;
            addFood.Name = "addFood";
            addFood.Size = new Size(180, 22);
            addFood.Text = "Yemek Ekle";
            addFood.Click += addFood_Click;
            // 
            // addCategory
            // 
            addCategory.BackColor = Color.PaleVioletRed;
            addCategory.Name = "addCategory";
            addCategory.Size = new Size(180, 22);
            addCategory.Text = "Kategori Ekle";
            addCategory.Click += addCategory_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menus);
            IsMdiContainer = true;
            Name = "AdminPage";
            Text = "AdminPage";
            Load += AdminPage_Load;
            menus.ResumeLayout(false);
            menus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menus;
        private ToolStripMenuItem anaSayfa;
        private ToolStripMenuItem kisiselBilgiler;
        private ToolStripMenuItem addFood;
        private ToolStripMenuItem addCategory;
    }
}