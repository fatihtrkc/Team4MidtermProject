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
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            Button1 = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(5, 66);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(403, 146);
            label1.TabIndex = 22;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(35, 500);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 15);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kayıt Ol";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(273, 500);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(95, 15);
            linkLabel2.TabIndex = 20;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Şifremi Unuttum";
            // 
            // Button1
            // 
            Button1.CustomizableEdges = customizableEdges1;
            Button1.DisabledState.BorderColor = Color.DarkGray;
            Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(105, 426);
            Button1.Name = "Button1";
            Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Button1.Size = new Size(195, 45);
            Button1.TabIndex = 19;
            Button1.Text = "Giriş Yap";
            Button1.Click += Button1_Click_1;
            // 
            // guna2ToggleSwitch1
            // 
            guna2ToggleSwitch1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ToggleSwitch1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2ToggleSwitch1.CheckedState.InnerBorderColor = Color.White;
            guna2ToggleSwitch1.CheckedState.InnerColor = Color.White;
            guna2ToggleSwitch1.CustomizableEdges = customizableEdges3;
            guna2ToggleSwitch1.Location = new Point(311, 356);
            guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            guna2ToggleSwitch1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ToggleSwitch1.Size = new Size(35, 25);
            guna2ToggleSwitch1.TabIndex = 18;
            guna2ToggleSwitch1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2ToggleSwitch1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            guna2ToggleSwitch1.UncheckedState.InnerBorderColor = Color.White;
            guna2ToggleSwitch1.UncheckedState.InnerColor = Color.White;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 10;
            txtPassword.CustomizableEdges = customizableEdges5;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(105, 351);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PlaceholderText = "Şifrenizi Giriniz";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassword.Size = new Size(195, 36);
            txtPassword.TabIndex = 17;
            // 
            // txtMail
            // 
            txtMail.BorderRadius = 10;
            txtMail.CustomizableEdges = customizableEdges7;
            txtMail.DefaultText = "";
            txtMail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMail.Location = new Point(105, 252);
            txtMail.Name = "txtMail";
            txtMail.PasswordChar = '\0';
            txtMail.PlaceholderText = "Mail Adresi Giriniz..";
            txtMail.SelectedText = "";
            txtMail.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtMail.Size = new Size(195, 36);
            txtMail.TabIndex = 16;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(412, 580);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(linkLabel2);
            Controls.Add(Button1);
            Controls.Add(guna2ToggleSwitch1);
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
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Guna.UI2.WinForms.Guna2GradientButton Button1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
    }
}