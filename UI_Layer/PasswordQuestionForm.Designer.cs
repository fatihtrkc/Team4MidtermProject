namespace UI_Layer
{
    partial class PasswordQuestionForm
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
            txtCevap = new TextBox();
            lblAnswer = new Label();
            lblOzelSoru = new Label();
            txtEmail = new TextBox();
            lblMail = new Label();
            button2 = new Button();
            txtSurname = new TextBox();
            lblSurname = new Label();
            txtName = new TextBox();
            lblName = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(152, 481);
            button1.Name = "button1";
            button1.Size = new Size(118, 30);
            button1.TabIndex = 21;
            button1.Text = "Şifreyi Sıfırla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCevap
            // 
            txtCevap.Location = new Point(173, 443);
            txtCevap.Name = "txtCevap";
            txtCevap.Size = new Size(128, 23);
            txtCevap.TabIndex = 20;
            // 
            // lblAnswer
            // 
            lblAnswer.Location = new Point(61, 442);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(100, 23);
            lblAnswer.TabIndex = 19;
            lblAnswer.Text = "Özel Soru Cevabı";
            lblAnswer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOzelSoru
            // 
            lblOzelSoru.Location = new Point(75, 406);
            lblOzelSoru.Name = "lblOzelSoru";
            lblOzelSoru.Size = new Size(226, 23);
            lblOzelSoru.TabIndex = 18;
            lblOzelSoru.Text = "Özel Soru";
            lblOzelSoru.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 22;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(42, 134);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(69, 15);
            lblMail.TabIndex = 23;
            lblMail.Text = "Mail Adresi:";
            // 
            // button2
            // 
            button2.Location = new Point(139, 158);
            button2.Name = "button2";
            button2.Size = new Size(126, 23);
            button2.TabIndex = 24;
            button2.Text = "Devam";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(138, 366);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(163, 23);
            txtSurname.TabIndex = 36;
            // 
            // lblSurname
            // 
            lblSurname.Location = new Point(61, 366);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(76, 23);
            lblSurname.TabIndex = 35;
            lblSurname.Text = "Soyisim";
            lblSurname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 338);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 23);
            txtName.TabIndex = 34;
            // 
            // lblName
            // 
            lblName.Location = new Point(61, 337);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 23);
            lblName.TabIndex = 33;
            lblName.Text = "İsim";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 571);
            Controls.Add(txtSurname);
            Controls.Add(lblSurname);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(button2);
            Controls.Add(lblMail);
            Controls.Add(txtEmail);
            Controls.Add(button1);
            Controls.Add(txtCevap);
            Controls.Add(lblAnswer);
            Controls.Add(lblOzelSoru);
            Name = "PasswordQuestionForm";
            Text = "PasswordQuestion";
            Load += PasswordQuestionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtCevap;
        private Label lblAnswer;
        private Label lblOzelSoru;
        private TextBox txtEmail;
        private Label lblMail;
        private Button button2;
        private TextBox txtSurname;
        private Label lblSurname;
        private TextBox txtName;
        private Label lblName;
    }
}