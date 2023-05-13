namespace UI_Layer
{
    partial class AdminAddCategory
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
            label2 = new Label();
            txtCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            lviewCategory = new ListView();
            columnHeader1 = new ColumnHeader();
            silici = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            silici.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(51, 77);
            label2.Name = "label2";
            label2.Size = new Size(91, 36);
            label2.TabIndex = 5;
            label2.Text = "Kategori Adı:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = Color.Transparent;
            txtCategoryName.BorderColor = SystemColors.Window;
            txtCategoryName.BorderRadius = 10;
            txtCategoryName.BorderThickness = 2;
            txtCategoryName.CustomizableEdges = customizableEdges1;
            txtCategoryName.DefaultText = "";
            txtCategoryName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCategoryName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCategoryName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCategoryName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCategoryName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoryName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCategoryName.Location = new Point(148, 77);
            txtCategoryName.MaxLength = 50;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PasswordChar = '\0';
            txtCategoryName.PlaceholderText = "";
            txtCategoryName.SelectedText = "";
            txtCategoryName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtCategoryName.Size = new Size(298, 36);
            txtCategoryName.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BorderColor = SystemColors.Window;
            btnAdd.BorderRadius = 10;
            btnAdd.BorderThickness = 2;
            btnAdd.CustomizableEdges = customizableEdges3;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(193, 139);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdd.Size = new Size(206, 45);
            btnAdd.TabIndex = 78;
            btnAdd.Text = "Kategori Ekle";
            btnAdd.Click += btnAdd_Click;
            // 
            // lviewCategory
            // 
            lviewCategory.BackColor = Color.CornflowerBlue;
            lviewCategory.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lviewCategory.ContextMenuStrip = silici;
            lviewCategory.ForeColor = SystemColors.Window;
            lviewCategory.GridLines = true;
            lviewCategory.Location = new Point(193, 215);
            lviewCategory.Name = "lviewCategory";
            lviewCategory.Size = new Size(206, 196);
            lviewCategory.TabIndex = 77;
            lviewCategory.UseCompatibleStateImageBehavior = false;
            lviewCategory.View = View.Details;
            lviewCategory.SelectedIndexChanged += lviewCategory_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Kategori Adı";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 200;
            // 
            // silici
            // 
            silici.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            silici.Name = "silici";
            silici.Size = new Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(86, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // AdminAddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(602, 450);
            Controls.Add(btnAdd);
            Controls.Add(lviewCategory);
            Controls.Add(label2);
            Controls.Add(txtCategoryName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminAddCategory";
            Text = "AdminAddCategory";
            Load += AdminAddCategory_Load;
            Click += AdminAddCategory_Click;
            silici.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryName;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private ListView lviewCategory;
        private ColumnHeader columnHeader1;
        private ContextMenuStrip silici;
        private ToolStripMenuItem silToolStripMenuItem;
    }
}