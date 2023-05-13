namespace UI_Layer
{
    partial class FoodStatisticsForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lviewFoods = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lviewTop = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // lviewFoods
            // 
            lviewFoods.BackColor = Color.CornflowerBlue;
            lviewFoods.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lviewFoods.ForeColor = SystemColors.Window;
            lviewFoods.GridLines = true;
            lviewFoods.Location = new Point(111, 140);
            lviewFoods.Name = "lviewFoods";
            lviewFoods.Size = new Size(529, 221);
            lviewFoods.TabIndex = 0;
            lviewFoods.UseCompatibleStateImageBehavior = false;
            lviewFoods.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Yemekler";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kahvaltı";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Öğle Yemeği";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Akşam Yemeği";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ara Öğünler";
            columnHeader5.Width = 100;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(111, 37);
            label1.Name = "label1";
            label1.Size = new Size(529, 23);
            label1.TabIndex = 1;
            label1.Text = "Hangi Öğünde Ne Yedim?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(111, 81);
            label2.Name = "label2";
            label2.Size = new Size(223, 37);
            label2.TabIndex = 6;
            label2.Text = "Arama Çubuğu :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(111, 379);
            label3.Name = "label3";
            label3.Size = new Size(529, 23);
            label3.TabIndex = 7;
            label3.Text = "En Çok Tercih Ettiklerim ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lviewTop
            // 
            lviewTop.BackColor = Color.CornflowerBlue;
            lviewTop.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7 });
            lviewTop.ForeColor = SystemColors.Window;
            lviewTop.GridLines = true;
            lviewTop.Location = new Point(260, 421);
            lviewTop.Name = "lviewTop";
            lviewTop.Size = new Size(226, 155);
            lviewTop.Sorting = SortOrder.Ascending;
            lviewTop.TabIndex = 8;
            lviewTop.UseCompatibleStateImageBehavior = false;
            lviewTop.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Yemek Adı";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kaç Defa Yedim";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 100;
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 10;
            txtSearch.BorderThickness = 2;
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(359, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(281, 37);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // FoodStatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(765, 630);
            Controls.Add(txtSearch);
            Controls.Add(lviewTop);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lviewFoods);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FoodStatisticsForm";
            Text = "FoodStatisticsForm";
            Load += FoodStatisticsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lviewFoods;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView lviewTop;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}