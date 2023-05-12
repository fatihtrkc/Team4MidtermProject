namespace UI_Layer
{
    partial class AdminFoodsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFoodsForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label3 = new Label();
            pctrbxExit = new PictureBox();
            txtName = new TextBox();
            dtgridFoods = new DataGridView();
            lblCategoryName = new Label();
            pictureBox2 = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            btnUpdate = new Button();
            btnAdd = new Button();
            pctrbxAlert = new PictureBox();
            btnDelete = new Button();
            cmbUnit = new ComboBox();
            cmbCategory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            nmrcCalory = new NumericUpDown();
            lblNameCharacter = new Label();
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgridFoods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrbxAlert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcCalory).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(220, 0);
            label3.Name = "label3";
            label3.Size = new Size(352, 77);
            label3.TabIndex = 31;
            label3.Text = "Besin İşlemleri";
            // 
            // pctrbxExit
            // 
            pctrbxExit.Image = (Image)resources.GetObject("pctrbxExit.Image");
            pctrbxExit.Location = new Point(758, 0);
            pctrbxExit.Name = "pctrbxExit";
            pctrbxExit.Size = new Size(42, 42);
            pctrbxExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrbxExit.TabIndex = 30;
            pctrbxExit.TabStop = false;
            pctrbxExit.Click += pctrbxExit_Click;
            pctrbxExit.MouseLeave += pctrbxExit_MouseLeave;
            pctrbxExit.MouseHover += pctrbxExit_MouseHover;
            // 
            // txtName
            // 
            txtName.BackColor = Color.LightCoral;
            txtName.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(276, 370);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Besin adını giriniz...";
            txtName.Size = new Size(450, 52);
            txtName.TabIndex = 28;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // dtgridFoods
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightCoral;
            dataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dtgridFoods.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgridFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgridFoods.BackgroundColor = Color.White;
            dtgridFoods.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.LightCoral;
            dataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgridFoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgridFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightCoral;
            dataGridViewCellStyle3.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgridFoods.DefaultCellStyle = dataGridViewCellStyle3;
            dtgridFoods.Location = new Point(83, 731);
            dtgridFoods.MultiSelect = false;
            dtgridFoods.Name = "dtgridFoods";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.LightCoral;
            dataGridViewCellStyle4.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgridFoods.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgridFoods.RowHeadersWidth = 100;
            dtgridFoods.RowTemplate.Height = 33;
            dtgridFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgridFoods.Size = new Size(643, 321);
            dtgridFoods.TabIndex = 27;
            dtgridFoods.CellClick += dtgridFoods_CellClick;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.BackColor = Color.White;
            lblCategoryName.ForeColor = Color.LightCoral;
            lblCategoryName.Location = new Point(316, 436);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(179, 39);
            lblCategoryName.TabIndex = 26;
            lblCategoryName.Text = "Kategori Adı";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(76, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(655, 223);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightCoral;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(513, 625);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(215, 83);
            btnUpdate.TabIndex = 33;
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
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pctrbxAlert
            // 
            pctrbxAlert.BackColor = Color.DarkOrange;
            pctrbxAlert.Image = (Image)resources.GetObject("pctrbxAlert.Image");
            pctrbxAlert.Location = new Point(732, 370);
            pctrbxAlert.Name = "pctrbxAlert";
            pctrbxAlert.Size = new Size(54, 52);
            pctrbxAlert.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrbxAlert.TabIndex = 32;
            pctrbxAlert.TabStop = false;
            pctrbxAlert.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(298, 625);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(215, 83);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cmbUnit.ForeColor = Color.LightCoral;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(276, 543);
            cmbUnit.MaxDropDownItems = 5;
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(450, 53);
            cmbUnit.TabIndex = 37;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.White;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategory.ForeColor = Color.LightCoral;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(276, 428);
            cmbCategory.MaxDropDownItems = 5;
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(450, 53);
            cmbCategory.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(83, 433);
            label1.Name = "label1";
            label1.Size = new Size(189, 42);
            label1.TabIndex = 39;
            label1.Text = "Kategori Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(81, 549);
            label2.Name = "label2";
            label2.Size = new Size(177, 42);
            label2.TabIndex = 39;
            label2.Text = "Besin Birimi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(83, 492);
            label4.Name = "label4";
            label4.Size = new Size(178, 42);
            label4.TabIndex = 39;
            label4.Text = "Besin Kalori";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(81, 376);
            label5.Name = "label5";
            label5.Size = new Size(146, 42);
            label5.TabIndex = 39;
            label5.Text = "Besin Adı";
            // 
            // nmrcCalory
            // 
            nmrcCalory.BackColor = Color.LightCoral;
            nmrcCalory.DecimalPlaces = 1;
            nmrcCalory.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nmrcCalory.ForeColor = Color.White;
            nmrcCalory.Location = new Point(276, 486);
            nmrcCalory.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmrcCalory.Name = "nmrcCalory";
            nmrcCalory.Size = new Size(450, 52);
            nmrcCalory.TabIndex = 40;
            // 
            // lblNameCharacter
            // 
            lblNameCharacter.AutoSize = true;
            lblNameCharacter.BackColor = Color.Transparent;
            lblNameCharacter.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameCharacter.ForeColor = Color.White;
            lblNameCharacter.Location = new Point(276, 339);
            lblNameCharacter.Name = "lblNameCharacter";
            lblNameCharacter.Size = new Size(0, 28);
            lblNameCharacter.TabIndex = 41;
            // 
            // AdminFoodsForm
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 1200);
            Controls.Add(lblNameCharacter);
            Controls.Add(nmrcCalory);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(cmbCategory);
            Controls.Add(cmbUnit);
            Controls.Add(label3);
            Controls.Add(pctrbxExit);
            Controls.Add(txtName);
            Controls.Add(dtgridFoods);
            Controls.Add(lblCategoryName);
            Controls.Add(pictureBox2);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(pctrbxAlert);
            Controls.Add(btnDelete);
            DoubleBuffered = true;
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "AdminFoodsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminFoodsForm";
            Load += AdminFoodsForm_Load;
            Click += AdminFoodsForm_Click;
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgridFoods).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrbxAlert).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcCalory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pctrbxExit;
        private TextBox txtName;
        private DataGridView dtgridFoods;
        private Label lblCategoryName;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer;
        private Button btnUpdate;
        private Button btnAdd;
        private PictureBox pctrbxAlert;
        private Button btnDelete;
        private ComboBox cmbUnit;
        private ComboBox cmbCategory;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private NumericUpDown nmrcCalory;
        private Label lblNameCharacter;
    }
}