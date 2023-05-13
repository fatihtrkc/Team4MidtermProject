namespace UI_Layer
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            btnGiris = new Guna.UI2.WinForms.Guna2GradientButton();
            lblKayit = new LinkLabel();
            lblSifre = new LinkLabel();
            ToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(47, 135);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(316, 180);
            label1.TabIndex = 22;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 10;
            txtPassword.CustomizableEdges = customizableEdges1;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(105, 437);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PlaceholderText = "Şifrenizi Giriniz";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtPassword.Size = new Size(195, 36);
            txtPassword.TabIndex = 17;
            // 
            // txtMail
            // 
            txtMail.BorderRadius = 10;
            txtMail.CustomizableEdges = customizableEdges3;
            txtMail.DefaultText = "";
            txtMail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.ForeColor = Color.Black;
            txtMail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMail.Location = new Point(105, 338);
            txtMail.Name = "txtMail";
            txtMail.PasswordChar = '\0';
            txtMail.PlaceholderText = "Mail Adresi Giriniz..";
            txtMail.SelectedText = "";
            txtMail.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMail.Size = new Size(195, 36);
            txtMail.TabIndex = 16;
            // 
            // btnGiris
            // 
            btnGiris.BorderColor = SystemColors.Window;
            btnGiris.BorderRadius = 10;
            btnGiris.BorderThickness = 2;
            btnGiris.CustomizableEdges = customizableEdges5;
            btnGiris.DisabledState.BorderColor = Color.DarkGray;
            btnGiris.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGiris.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGiris.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnGiris.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGiris.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(105, 514);
            btnGiris.Name = "btnGiris";
            btnGiris.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnGiris.Size = new Size(195, 45);
            btnGiris.TabIndex = 23;
            btnGiris.Text = "Giriş Yap";
            btnGiris.Click += btnGiris_Click;
            // 
            // lblKayit
            // 
            lblKayit.AutoSize = true;
            lblKayit.LinkColor = Color.White;
            lblKayit.Location = new Point(47, 597);
            lblKayit.Name = "lblKayit";
            lblKayit.Size = new Size(48, 15);
            lblKayit.TabIndex = 25;
            lblKayit.TabStop = true;
            lblKayit.Text = "Kayıt Ol";
            lblKayit.LinkClicked += lblKayit_LinkClicked;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.LinkColor = Color.White;
            lblSifre.Location = new Point(268, 597);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(95, 15);
            lblSifre.TabIndex = 24;
            lblSifre.TabStop = true;
            lblSifre.Text = "Şifremi Unuttum";
            lblSifre.LinkClicked += lblSifre_LinkClicked;
            // 
            // ToggleSwitch
            // 
            ToggleSwitch.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ToggleSwitch.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ToggleSwitch.CheckedState.InnerBorderColor = Color.White;
            ToggleSwitch.CheckedState.InnerColor = Color.White;
            ToggleSwitch.CustomizableEdges = customizableEdges7;
            ToggleSwitch.Location = new Point(188, 479);
            ToggleSwitch.Name = "ToggleSwitch";
            ToggleSwitch.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ToggleSwitch.Size = new Size(35, 25);
            ToggleSwitch.TabIndex = 26;
            ToggleSwitch.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ToggleSwitch.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ToggleSwitch.UncheckedState.InnerBorderColor = Color.White;
            ToggleSwitch.UncheckedState.InnerColor = Color.White;
            ToggleSwitch.CheckedChanged += ToggleSwitch_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(412, 656);
            Controls.Add(ToggleSwitch);
            Controls.Add(lblKayit);
            Controls.Add(lblSifre);
            Controls.Add(btnGiris);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtMail);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2GradientButton btnGiris;
        private LinkLabel lblKayit;
        private LinkLabel lblSifre;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitch;
    }
}