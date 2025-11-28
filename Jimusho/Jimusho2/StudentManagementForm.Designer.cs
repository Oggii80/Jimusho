namespace Jimusho2
{
    partial class StudentManagementForm
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
            lblTitle = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblBelt = new Label();
            lblStudents = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtBelt = new TextBox();
            lstStudents = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(341, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(122, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Management";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(41, 74);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(41, 101);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblBelt
            // 
            lblBelt.AutoSize = true;
            lblBelt.Location = new Point(41, 125);
            lblBelt.Name = "lblBelt";
            lblBelt.Size = new Size(59, 15);
            lblBelt.TabIndex = 3;
            lblBelt.Text = "Belt Rank:";
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Location = new Point(590, 74);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(56, 15);
            lblStudents.TabIndex = 4;
            lblStudents.Text = "Students:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(114, 71);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(114, 101);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 6;
            // 
            // txtBelt
            // 
            txtBelt.Location = new Point(114, 130);
            txtBelt.Name = "txtBelt";
            txtBelt.Size = new Size(100, 23);
            txtBelt.TabIndex = 7;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(589, 92);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(120, 94);
            lstStudents.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(41, 177);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(41, 206);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(111, 23);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove Student";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(589, 206);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh List";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // StudentManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lstStudents);
            Controls.Add(txtBelt);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblStudents);
            Controls.Add(lblBelt);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblTitle);
            Name = "StudentManagementForm";
            Text = "Jimusho - Dojo Management Software";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblBelt;
        private Label lblStudents;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtBelt;
        private ListBox lstStudents;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnRefresh;
    }
}
