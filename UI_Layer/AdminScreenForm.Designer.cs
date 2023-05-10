namespace UI_Layer
{
    partial class AdminScreenForm
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
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(165, 105);
            button1.Name = "button1";
            button1.Size = new Size(129, 39);
            button1.TabIndex = 0;
            button1.Text = "Kategori ekleme";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(165, 164);
            button2.Name = "button2";
            button2.Size = new Size(129, 39);
            button2.TabIndex = 1;
            button2.Text = "yemek ekleme";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(165, 243);
            button3.Name = "button3";
            button3.Size = new Size(129, 39);
            button3.TabIndex = 2;
            button3.Text = "kullanıcı durumlarını kontrol etme";
            button3.UseVisualStyleBackColor = true;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 390);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AdminScreen";
            Text = "AdminScreen";
            Load += AdminScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}