namespace StudentManagement
{
    partial class Manager
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
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            rollTextBox = new TextBox();
            label3 = new Label();
            emailTextBox = new TextBox();
            ageTextBox = new TextBox();
            label4 = new Label();
            dataGridView = new DataGridView();
            insertButton = new Button();
            updateButton = new Button();
            removeButton = new Button();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 48);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(29, 68);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(156, 25);
            nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 120);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 2;
            label2.Text = "Roll Number";
            // 
            // rollTextBox
            // 
            rollTextBox.Location = new Point(29, 149);
            rollTextBox.Name = "rollTextBox";
            rollTextBox.Size = new Size(156, 25);
            rollTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 264);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(29, 284);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(156, 25);
            emailTextBox.TabIndex = 5;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(29, 216);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(156, 25);
            ageTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 196);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 6;
            label4.Text = "Age";
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ButtonFace;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(235, 48);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(508, 359);
            dataGridView.TabIndex = 8;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.Gold;
            insertButton.Location = new Point(29, 337);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(75, 32);
            insertButton.TabIndex = 9;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(255, 128, 0);
            updateButton.Location = new Point(110, 337);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 32);
            updateButton.TabIndex = 10;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.FromArgb(255, 128, 128);
            removeButton.Location = new Point(29, 375);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 32);
            removeButton.TabIndex = 11;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.RosyBrown;
            clearButton.Location = new Point(110, 375);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 33);
            clearButton.TabIndex = 12;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(clearButton);
            Controls.Add(removeButton);
            Controls.Add(updateButton);
            Controls.Add(insertButton);
            Controls.Add(dataGridView);
            Controls.Add(ageTextBox);
            Controls.Add(label4);
            Controls.Add(emailTextBox);
            Controls.Add(label3);
            Controls.Add(rollTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management";
            Load += Manager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private TextBox rollTextBox;
        private Label label3;
        private TextBox emailTextBox;
        private TextBox ageTextBox;
        private Label label4;
        private DataGridView dataGridView;
        private Button insertButton;
        private Button updateButton;
        private Button removeButton;
        private Button clearButton;
    }
}
