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
            button1 = new Button();
            txtAgain = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtSpeAns = new TextBox();
            label5 = new Label();
            txtSpe = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            txtMail = new TextBox();
            label4 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtBirth = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(139, 328);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 43;
            button1.Text = "Devam Et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAgain
            // 
            txtAgain.Location = new Point(174, 183);
            txtAgain.Name = "txtAgain";
            txtAgain.Size = new Size(120, 23);
            txtAgain.TabIndex = 40;
            // 
            // label10
            // 
            label10.Location = new Point(68, 183);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 39;
            label10.Text = "Şifre Tekrarı";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Location = new Point(68, 270);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 36;
            label9.Text = "Doğum Tarihi";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSpeAns
            // 
            txtSpeAns.Location = new Point(174, 241);
            txtSpeAns.Name = "txtSpeAns";
            txtSpeAns.Size = new Size(120, 23);
            txtSpeAns.TabIndex = 35;
            // 
            // label5
            // 
            label5.Location = new Point(68, 241);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 34;
            label5.Text = "Özel Soru Cevabı";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSpe
            // 
            txtSpe.Location = new Point(174, 212);
            txtSpe.Name = "txtSpe";
            txtSpe.Size = new Size(120, 23);
            txtSpe.TabIndex = 33;
            // 
            // label6
            // 
            label6.Location = new Point(68, 212);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 32;
            label6.Text = "Özel Soru";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(174, 154);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(120, 23);
            txtPassword.TabIndex = 31;
            // 
            // label7
            // 
            label7.Location = new Point(68, 154);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 30;
            label7.Text = "Şifre";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(174, 123);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(120, 23);
            txtMail.TabIndex = 29;
            // 
            // label4
            // 
            label4.Location = new Point(68, 123);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 28;
            label4.Text = "Mail adresi";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(174, 94);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(120, 23);
            txtSurname.TabIndex = 27;
            // 
            // label3
            // 
            label3.Location = new Point(68, 94);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 26;
            label3.Text = "Soyisim";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.Location = new Point(174, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(120, 23);
            txtName.TabIndex = 25;
            // 
            // label2
            // 
            label2.Location = new Point(68, 65);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 24;
            label2.Text = "İsim";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 28);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 23;
            label1.Text = "Kullanıcı Kayıt Ekranı";
            // 
            // dtBirth
            // 
            dtBirth.Location = new Point(174, 270);
            dtBirth.Name = "dtBirth";
            dtBirth.Size = new Size(120, 23);
            dtBirth.TabIndex = 45;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 417);
            Controls.Add(dtBirth);
            Controls.Add(button1);
            Controls.Add(txtAgain);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtSpeAns);
            Controls.Add(label5);
            Controls.Add(txtSpe);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(txtMail);
            Controls.Add(label4);
            Controls.Add(txtSurname);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUpForm";
            Text = "SignUp";
            Load += SignUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox txtAgain;
        private Label label10;
        private Label label9;
        private TextBox txtSpeAns;
        private Label label5;
        private TextBox txtSpe;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private DateTimePicker dtBirth;
    }
}