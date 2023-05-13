namespace UI_Layer
{
    partial class UserDetails
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
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            txtSurname = new Guna.UI2.WinForms.Guna2TextBox();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            dtBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BorderRadius = 10;
            txtName.CustomizableEdges = customizableEdges1;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(239, 105);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtName.Size = new Size(132, 32);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.BorderRadius = 10;
            txtSurname.CustomizableEdges = customizableEdges3;
            txtSurname.DefaultText = "";
            txtSurname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSurname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSurname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSurname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSurname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSurname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSurname.Location = new Point(239, 166);
            txtSurname.Name = "txtSurname";
            txtSurname.PasswordChar = '\0';
            txtSurname.PlaceholderText = "";
            txtSurname.SelectedText = "";
            txtSurname.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSurname.Size = new Size(132, 32);
            txtSurname.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 10;
            btnUpdate.CustomizableEdges = customizableEdges5;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(169, 310);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnUpdate.Size = new Size(164, 43);
            btnUpdate.TabIndex = 67;
            btnUpdate.Text = "Güncelle";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dtBirth
            // 
            dtBirth.BorderColor = Color.White;
            dtBirth.BorderRadius = 10;
            dtBirth.BorderThickness = 2;
            dtBirth.Checked = true;
            dtBirth.CustomizableEdges = customizableEdges7;
            dtBirth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtBirth.Format = DateTimePickerFormat.Short;
            dtBirth.Location = new Point(239, 236);
            dtBirth.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtBirth.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtBirth.Name = "dtBirth";
            dtBirth.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtBirth.Size = new Size(132, 36);
            dtBirth.TabIndex = 68;
            dtBirth.Value = new DateTime(2023, 5, 13, 0, 31, 6, 809);
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(131, 101);
            label3.Name = "label3";
            label3.Size = new Size(67, 36);
            label3.TabIndex = 69;
            label3.Text = "Ad:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(131, 166);
            label1.Name = "label1";
            label1.Size = new Size(67, 36);
            label1.TabIndex = 70;
            label1.Text = "Soyad:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(131, 236);
            label2.Name = "label2";
            label2.Size = new Size(102, 36);
            label2.TabIndex = 71;
            label2.Text = "Doğum Tarihi";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(505, 477);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dtBirth);
            Controls.Add(btnUpdate);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDetails";
            Text = "UserDetails";
            Load += UserDetails_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtSurname;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtBirth;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}