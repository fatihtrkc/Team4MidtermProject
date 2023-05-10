namespace UI_Layer
{
    partial class UserInformationForm
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
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox10 = new TextBox();
            label11 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(56, 81);
            label1.Name = "label1";
            label1.Size = new Size(169, 23);
            label1.TabIndex = 41;
            label1.Text = "Adı soyadı hoş geldin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(148, 298);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(79, 15);
            linkLabel2.TabIndex = 40;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Şifre Güncelle";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(57, 298);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 15);
            linkLabel1.TabIndex = 39;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kişisel Bilgiler";
            // 
            // button1
            // 
            button1.Location = new Point(84, 212);
            button1.Name = "button1";
            button1.Size = new Size(123, 45);
            button1.TabIndex = 38;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Location = new Point(135, 140);
            numericUpDown1.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 130, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(92, 23);
            numericUpDown1.TabIndex = 37;
            numericUpDown1.Value = new decimal(new int[] { 130, 0, 0, 0 });
            // 
            // textBox10
            // 
            textBox10.Location = new Point(135, 169);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(92, 23);
            textBox10.TabIndex = 36;
            // 
            // label11
            // 
            label11.Location = new Point(58, 169);
            label11.Name = "label11";
            label11.Size = new Size(62, 23);
            label11.TabIndex = 35;
            label11.Text = "Kilo";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(58, 140);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 34;
            label8.Text = "Boy";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 469);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox10);
            Controls.Add(label11);
            Controls.Add(label8);
            Name = "UserInformation";
            Text = "UserInformation";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox10;
        private Label label11;
        private Label label8;
    }
}