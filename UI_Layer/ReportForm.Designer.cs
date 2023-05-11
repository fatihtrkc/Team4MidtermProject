namespace UI_Layer
{
    partial class ReportForm
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
            rdWeek = new RadioButton();
            rdMounth = new RadioButton();
            lviewCategory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lviewMeal = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // rdWeek
            // 
            rdWeek.Checked = true;
            rdWeek.Location = new Point(327, 337);
            rdWeek.Name = "rdWeek";
            rdWeek.Size = new Size(69, 64);
            rdWeek.TabIndex = 0;
            rdWeek.TabStop = true;
            rdWeek.Text = "Haftalık";
            rdWeek.UseVisualStyleBackColor = true;
            rdWeek.CheckedChanged += rdWeek_CheckedChanged;
            // 
            // rdMounth
            // 
            rdMounth.Location = new Point(439, 337);
            rdMounth.Name = "rdMounth";
            rdMounth.Size = new Size(54, 64);
            rdMounth.TabIndex = 1;
            rdMounth.Text = "Aylık";
            rdMounth.UseVisualStyleBackColor = true;
            rdMounth.CheckedChanged += rdMounth_CheckedChanged;
            // 
            // lviewCategory
            // 
            lviewCategory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lviewCategory.GridLines = true;
            lviewCategory.Location = new Point(12, 38);
            lviewCategory.Name = "lviewCategory";
            lviewCategory.Size = new Size(408, 264);
            lviewCategory.TabIndex = 38;
            lviewCategory.UseCompatibleStateImageBehavior = false;
            lviewCategory.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Kategoriler";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Aldığım Kalori Miktarı";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kullanıcı Ortalamaları";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 130;
            // 
            // lviewMeal
            // 
            lviewMeal.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            lviewMeal.GridLines = true;
            lviewMeal.Location = new Point(459, 38);
            lviewMeal.Name = "lviewMeal";
            lviewMeal.Size = new Size(408, 264);
            lviewMeal.TabIndex = 39;
            lviewMeal.UseCompatibleStateImageBehavior = false;
            lviewMeal.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Öğünler";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Aldığım Kalori Miktarı";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Kullanıcı Ortalamaları";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 130;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 454);
            Controls.Add(lviewMeal);
            Controls.Add(rdMounth);
            Controls.Add(rdWeek);
            Controls.Add(lviewCategory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportForm";
            Text = "Report";
            Load += ReportForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rdWeek;
        private RadioButton rdMounth;
        private ListView lviewCategory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lviewMeal;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}