namespace UI_Layer
{
    partial class AdminUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsersForm));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label3 = new Label();
            pctrbxExit = new PictureBox();
            txtUsername = new TextBox();
            dtgridPassiveUsers = new DataGridView();
            pictureBox2 = new PictureBox();
            btnUpdate = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgridPassiveUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(235, 0);
            label3.Name = "label3";
            label3.Size = new Size(319, 77);
            label3.TabIndex = 47;
            label3.Text = "Üye İşlemleri";
            // 
            // pctrbxExit
            // 
            pctrbxExit.Image = (Image)resources.GetObject("pctrbxExit.Image");
            pctrbxExit.Location = new Point(758, 0);
            pctrbxExit.Name = "pctrbxExit";
            pctrbxExit.Size = new Size(42, 42);
            pctrbxExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrbxExit.TabIndex = 46;
            pctrbxExit.TabStop = false;
            pctrbxExit.Click += pctrbxExit_Click;
            pctrbxExit.MouseLeave += pctrbxExit_MouseLeave;
            pctrbxExit.MouseHover += pctrbxExit_MouseHover;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.LightCoral;
            txtUsername.Location = new Point(76, 433);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Email üye kaydı seçildiğinde atanacaktır...";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(655, 52);
            txtUsername.TabIndex = 45;
            // 
            // dtgridPassiveUsers
            // 
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.LightCoral;
            dataGridViewCellStyle5.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dtgridPassiveUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgridPassiveUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgridPassiveUsers.BackgroundColor = Color.White;
            dtgridPassiveUsers.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.LightCoral;
            dataGridViewCellStyle6.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtgridPassiveUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtgridPassiveUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightCoral;
            dataGridViewCellStyle7.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dtgridPassiveUsers.DefaultCellStyle = dataGridViewCellStyle7;
            dtgridPassiveUsers.Location = new Point(3, 37);
            dtgridPassiveUsers.MultiSelect = false;
            dtgridPassiveUsers.Name = "dtgridPassiveUsers";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.LightCoral;
            dataGridViewCellStyle8.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtgridPassiveUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtgridPassiveUsers.RowHeadersWidth = 100;
            dtgridPassiveUsers.RowTemplate.Height = 33;
            dtgridPassiveUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgridPassiveUsers.Size = new Size(649, 465);
            dtgridPassiveUsers.TabIndex = 44;
            dtgridPassiveUsers.CellClick += dtgridPassiveUsers_CellClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(76, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(655, 223);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightCoral;
            btnUpdate.Enabled = false;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(76, 508);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(655, 87);
            btnUpdate.TabIndex = 49;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(285, 379);
            label1.Name = "label1";
            label1.Size = new Size(245, 39);
            label1.TabIndex = 50;
            label1.Text = "Username / Email";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dtgridPassiveUsers);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(76, 595);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 505);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bloke Edilen Üyelikler";
            // 
            // AdminUsersForm
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 1200);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pctrbxExit);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox2);
            Controls.Add(btnUpdate);
            DoubleBuffered = true;
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "AdminUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminUsersForm";
            Load += AdminUsersForm_Load;
            Click += AdminUsersForm_Click;
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgridPassiveUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private PictureBox pctrbxExit;
        private TextBox txtUsername;
        private DataGridView dtgridPassiveUsers;
        private PictureBox pictureBox2;
        private Button btnUpdate;
        private Label label1;
        private GroupBox groupBox1;
    }
}