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
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(112, 121);
            button1.Name = "button1";
            button1.Size = new Size(260, 50);
            button1.TabIndex = 0;
            button1.Text = "Сгенерировать товары";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(153, 63);
            label1.Name = "label1";
            label1.Size = new Size(164, 41);
            label1.TabIndex = 1;
            label1.Text = "Мой склад";
            label1.Click += label1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightCoral;
            button6.Font = new Font("Segoe UI", 16F);
            button6.Location = new Point(112, 177);
            button6.Name = "button6";
            button6.Size = new Size(260, 49);
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
            Controls.Add(button6);
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
        private Button button6;
    }
}
