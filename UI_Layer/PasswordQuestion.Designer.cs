namespace UI_Layer
{
    partial class PasswordQuestion
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
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(146, 233);
            button1.Name = "button1";
            button1.Size = new Size(118, 30);
            button1.TabIndex = 21;
            button1.Text = "Şifreyi Sıfırla";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(167, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(120, 23);
            textBox4.TabIndex = 20;
            // 
            // label5
            // 
            label5.Location = new Point(61, 184);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 19;
            label5.Text = "Özel Soru Cevabı";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(61, 132);
            label6.Name = "label6";
            label6.Size = new Size(226, 23);
            label6.TabIndex = 18;
            label6.Text = "Özel Soru";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 391);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "PasswordQuestion";
            Text = "PasswordQuestion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
    }
}