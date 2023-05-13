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
            lviewCategory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lviewMeal = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            rdbWeek = new Guna.UI2.WinForms.Guna2RadioButton();
            rdbMounth = new Guna.UI2.WinForms.Guna2RadioButton();
            SuspendLayout();
            // 
            // lviewCategory
            // 
            lviewCategory.BackColor = Color.CornflowerBlue;
            lviewCategory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lviewCategory.ForeColor = SystemColors.Window;
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
            lviewMeal.BackColor = Color.CornflowerBlue;
            lviewMeal.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            lviewMeal.ForeColor = SystemColors.Window;
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
            // rdbWeek
            // 
            rdbWeek.Checked = true;
            rdbWeek.CheckedState.BorderColor = Color.Black;
            rdbWeek.CheckedState.BorderThickness = 1;
            rdbWeek.CheckedState.FillColor = Color.Ivory;
            rdbWeek.CheckedState.InnerColor = Color.CornflowerBlue;
            rdbWeek.CheckedState.InnerOffset = -4;
            rdbWeek.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rdbWeek.ForeColor = SystemColors.Control;
            rdbWeek.Location = new Point(334, 347);
            rdbWeek.Name = "rdbWeek";
            rdbWeek.Size = new Size(86, 31);
            rdbWeek.TabIndex = 41;
            rdbWeek.TabStop = true;
            rdbWeek.Text = "Haftalık";
            rdbWeek.TextAlign = ContentAlignment.MiddleCenter;
            rdbWeek.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rdbWeek.UncheckedState.BorderThickness = 2;
            rdbWeek.UncheckedState.FillColor = Color.Transparent;
            rdbWeek.UncheckedState.InnerColor = Color.Transparent;
            rdbWeek.CheckedChanged += rdbWeek_CheckedChanged;
            // 
            // rdbMounth
            // 
            rdbMounth.CheckedState.BorderColor = Color.Black;
            rdbMounth.CheckedState.BorderThickness = 1;
            rdbMounth.CheckedState.FillColor = Color.Ivory;
            rdbMounth.CheckedState.InnerColor = Color.CornflowerBlue;
            rdbMounth.CheckedState.InnerOffset = -4;
            rdbMounth.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rdbMounth.ForeColor = SystemColors.Control;
            rdbMounth.Location = new Point(459, 347);
            rdbMounth.Name = "rdbMounth";
            rdbMounth.Size = new Size(78, 31);
            rdbMounth.TabIndex = 42;
            rdbMounth.Text = "Aylık";
            rdbMounth.TextAlign = ContentAlignment.MiddleCenter;
            rdbMounth.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rdbMounth.UncheckedState.BorderThickness = 2;
            rdbMounth.UncheckedState.FillColor = Color.Transparent;
            rdbMounth.UncheckedState.InnerColor = Color.Transparent;
            rdbMounth.CheckedChanged += rdbMounth_CheckedChanged;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(879, 454);
            Controls.Add(rdbMounth);
            Controls.Add(rdbWeek);
            Controls.Add(lviewMeal);
            Controls.Add(lviewCategory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportForm";
            Text = "Report";
            Load += ReportForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListView lviewCategory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lviewMeal;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Guna.UI2.WinForms.Guna2RadioButton rdbWeek;
        private Guna.UI2.WinForms.Guna2RadioButton rdbMounth;
    }
}