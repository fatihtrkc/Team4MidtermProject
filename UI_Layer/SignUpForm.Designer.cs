namespace UI_Layer
{
    partial class SignUpForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblBirthDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnGiris = new Guna.UI2.WinForms.Guna2GradientButton();
            dtBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtSpeAns = new Guna.UI2.WinForms.Guna2TextBox();
            txtSpe = new Guna.UI2.WinForms.Guna2TextBox();
            txtAgain = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            txtSurname = new Guna.UI2.WinForms.Guna2TextBox();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // lblBirthDate
            // 
            lblBirthDate.BackColor = Color.Transparent;
            lblBirthDate.Location = new Point(150, 424);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(86, 17);
            lblBirthDate.TabIndex = 35;
            lblBirthDate.Text = "DOĞUM TARİHİ ";
            // 
            // btnGiris
            // 
            btnGiris.BorderColor = Color.White;
            btnGiris.BorderRadius = 10;
            btnGiris.BorderThickness = 2;
            btnGiris.CustomizableEdges = customizableEdges1;
            btnGiris.DisabledState.BorderColor = Color.DarkGray;
            btnGiris.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGiris.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGiris.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnGiris.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGiris.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(90, 505);
            btnGiris.Name = "btnGiris";
            btnGiris.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGiris.Size = new Size(200, 45);
            btnGiris.TabIndex = 34;
            btnGiris.Text = "Devam Et";
            btnGiris.Click += btnGiris_Click;
            // 
            // dtBirth
            // 
            dtBirth.BorderColor = Color.White;
            dtBirth.BorderRadius = 10;
            dtBirth.BorderThickness = 2;
            dtBirth.Checked = true;
            dtBirth.CustomizableEdges = customizableEdges3;
            dtBirth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtBirth.Format = DateTimePickerFormat.Long;
            dtBirth.Location = new Point(90, 447);
            dtBirth.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtBirth.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtBirth.Name = "dtBirth";
            dtBirth.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtBirth.Size = new Size(200, 36);
            dtBirth.TabIndex = 33;
            dtBirth.Value = new DateTime(2023, 5, 12, 17, 24, 31, 362);
            // 
            // txtSpeAns
            // 
            txtSpeAns.BorderRadius = 10;
            txtSpeAns.CustomizableEdges = customizableEdges5;
            txtSpeAns.DefaultText = "";
            txtSpeAns.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSpeAns.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSpeAns.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSpeAns.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSpeAns.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpeAns.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSpeAns.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpeAns.Location = new Point(90, 370);
            txtSpeAns.Name = "txtSpeAns";
            txtSpeAns.PasswordChar = '\0';
            txtSpeAns.PlaceholderText = "Özel Sorunuzun Cevabını Giriniz";
            txtSpeAns.SelectedText = "";
            txtSpeAns.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSpeAns.Size = new Size(200, 36);
            txtSpeAns.TabIndex = 32;
            // 
            // txtSpe
            // 
            txtSpe.BorderRadius = 10;
            txtSpe.CustomizableEdges = customizableEdges7;
            txtSpe.DefaultText = "";
            txtSpe.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSpe.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSpe.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSpe.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSpe.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSpe.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpe.Location = new Point(90, 313);
            txtSpe.Name = "txtSpe";
            txtSpe.PasswordChar = '\0';
            txtSpe.PlaceholderText = "Size Öel Bir Soru Giriniz";
            txtSpe.SelectedText = "";
            txtSpe.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSpe.Size = new Size(200, 36);
            txtSpe.TabIndex = 31;
            // 
            // txtAgain
            // 
            txtAgain.BorderRadius = 10;
            txtAgain.CustomizableEdges = customizableEdges9;
            txtAgain.DefaultText = "";
            txtAgain.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAgain.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAgain.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAgain.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAgain.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAgain.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAgain.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAgain.Location = new Point(90, 254);
            txtAgain.Name = "txtAgain";
            txtAgain.PasswordChar = '\0';
            txtAgain.PlaceholderText = "Şifrenizi Tekrar Giriniz";
            txtAgain.SelectedText = "";
            txtAgain.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtAgain.Size = new Size(200, 36);
            txtAgain.TabIndex = 30;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 10;
            txtPassword.CustomizableEdges = customizableEdges11;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(90, 193);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PlaceholderText = "Şifre";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtPassword.Size = new Size(200, 36);
            txtPassword.TabIndex = 29;
            // 
            // txtMail
            // 
            txtMail.BorderRadius = 10;
            txtMail.CustomizableEdges = customizableEdges13;
            txtMail.DefaultText = "";
            txtMail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMail.Location = new Point(90, 134);
            txtMail.Name = "txtMail";
            txtMail.PasswordChar = '\0';
            txtMail.PlaceholderText = "Mail Adresi";
            txtMail.SelectedText = "";
            txtMail.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtMail.Size = new Size(200, 36);
            txtMail.TabIndex = 28;
            // 
            // txtSurname
            // 
            txtSurname.BorderRadius = 10;
            txtSurname.CustomizableEdges = customizableEdges15;
            txtSurname.DefaultText = "";
            txtSurname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSurname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSurname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSurname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSurname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSurname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSurname.Location = new Point(90, 78);
            txtSurname.Name = "txtSurname";
            txtSurname.PasswordChar = '\0';
            txtSurname.PlaceholderText = "Soyisim";
            txtSurname.SelectedText = "";
            txtSurname.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtSurname.Size = new Size(200, 36);
            txtSurname.TabIndex = 27;
            // 
            // txtName
            // 
            txtName.BorderRadius = 10;
            txtName.CustomizableEdges = customizableEdges17;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(90, 19);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "İsim";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtName.Size = new Size(200, 36);
            txtName.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(296, 447);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 36;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(374, 567);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblBirthDate);
            Controls.Add(btnGiris);
            Controls.Add(dtBirth);
            Controls.Add(txtSpeAns);
            Controls.Add(txtSpe);
            Controls.Add(txtAgain);
            Controls.Add(txtPassword);
            Controls.Add(txtMail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Name = "SignUpForm";
            Text = "SignUp";
            Load += SignUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblBirthDate;
        private Guna.UI2.WinForms.Guna2GradientButton btnGiris;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtBirth;
        private Guna.UI2.WinForms.Guna2TextBox txtSpeAns;
        private Guna.UI2.WinForms.Guna2TextBox txtSpe;
        private Guna.UI2.WinForms.Guna2TextBox txtAgain;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2TextBox txtSurname;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private DateTimePicker dateTimePicker1;
    }
}