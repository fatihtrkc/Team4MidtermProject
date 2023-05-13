namespace UI_Layer
{
    partial class UserAddMeal
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblUnitType = new Label();
            pboxYemekFoto = new PictureBox();
            Sil = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            lviewMeal = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            cboxYemekler = new Guna.UI2.WinForms.Guna2ComboBox();
            cboxCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            lblMeal = new Label();
            nudPorsiyon = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pboxYemekFoto).BeginInit();
            Sil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPorsiyon).BeginInit();
            SuspendLayout();
            // 
            // lblUnitType
            // 
            lblUnitType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitType.ForeColor = SystemColors.Window;
            lblUnitType.Location = new Point(117, 294);
            lblUnitType.Name = "lblUnitType";
            lblUnitType.Size = new Size(102, 36);
            lblUnitType.TabIndex = 68;
            lblUnitType.Text = "Porsiyon/Adet";
            lblUnitType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pboxYemekFoto
            // 
            pboxYemekFoto.Location = new Point(115, 21);
            pboxYemekFoto.Name = "pboxYemekFoto";
            pboxYemekFoto.Size = new Size(261, 154);
            pboxYemekFoto.TabIndex = 64;
            pboxYemekFoto.TabStop = false;
            // 
            // Sil
            // 
            Sil.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            Sil.Name = "Sil";
            Sil.Size = new Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(86, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // lviewMeal
            // 
            lviewMeal.BackColor = Color.CornflowerBlue;
            lviewMeal.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader3 });
            lviewMeal.ContextMenuStrip = Sil;
            lviewMeal.ForeColor = SystemColors.Window;
            lviewMeal.GridLines = true;
            lviewMeal.Location = new Point(117, 430);
            lviewMeal.Name = "lviewMeal";
            lviewMeal.Size = new Size(261, 196);
            lviewMeal.TabIndex = 74;
            lviewMeal.UseCompatibleStateImageBehavior = false;
            lviewMeal.View = View.Details;
            lviewMeal.SelectedIndexChanged += lviewMeal_SelectedIndexChanged_1;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Yemek";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Adet/Porsiyon";
            columnHeader7.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kalori";
            columnHeader3.Width = 65;
            // 
            // cboxYemekler
            // 
            cboxYemekler.BackColor = Color.Transparent;
            cboxYemekler.BorderRadius = 10;
            cboxYemekler.CustomizableEdges = customizableEdges1;
            cboxYemekler.DrawMode = DrawMode.OwnerDrawFixed;
            cboxYemekler.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxYemekler.FocusedColor = Color.FromArgb(94, 148, 255);
            cboxYemekler.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboxYemekler.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboxYemekler.ForeColor = Color.FromArgb(68, 88, 112);
            cboxYemekler.ItemHeight = 30;
            cboxYemekler.Location = new Point(117, 245);
            cboxYemekler.Name = "cboxYemekler";
            cboxYemekler.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cboxYemekler.Size = new Size(259, 36);
            cboxYemekler.TabIndex = 76;
            cboxYemekler.SelectedIndexChanged += cboxYemekler_SelectedIndexChanged;
            // 
            // cboxCategories
            // 
            cboxCategories.BackColor = Color.Transparent;
            cboxCategories.BorderRadius = 10;
            cboxCategories.CustomizableEdges = customizableEdges3;
            cboxCategories.DrawMode = DrawMode.OwnerDrawFixed;
            cboxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxCategories.FocusedColor = Color.FromArgb(94, 148, 255);
            cboxCategories.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboxCategories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboxCategories.ForeColor = Color.FromArgb(68, 88, 112);
            cboxCategories.ItemHeight = 30;
            cboxCategories.Location = new Point(117, 190);
            cboxCategories.Name = "cboxCategories";
            cboxCategories.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cboxCategories.Size = new Size(259, 36);
            cboxCategories.TabIndex = 75;
            cboxCategories.SelectedIndexChanged += cboxCategories_SelectedIndexChanged_1;
            // 
            // btnAdd
            // 
            btnAdd.BorderColor = Color.White;
            btnAdd.BorderRadius = 10;
            btnAdd.BorderThickness = 2;
            btnAdd.CustomizableEdges = customizableEdges5;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(179, 347);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAdd.Size = new Size(136, 40);
            btnAdd.TabIndex = 78;
            btnAdd.Text = "Kaydet";
            btnAdd.Click += btnAdd_Click_1;
            // 
            // lblMeal
            // 
            lblMeal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMeal.ForeColor = SystemColors.Window;
            lblMeal.Location = new Point(117, 390);
            lblMeal.Name = "lblMeal";
            lblMeal.Size = new Size(259, 23);
            lblMeal.TabIndex = 79;
            lblMeal.Text = "Öğün";
            lblMeal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudPorsiyon
            // 
            nudPorsiyon.BackColor = Color.Transparent;
            nudPorsiyon.BorderRadius = 10;
            nudPorsiyon.CustomizableEdges = customizableEdges7;
            nudPorsiyon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudPorsiyon.Location = new Point(256, 294);
            nudPorsiyon.Name = "nudPorsiyon";
            nudPorsiyon.ShadowDecoration.CustomizableEdges = customizableEdges8;
            nudPorsiyon.Size = new Size(120, 36);
            nudPorsiyon.TabIndex = 80;
            // 
            // UserAddMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(487, 638);
            Controls.Add(nudPorsiyon);
            Controls.Add(lblMeal);
            Controls.Add(btnAdd);
            Controls.Add(cboxYemekler);
            Controls.Add(cboxCategories);
            Controls.Add(lviewMeal);
            Controls.Add(lblUnitType);
            Controls.Add(pboxYemekFoto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAddMeal";
            Text = "UserAddMeal";
            Load += UserAddMeal_Load;
            Click += UserAddMeal_Click;
            ((System.ComponentModel.ISupportInitialize)pboxYemekFoto).EndInit();
            Sil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudPorsiyon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblUnitType;
        private PictureBox pboxYemekFoto;
        private ContextMenuStrip Sil;
        private ToolStripMenuItem silToolStripMenuItem;
        private ListView lviewMeal;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader3;
        private Guna.UI2.WinForms.Guna2ComboBox cboxYemekler;
        private Guna.UI2.WinForms.Guna2ComboBox cboxCategories;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Label lblMeal;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPorsiyon;
    }
}