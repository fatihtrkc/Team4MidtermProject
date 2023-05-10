namespace UI_Layer
{
    partial class ResetPasswordForm
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
            label1 = new Label();
            button1 = new Button();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(116, 80);
            label1.Name = "label1";
            label1.Size = new Size(141, 26);
            label1.TabIndex = 30;
            label1.Text = "Şifre Oluşturma Ekranı";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(128, 214);
            button1.Name = "button1";
            button1.Size = new Size(118, 30);
            button1.TabIndex = 29;
            button1.Text = "Yeni Şifre Oluştur";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(149, 161);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(120, 23);
            textBox9.TabIndex = 28;
            // 
            // label10
            // 
            label10.Location = new Point(43, 161);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 27;
            label10.Text = "Şifre Tekrarı";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(149, 132);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 23);
            textBox6.TabIndex = 26;
            // 
            // label7
            // 
            label7.Location = new Point(43, 132);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 25;
            label7.Text = "Şifre";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 373);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox9);
            Controls.Add(label10);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Name = "ResetPassword";
            Text = "ResetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox6;
        private Label label7;
    }
}