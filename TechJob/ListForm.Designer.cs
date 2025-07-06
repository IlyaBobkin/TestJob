namespace TechJob
{
    partial class ListForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewPallets = new DataGridView();
            groupHeaderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            palletIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            widthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            depthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            palletInfoBindingSource4 = new BindingSource(components);
            palletInfoBindingSource3 = new BindingSource(components);
            palletInfoBindingSource1 = new BindingSource(components);
            palletInfoBindingSource = new BindingSource(components);
            boxBindingSource = new BindingSource(components);
            label1 = new Label();
            button6 = new Button();
            palletInfoBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPallets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPallets
            // 
            dataGridViewPallets.AllowUserToAddRows = false;
            dataGridViewPallets.AllowUserToDeleteRows = false;
            dataGridViewPallets.AllowUserToOrderColumns = true;
            dataGridViewPallets.AllowUserToResizeRows = false;
            dataGridViewPallets.AutoGenerateColumns = false;
            dataGridViewPallets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPallets.BackgroundColor = Color.Gainsboro;
            dataGridViewPallets.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPallets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPallets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPallets.Columns.AddRange(new DataGridViewColumn[] { groupHeaderDataGridViewTextBoxColumn, palletIDDataGridViewTextBoxColumn, widthDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, depthDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn, volumeDataGridViewTextBoxColumn, expirationDateDataGridViewTextBoxColumn });
            dataGridViewPallets.DataSource = palletInfoBindingSource4;
            dataGridViewPallets.ImeMode = ImeMode.NoControl;
            dataGridViewPallets.Location = new Point(12, 109);
            dataGridViewPallets.Name = "dataGridViewPallets";
            dataGridViewPallets.ReadOnly = true;
            dataGridViewPallets.Size = new Size(698, 403);
            dataGridViewPallets.TabIndex = 0;
            dataGridViewPallets.CellContentClick += dataGridViewPallets_CellContentClick_1;
            dataGridViewPallets.RowPrePaint += dataGridViewPallets_RowPrePaint;
            // 
            // groupHeaderDataGridViewTextBoxColumn
            // 
            groupHeaderDataGridViewTextBoxColumn.DataPropertyName = "GroupHeader";
            groupHeaderDataGridViewTextBoxColumn.HeaderText = "Группа";
            groupHeaderDataGridViewTextBoxColumn.Name = "groupHeaderDataGridViewTextBoxColumn";
            groupHeaderDataGridViewTextBoxColumn.ReadOnly = true;
            groupHeaderDataGridViewTextBoxColumn.Width = 71;
            // 
            // palletIDDataGridViewTextBoxColumn
            // 
            palletIDDataGridViewTextBoxColumn.DataPropertyName = "PalletID";
            palletIDDataGridViewTextBoxColumn.HeaderText = "id";
            palletIDDataGridViewTextBoxColumn.Name = "palletIDDataGridViewTextBoxColumn";
            palletIDDataGridViewTextBoxColumn.ReadOnly = true;
            palletIDDataGridViewTextBoxColumn.Width = 42;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            widthDataGridViewTextBoxColumn.HeaderText = "Ширина";
            widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            widthDataGridViewTextBoxColumn.ReadOnly = true;
            widthDataGridViewTextBoxColumn.Width = 77;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn.HeaderText = "Высота";
            heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            heightDataGridViewTextBoxColumn.ReadOnly = true;
            heightDataGridViewTextBoxColumn.Width = 72;
            // 
            // depthDataGridViewTextBoxColumn
            // 
            depthDataGridViewTextBoxColumn.DataPropertyName = "Depth";
            depthDataGridViewTextBoxColumn.HeaderText = "Глубина";
            depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            depthDataGridViewTextBoxColumn.ReadOnly = true;
            depthDataGridViewTextBoxColumn.Width = 78;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            weightDataGridViewTextBoxColumn.ReadOnly = true;
            weightDataGridViewTextBoxColumn.Width = 51;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            volumeDataGridViewTextBoxColumn.HeaderText = "Объем";
            volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            volumeDataGridViewTextBoxColumn.ReadOnly = true;
            volumeDataGridViewTextBoxColumn.Width = 70;
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.HeaderText = "Годность до";
            expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            expirationDateDataGridViewTextBoxColumn.Width = 98;
            // 
            // palletInfoBindingSource4
            // 
            palletInfoBindingSource4.DataSource = typeof(PalletInfo);
            // 
            // palletInfoBindingSource3
            // 
            palletInfoBindingSource3.DataSource = typeof(PalletInfo);
            // 
            // palletInfoBindingSource1
            // 
            palletInfoBindingSource1.DataSource = typeof(PalletInfo);
            // 
            // palletInfoBindingSource
            // 
            palletInfoBindingSource.DataSource = typeof(PalletInfo);
            // 
            // boxBindingSource
            // 
            boxBindingSource.DataSource = typeof(Box);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(292, 49);
            label1.Name = "label1";
            label1.Size = new Size(164, 41);
            label1.TabIndex = 2;
            label1.Text = "Мой склад";
            // 
            // button6
            // 
            button6.BackColor = Color.LightCoral;
            button6.Font = new Font("Segoe UI", 16F);
            button6.Location = new Point(247, 547);
            button6.Name = "button6";
            button6.Size = new Size(260, 49);
            button6.TabIndex = 3;
            button6.Text = "Назад";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // palletInfoBindingSource2
            // 
            palletInfoBindingSource2.DataSource = typeof(PalletInfo);
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(722, 639);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(dataGridViewPallets);
            Name = "ListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мой склад";
            Load += ListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPallets).EndInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPallets;
        private BindingSource boxBindingSource;
        private BindingSource palletInfoBindingSource;
        private BindingSource palletInfoBindingSource1;
        private Label label1;
        private Button button6;
        private BindingSource palletInfoBindingSource2;
        private BindingSource palletInfoBindingSource3;
        private DataGridViewTextBoxColumn groupHeaderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn palletIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private BindingSource palletInfoBindingSource4;
    }
}