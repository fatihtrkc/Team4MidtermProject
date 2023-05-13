namespace UI_Layer
{
    partial class AdminChangeSituation
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
            lviewUsers = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            dtCreat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lviewUsers
            // 
            lviewUsers.BackColor = Color.CornflowerBlue;
            lviewUsers.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader1, columnHeader7 });
            lviewUsers.ForeColor = SystemColors.Window;
            lviewUsers.GridLines = true;
            lviewUsers.Location = new Point(124, 266);
            lviewUsers.Name = "lviewUsers";
            lviewUsers.Size = new Size(476, 309);
            lviewUsers.TabIndex = 75;
            lviewUsers.UseCompatibleStateImageBehavior = false;
            lviewUsers.View = View.Details;
            lviewUsers.SelectedIndexChanged += lviewUsers_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Kullanıcı Adı Soyadı";
            columnHeader6.Width = 200;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mail Adresi";
            columnHeader1.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Durumu";
            columnHeader7.Width = 70;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Transparent;
            txtName.BorderColor = SystemColors.Window;
            txtName.BorderRadius = 10;
            txtName.BorderThickness = 2;
            txtName.CustomizableEdges = customizableEdges1;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.Enabled = false;
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(273, 105);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtName.Size = new Size(200, 36);
            txtName.TabIndex = 78;
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.Transparent;
            txtMail.BorderColor = SystemColors.Window;
            txtMail.BorderRadius = 10;
            txtMail.BorderThickness = 2;
            txtMail.CustomizableEdges = customizableEdges3;
            txtMail.DefaultText = "";
            txtMail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMail.Enabled = false;
            txtMail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMail.Location = new Point(273, 159);
            txtMail.MaxLength = 50;
            txtMail.Name = "txtMail";
            txtMail.PasswordChar = '\0';
            txtMail.PlaceholderText = "";
            txtMail.SelectedText = "";
            txtMail.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMail.Size = new Size(200, 36);
            txtMail.TabIndex = 79;
            // 
            // dtCreat
            // 
            dtCreat.BorderColor = Color.White;
            dtCreat.BorderRadius = 10;
            dtCreat.BorderThickness = 2;
            dtCreat.Checked = true;
            dtCreat.CustomizableEdges = customizableEdges5;
            dtCreat.Enabled = false;
            dtCreat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtCreat.Format = DateTimePickerFormat.Long;
            dtCreat.Location = new Point(274, 213);
            dtCreat.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtCreat.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtCreat.Name = "dtCreat";
            dtCreat.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtCreat.Size = new Size(199, 36);
            dtCreat.TabIndex = 80;
            dtCreat.Value = new DateTime(2023, 5, 12, 17, 24, 31, 362);
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(124, 105);
            label1.Name = "label1";
            label1.Size = new Size(100, 36);
            label1.TabIndex = 81;
            label1.Text = "Adı Soyadı:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(124, 159);
            label2.Name = "label2";
            label2.Size = new Size(100, 36);
            label2.TabIndex = 82;
            label2.Text = "Mail Adresi:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(124, 213);
            label3.Name = "label3";
            label3.Size = new Size(100, 36);
            label3.TabIndex = 83;
            label3.Text = "Kayıt Tarihi:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderColor = SystemColors.Window;
            btnUpdate.BorderRadius = 15;
            btnUpdate.BorderThickness = 2;
            btnUpdate.CustomizableEdges = customizableEdges7;
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(479, 213);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnUpdate.Size = new Size(115, 36);
            btnUpdate.TabIndex = 84;
            btnUpdate.Text = "Durumu Değiştir";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // AdminChangeSituation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(709, 658);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtCreat);
            Controls.Add(txtMail);
            Controls.Add(txtName);
            Controls.Add(lviewUsers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminChangeSituation";
            Text = "AdminChangeSituation";
            Load += AdminChangeSituation_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lviewUsers;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader7;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCreat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
    }
}