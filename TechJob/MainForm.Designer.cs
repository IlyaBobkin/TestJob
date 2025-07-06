namespace TechJob
{
    partial class MainForm
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
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(208, 96);
            button1.Name = "button1";
            button1.Size = new Size(192, 35);
            button1.TabIndex = 0;
            button1.Text = "Генерация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 41);
            label1.TabIndex = 1;
            label1.Text = "Мой склад";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI", 16F);
            button2.Location = new Point(26, 150);
            button2.Name = "button2";
            button2.Size = new Size(173, 39);
            button2.TabIndex = 0;
            button2.Text = "Прочитать из:";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16F);
            button3.Location = new Point(208, 150);
            button3.Name = "button3";
            button3.Size = new Size(93, 39);
            button3.TabIndex = 0;
            button3.Text = "Файл";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16F);
            button4.Location = new Point(307, 150);
            button4.Name = "button4";
            button4.Size = new Size(93, 39);
            button4.TabIndex = 0;
            button4.Text = "БД";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 16F);
            button5.Location = new Point(208, 205);
            button5.Name = "button5";
            button5.Size = new Size(192, 35);
            button5.TabIndex = 0;
            button5.Text = "Ручной ввод";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightCoral;
            button6.Font = new Font("Segoe UI", 16F);
            button6.Location = new Point(239, 282);
            button6.Name = "button6";
            button6.Size = new Size(192, 45);
            button6.TabIndex = 0;
            button6.Text = "Выход";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(443, 339);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мой склад";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
