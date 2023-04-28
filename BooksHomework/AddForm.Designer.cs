namespace BooksHomework
{
    partial class AddForm
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
            btnAdd = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxTitle = new TextBox();
            txtBoxName = new TextBox();
            txtBoxSurname = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(201, 247);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(378, 247);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 77);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Book Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 122);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Writer Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 175);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 1;
            label3.Text = "Writer Surname:";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(178, 74);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(393, 23);
            txtBoxTitle.TabIndex = 2;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(178, 119);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(393, 23);
            txtBoxName.TabIndex = 2;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Location = new Point(178, 172);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(393, 23);
            txtBoxSurname.TabIndex = 2;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(681, 337);
            Controls.Add(txtBoxSurname);
            Controls.Add(txtBoxName);
            Controls.Add(txtBoxTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddForm";
            Text = "Form2";
            Load += AddForm_Load_1;
            Resize += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxTitle;
        private TextBox txtBoxName;
        private TextBox txtBoxSurname;
    }
}