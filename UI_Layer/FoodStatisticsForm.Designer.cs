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
            lviewFoods = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lviewTop = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // lviewFoods
            // 
            lviewFoods.BackColor = SystemColors.InactiveCaption;
            lviewFoods.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
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
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(111, 55);
            label1.Name = "label1";
            label1.Size = new Size(529, 23);
            label1.TabIndex = 1;
            label1.Text = "Hangi Öğünde Ne Yedim?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(338, 95);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(302, 23);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(111, 95);
            label2.Name = "label2";
            label2.Size = new Size(221, 23);
            label2.TabIndex = 6;
            label2.Text = "Arama Çubuğu :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(111, 379);
            label3.Name = "label3";
            label3.Size = new Size(529, 23);
            label3.TabIndex = 7;
            label3.Text = "En Çok Tercih Ettiklerim ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lviewTop
            // 
            lviewTop.BackColor = SystemColors.InactiveCaption;
            lviewTop.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7 });
            lviewTop.GridLines = true;
            lviewTop.Location = new Point(260, 421);
            lviewTop.Name = "lviewTop";
            lviewTop.Size = new Size(236, 155);
            lviewTop.Sorting = SortOrder.Ascending;
            lviewTop.TabIndex = 8;
            lviewTop.UseCompatibleStateImageBehavior = false;
            lviewTop.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kaç Defa Yedim";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Yemek Adı";
            columnHeader6.Width = 120;
            // 
            // FoodStatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(765, 630);
            Controls.Add(lviewTop);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(lviewFoods);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FoodStatisticsForm";
            Text = "FoodStatisticsForm";
            Load += FoodStatisticsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lviewFoods;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private Label label3;
        private ListView lviewTop;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}