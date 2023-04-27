namespace BooksHomework
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
            txtBoxSearch = new TextBox();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            label1 = new Label();
            lblDisplayed = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxSearch.Location = new Point(55, 53);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(502, 23);
            txtBoxSearch.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(671, 287);
            dataGridView1.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(594, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(132, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 6;
            label1.Text = "Displayed Total of";
            // 
            // lblDisplayed
            // 
            lblDisplayed.AutoSize = true;
            lblDisplayed.BackColor = SystemColors.ActiveBorder;
            lblDisplayed.BorderStyle = BorderStyle.FixedSingle;
            lblDisplayed.Location = new Point(163, 20);
            lblDisplayed.Name = "lblDisplayed";
            lblDisplayed.Size = new Size(15, 17);
            lblDisplayed.TabIndex = 6;
            lblDisplayed.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(798, 421);
            Controls.Add(lblDisplayed);
            Controls.Add(label1);
            Controls.Add(txtBoxSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Name = "Form1";
            Text = "Books";
            Load += Form1_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxSearch;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private Label label1;
        private Label lblDisplayed;
    }
}