namespace Deneme1
{
    partial class Form2
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(384, 47);
            label1.Name = "label1";
            label1.Size = new Size(360, 67);
            label1.TabIndex = 0;
            label1.Text = "Personel Ekranı";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(282, 148);
            button1.Name = "button1";
            button1.Size = new Size(576, 74);
            button1.TabIndex = 1;
            button1.Text = "ARAÇ KAYIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F);
            button2.Location = new Point(282, 244);
            button2.Name = "button2";
            button2.Size = new Size(576, 74);
            button2.TabIndex = 2;
            button2.Text = "ARAÇ ÇIKIŞ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F);
            button3.Location = new Point(282, 324);
            button3.Name = "button3";
            button3.Size = new Size(576, 74);
            button3.TabIndex = 3;
            button3.Text = "OTOPARK DURUMU SORGULAMA";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F);
            button4.Location = new Point(282, 404);
            button4.Name = "button4";
            button4.Size = new Size(576, 74);
            button4.TabIndex = 4;
            button4.Text = "OTOPARK HASILATI";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 639);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}