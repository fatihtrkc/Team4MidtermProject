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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCategoriesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lblCategoryName = new Label();
            dtgridCategory = new DataGridView();
            txtId = new TextBox();
            txtName = new TextBox();
            pctrbxExit = new PictureBox();
            label3 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            pctrbxAlert = new PictureBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgridCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrbxAlert).BeginInit();
            SuspendLayout();
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
            label1.Location = new Point(322, 379);
            label1.Name = "label1";
            label1.Size = new Size(166, 39);
            label1.TabIndex = 2;
            label1.Text = "Kategori Id";
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.BackColor = Color.White;
            lblCategoryName.ForeColor = Color.LightCoral;
            lblCategoryName.Location = new Point(316, 494);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(179, 39);
            lblCategoryName.TabIndex = 3;
            lblCategoryName.Text = "Kategori Adı";
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
            dtgridCategory.Location = new Point(83, 730);
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
            dtgridCategory.Size = new Size(643, 370);
            dtgridCategory.TabIndex = 4;
            dtgridCategory.CellClick += dtgridCategory_CellClick;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.ForeColor = Color.LightCoral;
            txtId.Location = new Point(83, 433);
            txtId.MaxLength = 5;
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Bu alan veri girişine kapalıdır...";
            txtId.ReadOnly = true;
            txtId.Size = new Size(643, 47);
            txtId.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.ForeColor = Color.LightCoral;
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
            label3.ForeColor = Color.White;
            label3.Location = new Point(173, 0);
            label3.Name = "label3";
            label3.Size = new Size(424, 77);
            label3.TabIndex = 18;
            label3.Text = "Kategori İşlemleri";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // pctrbxAlert
            // 
            pctrbxAlert.BackColor = Color.DarkOrange;
            pctrbxAlert.Image = (Image)resources.GetObject("pctrbxAlert.Image");
            pctrbxAlert.Location = new Point(732, 547);
            pctrbxAlert.Name = "pctrbxAlert";
            pctrbxAlert.Size = new Size(54, 47);
            pctrbxAlert.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrbxAlert.TabIndex = 19;
            pctrbxAlert.TabStop = false;
            pctrbxAlert.Visible = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightCoral;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(513, 625);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(215, 83);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightCoral;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(83, 625);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(215, 83);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(298, 625);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(215, 83);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // AdminCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 1200);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(pctrbxAlert);
            Controls.Add(btnDelete);
            Controls.Add(label3);
            Controls.Add(pctrbxExit);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(dtgridCategory);
            Controls.Add(lblCategoryName);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "AdminCategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminCategoriesForm";
            Load += AdminCategoriesForm_Load;
            Click += AdminCategoriesForm_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgridCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrbxAlert).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label1;
        private Label lblCategoryName;
        private DataGridView dtgridCategory;
        private TextBox txtId;
        private TextBox txtName;
        private PictureBox pctrbxExit;
        private Label label3;
        private System.Windows.Forms.Timer timer;
        private PictureBox pctrbxAlert;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
    }
}