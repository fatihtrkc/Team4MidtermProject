namespace UI_Layer
{
    partial class AdminCategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCategoriesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pctrbxForm = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            dtgridCategory = new DataGridView();
            btnAdd = new Button();
            txtId = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtName = new TextBox();
            pctrbxExit = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctrbxForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgridCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).BeginInit();
            SuspendLayout();
            // 
            // pctrbxForm
            // 
            pctrbxForm.Dock = DockStyle.Fill;
            pctrbxForm.Image = (Image)resources.GetObject("pctrbxForm.Image");
            pctrbxForm.Location = new Point(0, 0);
            pctrbxForm.Name = "pctrbxForm";
            pctrbxForm.Size = new Size(800, 1200);
            pctrbxForm.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrbxForm.TabIndex = 0;
            pctrbxForm.TabStop = false;
            pctrbxForm.Click += pctrbxForm_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(76, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(655, 223);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(323, 379);
            label1.Name = "label1";
            label1.Size = new Size(166, 39);
            label1.TabIndex = 2;
            label1.Text = "Kategori Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(316, 494);
            label2.Name = "label2";
            label2.Size = new Size(179, 39);
            label2.TabIndex = 3;
            label2.Text = "Kategori Adı";
            // 
            // dtgridCategory
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightCoral;
            dataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dtgridCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgridCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgridCategory.BackgroundColor = Color.White;
            dtgridCategory.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.LightCoral;
            dataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgridCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgridCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightCoral;
            dataGridViewCellStyle3.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgridCategory.DefaultCellStyle = dataGridViewCellStyle3;
            dtgridCategory.Location = new Point(83, 731);
            dtgridCategory.MultiSelect = false;
            dtgridCategory.Name = "dtgridCategory";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.LightCoral;
            dataGridViewCellStyle4.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgridCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgridCategory.RowHeadersWidth = 62;
            dtgridCategory.RowTemplate.Height = 33;
            dtgridCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgridCategory.Size = new Size(643, 321);
            dtgridCategory.TabIndex = 4;
            dtgridCategory.CellClick += dtgridCategory_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.LightCoral;
            btnAdd.Location = new Point(83, 625);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(215, 83);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(83, 433);
            txtId.MaxLength = 5;
            txtId.Name = "txtId";
            txtId.Size = new Size(643, 47);
            txtId.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.LightCoral;
            btnDelete.Location = new Point(298, 625);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(215, 83);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.LightCoral;
            btnUpdate.Location = new Point(513, 625);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(215, 83);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(83, 547);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Kategori adını giriniz...";
            txtName.Size = new Size(643, 47);
            txtName.TabIndex = 7;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // pctrbxExit
            // 
            pctrbxExit.Image = (Image)resources.GetObject("pctrbxExit.Image");
            pctrbxExit.Location = new Point(758, 0);
            pctrbxExit.Name = "pctrbxExit";
            pctrbxExit.Size = new Size(42, 42);
            pctrbxExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrbxExit.TabIndex = 17;
            pctrbxExit.TabStop = false;
            pctrbxExit.Click += pctrbxExit_Click;
            pctrbxExit.MouseLeave += pctrbxExit_MouseLeave;
            pctrbxExit.MouseHover += pctrbxExit_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(173, 0);
            label3.Name = "label3";
            label3.Size = new Size(424, 77);
            label3.TabIndex = 18;
            label3.Text = "Kategori İşlemleri";
            // 
            // AdminCategoriesForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 1200);
            Controls.Add(label3);
            Controls.Add(pctrbxExit);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dtgridCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pctrbxForm);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "AdminCategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminCategoriesForm";
            Load += AdminCategoriesForm_Load;
            ((System.ComponentModel.ISupportInitialize)pctrbxForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgridCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctrbxForm;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private DataGridView dtgridCategory;
        private Button btnAdd;
        private TextBox txtId;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtName;
        private PictureBox pctrbxExit;
        private Label label3;
    }
}