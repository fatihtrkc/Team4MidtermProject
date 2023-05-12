namespace UI_Layer
{
    partial class NewPassword
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
            txtOldPassword = new TextBox();
            txtNewPassowrd = new TextBox();
            txtNewAgain = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGuncelle = new Button();
            SuspendLayout();
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(177, 63);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(163, 23);
            txtOldPassword.TabIndex = 0;
            // 
            // txtNewPassowrd
            // 
            txtNewPassowrd.Location = new Point(177, 114);
            txtNewPassowrd.Name = "txtNewPassowrd";
            txtNewPassowrd.Size = new Size(163, 23);
            txtNewPassowrd.TabIndex = 1;
            // 
            // txtNewAgain
            // 
            txtNewAgain.Location = new Point(177, 167);
            txtNewAgain.Name = "txtNewAgain";
            txtNewAgain.Size = new Size(163, 23);
            txtNewAgain.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(66, 64);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 3;
            label1.Text = "Eski Şifreniz:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(66, 115);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 4;
            label2.Text = "Yeni Şifreniz:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(66, 167);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 5;
            label3.Text = "Yeni Şifreyi Tekrar:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(127, 218);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(170, 41);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // NewPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 321);
            Controls.Add(btnGuncelle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewAgain);
            Controls.Add(txtNewPassowrd);
            Controls.Add(txtOldPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewPassword";
            Text = "NewPassword";
            Load += NewPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOldPassword;
        private TextBox txtNewPassowrd;
        private TextBox txtNewAgain;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuncelle;
    }
}