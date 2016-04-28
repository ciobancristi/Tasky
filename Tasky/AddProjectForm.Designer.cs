namespace Tasky
{
    partial class AddProjectForm
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
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.tasksLabel = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.projectNameTexBox = new System.Windows.Forms.TextBox();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.addProjectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.taskCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.userCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(95, 64);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(35, 13);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Name";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(97, 108);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(33, 13);
            this.clientNameLabel.TabIndex = 1;
            this.clientNameLabel.Text = "Client";
            // 
            // tasksLabel
            // 
            this.tasksLabel.AutoSize = true;
            this.tasksLabel.Location = new System.Drawing.Point(94, 151);
            this.tasksLabel.Name = "tasksLabel";
            this.tasksLabel.Size = new System.Drawing.Size(36, 13);
            this.tasksLabel.TabIndex = 3;
            this.tasksLabel.Text = "Tasks";
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Location = new System.Drawing.Point(96, 269);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(34, 13);
            this.usersLabel.TabIndex = 4;
            this.usersLabel.Text = "Users";
            // 
            // projectNameTexBox
            // 
            this.projectNameTexBox.Location = new System.Drawing.Point(144, 64);
            this.projectNameTexBox.Name = "projectNameTexBox";
            this.projectNameTexBox.Size = new System.Drawing.Size(164, 20);
            this.projectNameTexBox.TabIndex = 5;
            // 
            // clientTextBox
            // 
            this.clientTextBox.Location = new System.Drawing.Point(144, 105);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.Size = new System.Drawing.Size(164, 20);
            this.clientTextBox.TabIndex = 6;
            // 
            // addProjectButton
            // 
            this.addProjectButton.Location = new System.Drawing.Point(97, 435);
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Size = new System.Drawing.Size(75, 23);
            this.addProjectButton.TabIndex = 8;
            this.addProjectButton.Text = "Add Project";
            this.addProjectButton.UseVisualStyleBackColor = true;
            this.addProjectButton.Click += new System.EventHandler(this.addProjectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(245, 435);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // taskCheckedListBox
            // 
            this.taskCheckedListBox.FormattingEnabled = true;
            this.taskCheckedListBox.Location = new System.Drawing.Point(144, 151);
            this.taskCheckedListBox.Name = "taskCheckedListBox";
            this.taskCheckedListBox.Size = new System.Drawing.Size(164, 94);
            this.taskCheckedListBox.TabIndex = 10;
            // 
            // userCheckedListBox
            // 
            this.userCheckedListBox.FormattingEnabled = true;
            this.userCheckedListBox.Location = new System.Drawing.Point(144, 269);
            this.userCheckedListBox.Name = "userCheckedListBox";
            this.userCheckedListBox.Size = new System.Drawing.Size(164, 94);
            this.userCheckedListBox.TabIndex = 11;
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 555);
            this.Controls.Add(this.userCheckedListBox);
            this.Controls.Add(this.taskCheckedListBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addProjectButton);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.projectNameTexBox);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.tasksLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.projectNameLabel);
            this.Name = "AddProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label tasksLabel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.TextBox projectNameTexBox;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.Button addProjectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckedListBox taskCheckedListBox;
        private System.Windows.Forms.CheckedListBox userCheckedListBox;
    }
}