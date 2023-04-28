namespace BooksHomework
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
            txtBoxSearch = new TextBox();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            label1 = new Label();
            lblDisplayed = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnModify = new Button();
            btnRefresh = new Button();
            lblInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxSearch.Location = new Point(55, 53);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(514, 23);
            txtBoxSearch.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(685, 284);
            dataGridView1.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(608, 53);
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 20);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 6;
            label1.Text = "Displayed Total of";
            // 
            // lblDisplayed
            // 
            lblDisplayed.AutoSize = true;
            lblDisplayed.BackColor = SystemColors.ActiveBorder;
            lblDisplayed.BorderStyle = BorderStyle.FixedSingle;
            lblDisplayed.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayed.Location = new Point(193, 17);
            lblDisplayed.Name = "lblDisplayed";
            lblDisplayed.Size = new Size(24, 27);
            lblDisplayed.TabIndex = 6;
            lblDisplayed.Text = "0";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Right;
            btnAdd.Location = new Point(774, 235);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Book";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.Location = new Point(774, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.Anchor = AnchorStyles.Right;
            btnModify.Location = new Point(774, 314);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(99, 23);
            btnModify.TabIndex = 7;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Right;
            btnRefresh.Location = new Point(774, 146);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(99, 50);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.Location = new Point(77, 192);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(635, 37);
            lblInfo.TabIndex = 9;
            lblInfo.Text = "Please wait a few seconds. The data will be updated.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(903, 418);
            Controls.Add(lblInfo);
            Controls.Add(btnRefresh);
            Controls.Add(btnModify);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblDisplayed);
            Controls.Add(label1);
            Controls.Add(txtBoxSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Name = "MainForm";
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
        private Button btnAdd;
        private Button btnDelete;
        private Button btnModify;
        private Button btnRefresh;
        private Label lblInfo;
    }
}