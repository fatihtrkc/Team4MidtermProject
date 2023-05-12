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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsersForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            timer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            pctrbxExit = new PictureBox();
            txtUsername = new TextBox();
            dtgridPassiveUsers = new DataGridView();
            pictureBox2 = new PictureBox();
            btnUpdate = new Button();
            txtActivePassiveSituation = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgridPassiveUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(200, 0);
            label3.Name = "label3";
            label3.Size = new Size(386, 77);
            label3.TabIndex = 47;
            label3.Text = "Üye Güncelleme";
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
            pctrbxExit.ClientSizeChanged += pctrbxExit_ClientSizeChanged;
            pctrbxExit.Click += pctrbxExit_Click;
            pctrbxExit.MouseHover += pctrbxExit_MouseHover;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.LightCoral;
            txtUsername.Location = new Point(83, 433);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(322, 52);
            txtUsername.TabIndex = 45;
            // 
            // dtgridPassiveUsers
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightCoral;
            dataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dtgridPassiveUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgridPassiveUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgridPassiveUsers.BackgroundColor = Color.White;
            dtgridPassiveUsers.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.LightCoral;
            dataGridViewCellStyle2.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgridPassiveUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgridPassiveUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightCoral;
            dataGridViewCellStyle3.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgridPassiveUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dtgridPassiveUsers.Location = new Point(83, 618);
            dtgridPassiveUsers.MultiSelect = false;
            dtgridPassiveUsers.Name = "dtgridPassiveUsers";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.LightCoral;
            dataGridViewCellStyle4.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgridPassiveUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgridPassiveUsers.RowHeadersWidth = 100;
            dtgridPassiveUsers.RowTemplate.Height = 33;
            dtgridPassiveUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgridPassiveUsers.Size = new Size(643, 482);
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
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(83, 510);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(645, 83);
            btnUpdate.TabIndex = 49;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtActivePassiveSituation
            // 
            txtActivePassiveSituation.BackColor = Color.White;
            txtActivePassiveSituation.Enabled = false;
            txtActivePassiveSituation.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtActivePassiveSituation.ForeColor = Color.LightCoral;
            txtActivePassiveSituation.Location = new Point(405, 433);
            txtActivePassiveSituation.MaxLength = 5;
            txtActivePassiveSituation.Name = "txtActivePassiveSituation";
            txtActivePassiveSituation.ReadOnly = true;
            txtActivePassiveSituation.Size = new Size(321, 52);
            txtActivePassiveSituation.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(170, 379);
            label1.Name = "label1";
            label1.Size = new Size(471, 39);
            label1.TabIndex = 50;
            label1.Text = "Username / User Active or Passive";
            // 
            // AdminUsersForm
            // 
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 1200);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pctrbxExit);
            Controls.Add(txtActivePassiveSituation);
            Controls.Add(txtUsername);
            Controls.Add(dtgridPassiveUsers);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private Label label3;
        private PictureBox pctrbxExit;
        private TextBox txtUsername;
        private DataGridView dtgridPassiveUsers;
        private PictureBox pictureBox2;
        private Button btnUpdate;
        private TextBox txtActivePassiveSituation;
        private Label label1;
    }
}