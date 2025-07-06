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
            dataGridViewPallets = new DataGridView();
            palletInfoBindingSource1 = new BindingSource(components);
            palletInfoBindingSource = new BindingSource(components);
            boxBindingSource = new BindingSource(components);
            GroupHeader = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            palletIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPallets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPallets
            // 
            dataGridViewPallets.AutoGenerateColumns = false;
            dataGridViewPallets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPallets.Columns.AddRange(new DataGridViewColumn[] { GroupHeader, expirationDateDataGridViewTextBoxColumn, palletIDDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn, volumeDataGridViewTextBoxColumn });
            dataGridViewPallets.DataSource = palletInfoBindingSource1;
            dataGridViewPallets.Location = new Point(319, 92);
            dataGridViewPallets.Name = "dataGridViewPallets";
            dataGridViewPallets.Size = new Size(758, 413);
            dataGridViewPallets.TabIndex = 0;
            dataGridViewPallets.CellContentClick += dataGridViewPallets_CellContentClick_1;
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
            // GroupHeader
            // 
            GroupHeader.DataPropertyName = "GroupHeader";
            GroupHeader.FillWeight = 250F;
            GroupHeader.HeaderText = "Группа";
            GroupHeader.Name = "GroupHeader";
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            // 
            // palletIDDataGridViewTextBoxColumn
            // 
            palletIDDataGridViewTextBoxColumn.DataPropertyName = "PalletID";
            palletIDDataGridViewTextBoxColumn.HeaderText = "ID";
            palletIDDataGridViewTextBoxColumn.Name = "palletIDDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            volumeDataGridViewTextBoxColumn.HeaderText = "Объем";
            volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1180, 699);
            Controls.Add(dataGridViewPallets);
            Name = "ListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мой склад";
            Load += ListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPallets).EndInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)palletInfoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPallets;
        private BindingSource boxBindingSource;
        private BindingSource palletInfoBindingSource;
        private BindingSource palletInfoBindingSource1;
        private DataGridViewTextBoxColumn GroupHeader;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn palletIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
    }
}