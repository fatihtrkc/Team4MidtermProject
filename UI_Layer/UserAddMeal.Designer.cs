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
            cboxCategories = new ComboBox();
            btnAdd = new Button();
            label1 = new Label();
            nudPorsiyon = new NumericUpDown();
            cboxYemekler = new ComboBox();
            pboxYemekFoto = new PictureBox();
            lviewMeal = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lblMeal = new Label();
            Sil = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)nudPorsiyon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxYemekFoto).BeginInit();
            Sil.SuspendLayout();
            SuspendLayout();
            // 
            // cboxCategories
            // 
            cboxCategories.FormattingEnabled = true;
            cboxCategories.Location = new Point(147, 224);
            cboxCategories.Name = "cboxCategories";
            cboxCategories.Size = new Size(240, 23);
            cboxCategories.TabIndex = 71;
            cboxCategories.SelectedIndexChanged += cboxCategories_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(206, 329);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 69;
            btnAdd.Text = "Kaydet";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.Location = new Point(148, 287);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 68;
            label1.Text = "Porsiyon/Adet";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudPorsiyon
            // 
            nudPorsiyon.Location = new Point(316, 287);
            nudPorsiyon.Name = "nudPorsiyon";
            nudPorsiyon.Size = new Size(71, 23);
            nudPorsiyon.TabIndex = 67;
            // 
            // cboxYemekler
            // 
            cboxYemekler.FormattingEnabled = true;
            cboxYemekler.Location = new Point(147, 253);
            cboxYemekler.Name = "cboxYemekler";
            cboxYemekler.Size = new Size(240, 23);
            cboxYemekler.TabIndex = 66;
            // 
            // pboxYemekFoto
            // 
            pboxYemekFoto.Location = new Point(146, 64);
            pboxYemekFoto.Name = "pboxYemekFoto";
            pboxYemekFoto.Size = new Size(241, 154);
            pboxYemekFoto.TabIndex = 64;
            pboxYemekFoto.TabStop = false;
            // 
            // lviewMeal
            // 
            lviewMeal.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader3 });
            lviewMeal.ContextMenuStrip = Sil;
            lviewMeal.GridLines = true;
            lviewMeal.Location = new Point(146, 394);
            lviewMeal.Name = "lviewMeal";
            lviewMeal.Size = new Size(241, 196);
            lviewMeal.TabIndex = 72;
            lviewMeal.UseCompatibleStateImageBehavior = false;
            lviewMeal.View = View.Details;
            lviewMeal.SelectedIndexChanged += lviewMeal_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Yemek";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Adet/Porsiyon";
            columnHeader7.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kalori";
            // 
            // lblMeal
            // 
            lblMeal.AutoSize = true;
            lblMeal.Location = new Point(241, 376);
            lblMeal.Name = "lblMeal";
            lblMeal.Size = new Size(37, 15);
            lblMeal.TabIndex = 73;
            lblMeal.Text = "Öğün";
            // 
            // Sil
            // 
            Sil.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            Sil.Name = "Sil";
            Sil.Size = new Size(181, 48);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(180, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // UserAddMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 618);
            Controls.Add(lblMeal);
            Controls.Add(lviewMeal);
            Controls.Add(cboxCategories);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(nudPorsiyon);
            Controls.Add(cboxYemekler);
            Controls.Add(pboxYemekFoto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAddMeal";
            Text = "UserAddMeal";
            Load += UserAddMeal_Load;
            Click += UserAddMeal_Click;
            ((System.ComponentModel.ISupportInitialize)nudPorsiyon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxYemekFoto).EndInit();
            Sil.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboxCategories;
        private Button btnAdd;
        private Label label1;
        private NumericUpDown nudPorsiyon;
        private ComboBox cboxYemekler;
        private PictureBox pboxYemekFoto;
        private ListView lviewMeal;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader3;
        private Label lblMeal;
        private ContextMenuStrip Sil;
        private ToolStripMenuItem silToolStripMenuItem;
    }
}