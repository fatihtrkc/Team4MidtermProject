namespace UI_Layer
{
    partial class UserInformation
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            llabelUpdPass = new LinkLabel();
            lblWelcome = new Label();
            label4 = new Label();
            label3 = new Label();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            cboxGoal = new Guna.UI2.WinForms.Guna2ComboBox();
            cboxLifeStyle = new Guna.UI2.WinForms.Guna2ComboBox();
            nudWeight = new Guna.UI2.WinForms.Guna2NumericUpDown();
            nudHeight = new Guna.UI2.WinForms.Guna2NumericUpDown();
            llabelUserDetails = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            SuspendLayout();
            // 
            // llabelUpdPass
            // 
            llabelUpdPass.AutoSize = true;
            llabelUpdPass.LinkColor = Color.White;
            llabelUpdPass.Location = new Point(353, 541);
            llabelUpdPass.Name = "llabelUpdPass";
            llabelUpdPass.Size = new Size(79, 15);
            llabelUpdPass.TabIndex = 83;
            llabelUpdPass.TabStop = true;
            llabelUpdPass.Text = "Şifre Güncelle";
            llabelUpdPass.LinkClicked += llabelUpdPass_LinkClicked;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = SystemColors.ButtonHighlight;
            lblWelcome.Location = new Point(71, 33);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(361, 23);
            lblWelcome.TabIndex = 81;
            lblWelcome.Text = "adı soyadı hoşgeldin";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(112, 152);
            label4.Name = "label4";
            label4.Size = new Size(130, 36);
            label4.TabIndex = 80;
            label4.Text = "Kilo:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(112, 93);
            label3.Name = "label3";
            label3.Size = new Size(130, 36);
            label3.TabIndex = 79;
            label3.Text = "Boy:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 10;
            btnUpdate.CustomizableEdges = customizableEdges1;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(160, 418);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnUpdate.Size = new Size(187, 45);
            btnUpdate.TabIndex = 78;
            btnUpdate.Text = "Güncelle";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(69, 308);
            label1.Name = "label1";
            label1.Size = new Size(363, 23);
            label1.TabIndex = 77;
            label1.Text = "Uygulamayı Kullanım Amacı";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(69, 214);
            label2.Name = "label2";
            label2.Size = new Size(363, 23);
            label2.TabIndex = 76;
            label2.Text = "Günlük Egzersiz Sıklığı";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboxGoal
            // 
            cboxGoal.BackColor = Color.Transparent;
            cboxGoal.BorderRadius = 10;
            cboxGoal.CustomizableEdges = customizableEdges3;
            cboxGoal.DrawMode = DrawMode.OwnerDrawFixed;
            cboxGoal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxGoal.FocusedColor = Color.FromArgb(94, 148, 255);
            cboxGoal.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboxGoal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboxGoal.ForeColor = Color.FromArgb(68, 88, 112);
            cboxGoal.ItemHeight = 30;
            cboxGoal.Location = new Point(69, 347);
            cboxGoal.Name = "cboxGoal";
            cboxGoal.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cboxGoal.Size = new Size(363, 36);
            cboxGoal.TabIndex = 75;
            // 
            // cboxLifeStyle
            // 
            cboxLifeStyle.BackColor = Color.Transparent;
            cboxLifeStyle.BorderRadius = 10;
            cboxLifeStyle.CustomizableEdges = customizableEdges5;
            cboxLifeStyle.DrawMode = DrawMode.OwnerDrawFixed;
            cboxLifeStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxLifeStyle.FocusedColor = Color.FromArgb(94, 148, 255);
            cboxLifeStyle.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboxLifeStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboxLifeStyle.ForeColor = Color.FromArgb(68, 88, 112);
            cboxLifeStyle.ItemHeight = 30;
            cboxLifeStyle.Location = new Point(70, 255);
            cboxLifeStyle.Name = "cboxLifeStyle";
            cboxLifeStyle.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboxLifeStyle.Size = new Size(363, 36);
            cboxLifeStyle.TabIndex = 74;
            // 
            // nudWeight
            // 
            nudWeight.BackColor = Color.Transparent;
            nudWeight.BorderRadius = 10;
            nudWeight.CustomizableEdges = customizableEdges7;
            nudWeight.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudWeight.Location = new Point(269, 152);
            nudWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudWeight.Minimum = new decimal(new int[] { 35, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.ShadowDecoration.CustomizableEdges = customizableEdges8;
            nudWeight.Size = new Size(100, 36);
            nudWeight.TabIndex = 73;
            nudWeight.Value = new decimal(new int[] { 35, 0, 0, 0 });
            // 
            // nudHeight
            // 
            nudHeight.BackColor = Color.Transparent;
            nudHeight.BorderRadius = 10;
            nudHeight.CustomizableEdges = customizableEdges9;
            nudHeight.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudHeight.Location = new Point(269, 93);
            nudHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudHeight.Minimum = new decimal(new int[] { 130, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.ShadowDecoration.CustomizableEdges = customizableEdges10;
            nudHeight.Size = new Size(100, 36);
            nudHeight.TabIndex = 72;
            nudHeight.Value = new decimal(new int[] { 130, 0, 0, 0 });
            // 
            // llabelUserDetails
            // 
            llabelUserDetails.LinkColor = Color.White;
            llabelUserDetails.Location = new Point(71, 527);
            llabelUserDetails.Name = "llabelUserDetails";
            llabelUserDetails.Size = new Size(86, 43);
            llabelUserDetails.TabIndex = 84;
            llabelUserDetails.TabStop = true;
            llabelUserDetails.Text = "Kişisel Bilgileri Güncelle";
            llabelUserDetails.TextAlign = ContentAlignment.MiddleCenter;
            llabelUserDetails.LinkClicked += llabelUserDetails_LinkClicked;
            // 
            // UserInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(481, 635);
            Controls.Add(llabelUserDetails);
            Controls.Add(llabelUpdPass);
            Controls.Add(lblWelcome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cboxGoal);
            Controls.Add(cboxLifeStyle);
            Controls.Add(nudWeight);
            Controls.Add(nudHeight);
            ForeColor = Color.PaleVioletRed;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserInformation";
            Text = "UserInformation";
            Load += UserInformation_Load;
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel llabelUpdPass;
        private Label lblWelcome;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cboxGoal;
        private Guna.UI2.WinForms.Guna2ComboBox cboxLifeStyle;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudWeight;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudHeight;
        private LinkLabel llabelUserDetails;
    }
}