namespace Deneme1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(287, 182);
            button1.Name = "button1";
            button1.Size = new Size(561, 86);
            button1.TabIndex = 0;
            button1.Text = "PERSONEL GİRİŞİ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Segoe UI", 18F);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(287, 320);
            button2.Name = "button2";
            button2.Size = new Size(561, 86);
            button2.TabIndex = 1;
            button2.Text = "MÜŞTERİ GİRİŞİ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Green;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(363, 58);
            label1.Name = "label1";
            label1.Size = new Size(418, 67);
            label1.TabIndex = 2;
            label1.Text = "GÜVEN OTOPARK";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1139, 639);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Login Sayfası";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
    }
}
